Imports System
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Windows.Forms

Namespace Manager

#Region "CLASSE UTIL"

    Public Class Util

#Region "DataReader"

        Public Shared Function getDataReader(ByVal strQuery As String) As SqlDataReader

            Dim _connectionString As String = My.Settings.connectionString
            Dim _Connection As New SqlConnection(_connectionString)
            Dim _Command As SqlCommand

            If _Connection.State = ConnectionState.Closed Then
                _Connection.Open()
            End If

            _Command = New SqlCommand(strQuery, _Connection)
            _Command.CommandType = CommandType.Text

            Dim drParametros As SqlDataReader = _Command.ExecuteReader(CommandBehavior.CloseConnection)

            getDataReader = drParametros

        End Function

#End Region

#Region "DataTable"

        Public Shared Function getDataTable(ByVal strQuery As String) As DataTable

            Dim _connectionString As String = My.Settings.connectionString
            Dim _Connection As New SqlConnection(_connectionString)
            Dim _Command As SqlCommand
            Dim _ds As New DataSet

            If _Connection.State = ConnectionState.Closed Then
                _Connection.Open()
            End If

            _Command = New SqlCommand(strQuery, _Connection)
            _Command.CommandType = CommandType.Text

            Dim _adapter As New SqlDataAdapter(_Command)

            _adapter.Fill(_ds)

            Return _ds.Tables(0)


        End Function

        Public Shared Function getDataTableById(ByVal strQuery As String) As DataTable

            Dim _connectionString As String = My.Settings.connectionString
            Dim _Connection As New SqlConnection(_connectionString)
            Dim _Command As SqlCommand
            Dim _ds As New DataSet

            If _Connection.State = ConnectionState.Closed Then
                _Connection.Open()
            End If

            _Command = New SqlCommand(strQuery, _Connection)
            _Command.CommandType = CommandType.Text

            Dim _adapter As New SqlDataAdapter(_Command)

            _adapter.Fill(_ds)

            Return _ds.Tables(0)

        End Function

#End Region

