Public Class Form1

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BACEPTAR_Click(sender As Object, e As EventArgs) Handles BACEPTAR.Click
        If (SALACINE < 9) Then
            TFUNCION(SALACINE) = CFUNCION.SelectedItem
            LCINE(SALACINE) = CCINE.SelectedItem
            ENTRADAS(SALACINE) = TENTRADAS.Text
            TPAGO1(SALACINE) = CALCULARPARCIAL(LCINE(SALACINE), TFUNCION(SALACINE)) * Val(TENTRADAS.Text)
            DESC1(SALACINE) = CALCULODESCUENTO1(LCINE(SALACINE), TFUNCION(SALACINE)) * Val(TENTRADAS.Text)
            DESC2(SALACINE) = CALCULODESCUENTO2(TPAGO1(SALACINE)) * TPAGO1(SALACINE)
            PAGOT(SALACINE) = TPAGO1(SALACINE) - DESC1(SALACINE) - DESC2(SALACINE)
        Else
            MsgBox("LIMITE DE DATOS ALCANZADOS")
        End If
        DataGridView1.Rows.Add(TFUNCION(SALACINE), LCINE(SALACINE), ENTRADAS(SALACINE), TPAGO1(SALACINE), DESC1(SALACINE), DESC2(SALACINE), PAGOT(SALACINE))
        SALACINE = SALACINE + 1
    End Sub

    Private Sub BLIMPIAR_Click(sender As Object, e As EventArgs) Handles BLIMPIAR.Click
        LIMPIAR()
    End Sub

    Private Sub BSALIR_Click(sender As Object, e As EventArgs) Handles BSALIR.Click
        SALIR()

    End Sub
End Class
