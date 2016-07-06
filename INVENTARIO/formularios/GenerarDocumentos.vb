Imports logica
Public Class GenerarDocumentos

    Public idcliente As String
    Public idcredito As Short
    Public total As String

    Private dtcredito As DataTable
    Private tcredito As New clsMaestros(clsNomTab.eTbl.FacturaVenta)

    Private dtdetalle As DataTable
    Private tdetalle As New clsMaestros(clsNomTab.eTbl.DetalleFacturaV)

    Private dtproductos As DataTable
    Private tproductos As New clsMaestros(clsNomTab.eTbl.Productos)

    Private dtcliente As DataTable
    Private tcliente As New clsMaestros(clsNomTab.eTbl.Clientes)
    Private tclientesf As New clsMaestros(clsNomTab.eTbl.clientescf)

    



    Dim totalgrid As Short = 0

    Dim factura As Boolean = True 'Para determinar si es factura

    Private Sub TextBox1_DoubleClick(sender As Object, e As EventArgs) Handles texclicredito.DoubleClick
        Dim vrali As New VentasRealizadas
        vrali.generarfactura = Me
        vrali.donde = "generar"
        vrali.Show()
    End Sub


    Private Sub GenerarDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = mdiMain
    End Sub


    Public Sub llenarcliente()

        Try
            dtcliente = tcliente.Consultar(" where codcliente = " & idcliente)
            Me.texcliente.Text = dtcliente.Rows(0).Item(1).ToString
            Me.texclicredito.Text = dtcliente.Rows(0).Item(1).ToString
        Catch ex As Exception
            dtcliente = tclientesf.Consultar(" where idclientescf = " & idcliente)
            Me.texcliente.Text = dtcliente.Rows(0).Item(1).ToString
            Me.texclicredito.Text = dtcliente.Rows(0).Item(1).ToString
        End Try

        Me.textotalcredito.text = Me.total


    End Sub


    Public Sub llenargrid()
        Try

            dtdetalle = tdetalle.Consultar(" where codfacturav = " & idcredito)
            Dim nf As Short = dtdetalle.Rows.Count

            If totalgrid = 0 Then
                Me.gridproductos.RowCount = 18
            End If

            For i As Integer = 0 To 17
                If Me.gridproductos.Rows(i).Cells(0).Value <> Nothing Then
                    totalgrid += 1
                End If

            Next
            Dim fl As Boolean = False
            Dim resta As Integer = 0


            For i As Integer = 0 To dtdetalle.Rows.Count - 1

                For e As Integer = 0 To totalgrid

                    If totalgrid > 0 Then

                        Try
                            If Me.gridproductos.Rows(e).Cells(0).Value <> Nothing Then

                                If Me.gridproductos.Rows(e).Cells(0).Value.ToString = dtdetalle.Rows(i).Item(2).ToString Then
                                    Dim canti As Integer = CInt(Me.gridproductos.Rows(e).Cells(1).Value)
                                    canti += CInt(dtdetalle.Rows(i).Item(3))
                                    gridproductos.Rows(e).Cells(1).Value = canti  'Cantidad 

                                    gridproductos.Rows(e).Cells(3).Value = dtdetalle.Rows(i).Item(9).ToString  ' Precio unitario

                                    Dim total As Decimal = CDec(dtdetalle.Rows(i).Item(9)) * CDec(canti)
                                    gridproductos.Rows(e).Cells(4).Value = total    ' Ventas afectas

                                    fl = True
                                    resta += 1

                                End If

                            End If
                        Catch ex As Exception

                        End Try

                    End If

                Next


                If Not fl Then

                    gridproductos.Rows((totalgrid + i) - resta).Cells(0).Value = dtdetalle.Rows(i).Item(2).ToString ' Codigo
                    gridproductos.Rows((totalgrid + i) - resta).Cells(1).Value = dtdetalle.Rows(i).Item(3).ToString  'Cantidad 
                    dtproductos = tproductos.Consultar(" where codproducto = '" & dtdetalle.Rows(i).Item(2) & "'")
                    gridproductos.Rows((totalgrid + i) - resta).Cells(2).Value = dtproductos.Rows(0).Item(1).ToString ' Nombre
                    gridproductos.Rows((totalgrid + i) - resta).Cells(3).Value = dtdetalle.Rows(i).Item(9).ToString  ' Precio unitario
                    gridproductos.Rows((totalgrid + i) - resta).Cells(4).Value = dtdetalle.Rows(i).Item(7).ToString   ' Ventas afectas
                End If

                fl = False

            Next
            totalgrid = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub botagregar_Click(sender As Object, e As EventArgs) Handles botagregar.Click
        Me.texclicredito.Text = ""
        Me.textotalcredito.Text = ""
        llenargrid()
    End Sub

    Private Sub botgererarfactura_Click(sender As Object, e As EventArgs) Handles botgererarfactura.Click
        Me.factura = True
        Me.textsumas.Text = "0.0"
        Me.textotal.Text = "0.0"
        Me.textiraje.Text = ""
        Me.texcorrelativo.Text = ""
        Me.textiva.Text = "0.0"


        Dim dtcodf As DataTable
        Dim tcodf As New clsProcesos
        Dim tt As New clsProcesos
        Dim dttt As DataTable

        dtcodf = tcodf.Consultar("select max(tirajefa) from tirajes")
        dttt = tt.Consultar("select tirajefs from tirajes")
        Me.textiraje.Text = dttt.Rows(0).Item(0).ToString
        Me.texcorrelativo.Text = dtcodf.Rows(0).Item(0).ToString

        Dim sumas As Decimal = 0
        For i As Integer = 0 To 17

            If chekdescartar.Checked Then

                If gridproductos.Rows(i).Cells(0).Value <> Nothing Then
                    If gridproductos.Rows(i).Cells(5).Value = False Then
                        sumas += CDec(gridproductos.Rows(i).Cells(4).Value)
                    End If

                End If

            Else

                If gridproductos.Rows(i).Cells(0).Value <> Nothing Then

                    If gridproductos.Rows(i).Cells(5).Value = True Then
                        sumas += CDec(gridproductos.Rows(i).Cells(4).Value)
                    End If

                End If

            End If


        Next

        Me.textsumas.Text = sumas
        Me.textotal.Text = sumas

    End Sub

  

    Private Sub botgenerarcomprobante_Click(sender As Object, e As EventArgs) Handles botgenerarcomprobante.Click
        Me.factura = False
        Me.textsumas.Text = "0.0"
        Me.textotal.Text = "0.0"
        Me.textiraje.Text = ""
        Me.texcorrelativo.Text = ""
        Me.textiva.Text = "0.0"


        Dim dtcodf As DataTable
        Dim tcodf As New clsProcesos
        Dim tt As New clsProcesos
        Dim dttt As DataTable



        dtcodf = tcodf.Consultar("select max(tirajeca) from tirajes")
        dttt = tt.Consultar("select tirajecs from tirajes")
        Me.textiraje.Text = dttt.Rows(0).Item(0).ToString
        Me.texcorrelativo.Text = dtcodf.Rows(0).Item(0).ToString

        Dim sumas As Decimal = 0
        For i As Integer = 0 To 17

            If chekdescartar.Checked Then

                If gridproductos.Rows(i).Cells(0).Value <> Nothing Then
                    If gridproductos.Rows(i).Cells(5).Value = False Then
                        sumas += CDec(gridproductos.Rows(i).Cells(4).Value)
                    End If

                End If

            Else

                If gridproductos.Rows(i).Cells(0).Value <> Nothing Then

                    If gridproductos.Rows(i).Cells(5).Value = True Then
                        sumas += CDec(gridproductos.Rows(i).Cells(4).Value)
                    End If

                End If

            End If


        Next


        Dim sumas1 As Decimal = Math.Round((sumas) / 1.13, 2)
        Me.textsumas.Text = sumas1
        Dim iva1 As Decimal = Math.Round(CDec(sumas1 * 0.13), 2)
        Me.textiva.Text = iva1
        Me.textotal.Text = Math.Round(iva1 + sumas1, 2)
    End Sub

    Private Sub botcliente_Click(sender As Object, e As EventArgs) Handles botcliente.Click
        Dim fcliente As New Clientes

        fcliente.donde = "generar"
        fcliente.frmgenerar = Me
        fcliente.Show()
    End Sub

    Private Sub botsalir_Click(sender As Object, e As EventArgs) Handles botsalir.Click
        Me.Close()
    End Sub

    Private Sub botguardar_Click(sender As Object, e As EventArgs) Handles botguardar.Click
        Dim n As String = ""
        If factura Then
            n = " la factura "
        Else
            n = " El comprobante de credito fiscal "
        End If

        If MsgBox("Esta seguro de guardar " & n, MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then

            Try


                Dim d, m, a, f As String
                d = Me.DateTimePicker1.Value.Day
                m = Me.DateTimePicker1.Value.Month
                a = Me.DateTimePicker1.Value.Year
                f = a + "-" + m + "-" + d
                Dim consultar As New clsProcesos
                Dim que As String = ""
                Dim iva As Decimal = 0

                If factura Then
                    que = "Factura"
                    iva = 0
                Else
                    que = "Comprobante de Credito fiscal"
                    iva = CDec(Me.textiva.Text)
                End If

                tcredito.Insertar("'" & Me.texcorrelativo.Text & "','" & que & "'," & Me.idcliente & ",'" & f & "'," & CDbl(Me.textsumas.Text).ToString & "," & CDbl(0) & "," & CDbl(iva).ToString & "," & CDbl(0).ToString & "," & CDbl(0).ToString & "," & CDbl(Me.textotal.Text).ToString & ",'Contado','valida','" & Me.textiraje.Text & "','" & f & "'," & CDec(Me.texcomision.Text))
                dtcredito = consultar.Consultar("SELECT  Max(codfacturav) FROM facturaventa")
                idcredito = dtcredito.Rows(0).Item(0)


                If factura Then
                    'imprimir()
                    consultar.Consultar(" update tirajes set tirajefa = " & (CShort(Me.texcorrelativo.Text.Trim) + 1))
                Else
                    'imprimecomprobante()
                    consultar.Consultar(" update tirajes set tirajeca = " & (CShort(Me.texcorrelativo.Text.Trim) + 1))
                End If


                For i As Integer = 0 To 17
                    If Me.gridproductos.Rows(i).Cells(0).Value <> Nothing Then
                        If chekdescartar.Checked Then

                            If gridproductos.Rows(i).Cells(0).Value <> Nothing Then
                                If gridproductos.Rows(i).Cells(5).Value = False Then
                                    tdetalle.Insertar(CInt(Me.idcredito).ToString & ",'" & gridproductos.Rows(i).Cells(0).Value & "'," & CDbl(gridproductos.Rows(i).Cells(1).Value).ToString & ",0,0,0," & gridproductos.Rows(i).Cells(4).Value & ", 0 ," & CDbl(gridproductos.Rows(i).Cells(3).Value))
                                End If

                            End If

                        Else

                            If gridproductos.Rows(i).Cells(0).Value <> Nothing Then

                                If gridproductos.Rows(i).Cells(5).Value = True Then
                                    tdetalle.Insertar(CInt(Me.idcredito).ToString & ",'" & gridproductos.Rows(i).Cells(0).Value & "'," & CDbl(gridproductos.Rows(i).Cells(1).Value).ToString & ",0,0,0," & gridproductos.Rows(i).Cells(4).Value & ", 0 ," & CDbl(gridproductos.Rows(i).Cells(3).Value))
                                End If

                            End If

                        End If

                    End If
                Next

                MsgBox("Su factura se genero exitosamente", MsgBoxStyle.Information, "Exito")
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub checomision_CheckedChanged(sender As Object, e As EventArgs) Handles checomision.CheckedChanged
        If checomision.Checked Then
            Me.lcomision.Visible = True
            Me.texcomision.Visible = True
        Else
            Me.lcomision.Visible = True
            Me.texcomision.Visible = True
        End If
    End Sub

End Class