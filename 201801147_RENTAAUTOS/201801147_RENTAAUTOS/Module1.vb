Imports System.Math
Module Module1
    Public VENTAUTOS = 0
    Public PAGOPAR(6)
    Public NIT(6), PLACA(6), MARCA_(6), ALQUILER(6), EFECTIVO_(6), TARJETA_(6)
    Public DESC_REC(6)
    Public PAGOTARJETA(6)
    Public PAGOEFECTIVO(6)
    Public LCARRO(6)
    Public PAGOTOTAL(6)
    Public PAG1 As Double
    Public PAGO As Double = 0
    Public DESCREC As Double
    Public DES As Double
    Public PAGOPARCIAL1_ As Double
    Public PAGOPARCIAL2_ As Double
    Public DR As Double
    Public DESC(6)
    Function CALCULARPARCIAL1(ByRef PAGOPARCIAL1_ As Double) As Double
        If Form1.CMARCA.Text = "HONDA" Then
            PAGOPARCIAL1_ = 250 * Val(Form1.TALQUILER.Text)
        ElseIf Form1.CMARCA.Text = "MERCEDES_BENZ" Then
            PAGOPARCIAL1_ = 450 * Val(Form1.TALQUILER.Text)
        ElseIf Form1.CMARCA.Text = "TOYOTA" Then
            PAGOPARCIAL1_ = 325 * Val(Form1.TALQUILER.Text)
        ElseIf Form1.CMARCA.Text = "MAZDA" Then
            PAGOPARCIAL1_ = 300 * Val(Form1.TALQUILER.Text)
        End If
        Return PAGOPARCIAL1_
    End Function
    Sub PAGOPORCENTAJE()
        If ((Form1.CheckBox1.Checked)) = True Then
            Form1.TEFECTIVO.Visible = True
            Form1.TEFECTIVO.Focus()
        Else
            Form1.TEFECTIVO.Visible = False
            Form1.TEFECTIVO.Clear()
        End If
        If ((Form1.CheckBox2.Checked)) = True Then
            Form1.TTARJETA.Visible = True
            Form1.TTARJETA.Focus()
        Else
            Form1.TTARJETA.Visible = False
            Form1.TTARJETA.Clear()
        End If
    End Sub
    Sub LIMPIARDATA()
        Form1.DataGridView1.Rows.Clear()
        VENTAUTOS = 0
        MsgBox("DATOS ALMACENADOS Y VECTORES BORRADOS EXITOSAMENTE")
    End Sub
    Sub LIMPIAR()
        Form1.TNIT.Clear()
        Form1.TNIT.Focus()
        Form1.TPLACA.Clear()
        Form1.CMARCA.SelectedIndex = -1
        Form1.TALQUILER.Clear()
        Form1.TTARJETA.Clear()
        Form1.TEFECTIVO.Clear()
        MsgBox("DATOS DE CAJA DE TEXTOS BORRADOS")
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
