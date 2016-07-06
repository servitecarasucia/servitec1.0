Imports System.Windows.Forms
Imports logica

Imports System.IO.StreamWriter
Imports System.IO


Public Class mdiMain
    Public usuario As String
    Public mMenu As New System.Windows.Forms.MainMenu
    Public codigoempresa As String
    Private dtempresas As DataTable


    'parte de los productos
    Public productos As New clsProcesos
    Public dtproductos As DataTable
    Public dttablas As DataTable
   

    'termina parte de los productos


    'ihabiliara las teclas de acceso rapido
    Public teclas As Boolean = True
    Public llama As String
    Private contador As Short = 0
    Public anular As Boolean = False

    'para la poscion en que aparecen'
    Public py As Short = 0
    Public px As Short = 0
    Public ventanas As Short = 0


    Public grp As New clsMaestros(clsNomTab.eTbl.Grp)
    Public grpusr As New clsMaestros(clsNomTab.eTbl.GrpUsr)

    Public dtgrp As DataTable
    Public dtgrpusr As DataTable


    'para las notificaciones
    Public cantidadf As Double
    Public idfactura As Short
    Public orden As Short

    Public super As Boolean = True 'para determinar si es super usuario o no'

    Public dtnoti As DataTable
    Public tnoti As New clsMaestros(clsNomTab.eTbl.notificaciones)


    'Para Respaldar

    Dim carpeta As New FolderBrowserDialog
    Dim consultar As New clsProcesos

    Dim dtrespados1 As DataTable
    Dim trespaldos1 As New clsMaestros(clsNomTab.eTbl.Respaldo)


    Public Sub llamar()

        Me.timllamar.Enabled = False
        If llama = "compra" Then
            compra.Show()
        Else
            Ventas.Show()
        End If



    End Sub

  

    Private Sub mdiMain_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        'If teclas = True Then
        '    If (e.KeyChar) = "v" Or (e.KeyChar) = "V" Then
        '        llama = "Ventas"
        '        teclas = False
        '        llamar()
        '    End If



        '    If (e.KeyChar) = "c" Or (e.KeyChar) = "C" Then
        '        llama = "compra"
        '        teclas = False
        '        llamar()
        '    End If

        '    If (e.KeyChar) = "d" Then
        '        VentasDiarias.Show()
        '    End If

        '    If (e.KeyChar) = "r" Or (e.KeyChar) = "R" Then
        '        Form1.Show()

        '    End If

        'End If

    End Sub

    Private Sub respaldardatos()

        Dim pathmysql As String
        Dim comando As String
        pathmysql = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\MySQL AB\MYSQL Server 5.7", "Location", 0)
        If pathmysql = Nothing Then
            MsgBox("No se encontro en tu equipo Mysql, escoge la carpeta donde esta ubicado")
            carpeta.ShowDialog()
            pathmysql = carpeta.SelectedPath
        End If
        Dim nombrearchivo As String
        Dim dtrespaldo As DataTable
        Dim trespaldo As New clsMaestros(clsNomTab.eTbl.Respaldo)


        trespaldo.Insertar("'" & System.DateTime.Now & "','Respaldo',' '")
        dtrespaldo = consultar.Consultar("select max(idrespaldo) from respaldos")
        consultar.Consultar("update respaldos set nombrearchivo = 'Respaldo" & dtrespaldo.Rows(0).Item(0).ToString & "' where idrespaldo = " & dtrespaldo.Rows(0).Item(0).ToString)



        nombrearchivo = "Respaldo" & dtrespaldo.Rows(0).Item(0).ToString & ".sql"
        ' Dim ruta As String = "D:\SISTEMAS DE LA UNIVERSIDAD\AUDITORIA DE SISTEMAS\INVENTARIO DE GASOLINERA CON MONITOREO DE BOMBAS AL FINAL DEL DIA\INVENTARIO\Respaldos\"
        'Dim ruta As String = "C:\Users\pc3\Documents\SYSTEMANUEL\INVENTARIO\Respaldos\"
        Dim ruta As String = "F:\SERVITEC\INVENTARIO\Respaldos\"
        MsgBox("Esta es a ruta: " & ruta, MsgBoxStyle.Information, "Aviso de respaldo")

        Try
            comando = pathmysql & "\bin\mysqldump --user=root --password=root --databases servitecwebd -r """ & ruta & nombrearchivo & """"
            Shell(comando, AppWinStyle.MinimizedFocus, True)




        Catch ex As Exception
            MsgBox("Ocurrio un error al respaldar razon: " & ex.Message, MsgBoxStyle.Critical, "Informacion")
        End Try

    End Sub

    Private Sub mdiMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Form1.Close()
        Me.WindowState() = FormWindowState.Maximized
        'Me.timernuevaventa.Enabled = True
        cargarmenu()

        dtgrpusr = grpusr.Consultar(" where idUsr = '" & usuario & "'")

        dtgrp = grp.Consultar(" where IdGrp = " & dtgrpusr.Rows(0).Item(1).ToString)

        If dtgrp.Rows(0).Item(1).ToString = "SUPER USUARIO" Then
            actualizargrid()
            verdeuda()
            timernuevaventa.Enabled = True
            Me.lnotis.Visible = True
            Me.gridventas.Visible = True
            Me.botlimpiar.Visible = True
            super = True
        Else
            Me.lnotis.Visible = False
            Me.gridventas.Visible = False
            timernuevaventa.Enabled = False
            Me.botlimpiar.Visible = False
            super = False
        End If




    End Sub

    Public Sub cargarmenu()

        Me.Text = "SYSTEMA SERVITEC"
        Dim operacion As New clsUtilerias
        Me.Menu = mMenu

        mMenu = operacion.GeneraMenu(True, usuario, 0, mMenu.MenuItems)

        Me.Menu.MenuItems.Add("Cotizar")
        Me.Menu.MenuItems.Add("Salir")


        AgregarManejador(Me.Menu.MenuItems, 0)

    End Sub

    Private Sub AgregarManejador(ByVal menuItems As MenuItem.MenuItemCollection, ByVal nivel As Integer)
        For Each menuItem As MenuItem In menuItems
            AddHandler menuItem.Click, AddressOf Opciones_Click
            AgregarManejador(menuItem.MenuItems, nivel + 1)
        Next
    End Sub

    Private Sub Opciones_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim t As MenuItem
        t = sender
        Dim formulario As New Form
        Dim tipo As System.Type

       

        If t.Text = "Cambiar Empresa" Or t.Text = "Cotizar" Then
            If t.Text = "Cotizar" Then
                Servitec.Ventas.donde = "Cotizar"
                Servitec.Ventas.Show()
            Else
                teclas = True
                Empresas.cambio = "si"
                Empresas.Show()
            End If

        Else
            If t.Text = "Salir" Then
                'Cerrando el formulario inicial (Login) Puede confirmar
                respaldardatos()
                frmLogin.Close()
            Else
                Try
                    tipo = Type.GetType("Servitec." & t.Tag)
                    formulario = Activator.CreateInstance(tipo)
                    teclas = False

                    formulario.Show()

                Catch ex As Exception
                    MessageBox.Show("El programa no existe")
                End Try
            End If
        End If

    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub timllamar_Tick(sender As Object, e As EventArgs) Handles timllamar.Tick
        llamar()
    End Sub

    Private Sub ButtonItem7_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

   

    Private Sub tmnulo_Tick(sender As Object, e As EventArgs) Handles tmnulo.Tick
    End Sub

    Private Sub timernuevaventa_Tick(sender As Object, e As EventArgs) Handles timernuevaventa.Tick

        actualizargrid()

    End Sub

    Public Sub setearventanas()
        ventanas = ventanas - 1
        If ventanas = 0 Then
            Me.py = 0
            Me.px = 0
            Me.timernuevaventa.Enabled = True
        End If
    End Sub



    Public Sub actualizargrid()
        dtnoti = tnoti.Consultar(" order by orden")
        If dtnoti.Rows.Count > 0 Then
            Me.lnotis.Visible = True
            Me.gridventas.Visible = True
            Me.botlimpiar.Visible = True
            cargargrid()
        Else
            Me.lnotis.Visible = False
            Me.gridventas.Visible = False
            Me.botlimpiar.Visible = False

        End If

    End Sub

    Public Sub cargargrid()

        Dim nf As Short
        nf = dtnoti.Rows.Count



        If nf = 0 Then
            Me.gridventas.RowCount = 1
            Me.gridventas.Rows(0).Cells(0).Value = ""
            Me.gridventas.Rows(0).Cells(1).Value = ""
            Me.gridventas.Rows(0).Cells(2).Value = ""
            Me.gridventas.Rows(0).Cells(3).Value = ""


        Else
            Me.gridventas.RowCount = nf
        End If

        For i As Integer = 0 To dtnoti.Rows.Count - 1
            Me.gridventas.Rows(i).Cells(0).Value = Me.dtnoti.Rows(i).Item(1)

            Me.gridventas.Rows(i).Cells(1).Value = Me.dtnoti.Rows(i).Item(2)
            Me.gridventas.Rows(i).Cells(2).Value = Me.dtnoti.Rows(i).Item(3)
            Me.gridventas.Rows(i).Cells(3).Value = Me.dtnoti.Rows(i).Item(4)
        Next
    End Sub



    Dim dtfacturaventa As DataTable
    Dim tfacturaventa As New clsMaestros(clsNomTab.eTbl.FacturaVenta)
    Dim dtdetalleventa As DataTable
    Dim tdetalle As New clsMaestros(clsNomTab.eTbl.DetalleFacturaV)
    Dim dtclientes As DataTable
    Dim tclientes As New clsMaestros(clsNomTab.eTbl.Clientes)
    Dim tclientesf As New clsMaestros(clsNomTab.eTbl.clientescf)

    Private Sub seleccionar() Handles gridventas.DoubleClick
        Try
            Dim id As Short = Me.gridventas.CurrentCell.RowIndex

            dtfacturaventa = tfacturaventa.Consultar(" where codfacturav = " & dtnoti.Rows(id).Item(5))
            DetalleVenta.idfactura = dtnoti.Rows(id).Item(5)

            DetalleVenta.Show()

            actualizargrid()
            Dim consultar As New clsProcesos
            consultar.Consultar(" delete from notificaciones where idnoti = " & dtnoti.Rows(id).Item(0))

        Catch ex As Exception

        End Try

    End Sub


    Private Sub gridventas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gridventas.KeyPress
        If (Asc(e.KeyChar)) = 13 Then
            seleccionar()
        End If
    End Sub

   
    Private Sub botlimpiar_Click(sender As Object, e As EventArgs) Handles botlimpiar.Click

        Try
            Dim tn As New clsProcesos
            tn.Ejecutar("DELETE FROM notificaciones")
            Me.botlimpiar.Visible = False
            actualizargrid()
        Catch ex As Exception

        End Try
    End Sub


  
    Private Sub noti_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles noti.MouseDoubleClick
        abrircredito()
    End Sub

    Private Sub abrircredito()
        Dim vr As New VentasRealizadas
        vr.donde = "noti"
        vr.Show()
    End Sub

    Private Sub abrirdudas()

        Dim cp As New Compras_realizadas
        cp.donde = "cuentas"
        cp.Show()

    End Sub



    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        abrircredito()
    End Sub

    Private Sub ConfiguracionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguracionesToolStripMenuItem.Click
        Me.noti.Dispose()
    End Sub

    Private Sub notificaciones_Tick(sender As Object, e As EventArgs) Handles notificaciones.Tick
        If System.DateTime.Now.Hour.ToString = "14" Then
            verdeuda()
        End If

        If System.DateTime.Now.Hour.ToString = "13" Then
            verdeuda()
        End If

        If System.DateTime.Now.Hour.ToString = "10" Then
            verdeuda()
        End If

    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        abrirdudas()
    End Sub


    Private Sub verdeuda()
        Try
            quitar.Enabled = True
            Dim dtfacturacompra As DataTable
            Dim tfacturacompra As New clsMaestros(clsNomTab.eTbl.FacturaCompra)

            Dim dtfacturaventa1 As DataTable
            Dim tfacturaventa1 As New clsMaestros(clsNomTab.eTbl.FacturaVenta)

            Dim varia As String = "0"
            Dim fc As Boolean = False
            Dim fv As Boolean = False

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

            dtfacturacompra = tfacturacompra.Consultar(" where  formadepago = 'Credito' and total <> descuento and fechalimite >= '" & f & "' and fechalimite <= '" & f1 & "' order by  fechalimite")

            dtfacturaventa1 = tfacturaventa1.Consultar(" where tipo = 'credito' and total <> descuento and fechavence >= '" & f & "' and fechavence <= '" & f1 & "' order by  numfacturav")

            If dtfacturacompra.Rows.Count <> 0 Then
                fc = True
            End If

            If dtfacturaventa1.Rows.Count <> 0 Then
                fv = True
            End If

            If fc = True And fv = True Then
                varia = "Hay cuentas por cobrar y cuentas por pagar pendientes"
                Me.lpagar.Text = "Cuntas por pagar"
                Me.lcobrar.Text = "Cuentas por cobrar"
                Me.grubnoti.Visible = True
                Me.lpagar.Visible = True
                Me.lcobrar.Visible = True
            ElseIf fc Then
                varia = "Hay cuentas por pagar pendientes"
                Me.lpagar.Text = "Cuntas por pagar"
                Me.grubnoti.Visible = True
                Me.lpagar.Visible = True
            ElseIf fv Then
                varia = "Hay cuentas por cobrar pendientes"
                Me.lcobrar.Text = "Cuentas por cobrar"
                Me.grubnoti.Visible = True

                Me.lcobrar.Visible = True
            End If

            If fv = True Or fc = True Then
                Me.noti.ShowBalloonTip(20000, varia, "haga clic derecho en el icono para mas informacion", ToolTipIcon.Info)
            End If


        Catch ex As Exception

        End Try
    End Sub

  

    Private Sub caja_Tick(sender As Object, e As EventArgs) Handles caja.Tick

        Dim hoy As String = Date.Now.Year.ToString + "-" + Date.Now.Month.ToString + "-" + Date.Now.Day.ToString


        Dim ventascontado As Decimal

        Dim comision As Decimal

        dtfacturaventa = tfacturaventa.Consultar(" where fecha ='" & hoy & "'")



        For i As Integer = 0 To dtfacturaventa.Rows.Count - 1


            If dtfacturaventa.Rows(i).Item(11).ToString = "Contado" Then
                ventascontado += Math.Round(CDec(dtfacturaventa.Rows(i).Item(10)), 2)
                comision += CDec(dtfacturaventa.Rows(i).Item(15))
            End If

        

        Next

       


        Me.lventas.Text = "$ " & Math.Round(CDec(ventascontado - comision), 2)



    End Sub

    Private Sub lpagar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lpagar.LinkClicked
        Dim cr As New Compras_realizadas
        cr.donde = "noti"
        cr.Show()
    End Sub

    Private Sub lcobrar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lcobrar.LinkClicked
        Dim vr As New VentasRealizadas
        vr.donde = "noti"
        vr.Show()
    End Sub

    Private Sub quitar_Tick(sender As Object, e As EventArgs) Handles quitar.Tick
        Me.quitar.Enabled = False
        Me.grubnoti.Visible = False
        Me.lpagar.Visible = False
        Me.lcobrar.Visible = False
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.quitar.Enabled = False
        Me.grubnoti.Visible = False
        Me.lpagar.Visible = False
        Me.lcobrar.Visible = False
    End Sub

    Private Sub gridventas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridventas.CellContentClick

    End Sub
End Class