#Region "Demais Classes"

        Public Class KeyValuePair

            Public newDisplayMember As Object
            Public newValueMember As Object

            Public Sub New(ByVal key As Object, ByVal value As Object)
                newDisplayMember = key
                newValueMember = value
            End Sub

            Public Overrides Function ToString() As String

                Return newValueMember

            End Function

        End Class

        Protected Friend Function Logon(ByVal usuario As String, _
                                        ByVal senha As String, _
                                        Optional ByRef idCliente As Integer = 0, _
                                        Optional ByRef idUsuario As Integer = 0, _
                                        Optional ByRef nome As String = "", _
                                        Optional ByRef email As String = "", _
                                        Optional ByRef isAdmin As Boolean = False) As Boolean

            Dim odr As SqlDataReader
            Dim sql As String = String.Format("SELECT * FROM USUARIOS WHERE LOGIN = '{0}' AND SENHA = '{1}'", usuario, senha)
            odr = getDataReader(sql)

            If odr.Read Then

                idCliente = odr("IDCLIENTE").ToString
                idUsuario = odr("IDUSUARIO").ToString
                nome = odr("NOME").ToString
                email = odr("EMAIL").ToString
                isAdmin = odr("ADMIN").ToString

                Return True
            Else
                Return False
            End If

        End Function

        Public Shared Function openTextFile(ByVal filePath As String) As String

            Dim retString As String = ""

            Try

                Dim fileStream As New IO.StreamReader(filePath)
                retString = fileStream.ReadToEnd

                fileStream.Close()

            Catch ex As Exception
                retString = ""
            End Try

            Return retString

        End Function

        Public Shared Function App_Path() As String
            Return System.AppDomain.CurrentDomain.BaseDirectory()
        End Function

        Public Shared Sub resetControls(ByVal c As Control)

            For Each ctrl As Control In c.Controls

                If TypeOf ctrl Is TextBox Then
                    CType(ctrl, TextBox).Text = ""
                End If

                If TypeOf ctrl Is MaskedTextBox Then
                    CType(ctrl, MaskedTextBox).Text = ""
                End If

                If TypeOf ctrl Is ComboBox Then
                    CType(ctrl, ComboBox).SelectedIndex = -1
                End If

            Next

        End Sub

        Public Shared Sub executeNonQuery(ByVal sql As String)

            Dim _connectionString As String = My.Settings.connectionString
            Dim _Connection As New SqlConnection(_connectionString)
            Dim _Command As SqlCommand

            If _Connection.State = ConnectionState.Closed Then
                _Connection.Open()
            End If

            _Command = New SqlCommand(sql, _Connection)
            _Command.CommandType = CommandType.Text

            _Command.ExecuteNonQuery()

        End Sub

        Public Shared Function IsEmail(ByVal email As String) As Boolean
            Return Regex.IsMatch(email, "^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        End Function

        Public Shared Sub FechaJanelas()
            'AnaliseCritica
            acListaDados.Close()
            acListaDecisoes.Close()
            acListaReuniao.Close()
            'Auditorias
            audListaTipoAuditorias.Close()
            audListaAuditores.Close()
            audRealizarAuditorias.Close()
            audProgramacaoAuditorias.Close()
            audChecklist.Close()
            'Avaliação de Fornecedores
            forListaOcorrencias.Close()
            'Calibração
            calListaInstrumentos.Close()
            calProgramacaoCalibracao.Close()
            calRealizarCalibracoes.Close()
            'Treinamentos
            cotrListaCargos.Close()
            cotrRealizacaoTreinamentos.Close()
            cotrProgramacaoTreinamentos.Close()
            cotrCurriculo.Close()
            'Configurações
            configSenhasPrincipal.Close()
            configListaBasico.Close()
            configOpcoesPrincipal.Close()
            ConfigPrefUsuarios.Close()
            'Melhorias
            melListaMelhorias.Close()
            melCadMelhorias.Close()
            'Politica/Objetivos
            poliListaPolitica.Close()
            objListaObjetivos.Close()
            'Produtos/Processos
            prodListaProdutos.Close()
            procListaProcessos.Close()
            'Projetos
            projListaProjetos.Close()
            projListaOcorrencias.Close()
            projListaResultados.Close()
            'Satisfacao de Clientes
            'cliListaClientes.Close()
        End Sub

#End Region

    End Class

#End Region

#Region "CLASSE USUARIOS"

    Public Class Usuarios

        Public Function Add(ByVal login As String, _
                            ByVal senha As String, _
                            ByVal nome As String, _
                            ByVal email As String, _
                            ByVal telefone As String, _
                            ByVal tipo As String, _
                            Optional ByRef idUsuario As Integer = 0) As Boolean

            Dim _connectionString As String = My.Settings.connectionString
            Dim _Connection As SqlConnection
            Dim _Command As SqlCommand
            Dim _cmdText As String = "[INSERT_USUARIOS]"

            Try

                _Connection = New SqlConnection(_connectionString)
                _Connection.Open()

                _Command = New SqlCommand(_cmdText, _Connection)
                _Command.CommandType = CommandType.StoredProcedure

                'Limpar dirty-char
                telefone = Regex.Replace(telefone, "[^0-9]", "")

                With _Command.Parameters
                    .AddWithValue("@NOME", nome)
                    .AddWithValue("@EMAIL", email)
                    .AddWithValue("@LOGIN", login)
                    .AddWithValue("@SENHA", senha)
                    .AddWithValue("@TELEFONE", telefone)

                End With

                idUsuario = _Command.ExecuteScalar
                _Connection.Close()

                Return True

            Catch ex As Exception
                Return False
            End Try


        End Function

        Public Function Update(ByVal id As String, _
                                ByVal login As String, _
                                ByVal senha As String, _
                                ByVal nome As String, _
                                ByVal email As String, _
                                ByVal telefone As String, _
                                ByVal tipo As String) As Boolean

            Dim _connectionString As String = My.Settings.connectionString
            Dim _Connection As SqlConnection
            Dim _Command As SqlCommand
            Dim _cmdText As String = "[UPDATE_USUARIOS]"

            Try

                _Connection = New SqlConnection(_connectionString)
                _Connection.Open()

                _Command = New SqlCommand(_cmdText, _Connection)
                _Command.CommandType = CommandType.StoredProcedure

                'Limpar dirty-char
                telefone = Regex.Replace(telefone, "[^0-9]", "")

                With _Command.Parameters
                    .AddWithValue("@IDUSUARIO", id)
                    .AddWithValue("@NOME", nome)
                    .AddWithValue("@EMAIL", email)
                    .AddWithValue("@LOGIN", login)
                    .AddWithValue("@SENHA", senha)
                    .AddWithValue("@TELEFONE", telefone)

                End With

                _Command.ExecuteNonQuery()
                _Connection.Close()

                Return True

            Catch ex As Exception
                Return False
            End Try

        End Function

        Public Function Delete(ByVal id As Integer) As Boolean

            Dim _connectionString As String = My.Settings.connectionString
            Dim _Connection As SqlConnection
            Dim _Command As SqlCommand
            Dim _cmdText As String = "[DELETE_USUARIO]"

            Try

                _Connection = New SqlConnection(_connectionString)
                _Connection.Open()

                _Command = New SqlCommand(_cmdText, _Connection)
                _Command.CommandType = CommandType.StoredProcedure

                With _Command.Parameters
                    .AddWithValue("@IDUSUARIO", id)
                End With

                _Command.ExecuteNonQuery()
                _Connection.Close()

                Return True

            Catch ex As Exception
                Return False
            End Try

        End Function

    End Class
#End Region

#Region "CLASSE EMAIL"

    Public Class Email

        Private _smtpHost As String = ""
        Private _smtpUsername As String = ""
        Private _smtpPassword As String = ""

        Private _mailTo As String = ""
        Private _mailFrom As String = ""
        Private _mailSubject As String = ""
        Private _mailBody As String = ""

        Public Sub New()

            _smtpHost = ""
            _smtpUsername = ""
            _smtpPassword = ""

            carregarConfiguracoes()

        End Sub

        Private Sub carregarConfiguracoes()

            Dim sql As String = "SELECT * FROM CONFIG_EMAIL"
            Dim dr As SqlDataReader = Manager.Util.getDataReader(sql)

            If Not dr Is Nothing Then

                If dr.Read Then

                    _smtpHost = dr("HOST").ToString
                    _smtpUsername = dr("USERNAME").ToString
                    _smtpPassword = dr("PASSWORD").ToString

                End If

            End If

        End Sub

        Public Sub Enviar(ByVal mailTo As String, _
                           ByVal mailFrom As String, _
                           ByVal mailSubject As String, _
                           ByVal mailBody As String)

            _mailTo = mailTo
            _mailFrom = mailFrom
            _mailSubject = mailSubject
            _mailBody = mailBody

            Dim threadEmail As New System.Threading.Thread(AddressOf EnviarThread)
            threadEmail.Start()

        End Sub

        Private Sub EnviarThread()

            Dim correo As New System.Net.Mail.MailMessage

            Try

                With correo
                    .From = New System.Net.Mail.MailAddress(_mailFrom)
                    .To.Add(_mailTo)
                    .Subject = _mailSubject
                    .Body = _mailBody
                    .IsBodyHtml = True
                    .Priority = System.Net.Mail.MailPriority.High
                End With

                correo.SubjectEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1")
                correo.BodyEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1")

                Dim smtp As New System.Net.Mail.SmtpClient

                smtp.Credentials = New System.Net.NetworkCredential(_smtpUsername, _smtpPassword)
                smtp.Host = _smtpHost

                smtp.Send(correo)

            Catch ex As Exception

            End Try

        End Sub

    End Class
#End Region

#Region "CLASSE ANEXOS"

    Public Class Anexos

#Region "ADD ANEXO"

        Public Shared Function Add(ByVal MODULOS As String, _
                               ByVal ID_NO_MODULO As Integer, _
                               ByVal TELA As String, _
                               ByVal DESCRICAO As String, _
                               ByVal ANEXO() As Byte, _
                               ByVal TIPO As String, _
                            Optional ByRef idAnexo As Integer = 0) As Boolean

            Dim _connectionString As String = My.Settings.connectionString
            Dim _Connection As SqlConnection
            Dim _Command As SqlCommand
            Dim _cmdText As String = "INSERT_ANEXOS"

            Try

                _Connection = New SqlConnection(_connectionString)
                _Connection.Open()

                _Command = New SqlCommand(_cmdText, _Connection)
                _Command.CommandType = CommandType.StoredProcedure

                With _Command.Parameters
                    .AddWithValue("@MODULOS", MODULOS)
                    .AddWithValue("@ID_NO_MODULO", ID_NO_MODULO)
                    .AddWithValue("@TELA", TELA)
                    .AddWithValue("@DESCRICAO", DESCRICAO)
                    .AddWithValue("@ANEXO", ANEXO)
                    .AddWithValue("@TIPO", TIPO)
                End With

                idAnexo = _Command.ExecuteScalar
                _Connection.Close()

                Return True

            Catch ex As Exception
                Return False
            End Try

        End Function

#End Region

#Region "DELETE ANEXO"

        Public Shared Function Delete(ByVal MODULOS As String, _
                                     ByVal ID_NO_MODULO As Integer, _
                                     ByVal TELA As String) As Boolean

            Dim _connectionString As String = My.Settings.connectionString
            Dim _Connection As SqlConnection
            Dim _Command As SqlCommand
            Dim _cmdText As String = "[DELETE_ANEXOS]"

            Try

                _Connection = New SqlConnection(_connectionString)
                _Connection.Open()

                _Command = New SqlCommand(_cmdText, _Connection)
                _Command.CommandType = CommandType.StoredProcedure

                With _Command.Parameters
                    .AddWithValue("@MODULOS", MODULOS)
                    .AddWithValue("@ID_NO_MODULO", ID_NO_MODULO)
                    .AddWithValue("@TELA", TELA)
                End With

                _Command.ExecuteNonQuery()
                _Connection.Close()

                Return True

            Catch ex As Exception
                Return False
            End Try

        End Function

#End Region

    End Class

#End Region

End Namespace

