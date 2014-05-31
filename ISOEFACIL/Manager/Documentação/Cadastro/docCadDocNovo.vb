Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports C1.Win.C1FlexGrid
Imports Microsoft.Office.Interop.Word
Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop

Public Class docCadDocNovo

#Region "VARIAVEIS"

    Private revisao As String = String.Empty
    Private situacao As String = String.Empty
    Private format As Integer = 0
    Private arquivo As String = String.Empty
    '// Identificação de qual atividade de encontra: 
    '// [E]laboração – [C]onsenso – [A]provação - [P]ublicação
    Private _E As Integer = 0
    Private _C As Integer = 0
    Private _A As Integer = 0
    Private _P As Integer = 0

    Private DOC() As Byte
    Private tpDoc As String = String.Empty

    ''' Variavel global que contera o valor passado
    Private isEdit As Boolean = False
    Public idDoc As String
    Public verif As Boolean = False

    ''' ANEXO
    Private ANEXO() As Byte
    Public Modulo As String = ""
    Public Tela As String = ""

    ''' Pega Id 
    Public WriteOnly Property Documentos() As String
        Set(ByVal value As String)
            Me.idDoc = value
        End Set
    End Property

#End Region

#Region "POPULA COMBOS"

#Region "Tipos de Documentos"
    Sub CarregaComboInputTipoDoc()
        Dim dtb1 As DataTable = Manager.Util.getDataTable("SELECT ID_DOCUMENTO_CONFIG_TP_DOCUMENTO AS ID, IDENTIFICACAO + '-' + NOME AS IDENTIFICACAO FROM DOCUMENTO_CONFIG_TP_DOCUMENTO")
        Dim dtr1 As DataRow = dtb1.NewRow
        dtr1("IDENTIFICACAO") = ""

        dtb1.Rows.InsertAt(dtr1, 0)
        dtb1.AcceptChanges()
        With cmbInputTipoDoc
            .DataSource = dtb1
            .DisplayMember = "IDENTIFICACAO"
            .ValueMember = "ID"
        End With
    End Sub
#End Region

#Region "AREAS"
    Sub CarregaComboArea()
        Dim dtb As DataTable = Manager.Util.getDataTable("SELECT ID_AREAS, CODIGO + ' - ' + DESCRICAO AS NOME FROM AREAS")
        Dim dtr As DataRow = dtb.NewRow
        dtr("NOME") = ""

        dtb.Rows.InsertAt(dtr, 0)
        dtb.AcceptChanges()
        With cmbInputAreaDoc
            .DataSource = dtb
            .DisplayMember = "NOME"
            .ValueMember = "ID_AREAS"
        End With
    End Sub
#End Region

#End Region

    Private Sub docCadDocNovo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaComboInputTipoDoc()
        CarregaComboArea()

    End Sub


    Private Sub cmbInputTipoDoc_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbInputTipoDoc.SelectedValueChanged
        carregaCodigo()
    End Sub

    Private Sub carregaCodigo()

        txtInputCodDoc.Text = String.Empty

        If cmbInputTipoDoc.ValueMember <> "" Then
            lblTpImpre.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            radioRetrato.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            radioPaisagem.Visibility = C1.Win.C1InputPanel.Visibility.Visible

            Dim id As Integer

            If cmbInputTipoDoc.SelectedValue.ToString = String.Empty Then
            Else
                id = cmbInputTipoDoc.SelectedValue
                Try
                    Dim dtb As New DataTable
                    '    Dim area As String = String.Empty
                    Dim tpdoc As String = String.Empty
                    Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_DOCUMENTO_CONFIG_TP_DOCUMENTO_CAD WHERE ID = {0}", id)
                    Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)
                    While dr.Read
                        format = dr("FORMATO")
                        ' area = dr("AREA")
                        tpdoc = dr("TP")
                    End While

                    If format = 0 Then
                        txtInputCodDoc.Enabled = True
                    Else
                        txtInputCodDoc.Enabled = False
                        Dim sq1 As String = String.Empty
                        Dim sq2 As String = String.Empty
                        Dim sq3 As String = String.Empty
                        Dim sql2 As String = String.Format("SELECT * FROM DOCUMENTO_COMP_TP_DOCUMENTO WHERE ID_DOCUMENTO_CONFIG_TP_DOCUMENTO = {0}", id)
                        Dim dr2 As SqlDataReader = Manager.Util.getDataReader(sql2)
                        While dr2.Read
                            sq1 = dr2("SEQUENCIA_01")
                            sq2 = dr2("SEQUENCIA_02")
                            sq3 = dr2("SEQUENCIA_03")
                        End While
                        '1
                        Select Case (sq1)
                            ' Case "Área"
                            '    txtInputCodDoc.Text = txtInputCodDoc.Text + " " + area
                            Case "Tipo Documento"
                                txtInputCodDoc.Text = txtInputCodDoc.Text + " " + tpdoc
                            Case "Número Sequêncial 01"
                                Dim sql3 As String = String.Format("SELECTSELECT ISNULL(MAX(ID_DOCUMENTO_CONTROLE_DOCUMENTO), 0) AS MaxX FROM DOCUMENTO_CONTROLE_DOCUMENTO WHERE ID_DOCUMENTO_CONFIG_TP_DOCUMENTO={0}", id)
                                Dim dr3 As SqlDataReader = Manager.Util.getDataReader(sql3)
                                Dim maxims As Integer = 0
                                While dr3.Read
                                    maxims = dr3("MaxX")
                                End While
                                If maxims = 0 Then
                                    txtInputCodDoc.Text = txtInputCodDoc.Text & " " & "01"
                                Else
                                    If maxims < 9 Then
                                        maxims = maxims + 1
                                        txtInputCodDoc.Text = txtInputCodDoc.Text & " " & "0" & Convert.ToString(maxims)
                                    Else
                                        maxims = maxims + 1
                                        txtInputCodDoc.Text = txtInputCodDoc.Text & " " & Convert.ToString(maxims)
                                    End If
                                End If
                            Case "Número Sequêncial 001"
                                Dim sql3 As String = String.Format("SELECT ISNULL(MAX(ID_DOCUMENTO_CONTROLE_DOCUMENTO), 0) AS MaxX FROM DOCUMENTO_CONTROLE_DOCUMENTO WHERE ID_DOCUMENTO_CONFIG_TP_DOCUMENTO={0}", id)
                                Dim dr3 As SqlDataReader = Manager.Util.getDataReader(sql3)
                                Dim maxims As Integer = 0
                                While dr3.Read
                                    maxims = dr3("MaxX")
                                End While
                                If maxims = 0 Then
                                    txtInputCodDoc.Text = txtInputCodDoc.Text & " " & "01"
                                Else
                                    If maxims < 9 Then
                                        maxims = maxims + 1
                                        txtInputCodDoc.Text = txtInputCodDoc.Text & " " & "0" & Convert.ToString(maxims)
                                    Else
                                        maxims = maxims + 1
                                        txtInputCodDoc.Text = txtInputCodDoc.Text & " " & Convert.ToString(maxims)
                                    End If
                                End If
                        End Select
                        '2
                        Select Case (sq2)
                            ' Case "Área"
                            '    txtInputCodDoc.Text = txtInputCodDoc.Text + " " + area
                            Case "Tipo Documento"
                                txtInputCodDoc.Text = txtInputCodDoc.Text + " " + tpdoc
                            Case "Número Sequêncial 01"
                                Dim sql3 As String = String.Format("SELECT ISNULL(MAX(ID_DOCUMENTO_CONTROLE_DOCUMENTO), 0) AS MaxX FROM DOCUMENTO_CONTROLE_DOCUMENTO WHERE ID_DOCUMENTO_CONFIG_TP_DOCUMENTO={0}", id)
                                Dim dr3 As SqlDataReader = Manager.Util.getDataReader(sql3)
                                Dim maxims As Integer = 0
                                While dr3.Read
                                    maxims = dr3("MaxX")
                                End While
                                If maxims = 0 Then
                                    txtInputCodDoc.Text = txtInputCodDoc.Text & " " & "01"
                                Else
                                    If maxims < 9 Then
                                        maxims = maxims + 1
                                        txtInputCodDoc.Text = txtInputCodDoc.Text & " " & "0" & Convert.ToString(maxims)
                                    Else
                                        maxims = maxims + 1
                                        txtInputCodDoc.Text = txtInputCodDoc.Text & " " & Convert.ToString(maxims)
                                    End If
                                End If
                            Case "Número Sequêncial 001"
                                Dim sql3 As String = String.Format("SELECT ISNULL(MAX(ID_DOCUMENTO_CONTROLE_DOCUMENTO), 0) AS MaxX FROM DOCUMENTO_CONTROLE_DOCUMENTO WHERE ID_DOCUMENTO_CONFIG_TP_DOCUMENTO={0}", id)
                                Dim dr3 As SqlDataReader = Manager.Util.getDataReader(sql3)
                                Dim maxims As Integer = 0
                                While dr3.Read
                                    maxims = dr3("MaxX")
                                End While
                                If maxims = 0 Then
                                    txtInputCodDoc.Text = txtInputCodDoc.Text & " " & "01"
                                Else
                                    If maxims < 9 Then
                                        maxims = maxims + 1
                                        txtInputCodDoc.Text = txtInputCodDoc.Text & " " & "0" & Convert.ToString(maxims)
                                    Else
                                        maxims = maxims + 1
                                        txtInputCodDoc.Text = txtInputCodDoc.Text & " " & Convert.ToString(maxims)
                                    End If
                                End If
                        End Select
                        '3
                        Select Case (sq3)
                            'Case "Área"
                            '   txtInputCodDoc.Text = txtInputCodDoc.Text + " " + area
                            Case "Tipo Documento"
                                txtInputCodDoc.Text = txtInputCodDoc.Text + " " + tpdoc
                            Case "Número Sequêncial 01"
                                Dim sql3 As String = String.Format("SELECT ISNULL(MAX(ID_DOCUMENTO_CONTROLE_DOCUMENTO), 0) AS MaxX FROM DOCUMENTO_CONTROLE_DOCUMENTO WHERE ID_DOCUMENTO_CONFIG_TP_DOCUMENTO={0}", id)
                                Dim dr3 As SqlDataReader = Manager.Util.getDataReader(sql3)
                                Dim maxims As Integer = 0
                                While dr3.Read
                                    maxims = dr3("MaxX")
                                End While
                                If maxims = 0 Then
                                    txtInputCodDoc.Text = txtInputCodDoc.Text & " " & "01"
                                Else
                                    If maxims < 9 Then
                                        maxims = maxims + 1
                                        txtInputCodDoc.Text = txtInputCodDoc.Text & " " & "0" & Convert.ToString(maxims)
                                    Else
                                        maxims = maxims + 1
                                        txtInputCodDoc.Text = txtInputCodDoc.Text & " " & Convert.ToString(maxims)
                                    End If
                                End If
                            Case "Número Sequêncial 001"
                                Dim sql3 As String = String.Format("SELECT ISNULL(MAX(ID_DOCUMENTO_CONTROLE_DOCUMENTO), 0) AS MaxX FROM DOCUMENTO_CONTROLE_DOCUMENTO WHERE ID_DOCUMENTO_CONFIG_TP_DOCUMENTO={0}", id)
                                Dim dr3 As SqlDataReader = Manager.Util.getDataReader(sql3)
                                Dim maxims As Integer = 0
                                While dr3.Read
                                    maxims = dr3("MaxX")
                                End While
                                If maxims = 0 Then
                                    txtInputCodDoc.Text = txtInputCodDoc.Text & " " & "01"
                                Else
                                    If maxims < 9 Then
                                        maxims = maxims + 1
                                        txtInputCodDoc.Text = txtInputCodDoc.Text & " " & "0" & Convert.ToString(maxims)
                                    Else
                                        maxims = maxims + 1
                                        txtInputCodDoc.Text = txtInputCodDoc.Text & " " & Convert.ToString(maxims)
                                    End If
                                End If
                        End Select

                    End If
                Catch ex As Exception
                    MsgBox(ex.Message & vbCrLf)
                End Try
            End If
        End If
    End Sub

    Public Sub Novo()
        'Cadastrar Novo
        isEdit = False
        DocContDoc.idVerifivcar_open = True
        revisao = "00"
        situacao = "Cadastrado"
        Me.ShowDialog()
    End Sub

    Private Sub btInputSalvarDoc_Click(sender As System.Object, e As System.EventArgs) Handles btInputSalvarDoc.Click
        Dim classeDoc As New documentos

        'Status
        barra.Value = 10
        lblStatus.Text = "Iniciando Criação de Arquivo..."

        If format = 0 Then
            arquivo = " - "
        Else
            arquivo = "docx"
        End If
        If radioRetrato.Checked Then
            tpDoc = "R"
        ElseIf radioPaisagem.Checked Then
            tpDoc = "P"
        Else
            barra.Value = 0
            barra.OwnerControl.ForeColor = Color.Red
            MessageBox.Show("Selecione um Tipo de impressão", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Status
        barra.Value = 20
        lblStatus.Text = "Tratamento do Arquivo..."

        '// Identificação de qual atividade de encontra: 
        '// [E]laboração – [C]onsenso – [A]provação - [P]ublicação

        '// VALIDAÇÃO DOS CAMPOS...
        'Titulo
        If txtInputTitudoDoc.Text = "" Then
            barra.Value = 0
            barra.OwnerControl.ForeColor = Color.Red
            MessageBox.Show("O campo Titulo não foi preenchido", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtInputTitudoDoc.Focus()
            Exit Sub
        End If
        'Codigo
        If txtInputCodDoc.Text = "" Then
            barra.Value = 0
            barra.OwnerControl.ForeColor = Color.Red
            MessageBox.Show("O campo Codigo não foi preenchido", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtInputCodDoc.Focus()
            Exit Sub
        End If
        'Tipo
        If cmbInputTipoDoc.Text = "" Then
            barra.Value = 0
            barra.OwnerControl.ForeColor = Color.Red
            MessageBox.Show("O campo Tipo não foi selecionado", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbInputTipoDoc.Focus()
            Exit Sub
        End If
        'Area
        If cmbInputAreaDoc.Text = "" Then
            barra.Value = 0
            barra.OwnerControl.ForeColor = Color.Red
            MessageBox.Show("O campo Área não foi selecionado", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbInputTipoDoc.Focus()
            Exit Sub
        End If

        'Status
        barra.Value = 40
        lblStatus.Text = "Salvando Registro..."

        '//SALVAE/EDITAR...
        Try
            If isEdit Then
                'Editar
                'If classeDoc.Update() Then
                '    MessageBox.Show("Documento salvo com sucesso!", "Documentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                '    'docConfigDocs.carregarTipoDoc()
                '    'docConfigDocs.carregarTipoDocComposicao()
                '    Me.Close()

                'End If
            Else
                'Salvar
                If classeDoc.AddCdoc(txtInputCodDoc.Text.Trim(), cmbInputTipoDoc.SelectedValue, txtInputTitudoDoc.Text, cmbInputAreaDoc.SelectedValue, revisao, situacao, _E, _C, _A, _P, format, False, arquivo) Then
                    '//criar um documento fisico...
                    criarDocumento(txtInputCodDoc.Text, txtInputTitudoDoc.Text, revisao)
                    MessageBox.Show("Novo Documento salvo com sucesso!", "Documentos", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DocContDoc.carregarLista()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub

    Private Sub criarDocumento(ByVal codigo As String, ByVal titulo As String, ByVal revisao As String)
        'VARIAVEIS
        Dim SubCaminho As String = Globals.Dados.SubCaminho
        Dim objWord = New Microsoft.Office.Interop.Word.Application()
        Dim objDoc = New Word.Document

        '//Codigo...
        Dim vCodDoc As String = codigo
        '//Titulo...
        Dim vTituloDoc As String = titulo
        '//revisao...
        Dim vRev As String = revisao

        'Status
        barra.Value = 60
        lblStatus.Text = "Criando Arquivo Físico..."

        '//Abra o formulário especifico...
        Try
            If tpDoc = "R" Then
                'Formulários Retrato
                Dim documentLocation = SubCaminho & "formularios\modeloR.doc"
                Dim NovaCopia = SubCaminho & "formularios\copia\modeloR.doc"
                If Dir(documentLocation) <> "" Then
                    '//faz uma copia do arquivo...
                    If System.IO.File.Exists(documentLocation) = True Then
                        System.IO.File.Copy(documentLocation, NovaCopia)
                    End If
                    objDoc = objWord.Documents.Open(NovaCopia)
                Else
                    MsgBox("O documento modeloR.doc, não se encontra no diretório " & SubCaminho & "Formularios\.", vbCritical, "ATENÇÃO")
                    Exit Sub
                End If
            Else
                'Formulários Paisagem
                Dim documentLocation = SubCaminho & "formularios\modeloP.doc"
                Dim NovaCopia = SubCaminho & "formularios\copia\modeloP.doc"
                If Dir(documentLocation) <> "" Then
                    '//faz uma copia do arquivo...
                    If System.IO.File.Exists(documentLocation) = True Then
                        System.IO.File.Copy(documentLocation, NovaCopia)
                    End If
                    objDoc = objWord.Documents.Open(NovaCopia)
                Else
                    MsgBox("O documento modeloP.doc, não se encontra no diretório " & SubCaminho & "Formularios\.", vbCritical, "ATENÇÃO")
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try

        'Status
        barra.Value = 80
        lblStatus.Text = "Formatando Arquivo Físico..."

        '//tramites...
        objWord.ActiveWindow.Selection.Font.Name = "Arial"
        objWord.ActiveWindow.Selection.Font.Size = 16
        objWord.ActiveWindow.Selection.Font.Bold = True
        objDoc.Bookmarks("titulo").Range.Text = UCase(vTituloDoc).Trim()
        objDoc.Bookmarks("titulo").Delete()
        objWord.ActiveWindow.Selection.Font.Size = 8
        objWord.ActiveWindow.Selection.Font.Name = "Arial"
        objDoc.Bookmarks("codigo").Range.Text = Mid(vCodDoc, 1, 2) & "-" & Mid(vCodDoc, 3, 3) & "-" & Mid(vCodDoc, 6, 3)
        objDoc.Bookmarks("codigo").Delete()
        objWord.ActiveWindow.Selection.Font.Name = "Arial"
        objDoc.Bookmarks("revisao").Range.Text = revisao
        objDoc.Bookmarks("revisao").Delete()

        objDoc.SaveAs(SubCaminho & "Formularios\word\" & vCodDoc & ".doc")
        objDoc.Save()
        objDoc.Close()
        'Salva no banco de dados...
        SalvaDocBd(SubCaminho & "Formularios\word\" & vCodDoc & ".doc", vCodDoc, revisao)
        objWord.Quit()

        objWord = Nothing
        objDoc = Nothing

        '//Deleta a copia do arquivo...
        If tpDoc = "R" Then
            Dim DeleteFile = SubCaminho & "formularios\copia\modeloR.doc"
            If System.IO.File.Exists(DeleteFile) = True Then
                System.IO.File.Delete(DeleteFile)
            End If
        Else
            Dim DeleteFile = SubCaminho & "formularios\copia\modeloP.doc"
            If System.IO.File.Exists(DeleteFile) = True Then
                System.IO.File.Delete(DeleteFile)
            End If
        End If

        'Status
        barra.Value = 100
        lblStatus.Text = "Concluido com sucesso!"

    End Sub

    Private Sub SalvaDocBd(ByVal documento As String, ByVal codigo As String, ByVal revisao As String)
        Dim classeDoc As New documentos

        Try
            Dim caminho As String = String.Empty
            Dim tipo As String = String.Empty
            Dim arquivo As String()
            Dim descricao As String = String.Empty
            Dim fisico As String = String.Empty

            fisico = documento
            caminho = documento
            arquivo = Split(caminho, "\")
            picDoc.ImageLocation = caminho
            descricao = arquivo.GetValue(arquivo.GetUpperBound(0))
            tipo = caminho.Substring(caminho.Length - 3, 3)

            If Not picDoc.ImageLocation Is Nothing Then
                Dim infoImg As New FileInfo(picDoc.ImageLocation)
                Dim tamanho As Long = infoImg.Length
                Dim arqStream As New FileStream(picDoc.ImageLocation, FileMode.Open, FileAccess.Read)
                DOC = New Byte(Convert.ToInt32(tamanho - 1)) {}
                arqStream.Read(DOC, 0, tamanho)
            End If

            'Salvar...
            If classeDoc.AddCdocBD(codigo.Trim(), _
                                revisao, _
                                DOC, _
                                fisico) Then
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf)
        End Try
    End Sub

    'recuperar doc
    'Dim bytePicData() As Byte = dr("FOTO")
    'Dim PicMemStream As New System.IO.MemoryStream(bytePicData)
    '            picFoto.Image = Image.FromStream(PicMemStream)
    '            FOTO = bytePicData

End Class
