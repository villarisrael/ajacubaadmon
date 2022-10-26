Imports System.Data.Odbc

Public Class frmEpagos
    Dim x As New base

    Dim datos As Odbc.OdbcDataReader
    Dim total As Double
    Private Sub btncrear_Click(sender As Object, e As EventArgs) Handles btncrear.Click

        StepIndicator1.StepCount = 3

        StepIndicator1.CurrentStep = 1

        Dim servicio As New Clspagoenlinea


        servicio.creaServicio(txtnombredelservicio.Text, My.Settings.basereporte)

        StepIndicator1.CurrentStep = 2


        PBExcel.Maximum = Val(obtenerCampo("select count(cuenta) as cuantos from usuario ", "cuantos"))
        datos = x.consultasql("select * from usuario USU inner join descuentos DES on(USU.idDescuento=DES.idDescuento)")
        Do While datos.Read()
            Dim cuenta As Integer
            cuenta = datos("cuenta")

            'cuenta = 2696
            Dim pago As New Clscontrolpago
            pago.cuenta = cuenta
            pago.Tarifa = datos("Tarifa").ToString()
            pago.Fechafinal = Now ' Date.Parse("2018-08-29") 'Now
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

            pago.calcula(False)

            PBExcel.Value = PBExcel.Value + 1
            PBExcel.Text = Math.Round((PBExcel.Value * 100) / PBExcel.Maximum, 2)

            Dim concepto As New Clsconcepto
            Try

                concepto = pago.Listadeconceptos.Item("PAGO VALVULISTA")
            Catch ex As Exception

            End Try

            pago.rectificaiva()
            ' Rectifica el iva en los conceptos
            Dim acumiva As Double = 0

            For index = 1 To pago.Listadeconceptos.Count
                Dim conce As New Clsconcepto
                conce = pago.Listadeconceptos(index)
                'If conce.IVA > 0 Then
                '    conce.IVA = Math.Round((conce.Cantidad * conce.Preciounitario) * (VARIABLE_IVA / 100), 2)
                'End If
                acumiva += conce.IVA
            Next


            total = pago.totaldeudaconsumo + pago.totaldeudaalcantarillado + pago.totaldeudasaneamiento + acumiva + pago.totaldeudarecargos + pago.totaldeudaotros + concepto.importe

            If total > 0 And pago.EsMEdido = True Then
                servicio.pasalecturas(txtnombredelservicio.Text, My.Settings.basereporte, cuenta)
                servicio.paragenerarfactura(txtnombredelservicio.Text, My.Settings.basereporte, cuenta, pago.Listadeconceptos)
            End If

            Ejecucion("update usuario set deuda=" & pago.totaldeudaconsumo & " , deualcant=" & pago.totaldeudaalcantarillado & ", deudasanea=" & pago.totaldeudasaneamiento & ", iva=" & acumiva & ", recargos =" & pago.totaldeudarecargos & ", deudaotros=" & pago.totaldeudaotros + concepto.importe & ", total=" & total & ", LecturaAnt=UltimaLectura('" & cuenta & "'), PeriodosAdeudo=" & pago.desgloseconsumo.Count + pago.desgloserezago.Count & ", periodo='" & pago.periodo & "'  where cuenta=" & cuenta)

            Application.DoEvents()

        Loop

        x.conexion.Dispose()

        StepIndicator1.CurrentStep = 3
        Application.DoEvents()

        Dim da As New OdbcDataAdapter("select * from vbancomer", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        ToExcelepagos2(dt, PBExcel)

        PBExcel.Value = 0
        StepIndicator1.CurrentStep = 0

    End Sub

    Private Sub frmEpagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StepIndicator1.CurrentStep = 0
    End Sub
End Class