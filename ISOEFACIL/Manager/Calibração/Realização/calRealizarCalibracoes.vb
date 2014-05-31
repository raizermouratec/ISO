Public Class calRealizarCalibracoes

#Region "POPULA COMBOS"

#Region "EXTERNO"

    Sub CarregacomboAnoExt()
        With comboAnoExt
            Dim dtb As New DataTable
            dtb = Manager.Util.getDataTable("SELECT DISTINCT ANO FROM VW_LISTAGEM_CALIBRACOES_PLANO_EXTERNA")
            If (dtb.Rows.Count > 0) Then
                Dim dr As DataRow = dtb.NewRow
                dr(0) = Date.Today.Year
            Else
                dtb.Rows.Add(dtb.NewRow)
            End If

            .DataSource = dtb
            .DisplayMember = "ANO"
            .ValueMember = "ANO"
        End With
    End Sub

#End Region

#Region "INTERNO"

    Sub CarregacomboAnoInt()
        With comboAnoInt
            Dim dtb As New DataTable
            dtb = Manager.Util.getDataTable("SELECT DISTINCT ANO FROM VW_LISTAGEM_CALIBRACOES_PLANO_INTERNA")
            If (dtb.Rows.Count > 0) Then
                Dim dr As DataRow = dtb.NewRow
                dr(0) = Date.Today.Year
            Else
                dtb.Rows.Add(dtb.NewRow)
            End If

            .DataSource = dtb
            .DisplayMember = "ANO"
            .ValueMember = "ANO"
        End With
    End Sub

#End Region

#End Region

#Region "ANO"

    Public Sub VerificaAno()

        Dim agora As DateTime = DateTime.Now

        'obtém o ano.
        Dim anoatual As Integer = agora.Year

        comboAnoExt.ValueMember = anoatual
        comboAnoInt.ValueMember = anoatual

    End Sub

#End Region

#Region "CARREGA LISTA"

    Public Sub carregaListaDatas()

        ''***ALTERAR NOS PONTOS NUMERADOS

        'Dim dt As New DataTable
        'Dim i As Integer = 1

        'Dim sqlId As String = String.Format("SELECT * FROM PLANO_AUDITORIA")
        'dt = Manager.Util.getDataTableById(sqlId)

    End Sub

#End Region

#Region "CARREGA LISTA EXTERNA"

#Region "LISTA EXTERNA"

    Public Sub carregaListaExterna()

        Dim dt As New DataTable
        Dim i As Integer = 1

        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_CALIBRACOES_PLANO_EXTERNA")
        dt = Manager.Util.getDataTableById(sql)

        'Monta o Grid
        gridCalibExterna.AutoGenerateColumns = False
        gridCalibExterna.DataSource = Manager.Util.getDataTable(sql)

        Try

            For Each dr As DataRow In dt.Rows

                ' coluna especifica
                If dr("SITUACAO") = "Programada" Then
                    gridCalibExterna.SetCellImage(i, 8, _imgListLegenda.Images.Item(0))
                End If

                If dr("SITUACAO") = "Realizada" Then
                    gridCalibExterna.SetCellImage(i, 8, _imgListLegenda.Images.Item(1))
                End If

                If dr("SITUACAO") = "Cancelada" Then
                    gridCalibExterna.SetCellImage(i, 8, _imgListLegenda.Images.Item(2))
                End If

                If dr("SITUACAO") = "Reprogramada" Then
                    gridCalibExterna.SetCellImage(i, 8, _imgListLegenda.Images.Item(3))
                End If

                If dr("SITUACAO") = "Atrasada" Then
                    gridCalibExterna.SetCellImage(i, 8, _imgListLegenda.Images.Item(4))
                End If

                If dr("SITUACAO") = "Em Branco" Then
                    gridCalibExterna.SetCellImage(i, 8, _imgListLegenda.Images.Item(5))
                End If

                i += 1

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "LISTA-EXTERNA-ANO"

    Public Sub carregaListaExternaAno(ByVal ANO As String)

        Dim dt As New DataTable
        Dim i As Integer = 1

        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_CALIBRACOES_PLANO_EXTERNA")
        dt = Manager.Util.getDataTableById(sql)

        Dim sqlId As String = String.Format("SELECT * FROM VW_LISTAGEM_CALIBRACOES_PLANO_EXTERNA WHERE ANO = {0}", ANO)
        Dim dt2 As New DataTable

        'Monta o Grid
        gridCalibExterna.AutoGenerateColumns = False
        dt2 = Manager.Util.getDataTableById(sqlId)
        gridCalibExterna.DataSource = dt2

        Try

            For Each dr As DataRow In dt.Rows

                ' coluna especifica
                If dr("SITUACAO") = "Programada" Then
                    gridCalibExterna.SetCellImage(i, 8, _imgListLegenda.Images.Item(0))
                End If

                If dr("SITUACAO") = "Realizada" Then
                    gridCalibExterna.SetCellImage(i, 8, _imgListLegenda.Images.Item(1))
                End If

                If dr("SITUACAO") = "Cancelada" Then
                    gridCalibExterna.SetCellImage(i, 8, _imgListLegenda.Images.Item(2))
                End If

                If dr("SITUACAO") = "Reprogramada" Then
                    gridCalibExterna.SetCellImage(i, 8, _imgListLegenda.Images.Item(3))
                End If

                If dr("SITUACAO") = "Atrasada" Then
                    gridCalibExterna.SetCellImage(i, 8, _imgListLegenda.Images.Item(4))
                End If

                If dr("SITUACAO") = "Em Branco" Then
                    gridCalibExterna.SetCellImage(i, 8, _imgListLegenda.Images.Item(5))
                End If

                i += 1

            Next
        Catch ex As Exception

        End Try

    End Sub

