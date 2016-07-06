Imports logica
Public Class VentasCompras
    Private tfacturacompra As New clsMaestros(clsNomTab.eTbl.FacturaCompra)
    Private dtfacturacompra As DataTable

    Private tfacturaventa As New clsMaestros(clsNomTab.eTbl.FacturaVenta)
    Private dtfacturaventa As DataTable

    Private dtdesdeg, dthastag As String

    Private ganancia1, ganancia2 As Decimal



    Private Sub botmostrar_Click(sender As Object, e As EventArgs) Handles botmostrar.Click
        obtenerfecha(dtdesde, dthasta)
        obtenerresultados()
    End Sub

    Private Sub obtenerresultados()
        dtfacturacompra = tfacturacompra.Consultar(" where fecha >='" & dtdesdeg & "' and fecha <='" & dthastag & "'")
        dtfacturaventa = tfacturaventa.Consultar(" where fecha >='" & dtdesdeg & "' and fecha <='" & dthastag & "'")



        Dim comprascontado As Decimal
        Dim comprascretito As Decimal
        Dim ventascontado As Decimal
        Dim ventascredito As Decimal

        Dim deudapagadacompra As Decimal
        Dim deudapagadventa As Decimal
        Dim comision As Decimal
        Dim gas As Decimal


        For i As Integer = 0 To dtfacturacompra.Rows.Count - 1


            If (dtfacturacompra.Rows(i).Item(11).ToString = "Contado") And (dtfacturacompra.Rows(i).Item(2).ToString = "Factura" Or dtfacturacompra.Rows(i).Item(2).ToString = "Comprobante de Credito fiscal") Then
                comprascontado += Math.Round(CDec(dtfacturacompra.Rows(i).Item(10)), 2)
            Else
                If dtfacturacompra.Rows(i).Item(11).ToString <> "Credito" Then
                    gas += Math.Round(CDec(dtfacturacompra.Rows(i).Item(10)), 2)
                End If

            End If

            If dtfacturacompra.Rows(i).Item(11).ToString = "Credito" Then
                comprascretito += Math.Round(CDec(dtfacturacompra.Rows(i).Item(10)), 2)

                deudapagadacompra += Math.Round(CDec(dtfacturacompra.Rows(i).Item(6)), 2)

            End If
        Next

        For i As Integer = 0 To dtfacturaventa.Rows.Count - 1
          
            If dtfacturaventa.Rows(i).Item(11).ToString = "Contado" Then
                ventascontado += Math.Round(CDec(dtfacturaventa.Rows(i).Item(10)), 2)
                comision += Math.Round(CDec(dtfacturaventa.Rows(i).Item(15)), 2)
            End If

            If dtfacturaventa.Rows(i).Item(11).ToString = "Credito" Then
                ventascredito += Math.Round(CDec(dtfacturaventa.Rows(i).Item(10)), 2)

                deudapagadventa += Math.Round(CDec(dtfacturaventa.Rows(i).Item(6)), 2)

            End If
        Next

        texcompras2.Text = "$ " & (comprascontado)
        texcompracreditofecha.Text = "$ " & comprascretito


        texventas2.Text = "$ " & ventascontado
        texventascreditofecha.Text = "$ " & ventascredito
        texsumaventasfecha.Text = "$ " & (ventascontado + ventascredito)

        Me.texventacacelada1.Text = "$ " & deudapagadventa
        Me.texcompracancelada1.Text = "$ " & deudapagadacompra
        Me.texsumacomprasfecha.Text = "$ " & (comprascontado + comprascretito)

        Dim cpc As Decimal = CDec(comprascretito - deudapagadacompra)
        Dim cpv As Decimal = CDec(ventascredito - deudapagadventa)

        Me.texcreditopendientecompra1.Text = cpc
        Me.texcreditopendienteventa1.Text = cpv
        Me.texcomisionrango.Text = comision
        Me.texgastosrango.Text = gas

        Me.textotalcajarango.Text = (deudapagadventa + ventascontado - (comision + gas))

    End Sub

    Private Sub obtenerfecha(ByRef desde As DateTimePicker, ByRef hasta As DateTimePicker)
        dtdesdeg = desde.Value.Year.ToString + "-"
        dtdesdeg += desde.Value.Month.ToString + "-"
        dtdesdeg += desde.Value.Day.ToString

        dthastag = hasta.Value.Year.ToString + "-"
        dthastag += hasta.Value.Month.ToString + "-"
        dthastag += hasta.Value.Day.ToString
    End Sub

    
    Private Sub VentasCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = mdiMain
        obtenerresultadoshoy()

    End Sub

    Private Sub obtenerresultadoshoy()
        Dim hoy As String = Date.Now.Year.ToString + "-" + Date.Now.Month.ToString + "-" + Date.Now.Day.ToString

        Dim ventas As Decimal
        Dim comprascontado As Decimal
        Dim comprascretito As Decimal
        Dim ventascontado As Decimal
        Dim ventascredito As Decimal

        Dim deudapagadacompra As Decimal
        Dim deudapagadventa As Decimal

        Dim comision As Decimal
        Dim gas As Decimal



        dtfacturacompra = tfacturacompra.Consultar(" where fecha ='" & hoy & "'")
        dtfacturaventa = tfacturaventa.Consultar(" where fecha ='" & hoy & "'")

        For i As Integer = 0 To dtfacturacompra.Rows.Count - 1


            If (dtfacturacompra.Rows(i).Item(11).ToString = "Contado") And (dtfacturacompra.Rows(i).Item(2).ToString = "Factura" Or dtfacturacompra.Rows(i).Item(2).ToString = "Comprobante de Credito fiscal") Then
                comprascontado += Math.Round(CDec(dtfacturacompra.Rows(i).Item(10)), 2)
            Else
                If dtfacturacompra.Rows(i).Item(11).ToString <> "Credito" Then
                    gas += Math.Round(CDec(dtfacturacompra.Rows(i).Item(10)), 2)
                End If
            End If

            If dtfacturacompra.Rows(i).Item(11).ToString = "Credito" Then
                comprascretito += Math.Round(CDec(dtfacturacompra.Rows(i).Item(10)), 2)
                If dtfacturacompra.Rows(i).Item(6).ToString = "1" Then
                    deudapagadacompra += Math.Round(CDec(dtfacturacompra.Rows(i).Item(10)), 2)
                End If
            End If

        Next

        For i As Integer = 0 To dtfacturaventa.Rows.Count - 1
            ventas += Math.Round(CDec(dtfacturaventa.Rows(i).Item(10)), 2)

            If dtfacturaventa.Rows(i).Item(11).ToString = "Contado" Then
                ventascontado += Math.Round(CDec(dtfacturaventa.Rows(i).Item(10)), 2)
                comision += Math.Round(CDec(dtfacturaventa.Rows(i).Item(15)), 2)

            End If

            If dtfacturaventa.Rows(i).Item(11).ToString = "Credito" Then
                ventascredito += Math.Round(CDec(dtfacturaventa.Rows(i).Item(10)), 2)

                deudapagadventa += Math.Round(CDec(dtfacturaventa.Rows(i).Item(6)), 2)

            End If

        Next

  

        Me.texsumacompras.Text = "$ " & (comprascontado + comprascretito)
        Me.texsumaventas.Text = "$ " & ventas
        Me.texcompras.Text = "$ " & comprascontado
        Me.texcompracredito.Text = "$ " & comprascretito
        Me.texventascredito.Text = "$ " & ventascredito
        Me.texventas.Text = "$ " & ventascontado

        Me.texventacacelada.Text = "$ " & deudapagadventa
        Me.texcompracancelada.Text = "$ " & deudapagadacompra

        Dim cpc As Decimal = CDec(comprascretito - deudapagadacompra)
        Dim cpv As Decimal = CDec(ventascredito - deudapagadventa)

        Me.texcreditopendientecompra.Text = cpc
        Me.texcreditopendienteventa.Text = cpv

        Me.texcajadiario.Text = (ventascontado - comision - gas) + (deudapagadventa)
        Me.texcomision.Text = comision
        Me.texgastos.Text = gas


    End Sub

  
End Class