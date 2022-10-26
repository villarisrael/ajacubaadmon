Public Class Frmconsultarcierre
    Dim Vista As DataView
    Dim Fil As New BindingSource

    Public Cuenta As Double
    Public Comunidad As String

    Private Sub BuscarUsuario()
        'TabControl1.SelectedTab = TabEstados
        TabControl1.SelectPreviousTab()
        Comunidad = obtenerCampo("Select id_comunidad from comunidades where comunidad = '" & Comunidad & "'", "id_comunidad")
        If Comunidad = "0" Then Exit Sub
        Dim mes As Date

        Dim Meses As IDataReader = ConsultaSql("SELECT MES_PERIODO, an_per FROM ESTADOS WHERE ID_COMUNIDAD='" & Comunidad & "' AND CUENTA =" & Cuenta & " order by valornummes(mes_periodo, an_per) desc limit 24").ExecuteReader
        If Meses.Read Then
            mes = CDate("01/" & NumeroMes(Meses("mes_periodo")) & "/" & Meses("an_per"))
            TabItem1.Text = cadenames(mes)
            TabItem1.Visible = True
        End If
        If Meses.Read Then
            mes = CDate("01/" & NumeroMes(Meses("mes_periodo")) & "/" & Meses("an_per"))
            TabItem2.Text = cadenames(mes)
            TabItem2.Visible = True
        End If
        If Meses.Read Then
            mes = CDate("01/" & NumeroMes(Meses("mes_periodo")) & "/" & Meses("an_per"))
            TabItem3.Text = cadenames(mes)
            TabItem3.Visible = True
        End If
        If Meses.Read Then
            mes = CDate("01/" & NumeroMes(Meses("mes_periodo")) & "/" & Meses("an_per"))
            TabItem4.Text = cadenames(mes)
            TabItem4.Visible = True
        End If
        If Meses.Read Then
            mes = CDate("01/" & NumeroMes(Meses("mes_periodo")) & "/" & Meses("an_per"))
            TabItem5.Text = cadenames(mes)
            TabItem5.Visible = True
        End If
        If Meses.Read Then
            mes = CDate("01/" & NumeroMes(Meses("mes_periodo")) & "/" & Meses("an_per"))
            TabItem6.Text = cadenames(mes)
            TabItem6.Visible = True
        End If
        If Meses.Read Then
            mes = CDate("01/" & NumeroMes(Meses("mes_periodo")) & "/" & Meses("an_per"))
            TabItem7.Text = cadenames(mes)
            TabItem7.Visible = True
        End If
        If Meses.Read Then
            mes = CDate("01/" & NumeroMes(Meses("mes_periodo")) & "/" & Meses("an_per"))
            TabItem8.Text = cadenames(mes)
            TabItem8.Visible = True
        End If
        If Meses.Read Then
            mes = CDate("01/" & NumeroMes(Meses("mes_periodo")) & "/" & Meses("an_per"))
            TabItem9.Text = cadenames(mes)
            TabItem9.Visible = True
        End If
        If Meses.Read Then
            mes = CDate("01/" & NumeroMes(Meses("mes_periodo")) & "/" & Meses("an_per"))
            TabItem10.Text = cadenames(mes)
            TabItem10.Visible = True
        End If
        If Meses.Read Then
            mes = CDate("01/" & NumeroMes(Meses("mes_periodo")) & "/" & Meses("an_per"))
            TabItem11.Text = cadenames(mes)
            TabItem11.Visible = True
        End If
        If Meses.Read Then
            mes = CDate("01/" & NumeroMes(Meses("mes_periodo")) & "/" & Meses("an_per"))
            TabItem12.Text = cadenames(mes)
            TabItem12.Visible = True
        End If
        If Meses.Read Then
            mes = CDate("01/" & NumeroMes(Meses("mes_periodo")) & "/" & Meses("an_per"))
            TabItem13.Text = cadenames(mes)
            TabItem13.Visible = True
        End If
        If Meses.Read Then
            mes = CDate("01/" & NumeroMes(Meses("mes_periodo")) & "/" & Meses("an_per"))
            TabItem14.Text = cadenames(mes)
            TabItem14.Visible = True
        End If
        If Meses.Read Then
            mes = CDate("01/" & NumeroMes(Meses("mes_periodo")) & "/" & Meses("an_per"))
            TabItem15.Text = cadenames(mes)
            TabItem15.Visible = True
        End If
        If Meses.Read Then
            mes = CDate("01/" & NumeroMes(Meses("mes_periodo")) & "/" & Meses("an_per"))
            TabItem16.Text = cadenames(mes)
            TabItem16.Visible = True
        End If
        If Meses.Read Then
            mes = CDate("01/" & NumeroMes(Meses("mes_periodo")) & "/" & Meses("an_per"))
            TabItem17.Text = cadenames(mes)
            TabItem17.Visible = True
        End If
        If Meses.Read Then
            mes = CDate("01/" & NumeroMes(Meses("mes_periodo")) & "/" & Meses("an_per"))
            TabItem18.Text = cadenames(mes)
            TabItem18.Visible = True
        End If
        If Meses.Read Then
            mes = CDate("01/" & NumeroMes(Meses("mes_periodo")) & "/" & Meses("an_per"))
            TabItem19.Text = cadenames(mes)
            TabItem19.Visible = True
        End If
        If Meses.Read Then
            mes = CDate("01/" & NumeroMes(Meses("mes_periodo")) & "/" & Meses("an_per"))
            TabItem20.Text = cadenames(mes)
            TabItem20.Visible = True
        End If
        If Meses.Read Then
            mes = CDate("01/" & NumeroMes(Meses("mes_periodo")) & "/" & Meses("an_per"))
            TabItem21.Text = cadenames(mes)
            TabItem21.Visible = True
        End If
        If Meses.Read Then
            mes = CDate("01/" & NumeroMes(Meses("mes_periodo")) & "/" & Meses("an_per"))
            TabItem22.Text = cadenames(mes)
            TabItem22.Visible = True
        End If
        If Meses.Read Then
            mes = CDate("01/" & NumeroMes(Meses("mes_periodo")) & "/" & Meses("an_per"))
            TabItem23.Text = cadenames(mes)
            TabItem23.Visible = True
        End If
        If Meses.Read Then
            mes = CDate("01/" & NumeroMes(Meses("mes_periodo")) & "/" & Meses("an_per"))
            TabItem24.Text = cadenames(mes)
            TabItem24.Visible = True
        End If
        TabItem25.Text = "Periodo"
        TabItem25.Visible = True

        CCIERRE.Cuenta = Cuenta
        CCIERRE.Comunidad = Comunidad

        CierreH.Cuenta = Cuenta
        CierreH.Comunidad = Comunidad
        CierreH.ultimo = True
        CierreH.Mostrar()



        Me.Text = "ESTADO DE CUENTA DE " & obtenerCampo("select nombre from usuario where cuenta=" & Cuenta & " and id_comunidad='" & Comunidad & "'", "nombre")
        Try
            MuestraCierre(1)
            llenaGrid(DGLecturas, "select trabajadores.nombre as LECTURISTA, concat(lecturas.mes,' ', lecturas.an_per) as PERIODO,lecturas.fec_lec as 'FECHA DE LECTURA', " & _
            "lecturas.lecturaant as 'LEC ANT', lecturas.lectura as 'LEC ACT', lecturas.consumo as  " & _
            "CONSUMO, lecturas.sit_med as 'SIT MED', lecturas.sit_pad as 'SIT PAD', lecturas.sit_hid as   " & _
            "'SIT HID', lecturas.status as ESTADO, lecturas.fec_cap as 'FECHA DE CAPTURA', lecturas.fec_ver as " & _
            "'FECHA DE VERIFICACIÓN', lecturas.accion as ACCIÓN, cuotas.descripcion_cuota as TARIFA " & _
            "from lecturas, trabajadores, cuotas " & _
            "where lecturas.lecturista=trabajadores.idtrab and lecturas.tarifa=cuotas.id_tarifa  and lecturas.cuenta=" & Cuenta & " and lecturas.comunidad='" & Comunidad & "' order by valornummes(mes,an_per) asc")
            DGLecturas.Columns("LEC ANT").Width = 50
            DGLecturas.Columns("LEC ACT").Width = 50
            DGLecturas.Columns("SIT MED").Width = 50
            DGLecturas.Columns("SIT PAD").Width = 50
            DGLecturas.Columns("SIT HID").Width = 50
            llenaGrid(DgOrdenes, " select vordent.nodemedidor as 'No. Medidor', vordent.folio as Folio, vordent.Departamento, vordent.nombre as Nombre, vordent.cuenta as Cuenta, comunidades.comunidad as Comunidad, vordent.ubicacion as Ubicación, vordent.status as Estado, vordent.fec_ord as Fecha, vordent.hora as Hora, vordent.fec_res as Resultado, vordent.fec_com as Compromiso, vordent.indic as Indicación, vordent.Descripcion_queja as Concepto from vordent, comunidades where vordent.id_comunidad=comunidades.id_comunidad and vordent.cuenta=" & Cuenta & " and vordent.id_comunidad='" & Comunidad & "' order by vordent.fec_ord desc, vordent.hora desc")
            CargaAnticipos()
            llenaGrid(DataGridView1, "select serie,recibo,fecha_act,concat(per_ini,' ',ano_ini) as fec_inicial, concat(per_fin,' ',ano_fin) as fec_final,subtotal,iva,total from pagos where cuenta=" & Cuenta & " and id_comunidad='" & Comunidad & "' and cancelado='A' order by fecha_Act desc")
            CargaConvenios()
            'llenaGrid(DgEstadosCuenta, "Select * from cambioestado where cuenta = " & Cuenta & " and id_comunidad = '" & Comunidad & "'")
            Dim Enc As New Encriptar
            DgEstadosCuenta.Rows.Clear()
            Dim Cam As IDataReader = ConsultaSql("Select * from Vcambioestado where cuenta = " & Cuenta & " and id_comunidad = '" & Comunidad & "'").ExecuteReader
            Do While Cam.Read
                Enc.Palabra = Cam("nombre")
                DgEstadosCuenta.Rows.Add(Cam("motivo"), UCase(Format(Cam("fechacambio"), "dd - MMM - yyyy")), Cam("Descripcion"), Enc.Desencriptada)
            Loop
            DgMedidor.Rows.Clear()
            Cam = ConsultaSql("Select * from VcambioMedidor where cuenta = " & Cuenta & " and comunidad = '" & Comunidad & "'").ExecuteReader
            Dim MarcaAntes As String, DiamAntes As String
            Dim MarcaNuevo As String, DiamNuevo As String
            Do While Cam.Read
                Enc.Palabra = Cam("nombre")
                MarcaAntes = obtenerCampo("Select descripcion from marcasmedidor where id_marca = '" & Cam("Marcaantes") & "'", "descripcion")
                DiamAntes = obtenerCampo("Select descripcion from diametros where id_diametro = '" & Cam("Diametroantes") & "'", "descripcion")
                MarcaNuevo = obtenerCampo("Select descripcion from marcasmedidor where id_marca = '" & Cam("Marca") & "'", "descripcion")
                DiamNuevo = obtenerCampo("Select descripcion from diametros where id_diametro = '" & Cam("Diametro") & "'", "descripcion")
                DgMedidor.Rows.Add(UCase(Format(Cam("fecha"), "dd - MMM - yyyy")), MarcaAntes, Cam("MedidorAntes"), DiamAntes, MarcaNuevo, Cam("medidor"), DiamNuevo, UCase(Format(Cam("fechainstalacion"), "dd - MMM - yyyy")), Cam("ultimalectura"), Cam("ultimo_consumo"), Cam("Observaciones"), Enc.Desencriptada)
            Loop
            'llenaGrid(DgMedidor, "Select * from VcambioMedidor where cuenta = " & Cuenta & " and id_comunidad = '" & Comunidad & "'")
            DGNombre.Rows.Clear()
            Cam = ConsultaSql("Select * from VcambioNombre where cuenta = " & Cuenta & " and comunidad = '" & Comunidad & "'").ExecuteReader
            Do While Cam.Read
                Enc.Palabra = Cam("Usuario")
                DGNombre.Rows.Add(UCase(Format(Cam("fecha"), "dd - MMM - yyyy")), Cam("nombreantes"), Cam("nombre"), Cam("Observacion"), Enc.Desencriptada)
            Loop
            'llenaGrid(DGNombre, "Select * from cambionombre where cuenta = " & Cuenta & " and comunidad = '" & Comunidad & "'")

            DGTarifas.Rows.Clear()
            Cam = ConsultaSql("Select * from VcambioTarifa where cuenta = " & Cuenta & " and comunidad = '" & Comunidad & "'").ExecuteReader
            Dim AntesTipo, AntesTarifa, Tipo, Tarifa As String
            Do While Cam.Read
                Enc.Palabra = Cam("Nombre")
                AntesTipo = obtenerCampo("select descripcion from tipos_usuarios where id_tipo_usuario = '" & Cam("Antestipo") & "'", "descripcion")
                AntesTarifa = obtenerCampo("select DESCRIPCION_CUOTA FROM CUOTAS WHERE ID_TARIFA ='" & Cam("antestarifa") & "'", "DESCRIPCION_CUOTA")
                Tipo = obtenerCampo("select descripcion from tipos_usuarios where id_tipo_usuario = '" & Cam("tipo") & "'", "descripcion")
                Tarifa = obtenerCampo("select DESCRIPCION_CUOTA FROM CUOTAS WHERE ID_TARIFA ='" & Cam("tarifa") & "'", "DESCRIPCION_CUOTA")
                DGTarifas.Rows.Add(UCase(Format(Cam("fecha"), "dd - MMM - yyyy")), AntesTarifa, AntesTipo, Tarifa, Tipo, Cam("observacion"), Enc.Desencriptada)
            Loop
        Catch ex As Exception
            'MessageBoxEx.Show(ex.Message)
        End Try
    End Sub

    Private Sub TabItem25_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem25.Click
        DTmes.Visible = True
    End Sub

    Private Sub MuestraCierre(ByVal Num As Integer)
        DTmes.Visible = False
        Dim Mes As String = "", Año As Integer
        Try
