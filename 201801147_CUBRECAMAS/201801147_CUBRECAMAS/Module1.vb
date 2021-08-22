Module Module1
    Public SUMAMATERIALES As Double, PARCIAL As Double
    Public MOI = 65.5, MOM = 85.99, MOQ = 99.99, MOK = 105.99
    Public MLINO = 15, MALGODON = 23.99, MSEDA = 30.99, MHILO = 39.99

    Sub LIMPIARFORMULARIOS()
        Form1.RIMPERIAL.Checked = False
        Form1.RMATRIMONIAL.Checked = False
        Form1.RQUEEN.Checked = False
        Form1.RKING.Checked = False
        Form1.CLINO.Checked = False
        Form1.CALGODON.Checked = False
        Form1.CCEDA.Checked = False
        Form1.CHILO.Checked = False
        Form1.TLINO.Clear()
        Form1.TALGODON.Clear()
        Form1.TSEDA.Clear()
        Form1.THILO.Clear()
        Form1.TMATERIALES.Clear()
        Form1.TMANODEOBRA.Clear()
        Form1.TPRECIOCOSTO.Clear()
        Form1.TPRECIOVENTA.Clear()
        SUMAMATERIALES = 0
        PARCIAL = 0
    End Sub
    Public Sub SALIR()
        If MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "salir") = vbYes Then
            End
        Else
            LIMPIARFORMULARIOS()
        End If
    End Sub

End Module
