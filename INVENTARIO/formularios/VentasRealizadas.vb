Imports logica
Public Class VentasRealizadas

    Private tfacturaventa As New clsMaestros(clsNomTab.eTbl.FacturaVenta)
    Private dtfacturaventa As DataTable
    Private tdetallefacutaventa As New clsMaestros(clsNomTab.eTbl.DetalleFacturaV)
    Private dtdetallefacturaventa As DataTable
    Private tclientes As New clsMaestros(clsNomTab.eTbl.Clientes)
    Private dtclientes As DataTable

    Private tclientescf As New clsMaestros(clsNomTab.eTbl.clientescf)

    Private loadf As Boolean = False
    Private tipof As String

    Public donde As String = "aqui"
    Public generarfactura As GenerarDocumentos


    Private ccf = False, fa = False, nc = False, nd = False, tic = False, otr = False
    Private Sub VentasRealizadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = mdiMain
        If donde = "generar" Then
            Me.botseleccionar.Visible = True
            Me.botnuevo.Visible = False
            Me.botdetalle.Visible = False
            dtfacturaventa = tfacturaventa.Consultar(" where tipo = 'credito' and descuento <> total order by  fecha")
        ElseIf donde = "noti" Then
            loadf = True

            Dim dia As String = System.DateTime.Now.Day.ToString
            Dim mes As String = System.DateTime.Now.Month.ToString
            Dim a As String = System.DateTime.Now.Year

            Dim dian As Integer = CInt(dia) + CInt(7)
            Dim mesn As Integer = mes
            Dim an As Integer = a

            If CInt(dian) > 28 Then
                dian = dian - 28
                If mes = 12 Then
                    mesn = 1
                    an = an + 1
                Else
                    mesn = mes + 1
                End If
            End If
            Dim f As String = a + "-" + mes + "-" + dia.ToString
            Dim f1 As String = an.ToString + "-" + mesn.ToString + "-" + dian.ToString
            dtfacturaventa = tfacturaventa.Consultar(" where tipo = 'credito' and total <> descuento and fechavence >= '" & f & "' and fechavence <= '" & f1 & "' order by  numfacturav")
            tipof = "todos"
        Else
            loadf = True
            Dim dia As String = System.DateTime.Now.Day.ToString
            Dim mes As String = System.DateTime.Now.Month.ToString
            Dim a As String = System.DateTime.Now.Year

            Dim dian As Integer = CInt(dia) - CInt(7)
          
            If CInt(dian) <= 0 Then
                dian = 1
            End If
            Dim f As String = a + "-" + mes + "-" + dian.ToString

            dtfacturaventa = tfacturaventa.Consultar(" where total <> 0 and fecha >= '" & f & "'  order by  numfacturav")
            tipof = "todos"
        End If
        cargarventas()
    End Sub

    Public Sub hacerconsulta()

        If tipof = "todos" Then
            radiotodos()
        ElseIf tipof = "Factura" Then
            radiofacturas()
        Else
            radiocomprobantes()
        End If

       
    End Sub


    Public Sub cargarventas()

        Try

            Dim nf As Short
            nf = dtfacturaventa.Rows.Count

            If nf = 0 Then
                Me.gridfacturaventas.RowCount = 0
                Me.gridfacturaventas.Rows(0).Cells(0).Value = ""
                Me.gridfacturaventas.Rows(0).Cells(1).Value = ""
                Me.gridfacturaventas.Rows(0).Cells(2).Value = ""
                Me.gridfacturaventas.Rows(0).Cells(3).Value = ""
                Me.gridfacturaventas.Rows(0).Cells(4).Value = ""
                Me.gridfacturaventas.Rows(0).Cells(5).Value = ""
                Me.gridfacturaventas.Rows(0).Cells(6).Value = ""
            Else
                Me.gridfacturaventas.RowCount = nf
            End If

            For i As Integer = 0 To dtfacturaventa.Rows.Count - 1

                If i = 100 Then
                    Dim m As String = "nada"

                End If

                Me.gridfacturaventas.Rows(i).Cells(0).Value = dtfacturaventa.Rows(i).Item(1).ToString 'para el codigo de la factura
                Me.gridfacturaventas.Rows(i).Cells(6).Value = dtfacturaventa.Rows(i).Item(0).ToString ' para el codigo
                Me.gridfacturaventas.Rows(i).Cells(7).Value = dtfacturaventa.Rows(i).Item(3).ToString ' para el codigo del cliente


                If dtfacturaventa.Rows(i).Item(2).ToString = "credito" Then
                    If dtfacturaventa.Rows(i).Item(6).ToString = dtfacturaventa.Rows(i).Item(10).ToString Then
                        Me.gridfacturaventas.Rows(i).Cells(5).Style.BackColor = Color.GreenYellow
                    Else
                        Me.gridfacturaventas.Rows(i).Cells(5).Style.BackColor = Color.Orange
                    End If

                End If


                If dtfacturaventa.Rows(i).Item(2).ToString = "Factura" Then
                    dtclientes = tclientescf.Consultar(" where idclientescf = " + dtfacturaventa.Rows(i).Item(3).ToString)
                    If dtclientes.Rows.Count = 0 Then
                        dtclientes = tclientes.Consultar(" where codcliente = '" + dtfacturaventa.Rows(i).Item(3).ToString + "'")
                    End If
                    Me.gridfacturaventas.Rows(i).Cells(5).Style.BackColor = Color.White
                ElseIf dtfacturaventa.Rows(i).Item(2).ToString = "credito" Then
                    Try
                        dtclientes = tclientescf.Consultar(" where idclientescf = " + dtfacturaventa.Rows(i).Item(3).ToString)
                        If dtclientes.Rows.Count = 0 Then
                            dtclientes = tclientes.Consultar(" where codcliente = '" + dtfacturaventa.Rows(i).Item(3).ToString + "'")
                        End If
                    Catch ex As Exception


                        



                        dtclientes = tclientes.Consultar(" where codcliente = '" + dtfacturaventa.Rows(i).Item(3).ToString + "'")
                        If dtclientes.Rows.Count = 0 Then
                            dtclientes = tclientes.Consultar(" where codcliente = '" + dtfacturaventa.Rows(i).Item(3).ToString + "'")
                        Else
                            If dtclientes.Rows(0).Item(9) = "inactivo" Then
                                Me.gridfacturaventas.Rows(i).Cells(1).Style.BackColor = Color.Red
                            Else
                                Me.gridfacturaventas.Rows(i).Cells(1).Style.BackColor = Color.White
                            End If
                        End If
                    End Try
                Else
                    dtclientes = tclientes.Consultar(" where codcliente = '" + dtfacturaventa.Rows(i).Item(3).ToString + "'")
                    If dtclientes.Rows.Count = 0 Then
                        dtclientes = tclientescf.Consultar(" where idclientescf = " + dtfacturaventa.Rows(i).Item(3).ToString)
                    Else
                        If dtclientes.Rows(0).Item(9) = "inactivo" Then
                            Me.gridfacturaventas.Rows(i).Cells(1).Style.BackColor = Color.Red
                        Else
                            Me.gridfacturaventas.Rows(i).Cells(1).Style.BackColor = Color.White
                        End If
                    End If

                End If
                Me.gridfacturaventas.Rows(0).Cells(0).Selected = True


                Me.gridfacturaventas.Rows(i).Cells(1).Value = dtclientes.Rows(0).Item(1) ' para el nombre de la factura
                Me.gridfacturaventas.Rows(i).Cells(2).Value = dtfacturaventa.Rows(i).Item(2).ToString ' para el tipo de la factura
                Dim s As Date = dtfacturaventa.Rows(i).Item(4)
                Me.gridfacturaventas.Rows(i).Cells(3).Value = s.Day.ToString + "/" + s.Month.ToString + "/" + s.Year.ToString 'para la fecha
                Dim s1 As Date = dtfacturaventa.Rows(i).Item(14)
                Me.gridfacturaventas.Rows(i).Cells(4).Value = s1.Day.ToString + "/" + s1.Month.ToString + "/" + s1.Year.ToString 'para la fecha

                Me.gridfacturaventas.Rows(i).Cells(5).Value = FormatNumber(CDbl(dtfacturaventa.Rows(i).Item(10)), 2) ' para el total

              

                If dtfacturaventa.Rows(i).Item(12).ToString = "invalida" Then
                    Me.gridfacturaventas.Rows(i).Cells(5).Style.BackColor = Color.Red

                End If


            Next
        Catch ex As Exception

        End Try
    End Sub


    Private Sub radiofactura_CheckedChanged(sender As Object, e As EventArgs)
        radiofacturas()
    End Sub

    Private Sub radiocomprobante_CheckedChanged(sender As Object, e As EventArgs)
        radiocomprobantes()
    End Sub

    Private Sub radiotodo_CheckedChanged(sender As Object, e As EventArgs) Handles radiotodo.CheckedChanged
        radiotodos()
    End Sub

    Private Sub radiocomprobantes()
        Try
            Dim dia As String = System.DateTime.Now.Day.ToString
            Dim mes As String = System.DateTime.Now.Month.ToString
            Dim a As String = System.DateTime.Now.Year

            Dim dian As Integer = CInt(dia) - CInt(7)
            If CInt(dian) <= 0 Then
                dian = 1
            End If
            Dim f As String = a + "-" + mes + "-" + dian.ToString
            dtfacturaventa = tfacturaventa.Consultar(" where total <> 0 and fecha >= '" & f & "' and tipo = 'Comprobante de Credito fiscal' order by  numfacturav")

            tipof = "Comprobante de Credito fiscal"
            cargarventas()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub radiofacturas()
        Try
            Dim dia As String = System.DateTime.Now.Day.ToString
            Dim mes As String = System.DateTime.Now.Month.ToString
            Dim a As String = System.DateTime.Now.Year

            Dim dian As Integer = CInt(dia) - CInt(7)
            If CInt(dian) <= 0 Then
                dian = 1
            End If
            Dim f As String = a + "-" + mes + "-" + dian.ToString
            dtfacturaventa = tfacturaventa.Consultar(" where total <> 0 and fecha >= '" & f & "' and tipo = 'Factura' order by  numfacturav")

            tipof = "Factura"
            cargarventas()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub radiotodos()
        If loadf = True Then
            Dim dia As String = System.DateTime.Now.Day.ToString
            Dim mes As String = System.DateTime.Now.Month.ToString
            Dim a As String = System.DateTime.Now.Year

            Dim dian As Integer = CInt(dia) - CInt(7)
            If CInt(dian) <= 0 Then
                dian = 1
            End If
            Dim f As String = a + "-" + mes + "-" + dian.ToString
            dtfacturaventa = tfacturaventa.Consultar(" where total <> 0 and fecha >= '" & f & "' order by  numfacturav")

            tipof = "todos"
            cargarventas()
        End If
    End Sub

    Dim varbus As String
    Dim fl As Boolean = True
    Private Sub texbusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texbusqueda.KeyPress
        Try
            fl = False
            Me.radiotodo.Checked = True
            If (Asc(e.KeyChar) = 13) Then
            Else
                If (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then
                    Dim contvarbus As Short

                    If varbus.Length = 0 Then
                    Else
                        contvarbus = varbus.Length
                        If varbus.Length = 1 Then
                            varbus = varbus.Remove(contvarbus - 1, 1)
                        Else
                            varbus = varbus.Remove(contvarbus - 1, 1)

                            dtclientes = tclientes.Consultar(" where nombre like '%" + varbus + "%'  ")
                            If dtclientes.Rows.Count = 0 Then
                                dtfacturaventa = tfacturaventa.Consultar(" where tipo like '%" & varbus & "%' or formadepago like '%" & varbus & "%'  or numfacturav like '%" & varbus & "%'")
                            Else
                                dtfacturaventa = tfacturaventa.Consultar(" where tipo like '%" & varbus & "%' or formadepago like '%" & varbus & "%'  or numfacturav like '%" & varbus & "%' or codcliente like '%" + dtclientes.Rows(0).Item(0).ToString + "%'")
                            End If

                            If dtfacturaventa.Rows.Count <> 0 Then
                                cargarventas()
                            End If
                        End If

                    End If
                Else

                    varbus += e.KeyChar
                    dtclientes = tclientes.Consultar(" where nombre like '%" + varbus + "%'")
                    If dtclientes.Rows.Count = 0 Then
                        dtfacturaventa = tfacturaventa.Consultar(" where tipo like '%" & varbus & "%' or formadepago like '%" & varbus & "%'  or numfacturav like '%" & varbus & "%'")
                    Else
                        dtfacturaventa = tfacturaventa.Consultar(" where tipo like '%" & varbus & "%' or formadepago like '%" & varbus & "%'  or numfacturav like '%" & varbus & "%' or codcliente like '%" + dtclientes.Rows(0).Item(0).ToString + "%'")
                    End If

                    If dtfacturaventa.Rows.Count <> 0 Then
                        cargarventas()
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
      
    End Sub

    Private Sub botsalir_Click(sender As Object, e As EventArgs) Handles botsalir.Click
        Me.Close()
    End Sub

    Private Sub radiotipo_CheckedChanged(sender As Object, e As EventArgs) Handles radiotipo.CheckedChanged
        If Me.radiotipo.Checked = True Then
            Me.combotipo.Visible = True
        Else
            Me.combotipo.Visible = False
        End If
    End Sub


    Private Sub checfecha_CheckedChanged(sender As Object, e As EventArgs) Handles checfecha.CheckedChanged
        If checfecha.Checked = True Then
            Me.gridfacturaventas.Height = 300
        Else
            Me.gridfacturaventas.Height = 384
        End If
    End Sub

    Private Sub combotipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combotipo.SelectedIndexChanged
        Try
            Select Case Me.combotipo.Text.ToString.Trim
                Case "Factura"
                    fa = True
                    radiofacturas()
                Case "Comprobante de Credito fiscal"
                    ccf = True
                    radiocomprobantes()
                Case "Notas de Credito"
                    dtfacturaventa = tfacturaventa.Consultar(" where tipo = 'credito' ")

                    cargarventas()
                Case "Nota de debito2"
                Case "Tiquet"
                Case "Otros"
            End Select
        Catch ex As Exception

        End Try

    End Sub

    Private Sub botbuscar_Click_1(sender As Object, e As EventArgs) Handles botbuscar.Click
        Try
            Dim d1, m1, a1, d2, a2, m2, f1, f2 As String
            d1 = dt1.Value.Day
            m1 = dt1.Value.Month
            a1 = dt1.Value.Year
            f1 = a1 + "-" + m1 + "-" + d1
            d2 = dt2.Value.Day
            m2 = dt2.Value.Month
            a2 = dt2.Value.Year
            f2 = a2 + "-" + m2 + "-" + d2
            If Me.combotipo.Text = "Factura" Then
                dtfacturaventa = tfacturaventa.Consultar(" where tipo = 'Factura' and total <> 0 and  fecha >= '" + f1 + "' and fecha <= '" + f2 + "'")
                tipof = "Factura"
                cargarventas()
            ElseIf Me.combotipo.Text = "Comprovante de Credito fiscal" Then
                dtfacturaventa = tfacturaventa.Consultar(" where tipo = 'Comprovante de Credito fiscal' and total <> 0 and fecha >='" + f1 + "' and fecha <= '" + f2 + "'")
                tipof = "Comprovante de Credito fiscal"
                cargarventas()
            ElseIf Me.radiotodo.Checked = True Then
                dtfacturaventa = tfacturaventa.Consultar(" where total <> 0 and  fecha >='" + f1 + "' and fecha <= '" + f2 + "'")
                tipof = "todos"
                cargarventas()
            End If
        Catch ex As Exception

        End Try

    End Sub

  
    Private Sub botnuevo_Click_1(sender As Object, e As EventArgs) Handles botnuevo.Click
        Ventas.Show()
        Me.Close()
    End Sub


    Private Sub botdetalle_Click_1(sender As Object, e As EventArgs) Handles botdetalle.Click
        Try

            Dim id As String = Me.gridfacturaventas.Rows(Me.gridfacturaventas.CurrentCell.RowIndex).Cells(6).Value

            DetalleVenta.idfactura = id
           
            DetalleVenta.frmvr = Me
            DetalleVenta.Show()
        Catch ex As Exception

        End Try

    End Sub

  
  

    Private Sub botseleccionar_Click(sender As Object, e As EventArgs) Handles botseleccionar.Click
        Try
            Dim idcredito As String = Me.gridfacturaventas.Rows(Me.gridfacturaventas.CurrentCell.RowIndex).Cells(6).Value
            Dim idclien As String = Me.gridfacturaventas.Rows(Me.gridfacturaventas.CurrentCell.RowIndex).Cells(7).Value
            Dim total As String = Me.gridfacturaventas.Rows(Me.gridfacturaventas.CurrentCell.RowIndex).Cells(5).Value

            generarfactura.idcliente = idclien
            generarfactura.idcredito = idcredito
            generarfactura.total = total

            generarfactura.llenarcliente()
            Me.Close()

        Catch ex As Exception


        End Try
    End Sub
End Class