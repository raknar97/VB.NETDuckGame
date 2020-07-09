Public Class Form1
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        crear_Patos(pnlPatos)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnMatar_Click(sender As Object, e As EventArgs) Handles btnMatar.Click
        matar_pajaros(nud.Value)
    End Sub
End Class
