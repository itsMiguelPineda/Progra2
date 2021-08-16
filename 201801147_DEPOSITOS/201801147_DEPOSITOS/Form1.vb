Public Class Form1
    
  
    Private Sub CCP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CCP.CheckedChanged
        If (CCP.Checked) Then
            TCPMONTO.Visible = True
            TCPMONTO.Focus()
        Else
            TCPMONTO.Clear()
            TCPMONTO.Visible = False
        End If
    End Sub
    Private Sub CCB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CCB.CheckedChanged
        If (CCB.Checked) Then
            TCOMONTO.Visible = True
            TCOMONTO.Focus()
        Else
            TCOMONTO.Clear()
            TCOMONTO.Visible = False
        End If
    End Sub
    Private Sub CE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CE.CheckedChanged
        If (CE.Checked) Then
            TEMONTO.Visible = True
            TEMONTO.Focus()
        Else
            TEMONTO.Clear()
            TEMONTO.Visible = False
        End If
    End Sub
    Private Sub CALCULAR_Click(sender As Object, e As EventArgs) Handles CALCULAR.Click
        If (TSAMONTO.Text = "") Then
            MsgBox("DEBE INGRESAR UN MONTO PARA PODER AVANZAR")
            TSAMONTO.Focus()
        End If
        'calculo
        If RMONETARIO.Checked = True Then
            NUEVOSALDO = Val(TCPMONTO.Text) + Val(TCOMONTO.Text) + Val(TEMONTO.Text)
            RESULTADO.Text = Val(NUEVOSALDO) + Val(TSAMONTO.Text)
            TextBox1.Text = Val(RESULTADO.Text)
            TextBox2.Text = "0"
        End If
        If RMONETARIOP.Checked = True Then
            Select Case Val(TSAMONTO.Text)
                Case 1 To 10000.99
                    INTERESMP = 2.5 / 100
                Case 10001 To 15000.99
                    INTERESMP = 3 / 100
                Case Is >= 15001
                    INTERESMP = 4.5 / 100
            End Select
            NUEVOSALDO = Val(TCPMONTO.Text) + Val(TCOMONTO.Text) + Val(TEMONTO.Text) + Val(TSAMONTO.Text) * INTERESMP
            TextBox2.Text = Val(TSAMONTO.Text) * INTERESMP
            RESULTADO.Text = Val(NUEVOSALDO)
            TextBox1.Text = Val(TSAMONTO.Text) + Val(RESULTADO.Text)
        End If
        If RAHORROS.Checked = True Then
            RESULTADO.Text = Val(TCPMONTO.Text) + Val(TCOMONTO.Text) + Val(TEMONTO.Text) + Val(TSAMONTO.Text)
            Select Case Val(RESULTADO.Text)
                Case 1 To 1000.99
                    INTERESA = 1.5 / 100
                Case 1001 To 5000.99
                    INTERESA = 2.5 / 100
                Case 5001 To 15000.99
                    INTERESA = 7.5 / 100
                Case Is >= 15001
                    INTERESA = 10 / 100
            End Select
            NUEVOSALDO = (Val(TCPMONTO.Text) + Val(TCOMONTO.Text) + Val(TEMONTO.Text) + Val(TSAMONTO.Text)) * INTERESA
            TextBox2.Text = Val(RESULTADO.Text) * INTERESA
            TextBox1.Text = Val(RESULTADO.Text) + NUEVOSALDO
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LIMPIARTODO()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "salir") = vbYes Then
            End
        Else
            LIMPIARTODO()
        End If
    End Sub
End Class
