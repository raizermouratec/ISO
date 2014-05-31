Imports System.Data.SqlClient
Public Class cotrProgramacaoTreinamentos

#Region "CARREGA LISTA"

    Public Sub carregaListaDatas()

        Dim dt As New DataTable
        Dim i As Integer = 1

        Dim sqlId As String = String.Format("SELECT * FROM TREINAMENTO_PLANO")
        dt = Manager.Util.getDataTableById(sqlId)

        'Monta o Grid
        gridPlanoDatas.AutoGenerateColumns = False
        gridPlanoDatas.DataSource = Manager.Util.getDataTable("SELECT * FROM VW_LISTAGEM_TREINAMENTO_PLANO_ANUAL")

        Try

            'Função para validação de Imagem
            For Each dr As DataRow In dt.Rows

                ' coluna especifica
                '--JANEIRO
                If dr("JAN") = 1 Then
                    gridPlanoDatas.SetCellImage(i, 3, _imgListLegenda.Images.Item(0))
                End If
                If dr("JAN") = 2 Then
                    gridPlanoDatas.SetCellImage(i, 3, _imgListLegenda.Images.Item(1))
                End If
                If dr("JAN") = 3 Then
                    gridPlanoDatas.SetCellImage(i, 3, _imgListLegenda.Images.Item(2))
                End If
                If dr("JAN") = 4 Then
                    gridPlanoDatas.SetCellImage(i, 3, _imgListLegenda.Images.Item(3))
                End If
                If dr("JAN") = 5 Then
                    gridPlanoDatas.SetCellImage(i, 3, _imgListLegenda.Images.Item(4))
                End If
                If dr("JAN") = 6 Then
                    gridPlanoDatas.SetCellImage(i, 3, _imgListLegenda.Images.Item(5))
                End If

                '--FEVEREIRO
                If dr("FEV") = 1 Then
                    gridPlanoDatas.SetCellImage(i, 4, _imgListLegenda.Images.Item(0))
                End If
                If dr("FEV") = 2 Then
                    gridPlanoDatas.SetCellImage(i, 4, _imgListLegenda.Images.Item(1))
                End If
                If dr("FEV") = 3 Then
                    gridPlanoDatas.SetCellImage(i, 4, _imgListLegenda.Images.Item(2))
                End If
                If dr("FEV") = 4 Then
                    gridPlanoDatas.SetCellImage(i, 4, _imgListLegenda.Images.Item(3))
                End If
                If dr("FEV") = 5 Then
                    gridPlanoDatas.SetCellImage(i, 4, _imgListLegenda.Images.Item(4))
                End If
                If dr("FEV") = 6 Then
                    gridPlanoDatas.SetCellImage(i, 4, _imgListLegenda.Images.Item(5))
                End If

                '--MARÇO
                If dr("MAR") = 1 Then
                    gridPlanoDatas.SetCellImage(i, 5, _imgListLegenda.Images.Item(0))
                End If
                If dr("MAR") = 2 Then
                    gridPlanoDatas.SetCellImage(i, 5, _imgListLegenda.Images.Item(1))
                End If
                If dr("MAR") = 3 Then
                    gridPlanoDatas.SetCellImage(i, 5, _imgListLegenda.Images.Item(2))
                End If
                If dr("MAR") = 4 Then
                    gridPlanoDatas.SetCellImage(i, 5, _imgListLegenda.Images.Item(3))
                End If
                If dr("MAR") = 5 Then
                    gridPlanoDatas.SetCellImage(i, 5, _imgListLegenda.Images.Item(4))
                End If
                If dr("MAR") = 6 Then
                    gridPlanoDatas.SetCellImage(i, 5, _imgListLegenda.Images.Item(5))
                End If

                '--ABRIL
                If dr("ABR") = 1 Then
                    gridPlanoDatas.SetCellImage(i, 6, _imgListLegenda.Images.Item(0))
                End If
                If dr("ABR") = 2 Then
                    gridPlanoDatas.SetCellImage(i, 6, _imgListLegenda.Images.Item(1))
                End If
                If dr("ABR") = 3 Then
                    gridPlanoDatas.SetCellImage(i, 6, _imgListLegenda.Images.Item(2))
                End If
                If dr("ABR") = 4 Then
                    gridPlanoDatas.SetCellImage(i, 6, _imgListLegenda.Images.Item(3))
                End If
                If dr("ABR") = 5 Then
                    gridPlanoDatas.SetCellImage(i, 6, _imgListLegenda.Images.Item(4))
                End If
                If dr("ABR") = 6 Then
                    gridPlanoDatas.SetCellImage(i, 6, _imgListLegenda.Images.Item(5))
                End If

                '--MAIO
                If dr("MAI") = 1 Then
                    gridPlanoDatas.SetCellImage(i, 7, _imgListLegenda.Images.Item(0))
                End If
                If dr("MAI") = 2 Then
                    gridPlanoDatas.SetCellImage(i, 7, _imgListLegenda.Images.Item(1))
                End If
                If dr("MAI") = 3 Then
                    gridPlanoDatas.SetCellImage(i, 7, _imgListLegenda.Images.Item(2))
                End If
                If dr("MAI") = 4 Then
                    gridPlanoDatas.SetCellImage(i, 7, _imgListLegenda.Images.Item(3))
                End If
                If dr("MAI") = 5 Then
                    gridPlanoDatas.SetCellImage(i, 7, _imgListLegenda.Images.Item(4))
                End If
                If dr("MAI") = 6 Then
                    gridPlanoDatas.SetCellImage(i, 7, _imgListLegenda.Images.Item(5))
                End If

                '--JUNHO
                If dr("JUN") = 1 Then
                    gridPlanoDatas.SetCellImage(i, 8, _imgListLegenda.Images.Item(0))
                End If
                If dr("JUN") = 2 Then
                    gridPlanoDatas.SetCellImage(i, 8, _imgListLegenda.Images.Item(1))
                End If
                If dr("JUN") = 3 Then
                    gridPlanoDatas.SetCellImage(i, 8, _imgListLegenda.Images.Item(2))
                End If
                If dr("JUN") = 4 Then
                    gridPlanoDatas.SetCellImage(i, 8, _imgListLegenda.Images.Item(3))
                End If
                If dr("JUN") = 5 Then
                    gridPlanoDatas.SetCellImage(i, 8, _imgListLegenda.Images.Item(4))
                End If
                If dr("JUN") = 6 Then
                    gridPlanoDatas.SetCellImage(i, 8, _imgListLegenda.Images.Item(5))
                End If

                '--JULHO
                If dr("JUL") = 1 Then
                    gridPlanoDatas.SetCellImage(i, 9, _imgListLegenda.Images.Item(0))
                End If
                If dr("JUL") = 2 Then
                    gridPlanoDatas.SetCellImage(i, 9, _imgListLegenda.Images.Item(1))
                End If
                If dr("JUL") = 3 Then
                    gridPlanoDatas.SetCellImage(i, 9, _imgListLegenda.Images.Item(2))
                End If
                If dr("JUL") = 4 Then
                    gridPlanoDatas.SetCellImage(i, 9, _imgListLegenda.Images.Item(3))
                End If
                If dr("JUL") = 5 Then
                    gridPlanoDatas.SetCellImage(i, 9, _imgListLegenda.Images.Item(4))
                End If
                If dr("JUL") = 6 Then
                    gridPlanoDatas.SetCellImage(i, 9, _imgListLegenda.Images.Item(5))
                End If

                '--AGOSTO
                If dr("AGO") = 1 Then
                    gridPlanoDatas.SetCellImage(i, 10, _imgListLegenda.Images.Item(0))
                End If
                If dr("AGO") = 2 Then
                    gridPlanoDatas.SetCellImage(i, 10, _imgListLegenda.Images.Item(1))
                End If
                If dr("AGO") = 3 Then
                    gridPlanoDatas.SetCellImage(i, 10, _imgListLegenda.Images.Item(2))
                End If
                If dr("AGO") = 4 Then
                    gridPlanoDatas.SetCellImage(i, 10, _imgListLegenda.Images.Item(3))
                End If
                If dr("AGO") = 5 Then
                    gridPlanoDatas.SetCellImage(i, 10, _imgListLegenda.Images.Item(4))
                End If
                If dr("AGO") = 6 Then
                    gridPlanoDatas.SetCellImage(i, 10, _imgListLegenda.Images.Item(5))
                End If

                '--SETEMBRO
                If dr("SET") = 1 Then
                    gridPlanoDatas.SetCellImage(i, 11, _imgListLegenda.Images.Item(0))
                End If
                If dr("SET") = 2 Then
                    gridPlanoDatas.SetCellImage(i, 11, _imgListLegenda.Images.Item(1))
                End If
                If dr("SET") = 3 Then
                    gridPlanoDatas.SetCellImage(i, 11, _imgListLegenda.Images.Item(2))
                End If
                If dr("SET") = 4 Then
                    gridPlanoDatas.SetCellImage(i, 11, _imgListLegenda.Images.Item(3))
                End If
                If dr("SET") = 5 Then
                    gridPlanoDatas.SetCellImage(i, 11, _imgListLegenda.Images.Item(4))
                End If
                If dr("SET") = 6 Then
                    gridPlanoDatas.SetCellImage(i, 11, _imgListLegenda.Images.Item(5))
                End If

                '--OUTUBRO
                If dr("OUT") = 1 Then
                    gridPlanoDatas.SetCellImage(i, 12, _imgListLegenda.Images.Item(0))
                End If
                If dr("OUT") = 2 Then
                    gridPlanoDatas.SetCellImage(i, 12, _imgListLegenda.Images.Item(1))
                End If
                If dr("OUT") = 3 Then
                    gridPlanoDatas.SetCellImage(i, 12, _imgListLegenda.Images.Item(2))
                End If
                If dr("OUT") = 4 Then
                    gridPlanoDatas.SetCellImage(i, 12, _imgListLegenda.Images.Item(3))
                End If
                If dr("OUT") = 5 Then
                    gridPlanoDatas.SetCellImage(i, 12, _imgListLegenda.Images.Item(4))
                End If
                If dr("OUT") = 6 Then
                    gridPlanoDatas.SetCellImage(i, 12, _imgListLegenda.Images.Item(5))
                End If

                '--NOVEMBRO
                If dr("NOV") = 1 Then
                    gridPlanoDatas.SetCellImage(i, 13, _imgListLegenda.Images.Item(0))
                End If
                If dr("NOV") = 2 Then
                    gridPlanoDatas.SetCellImage(i, 13, _imgListLegenda.Images.Item(1))
                End If
                If dr("NOV") = 3 Then
                    gridPlanoDatas.SetCellImage(i, 13, _imgListLegenda.Images.Item(2))
                End If
                If dr("NOV") = 4 Then
                    gridPlanoDatas.SetCellImage(i, 13, _imgListLegenda.Images.Item(3))
                End If
                If dr("NOV") = 5 Then
                    gridPlanoDatas.SetCellImage(i, 13, _imgListLegenda.Images.Item(4))
                End If
                If dr("NOV") = 6 Then
                    gridPlanoDatas.SetCellImage(i, 13, _imgListLegenda.Images.Item(5))
                End If

                '--DEZEMBRO
                If dr("DEZ") = 1 Then
                    gridPlanoDatas.SetCellImage(i, 14, _imgListLegenda.Images.Item(0))
                End If
                If dr("DEZ") = 2 Then
                    gridPlanoDatas.SetCellImage(i, 14, _imgListLegenda.Images.Item(1))
                End If
                If dr("DEZ") = 3 Then
                    gridPlanoDatas.SetCellImage(i, 14, _imgListLegenda.Images.Item(2))
                End If
                If dr("DEZ") = 4 Then
                    gridPlanoDatas.SetCellImage(i, 14, _imgListLegenda.Images.Item(3))
                End If
                If dr("DEZ") = 5 Then
                    gridPlanoDatas.SetCellImage(i, 14, _imgListLegenda.Images.Item(4))
                End If
                If dr("DEZ") = 6 Then
                    gridPlanoDatas.SetCellImage(i, 14, _imgListLegenda.Images.Item(5))
                End If

                i += 1

            Next

        Catch ex As Exception
            'MsgBox("Não foi possivel realizar a operação. Tente novamente.")
        End Try

    End Sub

