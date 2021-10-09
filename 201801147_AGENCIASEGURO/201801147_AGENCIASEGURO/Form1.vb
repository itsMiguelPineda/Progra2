Imports System.Math
Public Class Form1
    Dim TOTALPARCIAL As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Then
            MsgBox("DEBE LLENAR TODOS LOS CAMPOS SOLICITADOS")
            TextBox1.Focus()
        ElseIf TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("DEBE LLENAR TODOS LOS CAMPOS SOLICITADOS")
            TextBox1.Focus()
        ElseIf (INDICE <= 6) Then
            EDAD(INDICE) = Val(TextBox1.Text)
            GENERO(INDICE) = ComboBox1.Text
            CODIGOREG(INDICE) = ComboBox2.Text
            DAÑOS(INDICE) = Val(TextBox2.Text)
            TALLER(INDICE) = ComboBox3.Text
            INDICE = INDICE + 1
            INICIAR()
        End If
        If (INDICE >= 7) Then
            MsgBox("REGISTRO COMPLETO")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MOSTRAR_ As Byte
        DataGridView1.Rows.Clear()
        For MOSTRAR_ = 0 To 6
            If EDAD(MOSTRAR_) <> Nothing Then
                DataGridView1.Rows.Add(EDAD(MOSTRAR_), GENERO(MOSTRAR_), CODIGOREG(MOSTRAR_), DAÑOS(MOSTRAR_), TALLER(MOSTRAR_))
            Else
                Exit For
            End If
        Next MOSTRAR_
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim TOTALP As Integer
        For TOTALP = 0 To DataGridView1.Rows.Count - 2
            TOTALPARCIAL = TOTALPARCIAL + Val(DataGridView1.Rows(TOTALP).Cells(3).Value)

        Next TOTALP
        TextBox3.Text = Str(TOTALPARCIAL) * 0.06
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim LIMPIAR As Byte
        For LIMPIAR = 0 To 6
            EDAD(LIMPIAR) = Nothing
            GENERO(LIMPIAR) = Nothing
            CODIGOREG(LIMPIAR) = Nothing
            DAÑOS(LIMPIAR) = Nothing
            TALLER(LIMPIAR) = Nothing
        Next LIMPIAR
        MsgBox("VECTORES BORRADOS EXITOSAMENTE")
        DataGridView1.Rows.Clear()
        TextBox3.Clear()
        INDICE = 0
        INICIAR()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim R As Byte
        Dim MD_ As Byte = 0
        Dim GF As Byte = 0
        Dim GM As Byte = 0
        Dim RE As Byte = 0
        Dim CI As Byte = 0
        Dim TOT As Byte = 0
            For R = 0 To 6
            If (EDAD(R) <= 24 And EDAD(R) > 0) Then
                MD_ = (MD_ + 1)
            End If
                If (GENERO(R) = "F") Then
                    GF = (GF + 1)
                End If
                If (GENERO(R) = "M") And (EDAD(R) >= 18 And EDAD(R) <= 25) Then
                    GM = (GM + 1)
                End If
                If (CODIGOREG(R) = "0 (EXTRANJERO)") Then
                    RE = (RE + 1)
                End If
            Next R
        TextBox4.Text = Str(MD_) / INDICE
        TextBox5.Text = Str(GF) / INDICE
        TextBox6.Text = Str(GM) / INDICE
        TextBox7.Text = Str(RE) / INDICE
        TextBox8.Text = INDICE
        TextBox9.Text = TOTALPARCIAL

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        LIMPIARESTADISTICAS()
        MsgBox("CAMPOS BORRADOS EXITOSAMENTE")
    End Sub
End Class
