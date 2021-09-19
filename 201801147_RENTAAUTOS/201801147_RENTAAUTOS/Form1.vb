
Imports System.Math
Public Class Form1

    Private Sub BACEPTAR_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        PAGOPORCENTAJE()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        PAGOPORCENTAJE()
    End Sub

    Private Sub ACEPTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACEPTARToolStripMenuItem.Click
        If (VENTAUTOS < 7) Then
            If TNIT.Text = "" Then
                MsgBox("PARA CONTINUAR, DEBE COLOCAR UN NIT")
                TNIT.Focus() : Exit Sub
            End If
            If TPLACA.Text = "" Then
                MsgBox("PARA CONTINUAR, DEBE COLOCAR UN NUMERO DE PLACA")
                TPLACA.Focus() : Exit Sub
            End If
            If CMARCA.Text = "" Then
                MsgBox("PARA CONTINUAR, DEBE COLOCAR UNA MARCA DE AUTO")
                CMARCA.Focus() : Exit Sub
            End If
            If TALQUILER.Text = "" Then
                MsgBox("PARA CONTINUAR, DEBE COLOCAR UN NUMERO DE DIAS A ALQUILAR")
                TALQUILER.Focus() : Exit Sub
            End If
            If (CheckBox1.Checked = False) And (CheckBox2.Checked = False) Then
                MsgBox("DEBE SELECCIONAR UN METODO DE PAGO")
                Exit Sub
            Else
                If (CheckBox1.Checked = True And CheckBox2.Checked = True) And ((Val(TEFECTIVO.Text) + Val(TTARJETA.Text)) = 100) Then
                    DR = 0
                    DESCREC = CALCULARPARCIAL1(PAGOPAR(VENTAUTOS)) + DR
                ElseIf (CheckBox1.Checked = True) And (Val(TEFECTIVO.Text) = 100) Then
                    DR = CALCULARPARCIAL1(PAGOPAR(VENTAUTOS)) * 0.05
                    DESCREC = CALCULARPARCIAL1(PAGOPAR(VENTAUTOS)) - DR
                ElseIf (CheckBox2.Checked = True) And ((Val(TTARJETA.Text)) = 100) Then
                    DR = CALCULARPARCIAL1(PAGOPAR(VENTAUTOS)) * 0.025
                    DESCREC = CALCULARPARCIAL1(PAGOPAR(VENTAUTOS)) + DR
                Else
                    MsgBox("DEBE SUMAR EL 100 ENTRO AMBOS O UN SOLO METODO")
                    TEFECTIVO.Text = ""
                    TTARJETA.Text = ""
                    Exit Sub
                End If


            End If
            NIT(VENTAUTOS) = Val(TNIT.Text)
            PLACA(VENTAUTOS) = TPLACA.Text
            MARCA_(VENTAUTOS) = CMARCA.SelectedItem
            ALQUILER(VENTAUTOS) = Val(TALQUILER.Text)
            PAGOPAR(VENTAUTOS) = CALCULARPARCIAL1(PAGOPAR(VENTAUTOS))
            DESC_REC(VENTAUTOS) = DR
            PAGOTOTAL(VENTAUTOS) = DESCREC
        Else
            MsgBox("LIMITE DE DATOS ALCANZADOS")
        End If

        DataGridView1.Rows.Add(NIT(VENTAUTOS), PLACA(VENTAUTOS), MARCA_(VENTAUTOS), ALQUILER(VENTAUTOS), PAGOPAR(VENTAUTOS), DESC_REC(VENTAUTOS), PAGOTOTAL(VENTAUTOS))
        VENTAUTOS = VENTAUTOS + 1

    End Sub

    Private Sub ENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ENTRADASToolStripMenuItem.Click
        LIMPIAR()
    End Sub

    Private Sub VECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VECTORESToolStripMenuItem.Click
        LIMPIARDATA()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        SALIR()
    End Sub
End Class
