﻿
Imports logica
Public Class ProductoNuevo

    Public donde As String
    Private dtproducto As DataTable
    Public dtrcate As DataRow
    Public dtrprove As DataRow
    Private dtrtabla As DataRow
    Private productos As New clsProcesos
    Private tproductos As New clsMaestros(clsNomTab.eTbl.Productos)
    Private consultar As New clsProcesos

    Public editar As Boolean = False
    'desde aqui son de detalle
    Public dtrprodedit As DataRow
    Public dtcateedit As DataTable
    Public dtprovedit As DataTable
    Public frmdt As DetalleProducto
    Public frmps As Productos
    'hasta aqui son de detalle
    Public flagc As Boolean = False
    Dim flagp As Boolean = False
    Public flp As Boolean = False
    Private llenos As Boolean = True
    'nueva actualizacion
    Private provedores, categorian As String
    Private dtproveedores, dtcategoria As DataTable
    Dim idcategoria As String
    Dim codpreovee As String
    Public frmp As Productos

    Public idcatergoria As String

    Private dtdescuentos As DataTable




    Private Sub Productos1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MdiParent = mdiMain
            If donde = "productos" Then
                Me.texcantidad.Enabled = False
            End If

            If donde = "detalleproductos" Or flp = True Then
                Me.texcantidad.Enabled = False
                cargardatos()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cargardatos()
        Try
            Me.texcodigo.Text = dtrprodedit.Item(0)
            Me.texnombre.Text = dtrprodedit.Item(1)
            Me.texdescripcion.Text = dtrprodedit.Item(2)
            Me.texpreciounitario.Text = dtrprodedit.Item(5)
            Me.texprecioindi.Text = dtrprodedit.Item(7)
            Me.texcantidad.Text = dtrprodedit.Item(6)
            Me.tex40.Text = dtrprodedit.Item(8)
            Me.tex30.Text = dtrprodedit.Item(9)
            Me.tex20.Text = dtrprodedit.Item(10)

            If flp = True Then
                dtcategoria = consultar.Consultar(" Select id_categoria,nombre from categoria where nombre = '" & dtrprodedit.Item(3).ToString & "'")
                Me.texcategoria.Text = dtcategoria.Rows(0).Item(1).ToString
                idcategoria = dtcategoria.Rows(0).Item(0)

            Else
                Me.texcategoria.Text = dtrprodedit.Item(3)

            End If


            Me.texunidaddemedida.Text = dtrprodedit.Item(4)
            Me.editar = True
        Catch ex As Exception

        End Try

    End Sub



    Private Sub botguardar_Click(sender As Object, e As EventArgs) Handles botguardar.Click
        Try
            If Me.picno.Visible <> True Or editar = True Then

                If donde = "productos" And flp = False Then
                    insertarproducto()
                    If llenos Then

                        frmp.cargargrid()
                        frmp.f = True
                        frmp.Opacity = 1
                        Me.Close()
                    End If

                End If
                If flp = True Then
                    insertarproducto()
                    If llenos Then
                        frmps.cargargrid()
                        Me.Close()
                    End If

                End If
                If donde = "detalleproductos" Then
                    insertarproducto()
                End If
                llenos = True
            Else
                MsgBox("El codigo no se puede repetir para los productos", MsgBoxStyle.AbortRetryIgnore, "Aviso")
            End If
        Catch ex As Exception
            'MsgBox("Ocurrio un error al ingresar el articulo razon: " & ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub
    Private Sub insertarproducto()
        If vacio() Then
            If Me.picno.Visible = True Then
                MsgBox("El codigo del producto ya existe ", MsgBoxStyle.OkOnly, "Aviso")
            Else
                MsgBox("Tiene que llenar todos los campos obligatorios", MsgBoxStyle.OkOnly, "Aviso")
            End If

        Else
            Try
                Dim idprod As String = Me.texcodigo.Text.ToString.Trim
                Dim nombre As String = Me.texnombre.Text.ToString.Trim
                Dim descripcion As String = Me.texdescripcion.Text.ToString.Trim

                Dim p40 As Decimal = CDec(Me.tex40.Text)
                Dim p30 As Decimal = CDec(Me.tex30.Text)
                Dim p20 As Decimal = CDec(Me.tex20.Text)


                Dim preciounit As String
                Dim preciopublic As String
                Dim existencias As String

                If Me.texpreciounitario.Text.Trim = "" Then
                    preciounit = 0
                Else
                    preciounit = Me.texpreciounitario.Text.ToString.Trim
                End If

                If Me.texprecioindi.Text.Trim = "" Then
                    preciopublic = 0
                Else
                    preciopublic = Me.texprecioindi.Text.ToString.Trim
                End If


                If Me.texcantidad.Text.ToString.Trim = "" Then
                    existencias = "0"
                Else
                    existencias = Me.texcantidad.Text.ToString.Trim
                End If



                If flagc = True Then
                    idcategoria = dtrcate.Item(0).ToString
                Else

                    If donde <> "productos" Then
                        dtcategoria = consultar.Consultar(" Select id_categoria,nombre from categoria where nombre = '" & dtrprodedit.Item(3).ToString & "'")
                        idcategoria = dtcategoria.Rows(0).Item(0).ToString
                    Else
                        Me.lbcamposobligatorios.ForeColor = Color.Red
                        Me.lcat.ForeColor = Color.Red
                        llenos = False
                    End If

                End If



                Dim unidmede As String = texunidaddemedida.Text.ToString.Trim

                nombre = UCase(Mid(nombre, 1, 1)) + Mid(nombre, 2, Len(nombre))

                unidmede = UCase(Mid(unidmede, 1, 1)) + Mid(unidmede, 2, Len(unidmede))

                If editar = False Then

                    If llenos <> False Then
                        tproductos.Insertar("'" & idprod + "','" & nombre & "','" & descripcion & "'," & preciounit & "," & preciopublic & ",0," & existencias & "," & idcategoria & ",'" & unidmede & "',1," & p40 & "," & p30 & "," & p20)
                        MsgBox("El producto se ingreso exitozamente", MsgBoxStyle.Information, "Exito")
                    Else
                        MsgBox("Tienes que llenar los campos indicados ", MsgBoxStyle.Critical, "Aviso")
                    End If
                Else
                    tproductos.Actualizar("'" & dtrprodedit.Item(0) & "'|'" & nombre.ToString & "'|'" & descripcion.ToString & "'|" & CDbl(preciounit.ToString) & "|" & CDbl(preciopublic.ToString) & "|0|" & CDbl(existencias.ToString) & "|" & idcategoria.ToString & "|'" & unidmede.ToString & "'|1|" & p40 & "|" & p30 & "|" & p20)

                    MsgBox("El producto se actualizo exitozamente", MsgBoxStyle.Information, "Exito")
                    If flp = False Then
                        dtproducto = tproductos.Consultar(" where codproducto = '" & dtrprodedit.Item(0) & "'")
                        frmdt.dtrproducto = dtproducto.Rows(0)
                        frmdt.modi = True
                        frmdt.cargardatos()
                        Me.Close()
                    End If

                End If

            Catch ex As Exception
                MsgBox("Ocurrio un error al momento de insertar el producto razon: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
            End Try

        End If

    End Sub

    Private Function vacio() As Boolean

        If Me.texcodigo.Text.Trim = "" Then
            Me.lbcamposobligatorios.ForeColor = Color.Red
            Me.lcodigo.ForeColor = Color.Red
            llenos = False
        Else
            Me.lcodigo.ForeColor = Color.Black
        End If

        If Me.texcategoria.Text.Trim = "" Then
            Me.lbcamposobligatorios.ForeColor = Color.Red
            Me.lcat.ForeColor = Color.Red
            llenos = False
        Else
            Me.lcat.ForeColor = Color.Black
        End If



        If Me.texdescripcion.Text.Trim = "" Then
            Me.lbcamposobligatorios.ForeColor = Color.Red
            Me.ldescripcion.ForeColor = Color.Red
            llenos = False
        Else
            Me.ldescripcion.ForeColor = Color.Black
        End If

        If Me.texunidaddemedida.Text.Trim = "" Then
            Me.lbcamposobligatorios.ForeColor = Color.Red
            Me.lunitmed.ForeColor = Color.Red
            llenos = False
        Else
            Me.lunitmed.ForeColor = Color.Black
        End If

        If Me.texnombre.Text.Trim = "" Then
            Me.lbcamposobligatorios.ForeColor = Color.Red
            Me.lnombre.ForeColor = Color.Red
            llenos = False
        Else
            Me.lnombre.ForeColor = Color.Black
        End If

        If llenos Then
            Me.lbcamposobligatorios.ForeColor = Color.Black
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub botborrar_Click(sender As Object, e As EventArgs) Handles botborrar.Click
        borrar()
    End Sub

    Private Sub borrar()
        Me.texcategoria.Text = ""
        Me.texnombre.Text = ""
        Me.texdescripcion.Text = ""
        Me.texcantidad.Text = ""
        Me.texcodigo.Text = ""

        Me.texprecioindi.Text = ""
        Me.texpreciounitario.Text = ""
        Me.texunidaddemedida.Text = ""
    End Sub
    Private Sub texcategoria_Click(sender As Object, e As EventArgs) Handles texcategoria.Click


        Categoria.donde = "producto"
        Categoria.frmprod = Me
        Categoria.Show()
    End Sub

 


    Private Sub botsalir_Click(sender As Object, e As EventArgs) Handles botsalir.Click
        Me.Close()
    End Sub

    Private Sub texcodigo_KeyUp(sender As Object, e As KeyEventArgs) Handles texcodigo.KeyUp
        Dim dtp As DataTable = Nothing
        Dim ttp As New clsMaestros(clsNomTab.eTbl.Productos)
        dtp = ttp.Consultar(" where codproducto = '" & Me.texcodigo.Text.Trim.ToString & "'")
        If dtp.Rows.Count > 0 Then
            Me.picno.Visible = True
            Me.picsi.Visible = False
        Else
            Me.picno.Visible = False
            Me.picsi.Visible = True
        End If
    End Sub




    Private Sub texunidaddemedida_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texunidaddemedida.KeyPress
        If (Asc(e.KeyChar)) = 13 Then
            botguardar_Click(sender, e)
        End If
    End Sub

    Private Sub texpreciounitario_KeyUp(sender As Object, e As KeyEventArgs) Handles texpreciounitario.KeyUp
        Try
            If Me.texpreciounitario.Text <> Nothing Then
                Dim precio As Decimal = CDec(Me.texpreciounitario.Text)

                Me.tex40.Text = Math.Round((precio * 1.13) * 1.4, 2)
                Me.tex30.Text = Math.Round((precio * 1.13) * 1.3, 2)
                Me.tex20.Text = Math.Round((precio * 1.13) * 1.2, 2)

                Me.texprecioindi.Text = precio
            End If

        Catch ex As Exception

        End Try
    End Sub

   
    Private Sub texpreciounitario_TextChanged(sender As Object, e As EventArgs) Handles texpreciounitario.TextChanged

    End Sub
End Class