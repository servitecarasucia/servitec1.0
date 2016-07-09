Imports logica

Public Class compra
    Public dtrproveedor As DataRow
    Public drproducto As DataRow
    Private facturacompras As New clsMaestros(clsNomTab.eTbl.FacturaCompra)
    Private dtfacturacompras As DataTable
    Private detallefacturacompra As New clsMaestros(clsNomTab.eTbl.DetalleFacturaC)
    Private dtproducto As DataTable
    Private tproductos As New clsMaestros(clsNomTab.eTbl.Productos)
    Private dtdetallefacturacompra As DataTable
    Private consultar As New clsProcesos


    Private nombretablafacturac As String
    Private nombretabladetallefacturac As String
    Public primeraf As Boolean = True
    Private primeradf As Boolean = True
    Public codfacturac As String = "0"
    Private dtcodfactura As DataTable

    Private nuevo As Boolean = False

    Dim d, m, a, f As String
    Dim d1, m1, a1, f1 As String
    Private pr = False, dr = False, tip = False, frmp = False, numf = False
    Dim vareliminada As Boolean = False


    Private tnumros As New clsMaestros(clsNomTab.eTbl.Numeros)
    Private dtnumerosa As DataTable

    'para ver si ya le dio clik al texbox cliente
    Public ya As Boolean = False

    'precios 
    Private subtotal1 = 0, subtotal2 = 0, subtotal3 = 0, iva = 0, descuentof = 0, totalf As Double
    Private sumas = 0, descuento = 0, iva1 = 0, cotrans = 0, fovial = 0, totalfactu, cantidadproducto, totalproducto, ivauno As Double
    Dim contador1 As Integer = 0
    Private sumas1 = 0, descuento1 = 0, iva2 = 0, cotrans2 = 0, fovial2 = 0, totalfactu2, cantidadproducto2, totalproducto2, ivauno2 As Double
    'hasque aqui precios

    'para el descuento
    Private fldescuento As Boolean = False
    Private dtdescuento As DataTable
    'hasta qui


    Dim contafactura As Short
    'para la modificaciond e la factura
    Public dtproveedores As DataTable
    Public dtproductos As DataTable
    Public dtfacturacompra As DataTable
    Public dtdetallefacturacompram As DataTable
    Public donde As String = "here"
    Public contador As Integer
    Public frmcr As Compras_realizadas
    'Aqui termina los atributos para la modificacion de la factura


    'id para el producto y para los proveedores
    Public idproducto As String
    Public idproveedor As String


    ' Para los proveedores y productos
    Private tproveedores1 As New clsMaestros(clsNomTab.eTbl.Proveedores)
    Private dtproveedores1 As DataTable

    Private tproductos1 As New clsMaestros(clsNomTab.eTbl.Productos)
    Private dtproductos1 As DataTable
    'aqui termina


   
    ' aqui termina

    'para el uno por ciento retencion
    Dim unopc As Double = 0
    Dim guardado As Boolean = False

    'para ver si esta siendo editado o no
    Public estado As String = "nuevo"
    Private guardar As Boolean = False


    'para ver si ya ingreso un articulo
    Public numpr As Short = 0
    Private Sub compra_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If estado = "editando" Then
            If guardar = False Then
                If MsgBox("Desea guardar el documento", MsgBoxStyle.YesNo, "aviso") = MsgBoxResult.Yes Then
                    botguardar_Click_1(sender, e)
                End If
            End If



            mdiMain.teclas = False
        Else
            If numpr > 0 Then
                If Not guardar Then
                    If MsgBox("Desea guardar el documento", MsgBoxStyle.YesNo, "aviso") = MsgBoxResult.Yes Then
                        botguardar_Click_1(sender, e)
                    Else
                        consultar.Consultar(" delete from detallecompra where codfacturac = '" & codfacturac & "'")
                        consultar.Consultar(" delete from facturacompra where codfacturac = " & codfacturac)
                    End If
                End If

            Else
                consultar.Consultar(" delete from detallecompra where codfacturac = '" & codfacturac & "'")
                consultar.Consultar(" delete from facturacompra where codfacturac = " & codfacturac)
            End If
        End If

    End Sub
    Private scape As Boolean = True
    Private Sub compra_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 27 Then

            If scape Then
                Me.botguardar.Focus()
                scape = False
            Else
                Me.texnombrep.Focus()
                scape = True
            End If

        End If

    End Sub

   



    Private Sub compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        MdiParent = mdiMain
        Try

            If donde <> "here" Then
                cargardatos()

            Else

            End If

            cargargrid()
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente razon: " & ex.Message, MsgBoxStyle.OkOnly, "Avise")
        End Try


    End Sub

  
    Private Sub cargardatos()
        Try
            dtfacturacompra = facturacompras.Consultar(" where codfacturac = " & codfacturac)
            dtproveedores = tproveedores1.Consultar(" where codproveedor = " & dtfacturacompra.Rows(0).Item(3))
            Me.idproveedor = dtproveedores.Rows(0).Item(0)
            Me.texproveedor.Text = dtproveedores.Rows(0).Item(1)
            Me.combotipo.Text = dtfacturacompra.Rows(0).Item(2)
            Me.coboformadepago.Text = dtfacturacompra.Rows(0).Item(11)
            Me.texnumfact.Text = dtfacturacompra.Rows(0).Item(1)
            Me.textiraje.Text = dtfacturacompra.Rows(0).Item(14)
            Me.DateTimePicker1.Value = dtfacturacompra.Rows(0).Item(4).ToString

            If Me.dtfacturacompra.Rows(0).Item(12).ToString <> "0" Then
                Me.checuno.Checked = True
            End If

            Me.primeraf = False

            Dim num As Double = CDbl(dtfacturacompra.Rows(0).Item(10))
            convertirnumeroletras(num)
            cargarfactura()


            'Cuando todo ha salido bien hace los cargos a las existencias
            Dim c As Double = 0
            For i As Integer = 0 To dtdetallefacturacompra.Rows.Count - 1
                dtproducto = tproductos.Consultar(" where codproducto = '" + dtdetallefacturacompra.Rows(i).Item(2).ToString + "'")
                c = CDbl(CDbl(dtproducto.Rows(0).Item(6)) - dtdetallefacturacompra.Rows(i).Item(3))
                consultar.Consultar(" update productos set existencias = " + c.ToString + " where codproducto = '" + dtdetallefacturacompra.Rows(i).Item(2).ToString + "'")
            Next

        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub

    Private Sub texproveedor_Click(sender As Object, e As EventArgs) Handles texproveedor.Click
        Try
            Proveedores.donde = "compras"
            Proveedores.frmc = Me
            Proveedores.Show()
            pr = True

        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub


    'Private Sub texnombrep_Click(sender As Object, e As EventArgs) Handles texnombrep.Click
    '    Try
    '        Servitec.Productos.donde = "compras"
    '        Servitec.Productos.frmc = Me
    '        Servitec.Productos.Show()
    '        Me.textotalp.Select()
    '    Catch ex As Exception
    '        MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
    '    End Try

    'End Sub


    Private Function validar() As Boolean
        Return True
    End Function


    Private Sub insertar()
        Try
            If validar() Then

                If primeraf = True Then
                    primeraf = False

                    d = Me.DateTimePicker1.Value.Day
                    m = Me.DateTimePicker1.Value.Month
                    a = Me.DateTimePicker1.Value.Year
                    f = a + "-" + m + "-" + d

                    facturacompras.Insertar("'" & CDbl(0) & "','" & 0 & "','" & 0 & "','" & f & "'," & CDbl(0).ToString & "," & CDbl(0) & "," & CDbl(0).ToString & "," & CDbl(0).ToString & "," & CDbl(0).ToString & "," & CDbl(0).ToString & ",'" & 0 & "',0,'valida','" & 0 & "','" & f & "'")

                    dtcodfactura = consultar.Consultar("SELECT  Max(codfacturac) FROM facturacompra")
                    codfacturac = dtcodfactura.Rows(0).Item(0)
                    insertardetalle()
                Else
                    insertardetalle()
                End If
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error causa: " + ex.Message, MsgBoxStyle.OkOnly, "Avise")
        End Try


    End Sub


    Private Sub privar()
        Try
            Me.texprecio.Text = ""
            Me.texcantidad.Text = ""
            Me.textotalp.Text = ""
            Me.texnombrep.Text = ""
            Me.texproveedor.Enabled = False
            Me.texnumfact.Enabled = False
            Me.combotipo.Enabled = False
            Me.coboformadepago.Enabled = False
            Me.DateTimePicker1.Enabled = False
            Me.textiraje.Enabled = False
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub





    Private Sub insertardetalle()
        Try
            numpr += 1

            Dim prereal As Double
            Dim ventatotal As Double = CDbl(Me.textotalp.Text.ToString)
            Dim totalfactura As Double = 0.0


            detallefacturacompra.Insertar(CInt(Me.codfacturac).ToString & ",'" & idproducto & "'," & CDbl(Me.texcantidad.Text).ToString & ",0," & prereal & ",0," & ventatotal & ", 0 ," & CDbl(Me.texprecio.Text))

            privar()

            cargarfactura()


        Catch ex As Exception
            MsgBox("Ocurrio un error a la hora de insertar el articulo razon: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub
    Dim sumaf, sumac As Double
    Private Sub cargarfactura()
        Try

            cantidadproducto = 0
            totalproducto = 0
            subtotal1 = 0
            fovial = 0
            cotrans = 0
            iva1 = 0
            sumas = 0
            sumac = 0
            sumaf = 0

            Me.texsumas.Text = "0"
            Me.texiva.Text = "0"
            Me.textotal.Text = "0"
            Me.texivauno.Text = "0"



            dtdetallefacturacompra = detallefacturacompra.Consultar(" where codfacturac = '" + codfacturac.ToString + "'")
            Dim nf As Short
            nf = dtdetallefacturacompra.Rows.Count

            If nf = 0 Then
                Me.gridcompra.RowCount = 1
                Me.gridcompra.Rows(0).Cells(0).Value = ""
                Me.gridcompra.Rows(0).Cells(1).Value = ""
                Me.gridcompra.Rows(0).Cells(2).Value = ""
                Me.gridcompra.Rows(0).Cells(3).Value = ""
                Me.gridcompra.Rows(0).Cells(4).Value = ""
                Me.gridcompra.Rows(0).Cells(5).Value = ""
                Me.gridcompra.Rows(0).Cells(6).Value = ""


            Else
                Me.gridcompra.RowCount = nf
            End If

            For i As Integer = 0 To dtdetallefacturacompra.Rows.Count - 1

                If Me.combotipo.Text.ToString <> "Factura" And Me.combotipo.Text.ToString <> "Gastos" Then
                    dtproducto = tproductos.Consultar(" where codproducto = '" + dtdetallefacturacompra.Rows(i).Item(2).ToString & "'")

                    sumas += Math.Round(CDbl(dtdetallefacturacompra.Rows(i).Item(7)), 2)

                    Me.gridcompra.Rows(i).Cells(0).Value = dtdetallefacturacompra.Rows(i).Item(2)
                    Me.gridcompra.Rows(i).Cells(1).Value = dtdetallefacturacompra.Rows(i).Item(3)
                    Me.gridcompra.Rows(i).Cells(2).Value = dtproducto.Rows(0).Item(1)
                    Me.gridcompra.Rows(i).Cells(3).Value = dtdetallefacturacompra.Rows(i).Item(9)
                    Me.gridcompra.Rows(i).Cells(4).Value = "0"
                    Me.gridcompra.Rows(i).Cells(5).Value = "0"
                    Me.gridcompra.Rows(i).Cells(6).Value = dtdetallefacturacompra.Rows(i).Item(7)


                Else
                    dtproducto = tproductos.Consultar(" where codproducto = '" + dtdetallefacturacompra.Rows(i).Item(2).ToString & "'")

                    sumas += Math.Round(CDbl(dtdetallefacturacompra.Rows(i).Item(7)), 2)

                    Me.gridcompra.Rows(i).Cells(0).Value = dtdetallefacturacompra.Rows(i).Item(2)
                    Me.gridcompra.Rows(i).Cells(1).Value = dtdetallefacturacompra.Rows(i).Item(3)
                    Me.gridcompra.Rows(i).Cells(2).Value = dtproducto.Rows(0).Item(1)
                    Me.gridcompra.Rows(i).Cells(3).Value = dtdetallefacturacompra.Rows(i).Item(9)
                    Me.gridcompra.Rows(i).Cells(4).Value = "0"
                    Me.gridcompra.Rows(i).Cells(5).Value = "0"
                    Me.gridcompra.Rows(i).Cells(6).Value = dtdetallefacturacompra.Rows(i).Item(7)


                End If



            Next


            Me.texsumas.Text = CDbl(sumas)
            Dim uno As Double = 0
            If Me.combotipo.Text.ToString <> "Factura" And Me.combotipo.Text.ToString <> "Gastos" Then
                iva = Math.Round((sumas * 0.13), 2)

                Me.texiva.Text = iva

                If checuno.Checked Then
                    uno = Math.Round((sumas * 0.01), 2)
                    Me.textotal.Text = CDbl(sumas + iva + uno)
                    Me.texivauno.Text = uno
                Else
                    Me.textotal.Text = CDbl(sumas + iva)
                End If


            Else
                Me.textotal.Text = CDbl(sumas)

            End If

        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub

    Private Sub texcantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles texcantidad.KeyDown
        If e.KeyCode = 37 Then
            Me.texnombrep.Focus()
        End If
        If e.KeyCode = 39 Then
            Me.textotalp.Focus()
        End If
    End Sub

    Private Sub textotalp_KeyDown(sender As Object, e As KeyEventArgs) Handles textotalp.KeyDown
        If e.KeyCode = 37 Then
            Me.texcantidad.Focus()
        End If
    End Sub




    Private Sub texcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texcantidad.KeyPress, texprecio.KeyPress, textotalp.KeyPress, texnumfact.KeyPress
        e.Handled = onlynumero(e)
        If (Asc(e.KeyChar)) = 13 Then
            botagregar_Click_1(sender, e)
        End If
    End Sub
    Public Function onlynumero(ByVal caracter As System.Windows.Forms.KeyPressEventArgs)

        If (Asc(caracter.KeyChar)) >= 48 And (Asc(caracter.KeyChar)) <= 57 Or _
          (Asc(caracter.KeyChar)) = System.Windows.Forms.Keys.Back Or (Asc(caracter.KeyChar)) = 46 Then
            Return False
        Else
            Return True
        End If
    End Function



    Private Function combotipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles combotipo.KeyPress

        Return False

    End Function



    Private Sub combotipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combotipo.SelectedIndexChanged
        tip = True
    End Sub

   



    Private Sub texnumfact_TextChanged(sender As Object, e As EventArgs) Handles texnumfact.TextChanged
        numf = True
    End Sub


    Private Function correcto() As Boolean
        Dim fl As Boolean = True

        If texproveedor.Text = "" Then
            Me.texproveedor.BackColor = Color.Red
            fl = False
        Else
            Me.texproveedor.BackColor = Color.White
        End If

        If Me.texnumfact.Text = "" Then
            Me.texnumfact.BackColor = Color.Red
            fl = False
        Else
            Me.texnumfact.BackColor = Color.White
        End If

        If Me.combotipo.Text = "" Then
            Me.combotipo.BackColor = Color.Red
            fl = False
        Else
            Me.combotipo.BackColor = Color.White
        End If

        If Me.coboformadepago.Text = "" Then
            Me.coboformadepago.BackColor = Color.Red
            fl = False
        Else
            Me.coboformadepago.BackColor = Color.White
        End If

        If Me.textiraje.Text = "" Then
            Me.textiraje.BackColor = Color.Red
            fl = False
        Else
            Me.textiraje.BackColor = Color.White
        End If

        If Me.texnombrep.Text = "" Then
            Me.texnombrep.BackColor = Color.Red
            fl = False
        Else
            Me.texnombrep.BackColor = Color.White
        End If

        If Me.texcantidad.Text = "" Then
            Me.texcantidad.BackColor = Color.Red
            fl = False
        Else
            Me.texcantidad.BackColor = Color.White
        End If

        If Me.texprecio.Text = "" Then
            Me.texprecio.BackColor = Color.Red
            fl = False
        Else
            Me.texprecio.BackColor = Color.White
        End If

        If Me.textotalp.Text = "" Then
            Me.textotalp.BackColor = Color.Red
            fl = False
        Else
            Me.textotalp.BackColor = Color.White
        End If

        Return fl
    End Function

    Private Sub botagregar_Click_1(sender As Object, e As EventArgs) Handles botagregar.Click
        If correcto() <> False Then

            Try
                If primeraf = False Then
                    Dim can As Double
                    Dim tl As Double
                    Dim f As Boolean = False

                    For i As Integer = 0 To dtdetallefacturacompra.Rows.Count - 1
                        If idproducto.ToString = dtdetallefacturacompra.Rows(i).Item(2).ToString Then

                            can = Math.Round(CDbl(dtdetallefacturacompra.Rows(i).Item(3) + CDbl(Me.texcantidad.Text)), 2)
                            tl = Math.Round(CDbl(dtdetallefacturacompra.Rows(i).Item(7)) + CDbl(Me.textotalp.Text.Trim), 2)


                            consultar.Consultar("update detallecompra set total = " & tl & ", cantidadunit = " & can.ToString & " where codfacturac = " & codfacturac.ToString & " and coddetallefacturac = " & dtdetallefacturacompra.Rows(i).Item(0).ToString)

                            f = True
                            cargarfactura()
                        End If
                    Next
                    If f = False Then
                        insertar()
                    End If
                Else
                    insertar()
                End If

                Dim num As Double = CDbl(Me.textotal.Text)
                convertirnumeroletras(num)




            Catch ex As Exception
                MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
            End Try
        Else
            MsgBox("Tiene que llenar los datos que estan en rojo", MsgBoxStyle.ApplicationModal, "Aviso")
        End If

    End Sub

    Private Sub convertirnumeroletras(ByVal numero As Double)
        Dim numletras1 As New NumeroLetras
        Dim nl As String
        numletras1.setnumero(numero)
        nl = numletras1.getnumero().ToString & " dolares "

        If numletras1.getdecimal() > 0 Then
            Dim nn As String
            If numletras1.getdecimal() < 11 Then
                nn = numletras1.getdecimal() & "0"

                nl = nl & "con " & nn & "/100 cent"
            Else
                nl = nl & "con " & numletras1.getdecimal.ToString & "/100 cent"
            End If

        Else
            nl = nl
        End If

        Me.lson.Text = nl

    End Sub

    Private Sub botguardar_Click_1(sender As Object, e As EventArgs) Handles botguardar.Click
        Try
            guardar = True
            Dim ella As String = ""
            If guardado = False Then
                guardado = True
                If combotipo.Text = "Factura" Then
                    ella = "La "
                Else
                    ella = "El "
                End If

                Me.totalfactu = Me.textotal.Text


                d = Me.DateTimePicker1.Value.Day
                m = Me.DateTimePicker1.Value.Month
                a = Me.DateTimePicker1.Value.Year
                f = a + "-" + m + "-" + d

                d1 = Me.DateTimePicker2.Value.Day
                m1 = Me.DateTimePicker2.Value.Month
                a1 = Me.DateTimePicker2.Value.Year
                f1 = a1 + "-" + m1 + "-" + d1

                'facturacompras.Insertar("'" & Me.texnumfact.Text.ToString.Trim & "','" & Me.combotipo.Text.ToString & "','" & idproveedor & "','" & f & "'," & CDbl(0).ToString & "," & CDbl(0) & "," & CDbl(0).ToString & "," & CDbl(0).ToString & "," & CDbl(0).ToString & "," & CDbl(0).ToString & ",'" & Me.coboformadepago.Text.ToString & "',0,'valida','" & Me.textiraje.Text.ToString & "'")


                If Me.checuno.Checked Then
                    consultar.Consultar(" update facturacompra set numfacturac = '" & Me.texnumfact.Text.ToString.Trim & "', tipo = '" & Me.combotipo.Text.ToString & "', codproveedor = '" & idproveedor & "', fecha = '" & f & "', formadepago = '" & Me.coboformadepago.Text.ToString & "', tiraje = '" & Me.textiraje.Text.ToString & "', " & "sumas = " & Me.texsumas.Text.Trim.ToString & ", iva = " & Me.texiva.Text.Trim.ToString & ", total = " & Me.textotal.Text.Trim.ToString & ", unoretencion = " & Me.texivauno.Text.Trim.ToString & ",fechalimite = '" & f1 & "' where codfacturac = " & codfacturac)
                Else
                    consultar.Consultar(" update facturacompra set numfacturac = '" & Me.texnumfact.Text.ToString.Trim & "', tipo = '" & Me.combotipo.Text.ToString & "', codproveedor = '" & idproveedor & "', fecha = '" & f & "', formadepago = '" & Me.coboformadepago.Text.ToString & "', tiraje = '" & Me.textiraje.Text.ToString & "', " & " sumas = " & Me.texsumas.Text.Trim.ToString & ", iva = " & Me.texiva.Text.Trim.ToString & ", total = " & Me.textotal.Text.Trim.ToString & ",  unoretencion = 0, fechalimite = '" & f1 & "'  where codfacturac = " & codfacturac)
                End If

                'Cuando todo ha salido bien hace los cargos a las existencias
                Dim c As Double = 0
                For i As Integer = 0 To dtdetallefacturacompra.Rows.Count - 1
                    dtproducto = tproductos.Consultar(" where codproducto = '" + dtdetallefacturacompra.Rows(i).Item(2).ToString + "'")
                    c = CDbl(dtdetallefacturacompra.Rows(i).Item(3) + CDbl(dtproducto.Rows(0).Item(6)))
                    consultar.Consultar(" update productos set existencias = " + c.ToString + " where codproducto = '" + dtdetallefacturacompra.Rows(i).Item(2).ToString + "'")
                Next



                If MsgBox(ella & combotipo.Text.ToString & " Se ingreso exitosamente" & vbCrLf _
                          & " Desea agregar otra compra?", MsgBoxStyle.YesNo, "Compra") = MsgBoxResult.Yes Then
                    mdiMain.llama = "compra"
                    Me.Close()
                    mdiMain.timllamar.Enabled = True
                Else
                    Me.Close()
                End If



            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error al ingresar la factura razon: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try


    End Sub


    Private Sub botsalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Dim cantidad, preciot, totalp As Double


    Private Sub textotalp_KeyUp(sender As Object, e As KeyEventArgs) Handles textotalp.KeyUp
        Try
            If checklibre.Checked <> True Then
                If Me.textotalp.Text = "" Or Me.texcantidad.Text = "" Then
                    Me.texprecio.Text = ""
                Else

                    Me.cantidad = CDbl(Me.texcantidad.Text)
                    Me.totalp = CDbl(Me.textotalp.Text)


                    Me.texprecio.Text = Math.Round(Me.totalp / Me.cantidad, 4)

                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub texcantidad_KeyUp(sender As Object, e As KeyEventArgs) Handles texcantidad.KeyUp, texprecio.KeyUp
        Try
            If checklibre.Checked <> True Then
                If Me.textotalp.Text = "" Or Me.texcantidad.Text = "" Then
                    Me.texprecio.Text = ""
                Else

                    Me.cantidad = CDbl(Me.texcantidad.Text)
                    Me.totalp = CDbl(Me.textotalp.Text)


                    Me.texprecio.Text = Math.Round((totalp) / Me.cantidad, 2)

                End If
            End If

        Catch ex As Exception

        End Try

    End Sub


    'Private Sub texnombrep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texnombrep.KeyPress
    '    e.Handled = onlynumero(e)
    '    If (Asc(e.KeyChar)) = 13 Then
    '        texnombrep_Click(sender, e)
    '    End If
    'End Sub






    Private Sub Button7_Click(sender As Object, e As EventArgs)

        Me.texprecio.Text = Me.dtproductos1.Rows(3).Item(3)
        Me.texprecio.Select()
    End Sub

    Private Sub boteliminar_Click(sender As Object, e As EventArgs) Handles boteliminar.Click
        Try
            Dim id As Short = Me.gridcompra.CurrentCell.RowIndex
            Dim dtrdetalle As DataRow = dtdetallefacturacompra.Rows(id)

            If MsgBox("Esta seguro de quitar el producto de la factura? ", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                consultar.Consultar("delete from detallecompra where coddetallefacturac = " & dtrdetalle.Item(0))
                numpr -= 1
                cargarfactura()
            End If

        Catch ex As Exception

        End Try
    End Sub

  
    Dim fl As Boolean = False
    Private Sub textiraje_LostFocus(sender As Object, e As EventArgs) Handles textiraje.LostFocus
        Try
            If Not fl Then

                Dim dtfc As DataTable

                If Me.textiraje.Text = Nothing Or Me.texnumfact.Text = Nothing Then

                Else
                    fl = True
                    dtfc = consultar.Consultar("SELECT * FROM `facturacompra` where tiraje = '" & Me.textiraje.Text.Trim & "' and numfacturac = ' " & Me.texnumfact.Text.Trim & "'")
                    If dtfc.Rows.Count <> 0 Then
                        MsgBox("Esta compra ya esta ingresada", MsgBoxStyle.Information, "AVISO")
                    End If
                End If

            End If
        Catch ex As Exception

        End Try
       
    End Sub


















   


    Private Sub textiraje_TextChanged(sender As Object, e As EventArgs) Handles textiraje.TextChanged


    End Sub

    Private Sub gridproductos_DoubleClick(sender As Object, e As EventArgs) Handles gridproductos.DoubleClick
        Dim id As Short = Me.gridproductos.CurrentCell.RowIndex
        Dim dtrproducto1 As DataRow = dtproductosA.Rows(id)
        ProductoNuevo.dtrprodedit = dtrproducto1
        ProductoNuevo.dtprovedit = dtproveedor

        ProductoNuevo.flp = True
        ProductoNuevo.editar = True
        ProductoNuevo.donde = "editar"
        ProductoNuevo.Show()
    End Sub

    Private Sub gridproductos_KeyDown(sender As Object, e As KeyEventArgs) Handles gridproductos.KeyDown
        If e.KeyCode = 13 Then

            Dim id As Short = Me.gridproductos.CurrentCell.RowIndex
            Dim dtrproducto1 As DataRow = dtproductosA.Rows(id)


            'Me.dtrproductos = dtrproducto1
            'Me.texnombrep.Text = dtrproducto1.Item(1)
            'Me.comboprecios.Items.Clear()
            'Me.comboprecios.Text = dtrproducto1.Item(8).ToString
            'Me.comboprecios.Items.Add(dtrproducto1.Item(8).ToString)
            'Me.comboprecios.Items.Add(dtrproducto1.Item(9).ToString)
            'Me.comboprecios.Items.Add(dtrproducto1.Item(10).ToString)
            Me.textotalp.Focus()
            Me.idproducto = dtrproducto1.Item(0)

            Me.texnombrep.Text = dtrproducto1.Item(1)

            Me.gridproductos.Visible = False
            Me.texcantidad.Text = ""

        End If
    End Sub


    Dim dtproveedor As DataTable
    Dim dtproveedor1 As DataTable
    Dim tproveedor As New clsMaestros(clsNomTab.eTbl.Proveedores)
    Dim dtproductosA As DataTable
    Dim dtproductosalfa As DataTable

    Private Sub texnombrep_GotFocus(sender As Object, e As EventArgs) Handles texnombrep.GotFocus
        If nuevo Then
            cargargrid()
            nuevo = False
        End If
        Me.gridproductos.Visible = True
    End Sub

    Private Sub texnombrep_KeyDown(sender As Object, e As KeyEventArgs) Handles texnombrep.KeyDown
        If e.KeyCode = 40 Then
            Me.gridproductos.Focus()
            Me.gridproductos.CurrentRow.Cells(1).Selected = True
        End If

        If e.KeyCode = 39 Then
            Me.texcantidad.Focus()
        End If


        If e.KeyCode = 27 Then
            Me.gridproductos.Visible = False
            Me.texnombrep.Text = ""
            Me.texcantidad.Text = ""

            Me.botguardar.Focus()
        End If

        If e.KeyCode = 38 Then
            Me.texproveedor.Focus()
        End If

        If e.KeyCode = 13 Then
            Try
                Me.gridproductos.Visible = False

                Me.idproducto = Me.texnombrep.Text

                Dim dtprd As DataTable
                Dim tprd As New clsMaestros(clsNomTab.eTbl.Productos)
                dtprd = tprd.Consultar(" where codproducto = '" & idproducto & "'")
                Me.texnombrep.Text = dtprd.Rows(0).Item(1).ToString
                Me.texcantidad.Focus()
             


            Catch ex As Exception

            End Try
        End If
    End Sub



    Private Sub texnombrep_TextChanged(sender As Object, e As EventArgs) Handles texnombrep.TextChanged
        Dim dv As DataView = dtproductosalfa.DefaultView
        'dv.RowFilter = "nombre like '" & Me.texbusquedacodigonombre.Text.Trim.ToString & " '"
        dv.RowFilter = "nombre like '%" & Me.texnombrep.Text.Trim.ToString & "%' or codigo like '%" & Me.texnombrep.Text.Trim.ToString & "%'"

        gridproductos.DataSource = dv
        dtproductosA = dv.ToTable


        cargargrid1()
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


                Me.gridproductos.Rows(i).Cells(4).Value = dtproductosA.Rows(i).Item(11).ToString 'para la unidad de medida
                Dim cmb As New DataGridViewComboBoxCell()

                cmb.Items.Add("$ " & dtproductosA.Rows(i).Item(8).ToString)
                cmb.Items.Add("$ " & dtproductosA.Rows(i).Item(9).ToString)
                cmb.Items.Add("$ " & dtproductosA.Rows(i).Item(10).ToString)


                cmb.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
                cmb.Style.NullValue = "$ " & dtproductosA.Rows(i).Item(8).ToString
                Me.gridproductos.Rows(i).Cells(5) = cmb
                Me.gridproductos.Rows(i).Cells(6).Value = dtproductosA.Rows(i).Item(6).ToString 'para las existencias


            Next
        Catch ex As Exception
            'MsgBox("Ocurrio el siguiente error a la hora de llenar el grid: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try

    End Sub

    Public Sub cargargrid()
        Dim dtproductos As New DataTable
        dtproductos = consultar.Consultar(" SELECT a.codproducto as  'Codigo', a.nombre as 'Nombre', a.descripcion as 'Descripcion', b.nombre as 'Categoria',a.unid_med as 'Unidad de medida' , a.precio_unit as 'Precion'  ,a.existencias as 'Existencias',a.precioindi, a.popular, a.frecuente,a.mayoreo, a.precio_unit  FROM productos a, categoria b  where a.id_categoria=b.id_categoria and a.valida =1 ")
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


                Me.gridproductos.Rows(i).Cells(3).Value = dtproductos.Rows(i).Item(4) 'para la categoria

                Me.gridproductos.Rows(i).Cells(4).Value = dtproductos.Rows(i).Item(11).ToString 'para la unidad de medida

                Dim cmb As New DataGridViewComboBoxCell()

                cmb.Items.Add("$ " & dtproductosA.Rows(i).Item(8).ToString)
                cmb.Items.Add("$ " & dtproductosA.Rows(i).Item(9).ToString)
                cmb.Items.Add("$ " & dtproductosA.Rows(i).Item(10).ToString)


                cmb.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
                cmb.Style.NullValue = "$ " & dtproductosA.Rows(i).Item(8).ToString
                Me.gridproductos.Rows(i).Cells(5) = cmb

                Me.gridproductos.Rows(i).Cells(6).Value = dtproductos.Rows(i).Item(6).ToString 'para las existencias

                Me.gridproductos.Rows(i).Cells(7).Value = dtproductos.Rows(i).Item(7).ToString 'Precio popular
                Me.gridproductos.Rows(i).Cells(8).Value = dtproductos.Rows(i).Item(8).ToString 'precio frecuente
                Me.gridproductos.Rows(i).Cells(9).Value = dtproductos.Rows(i).Item(9).ToString 'Precio de mayoreo
            Next
            Me.texnombrep.Select()
            Me.Focus()
        Catch ex As Exception

        End Try

    End Sub

   
    Private Sub gridproductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridproductos.CellContentClick
       
    End Sub

    Private Sub texcantidad_TextChanged(sender As Object, e As EventArgs) Handles texcantidad.TextChanged

    End Sub

    Private Sub textotalp_TextChanged(sender As Object, e As EventArgs) Handles textotalp.TextChanged

    End Sub
End Class


