Imports logica
Imports Servitec
Imports validaciones
Imports System.Drawing.Printing

Public Class Ventas
    Public dtrclientes As DataRow
    Public dtrproductos As DataRow
    Private tventas As New clsMaestros(clsNomTab.eTbl.FacturaVenta)
    Private dtventas As DataTable
    Private tdetalleventa As New clsMaestros(clsNomTab.eTbl.DetalleFacturaV)
    Private dtproducto As DataTable
    Private tproductos As New clsMaestros(clsNomTab.eTbl.Productos)

    Private dtdetalleventa As DataTable

    Public primeraf As Boolean = True
    Public primera As Boolean = True

    Private dtcodfactura As DataTable
    Private codfactura As Integer = 0
    Private consultar As New clsProcesos
    Private clsvalidar As validar

    Public dtdecuento As DataTable

    'para ver si el cliente se cargo
    Private yasellenoelcliente As Boolean = False

    'para la modificacionde la factura
    Public dtclientes As DataTable
    Public dtproductos As DataTable
    Public dtfacturaventas As DataTable
    Public dtdetallefacturaventas As DataTable
    Public donde As String = "here"
    Public contador As Integer
    Public frmdv As DetalleVenta
    Public frmvr As VentasRealizadas
    'Aqui termina los atributos para la modificacion de la factura
    Private llenara As Boolean = False

    'id para el producto y para los proveedores
    Public idproducto As String
    Public idcliente As String = "0"

    'para la variable de agregar
    Dim agregarv As Boolean = False


    ' Para los proveedores y productos
    Private tclientes1 As New clsMaestros(clsNomTab.eTbl.Clientes)
    Private dtclientes11 As DataTable

    Private tproductos1 As New clsMaestros(clsNomTab.eTbl.Productos)
    Private dtproductos1 As DataTable
    'aqui termina



    Dim guardado As Boolean = False

    Dim contafactura As Short

    Dim tclientesfinales As New clsMaestros(clsNomTab.eTbl.clientescf)

    'LAS VARIABLES PARA CARGAR LOS DETALLES FACTURA'
    Dim sumas As Double
    Dim iva As Double
    Dim ventatotal As Double

    'VARIABLE PARA LOS FURMULCIOS (INSTANCIA A ELLOS)'
    Dim frmp As New Productos
    Dim frmc As New Clientes

    Dim tipo As Boolean = True

    Public estado As String = "insertando"
    Public guardar As Boolean = False


    'Variable para el limite de ventas
    Public numproductos As Short = 0

    'para ver si hay productos
    Public numpr As Short = 0

    'para ver si ya le dio clik al texbox cliente
    Public ya As Boolean = False

    'Este es el datatable alfa para seleccionar
    Private dtclisalfa As DataTable


    Private Sub Ventas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If donde = "Cotizar" Then
            Dim tfv As New clsMaestros(clsNomTab.eTbl.FacturaVenta)
            Dim dtfv As New clsMaestros(clsNomTab.eTbl.DetalleFacturaV)
            Dim elimd As New clsProcesos

            tfv.Eliminar(codfactura)
            elimd.Ejecutar(" delete from detalleventa where codfacturav = " & codfactura)

        Else
            If estado = "editando" Then
                If guardar = False Then
                    If MsgBox("Desea guardar el documento", MsgBoxStyle.YesNo, "aviso") = MsgBoxResult.Yes Then
                        botguardar_Click(sender, e)
                    End If
                End If

                mdiMain.teclas = False

            Else
                If numpr > 0 Then
                    If Not guardado Then
                        If MsgBox("Desea guardar el documento", MsgBoxStyle.YesNo, "aviso") = MsgBoxResult.Yes Then
                            botguardar_Click(sender, e)
                        Else
                            consultar.Consultar(" delete from detalleventa where codfacturav = '" & codfactura & "'")
                            consultar.Consultar(" delete from facturaventa where codfacturav = " & codfactura)
                        End If
                    End If

                Else
                    consultar.Consultar(" delete from detalleventa where codfacturav = '" & codfactura & "'")
                    consultar.Consultar(" delete from facturaventa where codfacturav = " & codfactura)
                End If
            End If

        End If





    End Sub

    Private scape As Boolean = True
    Private Sub Ventas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        MdiParent = mdiMain



        combotipo_SelectedIndexChanged(sender, e)
        Try

            If mdiMain.super Then
                Me.botguardar.Text = "Imprimir y Guardar"
            Else
                Me.botguardar.Text = "Guardar"
            End If
            If Me.donde <> "here" Then
                cargardatos()
            End If
            cargargrid()
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente razon: " & ex.Message, MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub

    Private Sub cargarcp()
        dtclientes11 = tclientes1.Consultar()
        dtproductos1 = tproductos1.Consultar()

        Dim nfp1 As Short = dtclientes11.Rows.Count
        Dim nfp2 As Short = dtproductos1.Rows.Count

    End Sub

    Private Sub cargardatos()
        Try
            If donde = "Cotizar" Then
                idcliente = 1

                Me.texcliente.Visible = False
                Me.combotipo.Visible = False
                Me.comboformapago.Visible = False
                Me.texnumfact.Visible = False
                Me.textiraje.Visible = False
                Me.DateTimePicker1.Visible = False

                Me.lcliente.Visible = False
                Me.ltipo.Visible = False
                Me.ltiraje.Visible = False
                Me.lfecha.Visible = False
                Me.lforma.Visible = False
                Me.lnum.Visible = False

                Me.botguardar.Text = "Imprimir"

            Else
                dtfacturaventas = tventas.Consultar(" where codfacturav = " & codfactura)
                dtclientes = tclientes1.Consultar(" where codcliente = " & dtfacturaventas.Rows(0).Item(3))
                Me.idcliente = dtclientes.Rows(0).Item(0)
                Me.texcliente.Text = dtclientes.Rows(0).Item(1)
                Me.combotipo.Text = dtfacturaventas.Rows(0).Item(2)
                Me.comboformapago.Text = dtfacturaventas.Rows(0).Item(11)
                Me.texnumfact.Text = dtfacturaventas.Rows(0).Item(1)
                Me.textiraje.Text = dtfacturaventas.Rows(0).Item(14)
                Me.DateTimePicker1.Value = dtfacturaventas.Rows(0).Item(4).ToString

                Me.primeraf = False

                Dim num As Double = CDbl(dtfacturaventas.Rows(0).Item(10))
                convertiraletras(num)
                cargarfactura()

                'Cuando todo ha salido bien hace los cargos a las existencias
                Dim c As Double = 0
                For i As Integer = 0 To dtdetallefacturaventas.Rows.Count - 1
                    dtproducto = tproductos.Consultar(" where codproducto = '" + dtdetallefacturaventas.Rows(i).Item(2).ToString + "'")
                    c = CDbl(CDbl(dtproducto.Rows(0).Item(6)) - dtdetallefacturaventas.Rows(i).Item(3))
                    consultar.Consultar(" update productos set existencias = " + c.ToString + " where codproducto = '" + dtdetallefacturaventas.Rows(i).Item(2).ToString + "'")
                Next
            End If


        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub




    Private Sub texnombrep_Click(sender As Object, e As EventArgs)
        Try
            Servitec.Productos.donde = "ventas"
            Servitec.Productos.frmv = Me
            Servitec.Productos.Show()
            Me.textotalp.Select()
        Catch ex As Exception

        End Try

    End Sub


    Private Function validar() As Boolean
        Return True
    End Function


    Private Sub insertar()
        If validar() Then

            If primeraf = True Then
                primeraf = False
                Dim d, m, a, f As String
                d = Me.DateTimePicker1.Value.Day
                m = Me.DateTimePicker1.Value.Month
                a = Me.DateTimePicker1.Value.Year
                f = a + "-" + m + "-" + d

                If Me.combotipo.Text = "Factura" Then
                    If llenara = False Then




                        'Codigo para el tiraje'
                        Dim tcodf As New clsProcesos

                        If Me.combotipo.Text.Trim.ToString = "Factura" Then
                            tcodf.Consultar("update tirajes set tirajefa = '" & Me.texnumfact.Text.Trim.ToString & "'")
                        Else
                            tcodf.Consultar("update tirajes set tirajeca = '" & Me.texnumfact.Text.Trim.ToString & "'")
                        End If


                    End If
                Else

                    'Codigo para el tiraje'
                    Dim tcodf As New clsProcesos

                    If Me.combotipo.Text.Trim.ToString = "Factura" Then
                        tcodf.Consultar("update tirajes set tirajefa = '" & Me.texnumfact.Text.Trim.ToString & "'")
                    Else
                        tcodf.Consultar("update tirajes set tirajeca = '" & Me.texnumfact.Text.Trim.ToString & "'")
                    End If


                End If

                'tventas.Insertar("'" & Me.texnumfact.Text.ToString.Trim & "','" & Me.combotipo.Text.ToString & "','" & idcliente & "','" & f & "'," & CDbl(0).ToString & "," & CDbl(0) & "," & CDbl(0).ToString & "," & CDbl(0).ToString & "," & CDbl(0).ToString & "," & CDbl(0).ToString & ",'" & Me.comboformapago.Text.ToString & "','valida','" & Me.textiraje.Text.ToString & "'")
                tventas.Insertar("'" & 0 & "','" & 0 & "','" & 0 & "','" & f & "'," & CDbl(0).ToString & "," & CDbl(0) & "," & CDbl(0).ToString & "," & CDbl(0).ToString & "," & CDbl(0).ToString & "," & CDbl(0).ToString & ",'" & 0 & "','valida','" & 0 & "','" & f & "',0")
                dtcodfactura = consultar.Consultar("SELECT  Max(codfacturav) FROM facturaventa")
                codfactura = dtcodfactura.Rows(0).Item(0)
                insertardetalle()
            Else
                insertardetalle()
            End If
        End If

    End Sub


    Private Sub privar()
        Try
            Me.comboprecios.Items.Clear()
            Me.texcantidad.Text = ""
            Me.textotalp.Text = ""
            Me.texnombrep.Text = ""
            Me.texcliente.Enabled = False
            Me.texnumfact.Enabled = False
            Me.combotipo.Enabled = False
            Me.comboformapago.Enabled = False
            Me.DateTimePicker1.Enabled = False
        Catch ex As Exception

        End Try

    End Sub



    Private Sub insertardetalle()
        Try

            numpr += 1
            Dim prereal As Double
            Dim ventatotal As Double = CDbl(Me.textotalp.Text.ToString)

            If combotipo.Text.ToString <> "Factura" Then


                ventatotal = Math.Round((ventatotal / 1.13), 2)

            End If

            tdetalleventa.Insertar(CInt(Me.codfactura).ToString & ",'" & idproducto & "'," & Math.Round(CDbl(Me.texcantidad.Text), 2).ToString & ",0," & prereal & ",0," & Math.Round(ventatotal, 2) & ", 0 ," & Math.Round(CDbl(Me.comboprecios.Text), 2))
            ' privar()

            cargarfactura()

            'Ocultamos el grid
            Me.gridproductos.Visible = False
        Catch ex As Exception
            MsgBox("Ocurrio un error a la hora de insertar el articulo razon: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub cargarfactura()
        numproductos = 0
        Try
            sumas = 0.0
            iva = 0.0
            ventatotal = 0.0

            Me.texsumas.Text = "0"
            Me.texiva.Text = "0"
            Me.textotal.Text = ""



            dtdetalleventa = tdetalleventa.Consultar(" where codfacturav = '" + codfactura.ToString + "'")
            Dim nf As Short
            nf = dtdetalleventa.Rows.Count



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

            For i As Integer = 0 To dtdetalleventa.Rows.Count - 1
                numproductos += 1
                If Me.combotipo.Text <> "Factura" Then
                    dtproducto = tproductos.Consultar(" where codproducto = '" + dtdetalleventa.Rows(i).Item(2).ToString & "'")

                    sumas += Math.Round(CDbl(dtdetalleventa.Rows(i).Item(7)), 2)

                    Me.gridcompra.Rows(i).Cells(0).Value = dtdetalleventa.Rows(i).Item(2)
                    Me.gridcompra.Rows(i).Cells(1).Value = dtdetalleventa.Rows(i).Item(3)
                    Me.gridcompra.Rows(i).Cells(2).Value = dtproducto.Rows(0).Item(1)
                    Me.gridcompra.Rows(i).Cells(3).Value = dtdetalleventa.Rows(i).Item(9)
                    Me.gridcompra.Rows(i).Cells(4).Value = "0"
                    Me.gridcompra.Rows(i).Cells(5).Value = "0"
                    Me.gridcompra.Rows(i).Cells(6).Value = dtdetalleventa.Rows(i).Item(7)


                Else
                    dtproducto = tproductos.Consultar(" where codproducto = '" + dtdetalleventa.Rows(i).Item(2).ToString & "'")

                    sumas += Math.Round(CDbl(dtdetalleventa.Rows(i).Item(7)), 2)

                    Me.gridcompra.Rows(i).Cells(0).Value = dtdetalleventa.Rows(i).Item(2)
                    Me.gridcompra.Rows(i).Cells(1).Value = dtdetalleventa.Rows(i).Item(3)
                    Me.gridcompra.Rows(i).Cells(2).Value = dtproducto.Rows(0).Item(1)
                    Me.gridcompra.Rows(i).Cells(3).Value = dtdetalleventa.Rows(i).Item(9)
                    Me.gridcompra.Rows(i).Cells(4).Value = "0"
                    Me.gridcompra.Rows(i).Cells(5).Value = "0"
                    Me.gridcompra.Rows(i).Cells(6).Value = FormatNumber(dtdetalleventa.Rows(i).Item(7), 2)


                End If



            Next

            Me.texsumas.Text = FormatNumber(sumas, 2)
            Dim numero As String = ""
            Dim conn As Short = 0
            Dim punto As Boolean = False
            Dim dpunto As String = ""
            Dim nuevonumero As String = ""
            If Me.combotipo.Text.ToString <> "Factura" Then
                iva = Math.Round((sumas * 0.13), 2)

                Me.texiva.Text = FormatNumber(Math.Round(iva, 2), 2)

                Me.textotal.Text = FormatNumber(CDec(Math.Round(CDbl(sumas + iva), 2)), 2)


            Else
                Me.textotal.Text = FormatNumber(CDbl(sumas), 2)


            End If

            Dim num As Double = Math.Round(CDbl(Me.textotal.Text.ToString), 2)
            convertiraletras(num)



            If Me.combotipo.Text.Trim.ToString = "Factura" Then
                If numproductos >= 23 Then
                    If MsgBox("Se ha alcanzado el limite de productos por factura desea guardar?", MsgBoxStyle.YesNo, "LIMITE") = MsgBoxResult.Yes Then
                        guardardocumento()
                    End If


                End If
            Else

                If numproductos >= 21 Then
                    If MsgBox("Se ha alcanzado el limite de productos por CCF desea guardar?", MsgBoxStyle.YesNo, "LIMITE") = MsgBoxResult.Yes Then
                        guardardocumento()
                    End If

                End If

            End If


        Catch ex As Exception
            MsgBox("Ocurrio un error al momento de llenar registrar el articulo en la factura razon: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try

    End Sub



    Private Sub texnombrep_Click1(sender As Object, e As EventArgs) Handles texnombrep.Click, texnombrep.GotFocus
        '  pjtAdus.Productos.donde = "ventas"
        ' pjtAdus.Productos.frmv = Me
        'pjtAdus.Productos.Show()


        ' Me.texcantidad.Select()
        'pjtAdus.Productos.Focus()
        If nuevo Then
            cargargrid()
            nuevo = False
        End If
        Me.gridproductos.Visible = True
    End Sub


    Dim cantidad, preciot As Double

    Private Sub textotalp_KeyDown(sender As Object, e As KeyEventArgs) Handles textotalp.KeyDown
        If e.KeyCode = 37 Then
            Me.texnombrep.Focus()
        End If

        If e.KeyCode = 39 Then
            Me.gridproductos.Visible = False
            Me.texcantidad.Text = ""
        End If

        If e.KeyCode = 13 Then
            Try
                Me.gridproductos.Visible = False

                Me.texnombrep.Text = Me.textotalp.Text
                Me.idproducto = Me.texnombrep.Text


                Dim dtprd As DataTable
                Dim tprd As New clsMaestros(clsNomTab.eTbl.Productos)
                dtprd = tprd.Consultar(" where codproducto = '" & idproducto & "'")
                Me.texnombrep.Text = dtprd.Rows(0).Item(1).ToString
                Me.texcantidad.Text = 1
                Me.comboprecios.Text = dtprd.Rows(0).Item(10).ToString
                Me.textotalp.Text = dtprd.Rows(0).Item(10).ToString
                botagregar_Click(sender, e)

            Catch ex As Exception

            End Try
        End If
    End Sub


    Private Sub texcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texcantidad.KeyPress, textotalp.KeyPress, texnumfact.KeyPress
        Try
            e.Handled = onlynumero(e)
            e.Handled = onlynumero(e)
            If (Asc(e.KeyChar)) = 13 Then
                If Me.texcantidad.Text <> Nothing Then
                    botagregar_Click(sender, e)
                End If

            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Function onlynumero(ByVal caracter As System.Windows.Forms.KeyPressEventArgs)

        If (Asc(caracter.KeyChar)) >= 48 And (Asc(caracter.KeyChar)) <= 57 Or _
          (Asc(caracter.KeyChar)) = System.Windows.Forms.Keys.Back Or (Asc(caracter.KeyChar)) = 46 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub texcantidad_KeyUp(sender As Object, e As KeyEventArgs) Handles texcantidad.KeyUp
        Try
            If checklibre.Checked <> True Then
                If Me.comboprecios.Text = "" Or Me.texcantidad.Text = "" Then
                Else
                    Me.cantidad = FormatNumber(CDec(Me.texcantidad.Text), 2)

                    Me.preciot = FormatNumber(CDec(Me.comboprecios.Text), 2)
                    Me.textotalp.Text = FormatNumber(CDec(cantidad * preciot), 2)

                End If
            End If
        Catch ex As Exception
            MsgBox("Ingrese datos en los campos para realizar los calculos", MsgBoxStyle.Critical, "Aviso")
        End Try

    End Sub

    Private Sub botappdescuento_Click(sender As Object, e As EventArgs) Handles botappdescuento.Click
        If primeraf = True Then
            MsgBox("Teene que igresar almenos un articulo para aplicar descuentos", MsgBoxStyle.OkOnly, "Aviso")
        Else
            Me.grubdescuento.Visible = True
        End If
    End Sub




    Private Sub combotipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combotipo.SelectedIndexChanged
        Try
            Dim dtcodf As DataTable
            Dim tcodf As New clsProcesos
            Dim tt As New clsProcesos
            Dim dttt As DataTable
            Dim n As String = ""
            Dim n1 As Integer = 0


            If Me.combotipo.Text.Trim.ToString = "Factura" Then
                dtcodf = tcodf.Consultar("select max(tirajefa) from tirajes")
                dttt = tt.Consultar("select tirajefs from tirajes")
                Me.textiraje.Text = dttt.Rows(0).Item(0).ToString
                Me.texcliente.Text = "Consumidor Final"
            Else
                dtcodf = tcodf.Consultar("select max(tirajeca) from tirajes")
                dttt = tt.Consultar("select tirajecs from tirajes")
                Me.textiraje.Text = dttt.Rows(0).Item(0).ToString

                Me.texcliente.Text = ""
            End If


            If dtcodf.Rows(0).Item(0).ToString = "" Then
                Me.texnumfact.Text = "1"
            Else
                Me.texnumfact.Text = CInt(dtcodf.Rows(0).Item(0)).ToString
            End If

        Catch ex As Exception

        End Try

    End Sub









    Private Sub imprimir()
        imprimirfactura()


        Me.Timerimprimir.Enabled = True
    End Sub





    Private Sub imprimirfactura()
        ' ejemplo simple para imprimir en .NET
        ' Usamos una clase del tipo PrintDocument
        Dim printDoc As New PrintDocument
        'Dim TamañoPersonal As New Printing.PaperSize("Prueba", 650, 425)
        Dim TamañoPersonal As New Printing.PaperSize("Prueba", 650, 800)


        printDoc.DefaultPageSettings.PaperSize = TamañoPersonal
        ' asignamos el método de evento para cada página a imprimir
        AddHandler printDoc.PrintPage, AddressOf print_PrintPage
        ' indicamos que queremos imprimir

        printDoc.Print()
    End Sub

    Private Sub print_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)

        Dim dtfacturaventa As DataTable
        Dim tfacturaventa As New clsMaestros(clsNomTab.eTbl.FacturaVenta)

        Dim dtdetallefacturaventa As DataTable
        Dim tdetallefacturaventa As New clsMaestros(clsNomTab.eTbl.DetalleFacturaV)

        Dim dtcliente As DataTable
        Dim tcliente As New clsMaestros(clsNomTab.eTbl.clientescf)
        Dim tclientec As New clsMaestros(clsNomTab.eTbl.Clientes)

        Dim dtproducto As DataTable
        Dim tproducto As New clsMaestros(clsNomTab.eTbl.Productos)
        Dim fl As Boolean = True


        dtfacturaventa = tfacturaventa.Consultar(" where codfacturav = " & Me.codfactura)
        dtdetallefacturaventa = tdetallefacturaventa.Consultar(" where codfacturav = " & Me.codfactura)
        Try

            dtcliente = tcliente.Consultar(" where idclientescf = " & dtfacturaventa.Rows(0).Item(3))
            Dim nc As String = dtcliente.Rows(0).Item(1)
        Catch ex As Exception
            dtcliente = tclientec.Consultar(" where codcliente = " & dtfacturaventa.Rows(0).Item(3))
            Dim nc As String = dtcliente.Rows(0).Item(1)
            fl = False
        End Try




        ' Este evento se producirá cada vez que se imprima una nueva página
        ' imprimir HOLA MUNDO en Arial tamaño 24 y negrita

        ' imprimimos la cadena en el margen izquierdo
        Dim xPos As Single = e.MarginBounds.Left
        ' La fuente a usar
        Dim prFont As New Font("Arial", 9, FontStyle.Italic)
        Dim prFontletras As New Font("Arial", 9, FontStyle.Italic)
        Dim prFontletrasabajo As New Font("Arial", 8, FontStyle.Italic)
        ' la posición superior
        Dim yPos As Single = prFont.GetHeight(e.Graphics)

        'para matener el primer xPos para las sumas
        Dim sumasxpos As Integer
        Dim sumasypos As Integer



        'para el cliente
        yPos += 70
        xPos += 153


        'para la fecha

        Dim fecha As Date = CDate(dtfacturaventa.Rows(0).Item(4))

        'e.Graphics.DrawString(fecha.Day, prFont, Brushes.Black, xPos, yPos)
        'xPos += 37

        'e.Graphics.DrawString(fecha.Month, prFont, Brushes.Black, xPos, yPos)
        'xPos += 37
        'e.Graphics.DrawString(fecha.Year, prFont, Brushes.Black, xPos, yPos)'

        yPos += 44
        xPos = 95




        e.Graphics.DrawString(dtcliente.Rows(0).Item(1), prFont, Brushes.Black, xPos, yPos)



        If fl Then

            xPos -= 45
            yPos += 116

            e.Graphics.DrawString(fecha.Day & " / " & fecha.Month & " / " & fecha.Year, prFont, Brushes.Black, xPos, yPos)

        Else
            yPos += 34
            e.Graphics.DrawString(dtcliente.Rows(0).Item(5), prFont, Brushes.Black, xPos, yPos)
            yPos += 34
            e.Graphics.DrawString(dtcliente.Rows(0).Item(10), prFont, Brushes.Black, xPos, yPos)
            xPos += 310
            e.Graphics.DrawString(dtcliente.Rows(0).Item(11), prFont, Brushes.Black, xPos, yPos)

            yPos += 68
            xPos -= 310

            'Para la fecha

            yPos -= 23
            xPos -= 45


            e.Graphics.DrawString(fecha.Day & " / " & fecha.Month & " / " & fecha.Year, prFont, Brushes.Black, xPos, yPos)
        End If
        'desde aqui voy a descomentar









        xPos -= 30
        yPos += 38

        sumasxpos = xPos
        sumasypos = yPos
        Dim strp As String
        Dim caramax As Short = 0

        For i As Integer = 0 To dtdetallefacturaventa.Rows.Count - 1
            Dim tem As Short = dtdetallefacturaventa.Rows(i).Item(7).ToString.Length
            If tem >= caramax Then
                caramax = tem
            End If
        Next

        For i As Integer = 0 To dtdetallefacturaventa.Rows.Count - 1

            ' Create a StringFormat object with the each line of text, and the block
            ' of text centered on the page.
            Dim stringFormat As New StringFormat()
            stringFormat.Alignment = StringAlignment.Far


            ' Draw the text and the surrounding rectangle.


            'para el nombre o descripcion del produco
            xPos += 10
            dtproducto = tproducto.Consultar(" where codproducto = '" & dtdetallefacturaventa.Rows(i).Item(2) & "'")
            strp = dtproducto.Rows(0).Item(1).ToString

            If strp.Length > 50 Then
                strp = strp.Substring(0, 50)
            End If


            e.Graphics.DrawString(strp, prFont, Brushes.Black, xPos, yPos)


            ''para la cantidad
            xPos += 350
            e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(3), prFont, Brushes.Black, xPos, yPos, stringFormat)


            'para el precio unitario
            xPos += 55
            e.Graphics.DrawString(FormatNumber(dtdetallefacturaventa.Rows(i).Item(9), 2), prFont, Brushes.Black, xPos, yPos, stringFormat)

            'para las ventas gravadas
            xPos += 160


            e.Graphics.DrawString(FormatNumber(dtdetallefacturaventa.Rows(i).Item(7), 2), prFont, Brushes.Black, xPos, yPos, stringFormat)


            yPos += 16
            xPos -= 575
        Next


        ' para las numeros letras son


        Dim numletras1 As New NumeroLetras
        Dim nl As String
        numletras1.setnumero(dtfacturaventa.Rows(0).Item(10).ToString)
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
            nl = nl & " con 00/100 cent"
        End If

        xPos = sumasxpos

        yPos = sumasypos - 3

        yPos += 375
        xPos += 30


        e.Graphics.DrawString(nl, prFontletrasabajo, Brushes.Black, xPos, yPos)


        'para las sumas
        xPos = sumasxpos
        yPos = sumasypos

        xPos += 530
        yPos += 367

        e.Graphics.DrawString(FormatNumber(dtfacturaventa.Rows(0).Item(5), 2).ToString, prFont, Brushes.Black, xPos, yPos)


        'para los totales
        yPos += 85
        e.Graphics.DrawString(FormatNumber(dtfacturaventa.Rows(0).Item(10), 2).ToString, prFont, Brushes.Black, xPos, yPos)










        ' indicamos que ya no hay nada más que imprimir

        e.HasMorePages = False



    End Sub












    Public Sub imprimecomprobante()
        ' ejemplo simple para imprimir en .NET
        ' Usamos una clase del tipo PrintDocument
        Dim printDoc As New PrintDocument
        'Dim TamañoPersonal As New Printing.PaperSize("Prueba", 650, 425)
        Dim TamañoPersonal As New Printing.PaperSize("Prueba", 650, 800)


        printDoc.DefaultPageSettings.PaperSize = TamañoPersonal
        ' asignamos el método de evento para cada página a imprimir
        AddHandler printDoc.PrintPage, AddressOf print_PrintPage1
        ' indicamos que queremos imprimir

        printDoc.Print()
    End Sub

    Private Sub print_PrintPage1(ByVal sender As Object, ByVal e As PrintPageEventArgs)

        Dim dtfacturaventa As DataTable
        Dim tfacturaventa As New clsMaestros(clsNomTab.eTbl.FacturaVenta)

        Dim dtdetallefacturaventa As DataTable
        Dim tdetallefacturaventa As New clsMaestros(clsNomTab.eTbl.DetalleFacturaV)

        Dim dtcliente As DataTable
        Dim tcliente As New clsMaestros(clsNomTab.eTbl.Clientes)

        Dim dtproducto As DataTable
        Dim tproducto As New clsMaestros(clsNomTab.eTbl.Productos)



        dtfacturaventa = tfacturaventa.Consultar(" where codfacturav = " & Me.codfactura)
        dtdetallefacturaventa = tdetallefacturaventa.Consultar(" where codfacturav = " & Me.codfactura)
        dtcliente = tcliente.Consultar(" where codcliente = " & dtfacturaventa.Rows(0).Item(3))



        ' Este evento se producirá cada vez que se imprima una nueva página
        ' imprimir HOLA MUNDO en Arial tamaño 24 y negrita

        ' imprimimos la cadena en el margen izquierdo
        Dim xPos As Single = e.MarginBounds.Left
        ' La fuente a usar
        Dim prFont As New Font("Arial", 8, FontStyle.Italic)
        Dim prFontletras As New Font("Arial", 6, FontStyle.Italic)
        Dim prFont7 As New Font("Arial", 7, FontStyle.Italic)
        Dim prFont9 As New Font("Arial", 9, FontStyle.Italic)
        ' la posición superior
        Dim yPos As Single = prFont.GetHeight(e.Graphics)

        'para matener el primer xPos para las sumas
        Dim sumasxpos As Integer
        Dim sumasypos As Integer

        yPos += 118
        xPos -= 5

        'para el cliente
        e.Graphics.DrawString(dtcliente.Rows(0).Item(1), prFont, Brushes.Black, xPos, yPos)









        yPos += 35
        xPos += 5


        'para la direccion

        e.Graphics.DrawString(dtcliente.Rows(0).Item(5), prFontletras, Brushes.Black, xPos, yPos)

        'para el nit
        yPos -= 16
        xPos += 320

        e.Graphics.DrawString(dtcliente.Rows(0).Item(2), prFont, Brushes.Black, xPos, yPos)

        ''para el nrc

        yPos += 16
        e.Graphics.DrawString(dtcliente.Rows(0).Item(3), prFont, Brushes.Black, xPos, yPos)


        'para el giro

        yPos += 16
        xPos -= 30
        e.Graphics.DrawString(dtcliente.Rows(0).Item(4), prFont, Brushes.Black, xPos, yPos)



        'para la forma de pago
        yPos += 32
        xPos += 85
        e.Graphics.DrawString(dtfacturaventa.Rows(0).Item(11), prFont, Brushes.Black, xPos, yPos)


        'para la fecha

        Dim fecha As Date = CDate(dtfacturaventa.Rows(0).Item(4))
        xPos -= 425
        yPos += 46
        e.Graphics.DrawString(fecha.Day & " / " & fecha.Month & " / " & fecha.Year, prFont9, Brushes.Black, xPos, yPos)

        'para cantidad de productos

        yPos += 37
        xPos -= 16

        sumasxpos = xPos
        sumasypos = yPos
        Dim strp As String



        For i As Integer = 0 To dtdetallefacturaventa.Rows.Count - 1

            Dim stringFormat As New StringFormat()
            stringFormat.Alignment = StringAlignment.Far

            'para el nombre o descripcion del produco

            dtproducto = tproducto.Consultar(" where codproducto = '" & dtdetallefacturaventa.Rows(i).Item(2) & "'")

            strp = dtproducto.Rows(0).Item(1).ToString
            If strp.Length > 60 Then
                strp = strp.Substring(0, 60)
            End If
            e.Graphics.DrawString(strp, prFont9, Brushes.Black, xPos, yPos)


            'para la cantidad
            xPos += 340
            e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(3), prFont9, Brushes.Black, xPos, yPos, stringFormat)

            'para el precio unitario
            xPos += 65
            e.Graphics.DrawString(FormatNumber(dtdetallefacturaventa.Rows(i).Item(9), 2), prFont9, Brushes.Black, xPos, yPos, stringFormat)

            'para las ventas gravadas
            xPos += 150
            e.Graphics.DrawString(FormatNumber(dtdetallefacturaventa.Rows(i).Item(7), 2), prFont9, Brushes.Black, xPos, yPos, stringFormat)

            yPos += 16
            xPos -= 555
        Next





        'para las sumas
        xPos = sumasxpos
        yPos = sumasypos
        xPos += 505
        yPos += 305

        e.Graphics.DrawString(FormatNumber(dtfacturaventa.Rows(0).Item(5), 2).ToString, prFont9, Brushes.Black, xPos, yPos)


        'para el iva
        yPos += 22
        e.Graphics.DrawString(FormatNumber(dtfacturaventa.Rows(0).Item(7), 2).ToString, prFont9, Brushes.Black, xPos, yPos)


        'para los totales
        yPos += 105
        e.Graphics.DrawString(FormatNumber(dtfacturaventa.Rows(0).Item(10), 2).ToString, prFont9, Brushes.Black, xPos, yPos)





        ' para las numeros letras son


        Dim numletras1 As New NumeroLetras
        Dim nl As String
        numletras1.setnumero(dtfacturaventa.Rows(0).Item(10).ToString)
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
            nl = nl & " con 00/100 cent"
        End If

        yPos -= 110
        xPos -= 505

        e.Graphics.DrawString(nl, prFont9, Brushes.Black, xPos, yPos)


        ' '' indicamos que ya no hay nada más que imprimir

        e.HasMorePages = False

    End Sub



    Private Sub botguardar_Click(sender As Object, e As EventArgs) Handles botguardar.Click
        Try
            If donde = "cotizar" Then
            Else
                If Me.textotal.Text.ToString.Trim <> "0" And Me.textotal.Text.ToString.Trim <> "0.0" Then
                    Dim dtc As DataTable

                    Dim ella As String = ""
                    Dim nc As String = ""
                    If combotipo.Text = "Factura" Then
                        ella = "La "

                        If idcliente = "0" Then
                            idclienteestablecer()
                        End If

                        Try
                            dtc = consultar.Consultar("SELECT cliente FROM clientescf where idclientescf = " & Me.idcliente)
                            nc = dtc.Rows(0).Item(0).ToString
                        Catch ex As Exception
                            dtc = consultar.Consultar("SELECT nombre FROM cliente where codcliente = " & Me.idcliente)
                            nc = dtc.Rows(0).Item(0).ToString
                        End Try
                    Else
                        ella = "El "
                        Try
                            dtc = consultar.Consultar("SELECT nombre FROM cliente where codcliente = " & Me.idcliente)
                            nc = dtc.Rows(0).Item(0).ToString
                        Catch ex As Exception
                            dtc = consultar.Consultar("SELECT cliente FROM clientescf where idclientescf = " & Me.idcliente)
                            nc = dtc.Rows(0).Item(0).ToString
                        End Try

                    End If

                    If MsgBox("Cliente: " & nc & vbCrLf _
                              & "Total: " & Me.textotal.Text.ToString, MsgBoxStyle.YesNo, ella & combotipo.Text.ToString & " se guardara") = MsgBoxResult.Yes Then

                        guardardocumento()

                        mdiMain.llama = "venta"
                        Me.Close()
                        mdiMain.timllamar.Enabled = True

                    End If
                End If
            End If



        Catch ex As Exception

        End Try



    End Sub

    Private Sub guardardocumento()
        Try
            If donde = "Cotizar" Then
                Dim tfv As New clsMaestros(clsNomTab.eTbl.FacturaVenta)
                Dim dtfv As New clsMaestros(clsNomTab.eTbl.DetalleFacturaV)
                Dim elimd As New clsProcesos

                tfv.Eliminar(codfactura)
                elimd.Ejecutar(" delete from detalleventa where codfacturav = " & codfactura)
                Me.Close()
            Else
                Me.guardado = True
                Dim ella As String = ""
                If combotipo.Text = "Factura" Then
                    ella = "La "
                Else
                    ella = "El "
                End If

                Dim imprimir1 As String = ""

                Dim imprimir2 As String = ella & combotipo.Text.ToString & " esta por imprimirse: Desea continuar?" & vbCrLf _
                          & " La decisión no podrá revertirse"



                'tventas.Insertar("'" & Me.texnumfact.Text.ToString.Trim & "','" & Me.combotipo.Text.ToString & "','" & idcliente & "','" & f & "'," & CDbl(0).ToString & "," & CDbl(0) & "," & CDbl(0).ToString & "," & CDbl(0).ToString & "," & CDbl(0).ToString & "," & CDbl(0).ToString & ",'" & Me.comboformapago.Text.ToString & "','valida','" & Me.textiraje.Text.ToString & "'")


                Dim d, m, a, f As String
                d = Me.DateTimePicker1.Value.Day
                m = Me.DateTimePicker1.Value.Month
                a = Me.DateTimePicker1.Value.Year
                f = a + "-" + m + "-" + d
                Dim tipo As String = ""

                If Me.combotipo.Text.ToString = "Factura" Then
                    tipo = "Factura"


                End If

                If combotipo.Text.ToString <> "Factura" Then
                    If combotipo.Text.ToString <> "Comprobante de Credito fiscal" Then
                        If Me.texiva.Text = "0.0" Then
                            tipo = "Comprobante de Credito fiscal"
                        Else
                            tipo = "Factura"
                        End If
                    Else
                        tipo = "Comprobante de Credito fiscal"
                    End If

                End If

                Dim comi As Decimal = 0

                If Me.checomision.Checked Then
                    If Me.texcomision.Text.ToString <> "" Then
                        comi = CDec(Me.texcomision.Text)
                    End If

                End If

                consultar.Consultar(" update facturaventa set numfacturav = " & Me.texnumfact.Text & ", tipo = '" & tipo & "', codcliente = '" & idcliente & "', fecha = '" & f & "',formadepago = '" & Me.comboformapago.Text & "', tiraje = '" & Me.textiraje.Text & "', " & " sumas = " & Me.texsumas.Text.Trim.ToString & ", iva = " & Me.texiva.Text.Trim.ToString & ", total = " & Me.textotal.Text.Trim.ToString & ",fechavence = '" & f & "',comision = " & comi & " where codfacturav = " & codfactura)


                Dim c As Double
                For i As Integer = 0 To dtdetalleventa.Rows.Count - 1
                    dtproducto = tproductos.Consultar(" where codproducto = '" & dtdetalleventa.Rows(i).Item(2).ToString & "'")
                    c = CDbl(dtproducto.Rows(0).Item(6)) - CDbl(dtdetalleventa.Rows(i).Item(3))
                    consultar.Consultar(" update productos set existencias = " & c.ToString & " where codproducto = '" & dtdetalleventa.Rows(i).Item(2).ToString & "'")
                Next



                If Me.combotipo.Text = "Factura" Then
                    consultar.Consultar(" update tirajes set tirajefa = " & (CShort(Me.texnumfact.Text.Trim) + 1))


                Else

                    consultar.Consultar(" update tirajes set tirajeca = " & (CShort(Me.texnumfact.Text.Trim) + 1))
                End If




                'termina la tarea de imprimir

                If mdiMain.super <> True Then
                    Dim tnoti As New clsMaestros(clsNomTab.eTbl.notificaciones)

                    Dim dtnoti As DataTable
                    dtnoti = consultar.Consultar(" SELECT max(orden) FROM notificaciones ")

                    Dim ordenactual As Short

                    If dtnoti.Rows(0).Item(0).ToString = Nothing Then
                        ordenactual = 1
                    Else
                        ordenactual = CShort(dtnoti.Rows(0).Item(0))
                        ordenactual += 1
                    End If





                    tnoti.Insertar(ordenactual & ",'" & Me.combotipo.Text.ToString & "','" & Me.texcliente.Text & "'," & Me.textotal.Text.ToString & "," & codfactura)


                Else
                    If Me.combotipo.Text = "Factura" Then
                        imprimir()

                    Else
                        imprimecomprobante()
                    End If


                End If

                If donde <> "here" Then
                    frmdv.modi = True
                    frmdv.cargarfacturac()
                    frmvr.hacerconsulta()
                    Me.Close()
                End If




            End If

        Catch ex As Exception
            MsgBox("Ocurrio un error al ingresar la factura razon: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles boteliminar.Click, HolaToolStripMenuItem.Click
        Try
            Dim id As Short = Me.gridcompra.CurrentCell.RowIndex
            Dim dtrdetalle As DataRow = dtdetalleventa.Rows(id)

            If MsgBox("Esta seguro de quitar el producto de la factura? ", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                consultar.Consultar("delete from detalleventa where coddetallefacturav = " & dtrdetalle.Item(0))
                numpr -= 1
                cargarfactura()
            End If

        Catch ex As Exception

        End Try

    End Sub



    Private Function correcto() As Boolean
        Dim fl As Boolean = True
        If donde <> "Cotizar" Then
            If texcliente.Text = "" Then
                Me.texcliente.BackColor = Color.Red
                fl = False
            Else
                Me.texcliente.BackColor = Color.White
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

            If Me.comboformapago.Text = "" Then
                Me.comboformapago.BackColor = Color.Red
                fl = False
            Else
                Me.comboformapago.BackColor = Color.White
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

            If Me.comboprecios.Text = "" Then
                Me.comboprecios.BackColor = Color.Red
                fl = False
            Else
                Me.comboprecios.BackColor = Color.White
            End If

            If Me.textotalp.Text = "" Then
                Me.textotalp.BackColor = Color.Red
                fl = False
            Else
                Me.textotalp.BackColor = Color.White
            End If

        End If



        Return fl
    End Function

    Private Sub botagregar_Click(sender As Object, e As EventArgs) Handles botagregar.Click

        If donde = "Cotizar" Then
            agregararticulo()
        Else
            If Me.combotipo.Text.Trim.ToString = "Factura" Then
                If numproductos > 23 Then
                    If MsgBox("Se ha alcanzado el limite de productos por factura desea guardar la factura?", MsgBoxStyle.YesNo, "LIMITE") = MsgBoxResult.Yes Then
                        guardardocumento()
                    End If
                Else
                    agregararticulo()
                End If
            Else
                If numproductos >= 18 Then
                    If MsgBox("Se ha alcanzado el limite de productos por CCF desea guardar?", MsgBoxStyle.YesNo, "LIMITE") = MsgBoxResult.Yes Then
                        guardardocumento()
                    End If
                Else
                    agregararticulo()
                End If
            End If
        End If



        Me.texcantidad.Text = ""
        Me.comboprecios.Items.Clear()
        Me.comboprecios.Text = ""
        Me.textotalp.Text = ""
        Me.texnombrep.Text = ""
        Me.texcantidad.Focus()

    End Sub

    Private Sub agregararticulo()
        If correcto() <> False Then
            agregarv = True

            'limpirando las variables globales

            Try
                If primeraf = False Then

                    Dim can As Double
                    Dim tl As Double
                    Dim f As Boolean = False

                    For i As Integer = 0 To dtdetalleventa.Rows.Count - 1
                        If idproducto = dtdetalleventa.Rows(i).Item(2).ToString Then

                            If combotipo.Text.Trim.ToString <> "Factura" Then
                                can = Math.Round(CDbl(dtdetalleventa.Rows(i).Item(3) + CDbl(Me.texcantidad.Text)), 2)

                                Dim pr As Double = (CDbl(Me.comboprecios.Text.Trim.ToString) * can)

                                Dim priva As Double = Math.Round((pr / 1.13), 2)

                                tl = priva

                            Else
                                can = Math.Round(CDbl(dtdetalleventa.Rows(i).Item(3) + CDbl(Me.texcantidad.Text)), 2)
                                tl = Math.Round(CDbl(dtdetalleventa.Rows(i).Item(7)) + CDbl(Me.textotalp.Text.Trim), 2)
                            End If


                            consultar.Consultar("update detalleventa set total = " & tl & ", cantidadunit = " & can.ToString & " where codfacturav = " & codfactura.ToString & " and coddetallefacturav = " & dtdetalleventa.Rows(i).Item(0).ToString)
                            f = True
                            privar()
                            cargarfactura()
                        End If
                    Next

                    If f = False Then
                        'If donde <> "Cotizar" Then
                        '    If CInt(dtrproductos.Item(6)) < CInt(Me.texcantidad.Text.Trim) Then
                        '        MsgBox("No cuenta con susficientes existencias de este produto para realizar la transaccion", MsgBoxStyle.Critical, "Aviso")
                        '    Else
                        '        insertar()
                        '    End If
                        'Else
                        '    insertar()
                        'End If
                        insertar()



                    End If
                Else
                    'If donde <> "Cotizar" Then
                    '    If CInt(dtrproductos.Item(6)) < CInt(Me.texcantidad.Text.Trim) Then
                    '        MsgBox("No cuenta con susficientes existencias de este produto para realizar la transaccion", MsgBoxStyle.Critical, "Aviso")
                    '    Else
                    '        insertar()
                    '    End If
                    'Else
                    '    insertar()
                    'End If

                    insertar()


                End If



            Catch ex As Exception
                MsgBox("ocurrio un error razon: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
            End Try
        Else
            MsgBox("Tiene que llenar todos los campos que esten en rojo", MsgBoxStyle.ApplicationModal, "Aviso")
        End If

    End Sub

    Private Sub convertiraletras(ByVal numero As Double)
        Dim numletras1 As New NumeroLetras
        Dim nl As String
        numletras1.setnumero(numero)
        nl = numletras1.getnumero().ToString & " dolares "

        If numletras1.getdecimal() > 0 Then
            Dim nn As String
            If numletras1.getdecimal() < 11 Then
                nn = numletras1.getdecimal()

                nl = nl & "con " & nn & "/100 cent"
            Else
                nl = nl & "con " & numletras1.getdecimal.ToString & "/100 cent"
            End If

        Else
            nl = nl
        End If

        Me.lson.Text = nl
    End Sub



    Private Sub textotalp_KeyUp(sender As Object, e As KeyEventArgs) Handles textotalp.KeyUp
        Try
            If checklibre.Checked <> True Then
                If Me.textotalp.Text = "" Or Me.comboprecios.Text = "" Then
                Else
                    Me.cantidad = CDbl(Me.textotalp.Text)
                    Me.preciot = CDbl(Me.comboprecios.Text)
                    Me.texcantidad.Text = Math.Round(cantidad / preciot, 2)
                End If
            End If
        Catch ex As Exception
            MsgBox("Ingrese datos en los campos para realizar los calculos", MsgBoxStyle.Critical, "Aviso")
        End Try

    End Sub




    Dim contasegundos As Short = 0
    Private Sub Timerimprimir_Tick(sender As Object, e As EventArgs) Handles Timerimprimir.Tick
        contasegundos += 1

        If contasegundos = 100 Then
            Me.Timerimprimir.Enabled = False
            Me.contasegundos = 0
        End If
    End Sub



    Private Sub idclienteestablecer()
        Dim cf As New clsMaestros(clsNomTab.eTbl.clientescf)
        Dim dtcf As DataTable
        Dim ncf As Integer




        If Not Me.texcliente.Text.ToString = CStr("Consumidor Final").ToString Then
            cf.Insertar("'" & Me.texcliente.Text.Trim.ToString & "'")
            dtcf = consultar.Consultar("SELECT  max(idclientescf) FROM clientescf")
            ncf = CInt(dtcf.Rows(0).Item(0))
            idcliente = ncf
        Else
            idcliente = CInt(1)
        End If

    End Sub

    Private Sub texcliente_DoubleClick(sender As Object, e As EventArgs) Handles texcliente.DoubleClick
        Try

            Me.texcliente.Text = ""
            Dim frmc As New Clientes
            frmc.donde = "ventas"
            frmc.frmv = Me
            frmc.Show()
        Catch ex As Exception

        End Try
    End Sub


    Dim dtcli As DataTable
    Dim dtclcf As DataTable
    Dim cf = False, cc As Boolean = False





    'Private Sub texcliente_Enter(sender As Object, e As EventArgs) Handles texcliente.Enter
    '  
    'End Sub






    Dim entert As Boolean = False




    Private Sub checkimprimir_CheckedChanged(sender As Object, e As EventArgs)

        Me.botguardar.Text = "Imprimir"
        Me.botguardar.Text = "Guardar"
    End Sub

    Private Sub texcliente_LostFocus(sender As Object, e As EventArgs) Handles texcliente.LostFocus
        If Me.texcliente.Text.ToString = "Consumidor Final".ToString Then
            Me.idcliente = 5403
        End If

    End Sub



 
 






    Dim fl As Boolean = False
    Private Sub textiraje_LostFocus(sender As Object, e As EventArgs) Handles textiraje.LostFocus
        Try
            If Not fl Then

                Dim dtfc As DataTable

                If Me.textiraje.Text = Nothing Or Me.texnumfact.Text = Nothing Then

                Else
                    fl = True
                    dtfc = consultar.Consultar("SELECT * FROM `facturaventa` where tiraje = '" & Me.textiraje.Text.Trim & "' and numfacturav = ' " & Me.texnumfact.Text.Trim & "'")
                    If dtfc.Rows.Count <> 0 Then
                        MsgBox("Esta venta ya esta ingresada", MsgBoxStyle.Information, "AVISO")
                    End If
                End If

            End If
        Catch ex As Exception

        End Try

    End Sub

    Dim dtproveedor As DataTable
    Dim dtproveedor1 As DataTable
    Dim tproveedor As New clsMaestros(clsNomTab.eTbl.Proveedores)
    Dim dtproductosA As DataTable
    Dim dtproductosalfa As DataTable





    Private Sub texnombrep_TextChanged(sender As Object, e As EventArgs) Handles texnombrep.TextChanged
        Dim dv As DataView = dtproductosalfa.DefaultView
        'dv.RowFilter = "nombre like '" & Me.texbusquedacodigonombre.Text.Trim.ToString & " '"
        dv.RowFilter = "nombre like '%" & Me.texnombrep.Text.Trim.ToString & "%' or codigo like '%" & Me.texnombrep.Text.Trim.ToString & "%'"

        gridproductos.DataSource = dv
        dtproductosA = dv.ToTable


        cargargrid1()
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
                Me.gridproductos.Rows(i).Cells(6).Value = dtproductosA.Rows(i).Item(6).ToString 'para las existencias


            Next
        Catch ex As Exception
            'MsgBox("Ocurrio el siguiente error a la hora de llenar el grid: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try

    End Sub

  

    Private Sub gridproductos_KeyDown(sender As Object, e As KeyEventArgs) Handles gridproductos.KeyDown
        Try
            If e.KeyCode = 13 Then

                Dim id As Short = Me.gridproductos.CurrentCell.RowIndex
                Dim dtrproducto1 As DataRow = dtproductosA.Rows(id)


                Me.dtrproductos = dtrproducto1
                Me.texnombrep.Text = dtrproducto1.Item(1)
                Me.comboprecios.Items.Clear()
                Me.comboprecios.Text = dtrproducto1.Item(8).ToString
                Me.comboprecios.Items.Add(dtrproducto1.Item(8).ToString)
                Me.comboprecios.Items.Add(dtrproducto1.Item(9).ToString)
                Me.comboprecios.Items.Add(dtrproducto1.Item(10).ToString)
                Me.texcantidad.Focus()
                Me.idproducto = dtrproducto1.Item(0)
                Me.gridproductos.Visible = False
                Me.texcantidad.Text = ""

            End If
        Catch ex As Exception

        End Try
    End Sub




    Private Sub texnombrep_KeyDown(sender As Object, e As KeyEventArgs) Handles texnombrep.KeyDown
        If e.KeyCode = 40 Then
            Me.gridproductos.Focus()
            Me.gridproductos.CurrentRow.Cells(1).Selected = True
        End If

        If e.KeyCode = 27 Then
            Me.gridproductos.Visible = False
            Me.texnombrep.Text = ""
            Me.texcantidad.Text = ""
            Me.comboprecios.Items.Clear()
            Me.botguardar.Focus()
        End If

        If e.KeyCode = 39 Then
            Me.texcantidad.Focus()
        End If

        If e.KeyCode = 38 Then
            Me.texcliente.Focus()
        End If

        If e.KeyCode = 13 Then
            Try
                Me.gridproductos.Visible = False
                Me.texcantidad.Text = ""
                Me.idproducto = Me.texnombrep.Text

                Dim dtprd As DataTable
                Dim tprd As New clsMaestros(clsNomTab.eTbl.Productos)
                dtprd = tprd.Consultar(" where codproducto = '" & idproducto & "'")
                Me.texnombrep.Text = dtprd.Rows(0).Item(1).ToString
                Me.texcantidad.Focus()
                Me.texcantidad.Text = 1
                Me.comboprecios.Text = dtprd.Rows(0).Item(10).ToString
                Me.textotalp.Text = dtprd.Rows(0).Item(10).ToString

                botagregar_Click(sender, e)

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub texcantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles texcantidad.KeyDown
        If e.KeyCode = 37 Then
            Me.texnombrep.Focus()
        End If

     

        If e.KeyCode = 39 Then
            Me.gridproductos.Visible = False
            Me.comboprecios.Focus()
        End If

        If e.KeyCode = 13 Then
            Try
                If Me.texcantidad.Text = Nothing Or Me.texnombrep.Text = Nothing Or Me.comboprecios.Text = Nothing Or Me.textotalp.Text = Nothing Then
                    Me.gridproductos.Visible = False


                    Me.idproducto = Me.texcantidad.Text

                    Dim dtprd As DataTable
                    Dim tprd As New clsMaestros(clsNomTab.eTbl.Productos)
                    dtprd = tprd.Consultar(" where codproducto = '" & idproducto & "'")
                    Me.texnombrep.Text = dtprd.Rows(0).Item(1).ToString
                    Me.texcantidad.Text = 1
                    Me.comboprecios.Text = dtprd.Rows(0).Item(10).ToString
                    Me.textotalp.Text = dtprd.Rows(0).Item(10).ToString


                Else
                    botagregar_Click(sender, e)
                End If

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private nuevo As Boolean = False
    Private Sub botnuevop_Click(sender As Object, e As EventArgs) Handles botnuevop.Click
        Servitec.Productos.Show()
        nuevo = True
    End Sub


    Private Sub checomision_CheckedChanged(sender As Object, e As EventArgs) Handles checomision.CheckedChanged
        If Me.checomision.Checked = True Then
            Me.lcomision.Visible = True
            Me.texcomision.Visible = True
        Else
            Me.texcomision.Visible = False
            Me.lcomision.Visible = False

        End If
    End Sub

    Private Sub comboprecios_KeyDown(sender As Object, e As KeyEventArgs) Handles comboprecios.KeyDown
        If e.KeyCode = 37 Then
            Me.texcantidad.Focus()
        End If

        If e.KeyCode = 39 Then
            Me.textotalp.Focus()
        End If
    End Sub

    Private Sub comboprecios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboprecios.KeyPress
        Try
            e.Handled = onlynumero(e)
            e.Handled = onlynumero(e)
            If (Asc(e.KeyChar)) = 13 Then
                botagregar_Click(sender, e)
            End If
        Catch ex As Exception

        End Try
    End Sub

 
    Private Sub comboprecios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboprecios.SelectedIndexChanged
        Try
            If checklibre.Checked <> True Then
                If Me.comboprecios.Text = "" Or Me.texcantidad.Text = "" Then
                Else
                    Me.cantidad = FormatNumber(CDec(Me.texcantidad.Text), 2)

                    Me.preciot = FormatNumber(CDec(Me.comboprecios.Text), 2)
                    Me.textotalp.Text = FormatNumber(CDec(cantidad * preciot), 2)

                End If
            End If
        Catch ex As Exception
            MsgBox("Ingrese datos en los campos para realizar los calculos", MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

 
   
    Private Sub texcantidad_TextChanged(sender As Object, e As EventArgs) Handles texcantidad.TextChanged

    End Sub

    Private Sub texcantidad_MouseDown(sender As Object, e As MouseEventArgs) Handles texcantidad.MouseDown

    End Sub

    Private Sub texcantidad_LostFocus(sender As Object, e As EventArgs) Handles texcantidad.LostFocus

    End Sub

    Private Sub texcliente_TextChanged(sender As Object, e As EventArgs) Handles texcliente.TextChanged

    End Sub
End Class