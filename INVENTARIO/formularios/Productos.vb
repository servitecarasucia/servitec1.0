Imports logica
Imports System.IO.StreamWriter
Imports System.IO
Public Class Productos
   
    Dim dtrtabla As DataRow
    Dim dtproveedor As DataTable
    Dim dtproveedor1 As DataTable
    Dim tproveedor As New clsMaestros(clsNomTab.eTbl.Proveedores)
    Dim tproductos As New clsMaestros(clsNomTab.eTbl.Productos)
    Dim dtproductosA As DataTable
    Dim dtproductosalfa As DataTable
    Public donde As String
    'datos de ventas
    Public frmv As Ventas
    Public frmc As compra
    Public frmk As Kardex

    Public frmcambio As Combinar
    Private codproveedor As String
    Public f As Boolean = True
    'termina datos ventas

    Dim consulta1 As New clsProcesos



    'para los respaldos
    Dim carpeta As New FolderBrowserDialog
    Dim consultar As New clsProcesos

    'varialble para determinar si ya paso
    Dim ya As Boolean = False

    Private Sub Productos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Me.texbusquedacodigonombre.Focus()
       
    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.botanalizar.Visible = False
        Me.botSeguir.Visible = False

        If Me.Focused Then
            Me.Focus()
        Else
            Me.Focus()
        End If

        Try


            If donde = "ventas" Or donde = "compras" Or donde = "cambio" Or donde = "kardex" Then
                ocultar()
                MdiParent = mdiMain
            Else
                MdiParent = mdiMain
            End If
            cargargrid()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub ocultar()
        Me.botseleccionar.Visible = True
        Me.botdetalle.Visible = False
        Me.boteditar.Visible = False
        Me.botSeguir.Visible = False
        Me.botanalizar.Visible = False
    End Sub
    Public Sub cargargrid()
        Dim dtproductos As New DataTable
        dtproductos = consultar.Consultar(" SELECT a. codproducto as  'Codigo', a.nombre as 'Nombre', a.descripcion as 'Descripcion', b.nombre as 'Categoria',a.unid_med as 'Unidad de medida' , a.precio_unit as 'Precion'  ,a.existencias as 'Existencias',a.precioindi, a.popular, a.frecuente,a.mayoreo  FROM productos a, categoria b  where a.id_categoria=b.id_categoria and a.valida =1 ")
        dtproductosalfa = dtproductos
        dtproductosA = dtproductos


        Try

            Dim nf As Short
            nf = dtproductos.Rows.Count

            If nf = 0 Then
                Me.gridproductos.RowCount = 1
                Me.gridproductos.Rows(0).Cells(0).Value = ""
                Me.gridproductos.Rows(0).Cells(1).Value = ""
                Me.gridproductos.Rows(0).Cells(2).Value = ""
                Me.gridproductos.Rows(0).Cells(3).Value = ""
                Me.gridproductos.Rows(0).Cells(4).Value = ""
                Me.gridproductos.Rows(0).Cells(5).Value = ""
                Me.gridproductos.Rows(0).Cells(5).Value = ""
            Else
                If ya = False Then
                    Me.gridproductos.RowCount = nf
                    dtproductosalfa = dtproductos
                    ya = True
                End If

            End If




            For i As Integer = 0 To dtproductos.Rows.Count - 1

                Me.gridproductos.Rows(i).Cells(0).Value = dtproductos.Rows(i).Item(0).ToString 'para el codigo
                Me.gridproductos.Rows(i).Cells(1).Value = dtproductos.Rows(i).Item(1).ToString 'para el nombre
                Me.gridproductos.Rows(i).Cells(2).Value = dtproductos.Rows(i).Item(2).ToString 'para la descripcion


                Me.gridproductos.Rows(i).Cells(3).Value = dtproductos.Rows(i).Item(3) 'para la categoria

                Me.gridproductos.Rows(i).Cells(4).Value = dtproductos.Rows(i).Item(4).ToString 'para la unidad de medida
                Dim cmb As New DataGridViewComboBoxCell()

                cmb.Items.Add("$ " & dtproductos.Rows(i).Item(8).ToString)
                cmb.Items.Add("$ " & dtproductos.Rows(i).Item(9).ToString)
                cmb.Items.Add("$ " & dtproductos.Rows(i).Item(10).ToString)

                cmb.Style.NullValue = "$ " & dtproductos.Rows(i).Item(8).ToString

                cmb.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox

                Me.gridproductos.Rows(i).Cells(5) = cmb


                ' Me.gridproductos.Rows(i).Cells(5).Value = "$ " & dtproductos.Rows(i).Item(5).ToString 'para el precio
                Me.gridproductos.Rows(i).Cells(6).Value = dtproductos.Rows(i).Item(6).ToString 'para las existencias

                Me.gridproductos.Rows(i).Cells(7).Value = dtproductos.Rows(i).Item(8).ToString 'popular
                Me.gridproductos.Rows(i).Cells(8).Value = dtproductos.Rows(i).Item(9).ToString 'frecuente
                Me.gridproductos.Rows(i).Cells(9).Value = dtproductos.Rows(i).Item(10).ToString 'mayoreo

                

            Next
            Me.texbusquedacodigonombre.Select()
            Me.Focus()
        Catch ex As Exception

        End Try

    End Sub


    Public Sub cargargrid1()
      
        Try

            Dim nf As Short
            nf = dtproductosA.Rows.Count

            If nf = 0 Then
                Me.gridproductos.RowCount = 1
                Me.gridproductos.Rows(0).Cells(0).Value = ""
                Me.gridproductos.Rows(0).Cells(1).Value = ""
                Me.gridproductos.Rows(0).Cells(2).Value = ""
                Me.gridproductos.Rows(0).Cells(3).Value = ""
                Me.gridproductos.Rows(0).Cells(4).Value = ""
                Me.gridproductos.Rows(0).Cells(5).Value = ""
                Me.gridproductos.Rows(0).Cells(5).Value = ""
            Else
                If ya = False Then
                    Me.gridproductos.RowCount = nf
                End If

            End If


      

            For i As Integer = 0 To dtproductosA.Rows.Count - 1

                Me.gridproductos.Rows(i).Cells(0).Value = dtproductosA.Rows(i).Item(0).ToString 'para el codigo
                Me.gridproductos.Rows(i).Cells(1).Value = dtproductosA.Rows(i).Item(1).ToString 'para el nombre
                Me.gridproductos.Rows(i).Cells(2).Value = dtproductosA.Rows(i).Item(2).ToString 'para la descripcion

                Me.gridproductos.Rows(i).Cells(3).Value = dtproductosA.Rows(i).Item(3) 'para la categoria


                Me.gridproductos.Rows(i).Cells(4).Value = dtproductosA.Rows(i).Item(4).ToString 'para la unidad de medida

              

                Dim cmb As New DataGridViewComboBoxCell()

                cmb.Items.Add("$ " & dtproductosA.Rows(i).Item(8).ToString)
                cmb.Items.Add("$ " & dtproductosA.Rows(i).Item(9).ToString)
                cmb.Items.Add("$ " & dtproductosA.Rows(i).Item(10).ToString)


                cmb.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
                cmb.Style.NullValue = "$ " & dtproductosA.Rows(i).Item(8).ToString
                Me.gridproductos.Rows(i).Cells(5) = cmb




                ' Me.gridproductos.Rows(i).Cells(5).Value = "$ " & dtproductosA.Rows(i).Item(5).ToString 'para el precio
                Me.gridproductos.Rows(i).Cells(6).Value = dtproductosA.Rows(i).Item(6).ToString 'para las existencias

                Me.gridproductos.Rows(i).Cells(7).Value = dtproductosA.Rows(i).Item(8).ToString 'popular
                Me.gridproductos.Rows(i).Cells(8).Value = dtproductosA.Rows(i).Item(9).ToString 'frecuente
                Me.gridproductos.Rows(i).Cells(9).Value = dtproductosA.Rows(i).Item(10).ToString 'mayoreo


            Next
        Catch ex As Exception
            'MsgBox("Ocurrio el siguiente error a la hora de llenar el grid: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try

    End Sub

    Private Sub ocultarbot()
        Me.botdetalle.Visible = False
        Me.boteditar.Visible = False
        Me.botseleccionar.Visible = True
    End Sub

 
  


    Private Sub radiotodos_Click(sender As Object, e As EventArgs)
        f = True
        cargargrid()
    End Sub

   

    Dim varbus As String
    'Private Sub texbusquedacodigonombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texbusquedacodigonombre.KeyPress
    '    Try
    '        f = False
    '        If (Asc(e.KeyChar) = 13) Then
    '        Else
    '            If (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then
    '                Dim contvarbus As Short
    '                If varbus = "" Then
    '                    dtproductos = tproductos.Consultar()
    '                    cargargrid()
    '                Else
    '                    contvarbus = varbus.Length
    '                    varbus = varbus.Remove(contvarbus - 1, 1)
    '                End If
    '                If varbus <> "" Then
    '                    dtproductos = tproductos.Consultar(" where (codproducto like '%" + varbus + "%' or nombre like '%" + varbus + "%') and valida = 1 ")

    '                End If

    '                If dtproductos.Rows.Count <> 0 Then
    '                    cargargrid1()
    '                End If

    '            Else
    '                varbus += e.KeyChar

    '                dtproductos = tproductos.Consultar(" where (codproducto like '%" + varbus + "%' or nombre like '%" + varbus + "%') and valida = 1 ")

    '                If dtproductos.Rows.Count <> 0 Then
    '                    cargargrid1()
    '                End If
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox("ocurrio algo")
    '    End Try

    'End Sub

   



    Private Sub botnuevo_Click(sender As Object, e As EventArgs) Handles botnuevo.Click

        Servitec.ProductoNuevo.donde = "productos"
        Servitec.ProductoNuevo.frmp = Me
        Me.Opacity = 0.5
        Servitec.ProductoNuevo.Show()

    End Sub

    Private Sub botdetalle_Click(sender As Object, e As EventArgs) Handles botdetalle.Click
        Try
            Dim id As Short = Me.gridproductos.CurrentCell.RowIndex
            Dim dtrproducto1 As DataRow = dtproductosA.Rows(id)
            DetalleProducto.donde = "productos"
            DetalleProducto.dtrproducto = dtrproducto1

            DetalleProducto.frmp = Me
            DetalleProducto.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub boteditar_Click(sender As Object, e As EventArgs) Handles boteditar.Click
        Try
            Dim id As Short = Me.gridproductos.CurrentCell.RowIndex
            Dim dtrproducto1 As DataRow = dtproductosA.Rows(id)
            ProductoNuevo.dtrprodedit = dtrproducto1
            ProductoNuevo.dtprovedit = dtproveedor
            ProductoNuevo.frmps = Me
            ProductoNuevo.flp = True
            ProductoNuevo.editar = True
            ProductoNuevo.donde = "editar"
            ProductoNuevo.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub botseleccionar_Click_1(sender As Object, e As EventArgs) Handles botseleccionar.Click
        Try
            Dim id As Short = Me.gridproductos.CurrentCell.RowIndex
            Dim dtrproducto1 As DataRow = dtproductosA.Rows(id)
            If donde = "compras" Then
                frmc.drproducto = dtrproducto1
                frmc.idproducto = dtrproducto1.Item(0)
                frmc.texnombrep.Text = dtrproducto1.Item(1)
                frmc.texprecio.Text = dtrproducto1.Item(5)
                frmc.textotalp.SelectAll()
                Me.Close()
            ElseIf donde = "ventas" Then
                frmv.dtrproductos = dtrproducto1
                frmv.texnombrep.Text = dtrproducto1.Item(1)
                frmv.comboprecios.Items.Add(dtrproducto1.Item(8).ToString)
                frmv.comboprecios.Items.Add(dtrproducto1.Item(9).ToString)
                frmv.comboprecios.Items.Add(dtrproducto1.Item(10).ToString)
                frmv.texcantidad.SelectAll()
                frmv.idproducto = dtrproducto1.Item(0)
                Me.Close()
            ElseIf donde = "kardex" Then
                frmk.dtrproductos = dtrproducto1
                frmk.texnombrep.Text = dtrproducto1.Item(1)
                Me.Close()

            Else
                frmcambio.dtrproductos = dtrproducto1
                frmcambio.texcodigop.Text = dtrproducto1.Item(0)
                frmcambio.texnombrep.Text = dtrproducto1.Item(1)
                frmcambio.texpreciop.Text = dtrproducto1.Item(5)
                frmcambio.texexistenciasp.Text = dtrproducto1.Item(6)

                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub botsalir_Click(sender As Object, e As EventArgs) Handles botsalir.Click
        Me.Close()
    End Sub

    Private Sub HolaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HolaToolStripMenuItem.Click
        botdetalle_Click(sender, e)
    End Sub

    Private Sub Hola1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Hola1ToolStripMenuItem.Click
        boteditar_Click(sender, e)
    End Sub

    Private Sub Hola2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Hola2ToolStripMenuItem.Click, botSeguir.Click
        Dim id As Short = Me.gridproductos.CurrentCell.RowIndex
        Dim dtrproducto1 As DataRow = dtproductosA.Rows(id)
        Registroart.dtrproductos = dtrproducto1
        Registroart.Show()
    End Sub

  
    Private Sub botanalizar_Click(sender As Object, e As EventArgs) Handles botanalizar.Click
        AnalizarProducto.Show()
        Me.Close()
    End Sub




    Private Sub hacerrespaldos()
        respaldar.DefaultExt = "sql"
        Dim pathmysql As String
        Dim comando As String
        pathmysql = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\MySQL AB\MYSQL Server 5.1", "Location", 0)
        If pathmysql = Nothing Then
            MsgBox("No se encontro en tu equipo Mysql, escoge la carpeta donde esta ubicado")
            carpeta.ShowDialog()
            pathmysql = carpeta.SelectedPath
        End If
        Dim nombrearchivo As String
        Dim dtrespaldo As DataTable
        Dim trespaldo As New clsMaestros(clsNomTab.eTbl.Respaldo)


        trespaldo.Insertar("'" & System.DateTime.Now & "','Respaldo',' '")
        dtrespaldo = consultar.Consultar("select max(idrespaldo) from respaldos")
        consultar.Consultar("update respaldos set nombrearchivo = 'Respaldo" & dtrespaldo.Rows(0).Item(0).ToString & "' where idrespaldo = " & dtrespaldo.Rows(0).Item(0).ToString)



        nombrearchivo = "Respaldo" & dtrespaldo.Rows(0).Item(0).ToString & ".sql"
        Dim ruta As String = "D:\SISTEMAS DE LA UNIVERSIDAD\AUDITORIA DE SISTEMAS\INVENTARIO DE GASOLINERA CON MONITOREO DE BOMBAS AL FINAL DEL DIA\INVENTARIO\Respaldos\"
        Try
            comando = pathmysql & "\bin\mysqldump --user=root --password=root --databases inventariome -r """ & ruta & nombrearchivo & """"
            Shell(comando, AppWinStyle.MinimizedFocus, True)
        Catch ex As Exception
            MsgBox("Ocurrio un error al respaldar", MsgBoxStyle.Critical, "Informacion")
        End Try

    End Sub

    Private Sub texbusquedacodigonombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texbusquedacodigonombre.KeyPress
        If (Asc(e.KeyChar) = 13) Then
            Me.gridproductos.Focus()
            botseleccionar_Click_1(sender, e)
        End If

        If (Asc(e.KeyChar) = 40) Then
            MsgBox("hola")
            Me.gridproductos.Focus()
            Me.gridproductos.CurrentRow.Cells(1).Selected = True
        End If

    End Sub



    Private Sub texbusquedacodigonombre_TextChanged(sender As Object, e As EventArgs) Handles texbusquedacodigonombre.TextChanged
        Dim dv As DataView = dtproductosalfa.DefaultView
        'dv.RowFilter = "nombre like '" & Me.texbusquedacodigonombre.Text.Trim.ToString & " '"
        dv.RowFilter = "nombre like '%" & Me.texbusquedacodigonombre.Text.Trim.ToString & "%' or codigo like '%" & Me.texbusquedacodigonombre.Text.Trim.ToString & "%'"

        gridproductos.DataSource = dv
        dtproductosA = dv.ToTable


        cargargrid1()
    End Sub

    Private Sub timerfoco_Tick(sender As Object, e As EventArgs) Handles timerfoco.Tick
        Me.Focus()
        Me.texbusquedacodigonombre.Focus()
        Me.timerfoco.Enabled = False
    End Sub

  

    Private Sub gridproductos_DoubleClick(sender As Object, e As EventArgs) Handles gridproductos.DoubleClick
        Try
            If Me.donde = "ventas" Or Me.donde = "compras" Then
                Dim id As Short = Me.gridproductos.CurrentCell.RowIndex
                Dim dtrproducto1 As DataRow = dtproductosA.Rows(id)
                If donde = "compras" Then
                    frmc.drproducto = dtrproducto1
                    frmc.idproducto = dtrproducto1.Item(0)
                    frmc.texnombrep.Text = dtrproducto1.Item(1)
                    frmc.texprecio.Text = dtrproducto1.Item(5)
                    frmc.textotalp.SelectAll()
                    Me.Close()
                ElseIf donde = "ventas" Then
                    frmv.dtrproductos = dtrproducto1
                    frmv.texnombrep.Text = dtrproducto1.Item(1)
                    frmv.comboprecios.Items.Add(dtrproducto1.Item(8).ToString)
                    frmv.comboprecios.Items.Add(dtrproducto1.Item(9).ToString)
                    frmv.comboprecios.Items.Add(dtrproducto1.Item(10).ToString)
                    frmv.texcantidad.SelectAll()
                    frmv.idproducto = dtrproducto1.Item(0)
                    Me.Close()
                ElseIf donde = "kardex" Then
                    frmk.dtrproductos = dtrproducto1
                    frmk.texnombrep.Text = dtrproducto1.Item(1)
                    Me.Close()

                Else
                    frmcambio.dtrproductos = dtrproducto1
                    frmcambio.texcodigop.Text = dtrproducto1.Item(0)
                    frmcambio.texnombrep.Text = dtrproducto1.Item(1)
                    frmcambio.texpreciop.Text = dtrproducto1.Item(5)
                    frmcambio.texexistenciasp.Text = dtrproducto1.Item(6)
                    Me.Close()
                End If
            End If


        Catch ex As Exception

        End Try
    End Sub

End Class