Imports System.Math
Public Class Form1
    Dim THABITACION As Double
    Dim TPAGO As Double, TPAGO1 As Double
    Private Sub CALCULOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULOToolStripMenuItem.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("DEBE LLENAR LOS CAMPOS REQUERIDOS")
        ElseIf ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("DEBE LLENAR LOS CAMPOS REQUERIDOS")
        ElseIf ((REPETIDO())) Then
            If (FILA <= 5) Then
                Select Case ComboBox1.Text
                    Case "HABITACION PRIVADA"
                        THABITACION = 350
                    Case "HABITACION SEMI-PRIVADA"
                        THABITACION = 250
                    Case "HABITACION NO PRIVADA"
                        THABITACION = 150
                End Select
                Select Case ComboBox2.Text
                    Case "EFECTIVO"
                        TPAGO = (THABITACION * 0.1)
                    Case "DEPOSITO"
                        TPAGO = (THABITACION * 0.1)
                    Case "ACH"
                        TPAGO = (THABITACION * 0.08)
                    Case "TARJETA DE CREDITO"
                        TPAGO = (THABITACION * 0.015)
                    Case Else
                        TPAGO = 0
                End Select
                Select Case ComboBox2.Text
                    Case "EFECTIVO"
                        TPAGO1 = THABITACION - (THABITACION * 0.1)
                    Case "DEPOSITO"
                        TPAGO1 = THABITACION - (THABITACION * 0.1)
                    Case "ACH"
                        TPAGO1 = THABITACION - (THABITACION * 0.08)
                    Case "TARJETA DE CREDITO"
                        TPAGO1 = THABITACION + (THABITACION * 0.015)
                    Case Else
                        TPAGO1 = THABITACION
                End Select
                HOSPITAL(FILA, 0) = TextBox1.Text
                HOSPITAL(FILA, 1) = TextBox2.Text
                HOSPITAL(FILA, 2) = TextBox3.Text
                HOSPITAL(FILA, 3) = TextBox4.Text
                HOSPITAL(FILA, 4) = ComboBox1.Text
                HOSPITAL(FILA, 5) = ComboBox2.Text
                HOSPITAL(FILA, 6) = THABITACION
                HOSPITAL(FILA, 7) = TPAGO
                HOSPITAL(FILA, 8) = TPAGO1
                FILA = FILA + 1
                MsgBox("DATOS INGRESADOS EXITOSAMENTE")
                LIMPIARENTRADAS()
            End If
        Else
            MsgBox("NIT REPETIDO, VERIFIQUE EL NUMERO DE NUEVO")
            TextBox2.Focus()
        End If
        If (FILA = 6) Then
            MsgBox("MATRIZ LLENA :(")
        End If
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        MOSTRAR()
    End Sub

    Private Sub MATRIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MATRIZToolStripMenuItem.Click
        LIMPIARMATRIZ()
        MsgBox("MATRIZ LIMPIA CORRECTAMENTE")
    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click
        Dim CONSULTA As Boolean = True
        I = 0
        While (I <= 5) And CONSULTA
            If (HOSPITAL(I, 0) <> Nothing) Then
                If (Val(HOSPITAL(I, 1)) = Val(TextBox5.Text)) Then
                    CONSULTA = False
                Else
                    I = I + 1
                End If
            Else
                Exit While
            End If
        End While
        If CONSULTA Then
            MsgBox("NIT NO ENCONTRADO")
            TextBox5.Focus()
        Else
            MsgBox("EL REGISTRO SE EFECTUO EXITOSAMENTE")
            TextBox1.Text = HOSPITAL(I, 0)
            TextBox2.Text = HOSPITAL(I, 1)
            TextBox3.Text = HOSPITAL(I, 2)
            TextBox4.Text = HOSPITAL(I, 3)
            ComboBox1.Text = HOSPITAL(I, 4)
            ComboBox2.Text = HOSPITAL(I, 5)
        End If
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(HOSPITAL(I, 0), HOSPITAL(I, 1), HOSPITAL(I, 2), HOSPITAL(I, 3), HOSPITAL(I, 4), HOSPITAL(I, 5), HOSPITAL(I, 6), HOSPITAL(I, 7), HOSPITAL(I, 8))
        LIMPIARESTADISTICAS()
        FILA = I
    End Sub

    Private Sub ESTADISTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ESTADISTICASToolStripMenuItem.Click
        Dim ESTADISTICA1 As Byte
        Dim SACH As Double
        Dim DNPRIV As Double

        I = 0
        While (I <= 5)
            If (HOSPITAL(I, 0) <> Nothing) Then
                If (HOSPITAL(I, 4) = "HABITACION PRIVADA") Then
                    ESTADISTICA1 = ESTADISTICA1 + 1
                End If

                If (HOSPITAL(I, 5) = "ACH") Then
                    SACH = SACH + Val(DataGridView1.Rows(I).Cells(6).Value)
                End If

                If (HOSPITAL(I, 4) = "HABITACION NO PRIVADA") Then
                    DNPRIV = DNPRIV + Val(DataGridView1.Rows(I).Cells(2).Value)

                End If

                I = I + 1
            Else
                Exit While
            End If
        End While
        TextBox6.Text = Str(ESTADISTICA1)
        TextBox7.Text = Str(SACH)
        TextBox8.Text = Str(DNPRIV)

    End Sub

    Private Sub ESTADISTICASToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ESTADISTICASToolStripMenuItem1.Click
        LIMPIARESTADISTICAS()
        MsgBox("ESTADISTICAS LIMPIAS")
    End Sub

    Private Sub CERRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CERRARToolStripMenuItem.Click
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Close()
        Else
            LIMPIARENTRADAS()
            LIMPIARESTADISTICAS()
        End If
    End Sub
End Class
