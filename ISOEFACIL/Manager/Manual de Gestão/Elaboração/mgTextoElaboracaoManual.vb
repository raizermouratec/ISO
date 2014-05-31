Public Class mgTextoElaboracaoManual

    Private Sub mgTextoItensManual_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub botSalvar_Click(sender As System.Object, e As System.EventArgs) Handles botSalvar.Click
        MessageBox.Show("Texto do Manual salvo com sucesso", "Edição de Texto", Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
