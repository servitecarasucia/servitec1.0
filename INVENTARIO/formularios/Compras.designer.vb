﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class compra
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.texnumfact = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.texproveedor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.combotipo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.texnombrep = New System.Windows.Forms.TextBox()
        Me.texcantidad = New System.Windows.Forms.TextBox()
        Me.texprecio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.coboformadepago = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.texsumas = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.texiva = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.textotal = New System.Windows.Forms.TextBox()
        Me.textotalp = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.checklibre = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.texnosujeta = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.texexentas = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.textiraje = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lson = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.texivauno = New System.Windows.Forms.TextBox()
        Me.text1retencion = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.botagregar = New System.Windows.Forms.Button()
        Me.checuno = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.boteliminar = New System.Windows.Forms.Button()
        Me.botguardar = New System.Windows.Forms.Button()
        Me.gridcompra = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preciu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preciod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.exentas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.gridproductos = New System.Windows.Forms.DataGridView()
        Me.codiggo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.catego = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidmed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.exi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.popular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.frecuente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mayoreo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.botactualizar = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.gridcompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridproductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(426, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero de factura:"
        '
        'texnumfact
        '
        Me.texnumfact.Location = New System.Drawing.Point(554, 4)
        Me.texnumfact.Margin = New System.Windows.Forms.Padding(4)
        Me.texnumfact.Name = "texnumfact"
        Me.texnumfact.Size = New System.Drawing.Size(56, 22)
        Me.texnumfact.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(53, 5)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Proveedor"
        '
        'texproveedor
        '
        Me.texproveedor.Location = New System.Drawing.Point(130, 5)
        Me.texproveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.texproveedor.Name = "texproveedor"
        Me.texproveedor.Size = New System.Drawing.Size(224, 22)
        Me.texproveedor.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(89, 37)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tipo"
        '
        'combotipo
        '
        Me.combotipo.FormattingEnabled = True
        Me.combotipo.Items.AddRange(New Object() {"Factura", "Comprobante de Credito fiscal", "Gastos"})
        Me.combotipo.Location = New System.Drawing.Point(130, 34)
        Me.combotipo.Margin = New System.Windows.Forms.Padding(4)
        Me.combotipo.Name = "combotipo"
        Me.combotipo.Size = New System.Drawing.Size(224, 24)
        Me.combotipo.TabIndex = 3
        Me.combotipo.Text = "Comprobante de Credito fiscal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(443, 39)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Fecha:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(496, 37)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(266, 22)
        Me.DateTimePicker1.TabIndex = 4
        '
        'texnombrep
        '
        Me.texnombrep.Location = New System.Drawing.Point(135, 128)
        Me.texnombrep.Margin = New System.Windows.Forms.Padding(4)
        Me.texnombrep.Name = "texnombrep"
        Me.texnombrep.Size = New System.Drawing.Size(202, 22)
        Me.texnombrep.TabIndex = 5
        '
        'texcantidad
        '
        Me.texcantidad.Location = New System.Drawing.Point(339, 128)
        Me.texcantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.texcantidad.Name = "texcantidad"
        Me.texcantidad.Size = New System.Drawing.Size(85, 22)
        Me.texcantidad.TabIndex = 6
        '
        'texprecio
        '
        Me.texprecio.Location = New System.Drawing.Point(429, 128)
        Me.texprecio.Margin = New System.Windows.Forms.Padding(4)
        Me.texprecio.Name = "texprecio"
        Me.texprecio.Size = New System.Drawing.Size(88, 22)
        Me.texprecio.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(201, 107)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nombre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(423, 107)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Precio Unitario"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(345, 107)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 16)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Cantidad"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(23, 72)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 16)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Forma de Pago"
        '
        'coboformadepago
        '
        Me.coboformadepago.FormattingEnabled = True
        Me.coboformadepago.Items.AddRange(New Object() {"Contado", "Credito"})
        Me.coboformadepago.Location = New System.Drawing.Point(130, 69)
        Me.coboformadepago.Margin = New System.Windows.Forms.Padding(4)
        Me.coboformadepago.Name = "coboformadepago"
        Me.coboformadepago.Size = New System.Drawing.Size(115, 24)
        Me.coboformadepago.TabIndex = 4
        Me.coboformadepago.Text = "Contado"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(940, 502)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 16)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Sumas"
        '
        'texsumas
        '
        Me.texsumas.Enabled = False
        Me.texsumas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texsumas.Location = New System.Drawing.Point(998, 497)
        Me.texsumas.Margin = New System.Windows.Forms.Padding(4)
        Me.texsumas.Name = "texsumas"
        Me.texsumas.Size = New System.Drawing.Size(96, 24)
        Me.texsumas.TabIndex = 26
        Me.texsumas.Text = "0.0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(932, 531)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 16)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "IVA(13%)"
        '
        'texiva
        '
        Me.texiva.Enabled = False
        Me.texiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texiva.Location = New System.Drawing.Point(997, 526)
        Me.texiva.Margin = New System.Windows.Forms.Padding(4)
        Me.texiva.Name = "texiva"
        Me.texiva.Size = New System.Drawing.Size(96, 24)
        Me.texiva.TabIndex = 32
        Me.texiva.Text = "0.0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(901, 641)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 16)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Venta Total"
        '
        'textotal
        '
        Me.textotal.Enabled = False
        Me.textotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textotal.Location = New System.Drawing.Point(997, 636)
        Me.textotal.Margin = New System.Windows.Forms.Padding(4)
        Me.textotal.Name = "textotal"
        Me.textotal.Size = New System.Drawing.Size(96, 24)
        Me.textotal.TabIndex = 36
        Me.textotal.Text = "0.0"
        '
        'textotalp
        '
        Me.textotalp.Location = New System.Drawing.Point(534, 127)
        Me.textotalp.Margin = New System.Windows.Forms.Padding(4)
        Me.textotalp.Name = "textotalp"
        Me.textotalp.Size = New System.Drawing.Size(88, 22)
        Me.textotalp.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(550, 107)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 16)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Total"
        '
        'checklibre
        '
        Me.checklibre.AutoSize = True
        Me.checklibre.BackColor = System.Drawing.Color.Transparent
        Me.checklibre.Location = New System.Drawing.Point(561, 84)
        Me.checklibre.Name = "checklibre"
        Me.checklibre.Size = New System.Drawing.Size(57, 20)
        Me.checklibre.TabIndex = 80
        Me.checklibre.Text = "Libre"
        Me.checklibre.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(898, 587)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 16)
        Me.Label15.TabIndex = 89
        Me.Label15.Text = "V.NO SUJETA"
        '
        'texnosujeta
        '
        Me.texnosujeta.Enabled = False
        Me.texnosujeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texnosujeta.Location = New System.Drawing.Point(997, 582)
        Me.texnosujeta.Margin = New System.Windows.Forms.Padding(4)
        Me.texnosujeta.Name = "texnosujeta"
        Me.texnosujeta.Size = New System.Drawing.Size(96, 24)
        Me.texnosujeta.TabIndex = 90
        Me.texnosujeta.Text = "0.0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(906, 615)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(83, 16)
        Me.Label20.TabIndex = 91
        Me.Label20.Text = "V.EXENTAS"
        '
        'texexentas
        '
        Me.texexentas.Enabled = False
        Me.texexentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texexentas.Location = New System.Drawing.Point(997, 609)
        Me.texexentas.Margin = New System.Windows.Forms.Padding(4)
        Me.texexentas.Name = "texexentas"
        Me.texexentas.Size = New System.Drawing.Size(96, 24)
        Me.texexentas.TabIndex = 92
        Me.texexentas.Text = "0.0"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Location = New System.Drawing.Point(617, 5)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(46, 16)
        Me.Label21.TabIndex = 93
        Me.Label21.Text = "Tiraje:"
        '
        'textiraje
        '
        Me.textiraje.Location = New System.Drawing.Point(662, 2)
        Me.textiraje.Margin = New System.Windows.Forms.Padding(4)
        Me.textiraje.Name = "textiraje"
        Me.textiraje.Size = New System.Drawing.Size(151, 22)
        Me.textiraje.TabIndex = 3
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(9, 18)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(35, 16)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Son:"
        '
        'lson
        '
        Me.lson.AutoSize = True
        Me.lson.Location = New System.Drawing.Point(52, 18)
        Me.lson.Name = "lson"
        Me.lson.Size = New System.Drawing.Size(35, 16)
        Me.lson.TabIndex = 1
        Me.lson.Text = "Son:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lson)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 484)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(603, 86)
        Me.GroupBox3.TabIndex = 96
        Me.GroupBox3.TabStop = False
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        Me.Highlighter1.CustomHighlightColors = New System.Drawing.Color() {System.Drawing.Color.Red, System.Drawing.Color.White}
        '
        'texivauno
        '
        Me.texivauno.Enabled = False
        Me.texivauno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texivauno.Location = New System.Drawing.Point(996, 554)
        Me.texivauno.Margin = New System.Windows.Forms.Padding(4)
        Me.texivauno.Name = "texivauno"
        Me.texivauno.Size = New System.Drawing.Size(96, 24)
        Me.texivauno.TabIndex = 98
        Me.texivauno.Text = "0.0"
        '
        'text1retencion
        '
        Me.text1retencion.AutoSize = True
        Me.text1retencion.BackColor = System.Drawing.Color.Transparent
        Me.text1retencion.Location = New System.Drawing.Point(933, 557)
        Me.text1retencion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.text1retencion.Name = "text1retencion"
        Me.text1retencion.Size = New System.Drawing.Size(35, 16)
        Me.text1retencion.TabIndex = 97
        Me.text1retencion.Text = "(1%)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 130)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 16)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "Datos del producto"
        '
        'botagregar
        '
        Me.botagregar.Location = New System.Drawing.Point(706, 108)
        Me.botagregar.Name = "botagregar"
        Me.botagregar.Size = New System.Drawing.Size(107, 43)
        Me.botagregar.TabIndex = 8
        Me.botagregar.Text = "Agregar"
        Me.botagregar.UseVisualStyleBackColor = True
        '
        'checuno
        '
        Me.checuno.AutoSize = True
        Me.checuno.BackColor = System.Drawing.Color.Transparent
        Me.checuno.Location = New System.Drawing.Point(625, 84)
        Me.checuno.Name = "checuno"
        Me.checuno.Size = New System.Drawing.Size(54, 20)
        Me.checuno.TabIndex = 101
        Me.checuno.Text = "(1%)"
        Me.checuno.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.boteliminar)
        Me.GroupBox1.Controls.Add(Me.botguardar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 591)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(598, 69)
        Me.GroupBox1.TabIndex = 123
        Me.GroupBox1.TabStop = False
        '
        'boteliminar
        '
        Me.boteliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boteliminar.Location = New System.Drawing.Point(432, 21)
        Me.boteliminar.Name = "boteliminar"
        Me.boteliminar.Size = New System.Drawing.Size(159, 40)
        Me.boteliminar.TabIndex = 1
        Me.boteliminar.Text = "Quitar producto"
        Me.boteliminar.UseVisualStyleBackColor = True
        '
        'botguardar
        '
        Me.botguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botguardar.Location = New System.Drawing.Point(7, 23)
        Me.botguardar.Name = "botguardar"
        Me.botguardar.Size = New System.Drawing.Size(159, 40)
        Me.botguardar.TabIndex = 0
        Me.botguardar.Text = "Guardar"
        Me.botguardar.UseVisualStyleBackColor = True
        '
        'gridcompra
        '
        Me.gridcompra.AllowUserToAddRows = False
        Me.gridcompra.AllowUserToDeleteRows = False
        Me.gridcompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridcompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.cantida, Me.nombr, Me.preciu, Me.preciod, Me.exentas, Me.tota})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridcompra.DefaultCellStyle = DataGridViewCellStyle2
        Me.gridcompra.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.gridcompra.Location = New System.Drawing.Point(14, 159)
        Me.gridcompra.Name = "gridcompra"
        Me.gridcompra.ReadOnly = True
        Me.gridcompra.RowHeadersVisible = False
        Me.gridcompra.Size = New System.Drawing.Size(1079, 320)
        Me.gridcompra.TabIndex = 124
        '
        'codigo
        '
        Me.codigo.HeaderText = "Codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 75
        '
        'cantida
        '
        Me.cantida.HeaderText = "Cantidad"
        Me.cantida.Name = "cantida"
        Me.cantida.ReadOnly = True
        Me.cantida.Width = 150
        '
        'nombr
        '
        Me.nombr.HeaderText = "Nombre del Producto"
        Me.nombr.Name = "nombr"
        Me.nombr.ReadOnly = True
        Me.nombr.Width = 350
        '
        'preciu
        '
        Me.preciu.HeaderText = "Precio Unitario"
        Me.preciu.Name = "preciu"
        Me.preciu.ReadOnly = True
        Me.preciu.Width = 150
        '
        'preciod
        '
        Me.preciod.HeaderText = "Ventas       no sujetas"
        Me.preciod.Name = "preciod"
        Me.preciod.ReadOnly = True
        '
        'exentas
        '
        Me.exentas.HeaderText = "Ventas Exentas"
        Me.exentas.Name = "exentas"
        Me.exentas.ReadOnly = True
        '
        'tota
        '
        Me.tota.HeaderText = "Ventas Afectas"
        Me.tota.Name = "tota"
        Me.tota.ReadOnly = True
        Me.tota.Width = 150
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(827, 36)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(266, 22)
        Me.DateTimePicker2.TabIndex = 125
        '
        'gridproductos
        '
        Me.gridproductos.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.gridproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridproductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codiggo, Me.Column1, Me.Descripcion, Me.catego, Me.Unidmed, Me.precios, Me.exi, Me.popular, Me.frecuente, Me.mayoreo})
        Me.gridproductos.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.gridproductos.Location = New System.Drawing.Point(13, 157)
        Me.gridproductos.MultiSelect = False
        Me.gridproductos.Name = "gridproductos"
        Me.gridproductos.RowHeadersVisible = False
        Me.gridproductos.Size = New System.Drawing.Size(1080, 322)
        Me.gridproductos.TabIndex = 126
        '
        'codiggo
        '
        Me.codiggo.Frozen = True
        Me.codiggo.HeaderText = "Codigo"
        Me.codiggo.Name = "codiggo"
        '
        'Column1
        '
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 300
        '
        'Descripcion
        '
        Me.Descripcion.Frozen = True
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Width = 225
        '
        'catego
        '
        Me.catego.Frozen = True
        Me.catego.HeaderText = "Categoria"
        Me.catego.Name = "catego"
        Me.catego.Width = 150
        '
        'Unidmed
        '
        Me.Unidmed.Frozen = True
        Me.Unidmed.HeaderText = "Precio Costo"
        Me.Unidmed.Name = "Unidmed"
        '
        'precios
        '
        Me.precios.Frozen = True
        Me.precios.HeaderText = "Precio"
        Me.precios.Name = "precios"
        '
        'exi
        '
        Me.exi.HeaderText = "Existencias"
        Me.exi.Name = "exi"
        '
        'popular
        '
        Me.popular.HeaderText = "porular"
        Me.popular.Name = "popular"
        Me.popular.Visible = False
        '
        'frecuente
        '
        Me.frecuente.HeaderText = "frecuente"
        Me.frecuente.Name = "frecuente"
        Me.frecuente.Visible = False
        '
        'mayoreo
        '
        Me.mayoreo.HeaderText = "mayoreo"
        Me.mayoreo.Name = "mayoreo"
        Me.mayoreo.Visible = False
        '
        'botactualizar
        '
        Me.botactualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.botactualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botactualizar.Location = New System.Drawing.Point(985, 110)
        Me.botactualizar.Name = "botactualizar"
        Me.botactualizar.Size = New System.Drawing.Size(107, 43)
        Me.botactualizar.TabIndex = 127
        Me.botactualizar.Text = "Actualizar"
        Me.botactualizar.UseVisualStyleBackColor = False
        '
        'compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1108, 668)
        Me.Controls.Add(Me.botactualizar)
        Me.Controls.Add(Me.gridproductos)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.gridcompra)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.checuno)
        Me.Controls.Add(Me.botagregar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.texivauno)
        Me.Controls.Add(Me.text1retencion)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.textiraje)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.texexentas)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.texnosujeta)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.checklibre)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.textotalp)
        Me.Controls.Add(Me.textotal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.texiva)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.texsumas)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.coboformadepago)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.texprecio)
        Me.Controls.Add(Me.texcantidad)
        Me.Controls.Add(Me.texnombrep)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.combotipo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.texproveedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.texnumfact)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "compra"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras"
        Me.TopMost = True
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.gridcompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridproductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lson As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents textiraje As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents texexentas As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents texnosujeta As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents checklibre As System.Windows.Forms.CheckBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents textotalp As System.Windows.Forms.TextBox
    Friend WithEvents textotal As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents texiva As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents texsumas As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents coboformadepago As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents texprecio As System.Windows.Forms.TextBox
    Friend WithEvents texcantidad As System.Windows.Forms.TextBox
    Friend WithEvents texnombrep As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents combotipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents texproveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents texnumfact As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents texivauno As System.Windows.Forms.TextBox
    Friend WithEvents text1retencion As System.Windows.Forms.Label
    Private WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents checuno As System.Windows.Forms.CheckBox
    Friend WithEvents botagregar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents boteliminar As System.Windows.Forms.Button
    Friend WithEvents botguardar As System.Windows.Forms.Button
    Friend WithEvents gridcompra As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents preciu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents preciod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents exentas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gridproductos As System.Windows.Forms.DataGridView
    Friend WithEvents codiggo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents catego As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unidmed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precios As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents exi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents popular As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents frecuente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mayoreo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents botactualizar As System.Windows.Forms.Button
End Class
