Imports System.Math
Module Module1
    Public PAGO1(8), DESC1(8), DESC2(8), PAGOT(8)
    Public TFUNCION(8)
    Public TPAGO1(8)
    Public LCINE(8)
    Public ENTRADAS(8)
    Public SALACINE = 0
    Public CALCULODESCUENTO2_ As Double = 0
    Public CALCULOPARCIAL As Double = 0
    Public PAGOSUBTOTAL As Double = 0
    Public CALCDESC1 As Double = 0
    Public CALCDESC2 As Double = 0


    Function CALCULARPARCIAL(CINE As String, FUNCION As Double) As Double
        Select Case CINE
            Case "A"
                Select Case FUNCION
                    Case "1"
                        CALCULOPARCIAL = 30
                    Case "2"
                        CALCULOPARCIAL = 35
                    Case "3"
                        CALCULOPARCIAL = 40
                    Case Else
                        CALCULOPARCIAL = 40
                End Select
            Case "B"
                Select Case FUNCION
                    Case "1"
                        CALCULOPARCIAL = 24
                    Case "2"
                        CALCULOPARCIAL = 34
                    Case "3"
                        CALCULOPARCIAL = 44
                    Case Else
                        CALCULOPARCIAL = 44
                End Select
            Case "C"
                Select Case FUNCION
                    Case "1"
                        CALCULOPARCIAL = 35
                    Case "2"
                        CALCULOPARCIAL = 40
                    Case "3"
                        CALCULOPARCIAL = 50
                    Case Else
                        CALCULOPARCIAL = 50
                End Select
        End Select
        Return CALCULOPARCIAL
    End Function
    Function CALCULODESCUENTO1(CINE As String, FUNCION As Double) As Double

        If (FUNCION = "3" Or FUNCION = "4") And (CINE = "C" Or CINE = "B") Then
            CALCULODESCUENTO1 = 0.055 * CALCULOPARCIAL
        ElseIf (FUNCION = "1") And (CINE = "C" Or CINE = "B") Then
            CALCULODESCUENTO1 = 0.03 * CALCULOPARCIAL
        ElseIf (FUNCION = "2") And (CINE = "A") Then
            CALCULODESCUENTO1 = 0.015 * CALCULOPARCIAL
        End If
        Return CALCULODESCUENTO1

    End Function
    Function CALCULODESCUENTO2(TPAGO1 As Double) As Double

        If (TPAGO1 >= 100) And (TPAGO1 <= 300) Then
            CALCULODESCUENTO2_ = 0.02
        ElseIf (TPAGO1 > 300) And (TPAGO1 <= 500) Then
            CALCULODESCUENTO2_ = 0.04
        ElseIf (TPAGO1 > 500) And (TPAGO1 <= 1000) Then
            CALCULODESCUENTO2_ = 0.06
        End If
        Return CALCULODESCUENTO2_

    End Function
    Sub LIMPIAR()
        Form1.TENTRADAS.Clear()
        Form1.CFUNCION.SelectedIndex = -1
        Form1.CCINE.SelectedIndex = -1
        MsgBox("DATOS BORRADOS")
    End Sub
    Sub LIMPIARDATA()
        Form1.DataGridView1.Rows.Clear()
        SALACINE = 0
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

