Public Class Form1


    Private Sub CLINO_CheckedChanged(sender As Object, e As EventArgs) Handles CLINO.CheckedChanged
        If (CLINO.Checked) Then
            TLINO.Visible = True
            TLINO.Focus()
        Else
            TLINO.Clear()
            TLINO.Visible = False
        End If
    End Sub

    Private Sub CALGODON_CheckedChanged(sender As Object, e As EventArgs) Handles CALGODON.CheckedChanged
        If (CALGODON.Checked) Then
            TALGODON.Visible = True
            TALGODON.Focus()
        Else
            TALGODON.Clear()
            TALGODON.Visible = False
        End If
    End Sub

    Private Sub CCEDA_CheckedChanged(sender As Object, e As EventArgs) Handles CCEDA.CheckedChanged
        If (CCEDA.Checked) Then
            TSEDA.Visible = True
            TSEDA.Focus()
        Else
            TSEDA.Clear()
            TSEDA.Visible = False
        End If
    End Sub

    Private Sub CHILO_CheckedChanged(sender As Object, e As EventArgs) Handles CHILO.CheckedChanged
        If (CHILO.Checked) Then
            THILO.Visible = True
            THILO.Focus()
        Else
            THILO.Clear()
            THILO.Visible = False
        End If
    End Sub

    Private Sub BCALCULAR_Click(sender As Object, e As EventArgs) Handles BCALCULAR.Click
        SUMAMATERIALES = Val(TLINO.Text) + Val(TALGODON.Text) + Val(TSEDA.Text) + Val(THILO.Text)
        If RIMPERIAL.Checked Then
            If SUMAMATERIALES <= 3 Then
                PARCIAL = MOI + (Val(TLINO.Text) * MLINO) + (Val(TALGODON.Text) * MALGODON) + (Val(TSEDA.Text) * MSEDA) + (Val(THILO.Text) * MHILO)
                TMANODEOBRA.Text = Val(MOI)
                TMATERIALES.Text = (Val(TLINO.Text) * MLINO) + (Val(TALGODON.Text) * MALGODON) + (Val(TSEDA.Text) * MSEDA) + (Val(THILO.Text) * MHILO)
                TPRECIOCOSTO.Text = Val(PARCIAL)
                TPRECIOVENTA.Text = Math.Round(Val(TPRECIOCOSTO.Text) * 0.65 + Val(TPRECIOCOSTO.Text), 2)
            Else
                MsgBox("ERROR, SOLO SE PUEDE USAR 3 YARDAS ENTRE LAS TELAS SELECCIONADAS")
                TLINO.Text = ""
                TALGODON.Text = ""
                TSEDA.Text = ""
                THILO.Text = ""
                CLINO.Checked = False
                CALGODON.Checked = False
                CCEDA.Checked = False
                CHILO.Checked = False
                TMANODEOBRA.Text = ""
                TPRECIOCOSTO.Text = ""
                TPRECIOVENTA.Text = ""
                TMATERIALES.Text = ""
                SUMAMATERIALES = 0
                PARCIAL = 0
            End If
        End If

        If RMATRIMONIAL.Checked Then
            If SUMAMATERIALES <= 5 Then
                PARCIAL = MOM + (Val(TLINO.Text) * MLINO) + (Val(TALGODON.Text) * MALGODON) + (Val(TSEDA.Text) * MSEDA) + (Val(THILO.Text) * MHILO)
                TMANODEOBRA.Text = Val(MOM)
                TMATERIALES.Text = (Val(TLINO.Text) * MLINO) + (Val(TALGODON.Text) * MALGODON) + (Val(TSEDA.Text) * MSEDA) + (Val(THILO.Text) * MHILO)
                TPRECIOCOSTO.Text = Val(PARCIAL)
                TPRECIOVENTA.Text = Math.Round(Val(TPRECIOCOSTO.Text) * 0.65 + Val(TPRECIOCOSTO.Text), 2)
            Else
                MsgBox("ERROR, SOLO SE PUEDE USAR 5 YARDAS ENTRE LAS TELAS SELECCIONADAS")
                TLINO.Text = ""
                TALGODON.Text = ""
                TSEDA.Text = ""
                THILO.Text = ""
                CLINO.Checked = False
                CALGODON.Checked = False
                CCEDA.Checked = False
                CHILO.Checked = False
                TMANODEOBRA.Text = ""
                TPRECIOCOSTO.Text = ""
                TPRECIOVENTA.Text = ""
                TMATERIALES.Text = ""
                SUMAMATERIALES = 0
                PARCIAL = 0
            End If
        End If
        If RQUEEN.Checked Then
            If SUMAMATERIALES <= 6 Then
                PARCIAL = MOQ + (Val(TLINO.Text) * MLINO) + (Val(TALGODON.Text) * MALGODON) + (Val(TSEDA.Text) * MSEDA) + (Val(THILO.Text) * MHILO)
                TMANODEOBRA.Text = Val(MOQ)
                TMATERIALES.Text = (Val(TLINO.Text) * MLINO) + (Val(TALGODON.Text) * MALGODON) + (Val(TSEDA.Text) * MSEDA) + (Val(THILO.Text) * MHILO)
                TPRECIOCOSTO.Text = Val(PARCIAL)
                TPRECIOVENTA.Text = Math.Round(Val(TPRECIOCOSTO.Text) * 0.65 + Val(TPRECIOCOSTO.Text), 2)
            Else
                MsgBox("ERROR, SOLO SE PUEDE USAR 6 YARDAS ENTRE LAS TELAS SELECCIONADAS")
                TLINO.Text = ""
                TALGODON.Text = ""
                TSEDA.Text = ""
                THILO.Text = ""
                CLINO.Checked = False
                CALGODON.Checked = False
                CCEDA.Checked = False
                CHILO.Checked = False
                TMANODEOBRA.Text = ""
                TPRECIOCOSTO.Text = ""
                TPRECIOVENTA.Text = ""
                TMATERIALES.Text = ""
                SUMAMATERIALES = 0
                PARCIAL = 0
            End If
                    End If
        If RKING.Checked Then
            If SUMAMATERIALES <= 7 Then
                PARCIAL = MOK + (Val(TLINO.Text) * MLINO) + (Val(TALGODON.Text) * MALGODON) + (Val(TSEDA.Text) * MSEDA) + (Val(THILO.Text) * MHILO)
                TMANODEOBRA.Text = Val(MOK)
                TMATERIALES.Text = (Val(TLINO.Text) * MLINO) + (Val(TALGODON.Text) * MALGODON) + (Val(TSEDA.Text) * MSEDA) + (Val(THILO.Text) * MHILO)
                TPRECIOCOSTO.Text = Val(PARCIAL)
                TPRECIOVENTA.Text = Math.Round(Val(TPRECIOCOSTO.Text) * 0.65 + Val(TPRECIOCOSTO.Text), 2)
            Else
                MsgBox("ERROR, SOLO SE PUEDE USAR 7 YARDAS ENTRE LAS TELAS SELECCIONADAS")
                TLINO.Text = ""
                TALGODON.Text = ""
                TSEDA.Text = ""
                THILO.Text = ""
                CLINO.Checked = False
                CALGODON.Checked = False
                CCEDA.Checked = False
                CHILO.Checked = False
                TMANODEOBRA.Text = ""
                TPRECIOCOSTO.Text = ""
                TPRECIOVENTA.Text = ""
                TMATERIALES.Text = ""
                SUMAMATERIALES = 0
                PARCIAL = 0
            End If
                    End If
    End Sub

    Private Sub BBORRAR_Click(sender As Object, e As EventArgs) Handles BBORRAR.Click
        LIMPIARFORMULARIOS()
    End Sub

    Private Sub BSALIR_Click(sender As Object, e As EventArgs) Handles BSALIR.Click
        SALIR()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