OtraVez:
            Select Case Num
                Case 1
                    Año = Mid(TabItem1.Text, Len(TabItem1.Text) - 4, 5)
                    Mes = Mid(TabItem1.Text, 1, 3).ToLower
                Case 2
                    Año = Mid(TabItem2.Text, Len(TabItem2.Text) - 4, 5)
                    Mes = Mid(TabItem2.Text, 1, 3).ToLower
                Case 3
                    Año = Mid(TabItem3.Text, Len(TabItem3.Text) - 4, 5)
                    Mes = Mid(TabItem3.Text, 1, 3).ToLower
                Case 4
                    Año = Mid(TabItem4.Text, Len(TabItem4.Text) - 4, 5)
                    Mes = Mid(TabItem4.Text, 1, 3).ToLower
                Case 5
                    Año = Mid(TabItem5.Text, Len(TabItem5.Text) - 4, 5)
                    Mes = Mid(TabItem5.Text, 1, 3).ToLower
                Case 6
                    Año = Mid(TabItem6.Text, Len(TabItem6.Text) - 4, 5)
                    Mes = Mid(TabItem6.Text, 1, 3).ToLower
                Case 7
                    Año = Mid(TabItem7.Text, Len(TabItem7.Text) - 4, 5)
                    Mes = Mid(TabItem7.Text, 1, 3).ToLower
                Case 8
                    Año = Mid(TabItem8.Text, Len(TabItem8.Text) - 4, 5)
                    Mes = Mid(TabItem8.Text, 1, 3).ToLower
                Case 9
                    Año = Mid(TabItem9.Text, Len(TabItem9.Text) - 4, 5)
                    Mes = Mid(TabItem9.Text, 1, 3).ToLower
                Case 10
                    Año = Mid(TabItem10.Text, Len(TabItem10.Text) - 4, 5)
                    Mes = Mid(TabItem10.Text, 1, 3).ToLower
                Case 11
                    Año = Mid(TabItem11.Text, Len(TabItem11.Text) - 4, 5)
                    Mes = Mid(TabItem11.Text, 1, 3).ToLower
                Case 12
                    Año = Mid(TabItem12.Text, Len(TabItem12.Text) - 4, 5)
                    Mes = Mid(TabItem12.Text, 1, 3).ToLower
                Case 13
                    Año = Mid(TabItem13.Text, Len(TabItem13.Text) - 4, 5)
                    Mes = Mid(TabItem13.Text, 1, 3).ToLower
                Case 14
                    Año = Mid(TabItem14.Text, Len(TabItem14.Text) - 4, 5)
                    Mes = Mid(TabItem14.Text, 1, 3).ToLower
                Case 15
                    Año = Mid(TabItem15.Text, Len(TabItem15.Text) - 4, 5)
                    Mes = Mid(TabItem15.Text, 1, 3).ToLower
                Case 16
                    Año = Mid(TabItem16.Text, Len(TabItem16.Text) - 4, 5)
                    Mes = Mid(TabItem16.Text, 1, 3).ToLower
                Case 17
                    Año = Mid(TabItem17.Text, Len(TabItem17.Text) - 4, 5)
                    Mes = Mid(TabItem17.Text, 1, 3).ToLower
                Case 18
                    Año = Mid(TabItem18.Text, Len(TabItem18.Text) - 4, 5)
                    Mes = Mid(TabItem18.Text, 1, 3).ToLower
                Case 19
                    Año = Mid(TabItem19.Text, Len(TabItem19.Text) - 4, 5)
                    Mes = Mid(TabItem19.Text, 1, 3).ToLower
                Case 20
                    Año = Mid(TabItem20.Text, Len(TabItem20.Text) - 4, 5)
                    Mes = Mid(TabItem20.Text, 1, 3).ToLower
                Case 21
                    Año = Mid(TabItem21.Text, Len(TabItem21.Text) - 4, 5)
                    Mes = Mid(TabItem21.Text, 1, 3).ToLower
                Case 22
                    Año = Mid(TabItem22.Text, Len(TabItem22.Text) - 4, 5)
                    Mes = Mid(TabItem22.Text, 1, 3).ToLower
                Case 23
                    Año = Mid(TabItem23.Text, Len(TabItem23.Text) - 4, 5)
                    Mes = Mid(TabItem23.Text, 1, 3).ToLower
                Case 24
                    Año = Mid(TabItem24.Text, Len(TabItem24.Text) - 4, 5)
                    Mes = Mid(TabItem24.Text, 1, 3).ToLower
                Case 25
                    Año = DTmes.SelectedDate.Year
                    Mes = UCase(MonthName(DTmes.SelectedDate.Month, True))
                Case 26
                    Año = Mid(TabItem26.Text, Len(TabItem26.Text) - 4, 5)
                    Mes = Mid(TabItem26.Text, 1, 3).ToLower
            End Select
            CCIERRE.Año = Año
            CCIERRE.Mes = Mes
            CCIERRE.Cuenta = Cuenta
            CCIERRE.Comunidad = Comunidad
            CCIERRE.Mostrar()
        Catch EX As Exception
            If Num < 27 Then
                Num += 1
                GoTo OtraVez
            End If
        End Try
    End Sub

