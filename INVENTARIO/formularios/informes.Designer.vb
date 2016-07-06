<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class informes
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.texruta = New System.Windows.Forms.TextBox()
        Me.inventariodeexistencias = New System.Windows.Forms.Button()
        Me.inventariogeneral = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.texrutac = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.comprasalcontribuyente = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dthasta = New System.Windows.Forms.DateTimePicker()
        Me.dtdesde = New System.Windows.Forms.DateTimePicker()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.texrutav = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dat2 = New System.Windows.Forms.DateTimePicker()
        Me.dat1 = New System.Windows.Forms.DateTimePicker()
        Me.botventascontribuyente = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.botventasfinal = New System.Windows.Forms.Button()
        Me.lhasta = New System.Windows.Forms.Label()
        Me.dthastavc = New System.Windows.Forms.DateTimePicker()
        Me.dtdesdevc = New System.Windows.Forms.DateTimePicker()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.texrutavd = New System.Windows.Forms.TextBox()
        Me.generareporte = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textitulo1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.datep1 = New System.Windows.Forms.DateTimePicker()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(833, 390)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.texruta)
        Me.TabPage1.Controls.Add(Me.inventariodeexistencias)
        Me.TabPage1.Controls.Add(Me.inventariogeneral)
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(825, 353)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Inventarios"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(394, 60)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 31)
        Me.Button5.TabIndex = 31
        Me.Button5.Text = "..."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(99, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(160, 24)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Ruta del reporte"
        '
        'texruta
        '
        Me.texruta.Location = New System.Drawing.Point(3, 61)
        Me.texruta.Name = "texruta"
        Me.texruta.Size = New System.Drawing.Size(392, 29)
        Me.texruta.TabIndex = 29
        '
        'inventariodeexistencias
        '
        Me.inventariodeexistencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventariodeexistencias.Location = New System.Drawing.Point(333, 155)
        Me.inventariodeexistencias.Name = "inventariodeexistencias"
        Me.inventariodeexistencias.Size = New System.Drawing.Size(275, 44)
        Me.inventariodeexistencias.TabIndex = 28
        Me.inventariodeexistencias.Text = "Inventario de existencias"
        Me.inventariodeexistencias.UseVisualStyleBackColor = True
        '
        'inventariogeneral
        '
        Me.inventariogeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventariogeneral.Location = New System.Drawing.Point(17, 155)
        Me.inventariogeneral.Name = "inventariogeneral"
        Me.inventariogeneral.Size = New System.Drawing.Size(275, 44)
        Me.inventariogeneral.TabIndex = 27
        Me.inventariogeneral.Text = "Inventario General"
        Me.inventariogeneral.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.texrutac)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.comprasalcontribuyente)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.dthasta)
        Me.TabPage2.Controls.Add(Me.dtdesde)
        Me.TabPage2.Location = New System.Drawing.Point(4, 33)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(825, 353)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Compras"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(399, 64)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 31)
        Me.Button6.TabIndex = 34
        Me.Button6.Text = "..."
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(104, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 24)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Ruta del reporte"
        '
        'texrutac
        '
        Me.texrutac.Location = New System.Drawing.Point(8, 65)
        Me.texrutac.Name = "texrutac"
        Me.texrutac.Size = New System.Drawing.Size(392, 29)
        Me.texrutac.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(597, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 24)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Hasta"
        '
        'comprasalcontribuyente
        '
        Me.comprasalcontribuyente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comprasalcontribuyente.Location = New System.Drawing.Point(287, 250)
        Me.comprasalcontribuyente.Name = "comprasalcontribuyente"
        Me.comprasalcontribuyente.Size = New System.Drawing.Size(275, 44)
        Me.comprasalcontribuyente.TabIndex = 26
        Me.comprasalcontribuyente.Text = "Compras al contribuyente"
        Me.comprasalcontribuyente.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(170, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 24)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Desde"
        '
        'dthasta
        '
        Me.dthasta.Location = New System.Drawing.Point(436, 175)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(382, 29)
        Me.dthasta.TabIndex = 22
        '
        'dtdesde
        '
        Me.dtdesde.Location = New System.Drawing.Point(8, 175)
        Me.dtdesde.Name = "dtdesde"
        Me.dtdesde.Size = New System.Drawing.Size(392, 29)
        Me.dtdesde.TabIndex = 21
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button7)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.texrutav)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.dat2)
        Me.TabPage3.Controls.Add(Me.dat1)
        Me.TabPage3.Controls.Add(Me.botventascontribuyente)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.botventasfinal)
        Me.TabPage3.Controls.Add(Me.lhasta)
        Me.TabPage3.Controls.Add(Me.dthastavc)
        Me.TabPage3.Controls.Add(Me.dtdesdevc)
        Me.TabPage3.Location = New System.Drawing.Point(4, 33)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(825, 353)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Ventas"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(397, 39)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 31)
        Me.Button7.TabIndex = 34
        Me.Button7.Text = "..."
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(102, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(160, 24)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Ruta del reporte"
        '
        'texrutav
        '
        Me.texrutav.Location = New System.Drawing.Point(6, 40)
        Me.texrutav.Name = "texrutav"
        Me.texrutav.Size = New System.Drawing.Size(392, 29)
        Me.texrutav.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(153, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 24)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Desde"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(591, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 24)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Hasta"
        '
        'dat2
        '
        Me.dat2.Location = New System.Drawing.Point(418, 121)
        Me.dat2.Name = "dat2"
        Me.dat2.Size = New System.Drawing.Size(395, 29)
        Me.dat2.TabIndex = 18
        '
        'dat1
        '
        Me.dat1.Location = New System.Drawing.Point(6, 121)
        Me.dat1.Name = "dat1"
        Me.dat1.Size = New System.Drawing.Size(382, 29)
        Me.dat1.TabIndex = 17
        '
        'botventascontribuyente
        '
        Me.botventascontribuyente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botventascontribuyente.Location = New System.Drawing.Point(280, 302)
        Me.botventascontribuyente.Name = "botventascontribuyente"
        Me.botventascontribuyente.Size = New System.Drawing.Size(275, 44)
        Me.botventascontribuyente.TabIndex = 16
        Me.botventascontribuyente.Text = "Ventas al contribuyente"
        Me.botventascontribuyente.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(174, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Desde"
        '
        'botventasfinal
        '
        Me.botventasfinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botventasfinal.Location = New System.Drawing.Point(267, 156)
        Me.botventasfinal.Name = "botventasfinal"
        Me.botventasfinal.Size = New System.Drawing.Size(279, 44)
        Me.botventasfinal.TabIndex = 15
        Me.botventasfinal.Text = "Ventas al consumidor final"
        Me.botventasfinal.UseVisualStyleBackColor = True
        '
        'lhasta
        '
        Me.lhasta.AutoSize = True
        Me.lhasta.Location = New System.Drawing.Point(591, 94)
        Me.lhasta.Name = "lhasta"
        Me.lhasta.Size = New System.Drawing.Size(62, 24)
        Me.lhasta.TabIndex = 13
        Me.lhasta.Text = "Hasta"
        '
        'dthastavc
        '
        Me.dthastavc.Location = New System.Drawing.Point(418, 258)
        Me.dthastavc.Name = "dthastavc"
        Me.dthastavc.Size = New System.Drawing.Size(395, 29)
        Me.dthastavc.TabIndex = 12
        '
        'dtdesdevc
        '
        Me.dtdesdevc.Location = New System.Drawing.Point(6, 258)
        Me.dtdesdevc.Name = "dtdesdevc"
        Me.dtdesdevc.Size = New System.Drawing.Size(382, 29)
        Me.dtdesdevc.TabIndex = 11
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Button8)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.texrutavd)
        Me.TabPage4.Controls.Add(Me.generareporte)
        Me.TabPage4.Controls.Add(Me.Label5)
        Me.TabPage4.Controls.Add(Me.textitulo1)
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Controls.Add(Me.datep1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 33)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(825, 353)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Ventas Diarias"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(394, 54)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 31)
        Me.Button8.TabIndex = 34
        Me.Button8.Text = "..."
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(99, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(160, 24)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Ruta del reporte"
        '
        'texrutavd
        '
        Me.texrutavd.Location = New System.Drawing.Point(3, 55)
        Me.texrutavd.Name = "texrutavd"
        Me.texrutavd.Size = New System.Drawing.Size(392, 29)
        Me.texrutavd.TabIndex = 32
        '
        'generareporte
        '
        Me.generareporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.generareporte.Location = New System.Drawing.Point(551, 173)
        Me.generareporte.Name = "generareporte"
        Me.generareporte.Size = New System.Drawing.Size(201, 56)
        Me.generareporte.TabIndex = 28
        Me.generareporte.Text = "Generar Reporte"
        Me.generareporte.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(87, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(261, 24)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Escriba el titulo del reporte"
        '
        'textitulo1
        '
        Me.textitulo1.Location = New System.Drawing.Point(12, 292)
        Me.textitulo1.Name = "textitulo1"
        Me.textitulo1.Size = New System.Drawing.Size(392, 29)
        Me.textitulo1.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 24)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Seleccione el dia"
        '
        'datep1
        '
        Me.datep1.Location = New System.Drawing.Point(11, 184)
        Me.datep1.Name = "datep1"
        Me.datep1.Size = New System.Drawing.Size(393, 29)
        Me.datep1.TabIndex = 21
        '
        'informes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 391)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "informes"
        Me.Text = "Reportes"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents inventariodeexistencias As System.Windows.Forms.Button
    Friend WithEvents inventariogeneral As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents comprasalcontribuyente As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dthasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtdesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dat2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dat1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents botventascontribuyente As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents botventasfinal As System.Windows.Forms.Button
    Friend WithEvents lhasta As System.Windows.Forms.Label
    Friend WithEvents dthastavc As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtdesdevc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents texruta As System.Windows.Forms.TextBox
    Friend WithEvents generareporte As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents textitulo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents datep1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents texrutac As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents texrutav As System.Windows.Forms.TextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents texrutavd As System.Windows.Forms.TextBox
End Class