#End Region

#Region "CARREGA LISTA - FILTRO"

    Public Sub carregaListaDatasAno(ByVal ANO As String)

        Dim dt As New DataTable
        Dim i As Integer = 1

        Dim sqlId As String = String.Format("SELECT * FROM TREINAMENTO_PLANO")
        dt = Manager.Util.getDataTableById(sqlId)

        If ANO = "" Then
            ANO = 0
        End If
        Dim sqlId2 As String = String.Format("SELECT * FROM VW_LISTAGEM_TREINAMENTO_PLANO_ANUAL WHERE ANO = {0}", ANO)
        Dim dt2 As New DataTable

        gridPlanoDatas.AutoGenerateColumns = False
        dt2 = Manager.Util.getDataTableById(sqlId2)
        gridPlanoDatas.DataSource = dt2

        Try

            For Each dr As DataRow In dt2.Rows

                ' coluna especifica
                '--JANEIRO
                If dr("JAN") = 1 Then
                    gridPlanoDatas.SetCellImage(i, 3, _imgListLegenda.Images.Item(0))
                End If
                If dr("JAN") = 2 Then
                    gridPlanoDatas.SetCellImage(i, 3, _imgListLegenda.Images.Item(1))
                End If
                If dr("JAN") = 3 Then
                    gridPlanoDatas.SetCellImage(i, 3, _imgListLegenda.Images.Item(2))
                End If
                If dr("JAN") = 4 Then
                    gridPlanoDatas.SetCellImage(i, 3, _imgListLegenda.Images.Item(3))
                End If
                If dr("JAN") = 5 Then
                    gridPlanoDatas.SetCellImage(i, 3, _imgListLegenda.Images.Item(4))
                End If
                If dr("JAN") = 6 Then
                    gridPlanoDatas.SetCellImage(i, 3, _imgListLegenda.Images.Item(5))
                End If

                '--FEVEREIRO
                If dr("FEV") = 1 Then
                    gridPlanoDatas.SetCellImage(i, 4, _imgListLegenda.Images.Item(0))
                End If
                If dr("FEV") = 2 Then
                    gridPlanoDatas.SetCellImage(i, 4, _imgListLegenda.Images.Item(1))
                End If
                If dr("FEV") = 3 Then
                    gridPlanoDatas.SetCellImage(i, 4, _imgListLegenda.Images.Item(2))
                End If
                If dr("FEV") = 4 Then
                    gridPlanoDatas.SetCellImage(i, 4, _imgListLegenda.Images.Item(3))
                End If
                If dr("FEV") = 5 Then
                    gridPlanoDatas.SetCellImage(i, 4, _imgListLegenda.Images.Item(4))
                End If
                If dr("FEV") = 6 Then
                    gridPlanoDatas.SetCellImage(i, 4, _imgListLegenda.Images.Item(5))
                End If

                '--MARÇO
                If dr("MAR") = 1 Then
                    gridPlanoDatas.SetCellImage(i, 5, _imgListLegenda.Images.Item(0))
                End If
                If dr("MAR") = 2 Then
                    gridPlanoDatas.SetCellImage(i, 5, _imgListLegenda.Images.Item(1))
                End If
                If dr("MAR") = 3 Then
                    gridPlanoDatas.SetCellImage(i, 5, _imgListLegenda.Images.Item(2))
                End If
                If dr("MAR") = 4 Then
                    gridPlanoDatas.SetCellImage(i, 5, _imgListLegenda.Images.Item(3))
                End If
                If dr("MAR") = 5 Then
                    gridPlanoDatas.SetCellImage(i, 5, _imgListLegenda.Images.Item(4))
                End If
                If dr("MAR") = 6 Then
                    gridPlanoDatas.SetCellImage(i, 5, _imgListLegenda.Images.Item(5))
                End If

                '--ABRIL
                If dr("ABR") = 1 Then
                    gridPlanoDatas.SetCellImage(i, 6, _imgListLegenda.Images.Item(0))
                End If
                If dr("ABR") = 2 Then
                    gridPlanoDatas.SetCellImage(i, 6, _imgListLegenda.Images.Item(1))
                End If
                If dr("ABR") = 3 Then
                    gridPlanoDatas.SetCellImage(i, 6, _imgListLegenda.Images.Item(2))
                End If
                If dr("ABR") = 4 Then
                    gridPlanoDatas.SetCellImage(i, 6, _imgListLegenda.Images.Item(3))
                End If
                If dr("ABR") = 5 Then
                    gridPlanoDatas.SetCellImage(i, 6, _imgListLegenda.Images.Item(4))
                End If
                If dr("ABR") = 6 Then
                    gridPlanoDatas.SetCellImage(i, 6, _imgListLegenda.Images.Item(5))
                End If

                '--MAIO
                If dr("MAI") = 1 Then
                    gridPlanoDatas.SetCellImage(i, 7, _imgListLegenda.Images.Item(0))
                End If
                If dr("MAI") = 2 Then
                    gridPlanoDatas.SetCellImage(i, 7, _imgListLegenda.Images.Item(1))
                End If
                If dr("MAI") = 3 Then
                    gridPlanoDatas.SetCellImage(i, 7, _imgListLegenda.Images.Item(2))
                End If
                If dr("MAI") = 4 Then
                    gridPlanoDatas.SetCellImage(i, 7, _imgListLegenda.Images.Item(3))
                End If
                If dr("MAI") = 5 Then
                    gridPlanoDatas.SetCellImage(i, 7, _imgListLegenda.Images.Item(4))
                End If
                If dr("MAI") = 6 Then
                    gridPlanoDatas.SetCellImage(i, 7, _imgListLegenda.Images.Item(5))
                End If

                '--JUNHO
                If dr("JUN") = 1 Then
                    gridPlanoDatas.SetCellImage(i, 8, _imgListLegenda.Images.Item(0))
                End If
                If dr("JUN") = 2 Then
                    gridPlanoDatas.SetCellImage(i, 8, _imgListLegenda.Images.Item(1))
                End If
                If dr("JUN") = 3 Then
                    gridPlanoDatas.SetCellImage(i, 8, _imgListLegenda.Images.Item(2))
                End If
                If dr("JUN") = 4 Then
                    gridPlanoDatas.SetCellImage(i, 8, _imgListLegenda.Images.Item(3))
                End If
                If dr("JUN") = 5 Then
                    gridPlanoDatas.SetCellImage(i, 8, _imgListLegenda.Images.Item(4))
                End If
                If dr("JUN") = 6 Then
                    gridPlanoDatas.SetCellImage(i, 8, _imgListLegenda.Images.Item(5))
                End If

                '--JULHO
                If dr("JUL") = 1 Then
                    gridPlanoDatas.SetCellImage(i, 9, _imgListLegenda.Images.Item(0))
                End If
                If dr("JUL") = 2 Then
                    gridPlanoDatas.SetCellImage(i, 9, _imgListLegenda.Images.Item(1))
                End If
                If dr("JUL") = 3 Then
                    gridPlanoDatas.SetCellImage(i, 9, _imgListLegenda.Images.Item(2))
                End If
                If dr("JUL") = 4 Then
                    gridPlanoDatas.SetCellImage(i, 9, _imgListLegenda.Images.Item(3))
                End If
                If dr("JUL") = 5 Then
                    gridPlanoDatas.SetCellImage(i, 9, _imgListLegenda.Images.Item(4))
                End If
                If dr("JUL") = 6 Then
                    gridPlanoDatas.SetCellImage(i, 9, _imgListLegenda.Images.Item(5))
                End If

                '--AGOSTO
                If dr("AGO") = 1 Then
                    gridPlanoDatas.SetCellImage(i, 10, _imgListLegenda.Images.Item(0))
                End If
                If dr("AGO") = 2 Then
                    gridPlanoDatas.SetCellImage(i, 10, _imgListLegenda.Images.Item(1))
                End If
                If dr("AGO") = 3 Then
                    gridPlanoDatas.SetCellImage(i, 10, _imgListLegenda.Images.Item(2))
                End If
                If dr("AGO") = 4 Then
                    gridPlanoDatas.SetCellImage(i, 10, _imgListLegenda.Images.Item(3))
                End If
                If dr("AGO") = 5 Then
                    gridPlanoDatas.SetCellImage(i, 10, _imgListLegenda.Images.Item(4))
                End If
                If dr("AGO") = 6 Then
                    gridPlanoDatas.SetCellImage(i, 10, _imgListLegenda.Images.Item(5))
                End If

                '--SETEMBRO
                If dr("SET") = 1 Then
                    gridPlanoDatas.SetCellImage(i, 11, _imgListLegenda.Images.Item(0))
                End If
                If dr("SET") = 2 Then
                    gridPlanoDatas.SetCellImage(i, 11, _imgListLegenda.Images.Item(1))
                End If
                If dr("SET") = 3 Then
                    gridPlanoDatas.SetCellImage(i, 11, _imgListLegenda.Images.Item(2))
                End If
                If dr("SET") = 4 Then
                    gridPlanoDatas.SetCellImage(i, 11, _imgListLegenda.Images.Item(3))
                End If
                If dr("SET") = 5 Then
                    gridPlanoDatas.SetCellImage(i, 11, _imgListLegenda.Images.Item(4))
                End If
                If dr("SET") = 6 Then
                    gridPlanoDatas.SetCellImage(i, 11, _imgListLegenda.Images.Item(5))
                End If

                '--OUTUBRO
                If dr("OUT") = 1 Then
                    gridPlanoDatas.SetCellImage(i, 12, _imgListLegenda.Images.Item(0))
                End If
                If dr("OUT") = 2 Then
                    gridPlanoDatas.SetCellImage(i, 12, _imgListLegenda.Images.Item(1))
                End If
                If dr("OUT") = 3 Then
                    gridPlanoDatas.SetCellImage(i, 12, _imgListLegenda.Images.Item(2))
                End If
                If dr("OUT") = 4 Then
                    gridPlanoDatas.SetCellImage(i, 12, _imgListLegenda.Images.Item(3))
                End If
                If dr("OUT") = 5 Then
                    gridPlanoDatas.SetCellImage(i, 12, _imgListLegenda.Images.Item(4))
                End If
                If dr("OUT") = 6 Then
                    gridPlanoDatas.SetCellImage(i, 12, _imgListLegenda.Images.Item(5))
                End If

                '--NOVEMBRO
                If dr("NOV") = 1 Then
                    gridPlanoDatas.SetCellImage(i, 13, _imgListLegenda.Images.Item(0))
                End If
                If dr("NOV") = 2 Then
                    gridPlanoDatas.SetCellImage(i, 13, _imgListLegenda.Images.Item(1))
                End If
                If dr("NOV") = 3 Then
                    gridPlanoDatas.SetCellImage(i, 13, _imgListLegenda.Images.Item(2))
                End If
                If dr("NOV") = 4 Then
                    gridPlanoDatas.SetCellImage(i, 13, _imgListLegenda.Images.Item(3))
                End If
                If dr("NOV") = 5 Then
                    gridPlanoDatas.SetCellImage(i, 13, _imgListLegenda.Images.Item(4))
                End If
                If dr("NOV") = 6 Then
                    gridPlanoDatas.SetCellImage(i, 13, _imgListLegenda.Images.Item(5))
                End If

                '--DEZEMBRO
                If dr("DEZ") = 1 Then
                    gridPlanoDatas.SetCellImage(i, 14, _imgListLegenda.Images.Item(0))
                End If
                If dr("DEZ") = 2 Then
                    gridPlanoDatas.SetCellImage(i, 14, _imgListLegenda.Images.Item(1))
                End If
                If dr("DEZ") = 3 Then
                    gridPlanoDatas.SetCellImage(i, 14, _imgListLegenda.Images.Item(2))
                End If
                If dr("DEZ") = 4 Then
                    gridPlanoDatas.SetCellImage(i, 14, _imgListLegenda.Images.Item(3))
                End If
                If dr("DEZ") = 5 Then
                    gridPlanoDatas.SetCellImage(i, 14, _imgListLegenda.Images.Item(4))
                End If
                If dr("DEZ") = 6 Then
                    gridPlanoDatas.SetCellImage(i, 14, _imgListLegenda.Images.Item(5))
                End If

                i += 1

            Next

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "POPULA COMBOS"

    Sub CarregaComboAno()
        With comboAno
            .DataSource = Manager.Util.getDataTable("SELECT DISTINCT ANO FROM VW_LISTAGEM_TREINAMENTO_PLANO_ANUAL")
            .DisplayMember = "ANO"
            .ValueMember = "ANO"
        End With
    End Sub

