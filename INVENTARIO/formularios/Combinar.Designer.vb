<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Combinar
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.todouno = New DevComponents.DotNetBar.ButtonX()
        Me.botremover = New DevComponents.DotNetBar.ButtonX()
        Me.botagregar = New DevComponents.DotNetBar.ButtonX()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.existencias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.botaceptar = New DevComponents.DotNetBar.ButtonX()
        Me.texnunidad = New System.Windows.Forms.TextBox()
        Me.texnexistencias = New System.Windows.Forms.TextBox()
        Me.texnpreciopublico = New System.Windows.Forms.TextBox()
        Me.texnprecio = New System.Windows.Forms.TextBox()
        Me.texndescripcion = New System.Windows.Forms.TextBox()
        Me.texnnombre = New System.Windows.Forms.TextBox()
        Me.texncodigo = New System.Windows.Forms.TextBox()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.texproveedor = New System.Windows.Forms.TextBox()
        Me.Wizard1 = New DevComponents.DotNetBar.Wizard()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.texnombrep = New System.Windows.Forms.TextBox()
        Me.texpreciop = New System.Windows.Forms.TextBox()
        Me.texexistenciasp = New System.Windows.Forms.TextBox()
        Me.texcodigop = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.todouno)
        Me.GroupPanel1.Controls.Add(Me.botremover)
        Me.GroupPanel1.Controls.Add(Me.botagregar)
        Me.GroupPanel1.Controls.Add(Me.DataGridViewX1)
        Me.GroupPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(606, 435)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.Class = ""
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.Class = ""
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.Class = ""
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 2
        Me.GroupPanel1.Text = "Productos a combinar"
        '
        'todouno
        '
        Me.todouno.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.todouno.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.todouno.Location = New System.Drawing.Point(461, 359)
        Me.todouno.Name = "todouno"
        Me.todouno.Size = New System.Drawing.Size(136, 43)
        Me.todouno.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.todouno.TabIndex = 13
        Me.todouno.Text = "Combinar"
        '
        'botremover
        '
        Me.botremover.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.botremover.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botremover.Location = New System.Drawing.Point(3, 359)
        Me.botremover.Name = "botremover"
        Me.botremover.Size = New System.Drawing.Size(105, 43)
        Me.botremover.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.botremover.TabIndex = 11
        Me.botremover.Text = "Remover"
        '
        'botagregar
        '
        Me.botagregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.botagregar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botagregar.Location = New System.Drawing.Point(491, 20)
        Me.botagregar.Name = "botagregar"
        Me.botagregar.Size = New System.Drawing.Size(100, 32)
        Me.botagregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.botagregar.TabIndex = 10
        Me.botagregar.Text = "Agregar"
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.AllowUserToAddRows = False
        Me.DataGridViewX1.AllowUserToDeleteRows = False
        Me.DataGridViewX1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nombre, Me.precio, Me.existencias})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(3, 58)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.ReadOnly = True
        Me.DataGridViewX1.RowHeadersVisible = False
        Me.DataGridViewX1.Size = New System.Drawing.Size(588, 260)
        Me.DataGridViewX1.TabIndex = 9
        '
        'codigo
        '
        Me.codigo.HeaderText = "Codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 75
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 300
        '
        'precio
        '
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        '
        'existencias
        '
        Me.existencias.HeaderText = "Existencias"
        Me.existencias.Name = "existencias"
        Me.existencias.ReadOnly = True
        Me.existencias.Width = 110
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.ButtonX1)
        Me.GroupPanel2.Controls.Add(Me.botaceptar)
        Me.GroupPanel2.Controls.Add(Me.texnunidad)
        Me.GroupPanel2.Controls.Add(Me.texnexistencias)
        Me.GroupPanel2.Controls.Add(Me.texnpreciopublico)
        Me.GroupPanel2.Controls.Add(Me.texnprecio)
        Me.GroupPanel2.Controls.Add(Me.texndescripcion)
        Me.GroupPanel2.Controls.Add(Me.texnnombre)
        Me.GroupPanel2.Controls.Add(Me.texncodigo)
        Me.GroupPanel2.Controls.Add(Me.LabelX9)
        Me.GroupPanel2.Controls.Add(Me.LabelX8)
        Me.GroupPanel2.Controls.Add(Me.LabelX6)
        Me.GroupPanel2.Controls.Add(Me.LabelX5)
        Me.GroupPanel2.Controls.Add(Me.LabelX3)
        Me.GroupPanel2.Controls.Add(Me.LabelX2)
        Me.GroupPanel2.Controls.Add(Me.LabelX1)
        Me.GroupPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(624, 12)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(350, 435)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.Class = ""
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.Class = ""
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.Class = ""
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 3
        Me.GroupPanel2.Text = "Producto combinado"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(3, 362)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(82, 43)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.ButtonX1.TabIndex = 19
        Me.ButtonX1.Text = "Cancelar"
        '
        'botaceptar
        '
        Me.botaceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.botaceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botaceptar.Location = New System.Drawing.Point(226, 362)
        Me.botaceptar.Name = "botaceptar"
        Me.botaceptar.Size = New System.Drawing.Size(85, 43)
        Me.botaceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.botaceptar.TabIndex = 18
        Me.botaceptar.Text = "Aceptar"
        '
        'texnunidad
        '
        Me.texnunidad.Location = New System.Drawing.Point(141, 245)
        Me.texnunidad.Name = "texnunidad"
        Me.texnunidad.Size = New System.Drawing.Size(121, 26)
        Me.texnunidad.TabIndex = 17
        '
        'texnexistencias
        '
        Me.texnexistencias.Location = New System.Drawing.Point(141, 211)
        Me.texnexistencias.Name = "texnexistencias"
        Me.texnexistencias.Size = New System.Drawing.Size(82, 26)
        Me.texnexistencias.TabIndex = 15
        '
        'texnpreciopublico
        '
        Me.texnpreciopublico.Location = New System.Drawing.Point(141, 179)
        Me.texnpreciopublico.Name = "texnpreciopublico"
        Me.texnpreciopublico.Size = New System.Drawing.Size(82, 26)
        Me.texnpreciopublico.TabIndex = 14
        '
        'texnprecio
        '
        Me.texnprecio.Location = New System.Drawing.Point(141, 147)
        Me.texnprecio.Name = "texnprecio"
        Me.texnprecio.Size = New System.Drawing.Size(82, 26)
        Me.texnprecio.TabIndex = 13
        '
        'texndescripcion
        '
        Me.texndescripcion.Location = New System.Drawing.Point(141, 83)
        Me.texndescripcion.Name = "texndescripcion"
        Me.texndescripcion.Size = New System.Drawing.Size(158, 26)
        Me.texndescripcion.TabIndex = 11
        '
        'texnnombre
        '
        Me.texnnombre.Location = New System.Drawing.Point(141, 51)
        Me.texnnombre.Name = "texnnombre"
        Me.texnnombre.Size = New System.Drawing.Size(158, 26)
        Me.texnnombre.TabIndex = 10
        '
        'texncodigo
        '
        Me.texncodigo.Location = New System.Drawing.Point(141, 20)
        Me.texncodigo.Name = "texncodigo"
        Me.texncodigo.Size = New System.Drawing.Size(82, 26)
        Me.texncodigo.TabIndex = 9
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.Class = ""
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(19, 180)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(116, 23)
        Me.LabelX9.TabIndex = 8
        Me.LabelX9.Text = "Precio Publico:"
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.Class = ""
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(4, 247)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(142, 23)
        Me.LabelX8.TabIndex = 7
        Me.LabelX8.Text = "Unidad de medida:"
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(42, 211)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(93, 23)
        Me.LabelX6.TabIndex = 5
        Me.LabelX6.Text = "Existencias:"
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(83, 147)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(62, 23)
        Me.LabelX5.TabIndex = 4
        Me.LabelX5.Text = "Precio:"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(42, 82)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(93, 23)
        Me.LabelX3.TabIndex = 2
        Me.LabelX3.Text = "Descripcion:"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(73, 51)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(62, 23)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "Nombre:"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(73, 23)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(62, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Codigo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(371, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Proveedor"
        '
        'texproveedor
        '
        Me.texproveedor.Enabled = false
        Me.texproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.texproveedor.Location = New System.Drawing.Point(371, 26)
        Me.texproveedor.Name = "texproveedor"
        Me.texproveedor.Size = New System.Drawing.Size(100, 26)
        Me.texproveedor.TabIndex = 8
        '
        'Wizard1
        '
        Me.Wizard1.CancelButtonText = "Cancel"
        Me.Wizard1.FinishButtonTabIndex = 3
        '
        '
        '
        Me.Wizard1.FooterStyle.Class = ""
        Me.Wizard1.FooterStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Wizard1.HeaderCaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        '
        '
        '
        Me.Wizard1.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Wizard1.HeaderStyle.BackColorGradientAngle = 90
        Me.Wizard1.HeaderStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched
        Me.Wizard1.HeaderStyle.BorderBottomWidth = 1
        Me.Wizard1.HeaderStyle.BorderColor = System.Drawing.SystemColors.Control
        Me.Wizard1.HeaderStyle.BorderLeftWidth = 1
        Me.Wizard1.HeaderStyle.BorderRightWidth = 1
        Me.Wizard1.HeaderStyle.BorderTopWidth = 1
        Me.Wizard1.HeaderStyle.Class = ""
        Me.Wizard1.HeaderStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Wizard1.HeaderStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.Wizard1.HeaderStyle.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Wizard1.Location = New System.Drawing.Point(0, 0)
        Me.Wizard1.Name = "Wizard"
        Me.Wizard1.Size = New System.Drawing.Size(548, 375)
        Me.Wizard1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(326, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Existencias"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(115, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre"
        '
        'texnombrep
        '
        Me.texnombrep.Location = New System.Drawing.Point(111, 67)
        Me.texnombrep.Name = "texnombrep"
        Me.texnombrep.Size = New System.Drawing.Size(161, 22)
        Me.texnombrep.TabIndex = 5
        '
        'texpreciop
        '
        Me.texpreciop.Location = New System.Drawing.Point(294, 67)
        Me.texpreciop.Name = "texpreciop"
        Me.texpreciop.Size = New System.Drawing.Size(75, 22)
        Me.texpreciop.TabIndex = 6
        '
        'texexistenciasp
        '
        Me.texexistenciasp.Location = New System.Drawing.Point(377, 67)
        Me.texexistenciasp.Name = "texexistenciasp"
        Me.texexistenciasp.Size = New System.Drawing.Size(75, 22)
        Me.texexistenciasp.TabIndex = 7
        '
        'texcodigop
        '
        Me.texcodigop.Location = New System.Drawing.Point(25, 67)
        Me.texcodigop.Name = "texcodigop"
        Me.texcodigop.Size = New System.Drawing.Size(75, 22)
        Me.texcodigop.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(29, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Codigo"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(297, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Precio"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(377, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "existencias"
        '
        'Combinar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(956, 459)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.texcodigop)
        Me.Controls.Add(Me.texexistenciasp)
        Me.Controls.Add(Me.texpreciop)
        Me.Controls.Add(Me.texnombrep)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Combinar"
        Me.Text = "Combinar productos "
        Me.GroupPanel1.ResumeLayout(false)
        CType(Me.DataGridViewX1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupPanel2.ResumeLayout(false)
        Me.GroupPanel2.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents texnunidad As System.Windows.Forms.TextBox
    Friend WithEvents texnexistencias As System.Windows.Forms.TextBox
    Friend WithEvents texnpreciopublico As System.Windows.Forms.TextBox
    Friend WithEvents texnprecio As System.Windows.Forms.TextBox
    Friend WithEvents texndescripcion As System.Windows.Forms.TextBox
    Friend WithEvents texnnombre As System.Windows.Forms.TextBox
    Friend WithEvents texncodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents texproveedor As System.Windows.Forms.TextBox
    Private WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Private WithEvents botremover As DevComponents.DotNetBar.ButtonX
    Private WithEvents botagregar As DevComponents.DotNetBar.ButtonX
    Private WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Private WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Private WithEvents todouno As DevComponents.DotNetBar.ButtonX
    Private WithEvents botaceptar As DevComponents.DotNetBar.ButtonX
    Private WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Private WithEvents Wizard1 As DevComponents.DotNetBar.Wizard
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents existencias As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents texnombrep As System.Windows.Forms.TextBox
    Friend WithEvents texpreciop As System.Windows.Forms.TextBox
    Friend WithEvents texexistenciasp As System.Windows.Forms.TextBox
    Friend WithEvents texcodigop As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
