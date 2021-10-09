Module Module1
    Public INDICE As Byte = 0
    Public EDAD(6)
    Public GENERO(6)
    Public CODIGOREG(6)
    Public DAÑOS(6)
    Public TALLER(6)
    Sub INICIAR()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""
        Form1.ComboBox3.Text = ""
    End Sub
    Sub LIMPIARESTADISTICAS()
        Form1.TextBox4.Clear()
        Form1.TextBox5.Clear()
        Form1.TextBox6.Clear()
        Form1.TextBox7.Clear()
        Form1.TextBox8.Clear()
        Form1.TextBox9.Clear()
    End Sub
    Sub SALIR()
        If MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "salir") = vbYes Then
            End
        Else
            INICIAR()
            LIMPIARESTADISTICAS()
        End If
    End Sub
End Module
