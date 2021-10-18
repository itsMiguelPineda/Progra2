Public Class Form1
    Public TIPO As Double, PG As Double, REC As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "BASICO" Then
            TIPO = 350
        ElseIf ComboBox1.Text = "DIVERSIFICADO" Then
            TIPO = 450
        End If
        If ComboBox1.Text = "BASICO" Then
            PG = 250
        ElseIf ComboBox1.Text = "DIVERSIFICADO" Then
            PG = 350
        End If
        If ComboBox3.Text = "TARJETA DE CREDITO" Then
            REC = 0.1 * (PG + TIPO)
        Else
            REC = 0
        End If
        If ComboBox1.Text = "BASICO" Then
            ComboBox2.Text = ""
            MsgBox("SE ELIMINO LA SELECCION DE CARRERA YA QUE EN NIVEL BASICO, NO APLICA")
        End If
        If ComboBox1.Text = "" Or ComboBox3.Text = "" Then
            MsgBox("DEBE LLENAR TODOS LOS CAMPOS SOLICITADOS")
            TextBox1.Focus()
        ElseIf TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("DEBE LLENAR TODOS LOS CAMPOS SOLICITADOS")
            TextBox1.Focus()

        ElseIf (INDICE <= 6) Then
            NOMBRE(INDICE) = TextBox1.Text
            CARNET(INDICE) = TextBox2.Text
            NIVEL(INDICE) = ComboBox1.Text
            CARRERA(INDICE) = ComboBox2.Text
            PAGO(INDICE) = ComboBox3.Text
            PPARCIAL(INDICE) = TIPO + PG
            RECARGO(INDICE) = REC
            PFINAL(INDICE) = PPARCIAL(INDICE) + RECARGO(INDICE)
            INDICE = INDICE + 1
            INICIAR()
            End If
            If INDICE >= 7 Then
                MsgBox("REGISTRO DE ESTUDIANTES LLENO")
            End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MOSTRAR As Byte
        Dim CALCU As Double
        DataGridView1.Rows.Clear()
        If TextBox1.Text = "BASICO" Then
            CALCU = 350
        ElseIf TextBox1.Text = "DIVERSIFICADO" Then
            CALCU = 450
        End If

        For MOSTRAR = 0 To 6
            If NOMBRE(MOSTRAR) <> Nothing Then
                DataGridView1.Rows.Add(NOMBRE(MOSTRAR), CARNET(MOSTRAR), NIVEL(MOSTRAR), CARRERA(MOSTRAR), PAGO(MOSTRAR), PPARCIAL(MOSTRAR), RECARGO(MOSTRAR), PFINAL(MOSTRAR))
            Else
                Exit For
            End If
        Next MOSTRAR
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim LIMPIAR As Byte
        For LIMPIAR = 0 To 6
            NOMBRE(LIMPIAR) = Nothing
            CARNET(LIMPIAR) = Nothing
            NIVEL(LIMPIAR) = Nothing
            CARRERA(LIMPIAR) = Nothing
            PAGO(LIMPIAR) = Nothing
        Next LIMPIAR
        MsgBox("VECTORES BORRADOS EXITOSAMENTE")
        DataGridView1.Rows.Clear()
        INDICE = 0
        INICIAR()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim TOTALP As Integer
        Dim TOTALPARCIAL As Integer
        Dim TOTALPARCIAL1 As Integer
        Dim TOTALPARCIAL2 As Integer

        For TOTALP = 0 To DataGridView1.Rows.Count - 2
            TOTALPARCIAL = TOTALPARCIAL + Val(DataGridView1.Rows(TOTALP).Cells(5).Value)
            TOTALPARCIAL1 = TOTALPARCIAL1 + Val(DataGridView1.Rows(TOTALP).Cells(6).Value)
            TOTALPARCIAL2 = TOTALPARCIAL2 + Val(DataGridView1.Rows(TOTALP).Cells(7).Value)

        Next TOTALP
        TextBox3.Text = Str(TOTALPARCIAL)
        TextBox4.Text = Str(TOTALPARCIAL1)
        TextBox5.Text = Str(TOTALPARCIAL2)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim R As Byte
        Dim R1 As Byte
        Dim R2 As Byte
        Dim R3 As Byte
        Dim R4 As Byte
        Dim R5 As Byte
        Dim R6 As Byte
        Dim R7 As Byte
        Dim R8 As Byte
        Dim R9 As Byte
        Dim R10 As Byte
        Dim R11 As Byte
        Dim R12 As Byte
        Dim R13 As Byte
        Dim R14 As Byte

        For R = 0 To 6
            If (PAGO(R) = "EFECTIVO" And NIVEL(R) = "BASICO") Then
                R1 = R1 + 1
            End If
            If (PAGO(R) = "EFECTIVO" And NIVEL(R) = "DIVERSIFICADO") Then
                R2 = R2 + 1
            End If
            If (PAGO(R) = "TARJETA DE CREDITO" And NIVEL(R) = "BASICO") Then
                R3 = R3 + 1
            End If
            If (PAGO(R) = "TARJETA DE CREDITO" And NIVEL(R) = "DIVERSIFICADO") Then
                R4 = R4 + 1
            End If
            If (PAGO(R) = "ACH" And NIVEL(R) = "BASICO") Then
                R5 = R5 + 1
            End If
            If (PAGO(R) = "ACH" And NIVEL(R) = "DIVERSIFICADO") Then
                R6 = R6 + 1
            End If
            If (PAGO(R) = "DEPOSITO BANCARIO" And NIVEL(R) = "BASICO") Then
                R7 = R7 + 1
            End If
            If (PAGO(R) = "DEPOSTIO BANCARIO" And NIVEL(R) = "DIVERSIFICADO") Then
                R8 = R8 + 1
            End If
            If (NIVEL(R) = "DIVERSIFICADO") Then
                R9 = R9 + 1
            End If
            If (NIVEL(R) = "BASICO") Then
                R10 = R10 + 1
            End If
            If (CARRERA(R) = "PERITO CONTADOR") Then
                R11 = R11 + 1
            End If
            If (CARRERA(R) = "BACHILLERATO") Then
                R12 = R12 + 1
            End If
            If (CARRERA(R) = "ELECTRONICA") Then
                R13 = R13 + 1
            End If
            If (CARRERA(R) = "DISEÑO GRAFICO") Then
                R14 = R14 + 1
            End If
        Next R
                TextBox6.Text = Val(TextBox3.Text)
                TextBox7.Text = (Str(R1) * 600) + (Str(R2) * 800)
                TextBox8.Text = (Str(R3) * 600) + (Str(R4) * 800) + (0.1 * ((Str(R3) * 600) + (Str(R4) * 800)))
                TextBox9.Text = (Str(R5) * 600) + (Str(R6) * 800)
                TextBox10.Text = (Str(R7) * 600) + (Str(R8) * 800)
                TextBox15.Text = Str(R9) * 800
        TextBox16.Text = Str(R10) * 600
        TextBox11.Text = Str(R14)
        TextBox12.Text = Str(R13)
        TextBox13.Text = Str(R12)
        TextBox14.Text = Str(R11)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        LIMPIARESTADISTICAS()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        SALIR()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        LIMPIARMATRIZ()
    End Sub
End Class


