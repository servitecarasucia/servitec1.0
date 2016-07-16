Imports logica
Public Class DetalledelaCompra

    Private tfacturac As New clsMaestros(clsNomTab.eTbl.FacturaCompra)
    Public dtfacturac As DataTable
    Private tdetallefacturac As New clsMaestros(clsNomTab.eTbl.DetalleFacturaC)
    Public dtdetallefacturac As DataTable
    Private tproveedores As New clsMaestros(clsNomTab.eTbl.Proveedores)
    Public dtproveedores As DataTable
    Private tproductos As New clsMaestros(clsNomTab.eTbl.Productos)
    Public dtproductos As DataTable
    Public frmcr As Compras_realizadas
    Public tipof As String
  
    Public modi As Boolean = False
    Public donde As String = "here"
    Public idcompra As String

    Private Sub DetalledelaCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = mdiMain
        hacerconsulta()
        cargarfacturac()



    End Sub


    Private Sub hacerconsulta()
        Try
           
            dtfacturac = tfacturac.Consultar(" where codfacturac = " & idcompra)

        Catch ex As Exception
            MsgBox("Ocurrio un error en la consulta", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub

    Public Sub cargarfacturac()

        Try
            If modi = True Then
                hacerconsulta()
            End If
            dtproveedores = tproveedores.Consultar(" where codproveedor = '" + dtfacturac.Rows(0).Item(3).ToString & "'")
            Me.texnumfact.Text = dtfacturac.Rows(0).Item(1)
            Me.texnit.Text = dtproveedores.Rows(0).Item(2)
            Me.texnrc.Text = dtproveedores.Rows(0).Item(3)
            Me.texproveedor.Text = dtproveedores.Rows(0).Item(1)

            Me.texformapago.Text = dtfacturac.Rows(0).Item(11)
            Me.textipo.Text = dtfacturac.Rows(0).Item(2)

            Me.textfecha.Text = dtfacturac.Rows(0).Item(4)
            Me.texfechavence.Text = dtfacturac.Rows(0).Item(15)


            Me.texsumas.Text = dtfacturac.Rows(0).Item(5)
            Me.texiva.Text = dtfacturac.Rows(0).Item(7)
            Me.texivauno.Text = dtfacturac.Rows(0).Item(12)
            Me.textotal.Text = dtfacturac.Rows(0).Item(10)

            If dtfacturac.Rows(0).Item(11).ToString = "Credito" Then

                If dtfacturac.Rows(0).Item(6).ToString = dtfacturac.Rows(0).Item(10).ToString Then
                    Me.botpagar.Text = "Cancelado"
                    Me.botpagar.BackColor = Color.Green
                    Me.botpagar.Visible = True
                    Me.texabonar.Visible = False
                    Me.botabonar.Visible = False
                    Me.texsaldo.Visible = False
                Else
                    Me.botpagar.Text = "Pagar"
                    Me.botpagar.BackColor = Color.Orange
                    Me.botpagar.Visible = True
                    Me.texabonar.Visible = True
                    Me.botabonar.Visible = True
                    Me.texsaldo.Visible = True
                    Me.texsaldo.Text = CDec(CDec(dtfacturac.Rows(0).Item(10).ToString) - CDec(dtfacturac.Rows(0).Item(6).ToString))
                End If
            Else
                Me.botpagar.Visible = False

            End If
          

            cargargrid()

            If CDbl(Me.textotal.Text.ToString) <> 0 Then
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
            End If


        Catch ex As Exception
            MsgBox("Ocurrio un error al cargar los datos" + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub


    Private Sub cargargrid()
        Try
            dtdetallefacturac = tdetallefacturac.Consultar(" where codfacturac = '" + dtfacturac.Rows(0).Item(0).ToString + "'")
            Dim nf As Short
            nf = dtdetallefacturac.Rows.Count


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

            For i As Integer = 0 To dtdetallefacturac.Rows.Count - 1
                dtproductos = tproductos.Consultar(" where codproducto = '" + dtdetallefacturac.Rows(i).Item(2).ToString & "'")
                Me.gridcompra.Rows(i).Cells(0).Value = dtproductos.Rows(0).Item(0)
                Me.gridcompra.Rows(i).Cells(1).Value = dtdetallefacturac.Rows(i).Item(3)
                Me.gridcompra.Rows(i).Cells(2).Value = dtproductos.Rows(0).Item(1)
                Me.gridcompra.Rows(i).Cells(3).Value = dtdetallefacturac.Rows(i).Item(9)
                Me.gridcompra.Rows(i).Cells(4).Value = "0"
                Me.gridcompra.Rows(i).Cells(5).Value = "0"
                Me.gridcompra.Rows(i).Cells(6).Value = dtdetallefacturac.Rows(i).Item(7)
            Next
        Catch ex As Exception

        End Try

    End Sub






    Private Sub botguardar_Click(sender As Object, e As EventArgs) Handles botguardar.Click

        salirdetalle()
    End Sub

    Private Sub salirdetalle()

        Me.Close()
    End Sub

    Private Sub boteditar_Click(sender As Object, e As EventArgs) Handles boteditar.Click
        compra.codfacturac = idcompra
        compra.donde = "detallecompra"
        Me.donde = "compras"
        compra.estado = "editando"
        compra.Show()
        Me.Close()

    End Sub

 

    Private Sub boteliminar_Click(sender As Object, e As EventArgs) Handles boteliminar.Click
        Try

            If MsgBox("Esta seguro de eliminar este Documento? la accion no podra ser revertida", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                Dim facturacompras As New clsMaestros(clsNomTab.eTbl.FacturaCompra)
                Dim dtdetallefacturacompra As DataTable
                Dim detallefacturacompra As New clsMaestros(clsNomTab.eTbl.DetalleFacturaC)
                Dim dtproducto As DataTable
                Dim consultar As New clsProcesos

                'MsgBox(dtfacturac.Rows(contador).Item(0).ToString)
                dtdetallefacturacompra = detallefacturacompra.Consultar(" where codfacturac = '" + dtfacturac.Rows(0).Item(0).ToString + "'")

                Dim c As Double = 0
                For i As Integer = 0 To dtdetallefacturacompra.Rows.Count - 1
                    dtproducto = tproductos.Consultar(" where codproducto = '" + dtdetallefacturacompra.Rows(i).Item(2).ToString + "'")
                    c = CDbl(CDbl(dtproducto.Rows(0).Item(6)) - dtdetallefacturacompra.Rows(i).Item(3))
                    consultar.Consultar(" update productos set existencias = " + c.ToString + " where codproducto = '" + dtdetallefacturacompra.Rows(i).Item(2).ToString + "'")

                Next
                consultar.Consultar(" delete from detallecompra where codfacturac = '" & dtfacturac.Rows(0).Item(0) & "'")
                consultar.Consultar(" delete from facturacompra where codfacturac = " & dtfacturac.Rows(0).Item(0))
                salirdetalle()

                MsgBox("La factura se elimino exitozamente", MsgBoxStyle.Information, "Exito")
            End If
           

        Catch ex As Exception
            MsgBox("Ocurrio un error al eliminar la factura razon: " & ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles botpagar.Click
        If botpagar.Text <> "Cancelado" Then
            If MsgBox("Esta seguro de efectuar esta acción", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                Try
                    Dim codigofactura As String = dtfacturac.Rows(0).Item(0).ToString
                    Dim consulta As New clsProcesos

                    consulta.Consultar(" update facturacompra set descuento = " & CDec(Me.textotal.Text) & " where codfacturac = " & idcompra)
                    Me.botpagar.Visible = False
                    hacerconsulta()
                    cargarfacturac()
                    MsgBox("La deuda se cancelo efectivamente", MsgBoxStyle.Information, "Exito")

                Catch ex As Exception
                    MsgBox("Ocurrio un error razon: " & ex.Message, MsgBoxStyle.Critical, "EROR")
                End Try

            End If
        End If
       

    End Sub

    Private Sub botabonar_Click(sender As Object, e As EventArgs) Handles botabonar.Click
        Dim abono As Decimal = CDec(Me.texabonar.Text)
        Dim consulta As New clsProcesos
        Try
            If MsgBox("Esta seguro de abonar " & Me.texabonar.Text & " a la deuda", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim dtfc As DataTable = tfacturac.Consultar(" where codfacturac = " & Me.idcompra)

                Dim abonar As Decimal = CDec(Me.texabonar.Text)
                Dim deuda As Decimal = CDec(dtfc.Rows(0).Item(6))

                Dim tabonar As Decimal = deuda + abonar

                consulta.Consultar(" update facturacompra set  descuento = " & tabonar & " where codfacturac = " & idcompra)
                Me.botpagar.Visible = False
                hacerconsulta()
                cargarfacturac()
                MsgBox("Se abono a la deuda exitosamente", MsgBoxStyle.Information, "Exito")
            End If
        Catch ex As Exception
            MsgBox("Ocurrio el siguiente error: " & ex.Message)
        End Try
    End Sub

    Private Sub botcambiaremision_Click(sender As Object, e As EventArgs) Handles botcambiaremision.Click
        Try
            Dim f, a, m, d As String
            Dim fec As Date = Me.textfecha.Text


            a = fec.Year
            m = fec.Month
            d = fec.Day

            f = a + "-" + m + "-" + d
            Dim mf As New clsProcesos
            mf.Ejecutar("update facturacompra set fecha = '" & f & "' where codfacturac = " & idcompra)
            MsgBox("La fecha se actualizo con exito", MsgBoxStyle.Information, "Exito")
        Catch ex As Exception

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
            mf.Ejecutar("update facturacompra set fechalimite = '" & f & "' where codfacturac = " & idcompra)
            MsgBox("La fecha se actualizo con exito", MsgBoxStyle.Information, "Exito")
        Catch ex As Exception

        End Try
    End Sub
End Class