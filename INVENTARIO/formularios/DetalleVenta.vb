Imports logica

Imports System.Drawing.Printing
Public Class DetalleVenta
    Private tfacturav As New clsMaestros(clsNomTab.eTbl.FacturaVenta)
    Public dtfacturav As DataTable
    Private tdetallefacturav As New clsMaestros(clsNomTab.eTbl.DetalleFacturaV)
    Public dtdetallefacturav As DataTable
    Private tclientes As New clsMaestros(clsNomTab.eTbl.Clientes)
    Public dtclientes As DataTable
    Private tproductos As New clsMaestros(clsNomTab.eTbl.Productos)
    Public dtproductos As DataTable
    Public frmvr As VentasRealizadas
    Public tipof As String
    Public max As Integer
    Public modi As Boolean = False
    Private codfactura As String

    Public idfactura As String

    Private tfcf As New clsMaestros(clsNomTab.eTbl.clientescf)

    Private dttiraje As DataTable
    Private ttiraje As New clsMaestros(clsNomTab.eTbl.tiraje)
    Public donde As String = "aqui"

    'Variable para determinar si el documento actual es una factura o un comprobante
    Private factura As Boolean = True

    Private Sub DetalleCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If donde <> "noti" Then
            MdiParent = mdiMain
            cargarfacturac()
            hacerconsulta()
        Else
            cargarfacturac()
        End If


        Me.botimprimir.Focus()
    End Sub

    Private Sub hacerconsulta()
        Try
            If tipof = "todos" Then
                dtfacturav = tfacturav.Consultar()
                Me.max = dtfacturav.Rows.Count - 1
            Else
                dtfacturav = tfacturav.Consultar(" where  tipo = '" + tipof + "'")
                Me.max = dtfacturav.Rows.Count - 1
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub
    Public Sub cargarfacturac()

        Try

            If donde = "noti" Then


                If modi = True Then
                    hacerconsulta()
                End If

               

                If dtfacturav.Rows(0).Item(2).ToString = "Factura" Then
                    dtclientes = tfcf.Consultar(" where idclientescf = " & dtfacturav.Rows(0).Item(3).ToString)
                    If dtclientes.Rows.Count = 0 Then
                        dtclientes = tclientes.Consultar(" where codcliente = '" + dtfacturav.Rows(0).Item(3).ToString + "'")
                    End If
                    Me.gruregis.Visible = False
                Else
                    dtclientes = tclientes.Consultar(" where codcliente = '" + dtfacturav.Rows(0).Item(3).ToString + "'")
                    If dtclientes.Rows.Count = 0 Then
                        dtclientes = tfcf.Consultar(" where idclientescf = " & dtfacturav.Rows(0).Item(3).ToString)
                    End If
                    Me.gruregis.Visible = True
                End If

                dttiraje = ttiraje.Consultar()

                If dtfacturav.Rows(0).Item(2).ToString = "Factura" Then
                    Me.texcliente.Text = dtclientes.Rows(0).Item(1)
                    factura = True
                    If dttiraje.Rows(0).Item(4).ToString = (CInt(dtfacturav.Rows(0).Item(1).ToString) + 1).ToString Then
                        Me.boteliminar.Visible = True
                    Else
                        Me.boteliminar.Visible = True
                    End If
                Else
                    Me.texnit.Text = dtclientes.Rows(0).Item(2).ToString
                    Me.texnrc.Text = dtclientes.Rows(0).Item(3).ToString
                    Me.texcliente.Text = dtclientes.Rows(0).Item(1).ToString
                    factura = False

                    If dttiraje.Rows(0).Item(8).ToString = (CInt(dtfacturav.Rows(0).Item(1).ToString) + 1).ToString Then
                        Me.boteliminar.Visible = True
                    Else
                        Me.boteliminar.Visible = True

                    End If
                End If


                Me.texnumfactura.Text = dtfacturav.Rows(0).Item(1)

                Me.textiraje.Text = dtfacturav.Rows(0).Item(13)

                dttiraje = ttiraje.Consultar()

                Me.texformadepago.Text = dtfacturav.Rows(0).Item(11)

                Me.textipo.Text = dtfacturav.Rows(0).Item(2)

                Me.texfecha.Text = dtfacturav.Rows(0).Item(4)


                Me.texsumas.Text = FormatNumber(dtfacturav.Rows(0).Item(5), 2)
                Me.texiva.Text = FormatNumber(dtfacturav.Rows(0).Item(7), 2)

                Me.textotal.Text = FormatNumber(dtfacturav.Rows(0).Item(10), 2)

                If dtfacturav.Rows(0).Item(11).ToString = "Credito" Then

                    If dtfacturav.Rows(0).Item(6).ToString = "1" Then
                        Me.botpagar.Text = "Cancelado"
                        Me.botpagar.BackColor = Color.Green
                        Me.botpagar.Visible = True
                    Else
                        Me.botpagar.Text = "Pagar"
                        Me.botpagar.BackColor = Color.Orange
                        Me.botpagar.Visible = True
                    End If

                Else
                    Me.botpagar.Visible = False
                End If




                If dtfacturav.Rows(0).Item(12).ToString = "invalida" Then
                    Me.lbanulada.Visible = True
                    Me.grupboton.Visible = False
                Else
                    Me.lbanulada.Visible = False
                    Me.grupboton.Visible = True
                End If



                Dim numletras1 As New NumeroLetras
                Dim nl As String
                numletras1.setnumero(textotal.Text.ToString)
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

                cargargrid()


            Else
                If modi = True Then
                    hacerconsulta()
                End If

                dtfacturav = tfacturav.Consultar(" where codfacturav = " & Me.idfactura)

                If dtfacturav.Rows(0).Item(2).ToString = "Factura" Then
                    Try
                        dtclientes = tfcf.Consultar(" where idclientescf = " & dtfacturav.Rows(0).Item(3).ToString)
                        Me.texcliente.Text = dtclientes.Rows(0).Item(1)
                        Me.gruregis.Visible = False
                    Catch ex As Exception
                        dtclientes = tclientes.Consultar(" where codcliente = '" + dtfacturav.Rows(0).Item(3).ToString + "'")
                        Me.gruregis.Visible = True
                    End Try


                ElseIf dtfacturav.Rows(0).Item(2).ToString = "credito" Then
                    Try
                        dtclientes = tfcf.Consultar(" where idclientescf = " & dtfacturav.Rows(0).Item(3).ToString)
                        Me.gruregis.Visible = False
                        Dim nc As String = dtclientes.Rows(0).Item(1)
                    Catch ex As Exception
                        dtclientes = tclientes.Consultar(" where codcliente = '" + dtfacturav.Rows(0).Item(3).ToString + "'")
                        Me.gruregis.Visible = True
                    End Try
                Else
                    Try
                        dtclientes = tclientes.Consultar(" where codcliente = '" + dtfacturav.Rows(0).Item(3).ToString + "'")
                        If dtclientes.Rows.Count = 0 Then
                            dtclientes = tfcf.Consultar(" where idclientescf = " & dtfacturav.Rows(0).Item(3).ToString)
                        End If
                        Me.gruregis.Visible = True
                    Catch ex As Exception

                    End Try

                End If

                dttiraje = ttiraje.Consultar()

                If dtfacturav.Rows(0).Item(2).ToString = "Factura" Then
                    Me.texcliente.Text = dtclientes.Rows(0).Item(1)
                    factura = True
                    If dttiraje.Rows(0).Item(4).ToString = (CInt(dtfacturav.Rows(0).Item(1).ToString) + 1).ToString Then
                        Me.boteliminar.Visible = True
                    Else
                        Me.boteliminar.Visible = True
                    End If
                ElseIf dtfacturav.Rows(0).Item(2).ToString = "credito" Then
                    Me.texcliente.Text = dtclientes.Rows(0).Item(1).ToString
                Else
                    Try
                        Me.texcliente.Text = dtclientes.Rows(0).Item(1).ToString
                        Me.texnit.Text = dtclientes.Rows(0).Item(2).ToString
                        Me.texnrc.Text = dtclientes.Rows(0).Item(3).ToString

                    Catch ex As Exception

                    End Try
                    factura = False

                    If dttiraje.Rows(0).Item(8).ToString = (CInt(dtfacturav.Rows(0).Item(1).ToString) + 1).ToString Then
                        Me.boteliminar.Visible = True
                    Else
                        Me.boteliminar.Visible = True
                    End If
                End If


                Me.texnumfactura.Text = dtfacturav.Rows(0).Item(1)

                Me.textiraje.Text = dtfacturav.Rows(0).Item(13)

                dttiraje = ttiraje.Consultar()

                Me.texformadepago.Text = dtfacturav.Rows(0).Item(11)

                Me.textipo.Text = dtfacturav.Rows(0).Item(2)

                Me.texfecha.Text = dtfacturav.Rows(0).Item(4)
                Me.texfechavence.Text = dtfacturav.Rows(0).Item(14)

                Me.texsumas.Text = FormatNumber(dtfacturav.Rows(0).Item(5), 2)
                Me.texiva.Text = FormatNumber(dtfacturav.Rows(0).Item(7), 2)

                Me.textotal.Text = FormatNumber(dtfacturav.Rows(0).Item(10), 2)

                If dtfacturav.Rows(0).Item(2).ToString = "credito" Then

                    If dtfacturav.Rows(0).Item(6).ToString = dtfacturav.Rows(0).Item(10).ToString Then
                        Me.botpagar.Text = "Cancelado"
                        Me.botpagar.BackColor = Color.Green
                        Me.botpagar.Visible = True

                        Me.texabonar.Visible = False
                        Me.botabonar.Visible = False
                        Me.texsaldo.Visible = False

                        Me.texfechavence.Visible = False

                        Me.lfechavence.Visible = False
                    Else
                        Me.botpagar.Text = "Pagar"
                        Me.botpagar.BackColor = Color.Orange
                        Me.botpagar.Visible = True
                        Me.texabonar.Visible = True
                        Me.botabonar.Visible = True
                        Me.texsaldo.Visible = True

                        Me.texfechavence.Visible = True
                        Me.lfechavence.Visible = True

                        Dim sl As Decimal = CDec(Math.Round(dtfacturav.Rows(0).Item(6), 2))
                        Dim tot As Decimal = CDec(Math.Round(dtfacturav.Rows(0).Item(10), 2))

                        Me.texsaldo.Text = tot - sl
                    End If

                Else
                    Me.botpagar.Visible = False
                End If


           


                If dtfacturav.Rows(0).Item(12).ToString = "invalida" Then
                    Me.lbanulada.Visible = True
                    Me.grupboton.Visible = False
                Else
                    Me.lbanulada.Visible = False
                    Me.grupboton.Visible = True
                End If



                Dim numletras1 As New NumeroLetras
                Dim nl As String
                numletras1.setnumero(textotal.Text.ToString)
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

                cargargrid()
            End If

        Catch ex As Exception
            MsgBox("Ocurrio un error al cargar los datos" + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub
    Private Sub cargargrid()
        Try
            dtdetallefacturav = tdetallefacturav.Consultar(" where codfacturav = '" + Me.idfactura.ToString + "'")
            codfactura = dtfacturav.Rows(0).Item(0).ToString
            Dim nf As Short
            nf = dtdetallefacturav.Rows.Count


            If nf = 0 Then
                Me.gridventa.RowCount = 1
                Me.gridventa.Rows(0).Cells(0).Value = ""
                Me.gridventa.Rows(0).Cells(1).Value = ""
                Me.gridventa.Rows(0).Cells(2).Value = ""
                Me.gridventa.Rows(0).Cells(3).Value = ""
                Me.gridventa.Rows(0).Cells(4).Value = ""
                Me.gridventa.Rows(0).Cells(5).Value = ""
                Me.gridventa.Rows(0).Cells(6).Value = ""
            Else
                Me.gridventa.RowCount = nf
            End If

            For i As Integer = 0 To dtdetallefacturav.Rows.Count - 1
                dtproductos = tproductos.Consultar(" where codproducto = '" + dtdetallefacturav.Rows(i).Item(2).ToString & "'")
                Me.gridventa.Rows(i).Cells(0).Value = dtproductos.Rows(0).Item(0) 'codigo del producto
                Me.gridventa.Rows(i).Cells(2).Value = dtproductos.Rows(0).Item(1) 'nombre del producto
                Me.gridventa.Rows(i).Cells(1).Value = dtdetallefacturav.Rows(i).Item(3) ' cantidad
                Me.gridventa.Rows(i).Cells(3).Value = FormatNumber(dtdetallefacturav.Rows(i).Item(9), 2) ' precio
                Me.gridventa.Rows(i).Cells(4).Value = "0"
                Me.gridventa.Rows(i).Cells(5).Value = "0"
                Me.gridventa.Rows(i).Cells(6).Value = FormatNumber(dtdetallefacturav.Rows(i).Item(7), 2)
            Next
            Me.gridventa.Rows(0).Cells(0).Selected = True
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub






    Private Sub botsalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub boteditar_Click(sender As Object, e As EventArgs)
        Try
            Dim ad As New AnularDocumento
            ad.forma = Me
            ad.Show()
        Catch ex As Exception

        End Try

    End Sub

    Dim c As New clsProcesos
 
    Public Sub duplicardocumento()
        Try
            'Insertando la venta nueva
            dtfacturav = tfacturav.Consultar(" where codfacturav = " & Me.idfactura)
            Dim nf As Integer = CInt(dtfacturav.Rows(0).Item(1)) + 1
            Dim tcodf As New clsProcesos

            If dtfacturav.Rows(0).Item(2).ToString = "Factura" Then
                tcodf.Consultar("update tirajes set tirajefa = '" & nf + 1 & "'")
            Else
                tcodf.Consultar("update tirajes set tirajeca = '" & nf + 1 & "'")
            End If

            Dim dt As Date = CDate(dtfacturav.Rows(0).Item(4))
            Dim f As String = dt.Year.ToString + "-" + dt.Month.ToString + "-" + dt.Day.ToString


            tfacturav.Insertar("'" & nf.ToString & "','" & dtfacturav.Rows(0).Item(2) & "','" & dtfacturav.Rows(0).Item(3) & "','" & f & "'," & dtfacturav.Rows(0).Item(5) & "," & dtfacturav.Rows(0).Item(6) & "," & dtfacturav.Rows(0).Item(7) & "," & dtfacturav.Rows(0).Item(8) & "," & dtfacturav.Rows(0).Item(9) & "," & dtfacturav.Rows(0).Item(10) & ",'" & dtfacturav.Rows(0).Item(11) & "','valida','" & dtfacturav.Rows(0).Item(13) & "','" & f & "'")
            Dim dtcodfactura As DataTable
            Dim consultar As New clsProcesos

            dtcodfactura = consultar.Consultar("SELECT  Max(codfacturav) FROM facturaventa")
            codfactura = dtcodfactura.Rows(0).Item(0)


            For i As Integer = 0 To dtdetallefacturav.Rows.Count - 1
                
                tdetallefacturav.Insertar(codfactura.ToString & ",'" & dtdetallefacturav.Rows(i).Item(2).ToString & "'," & dtdetallefacturav.Rows(i).Item(3).ToString & "," & dtdetallefacturav.Rows(i).Item(4).ToString & "," & dtdetallefacturav.Rows(i).Item(5).ToString & "," & dtdetallefacturav.Rows(i).Item(6).ToString & ",'" & dtdetallefacturav.Rows(i).Item(7).ToString & "'," & dtdetallefacturav.Rows(i).Item(8).ToString & "," & dtdetallefacturav.Rows(i).Item(9).ToString)

            Next
            MsgBox("El docuemento se anulo exitozamente", MsgBoxStyle.Information, "Exito")

            Dim tf As New clsProcesos

            tf.Consultar("   UPDATE facturaventa SET  estado = 'invalida' where codfacturav = " & dtfacturav.Rows(0).Item(0))

            Me.botimprimir.visible = True

            Me.Close()
        Catch ex As Exception
            MsgBox("Ocurrio el siguiente error: " & ex.Message)
        End Try
      

    End Sub

    'Private Sub imprimir1()
    '    ' ejemplo simple para imprimir en .NET
    '    ' Usamos una clase del tipo PrintDocument
    '    Dim printDoc As New PrintDocument
    '    'Dim TamañoPersonal As New Printing.PaperSize("Prueba", 650, 425)
    '    Dim TamañoPersonal As New Printing.PaperSize("Prueba", 800, 850)


    '    printDoc.DefaultPageSettings.PaperSize = TamañoPersonal
    '    ' asignamos el método de evento para cada página a imprimir
    '    AddHandler printDoc.PrintPage, AddressOf print_PrintPage
    '    ' indicamos que queremos imprimir

    '    printDoc.Print()
    'End Sub

    'Private Sub print_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)

    '    Dim dtfacturaventa As DataTable
    '    Dim tfacturaventa As New clsMaestros(clsNomTab.eTbl.FacturaVenta)

    '    Dim dtdetallefacturaventa As DataTable
    '    Dim tdetallefacturaventa As New clsMaestros(clsNomTab.eTbl.DetalleFacturaV)

    '    Dim dtcliente As DataTable
    '    Dim tcliente As New clsMaestros(clsNomTab.eTbl.clientescf)

    '    Dim dtproducto As DataTable
    '    Dim tproducto As New clsMaestros(clsNomTab.eTbl.Productos)



    '    dtfacturaventa = tfacturaventa.Consultar(" where codfacturav = " & Me.codfactura)
    '    dtdetallefacturaventa = tdetallefacturaventa.Consultar(" where codfacturav = " & Me.codfactura)
    '    dtcliente = tcliente.Consultar(" where idclientescf = " & dtfacturaventa.Rows(0).Item(3))



    '    ' Este evento se producirá cada vez que se imprima una nueva página
    '    ' imprimir HOLA MUNDO en Arial tamaño 24 y negrita

    '    ' imprimimos la cadena en el margen izquierdo
    '    Dim xPos As Single = e.MarginBounds.Left
    '    ' La fuente a usar
    '    Dim prFont As New Font("Arial", 9, FontStyle.Italic)
    '    Dim prFontletras As New Font("Arial", 9, FontStyle.Italic)
    '    Dim prFontletrasabajo As New Font("Arial", 8, FontStyle.Italic)
    '    ' la posición superior
    '    Dim yPos As Single = prFont.GetHeight(e.Graphics)

    '    'para matener el primer xPos para las sumas
    '    Dim sumasxpos As Integer
    '    Dim sumasypos As Integer



    '    'para el cliente
    '    yPos += 120
    '    xPos += 153


    '    'para la fecha

    '    Dim fecha As Date = CDate(dtfacturaventa.Rows(0).Item(4))

    '    e.Graphics.DrawString(fecha.Day, prFont, Brushes.Black, xPos, yPos)
    '    xPos += 37

    '    e.Graphics.DrawString(fecha.Month, prFont, Brushes.Black, xPos, yPos)
    '    xPos += 37
    '    e.Graphics.DrawString(fecha.Year, prFont, Brushes.Black, xPos, yPos)

    '    yPos += 22
    '    xPos = 145



    '    e.Graphics.DrawString(dtcliente.Rows(0).Item(1), prFont, Brushes.Black, xPos, yPos)

    '    ''para la direccion
    '    'yPos += 27
    '    'xPos -= 380
    '    'e.Graphics.DrawString(" ", prFont, Brushes.Black, xPos, yPos)

    '    ''para el nit o dui
    '    'xPos += 380
    '    'e.Graphics.DrawString(" ", prFont, Brushes.Black, xPos, yPos)

    '    'para cant super
    '    xPos -= 45
    '    yPos += 85
    '    sumasxpos = xPos
    '    sumasypos = yPos
    '    Dim strp As String
    '    Dim caramax As Short = 0

    '    For i As Integer = 0 To dtdetallefacturaventa.Rows.Count - 1
    '        Dim tem As Short = dtdetallefacturaventa.Rows(i).Item(7).ToString.Length
    '        If tem >= caramax Then
    '            caramax = tem
    '        End If
    '    Next

    '    For i As Integer = 0 To dtdetallefacturaventa.Rows.Count - 1

    '        ' Create a StringFormat object with the each line of text, and the block
    '        ' of text centered on the page.
    '        Dim stringFormat As New StringFormat()
    '        stringFormat.Alignment = StringAlignment.Far


    '        ' Draw the text and the surrounding rectangle.



    '        'para la cantidad
    '        xPos += 20
    '        e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(3), prFont, Brushes.Black, xPos, yPos, stringFormat)

    '        'para el nombre o descripcion del produco
    '        xPos += 10
    '        dtproducto = tproducto.Consultar(" where codproducto = '" & dtdetallefacturaventa.Rows(i).Item(2) & "'")
    '        strp = dtproducto.Rows(0).Item(1).ToString

    '        If strp.Length > 25 Then
    '            strp = strp.Substring(0, 25)
    '        End If




    '        e.Graphics.DrawString(strp, prFont, Brushes.Black, xPos, yPos)

    '        'para el precio unitario
    '        xPos += 195
    '        e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(9), prFont, Brushes.Black, xPos, yPos, stringFormat)

    '        'para las ventas gravadas
    '        xPos += 122


    '        e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(7), prFont, Brushes.Black, xPos, yPos, stringFormat)


    '        yPos += 23
    '        xPos -= 347
    '    Next

    '    'yPos += 115



    '    'para las sumas
    '    xPos = sumasxpos
    '    yPos = sumasypos
    '    xPos += 315
    '    yPos += 247

    '    e.Graphics.DrawString(dtfacturaventa.Rows(0).Item(5).ToString, prFont, Brushes.Black, xPos, yPos)


    '    'para los totales
    '    yPos += 70
    '    e.Graphics.DrawString(dtfacturaventa.Rows(0).Item(10).ToString, prFont, Brushes.Black, xPos, yPos)





    '    ' para las numeros letras son


    '    Dim numletras1 As New NumeroLetras
    '    Dim nl As String
    '    numletras1.setnumero(dtfacturaventa.Rows(0).Item(10).ToString)
    '    nl = numletras1.getnumero().ToString & " dolares "

    '    If numletras1.getdecimal() > 0 Then
    '        Dim nn As String
    '        If numletras1.getdecimal() < 11 Then
    '            nn = numletras1.getdecimal() & "0"

    '            nl = nl & "con " & nn & "/100 cent"
    '        Else
    '            nl = nl & "con " & numletras1.getdecimal.ToString & "/100 cent"
    '        End If


    '    Else
    '        nl = nl & " con 00/100 cent"
    '    End If

    '    xPos -= 330
    '    yPos -= 55

    '    e.Graphics.DrawString(nl, prFontletrasabajo, Brushes.Black, xPos, yPos)


    '    '' indicamos que ya no hay nada más que imprimir

    '    e.HasMorePages = False



    'End Sub

    Private Sub imprimir1()
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




    Private Sub imprimir2()
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

        Dim tcliente1 As New clsMaestros(clsNomTab.eTbl.clientescf)

        Dim dtproducto As DataTable
        Dim tproducto As New clsMaestros(clsNomTab.eTbl.Productos)



        dtfacturaventa = tfacturaventa.Consultar(" where codfacturav = " & Me.codfactura)
        dtdetallefacturaventa = tdetallefacturaventa.Consultar(" where codfacturav = " & Me.codfactura)
        Try
            dtcliente = tcliente.Consultar(" where codcliente = " & dtfacturaventa.Rows(0).Item(3))
            Dim nc As String = dtcliente.Rows(0).Item(1)
        Catch ex As Exception
            dtcliente = tcliente1.Consultar(" where idclientescf = " & dtfacturaventa.Rows(0).Item(3))
            Dim nc As String = dtcliente.Rows(0).Item(1)
        End Try



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

        yPos += 120
        xPos -= 5

        'para el cliente
        e.Graphics.DrawString(dtcliente.Rows(0).Item(1), prFont, Brushes.Black, xPos, yPos)









        yPos += 38
        xPos += 5

        Dim seguiry As Single = yPos
        Dim seguirx As Single = xPos

        'para la direccion
        xPos += 10
        e.Graphics.DrawString(dtcliente.Rows(0).Item(5), prFontletras, Brushes.Black, xPos, yPos)

        'para el municipio
        yPos += 17

        e.Graphics.DrawString(dtcliente.Rows(0).Item(10), prFontletras, Brushes.Black, xPos, yPos)
        'para el departamento
        yPos += 17
        xPos += 30

        e.Graphics.DrawString(dtcliente.Rows(0).Item(11), prFontletras, Brushes.Black, xPos, yPos)

        xPos = seguirx
        yPos = seguiry

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





    Private Sub botimprimir_Click(sender As Object, e As EventArgs)
        If dtfacturav.Rows(0).Item(2).ToString = "Factura" Then
            imprimir1()
        Else
            imprimir2()
        End If
    End Sub


    Private Sub botimprimir2_Click(sender As Object, e As EventArgs)
        If MsgBox("Esta seguro que desea imprimir", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
            If dtfacturav.Rows(0).Item(2).ToString = "Factura" Then
                imprimir1()
            Else
                imprimir2()
            End If
        End If

    End Sub

  
    Private Sub boteliminar_Click(sender As Object, e As EventArgs) Handles boteliminar.Click
        Try
            If MsgBox("Esta seguro de eliminar esta venta? ", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                If MsgBox("La venta se va a eliminar", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                    If MsgBox("Si continua no podran revertirse los cambios", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                        dtdetallefacturav = tdetallefacturav.Consultar(" where codfacturav = " & codfactura)
                        Dim dtproducto As DataTable
                        Dim consultar As New clsProcesos
                        'Cuando todo ha salido bien hace los cargos a las existencias

                        Dim c As Double = 0

                        For i As Integer = 0 To dtdetallefacturav.Rows.Count - 1
                            dtproducto = tproductos.Consultar(" where codproducto = '" + dtdetallefacturav.Rows(i).Item(2).ToString + "'")
                            c = CDbl(CDbl(dtproducto.Rows(0).Item(6)) + dtdetallefacturav.Rows(i).Item(3))
                            consultar.Consultar(" update productos set existencias = " + c.ToString + " where codproducto = '" + dtdetallefacturav.Rows(i).Item(2).ToString + "'")
                        Next

                        consultar.Consultar(" delete from detalleventa where codfacturav = " & codfactura)

                        consultar.Consultar(" delete from facturaventa where codfacturav = " & codfactura)

                        If factura Then
                            consultar.Consultar(" update tirajes set tirajefa = " & CInt(CInt(Me.texnumfactura.Text)).ToString)
                        Else
                            consultar.Consultar(" update tirajes set tirajeca = " & CInt(CInt(Me.texnumfactura.Text)).ToString)
                        End If

                        MsgBox("La venta fue eliminada exitosamente ", MsgBoxStyle.Information, "EXITO")
                    End If

                End If

            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error al eliminar la venta, razon:" & ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try


       
    End Sub


    Public Sub soloanular()
        Try

            dtdetallefacturav = tdetallefacturav.Consultar(" where codfacturav = " & codfactura)
            Dim dtproducto As DataTable
            Dim consultar As New clsProcesos
            'Cuando todo ha salido bien hace los cargos a las existencias

            Dim c As Double = 0

            For i As Integer = 0 To dtdetallefacturav.Rows.Count - 1
                dtproducto = tproductos.Consultar(" where codproducto = '" + dtdetallefacturav.Rows(i).Item(2).ToString + "'")
                c = CDbl(CDbl(dtproducto.Rows(0).Item(6)) + dtdetallefacturav.Rows(i).Item(3))
                consultar.Consultar(" update productos set existencias = " + c.ToString + " where codproducto = '" + dtdetallefacturav.Rows(i).Item(2).ToString + "'")
            Next

            consultar.Consultar("   UPDATE facturaventa SET  estado = 'invalida' where codfacturav = " & idfactura)


            MsgBox("La venta fue anulada exitosamente ", MsgBoxStyle.Information, "EXITO")

        Catch ex As Exception
            MsgBox("Ocurrio un error al anular la venta, razon:" & ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub
    Private Sub botanular_Click(sender As Object, e As EventArgs) Handles botanular.Click
        Servitec.AnularDocumento.forma = Me
        Servitec.AnularDocumento.Show()
    End Sub

    Private Sub botpagar_Click(sender As Object, e As EventArgs) Handles botpagar.Click
        If botpagar.Text <> "Cancelado" Then
            Try
                If MsgBox("Esta seguro de efectuar esta acción", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                    Try

                        Dim consulta As New clsProcesos
                        Dim dtfv As DataTable = tfacturav.Consultar(" where codfacturav = " & Me.idfactura)
                        Dim saldo As Decimal = CDec(Me.texsaldo.Text) 'Esto va a ir a caja

                        consulta.Consultar(" update facturaventa set  descuento = " & dtfv.Rows(0).Item(10) & " where codfacturav = " & idfactura)
                        Me.botpagar.Visible = False

                        cargarfacturac()
                        MsgBox("La deuda se cancelo efectivamente", MsgBoxStyle.Information, "Exito")

                    Catch ex As Exception
                        MsgBox("Ocurrio un error razon: " & ex.Message, MsgBoxStyle.Critical, "EROR")
                    End Try

                End If
            Catch ex As Exception
                MsgBox("Ocurrio el siguiente error: " & ex.Message)
            End Try

        End If
       
    End Sub

    Private Sub botimprimir_Click_1(sender As Object, e As EventArgs) Handles botimprimir.Click
        If Me.textipo.Text.ToString = "Factura" Then
            If MsgBox("Esta seguro de imprimir la factura? ", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                imprimir1()
            End If
        ElseIf Me.textipo.Text.ToString = "Comprobante de Credito fiscal" Then
            If MsgBox("Esta seguro de imprimir el comprobante de credito fiscal? ", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                imprimir2()
            End If
        Else
            If MsgBox("Esta seguro de imprimir la nota de credito? ", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                imprimir3()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim f, a, m, d As String
            Dim fec As Date = Me.texfecha.Text


            a = fec.Year
            m = fec.Month
            d = fec.Day

            f = a + "-" + m + "-" + d
            Dim mf As New clsProcesos
            mf.Ejecutar("update facturaventa set fecha = '" & f & "' where codfacturav = " & codfactura)
            MsgBox("La fecha se actualizo con exito", MsgBoxStyle.Information, "Exito")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub botabonar_Click(sender As Object, e As EventArgs) Handles botabonar.Click
        Dim abono As Decimal = CDec(Me.texabonar.Text)
        Dim consulta As New clsProcesos
        Try
            If MsgBox("Esta seguro de abonar " & Me.texabonar.Text & " a la deuda", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim dtfv As DataTable = tfacturav.Consultar(" where codfacturav = " & Me.idfactura)

                Dim abonar As Decimal = CDec(Me.texabonar.Text)
                Dim deuda As Decimal = CDec(dtfv.Rows(0).Item(6))

                Dim tabonar As Decimal = deuda + abonar

                consulta.Consultar(" update facturaventa set  descuento = " & tabonar & " where codfacturav = " & idfactura)
                Me.botpagar.Visible = False
                cargarfacturac()
                MsgBox("Se abono a la deuda exitosamente", MsgBoxStyle.Information, "Exito")
            End If
        Catch ex As Exception
            MsgBox("Ocurrio el siguiente error: " & ex.Message)
        End Try
    End Sub


    Private Sub botcambiarvence_Click(sender As Object, e As EventArgs) Handles botcambiarvence.Click

        Try
            Dim f, a, m, d As String
            Dim fec As Date = Me.texfechavence.Text


            a = fec.Year
            m = fec.Month
            d = fec.Day

            f = a + "-" + m + "-" + d
            Dim mf As New clsProcesos
            mf.Ejecutar("update facturaventa set fechavence = '" & f & "' where codfacturav = " & idfactura)
            MsgBox("La fecha se actualizo con exito", MsgBoxStyle.Information, "Exito")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub imprimir3()
        ' ejemplo simple para imprimir en .NET
        ' Usamos una clase del tipo PrintDocument
        Dim printDoc As New PrintDocument
        'Dim TamañoPersonal As New Printing.PaperSize("Prueba", 650, 425)
        Dim TamañoPersonal As New Printing.PaperSize("Prueba", 800, 1500)


        printDoc.DefaultPageSettings.PaperSize = TamañoPersonal
        ' asignamos el método de evento para cada página a imprimir
        AddHandler printDoc.PrintPage, AddressOf print_PrintPage3
        ' indicamos que queremos imprimir

        printDoc.Print()
    End Sub

    Private Sub print_PrintPage3(ByVal sender As Object, ByVal e As PrintPageEventArgs)

        Dim dtfacturaventa As DataTable
        Dim tfacturaventa As New clsMaestros(clsNomTab.eTbl.FacturaVenta)

        Dim dtdetallefacturaventa As DataTable
        Dim tdetallefacturaventa As New clsMaestros(clsNomTab.eTbl.DetalleFacturaV)

        Dim dtcliente As DataTable
        Dim tcliente As New clsMaestros(clsNomTab.eTbl.clientescf)
        Dim tcliente1 As New clsMaestros(clsNomTab.eTbl.Clientes)

        Dim dtproducto As DataTable
        Dim tproducto As New clsMaestros(clsNomTab.eTbl.Productos)



        dtfacturaventa = tfacturaventa.Consultar(" where codfacturav = " & Me.codfactura)
        dtdetallefacturaventa = tdetallefacturaventa.Consultar(" where codfacturav = " & Me.codfactura)


        Try
            dtcliente = tcliente.Consultar(" where idclientescf = " & dtfacturaventa.Rows(0).Item(3))
            Dim nc As String = dtcliente.Rows(0).Item(1)
        Catch ex As Exception
            dtcliente = tcliente1.Consultar(" where codcliente = " & dtfacturaventa.Rows(0).Item(3))
            Dim nc As String = dtcliente.Rows(0).Item(1)
        End Try



        ' Este evento se producirá cada vez que se imprima una nueva página
        ' imprimir HOLA MUNDO en Arial tamaño 24 y negrita

        ' imprimimos la cadena en el margen izquierdo
        Dim xPos As Single = e.MarginBounds.Left
        ' La fuente a usar
        Dim prFont As New Font("Arial", 11, FontStyle.Italic)
        Dim prFontletras As New Font("Arial", 9, FontStyle.Italic)
        Dim prFontletrasabajo As New Font("Arial", 8, FontStyle.Italic)
        ' la posición superior
        Dim yPos As Single = prFont.GetHeight(e.Graphics)

        'para matener el primer xPos para las sumas
        Dim sumasxpos As Integer
        Dim sumasypos As Integer



        'para el cliente
        yPos += 88
        xPos += 90


        'para la fecha

        Dim fecha As Date = CDate(dtfacturaventa.Rows(0).Item(4))

        'e.Graphics.DrawString(fecha.Day, prFont, Brushes.Black, xPos, yPos)
        'xPos += 37

        'e.Graphics.DrawString(fecha.Month, prFont, Brushes.Black, xPos, yPos)
        'xPos += 37
        'e.Graphics.DrawString(fecha.Year, prFont, Brushes.Black, xPos, yPos)'

        yPos += 90
        xPos -= 100




        e.Graphics.DrawString(dtcliente.Rows(0).Item(1), prFont, Brushes.Black, xPos, yPos)


        xPos += 515
        yPos += 67



        'para la fecha 
        e.Graphics.DrawString(fecha.Day & " / " & fecha.Month & " / " & fecha.Year, prFont, Brushes.Black, xPos, yPos)




        xPos -= 595
        yPos += 73



        sumasxpos = xPos
        sumasypos = yPos
        Dim strp As String
        Dim caramax As Short = 0

        'For i As Integer = 0 To dtdetallefacturaventa.Rows.Count - 1
        '    Dim tem As Short = dtdetallefacturaventa.Rows(i).Item(7).ToString.Length
        '    If tem >= caramax Then
        '        caramax = tem
        '    End If
        'Next

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

            If strp.Length > 33 Then
                strp = strp.Substring(0, 33)
            End If




            e.Graphics.DrawString(strp, prFont, Brushes.Black, xPos, yPos)


            'para la cantidad
            xPos += 515
            e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(3), prFont, Brushes.Black, xPos, yPos, stringFormat)


            yPos += 26
            xPos -= 525
        Next







        ' indicamos que ya no hay nada más que imprimir

        e.HasMorePages = False



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
          
            Dim mf As New clsProcesos
            mf.Ejecutar("update facturaventa set numfacturav = '" & Me.texnumfactura.Text.ToString & "' where codfacturav = " & codfactura)
            MsgBox("El numero se actualizo con exito", MsgBoxStyle.Information, "Exito")
        Catch ex As Exception

        End Try
    End Sub
End Class