#Region "Click sobre el Calendario"

    Private Sub TabItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem1.Click
        MuestraCierre(1)
    End Sub

    Private Sub TabItem10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem10.Click
        MuestraCierre(10)
    End Sub

    Private Sub TabItem11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem11.Click
        MuestraCierre(11)
    End Sub

    Private Sub TabItem12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem12.Click
        MuestraCierre(12)
    End Sub

    Private Sub TabItem13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem13.Click
        MuestraCierre(13)
    End Sub

    Private Sub TabItem14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem14.Click
        MuestraCierre(14)
    End Sub

    Private Sub TabItem15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem15.Click
        MuestraCierre(15)
    End Sub

    Private Sub TabItem16_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem16.Click
        MuestraCierre(16)
    End Sub

    Private Sub TabItem17_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem17.Click
        MuestraCierre(17)
    End Sub

    Private Sub TabItem18_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem18.Click
        MuestraCierre(18)
    End Sub

    Private Sub TabItem19_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem19.Click
        MuestraCierre(19)
    End Sub

    Private Sub TabItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem2.Click
        MuestraCierre(2)
    End Sub

    Private Sub TabItem20_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem20.Click
        MuestraCierre(20)
    End Sub

    Private Sub TabItem21_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem21.Click
        MuestraCierre(21)
    End Sub

    Private Sub TabItem22_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem22.Click
        MuestraCierre(22)
    End Sub

    Private Sub TabItem23_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem23.Click
        MuestraCierre(23)
    End Sub

    Private Sub TabItem24_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem24.Click
        MuestraCierre(24)
    End Sub

    Private Sub TabItem26_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem26.Click
        MuestraCierre(26)
    End Sub

    Private Sub TabItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem3.Click
        MuestraCierre(3)
    End Sub

    Private Sub TabItem4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem4.Click
        MuestraCierre(4)
    End Sub

    Private Sub TabItem5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem5.Click
        MuestraCierre(5)
    End Sub

    Private Sub TabItem6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem6.Click
        MuestraCierre(6)
    End Sub

    Private Sub TabItem7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem7.Click
        MuestraCierre(7)
    End Sub

    Private Sub TabItem8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem8.Click
        MuestraCierre(8)
    End Sub

    Private Sub TabItem9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabItem9.Click
        MuestraCierre(9)
    End Sub
