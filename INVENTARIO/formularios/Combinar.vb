Imports logica
Imports validaciones
Public Class Combinar
    Public dtrproductos As DataRow
    Private proveedor As New clsMaestros(clsNomTab.eTbl.Proveedores)
    Private categoria As New clsMaestros(clsNomTab.eTbl.Categorias)
    Private productos As New clsMaestros(clsNomTab.eTbl.Productos)

    Private dtproveedor As DataTable
    Private dtcategoria As DataTable
    Private dtproductos As DataTable
    Public dtrproveedor As DataRow
    Public dtrcate As DataRow
    Public dtfacturasc As DataTable
    Public dtarticulosc As DataTable
    Private consulta As New clsProcesos
    Private id As Short
    Public idcategoria As String
    Public idproveedor As String
    'contador de filas 
    Private contador As Short = 0
 


    Private Sub Combinar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = mdiMain
    End Sub

    
    Private Function mismo()
        Dim fl As Boolean = False
        Dim i As Short = 0
        While i < contador And fl <> True
            If Me.DataGridViewX1.Rows(i).Cells(0).Value = dtrproductos.Item(0) Then
                fl = True
            Else
                fl = False
            End If
            i += 1
        End While


        Return fl
    End Function
    Private Sub botagregar_Click(sender As Object, e As EventArgs) Handles botagregar.Click
        If Me.texnombrep.Text <> "" And mismo() <> True Then

            contador += 1
            Me.DataGridViewX1.RowCount = contador

            Me.DataGridViewX1.Rows(contador - 1).Cells(0).Value = dtrproductos.Item(0)
            Me.DataGridViewX1.Rows(contador - 1).Cells(1).Value = dtrproductos.Item(1)
            Me.DataGridViewX1.Rows(contador - 1).Cells(2).Value = dtrproductos.Item(5)
            Me.DataGridViewX1.Rows(contador - 1).Cells(3).Value = dtrproductos.Item(6)
            Me.texnombrep.Text = ""
            Me.texpreciop.Text = ""
            Me.texcodigop.Text = ""
            Me.texexistenciasp.Text = ""
        End If
    End Sub

    Private Sub botremover_Click(sender As Object, e As EventArgs) Handles botremover.Click
        Dim id As Short = DataGridViewX1.CurrentCell.RowIndex

        For i As Integer = id To contador - 1
            If i < contador - 1 Then
                Me.DataGridViewX1.Rows(i).Cells(0).Value = Me.DataGridViewX1.Rows(i + 1).Cells(0).Value
                Me.DataGridViewX1.Rows(i).Cells(1).Value = Me.DataGridViewX1.Rows(i + 1).Cells(1).Value
                Me.DataGridViewX1.Rows(i).Cells(2).Value = Me.DataGridViewX1.Rows(i + 1).Cells(2).Value
                Me.DataGridViewX1.Rows(i).Cells(3).Value = Me.DataGridViewX1.Rows(i + 1).Cells(3).Value
            Else
                Me.DataGridViewX1.Rows(i).Cells(0).Value = ""
                Me.DataGridViewX1.Rows(i).Cells(1).Value = ""
                Me.DataGridViewX1.Rows(i).Cells(2).Value = ""
                Me.DataGridViewX1.Rows(i).Cells(3).Value = ""
            End If

        Next

        Me.DataGridViewX1.RowCount = contador - 1
        contador -= 1
    End Sub

    Private Sub bocombinar_Click(sender As Object, e As EventArgs)
        generarnuevo()

    End Sub

    Private Sub generarnuevo()

    End Sub
    Private Sub todossobreuno()
        id = Me.DataGridViewX1.CurrentCell.RowIndex
        Dim existencias As Short = 0
        For i As Integer = 0 To contador - 1
            existencias += CShort(Me.DataGridViewX1.Rows(i).Cells(3).Value)
        Next

        dtproductos = productos.Consultar(" where codproducto = '" & Me.DataGridViewX1.Rows(id).Cells(0).Value.ToString & "'")

        Me.texncodigo.Text = dtproductos.Rows(0).Item(0)
        Me.texnnombre.Text = dtproductos.Rows(0).Item(1)
        Me.texndescripcion.Text = dtproductos.Rows(0).Item(2)


        Me.texnprecio.Text = dtproductos.Rows(0).Item(3)
        Me.texnpreciopublico.Text = dtproductos.Rows(0).Item(5)
        Me.texnexistencias.Text = existencias.ToString
        'dtcategoria = categoria.Consultar(" where id_categoria = " & dtproductos.Rows(0).Item(8))
        'idcategoria = dtproductos.Rows(0).Item(8).ToString
        Me.texnunidad.Text = dtproductos.Rows(0).Item(8)
    End Sub
    Private Sub todouno_Click(sender As Object, e As EventArgs) Handles todouno.Click
        If contador > 1 Then
            todossobreuno()
        End If
    End Sub

    Private Sub texnproveedor_Click(sender As Object, e As EventArgs)
        Servitec.Proveedores.donde = "cambio"
        Servitec.Proveedores.frmcambio = Me
        Servitec.Proveedores.Show()
    End Sub

    Private Sub texncategoria_Click(sender As Object, e As EventArgs)
        Servitec.Categoria.donde = "cambio"
        Servitec.Categoria.frmcambio = Me
        Servitec.Categoria.Show()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        limpiar()
    End Sub

    Private Sub limpiar()
        Me.texncodigo.Text = ""
        Me.texnnombre.Text = ""
        Me.texndescripcion.Text = ""
        Me.texnprecio.Text = ""
        Me.texnpreciopublico.Text = ""
        Me.texnexistencias.Text = ""
        Me.texnunidad.Text = ""

    End Sub

    Private Sub botaceptar_Click(sender As Object, e As EventArgs) Handles botaceptar.Click
        If vacio() Then
            MsgBox("No se puede realizar la operacion todos los campos tiene que estar llenos", MsgBoxStyle.Critical, "__..::Aviso::..__")
        Else
            If MsgBox("Esta seguro de combinar los productos, los cambios seran irreversibles", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                unir("facturacompra", "detallecompra", "codfacturac")
                unir("facturaventa", "detalleventa", "codfacturav")
                combinar()
                MsgBox("El producto fue cambiado exitozamente", MsgBoxStyle.Information, "EXITO")
            End If
        End If
    End Sub
    Private Sub combinar()
        Dim c As Short = contador - 1
        consulta.Consultar("update productos set codproducto = '" & texncodigo.Text.Trim & "', nombre = '" & texnnombre.Text.Trim & "',descripcion = '" & texndescripcion.Text.Trim & "',precio_unit = " & CDbl(texnprecio.Text.Trim).ToString & ",precioindi = 0,preciopublico = " & CDbl(texnpreciopublico.Text.Trim).ToString & ", existencias = " & CDbl(Me.texnexistencias.Text.Trim).ToString & ",unid_med = '" & Me.texnunidad.Text.Trim.ToString & "' where codproducto = '" & Me.texncodigo.Text.Trim & "'")
        For i As Integer = 0 To c
            If Me.DataGridViewX1.Rows(i).Cells(0).Value <> Me.DataGridViewX1.Rows(id).Cells(0).Value Then
                consulta.Consultar("delete from productos where  codproducto = '" & Me.DataGridViewX1.Rows(i).Cells(0).Value.ToString & "'")
            End If
        Next
    End Sub























    Private Sub unir(facturacompra As String, detallecompra As String, codfacturac As String)

        Try
            Dim cadena As String = ""
            Dim c As Short = contador - 1

            For i As Integer = 0 To c
                If i = c Then
                    cadena += "codproducto = '" & DataGridViewX1.Rows(i).Cells(0).Value.ToString & "' "
                Else
                    cadena += "codproducto = '" & DataGridViewX1.Rows(i).Cells(0).Value.ToString & "' or "
                End If
            Next

            dtarticulosc = consulta.Consultar("select * from " & detallecompra & " where " & cadena)

            For i As Integer = 0 To dtarticulosc.Rows.Count - 1


                consulta.Consultar("UPDATE " & detallecompra & " SET codproducto = " & Me.texncodigo.Text.ToString & " where codproducto = " & dtarticulosc.Rows(i).Item(2))


            Next
        Catch ex As Exception

        End Try


    End Sub





















    Private Function vacio()
        Dim fl As Boolean = False
        If Me.texncodigo.Text = "" Then
            fl = True
        End If
        If Me.texnnombre.Text = "" Then
            fl = True
        End If
        If Me.texndescripcion.Text = "" Then
            fl = True
        End If
        If Me.texnprecio.Text = "" Then
            fl = True
        End If

        If Me.texnpreciopublico.Text = "" Then
            fl = True
        End If

        If Me.texnexistencias.Text = "" Then
            fl = True
        End If

        If Me.texnunidad.Text = "" Then
            fl = True
        End If

        Return fl
    End Function



    Private Sub texnombrep_Click(sender As Object, e As EventArgs) Handles texnombrep.Click
        Servitec.Productos.donde = "cambio"
        Servitec.Productos.frmcambio = Me
        Servitec.Productos.Show()
    End Sub

  
End Class