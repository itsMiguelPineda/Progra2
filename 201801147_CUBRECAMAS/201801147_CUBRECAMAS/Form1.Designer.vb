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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RKING = New System.Windows.Forms.RadioButton()
        Me.RQUEEN = New System.Windows.Forms.RadioButton()
        Me.RIMPERIAL = New System.Windows.Forms.RadioButton()
        Me.RMATRIMONIAL = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.THILO = New System.Windows.Forms.TextBox()
        Me.TSEDA = New System.Windows.Forms.TextBox()
        Me.TALGODON = New System.Windows.Forms.TextBox()
        Me.TLINO = New System.Windows.Forms.TextBox()
        Me.CHILO = New System.Windows.Forms.CheckBox()
        Me.CCEDA = New System.Windows.Forms.CheckBox()
        Me.CALGODON = New System.Windows.Forms.CheckBox()
        Me.CLINO = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BCALCULAR = New System.Windows.Forms.Button()
        Me.BBORRAR = New System.Windows.Forms.Button()
        Me.BSALIR = New System.Windows.Forms.Button()
        Me.TMANODEOBRA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TMATERIALES = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TPRECIOCOSTO = New System.Windows.Forms.TextBox()
        Me.TPRECIOVENTA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox1.Controls.Add(Me.RKING)
        Me.GroupBox1.Controls.Add(Me.RQUEEN)
        Me.GroupBox1.Controls.Add(Me.RIMPERIAL)
        Me.GroupBox1.Controls.Add(Me.RMATRIMONIAL)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(157, 119)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TAMAÑO DE CUBRECAMA"
        '
        'RKING
        '
        Me.RKING.AutoSize = True
        Me.RKING.Location = New System.Drawing.Point(15, 88)
        Me.RKING.Name = "RKING"
        Me.RKING.Size = New System.Drawing.Size(95, 17)
        Me.RKING.TabIndex = 5
        Me.RKING.Text = "KING Q105.99"
        Me.RKING.UseVisualStyleBackColor = True
        '
        'RQUEEN
        '
        Me.RQUEEN.AutoSize = True
        Me.RQUEEN.Location = New System.Drawing.Point(15, 65)
        Me.RQUEEN.Name = "RQUEEN"
        Me.RQUEEN.Size = New System.Drawing.Size(101, 17)
        Me.RQUEEN.TabIndex = 4
        Me.RQUEEN.Text = "QUEEN Q99.99"
        Me.RQUEEN.UseVisualStyleBackColor = True
        '
        'RIMPERIAL
        '
        Me.RIMPERIAL.AutoSize = True
        Me.RIMPERIAL.Location = New System.Drawing.Point(15, 19)
        Me.RIMPERIAL.Name = "RIMPERIAL"
        Me.RIMPERIAL.Size = New System.Drawing.Size(116, 17)
        Me.RIMPERIAL.TabIndex = 2
        Me.RIMPERIAL.Text = "IMPERIAL  Q65.50"
        Me.RIMPERIAL.UseVisualStyleBackColor = True
        '
        'RMATRIMONIAL
        '
        Me.RMATRIMONIAL.AutoSize = True
        Me.RMATRIMONIAL.Location = New System.Drawing.Point(15, 42)
        Me.RMATRIMONIAL.Name = "RMATRIMONIAL"
        Me.RMATRIMONIAL.Size = New System.Drawing.Size(138, 17)
        Me.RMATRIMONIAL.TabIndex = 3
        Me.RMATRIMONIAL.Text = "MATRIMONIAL Q85.99"
        Me.RMATRIMONIAL.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox2.Controls.Add(Me.THILO)
        Me.GroupBox2.Controls.Add(Me.TSEDA)
        Me.GroupBox2.Controls.Add(Me.TALGODON)
        Me.GroupBox2.Controls.Add(Me.TLINO)
        Me.GroupBox2.Controls.Add(Me.CHILO)
        Me.GroupBox2.Controls.Add(Me.CCEDA)
        Me.GroupBox2.Controls.Add(Me.CALGODON)
        Me.GroupBox2.Controls.Add(Me.CLINO)
        Me.GroupBox2.Location = New System.Drawing.Point(202, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(309, 119)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MATERIAL DE CUBRECAMA"
        '
        'THILO
        '
        Me.THILO.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.THILO.Location = New System.Drawing.Point(182, 85)
        Me.THILO.Name = "THILO"
        Me.THILO.Size = New System.Drawing.Size(100, 20)
        Me.THILO.TabIndex = 9
        Me.THILO.Visible = False
        '
        'TSEDA
        '
        Me.TSEDA.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TSEDA.Location = New System.Drawing.Point(182, 62)
        Me.TSEDA.Name = "TSEDA"
        Me.TSEDA.Size = New System.Drawing.Size(100, 20)
        Me.TSEDA.TabIndex = 8
        Me.TSEDA.Visible = False
        '
        'TALGODON
        '
        Me.TALGODON.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TALGODON.Location = New System.Drawing.Point(182, 39)
        Me.TALGODON.Name = "TALGODON"
        Me.TALGODON.Size = New System.Drawing.Size(100, 20)
        Me.TALGODON.TabIndex = 7
        Me.TALGODON.Visible = False
        '
        'TLINO
        '
        Me.TLINO.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TLINO.Location = New System.Drawing.Point(182, 16)
        Me.TLINO.Name = "TLINO"
        Me.TLINO.Size = New System.Drawing.Size(100, 20)
        Me.TLINO.TabIndex = 6
        Me.TLINO.Visible = False
        '
        'CHILO
        '
        Me.CHILO.AutoSize = True
        Me.CHILO.Location = New System.Drawing.Point(6, 89)
        Me.CHILO.Name = "CHILO"
        Me.CHILO.Size = New System.Drawing.Size(181, 17)
        Me.CHILO.TabIndex = 5
        Me.CHILO.Text = "HILO CRUDO Q39.99 X YARDA"
        Me.CHILO.UseVisualStyleBackColor = True
        '
        'CCEDA
        '
        Me.CCEDA.AutoSize = True
        Me.CCEDA.Location = New System.Drawing.Point(6, 66)
        Me.CCEDA.Name = "CCEDA"
        Me.CCEDA.Size = New System.Drawing.Size(143, 17)
        Me.CCEDA.TabIndex = 4
        Me.CCEDA.Text = "SEDA Q30.99 X YARDA"
        Me.CCEDA.UseVisualStyleBackColor = True
        '
        'CALGODON
        '
        Me.CALGODON.AutoSize = True
        Me.CALGODON.Location = New System.Drawing.Point(6, 43)
        Me.CALGODON.Name = "CALGODON"
        Me.CALGODON.Size = New System.Drawing.Size(167, 17)
        Me.CALGODON.TabIndex = 3
        Me.CALGODON.Text = "ALGODÓN Q23.99 X YARDA"
        Me.CALGODON.UseVisualStyleBackColor = True
        '
        'CLINO
        '
        Me.CLINO.AutoSize = True
        Me.CLINO.Location = New System.Drawing.Point(6, 20)
        Me.CLINO.Name = "CLINO"
        Me.CLINO.Size = New System.Drawing.Size(139, 17)
        Me.CLINO.TabIndex = 2
        Me.CLINO.Text = "LINO Q15.00 X YARDA"
        Me.CLINO.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(372, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CANTIDAD DE YARDAS"
        '
        'BCALCULAR
        '
        Me.BCALCULAR.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BCALCULAR.Location = New System.Drawing.Point(109, 260)
        Me.BCALCULAR.Name = "BCALCULAR"
        Me.BCALCULAR.Size = New System.Drawing.Size(90, 30)
        Me.BCALCULAR.TabIndex = 3
        Me.BCALCULAR.Text = "CALCULAR"
        Me.BCALCULAR.UseVisualStyleBackColor = False
        '
        'BBORRAR
        '
        Me.BBORRAR.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BBORRAR.Location = New System.Drawing.Point(229, 260)
        Me.BBORRAR.Name = "BBORRAR"
        Me.BBORRAR.Size = New System.Drawing.Size(90, 30)
        Me.BBORRAR.TabIndex = 4
        Me.BBORRAR.Text = "BORRAR"
        Me.BBORRAR.UseVisualStyleBackColor = False
        '
        'BSALIR
        '
        Me.BSALIR.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BSALIR.Location = New System.Drawing.Point(347, 260)
        Me.BSALIR.Name = "BSALIR"
        Me.BSALIR.Size = New System.Drawing.Size(90, 30)
        Me.BSALIR.TabIndex = 5
        Me.BSALIR.Text = "SALIR"
        Me.BSALIR.UseVisualStyleBackColor = False
        '
        'TMANODEOBRA
        '
        Me.TMANODEOBRA.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TMANODEOBRA.Enabled = False
        Me.TMANODEOBRA.Location = New System.Drawing.Point(26, 191)
        Me.TMANODEOBRA.Name = "TMANODEOBRA"
        Me.TMANODEOBRA.Size = New System.Drawing.Size(100, 20)
        Me.TMANODEOBRA.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(8, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "TOTAL DE MANO DE OBRA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label3.Location = New System.Drawing.Point(155, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "TOTAL DE MATERIALES"
        '
        'TMATERIALES
        '
        Me.TMATERIALES.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TMATERIALES.Enabled = False
        Me.TMATERIALES.Location = New System.Drawing.Point(173, 191)
        Me.TMATERIALES.Name = "TMATERIALES"
        Me.TMATERIALES.Size = New System.Drawing.Size(100, 20)
        Me.TMATERIALES.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label4.Location = New System.Drawing.Point(302, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "PRECIO COSTO"
        '
        'TPRECIOCOSTO
        '
        Me.TPRECIOCOSTO.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TPRECIOCOSTO.Enabled = False
        Me.TPRECIOCOSTO.Location = New System.Drawing.Point(295, 191)
        Me.TPRECIOCOSTO.Name = "TPRECIOCOSTO"
        Me.TPRECIOCOSTO.Size = New System.Drawing.Size(100, 20)
        Me.TPRECIOCOSTO.TabIndex = 16
        '
        'TPRECIOVENTA
        '
        Me.TPRECIOVENTA.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TPRECIOVENTA.Enabled = False
        Me.TPRECIOVENTA.Location = New System.Drawing.Point(415, 191)
        Me.TPRECIOVENTA.Name = "TPRECIOVENTA"
        Me.TPRECIOVENTA.Size = New System.Drawing.Size(100, 20)
        Me.TPRECIOVENTA.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label5.Location = New System.Drawing.Point(425, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "PRECIO VENTA"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(551, 302)
        Me.Controls.Add(Me.TPRECIOVENTA)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TPRECIOCOSTO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TMATERIALES)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TMANODEOBRA)
        Me.Controls.Add(Me.BSALIR)
        Me.Controls.Add(Me.BBORRAR)
        Me.Controls.Add(Me.BCALCULAR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "CUBRECAMAS MIGUEL"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RKING As System.Windows.Forms.RadioButton
    Friend WithEvents RQUEEN As System.Windows.Forms.RadioButton
    Friend WithEvents RIMPERIAL As System.Windows.Forms.RadioButton
    Friend WithEvents RMATRIMONIAL As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents THILO As System.Windows.Forms.TextBox
    Friend WithEvents TSEDA As System.Windows.Forms.TextBox
    Friend WithEvents TALGODON As System.Windows.Forms.TextBox
    Friend WithEvents TLINO As System.Windows.Forms.TextBox
    Friend WithEvents CHILO As System.Windows.Forms.CheckBox
    Friend WithEvents CCEDA As System.Windows.Forms.CheckBox
    Friend WithEvents CALGODON As System.Windows.Forms.CheckBox
    Friend WithEvents CLINO As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BCALCULAR As System.Windows.Forms.Button
    Friend WithEvents BBORRAR As System.Windows.Forms.Button
    Friend WithEvents BSALIR As System.Windows.Forms.Button
    Friend WithEvents TMANODEOBRA As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TMATERIALES As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TPRECIOCOSTO As System.Windows.Forms.TextBox
    Friend WithEvents TPRECIOVENTA As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
