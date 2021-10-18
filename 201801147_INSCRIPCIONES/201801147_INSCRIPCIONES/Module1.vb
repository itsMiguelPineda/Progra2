Module Module1
    Public INSCRIPCIONES(7, 8) As String
    Public INDICE As Byte = 0
    Public NOMBRE(6), CARNET(6), NIVEL(6), CARRERA(6), CUOTA(6), PAGO(6), PPARCIAL(6), RECARGO(6), PFINAL(6)
    Sub INICIAR()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""
        Form1.ComboBox3.Text = ""
    End Sub
    Sub LIMPIARESTADISTICAS()
        Form1.TextBox6.Clear()
        Form1.TextBox7.Clear()
        Form1.TextBox8.Clear()
        Form1.TextBox9.Clear()
        Form1.TextBox10.Clear()
        Form1.TextBox11.Clear()
        Form1.TextBox12.Clear()
        Form1.TextBox13.Clear()
        Form1.TextBox14.Clear()
        Form1.TextBox15.Clear()
        Form1.TextBox16.Clear()
    End Sub
    Sub SALIR()
        If MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "salir") = vbYes Then
            End
        Else
            INICIAR()
            LIMPIARESTADISTICAS()
        End If
    End Sub
    Sub LIMPIARMATRIZ()
        Form1.DataGridView1.Rows.Clear()

        'se inicializa la variable Fila para dejarla lista para nuevos ingresos
        INDICE = 0

    End Sub
End Module
