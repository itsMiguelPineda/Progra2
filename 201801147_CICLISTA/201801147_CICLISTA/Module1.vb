Module Module1
    Public ETAPA(11) As String
    Public EQUIPO(11) As String
    Public RECORRIDO(11) As Integer
    Public TIEMPO(11) As Integer
    Public NACIONALIDAD(11) As String
    Public PEN_RED(11) As Integer
    Public TIEMPOTOTAL(11) As Integer
    Public FILA As Byte = 0
    Public I As Byte
    Sub salir()
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()
        Else
            limpiar_entradas()
            limpiar_estadisticas()
        End If
    End Sub
    Sub limpiar_entradas()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""
        Form1.ComboBox3.Text = ""
        Form1.ComboBox1.Focus()
    End Sub
    Sub limpiar_estadisticas()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Form1.TextBox5.Clear()
        Form1.TextBox6.Clear()
        Form1.TextBox7.Clear()
        Form1.TextBox8.Clear()
        Form1.TextBox9.Clear()
        Form1.TextBox10.Clear()
        Form1.TextBox11.Clear()
        Form1.TextBox3.Focus()
    End Sub
    Sub MOSTRAR()
        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 11
            If (ETAPA(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(ETAPA(I), EQUIPO(I), RECORRIDO(I), TIEMPO(I), NACIONALIDAD(I), PEN_RED(I), TIEMPOTOTAL(I))
            Else
                Exit For
            End If
        Next I
    End Sub
    Sub limpiar_vectores()
        Form1.DataGridView1.Rows.Clear()
        FILA = 0
         For I = 0 To 4
            ETAPA(I) = Nothing
            EQUIPO(I) = Nothing
            RECORRIDO(I) = Nothing
            TIEMPO(I) = Nothing
            NACIONALIDAD(I) = Nothing
            PEN_RED(I) = Nothing
            TIEMPOTOTAL(I) = Nothing
        Next I

    End Sub
End Module
