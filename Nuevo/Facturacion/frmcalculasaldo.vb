Public Class frmcalculasaldo


    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click

        Dim x As New base

        Dim datos As Odbc.OdbcDataReader
        Dim total As Double

        If rbruta.Checked And CmdRegion.SelectedIndex = -1 Then
            'MessageBoxEx.Show("No especificaste la Region", "Calculo de Consumo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'CmdRegion.Select()
            'Exit Sub
            PB.Maximum = Val(obtenerCampo("select count(cuenta) as cuantos from usuario", "cuantos"))
            datos = x.consultasql("select * from usuario USU inner join descuentos DES on(USU.idDescuento=DES.idDescuento)")
        End If

        If rbruta.Checked And CmdRegion.SelectedIndex > -1 And CmbRuta.SelectedIndex = -1 Then
            'MessageBoxEx.Show("No especificaste la Region", "Calculo de Consumo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'CmdRegion.Select()
            'Exit Sub
            PB.Maximum = Val(obtenerCampo("select count(cuenta) as cuantos from usuario where region='" & CmdRegion.SelectedValue & "'", "cuantos"))
            datos = x.consultasql("select * from usuario USU inner join descuentos DES on(USU.idDescuento=DES.idDescuento) where region='" & CmdRegion.SelectedValue & "'")
        End If

        If rbruta.Checked And CmdRegion.SelectedIndex > -1 And CmbRuta.SelectedIndex > -1 Then
            'MessageBoxEx.Show("No especificaste la Region", "Calculo de Consumo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'CmdRegion.Select()
            'Exit Sub
            PB.Maximum = Val(obtenerCampo("select count(cuenta) as cuantos from usuario where region='" & CmdRegion.SelectedValue & "' and  ruta ='" & CmbRuta.SelectedValue & "'", "cuantos"))
            datos = x.consultasql("select * from usuario USU inner join descuentos DES on(USU.idDescuento=DES.idDescuento) where region='" & CmdRegion.SelectedValue & "' and ruta='" & CmbRuta.SelectedValue & "'")
        End If

        If rbComunidad.Checked And cmbComunidades.Text <> "" Then
            PB.Maximum = Val(obtenerCampo("select count(cuenta) as cuantos from usuario where id_comunidad='" & cmbComunidades.SelectedValue & "'", "cuantos"))
            datos = x.consultasql("select * from usuario USU inner join descuentos DES on(USU.idDescuento=DES.idDescuento) where id_comunidad='" & cmbComunidades.SelectedValue & "'")
        End If
        If rbComunidad.Checked And cmbComunidades.Text = "" Then
            MessageBox.Show("No seleccionaste comunidad")
            Return
        End If


        '*** * * * 
        If rbCuenta.Checked Then
            If iiCuenta.Text = "" Then
                MessageBox.Show("Falta el Numero de Cuenta ")
                iiCuenta.Focus()
            Else
                PB.Maximum = 1 'Val(obtenerCampo("select count(cuenta) as cuantos from usuario where id_comunidad='" & cmbComunidades.SelectedValue & "'", "cuantos"))
                datos = x.consultasql("select * from usuario USU inner join descuentos DES on(USU.idDescuento=DES.idDescuento) where cuenta='" & iiCuenta.Text & "'")
            End If
            
        End If

        If rbtodos.Checked Then
            
            PB.Maximum = Val(obtenerCampo("select count(cuenta) as cuantos from usuario ", "cuantos"))
            datos = x.consultasql("select * from usuario USU inner join descuentos DES on(USU.idDescuento=DES.idDescuento)")


        End If

        CmdRegion.Enabled = False
        CmbRuta.Enabled = False
        BtnCalcular.Enabled = False
        BtnSalir.Enabled = False
        PB.Visible = True
        ' PB.Maximum = Val(obtenerCampo("select count(cuenta) as cuantos from usuario where region='" & CmdRegion.SelectedValue & "'", "cuantos"))
        ' Dim x As New base

        'Dim datos As Odbc.OdbcDataReader

        'datos = x.consultasql("select * from usuario where region='" & CmdRegion.SelectedValue & "'")



        Do While datos.Read()


            Try

                Dim cuenta As Integer
                cuenta = datos("cuenta")

                CorroborarPeriodosPagados(cuenta)

                Dim tipoServicio = Val(obtenerCampo($"select medido as tipoServicio from vusuario WHERE CUENTA = {cuenta}", "medido"))

                Dim pago As New Clscontrolpago
                pago.cuenta = cuenta
                pago.Tarifa = datos("Tarifa").ToString()

                If tipoServicio = 1 Then
                    pago.Fechafinal = Now.AddMonths(-1)
                Else
                    pago.Fechafinal = Now.AddMonths(0)
                End If

                pago.Fechainicio = datos("deudafec")
                'pasar los parametros si contiene descuento, alcantarrillado y saneamiento

                pago.saneamiento = datos("Saneamiento")
                pago.alcantarillado = datos("alcantarillado")
                pago.valvulista = datos("idCuotaValvulista")

                'Corroborar que no haya lecturas pagadas por anticipado sin estatus pagado = 1
                If tipoServicio Then
                    LecturasPagadasxAnticipado(cuenta)
                End If


                Try
                    Dim MESANTERIOR As Integer = Now.Month - 1
                    Dim ANANTERIOR As Integer = Now.Year
                    If MESANTERIOR = 0 Then MESANTERIOR = 12
                    If MESANTERIOR = 12 Then ANANTERIOR = Now.Year - 1



                Catch ex As Exception
                    MessageBox.Show(ex.Message())
                End Try




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


                pago.calcula(False)

                PB.Value = PB.Value + 1
                PB.Text = Math.Round((PB.Value * 100) / PB.Maximum, 2)

                Dim concepto As New Clsconcepto
                'Try

                '    concepto = pago.Listadeconceptos.Item("PAGO VALVULISTA")
                'Catch ex As Exception

                'End Try

                '' Rectifica el iva en los conceptos
                Dim acumiva As Double = 0

                For index = 1 To pago.Listadeconceptos.Count
                    Dim conce As New Clsconcepto
                    conce = pago.Listadeconceptos(index)

                    acumiva += conce.IVA
                Next


                Dim estadot As String = datos("estado")
                Dim mostrar As String = obtenerCampo("select mostrar from estadotoma where clave=" + estadot + "", "mostrar")
                If mostrar = "1" Then
                    total = Math.Round(pago.totaldeudaconsumo, 2) + pago.totaldeudaalcantarillado + pago.totaldeudasaneamiento + acumiva + pago.totaldeudarecargos + pago.totaldeudaotros + concepto.importe
                    Ejecucion("update usuario set deuda=" & pago.totaldeudaconsumo & " , deualcant=" & pago.totaldeudaalcantarillado & ", deudasanea=" & pago.totaldeudasaneamiento & ", iva=" & acumiva & ", recargos =" & pago.totaldeudarecargos & ", deudaotros=" & pago.totaldeudaotros + concepto.importe & ", total=" & total & ", LecturaAct=UltimaLectura(" & cuenta & "), LecturaAnt=PenUltimaLectura(" & cuenta & "), PeriodosAdeudo=" & pago.desgloseconsumo.Count + pago.desgloserezago.Count & ",periodo='" & pago.periodo & "' where cuenta=" & cuenta)
                Else
                    Ejecucion("update usuario set deuda=0 , deualcant=0, deudasanea=0, iva=0, recargos =0, deudaotros=0, total=0,  LecturaAct=UltimaLectura(" & cuenta & "), LecturaAnt=PenUltimaLectura(" & cuenta & "), PeriodosAdeudo=0,periodo='' where cuenta=" & cuenta)
                    End If





                    Application.DoEvents()

                Catch ex As Exception
                    MessageBox.Show(ex.Message())
            End Try
        Loop
        CmdRegion.Enabled = True
        x.conexion.Dispose()
        MessageBox.Show("La Actualizacion de Saldos ha Finalizado.")
        Close()

    End Sub

    Private Sub frmcalculasaldo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            llenarCombo(CmdRegion, "select id_region, region from region order by region")
        Catch ex As Exception

        End Try
        Try
            llenarCombo(cmbComunidades, "SELECT Id_comunidad,Comunidad FROM comunidades")
        Catch ex As Exception

        End Try
        WindowState = FormWindowState.Normal
    End Sub

    Private Sub CmdRegion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            llenarCombo(CmbRuta, "select id_ruta, ruta from rutas where id_region='" & CmdRegion.SelectedValue & "' order by ruta")
        Catch ex As Exception

        End Try


    End Sub

    Private Sub LblTitulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTitulo.Click

    End Sub

    Private Sub CmdRegion_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdRegion.SelectedIndexChanged
        Try
            llenarCombo(CmbRuta, "select id_ruta, ruta from rutas where id_region='" & CmdRegion.SelectedValue & "' order by ruta")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Close()
    End Sub


End Class