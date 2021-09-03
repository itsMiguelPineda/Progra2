Imports System.Math
Module Module1
    Public KILO As Byte = 0
    Public NOMBRE(11) As String, SERVICIO(11) As String, TARIFA(11) As String, TSERVICIO(11) As String, TTARIFA(11) As String
    Public NIT(11) As Double, SANTERIOR(11) As Double, CKILO(11) As Double, PARCIAL(11) As Double, TOTAL(11) As Double, RECARGO(11) As Double, D1(11) As Double, D2(11) As Double


    Sub CALCULAR()
        If (KILO < 11) Then
            If (Form1.TextBox1.Text <> "") Then
                NOMBRE(KILO) = Form1.TextBox1.Text
            Else
                MsgBox("PARA CONTINUAR, DEBE COLOCAR UN NOMBRE")
                Form1.TextBox1.Focus() : Exit Sub
            End If

            If (IsNumeric(Form1.TextBox2.Text) And Val(Form1.TextBox2.Text) > 0) Then
                NIT(KILO) = Form1.TextBox2.Text
            Else
                MsgBox("PARA CONTINUAR, DEBE COLOCAR UN NUMERO DE NIT")
                Form1.TextBox1.Focus() : Exit Sub
            End If

            If (IsNumeric(Form1.TextBox3.Text) And Val(Form1.TextBox3.Text) >= 0) Then
                SANTERIOR(KILO) = Form1.TextBox3.Text
            Else
                MsgBox("PARA CONTINUAR, DEBE COLOCAR SU SALDO ANTERIOR")
                Form1.TextBox1.Focus() : Exit Sub
            End If

            If (IsNumeric(Form1.TextBox4.Text) And Val(Form1.TextBox4.Text) > 0) Then
                CKILO(KILO) = Form1.TextBox4.Text
            Else
                MsgBox("PARA CONTINUAR, DEBE COLOCAR SU CONSUMO DE ENERGIA")
                Form1.TextBox1.Focus() : Exit Sub
            End If

            If (IsNumeric(Form1.TextBox4.Text) And (Val(Form1.TextBox4.Text) > 0 And Val(Form1.TextBox4.Text) <= 100)) Then
                Select Case (Form1.ComboBox1.SelectedIndex)
                    Case 0 : SERVICIO(KILO) = Round(CKILO(KILO) * 0.99, 2)
                    Case 1 : SERVICIO(KILO) = Round(CKILO(KILO) * 1.99, 2)
                    Case Else
                        MsgBox("PARA CONTINUAR, DEBE SELECCIONAR UN TIPO DE SERVICIO")
                        Form1.TextBox1.Focus() : Exit Sub
                End Select
            End If
            If (IsNumeric(Form1.TextBox4.Text) And (Val(Form1.TextBox4.Text) > 100 And Val(Form1.TextBox4.Text) <= 300)) Then
                Select Case (Form1.ComboBox1.SelectedIndex)
                    Case 0 : SERVICIO(KILO) = Round(CKILO(KILO) * 1.2, 2)
                    Case 1 : SERVICIO(KILO) = Round(CKILO(KILO) * 2.2, 2)
                    Case Else
                        MsgBox("PARA CONTINUAR, DEBE SELECCIONAR UN TIPO DE SERVICIO")
                        Form1.TextBox1.Focus() : Exit Sub
                End Select
            End If
            If (IsNumeric(Form1.TextBox4.Text) And Val(Form1.TextBox4.Text) > 300) Then
                Select Case (Form1.ComboBox1.SelectedIndex)
                    Case 0 : SERVICIO(KILO) = Round(CKILO(KILO) * 3.0, 2)
                    Case 1 : SERVICIO(KILO) = Round(CKILO(KILO) * 4.0, 2)
                    Case Else
                        MsgBox("PARA CONTINUAR, DEBE SELECCIONAR UN TIPO DE SERVICIO")
                        Form1.TextBox1.Focus() : Exit Sub
                End Select
            End If

            TSERVICIO(KILO) = Form1.ComboBox1.Text

            TARIFA(KILO) = Form1.ComboBox2.Text

            PARCIAL(KILO) = SANTERIOR(KILO) + SERVICIO(KILO)
            TOTAL(KILO) = PARCIAL(KILO) - TTARIFA(KILO) + RECARGO(KILO)
            If Val(Form1.TextBox3.Text) > 0 Then
                RECARGO(KILO) = Val(Form1.TextBox3.Text) * 0.02
            End If
            Select Case (Form1.ComboBox2.SelectedIndex)
                Case 0 : TTARIFA(KILO) = Round((TOTAL(KILO) + RECARGO(KILO)) * 0.2, 2)
                Case 1 : TTARIFA(KILO) = Round(PARCIAL(KILO) * 0.1, 2)
                Case Else
                    MsgBox("PARA CONTINUAR, DEBE SELECCIONAR UN TIPO DE TARIFA")
                    Form1.TextBox1.Focus() : Exit Sub
            End Select

            D1(KILO) = PARCIAL(KILO)
            D2(KILO) = PARCIAL(KILO) - TTARIFA(KILO) + RECARGO(KILO)
            Form1.DataGridView1.Rows.Add(NOMBRE(KILO), Str(NIT(KILO)), Str(SANTERIOR(KILO)), Str(SERVICIO(KILO)), TSERVICIO(KILO), TARIFA(KILO), D1(KILO), RECARGO(KILO), TTARIFA(KILO), D2(KILO))

            KILO = KILO + 1
        End If
        If KILO = 10 Then
            MsgBox("BORRE DATOS, LOS VECTORES ESTAN LLENOS")
        End If
    End Sub
    Sub LIMPIAR()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Form1.ComboBox1.SelectedIndex = -1
        Form1.ComboBox2.SelectedIndex = -1
        Form1.TextBox1.Focus()
        MsgBox("DATOS DE CAJA DE TEXTOS BORRADOS")
    End Sub
    Sub LIMPIARDATA()
        Form1.DataGridView1.Rows.Clear()
        KILO = 0
        MsgBox("DATOS ALMACENADOS Y VECTORES BORRADOS EXITOSAMENTE")
    End Sub
    Sub SALIR()
        If MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "salir") = vbYes Then
            End
        Else
            LIMPIAR()
            LIMPIARDATA()
        End If
    End Sub
End Module
