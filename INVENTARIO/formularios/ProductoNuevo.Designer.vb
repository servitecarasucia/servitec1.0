<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductoNuevo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductoNuevo))
        Me.lbcamposobligatorios = New System.Windows.Forms.Label()
        Me.texcategoria = New System.Windows.Forms.TextBox()
        Me.texcodigo = New System.Windows.Forms.TextBox()
        Me.texnombre = New System.Windows.Forms.TextBox()
        Me.texdescripcion = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ldescripcion = New System.Windows.Forms.Label()
        Me.lnombre = New System.Windows.Forms.Label()
        Me.lcodigo = New System.Windows.Forms.Label()
        Me.lcat = New System.Windows.Forms.Label()
        Me.picno = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picsi = New System.Windows.Forms.PictureBox()
        Me.texpreciounitario = New System.Windows.Forms.TextBox()
        Me.texprecioindi = New System.Windows.Forms.TextBox()
        Me.tex40 = New System.Windows.Forms.TextBox()
        Me.tex30 = New System.Windows.Forms.TextBox()
        Me.tex20 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.texcantidad = New System.Windows.Forms.TextBox()
        Me.texunidaddemedida = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lunitmed = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.botguardar = New System.Windows.Forms.Button()
        Me.botsalir = New System.Windows.Forms.Button()
        Me.botborrar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picsi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbcamposobligatorios
        '
        Me.lbcamposobligatorios.AutoSize = True
        Me.lbcamposobligatorios.BackColor = System.Drawing.Color.Transparent
        Me.lbcamposobligatorios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbcamposobligatorios.Location = New System.Drawing.Point(12, 9)
        Me.lbcamposobligatorios.Name = "lbcamposobligatorios"
        Me.lbcamposobligatorios.Size = New System.Drawing.Size(408, 20)
        Me.lbcamposobligatorios.TabIndex = 1
        Me.lbcamposobligatorios.Text = "Por favor llenar todos los campos que son obligatorios (*)"
        '
        'texcategoria
        '
        Me.texcategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texcategoria.Location = New System.Drawing.Point(145, 21)
        Me.texcategoria.Name = "texcategoria"
        Me.texcategoria.Size = New System.Drawing.Size(100, 26)
        Me.texcategoria.TabIndex = 2
        '
        'texcodigo
        '
        Me.texcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texcodigo.Location = New System.Drawing.Point(145, 52)
        Me.texcodigo.Name = "texcodigo"
        Me.texcodigo.Size = New System.Drawing.Size(100, 26)
        Me.texcodigo.TabIndex = 3
        '
        'texnombre
        '
        Me.texnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texnombre.Location = New System.Drawing.Point(145, 90)
        Me.texnombre.Name = "texnombre"
        Me.texnombre.Size = New System.Drawing.Size(367, 26)
        Me.texnombre.TabIndex = 4
        '
        'texdescripcion
        '
        Me.texdescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texdescripcion.Location = New System.Drawing.Point(145, 121)
        Me.texdescripcion.Name = "texdescripcion"
        Me.texdescripcion.Size = New System.Drawing.Size(367, 26)
        Me.texdescripcion.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ldescripcion)
        Me.GroupBox1.Controls.Add(Me.lnombre)
        Me.GroupBox1.Controls.Add(Me.lcodigo)
        Me.GroupBox1.Controls.Add(Me.lcat)
        Me.GroupBox1.Controls.Add(Me.picno)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.texnombre)
        Me.GroupBox1.Controls.Add(Me.texcategoria)
        Me.GroupBox1.Controls.Add(Me.texdescripcion)
        Me.GroupBox1.Controls.Add(Me.texcodigo)
        Me.GroupBox1.Controls.Add(Me.picsi)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(567, 177)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'ldescripcion
        '
        Me.ldescripcion.AutoSize = True
        Me.ldescripcion.BackColor = System.Drawing.Color.Transparent
        Me.ldescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ldescripcion.Location = New System.Drawing.Point(518, 121)
        Me.ldescripcion.Name = "ldescripcion"
        Me.ldescripcion.Size = New System.Drawing.Size(16, 20)
        Me.ldescripcion.TabIndex = 43
        Me.ldescripcion.Text = "*"
        '
        'lnombre
        '
        Me.lnombre.AutoSize = True
        Me.lnombre.BackColor = System.Drawing.Color.Transparent
        Me.lnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnombre.Location = New System.Drawing.Point(518, 90)
        Me.lnombre.Name = "lnombre"
        Me.lnombre.Size = New System.Drawing.Size(16, 20)
        Me.lnombre.TabIndex = 42
        Me.lnombre.Text = "*"
        '
        'lcodigo
        '
        Me.lcodigo.AutoSize = True
        Me.lcodigo.BackColor = System.Drawing.Color.Transparent
        Me.lcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lcodigo.Location = New System.Drawing.Point(282, 53)
        Me.lcodigo.Name = "lcodigo"
        Me.lcodigo.Size = New System.Drawing.Size(16, 20)
        Me.lcodigo.TabIndex = 41
        Me.lcodigo.Text = "*"
        '
        'lcat
        '
        Me.lcat.AutoSize = True
        Me.lcat.BackColor = System.Drawing.Color.Transparent
        Me.lcat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lcat.Location = New System.Drawing.Point(247, 21)
        Me.lcat.Name = "lcat"
        Me.lcat.Size = New System.Drawing.Size(16, 20)
        Me.lcat.TabIndex = 40
        Me.lcat.Text = "*"
        '
        'picno
        '
        Me.picno.Image = CType(resources.GetObject("picno.Image"), System.Drawing.Image)
        Me.picno.Location = New System.Drawing.Point(251, 52)
        Me.picno.Name = "picno"
        Me.picno.Size = New System.Drawing.Size(25, 25)
        Me.picno.TabIndex = 38
        Me.picno.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Descripción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(86, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Código"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Categoria"
        '
        'picsi
        '
        Me.picsi.Image = CType(resources.GetObject("picsi.Image"), System.Drawing.Image)
        Me.picsi.Location = New System.Drawing.Point(251, 53)
        Me.picsi.Name = "picsi"
        Me.picsi.Size = New System.Drawing.Size(25, 25)
        Me.picsi.TabIndex = 39
        Me.picsi.TabStop = False
        '
        'texpreciounitario
        '
        Me.texpreciounitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texpreciounitario.Location = New System.Drawing.Point(145, 45)
        Me.texpreciounitario.Name = "texpreciounitario"
        Me.texpreciounitario.Size = New System.Drawing.Size(100, 38)
        Me.texpreciounitario.TabIndex = 7
        '
        'texprecioindi
        '
        Me.texprecioindi.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texprecioindi.Location = New System.Drawing.Point(145, 99)
        Me.texprecioindi.Name = "texprecioindi"
        Me.texprecioindi.Size = New System.Drawing.Size(100, 38)
        Me.texprecioindi.TabIndex = 8
        '
        'tex40
        '
        Me.tex40.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tex40.Location = New System.Drawing.Point(298, 45)
        Me.tex40.Name = "tex40"
        Me.tex40.Size = New System.Drawing.Size(100, 26)
        Me.tex40.TabIndex = 9
        '
        'tex30
        '
        Me.tex30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tex30.Location = New System.Drawing.Point(298, 77)
        Me.tex30.Name = "tex30"
        Me.tex30.Size = New System.Drawing.Size(100, 26)
        Me.tex30.TabIndex = 10
        '
        'tex20
        '
        Me.tex20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tex20.Location = New System.Drawing.Point(298, 109)
        Me.tex20.Name = "tex20"
        Me.tex20.Size = New System.Drawing.Size(100, 26)
        Me.tex20.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.tex20)
        Me.GroupBox2.Controls.Add(Me.tex40)
        Me.GroupBox2.Controls.Add(Me.tex30)
        Me.GroupBox2.Controls.Add(Me.texpreciounitario)
        Me.GroupBox2.Controls.Add(Me.texprecioindi)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 215)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(567, 160)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(404, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 20)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "20%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(405, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "30%"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(405, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "40%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(294, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Precio publico"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Precio Individual"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Precio Unitario"
        '
        'texcantidad
        '
        Me.texcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texcantidad.Location = New System.Drawing.Point(161, 412)
        Me.texcantidad.Name = "texcantidad"
        Me.texcantidad.Size = New System.Drawing.Size(81, 31)
        Me.texcantidad.TabIndex = 13
        '
        'texunidaddemedida
        '
        Me.texunidaddemedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texunidaddemedida.Location = New System.Drawing.Point(161, 449)
        Me.texunidaddemedida.Name = "texunidaddemedida"
        Me.texunidaddemedida.Size = New System.Drawing.Size(116, 31)
        Me.texunidaddemedida.TabIndex = 14
        Me.texunidaddemedida.Text = "Unidad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(67, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 20)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Cantidad"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(138, 20)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Unidad de medida"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lunitmed)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 393)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(567, 113)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        '
        'lunitmed
        '
        Me.lunitmed.AutoSize = True
        Me.lunitmed.BackColor = System.Drawing.Color.Transparent
        Me.lunitmed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lunitmed.Location = New System.Drawing.Point(267, 67)
        Me.lunitmed.Name = "lunitmed"
        Me.lunitmed.Size = New System.Drawing.Size(16, 20)
        Me.lunitmed.TabIndex = 26
        Me.lunitmed.Text = "*"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.botguardar)
        Me.GroupBox4.Controls.Add(Me.botsalir)
        Me.GroupBox4.Controls.Add(Me.botborrar)
        Me.GroupBox4.Location = New System.Drawing.Point(590, 32)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(148, 474)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        '
        'botguardar
        '
        Me.botguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botguardar.Location = New System.Drawing.Point(6, 19)
        Me.botguardar.Name = "botguardar"
        Me.botguardar.Size = New System.Drawing.Size(136, 50)
        Me.botguardar.TabIndex = 5
        Me.botguardar.Text = "Guardar"
        Me.botguardar.UseVisualStyleBackColor = True
        '
        'botsalir
        '
        Me.botsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botsalir.Location = New System.Drawing.Point(6, 428)
        Me.botsalir.Name = "botsalir"
        Me.botsalir.Size = New System.Drawing.Size(136, 35)
        Me.botsalir.TabIndex = 4
        Me.botsalir.Text = "Salir"
        Me.botsalir.UseVisualStyleBackColor = True
        '
        'botborrar
        '
        Me.botborrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botborrar.Location = New System.Drawing.Point(6, 376)
        Me.botborrar.Name = "botborrar"
        Me.botborrar.Size = New System.Drawing.Size(136, 35)
        Me.botborrar.TabIndex = 3
        Me.botborrar.Text = "Borrar"
        Me.botborrar.UseVisualStyleBackColor = True
        '
        'ProductoNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 528)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.texunidaddemedida)
        Me.Controls.Add(Me.texcantidad)
        Me.Controls.Add(Me.lbcamposobligatorios)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Name = "ProductoNuevo"
        Me.Text = "Nuevo Producto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picsi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbcamposobligatorios As System.Windows.Forms.Label
    Friend WithEvents texcategoria As System.Windows.Forms.TextBox
    Friend WithEvents texcodigo As System.Windows.Forms.TextBox
    Friend WithEvents texnombre As System.Windows.Forms.TextBox
    Friend WithEvents texdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents texpreciounitario As System.Windows.Forms.TextBox
    Friend WithEvents texprecioindi As System.Windows.Forms.TextBox
    Friend WithEvents tex40 As System.Windows.Forms.TextBox
    Friend WithEvents tex30 As System.Windows.Forms.TextBox
    Friend WithEvents tex20 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents texcantidad As System.Windows.Forms.TextBox
    Friend WithEvents texunidaddemedida As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents botguardar As System.Windows.Forms.Button
    Friend WithEvents botsalir As System.Windows.Forms.Button
    Friend WithEvents botborrar As System.Windows.Forms.Button
    Friend WithEvents picno As System.Windows.Forms.PictureBox
    Friend WithEvents picsi As System.Windows.Forms.PictureBox
    Friend WithEvents lcat As System.Windows.Forms.Label
    Friend WithEvents lcodigo As System.Windows.Forms.Label
    Friend WithEvents lnombre As System.Windows.Forms.Label
    Friend WithEvents ldescripcion As System.Windows.Forms.Label
    Friend WithEvents lunitmed As System.Windows.Forms.Label
End Class
