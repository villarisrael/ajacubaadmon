Imports CrystalDecisions.CrystalReports.Engine

Public Class frmNotificaciones
    Private Sub frmNotificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            llenarCombo(CmdRegion, "select id_region, region from region order by region")
        Catch ex As Exception

        End Try
        Try
            llenarCombo(cmbComunidades, "SELECT id_colonia,Colonia FROM colonia")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtMensaje_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtMensaje.MouseClick
        txtMensaje.ResetText()
    End Sub

    Private Sub chktodascolonia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmdRegion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdRegion.SelectedIndexChanged
        Try
            llenarCombo(CmbRuta, "select id_ruta, ruta from rutas order by ruta")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Try


            Dim filtro As String = String.Empty


            'Calcular saldo para las notificaciones Actopan 
            Dim filtromysql As String = String.Empty

            If rbruta.Checked Then
                If CmdRegion.SelectedIndex = -1 And CmbRuta.SelectedIndex = -1 Then
                    Try
                        MessageBox.Show("Seleccione los Region y Ruta para Continuar")
                        CmdRegion.Focus()
                        CmbRuta.Focus()
                    Catch ex As Exception
                        Me.Show()
                    End Try

                Else

                    If chkfijos.Checked And chkMedidos.Checked Then
                        filtro = "{vusuario1.region} = '" & CmdRegion.SelectedValue.ToString & "' and {vusuario1.ruta} = '" & CmbRuta.SelectedValue.ToString & "' and {vusuario1.nodeperiodo}>2 and {vusuario1.tarifa}<>'12'  and {vusuario1.tarifa}<>'11'"

                        filtromysql = "vusuario.region = '" & CmdRegion.SelectedValue.ToString & "' and vusuario.ruta = '" & CmbRuta.SelectedValue.ToString & "' and vusuario.nodeperiodo>2 and vusuario.tarifa<>'12'  and vusuario.tarifa<>'11'"
                    End If
                    If Not chkfijos.Checked And chkMedidos.Checked Then
                        filtro = "{vusuario1.region} = '" & CmdRegion.SelectedValue.ToString & "' and {vusuario1.ruta} = '" & CmbRuta.SelectedValue.ToString & "' and {vusuario1.nodeperiodo}>2 and  {vusuario1.medido}=1  and {vusuario1.tarifa}<>'12'  and {vusuario1.tarifa}<>'11'"

                        filtromysql = "vusuario.region = '" & CmdRegion.SelectedValue.ToString & "' and vusuario.ruta = '" & CmbRuta.SelectedValue.ToString & "' and vusuario.nodeperiodo>2 and  vusuario.medido=1  and vusuario.tarifa<>'12'  and vusuario.tarifa<>'11'"
                    End If
                    If chkfijos.Checked And Not chkMedidos.Checked Then
                        filtro = "{vusuario1.region} = '" & CmdRegion.SelectedValue.ToString & "' and {vusuario1.ruta} = '" & CmbRuta.SelectedValue.ToString & "' and {vusuario1.nodeperiodo}>2 and  {vusuario1.medido}=0 and  {vusuario1.tarifa}<>'12'  and {vusuario1.tarifa}<>'11'"

                        filtromysql = "vusuario.region = '" & CmdRegion.SelectedValue.ToString & "' and vusuario.ruta = '" & CmbRuta.SelectedValue.ToString & "' and vusuario.nodeperiodo>2 and  vusuario.medido=0 and  vusuario.tarifa<>'12'  and vusuario.tarifa<>'11'"

                    End If
                    If Not chkfijos.Checked And Not chkMedidos.Checked Then
                        MessageBox.Show("Debes activar al menos una opcion de medidos o fijos")
                        Return
                    End If



                End If
            End If

            If rbComunidad.Checked Then
                If cmbComunidades.SelectedIndex = -1 Then
                    MessageBox.Show("Seleccione la Colonia para Continuar")
                    cmbComunidades.Focus()
                Else
                    filtro = "{usuario1.id_colonia} = '" & cmbComunidades.SelectedValue.ToString & "'"

                    filtromysql = "usuario.id_colonia = '" & cmbComunidades.SelectedValue.ToString & "'"


                    If chkfijos.Checked And chkMedidos.Checked Then
                        filtro = "{vusuario1.id_colonia} = '" & cmbComunidades.SelectedValue.ToString & "' and {vusuario1.nodeperiodo}>2 and {vusuario1.tarifa}<>'12'  and {vusuario1.tarifa}<>'11' "

                        filtromysql = "vusuario.id_colonia = '" & cmbComunidades.SelectedValue.ToString & "' and vusuario.nodeperiodo>2 and vusuario.tarifa<>'12'  and vusuario.tarifa<>'11' "
                    End If


                    If Not chkfijos.Checked And chkMedidos.Checked Then
                        filtro = "{usuario1.id_colonia} = '" & cmbComunidades.SelectedValue.ToString & "' and {usuario1.nodeperiodo}>2 And {vusuario1.medido} = 1 and {vusuario1.tarifa}<>'12'  and {vusuario1.tarifa}<>'11'"

                        filtromysql = "usuario.id_colonia = '" & cmbComunidades.SelectedValue.ToString & "' and usuario.nodeperiodo>2 And vusuario.medido = 1 and vusuario.tarifa<>'12'  and vusuario.tarifa<>'11'"


                    End If
                    If chkfijos.Checked And Not chkMedidos.Checked Then
                        filtro = "{usuario1.id_colonia} = '" & cmbComunidades.SelectedValue.ToString & "' and {usuario1.nodeperiodo}>2 And {vusuario1.medido} = 0 and {vusuario1.tarifa}<>'12'  and {vusuario1.tarifa}<>'11'"

                        filtromysql = "usuario.id_colonia = '" & cmbComunidades.SelectedValue.ToString & "' and usuario.nodeperiodo>2 And vusuario.medido = 0 and vusuario.tarifa<>'12'  and vusuario.tarifa<>'11'"
                    End If


                    If Not chkfijos.Checked And Not chkMedidos.Checked Then
                        MessageBox.Show("Debes activar al menos una opcion de medidos o fijos")
                        Return
                    End If

                End If
            End If


            If rbCuenta.Checked Then
                If iiCuenta.Text = "" Then
                    MessageBox.Show("Escriba el Numero de Cuenta para Continuar")
                    cmbComunidades.Focus()
                Else
                    filtro = "{vusuario1.cuenta} = " & iiCuenta.Text.ToString & ""
                    filtromysql = "vusuario.cuenta = " & iiCuenta.Text.ToString & ""
                End If


            End If


            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Actualizar saldo de las notificaciones 28/10/2021
            ' UZIEL MÁRQUEZ, ISRAEL VILLAR

            Dim DatosNotificaciones As IDataReader = ConsultaSql("Select * from vusuario where " & filtromysql).ExecuteReader





            While DatosNotificaciones.Read()
                Dim cargoConcepto As String = "PROCEDIMIENTO ADMINISTRATIVO DE NOTIFICACION DE ADEUDO"
                Dim TotalXNotificacion As Decimal = 0.00
                Dim IVAxNotificacion As Decimal = 0.00
                Dim CargoxNotificacion As Decimal = 0.00
                Dim MontoNotificacion As String = String.Empty
                Dim CargarNotificacion As String = String.Empty

                MontoNotificacion = "select Monto_Inicial from conceptoscxc where Id_Concepto = 'SERPRO'"
                Dim Monto As Decimal = obtenerCampo(MontoNotificacion, "Monto_Inicial")
                Dim FechaActual As String = DateTime.Now.ToString("yyyy-MM-dd")
                Dim hoy As Date = Date.Now

                IVAxNotificacion = Math.Round(Monto * (VARIABLE_IVA / 100), 2)
                TotalXNotificacion = Monto + IVAxNotificacion

                Dim SubTotResta As Decimal = 0.00
                Dim IVAResta As Decimal = 0.00
                Dim Resta As Decimal = 0.00

                Dim VerificaNotificacion As String = String.Empty
                Dim cuenta As String = DatosNotificaciones("cuenta")
                Dim ID_Comunidad As String = DatosNotificaciones("id_comunidad")











                VerificaNotificacion = "select Resta from otrosconceptos where Id_Concepto = 'SERPRO' and cuenta = " & cuenta & " and Resta > 0 and pagado = 0"
                Dim Verifica As String = obtenerCampo(VerificaNotificacion, "Resta")




                If Verifica = "0" Then



                    'Si no tiene cargo de notificación, se inserta 

                    CargarNotificacion = "insert into otrosconceptos (Cuenta, Concepto, Total, Subtotal, IVA, Pagado, vencimiento, 
                    Observa, tabla, folio, Estado, Motivo, Fec_apli, Per_apli, Usuarioalta, Fec_alta, usuariobaja, 
                    fecha_baja, usuariocambio, fecha_ult_camb, id_comunidad, Abonos, Resta, tipo_mov, MES_PERIODo, AN_PER,  
                    Factura, Serie, Caja, Cod_Ofi, Convenio, Consumo, Drenaje, Saneamiento, Recargos, RepIVA, Otros,  
                    SubTotResta, IVAResta, PorcRec, PerVenc, TotRec, Id_Concepto, Cantidad) VALUES (" & cuenta & ",'" & cargoConcepto & "', " & TotalXNotificacion & "," & Monto & "," & IVAxNotificacion & ",0 , '" & FechaActual & "'," & "' ', " & "'MULTAS', ' ' , 'PENDIENTE', 'CARGO POR NOTIFICACION DE ADEUDO', '" & FechaActual & "', '' , " & NumUser & ", '" & FechaActual & "' , '' , '2000-01-01' , '', '2000-01-01', '" & ID_Comunidad & "', 0.00 , " & TotalXNotificacion & ", 'CARGO' , '" & NOMBREDEMES3CAR(hoy.Month) & "', " & Year(Now) & ", 0.0, '', '', '', 0.0, 0.0, 0.0, 0.0, 0.0, 0.0," & "0.0," & Monto & "," & IVAxNotificacion & ",0," & "0," & "0.0," & " 'SERPRO' " & ",1)"

                    Ejecucion(CargarNotificacion)

                    'Ejecucion("INSERT INTO otrosconceptos (Cuenta, Concepto, Total, Subtotal, IVA, Pagado, vencimiento, tabla, folio, Estado, Fec_apli, Fec_alta, fecha_baja, fecha_ult_camb, Resta, tipo_mov, MES_PERIODo, AN_PER,  SubTotResta, IVAResta, Id_Concepto) VALUES (" & cuentatxt.Text & ", '" & pago & "'," & pagar & ", 0, 0, " & False & ", '" & UnixDateFormat(fecha1.ToShortDateString) & "','todos', " & idConvenio & ",'pendiente', '" & UnixDateFormat(hoy) & "', '" & UnixDateFormat(hoy) & "', '" & UnixDateFormat(hoy) & "', '" & UnixDateFormat(hoy) & "', " & pagar & ", 'cargo', '" & NOMBREDEMES3CAR(hoy.Month) & "', " & Year(Now) & "," & pagar & ", 0, '" & My.Settings.claveConvenio & "')")



                Else
                    'Dim dr As IDataReader = ConsultaSql(VerificaNotificacion).ExecuteReader()
                    'dr.Read()

                    'Resta = dr("Resta")
                    Dim Cadena As String = "select * from otrosconceptos where Id_Concepto = 'SERPRO' and cuenta = " & cuenta & ""
                    'Dim VerificaMontos As String = obtenerCampo(Cadena, " * ")


                    Dim dr2 As IDataReader = ConsultaSql(Cadena).ExecuteReader()
                    dr2.Read()
                    SubTotResta = dr2("SubTotResta")
                    IVAResta = dr2("IVAResta")
                    Resta = dr2("Resta")
                    Dim Cantidad As Int32 = dr2("Cantidad")
                    Dim Meses As String = dr2("MES_PERIODO")
                    Dim ClaveConcepto As Int64 = dr2("Clave")





                    'CargarNotificacion = "update otrosconceptos set Total =" & Resta + TotalXNotificacion & ", Subtotal =" & SubTotResta + Monto & ", IVA =" & IVAResta + IVAxNotificacion & ", Fec_apli = '" & FechaActual & "', Resta = " & Resta + TotalXNotificacion & ", MES_PERIODO = '" & Meses & "," & NOMBREDEMES3CAR(hoy.Month) & "', AN_PER = '" & Year(Now) & "', SubTotResta = " & SubTotResta + Monto & ", IVAResta = " & IVAResta + IVAxNotificacion & ", Cantidad =" & Cantidad + 1 & " where cuenta = '" & cuenta & "' and Clave = '" & ClaveConcepto & "'"

                    CargarNotificacion = "update otrosconceptos set Total =" & Resta + TotalXNotificacion & ", Subtotal =" & SubTotResta + Monto & ", IVA =" & IVAResta + IVAxNotificacion & ", Fec_apli = '" & FechaActual & "', Resta = " & Resta + TotalXNotificacion & "," & " AN_PER = '" & Year(Now) & "', SubTotResta = " & SubTotResta + Monto & ", IVAResta = " & IVAResta + IVAxNotificacion & ", Cantidad =" & Cantidad + 1 & " where cuenta = '" & cuenta & "' and Clave = '" & ClaveConcepto & "'"

                    Ejecucion(CargarNotificacion)

                End If


                'Dim CargoNotificacion As String = String.Empty

                'Actaulizar saldos
                '(28/10/2021)

                Try
                    Dim datos As Odbc.OdbcDataReader
                    Dim total As Double
                    datos = ConsultaSql("select * from usuario USU inner join descuentos DES on(USU.idDescuento=DES.idDescuento) where cuenta=" & cuenta & "").ExecuteReader
                    datos.Read()
                    Dim pago As New Clscontrolpago
                    pago.cuenta = cuenta
                    pago.Tarifa = datos("Tarifa").ToString()
                    pago.Fechafinal = Now.AddMonths(-1)
                    pago.Fechainicio = datos("deudafec")
                    'pasar los parametros si contiene descuento, alcantarrillado y saneamiento

                    pago.saneamiento = datos("Saneamiento")
                    pago.alcantarillado = datos("alcantarillado")
                    pago.valvulista = datos("idCuotaValvulista")

                    If datos("idDescuento") > 0 Then

                        ''------ Descuentos
                        Try
                            pago.descontartodoslosperiodosdeconsumo = True
                        Catch ex As Exception

                        End Try

                        Try
                            pago.periodoscondescuentodeconsumo = Month(Now)
                        Catch ex As Exception

                        End Try

                        Try
                            pago.descuentoaconsumo = datos("nPctDsct")
                        Catch ex As Exception

                        End Try
                        ''------
                    Else
                        Try
                            pago.descontartodoslosperiodosdeconsumo = False
                        Catch ex As Exception

                        End Try

                        Try
                            pago.periodoscondescuentodeconsumo = 0
                        Catch ex As Exception

                        End Try

                        Try
                            pago.descuentoaconsumo = 0
                        Catch ex As Exception

                        End Try
                    End If

                    Try
                        If datos("id_Tarifa") = "4" Then
                            Ejecucion("Update lecturas Set  monto = consumomedidos(consumo,'1', " & Year(Now) & ")  where cuenta=" & datos("cuenta") & " and pagado=0 and an_per=" & Year(Now) & " and not ( mes= '" & MES_TEXTO(Month(Now)) & "' and an_per=" & Year(Now) & ");")

                        End If

                    Catch ex As Exception
                        'MessageBox.Show(ex.ToString())
                    End Try

                    pago.calcula(False)


                    Dim concepto As New Clsconcepto
                    Try

                        concepto = pago.Listadeconceptos.Item("PAGO VALVULISTA")
                    Catch ex As Exception

                    End Try

                    ' Rectifica el iva en los conceptos
                    Dim acumiva As Double = 0

                    For index = 1 To pago.Listadeconceptos.Count
                        Dim conce As New Clsconcepto
                        conce = pago.Listadeconceptos(index)
                        If conce.IVA > 0 Then
                            conce.IVA = Math.Round((conce.Cantidad * conce.Preciounitario) * (VARIABLE_IVA / 100), 2)
                        End If
                        acumiva += conce.IVA
                    Next

                    total = pago.totaldeudaconsumo + pago.totaldeudaalcantarillado + pago.totaldeudasaneamiento + acumiva + pago.totaldeudarecargos + pago.totaldeudaotros + concepto.importe

                    'Ejecucion("update usuario set deuda=" & pago.totaldeudaconsumo & " , deualcant=" & pago.totaldeudaalcantarillado & ", deudasanea=" & pago.totaldeudasaneamiento & ", iva=" & acumiva & ", recargos =" & pago.totaldeudarecargos & ", deudaotros=" & pago.totaldeudaotros + concepto.importe & ", total=" & total & ", LecturaAnt=UltimaLecturaActualizar('" & cuenta & "'), PeriodosAdeudo=" & pago.desgloseconsumo.Count + pago.desgloserezago.Count & ",periodo='" & pago.periodo & "'  where cuenta=" & cuenta)

                    Ejecucion("update usuario set deuda=" & pago.totaldeudaconsumo & " , deualcant=" & pago.totaldeudaalcantarillado & ", deudasanea=" & pago.totaldeudasaneamiento & ", iva=" & acumiva & ", recargos =" & pago.totaldeudarecargos & ", deudaotros=" & pago.totaldeudaotros + concepto.importe & ", total=" & total & ", LecturaAnt=PenUltimaLectura('" & cuenta & "'), 
                        " & "LecturaAct=UltimaLectura('" & cuenta & "')," & "PeriodosAdeudo=" & pago.desgloseconsumo.Count + pago.desgloserezago.Count & ",periodo='" & pago.periodo & "'  where cuenta=" & cuenta)

                    datos.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try


            End While

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            BtnCalcular.Enabled = False
            Dim Frm As New frmReporte(frmReporte.Lista.Notificaciones, filtro)
            '   Frm.MdiParent = My.Forms.MDIPrincipal
            Frm.Show()
            Frm.WindowState = FormWindowState.Maximized

            BtnCalcular.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Me.Show()
        End Try
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub CmbRuta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbRuta.SelectedIndexChanged

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Dim filtro As String = String.Empty

        Dim TIT As String = String.Empty
        If rbruta.Checked Then
            If CmdRegion.SelectedIndex = -1 And CmbRuta.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione los Region y Ruta para Continuar")
                CmdRegion.Focus()
                CmbRuta.Focus()
            Else

                If chkfijos.Checked And chkMedidos.Checked Then
                    filtro = "{vusuario1.region} = '" & CmdRegion.SelectedValue.ToString & "' and {vusuario1.ruta} = '" & CmbRuta.SelectedValue.ToString & "' and {vusuario1.nodeperiodo}>2 and {vusuario1.tarifa}<>'12'  and {vusuario1.tarifa}<>'11'"
                End If
                If Not chkfijos.Checked And chkMedidos.Checked Then
                    filtro = "{vusuario1.region} = '" & CmdRegion.SelectedValue.ToString & "' and {vusuario1.ruta} = '" & CmbRuta.SelectedValue.ToString & "' and {vusuario1.nodeperiodo}>2 and  {vusuario1.medido}=1  and {vusuario1.tarifa}<>'12'  and {vusuario1.tarifa}<>'11'"
                End If
                If chkfijos.Checked And Not chkMedidos.Checked Then
                    filtro = "{vusuario1.region} = '" & CmdRegion.SelectedValue.ToString & "' and {vusuario1.ruta} = '" & CmbRuta.SelectedValue.ToString & "' and {vusuario1.nodeperiodo}>2 and  {vusuario1.medido}=0 and  {vusuario1.tarifa}<>'12'  and {vusuario1.tarifa}<>'11'"
                End If
                If Not chkfijos.Checked And Not chkMedidos.Checked Then
                    MessageBox.Show("Debes activar al menos una opcion de medidos o fijos")
                    Return
                End If
            End If
            TIT = " REGION: " & CmdRegion.Text & "  RUTA: " & CmbRuta.Text

        End If

        If rbComunidad.Checked Then
            If cmbComunidades.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione la Colonia para Continuar")
                cmbComunidades.Focus()
            Else
                filtro = "{usuario1.id_colonia} = '" & cmbComunidades.SelectedValue.ToString & "'"
                If chkfijos.Checked And chkMedidos.Checked Then
                    filtro = "{vusuario1.id_colonia} = '" & cmbComunidades.SelectedValue.ToString & "' and {vusuario1.nodeperiodo}>2 and {vusuario1.tarifa}<>'12'  and {vusuario1.tarifa}<>'11' "
                End If
                If Not chkfijos.Checked And chkMedidos.Checked Then
                    filtro = "{usuario1.id_colonia} = '" & cmbComunidades.SelectedValue.ToString & "' and {usuario1.nodeperiodo}>2 And {vusuario1.medido} = 1 and {vusuario1.tarifa}<>'12'  and {vusuario1.tarifa}<>'11'"
                End If
                If chkfijos.Checked And Not chkMedidos.Checked Then
                    filtro = "{usuario1.id_colonia} = '" & cmbComunidades.SelectedValue.ToString & "' and {usuario1.nodeperiodo}>2 And {vusuario1.medido} = 0 and {vusuario1.tarifa}<>'12'  and {vusuario1.tarifa}<>'11'"
                End If
                If Not chkfijos.Checked And Not chkMedidos.Checked Then
                    MessageBox.Show("Debes activar al menos una opcion de medidos o fijos")
                    Return
                End If
                TIT = " COLONIA: " & cmbComunidades.SelectedText
            End If
        End If


        If rbCuenta.Checked Then
            If iiCuenta.Text = "" Then
                MessageBox.Show("Escriba el Numero de Cuenta para Continuar")
                cmbComunidades.Focus()
            Else
                filtro = "{vusuario1.cuenta} = " & iiCuenta.Text.ToString & ""
                TIT = "CUENTA: " & iiCuenta.Value
            End If
        End If

        BtnCalcular.Enabled = False
        Dim Frm As New frmReporte(frmReporte.Lista.ListaNotificaciones, filtro, "Titulo. " & TIT & "")
        '   Frm.MdiParent = My.Forms.MDIPrincipal
        Frm.Show()
        Frm.WindowState = FormWindowState.Maximized

        BtnCalcular.Enabled = True
    End Sub
End Class