﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CALCULOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOSTRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARMATRIZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MATRIZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ESTADISTICASToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ESTADISTICASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CERRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 163)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PACIENTE"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.Gray
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"EFECTIVO", "ACH", "DEPOSITO", "TARJETA DE CREDITO", "SEGURO MEDICO"})
        Me.ComboBox2.Location = New System.Drawing.Point(186, 132)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(155, 21)
        Me.ComboBox2.TabIndex = 11
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Gray
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"HABITACION PRIVADA", "HABITACION SEMI-PRIVADA", "HABITACION NO PRIVADA"})
        Me.ComboBox1.Location = New System.Drawing.Point(186, 107)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(155, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Gray
        Me.TextBox4.Location = New System.Drawing.Point(186, 82)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(155, 20)
        Me.TextBox4.TabIndex = 9
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Gray
        Me.TextBox3.Location = New System.Drawing.Point(186, 58)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(155, 20)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Gray
        Me.TextBox2.Location = New System.Drawing.Point(186, 35)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(155, 20)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Gray
        Me.TextBox1.Location = New System.Drawing.Point(186, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(155, 20)
        Me.TextBox1.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "MÉTODO DE PAGO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "TIPO DE HABITACION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "HONORARIOS MEDICOS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NO DE DIAS HOSPITALIZADO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NUMERO DE NIT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE DEL PACIENTE"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gray
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULOToolStripMenuItem, Me.MOSTRARToolStripMenuItem, Me.CONSULTARToolStripMenuItem, Me.LIMPIARMATRIZToolStripMenuItem, Me.ESTADISTICASToolStripMenuItem, Me.CERRARToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(966, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CALCULOToolStripMenuItem
        '
        Me.CALCULOToolStripMenuItem.Name = "CALCULOToolStripMenuItem"
        Me.CALCULOToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.CALCULOToolStripMenuItem.Text = "CALCULO"
        '
        'MOSTRARToolStripMenuItem
        '
        Me.MOSTRARToolStripMenuItem.Name = "MOSTRARToolStripMenuItem"
        Me.MOSTRARToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.MOSTRARToolStripMenuItem.Text = "MOSTRAR"
        '
        'CONSULTARToolStripMenuItem
        '
        Me.CONSULTARToolStripMenuItem.Name = "CONSULTARToolStripMenuItem"
        Me.CONSULTARToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.CONSULTARToolStripMenuItem.Text = "CONSULTAR"
        '
        'LIMPIARMATRIZToolStripMenuItem
        '
        Me.LIMPIARMATRIZToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MATRIZToolStripMenuItem, Me.ESTADISTICASToolStripMenuItem1})
        Me.LIMPIARMATRIZToolStripMenuItem.Name = "LIMPIARMATRIZToolStripMenuItem"
        Me.LIMPIARMATRIZToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.LIMPIARMATRIZToolStripMenuItem.Text = "LIMPIAR"
        '
        'MATRIZToolStripMenuItem
        '
        Me.MATRIZToolStripMenuItem.Name = "MATRIZToolStripMenuItem"
        Me.MATRIZToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MATRIZToolStripMenuItem.Text = "MATRIZ"
        '
        'ESTADISTICASToolStripMenuItem1
        '
        Me.ESTADISTICASToolStripMenuItem1.Name = "ESTADISTICASToolStripMenuItem1"
        Me.ESTADISTICASToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ESTADISTICASToolStripMenuItem1.Text = "ESTADISTICAS"
        '
        'ESTADISTICASToolStripMenuItem
        '
        Me.ESTADISTICASToolStripMenuItem.Name = "ESTADISTICASToolStripMenuItem"
        Me.ESTADISTICASToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.ESTADISTICASToolStripMenuItem.Text = "ESTADISTICAS"
        '
        'CERRARToolStripMenuItem
        '
        Me.CERRARToolStripMenuItem.Name = "CERRARToolStripMenuItem"
        Me.CERRARToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.CERRARToolStripMenuItem.Text = "CERRAR"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 196)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(955, 186)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 14)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(949, 166)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "NOMBRE"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "NIT"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "DIAS HOSPITALIZADO"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "HONORARIOS"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "HABITACION"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "METODO DE PAGO"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "TOTAL PARCIAL"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "DESCUENTO/RECARGO"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "PAGO FINAL"
        Me.Column9.Name = "Column9"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Location = New System.Drawing.Point(353, 29)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CONSULTA"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Gray
        Me.TextBox5.Location = New System.Drawing.Point(6, 59)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(155, 20)
        Me.TextBox5.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "NUMERO DE NIT"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.TextBox8)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.TextBox7)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.TextBox6)
        Me.GroupBox4.Location = New System.Drawing.Point(559, 29)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(395, 161)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ESTADISTICAS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(244, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "PACIENTES QUE USAN HABITACION PRIVADA"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.Gray
        Me.TextBox6.Location = New System.Drawing.Point(264, 32)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(125, 20)
        Me.TextBox6.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(197, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "TOTAL RECAUDADO POR PAGO ACH"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.Gray
        Me.TextBox7.Location = New System.Drawing.Point(264, 70)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(125, 20)
        Me.TextBox7.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(219, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "DIAS UTILIZADOS DE CAMA NO PRIVADA"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.Gray
        Me.TextBox8.Location = New System.Drawing.Point(264, 113)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(125, 20)
        Me.TextBox8.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(966, 385)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "HOSPITAL"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CALCULOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MOSTRARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CONSULTARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LIMPIARMATRIZToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MATRIZToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ESTADISTICASToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ESTADISTICASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CERRARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox

End Class
