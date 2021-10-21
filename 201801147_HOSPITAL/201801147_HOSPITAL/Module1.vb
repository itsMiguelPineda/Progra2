Module Module1
    Public HOSPITAL(6, 9) As String
    Public FILA As Byte = 0
    Public I As Byte
    Function REPETIDO() As Boolean
        Dim ENCONTRADO As Boolean = True
        I = 0
        REPETIDO = True
        While (I <= 5) And (ENCONTRADO)
            If (HOSPITAL(I, 0) <> Nothing) Then
                If (HOSPITAL(I, 1) = Val(Form1.TextBox2.Text)) Then
                    REPETIDO = ENCONTRADO = False
                    Return REPETIDO
                Else
                    I = I + 1
                End If
            Else
                Exit While
            End If
        End While
        If (ENCONTRADO) Then
            Return REPETIDO
        End If
    End Function
    Sub MOSTRAR()
        Form1.DataGridView1.Rows.Clear()
        I = 0
        While (I <= 5)
            If (HOSPITAL(I, 0) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(HOSPITAL(I, 0), HOSPITAL(I, 1), HOSPITAL(I, 2), HOSPITAL(I, 3), HOSPITAL(I, 4), HOSPITAL(I, 5), HOSPITAL(I, 6), HOSPITAL(I, 7), HOSPITAL(I, 8))
            Else
                Exit While
            End If
            I = I + 1
        End While
    End Sub
    Sub LIMPIARMATRIZ()
        Form1.DataGridView1.Rows.Clear()
        FILA = 0
        I = 0
        While (I <= 5)
            HOSPITAL(I, 0) = Nothing
            HOSPITAL(I, 1) = Nothing
            HOSPITAL(I, 2) = Nothing
            HOSPITAL(I, 3) = Nothing
            HOSPITAL(I, 4) = Nothing
            HOSPITAL(I, 5) = Nothing
            HOSPITAL(I, 6) = Nothing
            HOSPITAL(I, 7) = Nothing
            HOSPITAL(I, 8) = Nothing
            I = I + 1
        End While
    End Sub
    Sub LIMPIARENTRADAS()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""
    End Sub
    Sub LIMPIARESTADISTICAS()
        Form1.TextBox6.Clear()
        Form1.TextBox7.Clear()
        Form1.TextBox8.Clear()
    End Sub
End Module
