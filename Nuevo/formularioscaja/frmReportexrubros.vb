﻿Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmReportexrubros
    Public tipo As String


    Private Sub FrmReportexrubros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If tipo = "Caja" Then
            Me.Text = "CORTE DE CAJA "
            txtcaja.Visible = True
        End If
        If tipo = "CAJADESGLOZADO" Then
            Me.Text = "CORTE DE CAJA DESGLOZADO "
            txtcaja.Visible = True
        End If
        If tipo = "Auditoria" Then
            Me.Text = "Corte de auditoria "
            txtcaja.Visible = False
        End If
        If tipo = "RESUMEN" Then
            Me.Text = "RESUMEN DIARIO "
            txtcaja.Visible = True
        End If

        If tipo = "CONCEPTOS" Then
            Me.Text = "CORTE DE CONCEPTOS "
            txtcaja.Visible = True
        End If

        If tipo = "RUBROS" Then
            Me.Text = "CORTE POR RUBROS "
            txtcaja.Visible = True
        End If
        If tipo = "TARIFA" Then
            Me.Text = "CORTE POR TARIFAS "
            txtcaja.Visible = True
        End If
        dtpfechainicio.SelectionRange.Start = Now
        dtpfechafinal.SelectionRange.End = Now
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Close()
    End Sub

    Private Sub dtpfechainicio_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles dtpfechainicio.DateChanged
        dtpfechafinal.MinDate = dtpfechainicio.SelectionRange.Start
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
      
        Dim filtro As String
        Dim filtromysql As String

        Dim SqlITSharp As String
        Dim SqlITSharpVIRTUALES As String

        Dim sqlDescuentosRecargos As String
        Dim sqlformasdepago As String


        Select Case tipo.ToUpper
            Case "CAJA"



                SqlITSharp = "select * from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' order by serie,recibo"

                SqlITSharpVIRTUALES = "SELECT count(concat(Serie, recibo)) as cuantos ,descuento, sum(descuentopesos) as virtuales from pagos  where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "'  and cancelado='A'  group by descuento"

                sqlDescuentosRecargos = $"SELECT sum(Descuento) as SumaDescuentos, Concepto, Porcentaje_Descuento from grabardescuentos_recargos WHERE FECHA_ACTUAL BETWEEN '{ dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") }' AND '{dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd")}' and cancelado='A'  group by Porcentaje_Descuento"

                sqlformasdepago = "select count(concat(serie,recibo)) as cuantos,  ccodpago, sum(total) as total  from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and cancelado='A' group by ccodpago"

                If txtcaja.Text <> "" And IIfolioinicial.Value = 0 And IIfoliofinal.Value = 0 Then

                    SqlITSharp = "select * from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "'" & " order by serie, recibo"

                    SqlITSharpVIRTUALES = "SELECT count(concat(Serie, recibo)) as cuantos,descuento, sum(descuentopesos) as virtuales from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "'" & " and cancelado='A'  group by descuento"

                    sqlDescuentosRecargos = $"SELECT sum(Descuento) as SumaDescuentos, Concepto, Porcentaje_Descuento from grabardescuentos_recargos WHERE FECHA_ACTUAL BETWEEN '{ dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") }' AND '{ dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") }' AND CAJA = { txtcaja.Text } and cancelado='A'  group by Porcentaje_Descuento"

                    'sqlDescuentosRecargos = $" "
                    sqlformasdepago = "select count(concat(serie,recibo)) as cuantos,  ccodpago, sum(total)  as total from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "' and cancelado='A'  group by ccodpago"

                End If

                If txtcaja.Text <> "" And IIfolioinicial.Value > 0 And IIfoliofinal.Value > 0 Then

                    SqlITSharp = "select * from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "'" & " and recibo>=" & IIfolioinicial.Value & " and recibo<=" & IIfoliofinal.Value & " order by serie, recibo"

                    SqlITSharpVIRTUALES = "SELECT count(concat(Serie, recibo)) as cuantos,descuento, sum(descuentopesos) as virtuales from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "'" & "  and recibo>=" & IIfolioinicial.Value & " and recibo<=" & IIfoliofinal.Value & " And cancelado ='A'  group by descuento"

                    sqlDescuentosRecargos = $"SELECT sum(Descuento) as SumaDescuentos, Concepto, Porcentaje_Descuento from grabardescuentos_recargos WHERE FECHA_ACTUAL BETWEEN '{ dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") }' AND '{ dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") }' AND CAJA = { txtcaja.Text } and cancelado='A' and recibo>=" & IIfolioinicial.Value & " and recibo<=" & IIfoliofinal.Value & " group by Porcentaje_Descuento"

                    ' 'sqlDescuentosRecargos = $" "
                    sqlformasdepago = "Select count(concat(serie,recibo)) As cuantos,  ccodpago, sum(total)  As total from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "' and cancelado='A' and recibo>=" & IIfolioinicial.Value & " and recibo<=" & IIfoliofinal.Value & "  group by ccodpago"

                End If



                Dim ObjCorteCaja As New CorteCajaITSharp
                ObjCorteCaja.CorteDiario(SqlITSharp, dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & " AL " & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd"), txtcaja.Text, SqlITSharpVIRTUALES, sqlDescuentosRecargos, sqlformasdepago)
                Exit Sub

            Case "CAJADESGLOSADO"



                SqlITSharp = "select * from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' order by serie,recibo"

                SqlITSharpVIRTUALES = "SELECT count(concat(Serie, recibo)) as cuantos ,descuento, sum(descuentopesos) as virtuales from pagos  where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "'  and cancelado='A'  group by descuento"

                sqlDescuentosRecargos = $"SELECT sum(Descuento) as SumaDescuentos, Concepto, Porcentaje_Descuento from grabardescuentos_recargos WHERE FECHA_ACTUAL BETWEEN '{ dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") }' AND '{dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd")}' and cancelado='A'  group by Porcentaje_Descuento"

                sqlformasdepago = "select count(concat(serie,recibo)) as cuantos,  ccodpago, sum(total) as total  from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and cancelado='A' group by ccodpago"

                If txtcaja.Text <> "" And IIfolioinicial.Value = 0 And IIfoliofinal.Value = 0 Then

                    SqlITSharp = "select * from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "'" & " order by serie, recibo"

                    SqlITSharpVIRTUALES = "SELECT count(concat(Serie, recibo)) as cuantos,descuento, sum(descuentopesos) as virtuales from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "'" & " and cancelado='A'  group by descuento"

                    sqlDescuentosRecargos = $"SELECT sum(Descuento) as SumaDescuentos, Concepto, Porcentaje_Descuento from grabardescuentos_recargos WHERE FECHA_ACTUAL BETWEEN '{ dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") }' AND '{ dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") }' AND CAJA = { txtcaja.Text } and cancelado='A'  group by Porcentaje_Descuento"

                    'sqlDescuentosRecargos = $" "
                    sqlformasdepago = "select count(concat(serie,recibo)) as cuantos,  ccodpago, sum(total)  as total from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "' and cancelado='A'  group by ccodpago"

                End If

                If txtcaja.Text <> "" And IIfolioinicial.Value > 0 And IIfoliofinal.Value > 0 Then

                    SqlITSharp = "select * from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "'" & " and recibo>=" & IIfolioinicial.Value & " and recibo<=" & IIfoliofinal.Value & " order by serie, recibo"

                    SqlITSharpVIRTUALES = "SELECT count(concat(Serie, recibo)) as cuantos,descuento, sum(descuentopesos) as virtuales from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "'" & "  and recibo>=" & IIfolioinicial.Value & " and recibo<=" & IIfoliofinal.Value & " And cancelado ='A'  group by descuento"

                    sqlDescuentosRecargos = $"SELECT sum(Descuento) as SumaDescuentos, Concepto, Porcentaje_Descuento from grabardescuentos_recargos WHERE FECHA_ACTUAL BETWEEN '{ dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") }' AND '{ dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") }' AND CAJA = { txtcaja.Text } and cancelado='A' and recibo>=" & IIfolioinicial.Value & " and recibo<=" & IIfoliofinal.Value & " group by Porcentaje_Descuento"

                    ' 'sqlDescuentosRecargos = $" "
                    sqlformasdepago = "Select count(concat(serie,recibo)) As cuantos,  ccodpago, sum(total)  As total from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "' and cancelado='A' and recibo>=" & IIfolioinicial.Value & " and recibo<=" & IIfoliofinal.Value & "  group by ccodpago"

                End If



                Dim ObjCorteCaja As New RptCajaDesglozado
                ObjCorteCaja.CorteDiario(SqlITSharp, dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & " AL " & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd"), txtcaja.Text, SqlITSharpVIRTUALES, sqlDescuentosRecargos, sqlformasdepago)
                Exit Sub


            Case "RECONEXIONES"



                SqlITSharp = "select pagos.* from pagos inner join pagotros on pagos.serie=pagotros.serie and pagos.recibo=pagotros.recibo  where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and pagotros.concepto like 'reconexi%' order by pagos.serie,pagos.recibo"

                'SqlITSharpVIRTUALES = "SELECT count(concat(Serie, recibo)) as cuantos ,descuento, sum(descuentopesos) as virtuales from pagos  where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "'  and cancelado='A'  group by descuento"

                'sqlDescuentosRecargos = $"SELECT sum(Descuento) as SumaDescuentos, Concepto, Porcentaje_Descuento from grabardescuentos_recargos WHERE FECHA_ACTUAL BETWEEN '{ dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") }' AND '{dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd")}' and cancelado='A'  group by Porcentaje_Descuento"

                'sqlformasdepago = "select count(concat(serie,recibo)) as cuantos,  ccodpago, sum(total) as total  from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and cancelado='A' group by ccodpago"

                If txtcaja.Text <> "" And IIfolioinicial.Value = 0 And IIfoliofinal.Value = 0 Then

                    SqlITSharp = "select pago.* from pagos  pagos inner join pagotros on pagos.serie=pagotros.serie and pagos.recibo=pagotros.recibo where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "'" & " order by serie, recibo"

                    'SqlITSharpVIRTUALES = "SELECT count(concat(Serie, recibo)) as cuantos,descuento, sum(descuentopesos) as virtuales from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "'" & " and cancelado='A'  group by descuento"

                    'sqlDescuentosRecargos = $"SELECT sum(Descuento) as SumaDescuentos, Concepto, Porcentaje_Descuento from grabardescuentos_recargos WHERE FECHA_ACTUAL BETWEEN '{ dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") }' AND '{ dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") }' AND CAJA = { txtcaja.Text } and cancelado='A'  group by Porcentaje_Descuento"

                    ''sqlDescuentosRecargos = $" "
                    'sqlformasdepago = "select count(concat(serie,recibo)) as cuantos,  ccodpago, sum(total)  as total from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "' and cancelado='A'  group by ccodpago"

                End If

                If txtcaja.Text <> "" And IIfolioinicial.Value > 0 And IIfoliofinal.Value > 0 Then

                    SqlITSharp = "select pagos.* from  pagos inner join pagotros on pagos.serie=pagotros.serie and pagos.recibo=pagotros.recibo where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "'" & " and pagos.recibo>=" & IIfolioinicial.Value & " and pagos.recibo<=" & IIfoliofinal.Value & " order by pagos.serie, pagos.recibo"

                    'SqlITSharpVIRTUALES = "SELECT count(concat(Serie, recibo)) as cuantos,descuento, sum(descuentopesos) as virtuales from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "'" & "  and recibo>=" & IIfolioinicial.Value & " and recibo<=" & IIfoliofinal.Value & " And cancelado ='A'  group by descuento"

                    'sqlDescuentosRecargos = $"SELECT sum(Descuento) as SumaDescuentos, Concepto, Porcentaje_Descuento from grabardescuentos_recargos WHERE FECHA_ACTUAL BETWEEN '{ dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") }' AND '{ dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") }' AND CAJA = { txtcaja.Text } and cancelado='A' and recibo>=" & IIfolioinicial.Value & " and recibo<=" & IIfoliofinal.Value & " group by Porcentaje_Descuento"

                    '' 'sqlDescuentosRecargos = $" "
                    'sqlformasdepago = "Select count(concat(serie,recibo)) As cuantos,  ccodpago, sum(total)  As total from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "' and cancelado='A' and recibo>=" & IIfolioinicial.Value & " and recibo<=" & IIfoliofinal.Value & "  group by ccodpago"

                End If



                Dim ObjCorteCaja As New rptReporteReconexiones
                ObjCorteCaja.CorteDiario(SqlITSharp, dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & " AL " & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd"), txtcaja.Text, SqlITSharpVIRTUALES, sqlDescuentosRecargos, sqlformasdepago)
                Exit Sub


            Case "Auditoria"
                filtro = "{encfac1.fecha}>=DateTime(" & dtpfechainicio.SelectionRange.Start.Year & "," & dtpfechainicio.SelectionRange.Start.Month & "," & dtpfechainicio.SelectionRange.Start.Day & ",00,01,00) And {encfac1.fecha}<=DateTime(" & dtpfechafinal.SelectionRange.Start.Year & "," & dtpfechafinal.SelectionRange.Start.Month & "," & dtpfechafinal.SelectionRange.Start.Day & ",23,59,00) "
            Case "CONCEPTOS"


                SqlITSharp = "select numconcepto, concepto, sum(cantidad*monto) as total,iva,sum(montoiva) as Montoiva from pagotros where fecha between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and cancelado='A' group by numconcepto,iva"

                SqlITSharpVIRTUALES = "SELECT count(concat(Serie, recibo)) as cuantos ,descuento, sum(descuentopesos) as virtuales from pagos  where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "'  and cancelado='A'  group by descuento"

                sqlDescuentosRecargos = $"SELECT sum(Descuento) as SumaDescuentos, Concepto, Porcentaje_Descuento from grabardescuentos_recargos WHERE FECHA_ACTUAL BETWEEN '{ dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") }' AND '{dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd")}' and cancelado='A'  group by Porcentaje_Descuento"

                sqlformasdepago = "select count(concat(serie,recibo)) as cuantos,  ccodpago, sum(total) as total  from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and cancelado='A' group by ccodpago"

                If txtcaja.Text <> "" And IIfolioinicial.Value = 0 And IIfoliofinal.Value = 0 Then

                    SqlITSharp = "select numconcepto,concepto, sum(pagos) as total,iva,sum(montoiva) as Montoiva from pagotros where fecha between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and  cancelado='A' and caja=" & txtcaja.Text & " group by numconcepto,iva"

                    SqlITSharpVIRTUALES = "SELECT count(concat(Serie, recibo)) as cuantos,descuento, sum(descuentopesos) as virtuales from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "'" & " and cancelado='A'  group by descuento"

                    sqlDescuentosRecargos = $"SELECT sum(Descuento) as SumaDescuentos, Concepto, Porcentaje_Descuento from grabardescuentos_recargos WHERE FECHA_ACTUAL BETWEEN '{ dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") }' AND '{ dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") }' AND CAJA = { txtcaja.Text } and cancelado='A'  group by Porcentaje_Descuento"

                    'sqlDescuentosRecargos = $" "
                    sqlformasdepago = "select count(concat(serie,recibo)) as cuantos,  ccodpago, sum(total)  as total from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "' and cancelado='A'  group by ccodpago"

                End If

                If txtcaja.Text <> "" And IIfolioinicial.Value > 0 And IIfoliofinal.Value > 0 Then


                    SqlITSharp = "select numconcepto,concepto, sum(cantidad*Monto) as total,iva,sum(montoiva) as Montoiva from pagotros where fecha between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "'  and Caja = '" & txtcaja.Text & "'" & " and recibo>=" & IIfolioinicial.Value & " and recibo<=" & IIfoliofinal.Value & " and cancelado='A' group by numconcepto,iva"

                    SqlITSharpVIRTUALES = "SELECT count(concat(Serie, recibo)) as cuantos,descuento, sum(descuentopesos) as virtuales from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "'" & "  and recibo>=" & IIfolioinicial.Value & " and recibo<=" & IIfoliofinal.Value & " And cancelado ='A'  group by descuento"

                    sqlDescuentosRecargos = $"SELECT sum(Descuento) as SumaDescuentos, Concepto, Porcentaje_Descuento from grabardescuentos_recargos WHERE FECHA_ACTUAL BETWEEN '{ dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") }' AND '{ dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") }' AND CAJA = { txtcaja.Text } and cancelado='A' and recibo>=" & IIfolioinicial.Value & " and recibo<=" & IIfoliofinal.Value & " group by Porcentaje_Descuento"

                    ' 'sqlDescuentosRecargos = $" "
                    sqlformasdepago = "Select count(concat(serie,recibo)) As cuantos,  ccodpago, sum(total)  As total from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "' and cancelado='A' and recibo>=" & IIfolioinicial.Value & " and recibo<=" & IIfoliofinal.Value & "  group by ccodpago"

                End If

                Dim ObjCorteCaja As New cortexrubros
                ObjCorteCaja.CorteDiario(SqlITSharp, dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & " AL " & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd"), txtcaja.Text, SqlITSharpVIRTUALES, sqlDescuentosRecargos, sqlformasdepago)
                Exit Sub
            Case "RESUMEN"

                SqlITSharp = "select FECHA_aCT AS FECHA, SUM(PAGOS) AS SUBTOTAL, SUM(IVA) AS IVA, SUM(TOTAL) AS TOTAL , SUM(DESCUENTOPESOS) AS DESCUENTO FROM PAgOS where fecha_aCT between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and cancelado='A' group by FECHA_aCT"

                SqlITSharpVIRTUALES = "SELECT count(concat(Serie, recibo)) as cuantos ,descuento, sum(descuentopesos) as virtuales from pagos  where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "'  and cancelado='A'  group by descuento"

                sqlDescuentosRecargos = $"SELECT sum(Descuento) as SumaDescuentos, Concepto, Porcentaje_Descuento from grabardescuentos_recargos WHERE FECHA_ACTUAL BETWEEN '{ dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") }' AND '{dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd")}' and cancelado='A'  group by Porcentaje_Descuento"

                sqlformasdepago = "select count(concat(serie,recibo)) as cuantos,  ccodpago, sum(total) as total  from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and cancelado='A' group by ccodpago"

                If txtcaja.Text <> "" And IIfolioinicial.Value = 0 And IIfoliofinal.Value = 0 Then


                    SqlITSharp = "Select FECHA_aCT As FECHA, SUM(PAGOS) As SUBTOTAL, SUM(IVA) As IVA, SUM(TOTAL) As TOTAL , SUM(DESCUENTOPESOS) As DESCUENTO FROM PAgOS where fecha_aCT between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and cancelado='A'  and caja=" & txtcaja.Text & " group by FECHA_aCT"

                    SqlITSharpVIRTUALES = "SELECT count(concat(Serie, recibo)) as cuantos,descuento, sum(descuentopesos) as virtuales from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "'" & " and cancelado='A'  group by descuento"

                    sqlDescuentosRecargos = $"SELECT sum(Descuento) as SumaDescuentos, Concepto, Porcentaje_Descuento from grabardescuentos_recargos WHERE FECHA_ACTUAL BETWEEN '{ dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") }' AND '{ dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") }' AND CAJA = { txtcaja.Text } and cancelado='A'  group by Porcentaje_Descuento"

                    'sqlDescuentosRecargos = $" "
                    sqlformasdepago = "select count(concat(serie,recibo)) as cuantos,  ccodpago, sum(total)  as total from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "' and cancelado='A'  group by ccodpago"

                End If

                If txtcaja.Text <> "" And IIfolioinicial.Value > 0 And IIfoliofinal.Value > 0 Then

                    SqlITSharp = "Select FECHA_aCT As FECHA, SUM(PAGOS) As SUBTOTAL, SUM(IVA) As IVA, SUM(TOTAL) As TOTAL , SUM(DESCUENTOPESOS) As DESCUENTO FROM PAgOS where fecha_aCT between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and cancelado='A'  and caja=" & txtcaja.Text & " and recibo>=" & IIfolioinicial.Value & " and recibo<=" & IIfoliofinal.Value & "   group by FECHA_aCT"


                    SqlITSharpVIRTUALES = "SELECT count(concat(Serie, recibo)) as cuantos,descuento, sum(descuentopesos) as virtuales from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "'" & "  and recibo>=" & IIfolioinicial.Value & " and recibo<=" & IIfoliofinal.Value & " And cancelado ='A'  group by descuento"

                    sqlDescuentosRecargos = $"SELECT sum(Descuento) as SumaDescuentos, Concepto, Porcentaje_Descuento from grabardescuentos_recargos WHERE FECHA_ACTUAL BETWEEN '{ dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") }' AND '{ dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") }' AND CAJA = { txtcaja.Text } and cancelado='A' and recibo>=" & IIfolioinicial.Value & " and recibo<=" & IIfoliofinal.Value & " group by Porcentaje_Descuento"

                    ' 'sqlDescuentosRecargos = $" "
                    sqlformasdepago = "Select count(concat(serie,recibo)) As cuantos,  ccodpago, sum(total)  As total from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "' and cancelado='A' and recibo>=" & IIfolioinicial.Value & " and recibo<=" & IIfoliofinal.Value & "  group by ccodpago"

                End If

                Dim reporteResumen As New reporteResumenFecha
                reporteResumen.CreaResumen(SqlITSharp, dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & " AL " & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd"), txtcaja.Text, SqlITSharpVIRTUALES, sqlDescuentosRecargos, sqlformasdepago)
                Exit Sub
            Case "RUBROS"

                SqlITSharp = "select  rubros.Id_Rubro, Rubros.descripcion as RUBRO, sum(pagotros.cantidad*pagotros.importe) as IMPORTE, conceptoscxc.Descripcion AS CONCEPTO, pagotros.Concepto AS DETALLE , SUM(MontoIva) as IVA  from (pagotros left join conceptoscxc on pagotros.NumConcepto = conceptoscxc.Id_Concepto) left join rubros on conceptoscxc.Rubro= Rubros.id_Rubro where fecha between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and cancelado='A' group by rubros.Id_Rubro"

                SqlITSharpVIRTUALES = "SELECT count(concat(Serie, recibo)) as cuantos ,descuento, sum(descuentopesos) as virtuales from pagos  where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "'  and cancelado='A'  group by descuento"

                sqlDescuentosRecargos = $"SELECT sum(Descuento) as SumaDescuentos, Concepto, Porcentaje_Descuento from grabardescuentos_recargos WHERE FECHA_ACTUAL BETWEEN '{ dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") }' AND '{dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd")}' and cancelado='A'  group by Porcentaje_Descuento"

                sqlformasdepago = "select count(concat(serie,recibo)) as cuantos,  ccodpago, sum(total) as total  from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and cancelado='A' group by ccodpago"

                If txtcaja.Text <> "" And IIfolioinicial.Value = 0 And IIfoliofinal.Value = 0 Then

                    SqlITSharp = "select  rubros.Id_Rubro, Rubros.descripcion as RUBRO, sum(pagotros.cantidad*pagotros.importe) as IMPORTE, conceptoscxc.Descripcion AS CONCEPTO, pagotros.Concepto AS DETALLE , SUM(MontoIva) as IVA  from (pagotros left join conceptoscxc on pagotros.NumConcepto = conceptoscxc.Id_Concepto) left join rubros on conceptoscxc.Rubro= Rubros.id_Rubro  where fecha between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and  cancelado='A' and caja=" & txtcaja.Text & " group by rubros.id_rubro"

                    SqlITSharpVIRTUALES = "SELECT count(concat(Serie, recibo)) as cuantos,descuento, sum(descuentopesos) as virtuales from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "'" & " and cancelado='A'  group by descuento"

                    sqlDescuentosRecargos = $"SELECT sum(Descuento) as SumaDescuentos, Concepto, Porcentaje_Descuento from grabardescuentos_recargos WHERE FECHA_ACTUAL BETWEEN '{ dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") }' AND '{ dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") }' AND CAJA = { txtcaja.Text } and cancelado='A'  group by Porcentaje_Descuento"

                    'sqlDescuentosRecargos = $" "
                    sqlformasdepago = "select count(concat(serie,recibo)) as cuantos,  ccodpago, sum(total)  as total from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "' and cancelado='A'  group by ccodpago"

                End If

                If txtcaja.Text <> "" And IIfolioinicial.Value > 0 And IIfoliofinal.Value > 0 Then


                    SqlITSharp = "select  rubros.Id_Rubro, Rubros.descripcion as RUBRO, sum(pagotros.cantidad*pagotros.importe) as IMPORTE, conceptoscxc.Descripcion AS CONCEPTO, pagotros.Concepto AS DETALLE , SUM(MontoIva) as IVA  from (pagotros left join conceptoscxc on pagotros.NumConcepto = conceptoscxc.Id_Concepto) left join rubros on conceptoscxc.Rubro= Rubros.id_Rubro  where fecha between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "'  and Caja = '" & txtcaja.Text & "'" & " and recibo>=" & IIfolioinicial.Value & " and recibo<=" & IIfoliofinal.Value & " and cancelado='A' group by rubros.id_rubro"

                    SqlITSharpVIRTUALES = "SELECT count(concat(Serie, recibo)) as cuantos,descuento, sum(descuentopesos) as virtuales from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "'" & "  and recibo>=" & IIfolioinicial.Value & " and recibo<=" & IIfoliofinal.Value & " And cancelado ='A'  group by descuento"

                    sqlDescuentosRecargos = $"SELECT sum(Descuento) as SumaDescuentos, Concepto, Porcentaje_Descuento from grabardescuentos_recargos WHERE FECHA_ACTUAL BETWEEN '{ dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") }' AND '{ dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") }' AND CAJA = { txtcaja.Text } and cancelado='A' and recibo>=" & IIfolioinicial.Value & " and recibo<=" & IIfoliofinal.Value & " group by Porcentaje_Descuento"

                    ' 'sqlDescuentosRecargos = $" "
                    sqlformasdepago = "Select count(concat(serie,recibo)) As cuantos,  ccodpago, sum(total)  As total from pagos where fecha_Act between '" & dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & "' and '" & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd") & "' and Caja = '" & txtcaja.Text & "' and cancelado='A' and recibo>=" & IIfolioinicial.Value & " and recibo<=" & IIfoliofinal.Value & "  group by ccodpago"

                End If

                Dim ObjCorteCaja As New ReporteRubros
                ObjCorteCaja.CorteDiario(SqlITSharp, dtpfechainicio.SelectionStart.ToString("yyyy-MM-dd") & " AL " & dtpfechafinal.SelectionEnd.ToString("yyyy-MM-dd"), txtcaja.Text, SqlITSharpVIRTUALES, sqlDescuentosRecargos, sqlformasdepago)
                Exit Sub
            Case "", "TARIFA"
                filtro = "{pagos1.fecha_Act}>=CDate(" & dtpfechainicio.SelectionRange.Start.Year & "," & dtpfechainicio.SelectionRange.Start.Month & "," & dtpfechainicio.SelectionRange.Start.Day & ") And {pagos1.fecha_Act}<=CDate(" & dtpfechafinal.SelectionRange.Start.Year & "," & dtpfechafinal.SelectionRange.Start.Month & "," & dtpfechafinal.SelectionRange.Start.Day & ") And {pagos1.cancelado}='A'"
        End Select


        filtromysql = " Fecha_act >='" & dtpfechainicio.SelectionRange.Start.Year & "/" & dtpfechainicio.SelectionRange.Start.Month & "/" & dtpfechainicio.SelectionRange.Start.Day & "' and "
        filtromysql += "fecha_Act <='" & dtpfechafinal.SelectionRange.Start.Year & "/" & dtpfechafinal.SelectionRange.Start.Month & "/" & dtpfechafinal.SelectionRange.Start.Day & "'"

        If txtcaja.Text <> "" Then
            filtro += " and {pagos1.Caja}=" & txtcaja.Text & ""
            filtromysql += "and pagos1.Caja=" & txtcaja.Text & ""
        End If

        If IIfolioinicial.Value > 0 And IIfoliofinal.Value > 0 Then
            If IIfoliofinal.Value >= IIfolioinicial.Value Then

                Select Case tipo
                    Case "CAJA", "RUBROS", "RESUMEN", "CONCEPTOS", "TARIFA"
                        filtro += " and {pagos1.recibo}>=" & IIfolioinicial.Value & "  and {pagos1.recibo}<=" & IIfoliofinal.Value

                        filtromysql += " and pagos1.recibo>=" & IIfolioinicial.Value & "  and pagos1.recibo<=" & IIfoliofinal.Value
                    Case "Auditoria"
                        filtro += " and {encfac1.recibo}>=" & IIfolioinicial.Value & "  and {encfac1.recibo}<=" & IIfoliofinal.Value
                End Select

            End If
        End If

    End Sub
End Class