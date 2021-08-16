<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RMONETARIO = New System.Windows.Forms.RadioButton()
        Me.RMONETARIOP = New System.Windows.Forms.RadioButton()
        Me.RAHORROS = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CCP = New System.Windows.Forms.CheckBox()
        Me.CCB = New System.Windows.Forms.CheckBox()
        Me.CE = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TCPMONTO = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TCOMONTO = New System.Windows.Forms.TextBox()
        Me.TEMONTO = New System.Windows.Forms.TextBox()
        Me.TSAMONTO = New System.Windows.Forms.TextBox()
        Me.CALCULAR = New System.Windows.Forms.Button()
        Me.RESULTADO = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'RMONETARIO
        '
        Me.RMONETARIO.AutoSize = True
        Me.RMONETARIO.Location = New System.Drawing.Point(12, 43)
        Me.RMONETARIO.Name = "RMONETARIO"
        Me.RMONETARIO.Size = New System.Drawing.Size(97, 17)
        Me.RMONETARIO.TabIndex = 0
        Me.RMONETARIO.TabStop = True
        Me.RMONETARIO.Text = "MONETARIOS"
        Me.RMONETARIO.UseVisualStyleBackColor = True
        '
        'RMONETARIOP
        '
        Me.RMONETARIOP.AutoSize = True
        Me.RMONETARIOP.Location = New System.Drawing.Point(12, 66)
        Me.RMONETARIOP.Name = "RMONETARIOP"
        Me.RMONETARIOP.Size = New System.Drawing.Size(149, 17)
        Me.RMONETARIOP.TabIndex = 1
        Me.RMONETARIOP.TabStop = True
        Me.RMONETARIOP.Text = "MONETARIOS PREMIER"
        Me.RMONETARIOP.UseVisualStyleBackColor = True
        '
        'RAHORROS
        '
        Me.RAHORROS.AutoSize = True
        Me.RAHORROS.Location = New System.Drawing.Point(12, 89)
        Me.RAHORROS.Name = "RAHORROS"
        Me.RAHORROS.Size = New System.Drawing.Size(79, 17)
        Me.RAHORROS.TabIndex = 2
        Me.RAHORROS.TabStop = True
        Me.RAHORROS.Text = "AHORROS"
        Me.RAHORROS.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "TIPO DE DÉPOSITO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "METODO DE DÉPOSITO"
        '
        'CCP
        '
        Me.CCP.AutoSize = True
        Me.CCP.Location = New System.Drawing.Point(187, 43)
        Me.CCP.Name = "CCP"
        Me.CCP.Size = New System.Drawing.Size(115, 17)
        Me.CCP.TabIndex = 5
        Me.CCP.Text = "CHEQUE PROPIO"
        Me.CCP.UseVisualStyleBackColor = True
        '
        'CCB
        '
        Me.CCB.AutoSize = True
        Me.CCB.Location = New System.Drawing.Point(187, 66)
        Me.CCB.Name = "CCB"
        Me.CCB.Size = New System.Drawing.Size(145, 17)
        Me.CCB.TabIndex = 6
        Me.CCB.Text = "CHEQUE OTRO BANCO"
        Me.CCB.UseVisualStyleBackColor = True
        '
        'CE
        '
        Me.CE.AutoSize = True
        Me.CE.Location = New System.Drawing.Point(187, 89)
        Me.CE.Name = "CE"
        Me.CE.Size = New System.Drawing.Size(78, 17)
        Me.CE.TabIndex = 7
        Me.CE.Text = "EFECTIVO"
        Me.CE.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(360, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "MONTO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(360, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Q"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(360, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Q"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(360, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Q"
        '
        'TCPMONTO
        '
        Me.TCPMONTO.Location = New System.Drawing.Point(381, 41)
        Me.TCPMONTO.Name = "TCPMONTO"
        Me.TCPMONTO.Size = New System.Drawing.Size(100, 20)
        Me.TCPMONTO.TabIndex = 12
        Me.TCPMONTO.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "INGRESE SALDO ANTERIOR"
        '
        'TCOMONTO
        '
        Me.TCOMONTO.Location = New System.Drawing.Point(381, 65)
        Me.TCOMONTO.Name = "TCOMONTO"
        Me.TCOMONTO.Size = New System.Drawing.Size(100, 20)
        Me.TCOMONTO.TabIndex = 14
        Me.TCOMONTO.Visible = False
        '
        'TEMONTO
        '
        Me.TEMONTO.Location = New System.Drawing.Point(381, 88)
        Me.TEMONTO.Name = "TEMONTO"
        Me.TEMONTO.Size = New System.Drawing.Size(100, 20)
        Me.TEMONTO.TabIndex = 15
        Me.TEMONTO.Visible = False
        '
        'TSAMONTO
        '
        Me.TSAMONTO.Location = New System.Drawing.Point(17, 138)
        Me.TSAMONTO.Name = "TSAMONTO"
        Me.TSAMONTO.Size = New System.Drawing.Size(100, 20)
        Me.TSAMONTO.TabIndex = 16
        '
        'CALCULAR
        '
        Me.CALCULAR.Location = New System.Drawing.Point(86, 188)
        Me.CALCULAR.Name = "CALCULAR"
        Me.CALCULAR.Size = New System.Drawing.Size(75, 23)
        Me.CALCULAR.TabIndex = 17
        Me.CALCULAR.Text = "CALCULAR"
        Me.CALCULAR.UseVisualStyleBackColor = True
        '
        'RESULTADO
        '
        Me.RESULTADO.Location = New System.Drawing.Point(296, 138)
        Me.RESULTADO.Name = "RESULTADO"
        Me.RESULTADO.Size = New System.Drawing.Size(100, 20)
        Me.RESULTADO.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(297, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "NUEVO SALDO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(407, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "MONTO TOTAL"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(410, 138)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(208, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "LIMPIAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(321, 188)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "SALIR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(162, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "INTERES GENERADO"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(165, 138)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 24
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 247)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RESULTADO)
        Me.Controls.Add(Me.CALCULAR)
        Me.Controls.Add(Me.TSAMONTO)
        Me.Controls.Add(Me.TEMONTO)
        Me.Controls.Add(Me.TCOMONTO)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TCPMONTO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CE)
        Me.Controls.Add(Me.CCB)
        Me.Controls.Add(Me.CCP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RAHORROS)
        Me.Controls.Add(Me.RMONETARIOP)
        Me.Controls.Add(Me.RMONETARIO)
        Me.Name = "Form1"
        Me.Text = "BANCO DE GUATEMALA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RMONETARIO As System.Windows.Forms.RadioButton
    Friend WithEvents RMONETARIOP As System.Windows.Forms.RadioButton
    Friend WithEvents RAHORROS As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CCP As System.Windows.Forms.CheckBox
    Friend WithEvents CCB As System.Windows.Forms.CheckBox
    Friend WithEvents CE As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TCPMONTO As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TCOMONTO As System.Windows.Forms.TextBox
    Friend WithEvents TEMONTO As System.Windows.Forms.TextBox
    Friend WithEvents TSAMONTO As System.Windows.Forms.TextBox
    Friend WithEvents CALCULAR As System.Windows.Forms.Button
    Friend WithEvents RESULTADO As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox

End Class