#End Region

    Public Function VERIFICAEXISTENCIA(ByVal MES As Date) As Integer
        If obtenerCampo("SELECT MES_PERIODO FROM ESTADOS WHERE ID_COMUNIDAD='" & Comunidad & "' AND CUENTA =" & Cuenta & " AND MES_PERIODO='" & MonthName(MES.Month, True) & "' AND AN_PER=" & MES.Year, "MES_PERIODO") = "0" Then
            Return 0
        Else
            Return 1
        End If
    End Function

    Private Sub Frmconsultarcierre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.tabFacturacion.Select()
    End Sub

    Private Sub Frmconsultarcierre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub Frmconsultarcierre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtbusNombre.Select()

        Try
            llenarCombo(CmbComunidad, "Select id_comunidad, comunidad from comunidades order by comunidad")
            Vista = llenarVista("Select cuenta, nombre, concat(calle,' ', numext, ' ', numint, ' ', colonia) as domicilio, comunidad  from vusuario order by cuenta")
            Fil.DataSource = Vista

            DGBus.DataSource = Fil
            'ExBus.Expanded = False
            PanBuscar.Width = 646
        Catch ex As Exception

        End Try
    End Sub

 
    Private Sub DGBus_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGBus.DoubleClick
        Cuenta = DGBus.Item(0, DGBus.CurrentRow.Index).Value
        Comunidad = DGBus.Item(3, DGBus.CurrentRow.Index).Value

        DGBus.Enabled = False
        ExBus.Expanded = False
        BuscarUsuario()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    
    Private Sub CargaAnticipos()
        Dim i As Integer = 1
        Dim j As Integer = 1
        Dim ir As IDataReader = ConsultaSql("Select idmov, serie, recibo, caja, Ofi_Pago, resta, pagado, total from vanticipos where cuenta = " & Cuenta & " and id_comunidad = '" & Comunidad & "' ").ExecuteReader
        Dim iv As Integer
        Try

            For iv = 0 To TreeAnti.Nodes.Count - 1
                TreeAnti.Nodes.Remove(TreeAnti.Nodes.Item(0))
            Next iv
            While ir.Read
                TreeAnti.Nodes.Add(New DevComponents.AdvTree.Node())
                TreeAnti.Nodes.Item(i - 1).Cells(0).Text = ir("Serie")
                TreeAnti.Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                TreeAnti.Nodes.Item(i - 1).Cells(1).Text = ir("Recibo")
                TreeAnti.Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                Try
                    TreeAnti.Nodes.Item(i - 1).Cells(2).Text = ir("Caja")
                Catch ex As Exception
                    TreeAnti.Nodes.Item(i - 1).Cells(2).Text = "TUL"
                End Try
                TreeAnti.Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                Try
                    TreeAnti.Nodes.Item(i - 1).Cells(3).Text = ir("Ofi_Pago")
                Catch ex As Exception
                    TreeAnti.Nodes.Item(i - 1).Cells(3).Text = "TUL"
                End Try
                TreeAnti.Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                TreeAnti.Nodes.Item(i - 1).Cells(4).HostedControl = monedatext(ir("Resta"))
                TreeAnti.Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                Dim lbpag As New Label
                lbpag.Height = 15
                If CBool(ir("Pagado")) Then
                    lbpag.Text = "Aplicado"
                    lbpag.BackColor = Color.LightGreen
                Else
                    lbpag.Text = "Activo"
                    lbpag.BackColor = Color.Green
                End If
                TreeAnti.Nodes.Item(i - 1).Cells(5).HostedControl = monedatext(ir("Total"))
                TreeAnti.Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                TreeAnti.Nodes.Item(i - 1).Cells(6).HostedControl = lbpag


                Dim Anti As IDataReader = ConsultaSql("select * from vdetanti where idanticipo = '" & ir("idmov") & "' ").ExecuteReader()
                j = 1
                While Anti.Read()

                    TreeAnti.Nodes(i - 1).Nodes.Add(New DevComponents.AdvTree.Node())
                    If j = 1 Then
                        TreeAnti.Nodes.Item(i - 1).NodesColumns.Add(New DevComponents.AdvTree.ColumnHeader("Monto Aplicado"))
                        TreeAnti.Nodes.Item(i - 1).NodesColumns.Item(0).Width.Absolute = 100
                        TreeAnti.Nodes.Item(i - 1).NodesColumns.Add(New DevComponents.AdvTree.ColumnHeader("Mes "))
                        TreeAnti.Nodes.Item(i - 1).NodesColumns.Item(1).Width.Absolute = 80
                        TreeAnti.Nodes.Item(i - 1).NodesColumns.Add(New DevComponents.AdvTree.ColumnHeader("Año"))
                        TreeAnti.Nodes.Item(i - 1).NodesColumns.Item(2).Width.Absolute = 80
                    End If
                    TreeAnti.Nodes.Item(i - 1).Nodes.Item(j - 1).Cells(0).HostedControl = monedatext(Anti("Anticipo"))
                    TreeAnti.Nodes.Item(i - 1).Nodes.Item(j - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                    TreeAnti.Nodes.Item(i - 1).Nodes.Item(j - 1).Cells(1).Text = Anti("Mes_Periodo")
                    TreeAnti.Nodes.Item(i - 1).Nodes.Item(j - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                    TreeAnti.Nodes.Item(i - 1).Nodes.Item(j - 1).Cells(2).Text = Anti("An_Per")
                    TreeAnti.Nodes.Item(i - 1).Nodes.Item(j - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                    j += 1
                End While
                i += 1
            End While
        Catch ex As Exception
            'Stop
        End Try

    End Sub


    Private Sub CargaConvenios()
        Dim i As Int16 = 1
        Dim j As Int16 = 1
        Dim lblpag As Label



        Dim idpag As IDataReader = Nothing
        Dim idcon As IDataReader = ConsultaSql("select * from convenios where cuenta=" & Cuenta & " and id_comunidad='" & Comunidad & "'").ExecuteReader
        Try

            If idcon.RecordsAffected <= 0 Then
                TreeConve.Nodes.Item(0).Nodes.Clear()
                TreeConve.Nodes.Item(0).Nodes(i - 1).Nodes.Clear()
                'TreeConve.Nodes.Item(0).Nodes.Item(i - 1).Nodes.Item(j - 1).Nodes.Clear()
                TreeConve.Nodes.Item(0).Nodes.Item(i - 1).Nodes.Item(j - 1).Cells.Clear()
            End If

            While idcon.Read()
                TreeConve.Nodes.Item(0).Nodes.Add(New DevComponents.AdvTree.Node())
                TreeConve.Nodes.Item(0).Nodes.Item(i - 1).Cells(0).Text = idcon("no_convenio")
                TreeConve.Nodes.Item(0).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                TreeConve.Nodes.Item(0).Nodes.Item(i - 1).Cells(1).Text = idcon("Fecha")
                TreeConve.Nodes.Item(0).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                TreeConve.Nodes.Item(0).Nodes.Item(i - 1).Cells(2).Text = idcon("Subtotal")
                TreeConve.Nodes.Item(0).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                TreeConve.Nodes.Item(0).Nodes.Item(i - 1).Cells(3).Text = idcon("Anticipo")
                TreeConve.Nodes.Item(0).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                TreeConve.Nodes.Item(0).Nodes.Item(i - 1).Cells(4).Text = idcon("Total")
                TreeConve.Nodes.Item(0).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                TreeConve.Nodes.Item(0).Nodes.Item(i - 1).Cells(5).Text = idcon("Resta")
                TreeConve.Nodes.Item(0).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                TreeConve.Nodes.Item(0).Nodes.Item(i - 1).Cells(6).Text = idcon("Status")
                TreeConve.Nodes.Item(0).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                TreeConve.Nodes.Item(0).Nodes.Item(i - 1).Cells(7).Text = idcon("Vencimiento")
                TreeConve.Nodes.Item(0).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                TreeConve.Nodes.Item(0).Nodes.Item(i - 1).Cells(8).Text = idcon("Nopagares")


                idpag = ConsultaSql("select * from otrosconceptos where concepto='" & idcon("no_convenio") & "'").ExecuteReader()
                j = 1


                If idpag.RecordsAffected = 0 Then
                    Try
                        TreeConve.Nodes.Item(0).Nodes.Item(i - 1).Nodes.Clear()

                    Catch ex As Exception

                    End Try
                End If

                While idpag.Read()
                    TreeConve.Nodes.Item(0).Nodes(i - 1).Nodes.Add(New DevComponents.AdvTree.Node())
                    TreeConve.Nodes.Item(0).Nodes.Item(i - 1).Nodes.Item(j - 1).Cells(0).Text = "Pagaré: " & idpag("motivo")
                    TreeConve.Nodes.Item(0).Nodes.Item(i - 1).Nodes.Item(j - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                    TreeConve.Nodes.Item(0).Nodes.Item(i - 1).Nodes.Item(j - 1).Cells(1).Text = " por un monto de : " & idpag("total")
                    TreeConve.Nodes.Item(0).Nodes.Item(i - 1).Nodes.Item(j - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                    lblpag = New Label()
                    lblpag.Height = 15
                    If Not CBool(idpag("pagado")) Then
                        lblpag.Text = "No pagado"
                        lblpag.BackColor = Color.Red
                    Else
                        lblpag.Text = "Pagado"
                        lblpag.BackColor = Color.LightGreen
                    End If
                    TreeConve.Nodes.Item(0).Nodes.Item(i - 1).Nodes.Item(j - 1).Cells(2).HostedControl = lblpag

                    j += 1
                End While
                i += 1
            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tabdetalles_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabdetalles.Click
        Try
            Dim serie As String
            serie = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells.Item(0).Value
            Dim folio
            folio = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells.Item(1).Value

            Dim i As Integer
            For i = 0 To AdvTreeDetalles.Nodes.Count - 1
                AdvTreeDetalles.Nodes.Remove(AdvTreeDetalles.Nodes.Item(i))
            Next i
            AdvTreeDetalles.Nodes.Add(New DevComponents.AdvTree.Node())
            AdvTreeDetalles.Nodes.Item(0).Expand()

            AdvTreeDetalles.Nodes.Item(0).NodesColumns.Add(New DevComponents.AdvTree.ColumnHeader("Consumo"))
            AdvTreeDetalles.Nodes.Item(0).NodesColumns.Item(0).Width.Absolute = 70
            AdvTreeDetalles.Nodes.Item(0).NodesColumns.Add(New DevComponents.AdvTree.ColumnHeader("Alcantarillado"))
            AdvTreeDetalles.Nodes.Item(0).NodesColumns.Item(1).Width.Absolute = 70
            AdvTreeDetalles.Nodes.Item(0).NodesColumns.Add(New DevComponents.AdvTree.ColumnHeader("Saneamiento"))
            AdvTreeDetalles.Nodes.Item(0).NodesColumns.Item(2).Width.Absolute = 70
            AdvTreeDetalles.Nodes.Item(0).NodesColumns.Add(New DevComponents.AdvTree.ColumnHeader("Rezagos"))
            AdvTreeDetalles.Nodes.Item(0).NodesColumns.Item(3).Width.Absolute = 70
            AdvTreeDetalles.Nodes.Item(0).NodesColumns.Add(New DevComponents.AdvTree.ColumnHeader("Recargos"))
            AdvTreeDetalles.Nodes.Item(0).NodesColumns.Item(4).Width.Absolute = 70
            AdvTreeDetalles.Nodes.Item(0).NodesColumns.Add(New DevComponents.AdvTree.ColumnHeader("Otros"))
            AdvTreeDetalles.Nodes.Item(0).NodesColumns.Item(5).Width.Absolute = 70
            AdvTreeDetalles.Nodes.Item(0).NodesColumns.Add(New DevComponents.AdvTree.ColumnHeader("Anticipo"))
            AdvTreeDetalles.Nodes.Item(0).NodesColumns.Item(6).Width.Absolute = 70
            AdvTreeDetalles.Nodes.Item(0).NodesColumns.Add(New DevComponents.AdvTree.ColumnHeader("Descuento"))
            AdvTreeDetalles.Nodes.Item(0).NodesColumns.Item(7).Width.Absolute = 70
            AdvTreeDetalles.Nodes.Item(0).NodesColumns.Add(New DevComponents.AdvTree.ColumnHeader("Subtotal"))
            AdvTreeDetalles.Nodes.Item(0).NodesColumns.Item(8).Width.Absolute = 70
            AdvTreeDetalles.Nodes.Item(0).NodesColumns.Add(New DevComponents.AdvTree.ColumnHeader("IVA"))
            AdvTreeDetalles.Nodes.Item(0).NodesColumns.Item(9).Width.Absolute = 70
            AdvTreeDetalles.Nodes.Item(0).NodesColumns.Add(New DevComponents.AdvTree.ColumnHeader("total"))
            AdvTreeDetalles.Nodes.Item(0).NodesColumns.Item(10).Width.Absolute = 90


            Dim ir As IDataReader
            Dim cman As Odbc.OdbcCommand
            cman = ConsultaSql("select * from pagos where serie='" & serie & "' and  recibo=" & folio)
            ir = cman.ExecuteReader

            ir.Read()
            AdvTreeDetalles.Nodes.Item(0).Cells(0).Text = "Factura " & serie & " " & folio & " cobrada en la oficina " & obtenerCampo("select * from oficinas where cod_ofi='" & ir("cod_ofi") & "'", "nombre") & " caja " & ir("id_caja") & " pagada con " & obtenerCampo("select * from fpago where ccodpago='" & ir("ccodpago") & "'", "cdespago") & " " & ir("referencia") & " a las " & ir("hora")

            AdvTreeDetalles.Nodes.Item(0).Nodes.Add(New DevComponents.AdvTree.Node())
            AdvTreeDetalles.Nodes.Item(0).Nodes.Item(0).Cells(0).HostedControl = monedatext(ir("pagos"))
            AdvTreeDetalles.Nodes.Item(0).Nodes.Item(0).Cells.Add(New DevComponents.AdvTree.Cell())
            AdvTreeDetalles.Nodes.Item(0).Nodes.Item(0).Cells(1).HostedControl = monedatext(ir("alcantarillado"))

            AdvTreeDetalles.Nodes.Item(0).Nodes.Item(0).Cells.Add(New DevComponents.AdvTree.Cell())
            AdvTreeDetalles.Nodes.Item(0).Nodes.Item(0).Cells(2).HostedControl = monedatext(ir("saneamiento"))
            'AdvTreeDetalles.Nodes.Item(0).Nodes.Item(0).Cells(2).StyleNo
            AdvTreeDetalles.Nodes.Item(0).Nodes.Item(0).Cells.Add(New DevComponents.AdvTree.Cell())
            AdvTreeDetalles.Nodes.Item(0).Nodes.Item(0).Cells(3).HostedControl = monedatext(ir("rezagos"))
            AdvTreeDetalles.Nodes.Item(0).Nodes.Item(0).Cells.Add(New DevComponents.AdvTree.Cell())
            AdvTreeDetalles.Nodes.Item(0).Nodes.Item(0).Cells(4).HostedControl = monedatext(ir("recargos"))
            AdvTreeDetalles.Nodes.Item(0).Nodes.Item(0).Cells.Add(New DevComponents.AdvTree.Cell())
            AdvTreeDetalles.Nodes.Item(0).Nodes.Item(0).Cells(5).HostedControl = monedatext(ir("otros"))
            AdvTreeDetalles.Nodes.Item(0).Nodes.Item(0).Cells.Add(New DevComponents.AdvTree.Cell())
            AdvTreeDetalles.Nodes.Item(0).Nodes.Item(0).Cells(6).HostedControl = monedatext(ir("anticipo"))
            AdvTreeDetalles.Nodes.Item(0).Nodes.Item(0).Cells.Add(New DevComponents.AdvTree.Cell())
            AdvTreeDetalles.Nodes.Item(0).Nodes.Item(0).Cells(7).HostedControl = monedatext(ir("montoDescuento") * -1)
            AdvTreeDetalles.Nodes.Item(0).Nodes.Item(0).Cells.Add(New DevComponents.AdvTree.Cell())
            AdvTreeDetalles.Nodes.Item(0).Nodes.Item(0).Cells(8).HostedControl = monedatext(ir("subtotal"))
            AdvTreeDetalles.Nodes.Item(0).Nodes.Item(0).Cells.Add(New DevComponents.AdvTree.Cell())
            AdvTreeDetalles.Nodes.Item(0).Nodes.Item(0).Cells(9).HostedControl = monedatext(ir("iva"))
            AdvTreeDetalles.Nodes.Item(0).Nodes.Item(0).Cells.Add(New DevComponents.AdvTree.Cell())
            AdvTreeDetalles.Nodes.Item(0).Nodes.Item(0).Cells(10).HostedControl = monedatext(ir("total"))

            If ir("otros") > 0 Then
                Dim ir2 As IDataReader

                cman = ConsultaSql("select * from pagotros where serie='" & serie & "' and  recibo=" & folio)
                ir2 = cman.ExecuteReader
                ir2.Read()

                AdvTreeDetalles.Nodes.Item(0).Nodes.Add(New DevComponents.AdvTree.Node())
                AdvTreeDetalles.Nodes.Item(0).Nodes.Item(1).Expand()
                AdvTreeDetalles.Nodes.Item(0).Nodes.Item(1).Cells(0).Text = "Desglose de otros "




                'AdvTreeDetalles.Nodes.Item(0).Nodes.Item(1).Cells(0).Imag = New Image("AcquaLiberVista.My.Resources.Resources.kwrite")
                AdvTreeDetalles.Nodes.Item(0).Nodes.Item(1).NodesColumns.Add(New DevComponents.AdvTree.ColumnHeader("Concepto"))
                AdvTreeDetalles.Nodes.Item(0).Nodes.Item(1).NodesColumns.Item(0).Width.Absolute = 300
                AdvTreeDetalles.Nodes.Item(0).Nodes.Item(1).NodesColumns.Add(New DevComponents.AdvTree.ColumnHeader("Subtotal"))
                AdvTreeDetalles.Nodes.Item(0).Nodes.Item(1).NodesColumns.Item(1).Width.Absolute = 70
                AdvTreeDetalles.Nodes.Item(0).Nodes.Item(1).NodesColumns.Add(New DevComponents.AdvTree.ColumnHeader("IVA"))
                AdvTreeDetalles.Nodes.Item(0).Nodes.Item(1).NodesColumns.Item(2).Width.Absolute = 70
                AdvTreeDetalles.Nodes.Item(0).Nodes.Item(1).NodesColumns.Add(New DevComponents.AdvTree.ColumnHeader("Total"))
                AdvTreeDetalles.Nodes.Item(0).Nodes.Item(1).NodesColumns.Item(3).Width.Absolute = 70

                For i = 1 To ir2.RecordsAffected
                    AdvTreeDetalles.Nodes.Item(0).Nodes.Item(1).Nodes.Add(New DevComponents.AdvTree.Node())

                    AdvTreeDetalles.Nodes.Item(0).Nodes.Item(1).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                    AdvTreeDetalles.Nodes.Item(0).Nodes.Item(1).Nodes.Item(i - 1).Cells(0).Text = (ir2("concepto"))

                    AdvTreeDetalles.Nodes.Item(0).Nodes.Item(1).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                    AdvTreeDetalles.Nodes.Item(0).Nodes.Item(1).Nodes.Item(i - 1).Cells(1).HostedControl = monedatext(ir2("subtotal"))
                    AdvTreeDetalles.Nodes.Item(0).Nodes.Item(1).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                    AdvTreeDetalles.Nodes.Item(0).Nodes.Item(1).Nodes.Item(i - 1).Cells(2).HostedControl = monedatext(ir2("iva"))
                    AdvTreeDetalles.Nodes.Item(0).Nodes.Item(1).Nodes.Item(i - 1).Cells.Add(New DevComponents.AdvTree.Cell())
                    AdvTreeDetalles.Nodes.Item(0).Nodes.Item(1).Nodes.Item(i - 1).Cells(3).HostedControl = monedatext(ir2("total"))
                    ir2.Read()
                Next

            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub DTmes_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles DTmes.DateSelected
        TabItem25.Text = cadenames(DTmes.SelectedDate)
        DTmes.Visible = False
        MuestraCierre(25)
    End Sub

    Private Sub txtbusNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbusNombre.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Try
            Cuenta = txtbusNombre.Text
            Comunidad = CmbComunidad.Text
            BuscarUsuario()
            ExBus.Expanded = False
        Catch EX As Exception
            If txtbusNombre.Text = "" Then
                MessageBox.Show("Selecciona una cuenta")
            Else
                MessageBox.Show(EX.Message)
            End If
        End Try
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Dim mens As String = "Introduzca el campo: " & DGBus.Columns.Item(DGBus.CurrentCell.ColumnIndex).Name
        Dim frmb As New frmBusCat(DGBus.Columns.Item(DGBus.CurrentCell.ColumnIndex).DataPropertyName, Fil, mens, DGBus.Item(DGBus.CurrentCell.ColumnIndex, DGBus.CurrentRow.Index).Value)
        frmb.ShowDialog()
    End Sub

    Private Sub txtbusNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusNombre.TextChanged
        If txtbusNombre.Text = "" Then
            Fil.Filter = ""
        Else
            Fil.Filter = "cuenta = " & Val(txtbusNombre.Text) & " "
        End If
    End Sub

    Private Sub CmbComunidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbComunidad.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
    Private Sub tabSalDia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabSalDia.Click
        CierreH.Cuenta = Cuenta
        CierreH.Comunidad = Comunidad
        CierreH.ultimo = True
        CierreH.Mostrar()
    End Sub

    Private Sub DgEstadosCuenta_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DgEstadosCuenta.CellFormatting
        If DgEstadosCuenta.Item("EstDescripcion", e.RowIndex).Value = "Activo" Then
            DgEstadosCuenta.Item("EstDescripcion", e.RowIndex).Style.BackColor = Color.LightGreen
        ElseIf LCase(DgEstadosCuenta.Item("EstDescripcion", e.RowIndex).Value) = "baja temporal" Then
            DgEstadosCuenta.Item("EstDescripcion", e.RowIndex).Style.BackColor = Color.Orange
        ElseIf LCase(DgEstadosCuenta.Item("EstDescripcion", e.RowIndex).Value) = "inactivo" Then
            DgEstadosCuenta.Item("EstDescripcion", e.RowIndex).Style.BackColor = Color.Gray
        ElseIf LCase(DgEstadosCuenta.Item("EstDescripcion", e.RowIndex).Value) = "baja" Then
            DgEstadosCuenta.Item("EstDescripcion", e.RowIndex).Style.BackColor = Color.Red
        End If

    End Sub

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        cmdImp.Text = "Imprimiendo..."
        cmdImp.Enabled = False
        Dim fecha As Date = Nothing
        Dim valor As Integer = 0
  
        Dim frm As New frmEstCuenta()
        frm.ShowDialog()
        Dim descomu As String = obtenerCampo("select comunidad from comunidades where id_comunidad='" & Comunidad & "'", "comunidad")
        Dim frmrepa As New frmReporte(frmReporte.Lista.HistoriaUsuario, "{vusuario1.cuenta}=" & Cuenta & " and {vusuario1.comunidad}='" & descomu & "'", "rez_con ,'" & CierreH._rez_con & "'", "rez_alca ,'" & CierreH._rez_alca & "'", "rez_san ,'" & CierreH._rez_san & "'", "rez_rec ,'" & _
                                      CierreH._rez_rec & "'", "rez_iva ,'" & CierreH._rez_iva & "'", "rez_tot ,'" & CierreH._tot_consua & "'", "act_con ,'" & CierreH._act_con & "'", "act_alca ,'" & CierreH._act_alca & "'", "act_san ,'" & CierreH._act_san & "'", "act_rec ,'" & _
                                      CierreH._act_rec & "'", "act_iva ,'" & CierreH._act_iva & "'", "act_tot ,'" & CierreH._tot_consun & "'", "t_con ,'" & CierreH._t_con & "'", "t_alca ,'" & CierreH._t_alca & "'", "t_san ,'" & CierreH._t_san & "'", "t_rec ,'" & CierreH._t_rec & "'", "t_iva ,'" & _
                                      CierreH._t_iva & "'", "t_total ,'" & CierreH._tot_gen1 & "'", "otrcargos ,'" & CierreH._otr_cargos & "'", "cargosmconsumo ,'" & CierreH._cargomconsumo & "'", "abodesc ,'" & CierreH._abodescu & "'", "totalfinal ,'" & CierreH._totalfinal & "'")



        frmrepa.objRepEsp.DetailSection2.SectionFormat.EnableSuppress = Not frm._cie
        frmrepa.objRepEsp.DetailSection3.SectionFormat.EnableSuppress = Not frm._lec
        If frm._lec Then
            fecha = DateAdd(DateInterval.Month, -frm._meses, Now)
            valor = obtenerCampo("select valornummes('" & MonthName(Month(fecha), True) & "'," & Year(fecha) & ") as valor", "valor")
            frmrepa.objRepEsp.Subreports.Item("Lecturas").RecordSelectionFormula = "{vlecturas1.Cuenta}=" & Cuenta & " and {vlecturas1.Comunidad}='" & Comunidad & "' and {vlecturas1.orden} >=" & valor & ""
        End If
        frmrepa.objRepEsp.DetailSection4.SectionFormat.EnableSuppress = Not frm._ordt
        frmrepa.objRepEsp.DetailSection5.SectionFormat.EnableSuppress = Not frm._carg
        frmrepa.objRepEsp.DetailSection6.SectionFormat.EnableSuppress = Not frm._abn

        frmrepa.MdiParent = MDIPrincipal
        frmrepa.Show()
        frmrepa.WindowState = FormWindowState.Maximized
        cmdImp.Enabled = True
        cmdImp.Text = "Imprimir"
    End Sub
    Private Sub TabFacturas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabFacturas.Click
        TabControl3.SelectedTab = TabItem27
    End Sub
    Private Sub ExBus_ExpandedChanged(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ExpandedChangeEventArgs) Handles ExBus.ExpandedChanged
        If ExBus.Expanded = True Then
            DGBus.Enabled = True
        End If
    End Sub

    Private Sub DgOrdenes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgOrdenes.DoubleClick
        Dim folio As Integer
        Try
            folio = DgOrdenes.Item("Folio", DgOrdenes.CurrentRow.Index).Value
            If folio > 0 Then
                Dim frmagr As New frmAgrOrd(folio, frmAgrOrd._tipo.Verificar)
                'frmagr.MdiParent = My.Forms.MDIPrincipal
                frmagr.ShowDialog()
                frmagr.WindowState = FormWindowState.Normal
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class