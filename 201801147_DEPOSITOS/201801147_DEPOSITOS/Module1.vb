Module Module1
    Public PROPIO As Byte, OTROBANCO As Byte, AHORRO As Byte
    Public SMONETARIO As Double, SMONETARIOP As Double, SAHORRO As Double
    Public INTERESMP As Double, NUEVOSALDO As Double, INTERESA As Double

    Sub LIMPIARTODO()
        Form1.RMONETARIO.Checked = False
        Form1.RMONETARIOP.Checked = False
        Form1.RAHORROS.Checked = False
        Form1.CCP.Checked = False
        Form1.CCB.Checked = False
        Form1.CE.Checked = False
        Form1.TCPMONTO.Clear()
        Form1.TCOMONTO.Clear()
        Form1.TEMONTO.Clear()
        Form1.TSAMONTO.Clear()
        Form1.RESULTADO.Clear()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TSAMONTO.Focus()





    End Sub


End Module
