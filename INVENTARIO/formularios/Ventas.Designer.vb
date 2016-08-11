<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.comboformapago = New System.Windows.Forms.ComboBox()
        Me.lforma = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lfecha = New System.Windows.Forms.Label()
        Me.texcliente = New System.Windows.Forms.TextBox()
        Me.lcliente = New System.Windows.Forms.Label()
        Me.texnumfact = New System.Windows.Forms.TextBox()
        Me.lnum = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.textotalp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.texcantidad = New System.Windows.Forms.TextBox()
        Me.texnombrep = New System.Windows.Forms.TextBox()
        Me.grubdescuento = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.texpdescuento = New System.Windows.Forms.TextBox()
        Me.botappdescuento = New System.Windows.Forms.Button()
        Me.checklibre = New System.Windows.Forms.CheckBox()
        Me.texexentas = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.texnosujeta = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.textotal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.texsumas = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gridcompra = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preciu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preciod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.exentas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HolaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lson = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Timerimprimir = New System.Windows.Forms.Timer(Me.components)
        Me.sugerir = New System.Windows.Forms.ToolTip(Me.components)
        Me.textiraje = New System.Windows.Forms.TextBox()
        Me.BalloonTip1 = New DevComponents.DotNetBar.BalloonTip()
        Me.ltiraje = New System.Windows.Forms.Label()
        Me.combotipo = New System.Windows.Forms.ComboBox()
        Me.ltipo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.boteliminar = New System.Windows.Forms.Button()
        Me.botguardar = New System.Windows.Forms.Button()
        Me.botagregar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.texiva = New System.Windows.Forms.TextBox()
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
        Me.botnuevop = New System.Windows.Forms.Button()
        Me.texcomision = New System.Windows.Forms.TextBox()
        Me.lcomision = New System.Windows.Forms.Label()
        Me.checomision = New System.Windows.Forms.CheckBox()
        Me.comboprecios = New System.Windows.Forms.ComboBox()
        Me.grubdescuento.SuspendLayout()
        CType(Me.gridcompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.gridproductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'comboformapago
        '
        Me.comboformapago.FormattingEnabled = True
        Me.comboformapago.Items.AddRange(New Object() {"Contado", "Credito"})
        Me.comboformapago.Location = New System.Drawing.Point(126, 89)
        Me.comboformapago.Margin = New System.Windows.Forms.Padding(4)
        Me.comboformapago.Name = "comboformapago"
        Me.comboformapago.Size = New System.Drawing.Size(115, 24)
        Me.comboformapago.TabIndex = 56
        Me.comboformapago.Text = "Contado"
        '
        'lforma
        '
        Me.lforma.AutoSize = True
        Me.lforma.Location = New System.Drawing.Point(19, 93)
        Me.lforma.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lforma.Name = "lforma"
        Me.lforma.Size = New System.Drawing.Size(102, 16)
        Me.lforma.TabIndex = 55
        Me.lforma.Text = "Forma de Pago"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(492, 57)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(266, 22)
        Me.DateTimePicker1.TabIndex = 44
        '
        'lfecha
        '
        Me.lfecha.AutoSize = True
        Me.lfecha.Location = New System.Drawing.Point(440, 60)
        Me.lfecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lfecha.Name = "lfecha"
        Me.lfecha.Size = New System.Drawing.Size(49, 16)
        Me.lfecha.TabIndex = 43
        Me.lfecha.Text = "Fecha:"
        '
        'texcliente
        '
        Me.texcliente.Location = New System.Drawing.Point(64, 57)
        Me.texcliente.Margin = New System.Windows.Forms.Padding(4)
        Me.texcliente.Name = "texcliente"
        Me.texcliente.Size = New System.Drawing.Size(144, 22)
        Me.texcliente.TabIndex = 40
        '
        'lcliente
        '
        Me.lcliente.AutoSize = True
        Me.lcliente.Location = New System.Drawing.Point(13, 60)
        Me.lcliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lcliente.Name = "lcliente"
        Me.lcliente.Size = New System.Drawing.Size(49, 16)
        Me.lcliente.TabIndex = 39
        Me.lcliente.Text = "Cliente"
        '
        'texnumfact
        '
        Me.texnumfact.Location = New System.Drawing.Point(505, 23)
        Me.texnumfact.Margin = New System.Windows.Forms.Padding(4)
        Me.texnumfact.Name = "texnumfact"
        Me.texnumfact.Size = New System.Drawing.Size(56, 22)
        Me.texnumfact.TabIndex = 38
        '
        'lnum
        '
        Me.lnum.AutoSize = True
        Me.lnum.Location = New System.Drawing.Point(381, 25)
        Me.lnum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnum.Name = "lnum"
        Me.lnum.Size = New System.Drawing.Size(121, 16)
        Me.lnum.TabIndex = 37
        Me.lnum.Text = "Numero de factura:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(555, 129)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 16)
        Me.Label16.TabIndex = 77
        Me.Label16.Text = "Total"
        '
        'textotalp
        '
        Me.textotalp.Location = New System.Drawing.Point(540, 149)
        Me.textotalp.Margin = New System.Windows.Forms.Padding(4)
        Me.textotalp.Name = "textotalp"
        Me.textotalp.Size = New System.Drawing.Size(88, 22)
        Me.textotalp.TabIndex = 76
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(350, 129)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 16)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Cantidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(428, 129)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Precio Unitario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(206, 129)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Nombre"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 151)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 16)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "Datos del producto"
        '
        'texcantidad
        '
        Me.texcantidad.Location = New System.Drawing.Point(345, 149)
        Me.texcantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.texcantidad.Name = "texcantidad"
        Me.texcantidad.Size = New System.Drawing.Size(85, 22)
        Me.texcantidad.TabIndex = 70
        '
        'texnombrep
        '
        Me.texnombrep.Location = New System.Drawing.Point(140, 149)
        Me.texnombrep.Margin = New System.Windows.Forms.Padding(4)
        Me.texnombrep.Name = "texnombrep"
        Me.texnombrep.Size = New System.Drawing.Size(202, 22)
        Me.texnombrep.TabIndex = 69
        '
        'grubdescuento
        '
        Me.grubdescuento.Controls.Add(Me.Label18)
        Me.grubdescuento.Controls.Add(Me.Label17)
        Me.grubdescuento.Controls.Add(Me.texpdescuento)
        Me.grubdescuento.Controls.Add(Me.botappdescuento)
        Me.grubdescuento.Location = New System.Drawing.Point(6, 92)
        Me.grubdescuento.Margin = New System.Windows.Forms.Padding(4)
        Me.grubdescuento.Name = "grubdescuento"
        Me.grubdescuento.Padding = New System.Windows.Forms.Padding(4)
        Me.grubdescuento.Size = New System.Drawing.Size(584, 70)
        Me.grubdescuento.TabIndex = 78
        Me.grubdescuento.TabStop = False
        Me.grubdescuento.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(166, 42)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(20, 16)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "%"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 19)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(212, 16)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "Digite el porcentaje del descuento"
        '
        'texpdescuento
        '
        Me.texpdescuento.Location = New System.Drawing.Point(75, 39)
        Me.texpdescuento.Margin = New System.Windows.Forms.Padding(4)
        Me.texpdescuento.Name = "texpdescuento"
        Me.texpdescuento.Size = New System.Drawing.Size(89, 22)
        Me.texpdescuento.TabIndex = 39
        '
        'botappdescuento
        '
        Me.botappdescuento.Location = New System.Drawing.Point(417, 59)
        Me.botappdescuento.Margin = New System.Windows.Forms.Padding(4)
        Me.botappdescuento.Name = "botappdescuento"
        Me.botappdescuento.Size = New System.Drawing.Size(148, 34)
        Me.botappdescuento.TabIndex = 42
        Me.botappdescuento.Text = "Aplicar descuento"
        Me.botappdescuento.UseVisualStyleBackColor = True
        '
        'checklibre
        '
        Me.checklibre.AutoSize = True
        Me.checklibre.Location = New System.Drawing.Point(537, 93)
        Me.checklibre.Name = "checklibre"
        Me.checklibre.Size = New System.Drawing.Size(57, 20)
        Me.checklibre.TabIndex = 79
        Me.checklibre.Text = "Libre"
        Me.checklibre.UseVisualStyleBackColor = True
        '
        'texexentas
        '
        Me.texexentas.Enabled = False
        Me.texexentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texexentas.Location = New System.Drawing.Point(992, 593)
        Me.texexentas.Margin = New System.Windows.Forms.Padding(4)
        Me.texexentas.Name = "texexentas"
        Me.texexentas.Size = New System.Drawing.Size(96, 24)
        Me.texexentas.TabIndex = 108
        Me.texexentas.Text = "0.0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(901, 598)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(83, 16)
        Me.Label20.TabIndex = 107
        Me.Label20.Text = "V.EXENTAS"
        '
        'texnosujeta
        '
        Me.texnosujeta.Enabled = False
        Me.texnosujeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texnosujeta.Location = New System.Drawing.Point(992, 559)
        Me.texnosujeta.Margin = New System.Windows.Forms.Padding(4)
        Me.texnosujeta.Name = "texnosujeta"
        Me.texnosujeta.Size = New System.Drawing.Size(96, 24)
        Me.texnosujeta.TabIndex = 106
        Me.texnosujeta.Text = "0.0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(893, 565)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 16)
        Me.Label15.TabIndex = 105
        Me.Label15.Text = "V.NO SUJETA"
        '
        'textotal
        '
        Me.textotal.Enabled = False
        Me.textotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textotal.Location = New System.Drawing.Point(992, 620)
        Me.textotal.Margin = New System.Windows.Forms.Padding(4)
        Me.textotal.Name = "textotal"
        Me.textotal.Size = New System.Drawing.Size(96, 24)
        Me.textotal.TabIndex = 100
        Me.textotal.Text = "0.0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(896, 625)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 16)
        Me.Label14.TabIndex = 99
        Me.Label14.Text = "Venta Total"
        '
        'texsumas
        '
        Me.texsumas.Enabled = False
        Me.texsumas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texsumas.Location = New System.Drawing.Point(992, 495)
        Me.texsumas.Margin = New System.Windows.Forms.Padding(4)
        Me.texsumas.Name = "texsumas"
        Me.texsumas.Size = New System.Drawing.Size(96, 24)
        Me.texsumas.TabIndex = 94
        Me.texsumas.Text = "0.0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(935, 500)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 16)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Sumas"
        '
        'gridcompra
        '
        Me.gridcompra.AllowUserToAddRows = False
        Me.gridcompra.AllowUserToDeleteRows = False
        Me.gridcompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridcompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.cantida, Me.nombr, Me.preciu, Me.preciod, Me.exentas, Me.tota})
        Me.gridcompra.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridcompra.DefaultCellStyle = DataGridViewCellStyle1
        Me.gridcompra.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.gridcompra.Location = New System.Drawing.Point(8, 177)
        Me.gridcompra.Name = "gridcompra"
        Me.gridcompra.ReadOnly = True
        Me.gridcompra.RowHeadersVisible = False
        Me.gridcompra.Size = New System.Drawing.Size(1080, 283)
        Me.gridcompra.TabIndex = 111
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
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HolaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(160, 26)
        '
        'HolaToolStripMenuItem
        '
        Me.HolaToolStripMenuItem.Name = "HolaToolStripMenuItem"
        Me.HolaToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.HolaToolStripMenuItem.Text = "Quitar Producto"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lson)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.grubdescuento)
        Me.GroupBox3.Location = New System.Drawing.Point(26, 482)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(843, 86)
        Me.GroupBox3.TabIndex = 113
        Me.GroupBox3.TabStop = False
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
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(9, 18)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(35, 16)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Son:"
        '
        'Timerimprimir
        '
        Me.Timerimprimir.Interval = 50
        '
        'sugerir
        '
        Me.sugerir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sugerir.ShowAlways = True
        Me.sugerir.StripAmpersands = True
        '
        'textiraje
        '
        Me.textiraje.Location = New System.Drawing.Point(648, 20)
        Me.textiraje.Margin = New System.Windows.Forms.Padding(4)
        Me.textiraje.Name = "textiraje"
        Me.textiraje.Size = New System.Drawing.Size(151, 22)
        Me.textiraje.TabIndex = 116
        Me.sugerir.SetToolTip(Me.textiraje, "hola")
        '
        'ltiraje
        '
        Me.ltiraje.AutoSize = True
        Me.ltiraje.BackColor = System.Drawing.Color.Transparent
        Me.ltiraje.Location = New System.Drawing.Point(601, 22)
        Me.ltiraje.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ltiraje.Name = "ltiraje"
        Me.ltiraje.Size = New System.Drawing.Size(46, 16)
        Me.ltiraje.TabIndex = 115
        Me.ltiraje.Text = "Tiraje:"
        '
        'combotipo
        '
        Me.combotipo.FormattingEnabled = True
        Me.combotipo.Items.AddRange(New Object() {"Factura", "Comprobante de Credito fiscal"})
        Me.combotipo.Location = New System.Drawing.Point(64, 12)
        Me.combotipo.Margin = New System.Windows.Forms.Padding(4)
        Me.combotipo.Name = "combotipo"
        Me.combotipo.Size = New System.Drawing.Size(115, 24)
        Me.combotipo.TabIndex = 121
        Me.combotipo.Text = "Factura"
        '
        'ltipo
        '
        Me.ltipo.AutoSize = True
        Me.ltipo.Location = New System.Drawing.Point(23, 15)
        Me.ltipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ltipo.Name = "ltipo"
        Me.ltipo.Size = New System.Drawing.Size(36, 16)
        Me.ltipo.TabIndex = 120
        Me.ltipo.Text = "Tipo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.boteliminar)
        Me.GroupBox1.Controls.Add(Me.botguardar)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 574)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(838, 69)
        Me.GroupBox1.TabIndex = 122
        Me.GroupBox1.TabStop = False
        '
        'boteliminar
        '
        Me.boteliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boteliminar.Location = New System.Drawing.Point(646, 19)
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
        Me.botguardar.Text = "Imprimir y guardar"
        Me.botguardar.UseVisualStyleBackColor = True
        '
        'botagregar
        '
        Me.botagregar.Location = New System.Drawing.Point(703, 129)
        Me.botagregar.Name = "botagregar"
        Me.botagregar.Size = New System.Drawing.Size(107, 43)
        Me.botagregar.TabIndex = 1
        Me.botagregar.Text = "Agregar"
        Me.botagregar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(928, 533)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 16)
        Me.Label12.TabIndex = 97
        Me.Label12.Text = "IVA(13%)"
        '
        'texiva
        '
        Me.texiva.Enabled = False
        Me.texiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texiva.Location = New System.Drawing.Point(992, 527)
        Me.texiva.Margin = New System.Windows.Forms.Padding(4)
        Me.texiva.Name = "texiva"
        Me.texiva.Size = New System.Drawing.Size(96, 24)
        Me.texiva.TabIndex = 98
        Me.texiva.Text = "0.0"
        '
        'gridproductos
        '
        Me.gridproductos.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.gridproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridproductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codiggo, Me.Column1, Me.Descripcion, Me.catego, Me.Unidmed, Me.precios, Me.exi, Me.popular, Me.frecuente, Me.mayoreo})
        Me.gridproductos.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.gridproductos.Location = New System.Drawing.Point(8, 177)
        Me.gridproductos.MultiSelect = False
        Me.gridproductos.Name = "gridproductos"
        Me.gridproductos.RowHeadersVisible = False
        Me.gridproductos.Size = New System.Drawing.Size(1080, 300)
        Me.gridproductos.TabIndex = 124
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
        Me.Unidmed.HeaderText = "Unidad de medida"
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
        'botnuevop
        '
        Me.botnuevop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.botnuevop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botnuevop.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.botnuevop.Location = New System.Drawing.Point(981, 129)
        Me.botnuevop.Name = "botnuevop"
        Me.botnuevop.Size = New System.Drawing.Size(107, 43)
        Me.botnuevop.TabIndex = 125
        Me.botnuevop.Text = "Nuevo Producto"
        Me.botnuevop.UseVisualStyleBackColor = False
        '
        'texcomision
        '
        Me.texcomision.Location = New System.Drawing.Point(950, 77)
        Me.texcomision.Margin = New System.Windows.Forms.Padding(4)
        Me.texcomision.Name = "texcomision"
        Me.texcomision.Size = New System.Drawing.Size(87, 22)
        Me.texcomision.TabIndex = 127
        Me.texcomision.Visible = False
        '
        'lcomision
        '
        Me.lcomision.AutoSize = True
        Me.lcomision.Location = New System.Drawing.Point(932, 57)
        Me.lcomision.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lcomision.Name = "lcomision"
        Me.lcomision.Size = New System.Drawing.Size(123, 16)
        Me.lcomision.TabIndex = 126
        Me.lcomision.Text = "Comision por venta"
        Me.lcomision.Visible = False
        '
        'checomision
        '
        Me.checomision.AutoSize = True
        Me.checomision.Location = New System.Drawing.Point(950, 16)
        Me.checomision.Name = "checomision"
        Me.checomision.Size = New System.Drawing.Size(81, 20)
        Me.checomision.TabIndex = 128
        Me.checomision.Text = "comision"
        Me.checomision.UseVisualStyleBackColor = True
        '
        'comboprecios
        '
        Me.comboprecios.FormattingEnabled = True
        Me.comboprecios.Location = New System.Drawing.Point(436, 148)
        Me.comboprecios.Name = "comboprecios"
        Me.comboprecios.Size = New System.Drawing.Size(97, 24)
        Me.comboprecios.TabIndex = 129
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1107, 656)
        Me.Controls.Add(Me.comboprecios)
        Me.Controls.Add(Me.checomision)
        Me.Controls.Add(Me.texcomision)
        Me.Controls.Add(Me.lcomision)
        Me.Controls.Add(Me.botnuevop)
        Me.Controls.Add(Me.gridproductos)
        Me.Controls.Add(Me.botagregar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.combotipo)
        Me.Controls.Add(Me.ltipo)
        Me.Controls.Add(Me.textiraje)
        Me.Controls.Add(Me.ltiraje)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gridcompra)
        Me.Controls.Add(Me.texexentas)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.texnosujeta)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.textotal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.texiva)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.texsumas)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.checklibre)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.textotalp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.texcantidad)
        Me.Controls.Add(Me.texnombrep)
        Me.Controls.Add(Me.comboformapago)
        Me.Controls.Add(Me.lforma)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lfecha)
        Me.Controls.Add(Me.texcliente)
        Me.Controls.Add(Me.lcliente)
        Me.Controls.Add(Me.texnumfact)
        Me.Controls.Add(Me.lnum)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.grubdescuento.ResumeLayout(False)
        Me.grubdescuento.PerformLayout()
        CType(Me.gridcompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.gridproductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents comboformapago As System.Windows.Forms.ComboBox
    Friend WithEvents lforma As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lfecha As System.Windows.Forms.Label
    Friend WithEvents texcliente As System.Windows.Forms.TextBox
    Friend WithEvents lcliente As System.Windows.Forms.Label
    Friend WithEvents texnumfact As System.Windows.Forms.TextBox
    Friend WithEvents lnum As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents textotalp As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents texcantidad As System.Windows.Forms.TextBox
    Friend WithEvents texnombrep As System.Windows.Forms.TextBox
    Friend WithEvents grubdescuento As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents texpdescuento As System.Windows.Forms.TextBox
    Friend WithEvents botappdescuento As System.Windows.Forms.Button
    Friend WithEvents checklibre As System.Windows.Forms.CheckBox
    Friend WithEvents texexentas As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents texnosujeta As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents textotal As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents texsumas As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gridcompra As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lson As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Timerimprimir As System.Windows.Forms.Timer
    Friend WithEvents sugerir As System.Windows.Forms.ToolTip
    Friend WithEvents BalloonTip1 As DevComponents.DotNetBar.BalloonTip
    Friend WithEvents textiraje As System.Windows.Forms.TextBox
    Friend WithEvents ltiraje As System.Windows.Forms.Label
    Friend WithEvents combotipo As System.Windows.Forms.ComboBox
    Friend WithEvents ltipo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents botguardar As System.Windows.Forms.Button
    Friend WithEvents botagregar As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents texiva As System.Windows.Forms.TextBox
    Friend WithEvents boteliminar As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HolaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gridproductos As System.Windows.Forms.DataGridView
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents preciu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents preciod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents exentas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents botnuevop As System.Windows.Forms.Button
    Friend WithEvents texcomision As System.Windows.Forms.TextBox
    Friend WithEvents lcomision As System.Windows.Forms.Label
    Friend WithEvents checomision As System.Windows.Forms.CheckBox
    Friend WithEvents comboprecios As System.Windows.Forms.ComboBox
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
End Class