#End Region

#End Region

#Region "CARREGA LISTA INTERNA"

#Region "LISTA INTERNA"

    Public Sub carregaListaInterna()

        Dim dt As New DataTable
        Dim i As Integer = 1

        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_CALIBRACOES_PLANO_INTERNA")
        dt = Manager.Util.getDataTableById(sql)

        'Monta o Grid'
        gridCalibInterna.AutoGenerateColumns = False
        gridCalibInterna.DataSource = Manager.Util.getDataTable(sql)

        Try

            For Each dr As DataRow In dt.Rows

                ' coluna especifica
                If dr("SITUACAO") = "Programada" Then
                    gridCalibInterna.SetCellImage(i, 8, _imgListLegenda.Images.Item(0))
                End If
                ' coluna especifica
                If dr("SITUACAO") = "Realizada" Then
                    gridCalibInterna.SetCellImage(i, 8, _imgListLegenda.Images.Item(1))
                End If
                ' coluna especifica
                If dr("SITUACAO") = "Cancelada" Then
                    gridCalibInterna.SetCellImage(i, 8, _imgListLegenda.Images.Item(2))
                End If
                ' coluna especifica
                If dr("SITUACAO") = "Reprogramada" Then
                    gridCalibInterna.SetCellImage(i, 8, _imgListLegenda.Images.Item(3))
                End If
                ' coluna especifica
                If dr("SITUACAO") = "Atrasada" Then
                    gridCalibInterna.SetCellImage(i, 8, _imgListLegenda.Images.Item(4))
                End If
                ' coluna especifica
                If dr("SITUACAO") = "Em Branco" Then
                    gridCalibInterna.SetCellImage(i, 8, _imgListLegenda.Images.Item(5))
                End If
                i += 1

            Next

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "LISTA-INTERNA-ANO"

    Public Sub carregaListaInternaAno(ByVal ANO As String)

        Dim dt As New DataTable
        Dim i As Integer = 1

        Dim sql As String = String.Format("SELECT * FROM VW_LISTAGEM_CALIBRACOES_PLANO_INTERNA")
        dt = Manager.Util.getDataTableById(sql)

        Dim sqlId As String = String.Format("SELECT * FROM VW_LISTAGEM_CALIBRACOES_PLANO_INTERNA WHERE ANO = {0}", ANO)
        Dim dt2 As New DataTable

        'Monta o Grid'
        gridCalibInterna.AutoGenerateColumns = False
        dt2 = Manager.Util.getDataTableById(sqlId)
        gridCalibInterna.DataSource = dt2

        Try

            For Each dr As DataRow In dt.Rows

                ' coluna especifica
                If dr("SITUACAO") = "Programada" Then
                    gridCalibInterna.SetCellImage(i, 8, _imgListLegenda.Images.Item(0))
                End If
                ' coluna especifica
                If dr("SITUACAO") = "Realizada" Then
                    gridCalibInterna.SetCellImage(i, 8, _imgListLegenda.Images.Item(1))
                End If
                ' coluna especifica
                If dr("SITUACAO") = "Cancelada" Then
                    gridCalibInterna.SetCellImage(i, 8, _imgListLegenda.Images.Item(2))
                End If
                ' coluna especifica
                If dr("SITUACAO") = "Reprogramada" Then
                    gridCalibInterna.SetCellImage(i, 8, _imgListLegenda.Images.Item(3))
                End If
                ' coluna especifica
                If dr("SITUACAO") = "Atrasada" Then
                    gridCalibInterna.SetCellImage(i, 8, _imgListLegenda.Images.Item(4))
                End If
                ' coluna especifica
                If dr("SITUACAO") = "Em Branco" Then
                    gridCalibInterna.SetCellImage(i, 8, _imgListLegenda.Images.Item(5))
                End If
                i += 1

            Next

        Catch ex As Exception

        End Try

    End Sub

