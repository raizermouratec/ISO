Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO

Public Class docAnexosElaboracao

#Region "VARIAVEIS"
    Private ANEXO() As Byte
    Public doc1 As String = String.Empty
    Public rev1 As Integer = 0
    Public doc As String = doc1
    Public rev As Integer = rev1
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

#Region "LOAD"
    Private Sub docAnexosElaboracao_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        carregaListaAnexos(doc, rev)
    End Sub
#End Region

#Region "NOVO"
    Public Sub Novo()
        doc = doc1
        rev = rev1
        Me.ShowDialog()
    End Sub
#End Region
    
#Region "ANEXOS"
    Private Sub botAnexos_Click(sender As System.Object, e As System.EventArgs) Handles botAnexos.Click
        Try
            Dim classe As New elaboracao

            'Status
            barra.Value = 10
            lblStatus.Text = "Iniciando Inportação de Arquivo..."

            Dim dlgAnexo As FileDialog = New OpenFileDialog()
            Dim caminho As String = ""
            Dim tipo As String = ""
            Dim arquivo As String()
            Dim descricao As String = ""

            If dlgAnexo.ShowDialog() = Windows.Forms.DialogResult.OK Then
                caminho = dlgAnexo.FileName
                arquivo = Split(caminho, "\")
                picAnexo.ImageLocation = caminho
                descricao = arquivo.GetValue(arquivo.GetUpperBound(0))
                tipo = caminho.Substring(caminho.Length - 3, 3)
            Else
                barra.Value = 0
                barra.OwnerControl.ForeColor = Color.Red
                lblStatus.Text = "Nenhum aquivo selecionado!"
                Exit Sub
            End If

            'Status
            barra.Value = 30
            lblStatus.Text = "Tratamento do Arquivo..."

            If Not picAnexo.ImageLocation Is Nothing Then
                Dim infoImg As New FileInfo(picAnexo.ImageLocation)
                Dim tamanho As Long = infoImg.Length
                Dim arqStream As New FileStream(picAnexo.ImageLocation, FileMode.Open, FileAccess.Read)
                ANEXO = New Byte(Convert.ToInt32(tamanho - 1)) {}
                arqStream.Read(ANEXO, 0, tamanho)
            End If

            'Status
            barra.Value = 80
            lblStatus.Text = "Salvando Arquivo..."

            If MessageBox.Show("Tem certeza que deseja Salvar o Anexo selecionado ?", "ISO é Fácil", Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
                '//caso exista um documento; deleta e cria novamente
                Dim dt As New DataTable
                Dim sql As String = String.Format("SELECT * FROM DOCUMENTO_ELABORACAO_ANEXOS WHERE CODIGO_DOCUMENTO = '{0}' AND REVISAO = {1}", doc, rev)
                dt = Manager.Util.getDataTableById(sql)
                If dt.Rows.Count > 0 Then
                    classe.Delete(doc, rev)
                End If
                '//Salva...
                If classe.Add(doc, rev, descricao, ANEXO, tipo) Then
                    MessageBox.Show("Anexos salvos com sucesso.", "ISO é Fácil", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Status
                    barra.Value = 100
                    lblStatus.Text = "Concluido com sucesso!"

                    'carrega Lista
                    carregaListaAnexos(doc, rev)
                End If
            Else
                barra.Value = 0
                barra.OwnerControl.ForeColor = Color.Red
                lblStatus.Text = "Operação Cancelada!"
            End If
        Catch ex As Exception
            lblStatus.Text = "Não foi possivel realizar a operação. Tente novamente." & " ... " & lblStatus.Text
        End Try
    End Sub
#End Region

#Region "CARREGAR LISTA DE ANEXOS"

    Public Sub carregaListaAnexos(ByVal codigo As String, ByVal revisao As String)

        Dim dt As New DataTable
        Dim i As Integer = 1

        Dim sql As String = String.Format("SELECT * FROM DOCUMENTO_ELABORACAO_ANEXOS WHERE CODIGO_DOCUMENTO = '{0}' AND REVISAO = {1}", codigo, revisao)
        dt = Manager.Util.getDataTableById(sql)

        'Monta o Grid
        gridAnexos.AutoGenerateColumns = False
        gridAnexos.DataSource = Manager.Util.getDataTable(sql)

        Try

            For Each dr As DataRow In dt.Rows

                ' coluna especifica
                If dr("TIPO") = "doc" Then
                    gridAnexos.SetCellImage(i, 2, _imgListLegenda.Images.Item(0))
                End If

                If dr("TIPO") = "ocx" Then
                    gridAnexos.SetCellImage(i, 2, _imgListLegenda.Images.Item(0))
                End If

                If dr("TIPO") = "xls" Then
                    gridAnexos.SetCellImage(i, 2, _imgListLegenda.Images.Item(1))
                End If

                If dr("TIPO") = "pdf" Then
                    gridAnexos.SetCellImage(i, 2, _imgListLegenda.Images.Item(2))
                End If

                If dr("TIPO") = "txt" Then
                    gridAnexos.SetCellImage(i, 2, _imgListLegenda.Images.Item(3))
                End If

                If dr("TIPO") = "ppt" Then
                    gridAnexos.SetCellImage(i, 2, _imgListLegenda.Images.Item(4))
                End If

                If dr("TIPO") = "out" Then
                    gridAnexos.SetCellImage(i, 2, _imgListLegenda.Images.Item(5))
                End If

                i += 1

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

End Class
