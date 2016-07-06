Imports logica

Public Class DetalleProducto
    Public donde As String
    Public dtrproducto As DataRow
    Public nombretabla As String
    Private consulta As New clsProcesos
    Public frmp As Productos
    Public modi As Boolean = False
    Private Sub DetalleProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = mdiMain
        cargardatos()
    End Sub

    Public Sub cargardatos()
        Try
            If modi = True Then
                frmp.cargargrid()
            End If

            Me.texcodigo.Text = Me.dtrproducto.Item(0).ToString 'para el codigo

            Me.texnombre.Text = Me.dtrproducto.Item(1).ToString 'para el nombre

            Me.texdescripcion.Text = Me.dtrproducto.Item(2).ToString    'para la descripcion

            Me.texpreciounit.Text = Me.dtrproducto.Item(5).ToString 'para precio unitario

            Me.texprecioindi.Text = Me.dtrproducto.Item(7).ToString 'para el precio individual

            Me.texexistencias.Text = Me.dtrproducto.Item(6).ToString    'para las existencias

            Me.tex40.Text = dtrproducto.Item(8) ' para el precio popular

            Me.tex30.Text = dtrproducto.Item(9) '  para el precio frecuente

            Me.tex20.Text = dtrproducto.Item(10) ' para el precio de mayoreo



            Me.texcategoria.Text = Me.dtrproducto.Item(3).ToString
           
            Me.texunidmed.Text = Me.dtrproducto.Item(4).ToString
        Catch ex As Exception
            MsgBox("Ocurrio un error al cargar los datos rezon: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles botsalir.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles boteditar.Click
        ProductoNuevo.dtrprodedit = dtrproducto
        ProductoNuevo.frmdt = Me
        ProductoNuevo.donde = "detalleproductos"
        ProductoNuevo.Show()
    End Sub

    Private Sub boteliminar_Click(sender As Object, e As EventArgs) Handles boteliminar.Click
        If MsgBox("Seguro que quiere eliminar " & dtrproducto.Item(1).ToString, MsgBoxStyle.YesNo, "___....:::: AVISO :::...___") = MsgBoxResult.Yes Then
            consulta.Consultar("update productos set valida = 0 where codproducto = '" & dtrproducto.Item(0).ToString & "'")
            MsgBox("El Producto " & dtrproducto.Item(1).ToString & " se elimino exitozamente: ", MsgBoxStyle.Information, "Exito")
            Me.Close()
        End If
    End Sub
End Class