#End Region

#End Region

#Region "LOAD"

    Private Sub calListaCalibracoes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TabExt.Show()

        'VerificaAno()
        CarregacomboAnoExt()
        CarregacomboAnoInt()
        carregaListaExterna()
        carregaListaInterna()

    End Sub

#End Region

#Region "BOTÕES"

#Region "REALIZAR"

    Private Sub botRealizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botRealizar.Click

        If TabExt.Focus = True Then

            If gridCalibExterna.RowSel <= 0 Then
                MessageBox.Show("Não à nenhuma item selecionado", "Calibração Externa", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else

                Dim frmExt As New calRealizacaoCalibracoesExternas
                Dim id As Integer = 0
                Dim idplano As Integer = 0
                Dim mes As String = String.Empty
                Dim situacao As String = String.Empty
                Dim ano As String = String.Empty

                'Passagem de parametros
                Try

                    id = gridCalibExterna(gridCalibExterna.RowSel, 1)
                    idplano = gridCalibExterna(gridCalibExterna.RowSel, 2)
                    mes = gridCalibExterna(gridCalibExterna.RowSel, 5)
                    situacao = gridCalibExterna(gridCalibExterna.RowSel, 8)
                    ano = comboAnoExt.SelectedValue.ToString

                    If situacao = "Cancelada" Then
                        MessageBox.Show("Calibração Externa cancelada", "Realização de Calibração Externa", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    ElseIf situacao = "Realizada" Then
                        MessageBox.Show("Calibração Externa já realizada. Para alterar os dados clique no botão Editar.", "Realização de Calibração Externa", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    ElseIf situacao = "Reprogramada" Then
                        MessageBox.Show("Calibração Externa reprogramada. É necessário programar uma outra calibração externa.", "Realização de Calibração Externa", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    frmExt.Mes = mes
                    frmExt.Situacao = situacao
                    frmExt.Ano = ano
                    frmExt.CalExterno = id
                    frmExt.Plano = idplano
                    frmExt.NovoCalExterno(idplano, mes, situacao)

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try
            End If


        Else

            If gridCalibInterna.RowSel < 0 Then
                MessageBox.Show("Não à nenhuma item selecionado", "Calibração Interna", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                Dim frmInt As New calRealizacaoCalibracoesInternas
                Dim id As Integer = 0
                Dim idplano As Integer = 0
                Dim mes As String = String.Empty
                Dim situacao As String = String.Empty
                Dim ano As String = String.Empty

                'Passagem de parametros
                Try

                    id = gridCalibInterna(gridCalibInterna.RowSel, 1)
                    idplano = gridCalibInterna(gridCalibInterna.RowSel, 2)
                    mes = gridCalibInterna(gridCalibInterna.RowSel, 5)
                    situacao = gridCalibInterna(gridCalibInterna.RowSel, 8)
                    ano = comboAnoInt.SelectedValue.ToString

                    If situacao = "Cancelada" Then
                        MessageBox.Show("Calibração Externa cancelada", "Realização de Calibração Externa", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    ElseIf situacao = "Realizada" Then
                        MessageBox.Show("Calibração Externa já realizada. Para alterar os dados clique no botão Editar.", "Realização de Calibração Externa", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    ElseIf situacao = "Reprogramada" Then
                        MessageBox.Show("Calibração Externa reprogramada. É necessário programar uma outra calibração externa.", "Realização de Calibração Externa", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    frmInt.Mes = mes
                    frmInt.Situacao = situacao
                    frmInt.Ano = ano
                    frmInt.CalInterno = id
                    frmInt.Plano = idplano
                    frmInt.NovoCalInterno(idplano, mes, situacao)

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try

            End If
        End If

    End Sub

#End Region

#Region "EDITAR"

    Private Sub botEditar_Click(sender As System.Object, e As System.EventArgs) Handles botEditar.Click

        If TabExt.Focus = True Then

            If gridCalibExterna.RowSel <= 0 Then
                MessageBox.Show("Não à nenhuma item selecionado", "Calibração Externa", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else

                Dim frm As New calRealizacaoCalibracoesExternas
                Dim id As Integer = 0
                Dim situacao As String = String.Empty
                Dim ano As String = String.Empty

                'Muda o Label do botão Incluir
                frm.botSalvar.Width = 80
                frm.botSalvar.Text = "Atualizar"

                'Passagem de parametros
                Try

                    situacao = gridCalibExterna(gridCalibExterna.RowSel, 8)
                    ano = comboAnoExt.SelectedValue.ToString

                    If situacao = "Programada" Then
                        MessageBox.Show("Precisa realizar a calibração para edita-la", "Realização de Calibração Externa", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    ElseIf situacao = "Cancelada" Then
                        MessageBox.Show("Calibração Externa cancelada", "Realização de Calibração Externa", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    ElseIf situacao = "Reprogramada" Then
                        MessageBox.Show("Calibração Externa reprogramada. É necessário programar uma outra calibração externa", "Realização de Calibração Externa", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    id = gridCalibExterna(gridCalibExterna.RowSel, 1)
                    frm.Ano = ano
                    frm.CalExterno = id
                    frm.EditarCalibracaoExterna(id)

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try

            End If

        Else

            If gridCalibInterna.RowSel <= 0 Then
                MessageBox.Show("Não à nenhuma item selecionado", "Calibração Interna", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else

                Dim frm As New calRealizacaoCalibracoesInternas
                Dim id As Integer = 0
                Dim situacao As String = String.Empty
                Dim ano As String = String.Empty

                'Muda o Label do botão Incluir
                frm.botSalvar.Width = 80
                frm.botSalvar.Text = "Atualizar"

                'Passagem de parametros
                Try

                    situacao = gridCalibInterna(gridCalibInterna.RowSel, 8)
                    ano = comboAnoInt.SelectedValue.ToString

                    If situacao = "Programada" Then
                        MessageBox.Show("Precisa realizar a calibração para edita-la", "Realização de Calibração Interna", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    ElseIf situacao = "Cancelada" Then
                        MessageBox.Show("Calibração Interna cancelada", "Realização de Calibração Interna", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    ElseIf situacao = "Reprogramada" Then
                        MessageBox.Show("Calibração Interna reprogramada. É necessário programar uma outra calibração interna.", "Realização de Calibração Interna", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    id = gridCalibInterna(gridCalibInterna.RowSel, 1)
                    frm.Ano = ano
                    frm.CalInterno = id
                    frm.EditarCalibracaoInterna(id)

                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                End Try

            End If
        End If
    End Sub

#End Region

#End Region

#Region "FILTRO POR ANO"

#Region "FILTRO EXTERNA"

    Private Sub comboAnoExt_ChangeCommitted(sender As System.Object, e As System.EventArgs) Handles comboAnoExt.ChangeCommitted
        Dim ano As String
        Try

            If comboAnoExt.ValueMember = "" Then
                CarregacomboAnoExt()
            End If

            ano = comboAnoExt.SelectedValue.ToString
            carregaListaExternaAno(ano)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub comboAnoExt_GotFocus(sender As System.Object, e As System.EventArgs) Handles comboAnoExt.GotFocus
        Dim ano As String

        Try

            If comboAnoExt.ValueMember = "" Then
                CarregacomboAnoExt()
            End If

            ano = comboAnoExt.SelectedValue.ToString
            carregaListaExternaAno(ano)

        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "FILTRO INTERNA"
    Private Sub comboAnoInt_ChangeCommitted(sender As System.Object, e As System.EventArgs) Handles comboAnoInt.ChangeCommitted
        Dim ano As String

        Try

            If comboAnoInt.ValueMember = "" Then
                CarregacomboAnoInt()
            End If

            ano = comboAnoInt.SelectedValue.ToString
            carregaListaInternaAno(ano)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub comboAnoInt_GotFocus(sender As System.Object, e As System.EventArgs) Handles comboAnoInt.GotFocus
        Dim ano As String

        Try

            If comboAnoInt.ValueMember = "" Then
                CarregacomboAnoInt()
            End If

            ano = comboAnoInt.SelectedValue.ToString
            carregaListaInternaAno(ano)

        Catch ex As Exception

        End Try
    End Sub

#End Region

#End Region

End Class
