<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerarDocumentos
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
        Me.checdescartar = New System.Windows.Forms.GroupBox()
        Me.chekdescartar = New System.Windows.Forms.CheckBox()
        Me.gridproductos = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preunit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ventasafectas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.elegir = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.botagregar = New System.Windows.Forms.Button()
        Me.textotalcredito = New System.Windows.Forms.TextBox()
        Me.texclicredito = New System.Windows.Forms.TextBox()
        Me.botgererarfactura = New System.Windows.Forms.Button()
        Me.botgenerarcomprobante = New System.Windows.Forms.Button()
        Me.botsalir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.checomision = New System.Windows.Forms.CheckBox()
        Me.texcomision = New System.Windows.Forms.TextBox()
        Me.lcomision = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.textotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.textiva = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.textsumas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textiraje = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.texcorrelativo = New System.Windows.Forms.TextBox()
        Me.botcliente = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.texcliente = New System.Windows.Forms.TextBox()
        Me.botguardar = New System.Windows.Forms.Button()
        Me.descartar = New System.Windows.Forms.ToolTip(Me.components)
        Me.checdescartar.SuspendLayout()
        CType(Me.gridproductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'checdescartar
        '
        Me.checdescartar.Controls.Add(Me.chekdescartar)
        Me.checdescartar.Controls.Add(Me.gridproductos)
        Me.checdescartar.Controls.Add(Me.Label2)
        Me.checdescartar.Controls.Add(Me.Label1)
        Me.checdescartar.Controls.Add(Me.botagregar)
        Me.checdescartar.Controls.Add(Me.textotalcredito)
        Me.checdescartar.Controls.Add(Me.texclicredito)
        Me.checdescartar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checdescartar.Location = New System.Drawing.Point(12, 23)
        Me.checdescartar.Name = "checdescartar"
        Me.checdescartar.Size = New System.Drawing.Size(788, 620)
        Me.checdescartar.TabIndex = 0
        Me.checdescartar.TabStop = False
        Me.checdescartar.Text = "Selecciona las notas de credito"
        '
        'chekdescartar
        '
        Me.chekdescartar.AutoSize = True
        Me.chekdescartar.Checked = True
        Me.chekdescartar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chekdescartar.Location = New System.Drawing.Point(635, 87)
        Me.chekdescartar.Name = "chekdescartar"
        Me.chekdescartar.Size = New System.Drawing.Size(124, 29)
        Me.chekdescartar.TabIndex = 6
        Me.chekdescartar.Text = "Descartar"
        Me.descartar.SetToolTip(Me.chekdescartar, "Indica que producto se va a descartar")
        Me.chekdescartar.UseVisualStyleBackColor = True
        '
        'gridproductos
        '
        Me.gridproductos.AllowUserToAddRows = False
        Me.gridproductos.AllowUserToDeleteRows = False
        Me.gridproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridproductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Cantidad, Me.Producto, Me.preunit, Me.ventasafectas, Me.elegir})
        Me.gridproductos.Location = New System.Drawing.Point(6, 122)
        Me.gridproductos.Name = "gridproductos"
        Me.gridproductos.RowHeadersVisible = False
        Me.gridproductos.Size = New System.Drawing.Size(753, 457)
        Me.gridproductos.TabIndex = 5
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 80
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 110
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.Width = 300
        '
        'preunit
        '
        Me.preunit.HeaderText = "Precio Unitario"
        Me.preunit.Name = "preunit"
        Me.preunit.Width = 90
        '
        'ventasafectas
        '
        Me.ventasafectas.HeaderText = "Ventas Afectas"
        Me.ventasafectas.Name = "ventasafectas"
        Me.ventasafectas.Width = 90
        '
        'elegir
        '
        Me.elegir.HeaderText = "Elegir"
        Me.elegir.Name = "elegir"
        Me.elegir.Width = 80
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(339, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nota de credito"
        '
        'botagregar
        '
        Me.botagregar.Location = New System.Drawing.Point(467, 60)
        Me.botagregar.Name = "botagregar"
        Me.botagregar.Size = New System.Drawing.Size(128, 43)
        Me.botagregar.TabIndex = 2
        Me.botagregar.Text = "Agregar"
        Me.botagregar.UseVisualStyleBackColor = True
        '
        'textotalcredito
        '
        Me.textotalcredito.Location = New System.Drawing.Point(342, 72)
        Me.textotalcredito.Name = "textotalcredito"
        Me.textotalcredito.Size = New System.Drawing.Size(110, 31)
        Me.textotalcredito.TabIndex = 1
        '
        'texclicredito
        '
        Me.texclicredito.Location = New System.Drawing.Point(6, 72)
        Me.texclicredito.Name = "texclicredito"
        Me.texclicredito.Size = New System.Drawing.Size(304, 31)
        Me.texclicredito.TabIndex = 0
        '
        'botgererarfactura
        '
        Me.botgererarfactura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.botgererarfactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.botgererarfactura.Location = New System.Drawing.Point(12, 649)
        Me.botgererarfactura.Name = "botgererarfactura"
        Me.botgererarfactura.Size = New System.Drawing.Size(209, 47)
        Me.botgererarfactura.TabIndex = 6
        Me.botgererarfactura.Text = "Generar Factura"
        Me.botgererarfactura.UseVisualStyleBackColor = True
        '
        'botgenerarcomprobante
        '
        Me.botgenerarcomprobante.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.botgenerarcomprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.botgenerarcomprobante.Location = New System.Drawing.Point(236, 649)
        Me.botgenerarcomprobante.Name = "botgenerarcomprobante"
        Me.botgenerarcomprobante.Size = New System.Drawing.Size(175, 47)
        Me.botgenerarcomprobante.TabIndex = 7
        Me.botgenerarcomprobante.Text = "Generar C.C.F"
        Me.botgenerarcomprobante.UseVisualStyleBackColor = True
        '
        'botsalir
        '
        Me.botsalir.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.botsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.botsalir.Location = New System.Drawing.Point(1087, 649)
        Me.botsalir.Name = "botsalir"
        Me.botsalir.Size = New System.Drawing.Size(183, 47)
        Me.botsalir.TabIndex = 8
        Me.botsalir.Text = "Salir"
        Me.botsalir.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.checomision)
        Me.GroupBox2.Controls.Add(Me.texcomision)
        Me.GroupBox2.Controls.Add(Me.lcomision)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.textotal)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.textiva)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.textsumas)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.textiraje)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.texcorrelativo)
        Me.GroupBox2.Controls.Add(Me.botcliente)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.texcliente)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(806, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(464, 617)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos generales del docuemento"
        '
        'checomision
        '
        Me.checomision.AutoSize = True
        Me.checomision.Location = New System.Drawing.Point(44, 282)
        Me.checomision.Name = "checomision"
        Me.checomision.Size = New System.Drawing.Size(116, 29)
        Me.checomision.TabIndex = 131
        Me.checomision.Text = "comision"
        Me.checomision.UseVisualStyleBackColor = True
        '
        'texcomision
        '
        Me.texcomision.Location = New System.Drawing.Point(53, 342)
        Me.texcomision.Margin = New System.Windows.Forms.Padding(4)
        Me.texcomision.Name = "texcomision"
        Me.texcomision.Size = New System.Drawing.Size(87, 31)
        Me.texcomision.TabIndex = 130
        Me.texcomision.Text = "0"
        Me.texcomision.Visible = False
        '
        'lcomision
        '
        Me.lcomision.AutoSize = True
        Me.lcomision.Location = New System.Drawing.Point(6, 314)
        Me.lcomision.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lcomision.Name = "lcomision"
        Me.lcomision.Size = New System.Drawing.Size(197, 25)
        Me.lcomision.TabIndex = 129
        Me.lcomision.Text = "Comision por venta"
        Me.lcomision.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(17, 219)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(398, 31)
        Me.DateTimePicker1.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 181)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 25)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Fecha"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(169, 475)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 25)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Venta Total"
        '
        'textotal
        '
        Me.textotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textotal.Location = New System.Drawing.Point(305, 472)
        Me.textotal.Name = "textotal"
        Me.textotal.Size = New System.Drawing.Size(133, 35)
        Me.textotal.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(196, 413)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Iva (13%)"
        '
        'textiva
        '
        Me.textiva.Location = New System.Drawing.Point(305, 410)
        Me.textiva.Name = "textiva"
        Me.textiva.Size = New System.Drawing.Size(133, 31)
        Me.textiva.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(221, 363)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 25)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Sumas"
        '
        'textsumas
        '
        Me.textsumas.Location = New System.Drawing.Point(305, 363)
        Me.textsumas.Name = "textsumas"
        Me.textsumas.Size = New System.Drawing.Size(133, 31)
        Me.textsumas.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(169, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Tiraje"
        '
        'textiraje
        '
        Me.textiraje.Location = New System.Drawing.Point(167, 129)
        Me.textiraje.Name = "textiraje"
        Me.textiraje.Size = New System.Drawing.Size(219, 31)
        Me.textiraje.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Correlativo"
        '
        'texcorrelativo
        '
        Me.texcorrelativo.Location = New System.Drawing.Point(17, 129)
        Me.texcorrelativo.Name = "texcorrelativo"
        Me.texcorrelativo.Size = New System.Drawing.Size(118, 31)
        Me.texcorrelativo.TabIndex = 8
        '
        'botcliente
        '
        Me.botcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botcliente.Location = New System.Drawing.Point(327, 63)
        Me.botcliente.Name = "botcliente"
        Me.botcliente.Size = New System.Drawing.Size(59, 31)
        Me.botcliente.TabIndex = 6
        Me.botcliente.Text = "..."
        Me.descartar.SetToolTip(Me.botcliente, "Selecciona un Cliente")
        Me.botcliente.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cliente"
        '
        'texcliente
        '
        Me.texcliente.Location = New System.Drawing.Point(17, 63)
        Me.texcliente.Name = "texcliente"
        Me.texcliente.Size = New System.Drawing.Size(304, 31)
        Me.texcliente.TabIndex = 6
        '
        'botguardar
        '
        Me.botguardar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.botguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.botguardar.Location = New System.Drawing.Point(806, 649)
        Me.botguardar.Name = "botguardar"
        Me.botguardar.Size = New System.Drawing.Size(183, 47)
        Me.botguardar.TabIndex = 10
        Me.botguardar.Text = "Guardar"
        Me.botguardar.UseVisualStyleBackColor = True
        '
        'GenerarDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1282, 708)
        Me.Controls.Add(Me.botguardar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.botsalir)
        Me.Controls.Add(Me.botgenerarcomprobante)
        Me.Controls.Add(Me.botgererarfactura)
        Me.Controls.Add(Me.checdescartar)
        Me.Name = "GenerarDocumentos"
        Me.Text = "Generar Documentos"
        Me.checdescartar.ResumeLayout(False)
        Me.checdescartar.PerformLayout()
        CType(Me.gridproductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents checdescartar As System.Windows.Forms.GroupBox
    Friend WithEvents gridproductos As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents botagregar As System.Windows.Forms.Button
    Friend WithEvents textotalcredito As System.Windows.Forms.TextBox
    Friend WithEvents texclicredito As System.Windows.Forms.TextBox
    Friend WithEvents botgererarfactura As System.Windows.Forms.Button
    Friend WithEvents botgenerarcomprobante As System.Windows.Forms.Button
    Friend WithEvents botsalir As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents textiva As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents textsumas As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents textiraje As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents texcorrelativo As System.Windows.Forms.TextBox
    Friend WithEvents botcliente As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents texcliente As System.Windows.Forms.TextBox
    Friend WithEvents botguardar As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents textotal As System.Windows.Forms.TextBox
    Friend WithEvents chekdescartar As System.Windows.Forms.CheckBox
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents preunit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ventasafectas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents elegir As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents descartar As System.Windows.Forms.ToolTip
    Friend WithEvents checomision As System.Windows.Forms.CheckBox
    Friend WithEvents texcomision As System.Windows.Forms.TextBox
    Friend WithEvents lcomision As System.Windows.Forms.Label
End Class