#End Region

#Region "LOAD"
    Private Sub cotrProgramacaoAnual_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
#End Region

#Region "FILTRO POR ANO"

    Private Sub comboAno_ChangeCommitted(sender As System.Object, e As System.EventArgs) Handles comboAno.ChangeCommitted

        Dim ano As String

        Try

            If comboAno.ValueMember = "" Then
                CarregaComboAno()
            End If

            ano = comboAno.SelectedValue.ToString
            carregaListaDatasAno(ano)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub comboAno_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboAno.GotFocus
        Dim ano As String

        Try

            If comboAno.ValueMember = "" Then
                CarregaComboAno()
            End If

            ano = comboAno.SelectedValue.ToString
            carregaListaDatasAno(ano)

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "BOTÕES"

#Region "NOVO"
    Private Sub botNovo_Click(sender As System.Object, e As System.EventArgs) Handles botNovo.Click
        cotrAddProgTreinamentos.ShowDialog()
    End Sub
#End Region

#Region "EXCLUIR"

    Private Sub botExcluir_Click(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click

        If gridPlanoDatas.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma Programação cadastrada", "Programação de Treinamentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else

        End If

    End Sub

#End Region

#Region "RELATÓRIOS"

    Private Sub botRelatorio_Click(sender As System.Object, e As System.EventArgs) Handles botRelatorio.Click

        If gridPlanoDatas.RowSel <= 0 Then
            MessageBox.Show("Não à nenhuma Programação cadastrada", "Programação de Treinamentos", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else

        End If

    End Sub

#End Region

#End Region

#Region "CHAMAR O MENU"

    Private Sub gridPlanoDatas_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridPlanoDatas.MouseUp

        'Chama o Menu quando o mouse estiver em cima do grid
        If e.Button = Windows.Forms.MouseButtons.Right Then

            Menu_01.ShowContextMenu(gridPlanoDatas, e.Location)

        End If

    End Sub

#End Region

#Region "UM CLICK NO GRID"

    Private Sub gridPlanoDatas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridPlanoDatas.Click

        With gridPlanoDatas

            Dim Check As New planoAnualTreinamento

            Try
                'SE NADA
                If .GetData(.RowSel, .ColSel) = 6 Then
                    cmdProgramar.Enabled = True
                    cmdCancelar.Enabled = False
                    cmdReprogramar.Enabled = False
                    cmdRemover.Enabled = False
                    'SE PROGRAMADA
                ElseIf .GetData(.RowSel, .ColSel) = 1 Then
                    cmdProgramar.Enabled = False
                    cmdCancelar.Enabled = True
                    cmdReprogramar.Enabled = True
                    cmdRemover.Enabled = True
                    'SE CANCELADA
                ElseIf .GetData(.RowSel, .ColSel) = 3 Then
                    cmdProgramar.Enabled = False
                    cmdCancelar.Enabled = False
                    cmdReprogramar.Enabled = False
                    cmdRemover.Enabled = True
                    'SE REPROGRAMADA
                ElseIf .GetData(.RowSel, .ColSel) = 4 Then
                    cmdProgramar.Enabled = False
                    cmdReprogramar.Enabled = False
                    cmdCancelar.Enabled = True
                    cmdRemover.Enabled = True
                    'SE REALIZADA
                ElseIf .GetData(.RowSel, .ColSel) = 2 Then
                    cmdProgramar.Enabled = False
                    cmdReprogramar.Enabled = False
                    cmdCancelar.Enabled = False
                    cmdRemover.Enabled = False
                    'SE ATRASADA
                ElseIf .GetData(.RowSel, .ColSel) = 2 Then
                    cmdProgramar.Enabled = False
                    cmdReprogramar.Enabled = True
                    cmdCancelar.Enabled = True
                    cmdRemover.Enabled = True
                Else

                End If

            Catch ex As Exception
                ' MsgBox("Não foi possivel realizar a operação. Tente novamente.")
            End Try

        End With

    End Sub

#End Region

#Region "BOTÕES DO MENU"

#Region "PROGRAMAR"

    Private Sub cmdProgramar_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdProgramar.Click

        Dim Check As New planoAnualTreinamento
        Dim Tipo As Integer
        Dim setmes As String
        Dim ano As String
        Dim id As Integer
        ano = comboAno.Text

        Try

            With gridPlanoDatas

                'JAN
                If .ColSel = 3 Then
                    Try
                        setmes = "Janeiro"
                        Tipo = 1
                        id = gridPlanoDatas(.RowSel, 1)
                        Check.Update_Plano_JAN(id, _
                            Tipo)
                        Realizacao(Tipo, id, setmes)
                        carregaListaDatasAno(ano)
                    Catch ex As Exception
                        MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                    End Try
                End If

                'FEV
                If .ColSel = 4 Then
                    Try
                        setmes = "Fevereiro"
                        Tipo = 1
                        id = gridPlanoDatas(.RowSel, 1)
                        Check.Update_Plano_FEV(id, _
                            Tipo)
                        Realizacao(Tipo, id, setmes)
                        carregaListaDatasAno(ano)
                    Catch ex As Exception
                        MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                    End Try
                End If

                'MAR
                If .ColSel = 5 Then
                    Try
                        setmes = "Março"
                        Tipo = 1
                        id = gridPlanoDatas(.RowSel, 1)
                        Check.Update_Plano_MAR(id, _
                            Tipo)
                        Realizacao(Tipo, id, setmes)
                        carregaListaDatasAno(ano)
                    Catch ex As Exception
                        MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                    End Try
                End If

                'ABR
                If .ColSel = 6 Then
                    Try
                        setmes = "Abril"
                        Tipo = 1
                        id = gridPlanoDatas(.RowSel, 1)
                        Check.Update_Plano_ABR(id, _
                            Tipo)
                        Realizacao(Tipo, id, setmes)
                        carregaListaDatasAno(ano)
                    Catch ex As Exception
                        MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                    End Try
                End If

                'MAI
                If .ColSel = 7 Then
                    Try
                        setmes = "Maio"
                        Tipo = 1
                        id = gridPlanoDatas(.RowSel, 1)
                        Check.Update_Plano_MAI(id, _
                            Tipo)
                        Realizacao(Tipo, id, setmes)
                        carregaListaDatasAno(ano)
                    Catch ex As Exception
                        MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                    End Try
                End If

                'JUN
                If .ColSel = 8 Then
                    Try
                        setmes = "Junho"
                        Tipo = 1
                        id = gridPlanoDatas(.RowSel, 1)
                        Check.Update_Plano_JUN(id, _
                            Tipo)
                        Realizacao(Tipo, id, setmes)
                        carregaListaDatasAno(ano)
                    Catch ex As Exception
                        MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                    End Try
                End If

                'JUL
                If .ColSel = 9 Then
                    Try
                        setmes = "Julho"
                        Tipo = 1
                        id = gridPlanoDatas(.RowSel, 1)
                        Check.Update_Plano_JUL(id, _
                            Tipo)
                        Realizacao(Tipo, id, setmes)
                        carregaListaDatasAno(ano)
                    Catch ex As Exception
                        MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                    End Try
                End If

                'AGO
                If .ColSel = 10 Then
                    Try
                        setmes = "Agosto"
                        Tipo = 1
                        id = gridPlanoDatas(.RowSel, 1)
                        Check.Update_Plano_AGO(id, _
                            Tipo)
                        Realizacao(Tipo, id, setmes)
                        carregaListaDatasAno(ano)
                    Catch ex As Exception
                        MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                    End Try
                End If

                'SET
                If .ColSel = 11 Then
                    Try
                        setmes = "Setembro"
                        Tipo = 1
                        id = gridPlanoDatas(.RowSel, 1)
                        Check.Update_Plano_SET(id, _
                            Tipo)
                        Realizacao(Tipo, id, setmes)
                        carregaListaDatasAno(ano)
                    Catch ex As Exception
                        MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                    End Try
                End If

                'OUT
                If .ColSel = 12 Then
                    Try
                        setmes = "Outubro"
                        Tipo = 1
                        id = gridPlanoDatas(.RowSel, 1)
                        Check.Update_Plano_OUT(id, _
                            Tipo)
                        Realizacao(Tipo, id, setmes)
                        carregaListaDatasAno(ano)
                    Catch ex As Exception
                        MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                    End Try
                End If

                'NOV
                If .ColSel = 13 Then
                    Try
                        setmes = "Novembro"
                        Tipo = 1
                        id = gridPlanoDatas(.RowSel, 1)
                        Check.Update_Plano_NOV(id, _
                            Tipo)
                        Realizacao(Tipo, id, setmes)
                        carregaListaDatasAno(ano)
                    Catch ex As Exception
                        MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                    End Try
                End If

                'DEZ
                If .ColSel = 14 Then
                    Try
                        setmes = "Dezembro"
                        Tipo = 1
                        id = gridPlanoDatas(.RowSel, 1)
                        Check.Update_Plano_DEZ(id, _
                            Tipo)
                        Realizacao(Tipo, id, setmes)
                        carregaListaDatasAno(ano)
                    Catch ex As Exception
                        MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                    End Try
                End If
            End With

        Catch ex As Exception
            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
        End Try

    End Sub

#End Region

#Region "CANCELAR"

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdCancelar.Click

        Dim setmes As String
        Dim ano As String
        Dim id As Integer
        ano = comboAno.Text

        Dim ms As DialogResult = MessageBox.Show("Deseja realmente cancelar a calibração ?", "Plano Anual de Calibração", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Try

            With gridPlanoDatas

                Dim Check As New planoAnualTreinamento
                Dim Tipo As Integer

                'JAN
                If .ColSel = 3 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Janeiro"
                            Tipo = 3
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_JAN(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'FEV
                If .ColSel = 4 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Fevereiro"
                            Tipo = 3
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_FEV(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'MAR
                If .ColSel = 5 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Março"
                            Tipo = 3
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_MAR(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'ABR
                If .ColSel = 6 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Abril"
                            Tipo = 3
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_ABR(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'MAI
                If .ColSel = 7 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Maio"
                            Tipo = 3
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_MAI(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'JUN
                If .ColSel = 8 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Junho"
                            Tipo = 3
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_JUN(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'JUL
                If .ColSel = 9 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Julho"
                            Tipo = 3
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_JUL(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'AGO
                If .ColSel = 10 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Agosto"
                            Tipo = 3
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_AGO(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'SET
                If .ColSel = 11 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Setembro"
                            Tipo = 3
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_SET(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'OUT
                If .ColSel = 12 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Outubro"
                            Tipo = 3
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_OUT(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'NOV
                If .ColSel = 13 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Novembro"
                            Tipo = 3
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_NOV(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'DEZ
                If .ColSel = 14 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Dezembro"
                            Tipo = 3
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_DEZ(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

            End With

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "REPROGRAMAR"

    Private Sub cmdReprogramar_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdReprogramar.Click

        Dim setmes As String
        Dim ano As String
        Dim id As Integer
        ano = comboAno.Text

        Dim ms As DialogResult = MessageBox.Show("Deseja realmente Reprogramar a calibração ?", "Plano Anual de Calibração", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Try

            With gridPlanoDatas

                Dim Check As New planoAnualTreinamento
                Dim Tipo As Integer

                'JAN
                If .ColSel = 3 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Janeiro"
                            Tipo = 4
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_JAN(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'FEV
                If .ColSel = 4 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Fevereiro"
                            Tipo = 4
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_FEV(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'MAR
                If .ColSel = 5 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Março"
                            Tipo = 4
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_MAR(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'ABR
                If .ColSel = 6 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Abril"
                            Tipo = 4
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_ABR(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'MAI
                If .ColSel = 7 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Maio"
                            Tipo = 4
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_MAI(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'JUN
                If .ColSel = 8 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Junho"
                            Tipo = 4
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_JUN(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'JUL
                If .ColSel = 9 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Julho"
                            Tipo = 4
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_JUL(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'AGO
                If .ColSel = 10 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Agosto"
                            Tipo = 4
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_AGO(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'SET
                If .ColSel = 11 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Setembro"
                            Tipo = 4
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_SET(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'OUT
                If .ColSel = 12 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Outubro"
                            Tipo = 4
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_OUT(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'NOV
                If .ColSel = 13 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Novembro"
                            Tipo = 4
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_NOV(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'DEZ
                If .ColSel = 14 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Dezembro"
                            Tipo = 4
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_DEZ(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

            End With

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "REMOVER"

    Private Sub cmdRemover_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdRemover.Click

        Dim setmes As String
        Dim ano As String
        Dim id As Integer
        ano = comboAno.Text

        Dim ms As DialogResult = MessageBox.Show("Deseja realmente Remover a calibração ?", "Plano Anual de Calibração", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Try

            With gridPlanoDatas

                Dim Check As New planoAnualTreinamento
                Dim Tipo As Integer

                'JAN
                If .ColSel = 3 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Janeiro"
                            Tipo = 6
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_JAN(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'FEV
                If .ColSel = 4 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Fevereiro"
                            Tipo = 6
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_FEV(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'MAR
                If .ColSel = 5 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Março"
                            Tipo = 6
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_MAR(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'ABR
                If .ColSel = 6 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Abril"
                            Tipo = 6
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_ABR(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'MAI
                If .ColSel = 7 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Maio"
                            Tipo = 6
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_MAI(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'JUN
                If .ColSel = 8 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Junho"
                            Tipo = 6
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_JUN(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'JUL
                If .ColSel = 9 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Julho"
                            Tipo = 6
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_JUL(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'AGO
                If .ColSel = 10 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Agosto"
                            Tipo = 6
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_AGO(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'SET
                If .ColSel = 11 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Setembro"
                            Tipo = 6
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_SET(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'OUT
                If .ColSel = 12 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Outubro"
                            Tipo = 6
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_OUT(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'NOV
                If .ColSel = 13 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Novembro"
                            Tipo = 6
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_NOV(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

                'DEZ
                If .ColSel = 14 Then
                    If ms = DialogResult.Yes Then
                        Try
                            setmes = "Dezembro"
                            Tipo = 6
                            id = gridPlanoDatas(.RowSel, 1)
                            Check.Update_Plano_DEZ(id, _
                                Tipo)
                            Realizacao(Tipo, id, setmes)
                            carregaListaDatasAno(ano)
                        Catch ex As Exception
                            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                        End Try
                    End If
                Else

                End If

            End With

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "CHECA ATRASADA"

    Public Sub ChecaAtrasada()

        Dim setmes As String
        Dim ano As String
        ano = comboAno.Text

        Try

            With gridPlanoDatas

                Dim Check As New planoAnualTreinamento
                Dim Tipo As Integer

                'JAN
                If .ColSel = 3 Then
                    Try
                        setmes = "Janeiro"
                        Tipo = 5
                        Check.Update_Plano_JAN((.RowSel), _
                           Tipo)
                        Realizacao(Tipo, .RowSel, setmes)
                        carregaListaDatasAno(ano)
                    Catch ex As Exception
                        MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                    End Try
                End If

                'FEV
                If .ColSel = 4 Then
                    Try
                        setmes = "Fevereiro"
                        Tipo = 5
                        Check.Update_Plano_FEV((.RowSel), _
                            Tipo)
                        Realizacao(Tipo, .RowSel, setmes)
                        carregaListaDatasAno(ano)
                    Catch ex As Exception
                        MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                    End Try
                End If

                'MAR
                If .ColSel = 5 Then
                    Try
                        setmes = "Março"
                        Tipo = 5
                        Check.Update_Plano_MAR((.RowSel), _
                            Tipo)
                        Realizacao(Tipo, .RowSel, setmes)
                        carregaListaDatasAno(ano)
                    Catch ex As Exception
                        MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                    End Try
                End If

                'ABR
                If .ColSel = 6 Then
                    Try
                        setmes = "Abril"
                        Tipo = 5
                        Check.Update_Plano_ABR((.RowSel), _
                            Tipo)
                        Realizacao(Tipo, .RowSel, setmes)
                        carregaListaDatasAno(ano)
                    Catch ex As Exception
                        MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                    End Try
                End If

                'MAI
                If .ColSel = 7 Then
                    Try
                        setmes = "Maio"
                        Tipo = 5
                        Check.Update_Plano_MAI((.RowSel), _
                            Tipo)
                        Realizacao(Tipo, .RowSel, setmes)
                        carregaListaDatasAno(ano)
                    Catch ex As Exception
                        MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                    End Try
                End If

                'JUN
                If .ColSel = 8 Then
                    Try
                        setmes = "Junho"
                        Tipo = 5
                        Check.Update_Plano_JUN((.RowSel), _
                            Tipo)
                        Realizacao(Tipo, .RowSel, setmes)
                        carregaListaDatasAno(ano)
                    Catch ex As Exception
                        MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                    End Try
                End If

                'JUL
                If .ColSel = 9 Then
                    Try
                        setmes = "Julho"
                        Tipo = 5
                        Check.Update_Plano_JUL((.RowSel), _
                            Tipo)
                        Realizacao(Tipo, .RowSel, setmes)
                        carregaListaDatasAno(ano)
                    Catch ex As Exception
                        MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                    End Try
                End If

                'AGO
                If .ColSel = 10 Then
                    Try
                        setmes = "Agosto"
                        Tipo = 5
                        Check.Update_Plano_AGO((.RowSel), _
                            Tipo)
                        Realizacao(Tipo, .RowSel, setmes)
                        carregaListaDatasAno(ano)
                    Catch ex As Exception
                        MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                    End Try
                End If

                'SET
                If .ColSel = 11 Then
                    Try
                        setmes = "Setembro"
                        Tipo = 5
                        Check.Update_Plano_SET((.RowSel), _
                            Tipo)
                        Realizacao(Tipo, .RowSel, setmes)
                        carregaListaDatasAno(ano)
                    Catch ex As Exception
                        MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                    End Try
                End If

                'OUT
                If .ColSel = 12 Then
                    Try
                        setmes = "Outubro"
                        Tipo = 5
                        Check.Update_Plano_OUT((.RowSel), _
                            Tipo)
                        Realizacao(Tipo, .RowSel, setmes)
                        carregaListaDatasAno(ano)
                    Catch ex As Exception
                        MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                    End Try
                End If

                'NOV
                If .ColSel = 13 Then
                    Try
                        setmes = "Novembro"
                        Tipo = 5
                        Check.Update_Plano_NOV((.RowSel), _
                            Tipo)
                        Realizacao(Tipo, .RowSel, setmes)
                        carregaListaDatasAno(ano)
                    Catch ex As Exception
                        MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                    End Try
                End If

                'DEZ
                If .ColSel = 14 Then
                    Try
                        setmes = "Dezembro"
                        Tipo = 5
                        Check.Update_Plano_DEZ((.RowSel), _
                            Tipo)
                        Realizacao(Tipo, .RowSel, setmes)
                        carregaListaDatasAno(ano)
                    Catch ex As Exception
                        MsgBox("Não foi possivel realizar a operação. Tente novamente.")
                    End Try
                End If

            End With

        Catch ex As Exception

        End Try

    End Sub

#End Region

#End Region

#Region "REALIZACAO"

    Public Sub Realizacao(ByVal t As Integer, ByVal id As Integer, ByVal mes As String)

        Dim Check As New planoAnualTreinamento

        Dim Sit As String
        Dim Ano As String
        Dim Acao As String
        Dim Numero As String

        Dim sql As String = String.Format("SELECT * FROM TREINAMENTO_PLANO WHERE ID_TREINAMETO_PLANO = {0}", id)

        Try

            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            While dr.Read

                'PROGRAMADA
                If t = 1 Then
                    Acao = dr("ACAO")
                    Numero = dr("NUMERO")
                    Ano = dr("ANO")
                    Sit = "Programada"
                    Dim sql2 As String = String.Format("SELECT * FROM TREINAMENTO_REALIZAR WHERE ID_TREINAMETO_PLANO = {0}", id)
                    Dim dr2 As SqlDataReader = Manager.Util.getDataReader(sql2)

                    If dr2.HasRows = True Then
                        While dr2.Read
                            If id = dr2("ID_TREINAMETO_PLANO") And Acao = dr2("ACAO") And Ano = dr2("ANO") And mes = dr2("mes") Then
                                Check.DeleteRealiza(id, Acao, Ano, mes)
                                Check.AddRealiza((id), Acao, Numero, Ano, mes, Sit)
                                Exit Sub
                            End If
                        End While
                        Check.AddRealiza((id), Acao, Numero, Ano, mes, Sit)
                    Else
                        Check.AddRealiza((id), Acao, Numero, Ano, mes, Sit)
                    End If

                End If

                'REALIZADA
                If t = 2 Then
                    Acao = dr("ACAO")
                    Numero = dr("NUMERO")
                    Ano = dr("ANO")
                    Sit = "Realizada"
                    Dim sql2 As String = String.Format("SELECT * FROM TREINAMENTO_REALIZAR WHERE ID_TREINAMETO_PLANO = {0}", id)
                    Dim dr2 As SqlDataReader = Manager.Util.getDataReader(sql2)

                    If dr2.HasRows = True Then
                        While dr2.Read
                            If id = dr2("ID_TREINAMETO_PLANO") And Acao = dr2("ACAO") And Ano = dr2("ANO") And mes = dr2("mes") Then
                                Check.DeleteRealiza(id, Acao, Ano, mes)
                                Check.AddRealiza((id), Acao, Numero, Ano, mes, Sit)
                                Exit Sub
                            End If
                        End While
                        Check.AddRealiza((id), Acao, Numero, Ano, mes, Sit)
                    Else
                        Check.AddRealiza((id), Acao, Numero, Ano, mes, Sit)
                    End If
                End If

                'CANCELADA
                If t = 3 Then
                    Acao = dr("ACAO")
                    Numero = dr("NUMERO")
                    Ano = dr("ANO")
                    Sit = "Cancelada"
                    Dim sql2 As String = String.Format("SELECT * FROM TREINAMENTO_REALIZAR WHERE ID_TREINAMETO_PLANO = {0}", id)
                    Dim dr2 As SqlDataReader = Manager.Util.getDataReader(sql2)

                    If dr2.HasRows = True Then
                        While dr2.Read
                            If id = dr2("ID_TREINAMETO_PLANO") And Acao = dr2("ACAO") And Ano = dr2("ANO") And mes = dr2("mes") Then
                                Check.DeleteRealiza(id, Acao, Ano, mes)
                                Check.AddRealiza((id), Acao, Numero, Ano, mes, Sit)
                                Exit Sub
                            End If
                        End While
                        Check.AddRealiza((id), Acao, Numero, Ano, mes, Sit)
                    Else
                        Check.AddRealiza((id), Acao, Numero, Ano, mes, Sit)
                    End If
                End If

                'REPROGRAMAR
                If t = 4 Then
                    Acao = dr("ACAO")
                    Numero = dr("NUMERO")
                    Ano = dr("ANO")
                    Sit = "Reprogramada"
                    Dim sql2 As String = String.Format("SELECT * FROM TREINAMENTO_REALIZAR WHERE ID_TREINAMETO_PLANO = {0}", id)
                    Dim dr2 As SqlDataReader = Manager.Util.getDataReader(sql2)

                    If dr2.HasRows = True Then
                        While dr2.Read
                            If id = dr2("ID_TREINAMETO_PLANO") And Acao = dr2("ACAO") And Ano = dr2("ANO") And mes = dr2("mes") Then
                                Check.DeleteRealiza(id, Acao, Ano, mes)
                                Check.AddRealiza((id), Acao, Numero, Ano, mes, Sit)
                                Exit Sub
                            End If
                        End While
                        Check.AddRealiza((id), Acao, Numero, Ano, mes, Sit)
                    Else
                        Check.AddRealiza((id), Acao, Numero, Ano, mes, Sit)
                    End If
                End If

                'ATRASADA
                If t = 5 Then
                    Acao = dr("ACAO")
                    Numero = dr("NUMERO")
                    Ano = dr("ANO")
                    Sit = "Atrasada"
                    Dim sql2 As String = String.Format("SELECT * FROM TREINAMENTO_REALIZAR WHERE ID_TREINAMETO_PLANO = {0}", id)
                    Dim dr2 As SqlDataReader = Manager.Util.getDataReader(sql2)

                    If dr2.HasRows = True Then
                        While dr2.Read
                            If id = dr2("ID_TREINAMETO_PLANO") And Acao = dr2("ACAO") And Ano = dr2("ANO") And mes = dr2("mes") Then
                                Check.DeleteRealiza(id, Acao, Ano, mes)
                                Check.AddRealiza((id), Acao, Numero, Ano, mes, Sit)
                                Exit Sub
                            End If
                        End While
                        Check.AddRealiza((id), Acao, Numero, Ano, mes, Sit)
                    Else
                        Check.AddRealiza((id), Acao, Numero, Ano, mes, Sit)
                    End If
                End If

                'REMOVER
                If t = 6 Then
                    Acao = dr("ACAO")
                    Numero = dr("NUMERO")
                    Ano = dr("ANO")
                    Dim sql2 As String = String.Format("SELECT * FROM TREINAMENTO_REALIZAR WHERE ID_TREINAMETO_PLANO = {0}", id)
                    Dim dr2 As SqlDataReader = Manager.Util.getDataReader(sql2)

                    If dr2.HasRows = True Then
                        While dr2.Read
                            If id = dr2("ID_TREINAMETO_PLANO") And Acao = dr2("ACAO") And Ano = dr2("ANO") And mes = dr2("mes") Then
                                Check.DeleteRealiza(id, Acao, Ano, mes)
                                Exit Sub
                            End If
                        End While
                    End If
                End If

            End While
        Catch ex As Exception
            MsgBox("Não foi possivel realizar a operação. Tente novamente.")
        End Try
    End Sub

#End Region

End Class
