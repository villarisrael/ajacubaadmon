Imports System.IO
Imports OfficeOpenXml
Imports OfficeOpenXml.Style

Public Class FRMREPcat
    Private Sub FRMREPcat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fecini.SelectedDate = Now

        fecfinal.SelectedDate = Now
    End Sub



    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Close()

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        BtnAceptar.Enabled = False

        If ChkEstadistica.Checked = True Then


            Dim SQL As String
            Dim frmest As New Estadistica
            Dim TOTALrubrosconsumo As Decimal = 0.0
            fecini.SelectedDate = fecini.SelectedDate.AddDays((fecini.SelectedDate.Day - 1) * -1)
            fecfinal.SelectedDate = fecfinal.SelectedDate.AddMonths(1)
            fecfinal.SelectedDate = fecfinal.SelectedDate.AddDays((fecfinal.SelectedDate.Day) * -1)
            ' MessageBoxEx.Show(fecini.SelectedDate)
            StepIndicator1.CurrentStep = 1
            Try
                ''''' *************** A SACAR PAGOS POR AÑO ************************************''''''
                Ejecucion("drop table if exists temborralapagos")
                SQL = "create table temborralapagos select * from pagos pg where pg.fecha_Act between """ & UnixDateFormat(fecini.SelectedDate) & """ And """ & UnixDateFormat(fecfinal.SelectedDate) & """ and pg.cancelado='A' AND ESUSUARIO=1 "
                Ejecucion(SQL)
                Ejecucion(" ALTER TABLE temborralapagos ADD Index rec (serie,recibo)")



                Ejecucion("drop table if exists temborralapagomes")
                SQL = "create table temborralapagomes select distinct pm.* from pago_mes  pm inner join temborralapagos p on pm.serie=p.serie and pm.recibo=p.recibo "
                Ejecucion(SQL)
                Ejecucion(" ALTER TABLE temborralapagomes ADD Index mes2 (mes,ano,cuenta,concepto)")



                Ejecucion("drop table if exists temborrala")
                SQL = "CREATE table temborrala Select p.cuenta, usuario.tarifa AS TARIFA, p.montopagado as monto, IF(YEAR(P.FECHA)=P.ano,1,0) AS ANOACTUAL, p.concepto AS CONCEPTO  from temborralapagomes  p INNER JOIN usuario on  p.cuenta=usuario.cuenta"
                Ejecucion(SQL)
                Ejecucion(" ALTER TABLE temborrala ADD Index tar (tarifa ASC)")
                'Ejecucion("ALTER TABLE temborrala ADD Index consu (consumo ASC)")
                Ejecucion("ALTER TABLE temborrala ADD Index conce (concepto ASC)")




                '****** CREANDO DATOS PARA CONSUMO Y REZAGO **********************************************************

                Ejecucion("drop table if exists temborralapagoCON")
                Ejecucion("create table temborralapagoCON select distinct pm.* from pagotros  pm inner join temborralapagos p on pm.serie=p.serie and pm.recibo=p.recibo where numconcepto='081DES' or numconcepto='004RZG'")
                Ejecucion(" ALTER TABLE temborralapagoCON ADD Index mes2 (cuenta,NUMconcepto)")
                Ejecucion("drop table if exists temborralaCON")
                Ejecucion("CREATE table temborralaCON Select p.cuenta, usuario.tarifa AS TARIFA, p.importe as monto,  p.numconcepto AS CONCEPTO  from temborralapagoCON  p INNER JOIN usuario on  p.cuenta=usuario.cuenta")
                Ejecucion(" ALTER TABLE temborralaCON ADD Index tarq (tarifa ASC)")
                'Ejecucion("ALTER TABLE temborrala ADD Index consu (consumo ASC)")
                Ejecucion("ALTER TABLE temborrala ADD Index conceq (concepto ASC)")

                Ejecucion("drop table if exists  temborralaconsumom")
                Ejecucion(" create table temborralaconsumom ( id INT NOT NULL AUTO_INCREMENT,concepto varchar(250), valor decimal(15,2) Not NULL DEFAULT 0,tipo varchar(15) not null default ""SIN VALOR"", NODO Varchar(15) not null default """",PRIMARY KEY(`id`) )")




                SQL = "select sum(importe) as importe from pagos inner join pagotros on pagos.serie=pagotros.serie and pagos.recibo=pagotros.recibo  where pagos.fecha_Act between """ & UnixDateFormat(fecini.SelectedDate) & """ and """ & UnixDateFormat(fecfinal.SelectedDate) & """ and pagos.cancelado='A' and (pagotros.numconcepto='" & My.Settings.Clavedeconsumo & "' or pagotros.numconcepto='" & My.Settings.ClavedeRezago & "') "

                'ERROR CONVERSIÓN
                TOTALrubrosconsumo = Decimal.Parse(obtenerCampoDecimal(SQL, "importe"))
                Dim totalactual As Decimal = obtenerCampoDecimal("SELECT SUM(MONTO) as importe FROM temborralapagoCON where numconcepto='" & My.Settings.Clavedeconsumo & "'", "importe")

                Ejecucion("insert into temborralaconsumom (concepto,valor,TIPO,NODO) values( ""TOTAL DE INGRESOS POR CONSUMO DEL PERIODO " & fecini.SelectedDate.ToShortDateString & " A " & fecfinal.SelectedDate.ToShortDateString & """ , " & TOTALrubrosconsumo & ",""MONEDA"",""NODO 1"" )")
                Ejecucion("insert into temborralaconsumom (concepto,valor,TIPO,NODO) values( ""DEL MISMO AÑO ""," & totalactual & ",""MONEDA"",""NODO 2"")")
                Ejecucion("insert into temborralaconsumom (concepto,valor,TIPO,NODO) SELECT CUOTAS.DESCRIPCION_CUOTA ,SUM(importe),""MONEDA"",""NODO 3"" FROM (usuario inner join cuotas on usuario.tarifa = cuotas.id_tarifa) inner join temborralapagoCON on temborralapagoCON.cuenta= usuario.cuenta WHERE   numCONCEPTO='" & My.Settings.Clavedeconsumo & "'  GROUP BY TARIFA")

                Dim totalANTE As Decimal = obtenerCampoDecimal("SELECT SUM(MONTO) as importe FROM temborralaPAGOCON where numconcepto='" & My.Settings.ClavedeRezago & "'", "importe")

                Ejecucion("insert into temborralaconsumom (concepto,valor,TIPO,NODO) values( ""DE AÑOS ANTERIORES ""," & totalANTE & ",""MONEDA"",""NODO 2"")")
                Ejecucion("insert into temborralaconsumom (concepto,valor,TIPO,NODO) SELECT CUOTAS.DESCRIPCION_CUOTA ,SUM(importe),""MONEDA"",""NODO 3"" FROM (usuario inner join cuotas on usuario.tarifa = cuotas.id_tarifa) inner join temborralapagoCON on temborralapagoCON.cuenta= usuario.cuenta WHERE   numCONCEPTO='" & My.Settings.ClavedeRezago & "'  GROUP BY TARIFA")

                Dim TOTALrubrosalcant As Decimal = obtenerCampoDecimal("select sum(importe) as importe from pagos inner join pagotros on pagos.serie=pagotros.serie and pagos.recibo=pagotros.recibo  where pagos.fecha_Act between """ & UnixDateFormat(fecini.SelectedDate) & """ and """ & UnixDateFormat(fecfinal.SelectedDate) & """ and pagos.cancelado='A' and (pagotros.numconcepto='" & My.Settings.Clavedealcantarillado & "') ", "importe")
                Dim totalactualalcant As Decimal = obtenerCampoDecimal("SELECT SUM(MONTO) as importe FROM temborrala where concepto=""ALCANTARILLADO""", "importe")



                Ejecucion("insert into temborralaconsumom (concepto,valor,TIPO,NODO) values ( ""TOTAL DE INGRESOS POR ALCANTARILLADO "" ," & TOTALrubrosalcant & ",""MONEDA"",""NODO 1"" )")
                Ejecucion("insert into temborralaconsumom (concepto,valor,TIPO,NODO) values( ""DEL MISMO AÑO "",0,""SIN VALOR"",""NODO 2"")")
                Ejecucion("insert into temborralaconsumom (concepto,valor,TIPO,NODO) SELECT CUOTAS.DESCRIPCION_CUOTA ,(SUM(MONTO)/" & totalactualalcant & ")*" & TOTALrubrosalcant & ", ""MONEDA"", ""NODO 3"" FROM temborrala inner join cuotas on temborrala.tarifa = cuotas.id_tarifa  WHERE ANOACTUAL=1 And concepto='ALCANTARILLADO' GROUP BY TARIFA")
                Ejecucion("insert into temborralaconsumom (concepto,valor,TIPO,NODO) values( ""DE AÑOS ANTERIORES "",0,""SIN VALOR"",""NODO 2"")")
                Ejecucion("insert into temborralaconsumom (concepto,valor,TIPO,NODO) SELECT CUOTAS.DESCRIPCION_CUOTA ,(SUM(MONTO)/" & totalactualalcant & ")*" & TOTALrubrosalcant & ",""MONEDA"",""NODO 3"" FROM temborrala inner join cuotas on temborrala.tarifa = cuotas.id_tarifa  WHERE ANOACTUAL=0 AND concepto='ALCANTARILLADO' GROUP BY TARIFA")

                SQL = "select sum(importe) as importe from pagos inner join pagotros on pagos.serie=pagotros.serie and pagos.recibo=pagotros.recibo  where pagos.fecha_Act between """ & UnixDateFormat(fecini.SelectedDate) & """ and """ & UnixDateFormat(fecfinal.SelectedDate) & """ and pagos.cancelado='A' and (pagotros.numconcepto='" & My.Settings.clavedesaneamiento & "')"


                Dim TOTALrubrossanea As Decimal = obtenerCampoDecimal(SQL, "importe")
                Dim totalactualsanea As Decimal = obtenerCampoDecimal("SELECT SUM(MONTO) as importe FROM temborrala where concepto=""SANEAMIENTO""", "importe")

                Ejecucion("insert into temborralaconsumom (concepto,valor,TIPO,NODO) values (""TOTAL DE INGRESOS POR SANEAMIENTO "" , " & TOTALrubrossanea & ",""MONEDA"",""NODO 1"" )")
                Ejecucion("insert into temborralaconsumom (concepto,valor,TIPO,NODO) values( ""DEL MISMO AÑO "",0,""SIN VALOR"",""NODO 2"")")
                Ejecucion("insert into temborralaconsumom (concepto,valor,TIPO,NODO) SELECT CUOTAS.DESCRIPCION_CUOTA ,(SUM(MONTO)/" & totalactualsanea & ")*" & totalactualsanea & ",""MONEDA"",""NODO 3"" FROM temborrala inner join cuotas on temborrala.tarifa = cuotas.id_tarifa  WHERE ANOACTUAL=1 and concepto='SANEAMIENTO' GROUP BY TARIFA")
                Ejecucion("insert into temborralaconsumom (concepto,valor,TIPO,NODO) values( ""DE AÑOS ANTERIORES "",0,""SIN VALOR"",""NODO 2"")")
                Ejecucion("insert into temborralaconsumom (concepto,valor,TIPO,NODO) SELECT CUOTAS.DESCRIPCION_CUOTA ,(SUM(MONTO)/" & totalactualsanea & ")*" & totalactualsanea & ",""MONEDA"",""NODO 3"" FROM temborrala inner join cuotas on temborrala.tarifa = cuotas.id_tarifa  WHERE ANOACTUAL=0 AND concepto='SANEAMIENTO' GROUP BY TARIFA")

                Dim TOTALrubrosreca As Decimal = obtenerCampoDecimal("select sum(importe) as importe from pagos inner join pagotros on pagos.serie=pagotros.serie and pagos.recibo=pagotros.recibo  where pagos.fecha_Act between """ & UnixDateFormat(fecini.SelectedDate) & """ and """ & UnixDateFormat(fecfinal.SelectedDate) & """ and pagos.cancelado='A' and (pagotros.numconcepto='" & My.Settings.Clavederecargo & "') ", "importe")


                Dim totalactualreca As Decimal = obtenerCampoDecimal("SELECT SUM(MONTO) as importe FROM temborrala where concepto=""RECARGO""", "importe")

                Ejecucion("insert into temborralaconsumom (concepto,valor,TIPO,NODO) VALUES(""TOTAL DE INGRESOS POR RECARGO "" ," & TOTALrubrosreca & ",""MONEDA"",""NODO 2"")")
                Ejecucion("insert into temborralaconsumom (concepto,valor,TIPO,NODO) SELECT ""TOTAL DE INGRESOS POR RECARGO DEL MISMO AÑO"" ,(SUM(MONTO)/" & totalactualreca & ")*" & TOTALrubrosreca & ",""MONEDA"",""NODO 3"" FROM temborrala WHERE ANOACTUAL=1 and concepto='RECARGO'")
                Ejecucion("insert into temborralaconsumom (concepto,valor,TIPO,NODO) SELECT ""TOTAL DE INGRESOS POR RECARGO DE AÑOS ANTERIORES"" ,(SUM(MONTO)/" & totalactualreca & ")*" & TOTALrubrosreca & ",""MONEDA"",""NODO 3"" FROM temborrala WHERE ANOACTUAL=0 AND concepto='RECARGO'")

                Application.DoEvents()
                StepIndicator1.CurrentStep = 2
                'Ejecucion("drop table if exists tempconsumos")
                'Ejecucion("create table tempconsumos Select count(cuenta) as cuenta, cuotas.Descripcion_Cuota, IF(cuotas.medido=1, temborrala.consumo,cuotas.consumen) AS CONSUMO, sum(monto) As monto,ANOACTUAL,CONCEPTO  from temborrala  left join cuotas On temborrala.tarifa=cuotas.id_tarifa WHERE CONCEPTO='CONSUMO' group by Descripcion_Cuota, consumo, anoactual ")
                'Ejecucion("ALTER TABLE tempconsumos ADD Index consu (CONSUMO ASC)")
                'Ejecucion("update tempconsumos set consumo=0 where consumo is null")
                'StepIndicator1.CurrentStep = 3



            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Application.DoEvents()

            '''''''''''''consumo''''''''''''''''''''''''''''''

            Try


                '            create table temborralac Select tipousu, lecturas.consumo, lecturas.MONTO from vusuario, lecturas, cuotas, tipos_usuarios  
                'where vusuario.cuenta = lecturas.cuenta 
                'And  VALORNUMMES(mes,an_per) >= VALORNUMMES('OCT',2021) AND VALORNUMMES(mes, an_per) <= VALORNUMMES('DIC',2021)  and lecturas.consumo >= 100 
                'And lecturas.consumo <= 99999 And vusuario.tarifa=cuotas.id_tarifa And cuotas.parauso=tipos_usuarios.id_tipo_usuario 
                'And tipos_usuarios.id_tipo_usuario=4;


                Ejecucion("drop table If exists  temborralac")
                SQL = "create table temborralac select tipousu, lecturas.consumo, lecturas.MONTO from vusuario, lecturas, cuotas, tipos_usuarios where vusuario.cuenta=lecturas.cuenta and  VALORNUMMES(mes,an_per) >= VALORNUMMES('" & NOMBREDEMES3CAR(fecini.SelectedDate.Month) & "'," & fecini.SelectedDate.Year & ") AND VALORNUMMES(mes, an_per) <= VALORNUMMES('" & NOMBREDEMES3CAR(fecfinal.SelectedDate.Month) & "'," & fecfinal.SelectedDate.Year & ")  and lecturas.consumo >= 0 and lecturas.consumo <= 50 and vusuario.tarifa=cuotas.id_tarifa And cuotas.parauso=tipos_usuarios.id_tipo_usuario And tipos_usuarios.id_tipo_usuario=3"
                Ejecucion(SQL)



                SQL = "insert into temborralac select tipousu, lecturas.consumo, lecturas.MONTO from vusuario, lecturas, cuotas, tipos_usuarios where vusuario.cuenta=lecturas.cuenta and  VALORNUMMES(mes,an_per) >= VALORNUMMES('" & NOMBREDEMES3CAR(fecini.SelectedDate.Month) & "'," & fecini.SelectedDate.Year & ") AND VALORNUMMES(mes, an_per) <= VALORNUMMES('" & NOMBREDEMES3CAR(fecfinal.SelectedDate.Month) & "'," & fecfinal.SelectedDate.Year & ")  and lecturas.consumo >= 0 and lecturas.consumo <= 50 and vusuario.tarifa=cuotas.id_tarifa And cuotas.parauso=tipos_usuarios.id_tipo_usuario And tipos_usuarios.id_tipo_usuario=2"
                Ejecucion(SQL)



                SQL = "insert into temborralac select tipousu, lecturas.consumo, lecturas.MONTO from vusuario, lecturas, cuotas, tipos_usuarios where vusuario.cuenta=lecturas.cuenta and  VALORNUMMES(mes,an_per) >= VALORNUMMES('" & NOMBREDEMES3CAR(fecini.SelectedDate.Month) & "'," & fecini.SelectedDate.Year & ") AND VALORNUMMES(mes, an_per) <= VALORNUMMES('" & NOMBREDEMES3CAR(fecfinal.SelectedDate.Month) & "'," & fecfinal.SelectedDate.Year & ")  and lecturas.consumo >= 0 and lecturas.consumo <= 50 and vusuario.tarifa=cuotas.id_tarifa And cuotas.parauso=tipos_usuarios.id_tipo_usuario And tipos_usuarios.id_tipo_usuario=1"
                Ejecucion(SQL)



                SQL = "insert into temborralac select tipousu, lecturas.consumo, lecturas.MONTO from vusuario, lecturas, cuotas, tipos_usuarios where vusuario.cuenta=lecturas.cuenta and  VALORNUMMES(mes,an_per) >= VALORNUMMES('" & NOMBREDEMES3CAR(fecini.SelectedDate.Month) & "'," & fecini.SelectedDate.Year & ") AND VALORNUMMES(mes, an_per) <= VALORNUMMES('" & NOMBREDEMES3CAR(fecfinal.SelectedDate.Month) & "'," & fecfinal.SelectedDate.Year & ")  and lecturas.consumo >= 0 and lecturas.consumo <= 50 and vusuario.tarifa=cuotas.id_tarifa And cuotas.parauso=tipos_usuarios.id_tipo_usuario And tipos_usuarios.id_tipo_usuario=4"
                Ejecucion(SQL)



                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


                Ejecucion("drop table If exists  temborralac1")
                Ejecucion("create table temborralac1 select tipousu, lecturas.consumo, lecturas.MONTO from vusuario, lecturas, cuotas, tipos_usuarios where vusuario.cuenta=lecturas.cuenta and  VALORNUMMES(mes,an_per) >= VALORNUMMES('" & NOMBREDEMES3CAR(fecini.SelectedDate.Month) & "'," & fecini.SelectedDate.Year & ") AND VALORNUMMES(mes, an_per) <= VALORNUMMES('" & NOMBREDEMES3CAR(fecfinal.SelectedDate.Month) & "'," & fecfinal.SelectedDate.Year & ")  and lecturas.consumo >= 50 and lecturas.consumo <= 100 and vusuario.tarifa=cuotas.id_tarifa And cuotas.parauso=tipos_usuarios.id_tipo_usuario And tipos_usuarios.id_tipo_usuario=3")



                Ejecucion("insert into temborralac1 select tipousu, lecturas.consumo, lecturas.MONTO from vusuario, lecturas, cuotas, tipos_usuarios where vusuario.cuenta=lecturas.cuenta and  VALORNUMMES(mes,an_per) >= VALORNUMMES('" & NOMBREDEMES3CAR(fecini.SelectedDate.Month) & "'," & fecini.SelectedDate.Year & ") AND VALORNUMMES(mes, an_per) <= VALORNUMMES('" & NOMBREDEMES3CAR(fecfinal.SelectedDate.Month) & "'," & fecfinal.SelectedDate.Year & ")  and lecturas.consumo >= 50 and lecturas.consumo <= 100 and vusuario.tarifa=cuotas.id_tarifa And cuotas.parauso=tipos_usuarios.id_tipo_usuario And tipos_usuarios.id_tipo_usuario=2")



                Ejecucion("insert into temborralac1 select tipousu, lecturas.consumo, lecturas.MONTO from vusuario, lecturas, cuotas, tipos_usuarios where vusuario.cuenta=lecturas.cuenta and  VALORNUMMES(mes,an_per) >= VALORNUMMES('" & NOMBREDEMES3CAR(fecini.SelectedDate.Month) & "'," & fecini.SelectedDate.Year & ") AND VALORNUMMES(mes, an_per) <= VALORNUMMES('" & NOMBREDEMES3CAR(fecfinal.SelectedDate.Month) & "'," & fecfinal.SelectedDate.Year & ")  and lecturas.consumo >= 50 and lecturas.consumo <= 100 and vusuario.tarifa=cuotas.id_tarifa And cuotas.parauso=tipos_usuarios.id_tipo_usuario And tipos_usuarios.id_tipo_usuario=1")



                Ejecucion("insert into temborralac1 select tipousu, lecturas.consumo, lecturas.MONTO from vusuario, lecturas, cuotas, tipos_usuarios where vusuario.cuenta=lecturas.cuenta and  VALORNUMMES(mes,an_per) >= VALORNUMMES('" & NOMBREDEMES3CAR(fecini.SelectedDate.Month) & "'," & fecini.SelectedDate.Year & ") AND VALORNUMMES(mes, an_per) <= VALORNUMMES('" & NOMBREDEMES3CAR(fecfinal.SelectedDate.Month) & "'," & fecfinal.SelectedDate.Year & ")  and lecturas.consumo >= 50 and lecturas.consumo <= 100 and vusuario.tarifa=cuotas.id_tarifa And cuotas.parauso=tipos_usuarios.id_tipo_usuario And tipos_usuarios.id_tipo_usuario=4")



                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                Ejecucion("drop table If exists  temborralac2")
                Ejecucion("create table temborralac2 select tipousu, lecturas.consumo, lecturas.MONTO from vusuario, lecturas, cuotas, tipos_usuarios where vusuario.cuenta=lecturas.cuenta and  VALORNUMMES(mes,an_per) >= VALORNUMMES('" & NOMBREDEMES3CAR(fecini.SelectedDate.Month) & "'," & fecini.SelectedDate.Year & ") AND VALORNUMMES(mes, an_per) <= VALORNUMMES('" & NOMBREDEMES3CAR(fecfinal.SelectedDate.Month) & "'," & fecfinal.SelectedDate.Year & ")  and vusuario.tarifa=cuotas.id_tarifa And cuotas.parauso=tipos_usuarios.id_tipo_usuario And tipos_usuarios.id_tipo_usuario=3")

                Ejecucion("insert into temborralac2 select tipousu, lecturas.consumo, lecturas.MONTO from vusuario, lecturas, cuotas, tipos_usuarios where vusuario.cuenta=lecturas.cuenta and  VALORNUMMES(mes,an_per) >= VALORNUMMES('" & NOMBREDEMES3CAR(fecini.SelectedDate.Month) & "'," & fecini.SelectedDate.Year & ") AND VALORNUMMES(mes, an_per) <= VALORNUMMES('" & NOMBREDEMES3CAR(fecfinal.SelectedDate.Month) & "'," & fecfinal.SelectedDate.Year & ")  and lecturas.consumo >= 100 and vusuario.tarifa=cuotas.id_tarifa And cuotas.parauso=tipos_usuarios.id_tipo_usuario And tipos_usuarios.id_tipo_usuario=2")


                Ejecucion("insert into temborralac2 select tipousu, lecturas.consumo, lecturas.MONTO from vusuario, lecturas, cuotas, tipos_usuarios where vusuario.cuenta=lecturas.cuenta and  VALORNUMMES(mes,an_per) >= VALORNUMMES('" & NOMBREDEMES3CAR(fecini.SelectedDate.Month) & "'," & fecini.SelectedDate.Year & ") AND VALORNUMMES(mes, an_per) <= VALORNUMMES('" & NOMBREDEMES3CAR(fecfinal.SelectedDate.Month) & "'," & fecfinal.SelectedDate.Year & ")  and lecturas.consumo >= 100 and vusuario.tarifa=cuotas.id_tarifa And cuotas.parauso=tipos_usuarios.id_tipo_usuario And tipos_usuarios.id_tipo_usuario=1")


                Ejecucion("insert into temborralac1 select tipousu, lecturas.consumo, lecturas.MONTO from vusuario, lecturas, cuotas, tipos_usuarios where vusuario.cuenta=lecturas.cuenta and  VALORNUMMES(mes,an_per) >= VALORNUMMES('" & NOMBREDEMES3CAR(fecini.SelectedDate.Month) & "'," & fecini.SelectedDate.Year & ") AND VALORNUMMES(mes, an_per) <= VALORNUMMES('" & NOMBREDEMES3CAR(fecfinal.SelectedDate.Month) & "'," & fecfinal.SelectedDate.Year & ")  and lecturas.consumo >= 100 and vusuario.tarifa=cuotas.id_tarifa And cuotas.parauso=tipos_usuarios.id_tipo_usuario And tipos_usuarios.id_tipo_usuario=4")


                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                Ejecucion("drop table if exists  temconsumoTotal")
                Ejecucion("create table  temconsumoTotal ( id INT NOT NULL AUTO_INCREMENT,TipoUso varchar(250), cantidad varchar(50), MontoConsumo decimal(15,2) ,Consumo int, NODO Varchar(15) not null default """", primary key(id))")
                'Ejecucion("insert into temconsumoTotal  (Tipouso,cantidad,NODO) values (""De 1-50"", """", 0,0, ""NODO 2"")")
                Ejecucion("insert into temconsumoTotal  (Tipouso,cantidad,MontoConsumo,Consumo,NODO) select '', ""1-50"", sum(MONTO),sum(CONSUMO), ""NODO 1"" from temborralac")
                Ejecucion("insert into temconsumoTotal  (Tipouso,cantidad,MontoConsumo, Consumo,NODO) select tipousu, ""1-50"", SUM(MONTO),sum(CONSUMO), ""NODO 2"" from temborralac where tipousu= 'Comercial'")
                Ejecucion("insert into temconsumoTotal  (Tipouso,cantidad,MontoConsumo, Consumo,NODO) select tipousu, ""1-50"", SUM(MONTO),sum(CONSUMO), ""NODO 2"" from temborralac where tipousu= 'Domestico'")
                Ejecucion("insert into temconsumoTotal  (Tipouso,cantidad,MontoConsumo, Consumo,NODO) select tipousu, ""1-50"", SUM(MONTO),sum(CONSUMO), ""NODO 2"" from temborralac where tipousu= 'Servicios Publicos'")
                Ejecucion("insert into temconsumoTotal  (Tipouso,cantidad,MontoConsumo, Consumo,NODO) select tipousu, ""1-50"", SUM(MONTO),sum(CONSUMO), ""NODO 2"" from temborralac where tipousu= 'Industrial'")

                'Ejecucion("insert into temconsumoTotal  (Tipouso,cantidad,MontoConsumo,Consumo,NODO) values (""De 50-100"", """", 0,0, ""NODO 2"")")
                Ejecucion("insert into temconsumoTotal  (Tipouso,cantidad,MontoConsumo,Consumo,NODO) select '', ""50-100"", sum(MONTO),sum(CONSUMO), ""NODO 3"" from temborralac1")
                Ejecucion("insert into temconsumoTotal  (Tipouso,cantidad,MontoConsumo, Consumo,NODO) select tipousu, ""50-100"", SUM(MONTO),sum(CONSUMO), ""NODO 2"" from temborralac1 where tipousu= 'Comercial'")
                Ejecucion("insert into temconsumoTotal  (Tipouso,cantidad,MontoConsumo, Consumo,NODO) select tipousu, ""50-100"", SUM(MONTO),sum(CONSUMO), ""NODO 2"" from temborralac1 where tipousu= 'Domestico'")
                Ejecucion("insert into temconsumoTotal  (Tipouso,cantidad,MontoConsumo, Consumo,NODO) select tipousu, ""50-100"", SUM(MONTO),sum(CONSUMO), ""NODO 2"" from temborralac1 where tipousu= 'Servicios Publicos'")
                Ejecucion("insert into temconsumoTotal  (Tipouso,cantidad,MontoConsumo, Consumo,NODO) select tipousu, ""1-50"", SUM(MONTO),sum(CONSUMO), ""NODO 2"" from temborralac where tipousu= 'Industrial'")

                'Ejecucion("insert into temconsumoTotal  (Tipouso,cantidad,MontoConsumo,Consumo,NODO) values (""De 100..."", """", 0,0, ""NODO 2"")")
                Ejecucion("insert into temconsumoTotal  (Tipouso,cantidad,MontoConsumo,Consumo,NODO) select '', ""100..."", sum(MONTO),sum(CONSUMO), ""NODO 4"" from temborralac2")
                Ejecucion("insert into temconsumoTotal  (Tipouso,cantidad,MontoConsumo, Consumo,NODO) select tipousu, ""100..."", SUM(MONTO),sum(CONSUMO), ""NODO 2"" from temborralac2 where tipousu= 'Comercial'")
                Ejecucion("insert into temconsumoTotal  (Tipouso,cantidad,MontoConsumo, Consumo,NODO) select tipousu, ""100..."", SUM(MONTO),sum(CONSUMO), ""NODO 2"" from temborralac2 where tipousu= 'Domestico'")
                Ejecucion("insert into temconsumoTotal  (Tipouso,cantidad,MontoConsumo, Consumo,NODO) select tipousu, ""100..."", SUM(MONTO),sum(CONSUMO), ""NODO 2"" from temborralac2 where tipousu= 'Servicios Publicos'")
                Ejecucion("insert into temconsumoTotal  (Tipouso,cantidad,MontoConsumo, Consumo,NODO) select tipousu, ""100..."", SUM(MONTO),sum(CONSUMO), ""NODO 2"" from temborralac2 where tipousu= 'Industrial'")

                'Ejecucion("insert into temconsumoTotal  (Tipouso,cantidad,MontoConsumo,Consumo,NODO) select ""De 1-"", """", 0,0, ""NODO 1"" from temborralac")
                Application.DoEvents()
                StepIndicator1.CurrentStep = 4

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Try

                '''' *************** A COMPOSICION DEL PADRON ************************************''''''

                Ejecucion("drop table If exists  temborrala2")
                Ejecucion(" create table temborrala2 ( id INT Not NULL AUTO_INCREMENT,concepto varchar(250), valor Decimal(15,2) Not NULL Default 0,tipo varchar(15) Not null Default ""SIN VALOR"", NODO Varchar(15) Not null Default """",PRIMARY KEY(`id`) )")
                Ejecucion("insert into temborrala2 (concepto,valor,TIPO,NODO) Select ""TOTAL DE USUARIOS A LA FECHA " & fecfinal.SelectedDate.ToShortDateString & """ ,COUNT(CUENTA),""VALOR ENTERO"",""NODO 1"" FROM usuario INNER JOIN estadotoma On usuario.estado = estadotoma.clave where estadotoma.mostrar=1 And usuario.FECHAALTA<=""" & UnixDateFormat(fecfinal.SelectedDate) & """")
                Ejecucion("insert into temborrala2 (concepto,valor,TIPO,NODO) values( ""POR TARIFA "",0,""SIN VALOR"",""NODO 2"")")
                Ejecucion("insert into temborrala2 (concepto,valor,TIPO,NODO) Select Descripcion_Cuota , count(cuenta),""VALOR ENTERO"",""NODO 3"" FROM usuario inner join cuotas On usuario.tarifa=cuotas.id_tarifa INNER JOIN estadotoma On usuario.estado = estadotoma.clave where estadotoma.mostrar=1 And usuario.FECHAALTA<=""" & UnixDateFormat(fecfinal.SelectedDate) & """ group by cuotas.id_tarifa")
                Ejecucion("insert into temborrala2 (concepto,valor,TIPO,NODO) VALUES (""POR TIPO DE USUARIO "",0,""SIN VALOR"",""NODO 2"")")
                'Ejecucion("insert into temborrala2 (concepto,valor,TIPO,NODO) Select ""NUMERO TOTAL DE USUARIOS "",COUNT(CUENTA),""VALOR ENTERO"",""NODO 3"" FROM usuario INNER JOIN estadotoma On usuario.estado = estadotoma.clave where estadotoma.mostrar=1 And usuario.FECHAALTA<=" & UnixDateFormat(fecfinal.SelectedDate))
                Ejecucion("insert into temborrala2 (concepto,valor,TIPO,NODO) Select TIPOUSO.USO , count(cuenta),""VALOR ENTERO"",""NODO 3"" FROM (usuario inner join cuotas On usuario.tarifa=cuotas.id_tarifa INNER JOIN estadotoma On usuario.estado = estadotoma.clave) INNER JOIN tipouso On cuotas.parauso=tipouso.clave where estadotoma.mostrar=1 And usuario.FECHAALTA<=""" & UnixDateFormat(fecfinal.SelectedDate) & """ group by tipouso.uso")
                Ejecucion("insert into temborrala2 (concepto,valor,TIPO,NODO) VALUES (""POR COMUNIDAD "",0,""SIN VALOR"",""NODO 2"")")
                Ejecucion("insert into temborrala2 (concepto,valor,TIPO,NODO) Select comunidades.comunidad , count(cuenta),""VALOR ENTERO"",""NODO 3"" FROM (usuario inner join comunidades On usuario.id_comunidad=comunidades.id_Comunidad INNER JOIN estadotoma On usuario.estado = estadotoma.clave) where estadotoma.mostrar=1 And usuario.FECHAALTA<=""" & UnixDateFormat(fecfinal.SelectedDate) & """ group by comunidades.id_comunidad")
                Ejecucion("insert into temborrala2 (concepto,valor,TIPO,NODO) VALUES (""POR COLONIA "",0,""SIN VALOR"",""NODO 2"")")
                'Ejecucion("insert into temborrala2 (concepto,valor,TIPO,NODO) Select ""NUMERO TOTAL DE USUARIOS "",COUNT(CUENTA),""VALOR ENTERO"",""NODO 3"" FROM usuario INNER JOIN estadotoma On usuario.estado = estadotoma.clave where estadotoma.mostrar=1 And usuario.FECHAALTA<=" & UnixDateFormat(fecfinal.SelectedDate))
                Ejecucion("insert into temborrala2 (concepto,valor,TIPO,NODO) Select COLONIA.colonia , count(cuenta),""VALOR ENTERO"",""NODO 3"" FROM (usuario inner join colonia On usuario.id_colonia=colonia.id_colonia INNER JOIN estadotoma On usuario.estado = estadotoma.clave) where estadotoma.mostrar=1 And usuario.FECHAALTA<=""" & UnixDateFormat(fecfinal.SelectedDate) & """ group by colonia.id_colonia")

                Application.DoEvents()
                StepIndicator1.CurrentStep = 4

                '''' *************** INGRESO POR FECHAS ************************************''''''

                Ejecucion("drop table If exists  temborrala3")
                Ejecucion(" create table temborrala3 ( id INT Not NULL AUTO_INCREMENT,concepto varchar(250), valor Decimal(15,2) Not NULL Default 0,tipo varchar(15) Not null Default ""SIN VALOR"", NODO Varchar(15) Not null Default """",PRIMARY KEY(`id`) )")

                Dim TOTAL As Decimal = obtenerCampoDecimal("Select SUM(TOTAL) As TOTAL FROM PAGOS WHERE FECHA_aCT BETWEEN """ & UnixDateFormat(fecini.SelectedDate) & """ And """ & UnixDateFormat(fecfinal.SelectedDate) & """ And PAGOS.CANCELADO=""A""", "TOTAL")

                Ejecucion("insert into temborrala3 (concepto,valor,TIPO,NODO) VALUES (""TOTAL DE INGRESOS DEL PERIODO " & fecini.SelectedDate.ToShortDateString & " A " & fecfinal.SelectedDate.ToShortDateString & """ ," & TOTAL & ",""MONEDA"",""NODO 1"")")
                Ejecucion("insert into temborrala3 (concepto,valor,TIPO,NODO) Select FECHA_aCT, sum(total),""MONEDA"",""NODO 3"" FROM PAGOS WHERE PAGOS.CANCELADO='A' AND FECHA_aCT BETWEEN """ & UnixDateFormat(fecini.SelectedDate) & """ AND """ & UnixDateFormat(fecfinal.SelectedDate) & """ group by fecha_Act ")

                Application.DoEvents()
                StepIndicator1.CurrentStep = 6

                '''' *************** INGRESO POR RUBROS ************************************''''''

                Ejecucion("drop table if exists pagostemrubros")
                '  basem.ejecutarSIMPLE("CREATE TABLE PAGOSTEMRUBROS LIKE PAGOS")
                Ejecucion("create table pagostemrubros  select pagotros1.SERIE, pagotros1.RECIBO, pagotros1.NUMCONCEPTO, `pagotros1`.`IVA`, `pagotros1`.`Cancelado`, sum(pagotros1.importe) as importe, `pagos1`.`esfijo`, `conceptoscxc1`.`Id_Concepto`, `conceptoscxc1`.`cta_cont`, `conceptoscxc1`.`Descripcion`,  `pagotros1`.`MontoIva`, pagos1.caja " _
             & "FROM   (`pagos` `pagos1` INNER JOIN `pagotros` `pagotros1` ON (`pagos1`.`recibo`=`pagotros1`.`Recibo`) AND (`pagos1`.`Serie`=`pagotros1`.`Serie`)) INNER JOIN `conceptoscxc` `conceptoscxc1` ON `pagotros1`.`NumConcepto`=`conceptoscxc1`.`Id_Concepto`" _
             & "WHERE FECHA BETWEEN """ & UnixDateFormat(fecini.SelectedDate) & """ AND """ & UnixDateFormat(fecfinal.SelectedDate) & """ and pagos1.cancelado ='A' " _
             & " group by `conceptoscxc1`.`Id_Concepto` ORDER BY `pagotros1`.`IVA`, `conceptoscxc1`.`Id_Concepto`")

                Ejecucion("drop table if exists  temborrala4")
                Ejecucion(" create table temborrala4 ( id INT NOT NULL AUTO_INCREMENT,concepto varchar(250), valor decimal(15,2) Not NULL DEFAULT 0,tipo varchar(15) not null default ""SIN VALOR"", NODO Varchar(15) not null default """",PRIMARY KEY(`id`) )")


                Dim TOTAL1 As Decimal = obtenerCampoDecimal("SELECT SUM(TOTAL) AS TOTAL FROM PAGOS WHERE FECHA_aCT BETWEEN """ & UnixDateFormat(fecini.SelectedDate) & """ AND """ & UnixDateFormat(fecfinal.SelectedDate) & """ and PAGOS.CANCELADO=""A""", "TOTAL")

                Ejecucion("insert into temborrala4 (concepto,valor,TIPO,NODO) VALUES (""TOTAL DE INGRESOS DEL PERIODO " & fecini.SelectedDate.ToShortDateString & " A " & fecfinal.SelectedDate.ToShortDateString & """ ," & TOTAL1 & ",""MONEDA"",""NODO 1"")")
                Ejecucion("insert into temborrala4 (concepto,valor,TIPO,NODO) select Descripcion, importe, ""MONEDA"",""NODO 3"" " _
             & "FROM pagostemrubros ORDER BY DESCRIPCION " & "")


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Try
                StepIndicator1.CurrentStep = 7

                Ejecucion(" drop table if exists borralacuentas")
                Ejecucion(" drop table if exists borralacuentas2")
                Ejecucion(" create table borralacuentas Select  cuenta, tarifa, cuotas.parauso, cuotas.medido FROM pagos inner join cuotas on pagos.tarifa=cuotas.id_tarifa where fecha_Act between """ & UnixDateFormat(fecini.SelectedDate) & """ AND """ & UnixDateFormat(fecfinal.SelectedDate) & """ and pagos.cancelado ='A'  and esusuario=1 order by cuenta")
                Ejecucion("create table borralacuentas2 select distinct * from borralacuentas")
                Ejecucion("select tipos_usuarios.DESCRIPCION,  tipos_usuarios.DESCRIPCION,count( cuenta) As cuantos, If (medido=1,""MEDIDO"",""FIJO"") As TIPO from borralacuentas2 inner join tipos_usuarios On parauso=tipos_usuarios.ID_TIPO_USUARIO group by borralacuentas2.parauso,MEDIDO;")


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Try
                StepIndicator1.CurrentStep = 8
                Ejecucion(" drop table if exists borralacuentas3")
                Ejecucion(" drop table if exists borralacuentas4")
                Ejecucion(" drop table if exists borralacuentas5")
                Ejecucion(" create table borralacuentas3 Select  pagos.cuenta As cuenta, tarifa, cuotas.parauso, cuotas.medido, mes, ano, pagos.recibo, pagos.serie FROM (pagos inner join cuotas on pagos.tarifa=cuotas.id_tarifa) inner join pago_mes on  pagos.recibo=pago_mes.recibo And pagos.serie=pago_mes.serie  And pagos.cuenta=pago_mes.cuenta where fecha_Act between """ & UnixDateFormat(fecini.SelectedDate) & """ AND """ & UnixDateFormat(fecfinal.SelectedDate) & """ and cancelado='A' and esusuario=1 order by cuenta")
                Ejecucion(" create table borralacuentas4 select distinct * from borralacuentas3")





                Dim totalactualreca = obtenerCampoDecimal("Select sum(monto) as monto from (borralacuentas4 inner join tipos_usuarios  inner join lecturas l on parauso=tipos_usuarios.ID_TIPO_USUARIO and  borralacuentas4.mes=l.mes and borralacuentas4.ano=l.an_per and  borralacuentas4.cuenta = l.cuenta )", "monto")

                Ejecucion(" CREATE TABLE borralacuentas5 select tipos_usuarios.DESCRIPCION,sum(if(l.consumo>=0 and l.consumo<=50,MONTO,0)) as rengo50,sum(if(l.consumo>=50.1 and l.consumo<=100,MONTO,0)) as rango100, sum(if(l.consumo>=100.1 and l.consumo<=99999,mONTO,0)) as rango999 from (borralacuentas4 inner join tipos_usuarios  inner join lecturas l on parauso=tipos_usuarios.ID_TIPO_USUARIO and  borralacuentas4.mes=l.mes and borralacuentas4.ano=l.an_per and  borralacuentas4.cuenta = l.cuenta ) group by borralacuentas4.parauso")
                Ejecucion(" ALTER TABLE borralacuentas5 ADD id INT PRIMARY KEY AUTO_INCREMENT")

                Dim totaloriginal As Decimal = obtenerCampoDecimal("select sum(rengo50)+sum(rango100)+sum(rango999) as suma from borralacuentas5 ", "suma")

                Ejecucion("update borralacuentas5 set rengo50=(rengo50/" & totaloriginal & ") *" & TOTALrubrosconsumo & ", rango100= (rango100/" & totaloriginal & ") *" & TOTALrubrosconsumo & ",rango999= (rango999/" & totaloriginal & ") *" & TOTALrubrosconsumo & " ")


            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try

            frmest.TOTALrubrosCONSUMO = TOTALrubrosconsumo
            frmest.WindowState = FormWindowState.Maximized
            frmest.Show()

        ElseIf ChkNuevaEstadistica.Checked = True Then

            'Dim Path As String = $"{(Environment.GetFolderPath(Environment.SpecialFolder.Desktop))}\Estadistica.xlsx"

            'Dim newFile As New FileInfo(Path)

            'Using xlPackage As New ExcelPackage(newFile)


            'Dim ExcellApp = New Microsoft.Office.Interop.Excel.Application
            'Dim libro = ExcellApp.Workbooks.Add.


            Dim path As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\EstadisticaNueva\\").Trim()

            If Not Directory.Exists(path) Then


                Dim di = Directory.CreateDirectory(path)

            End If

            'Dim ruta As String = "\\EstadisticaNueva\\" + "ReporteExcel_" & fechaInicioP & "-" & fechaFinP & ".xlsx"
            Dim ruta As String = "\\EstadisticaNueva\\" + "ReporteExcel_.xlsx"
            Dim pathReporte As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ruta).Trim()


            ExcelPackage.LicenseContext = LicenseContext.NonCommercial




            Using Ep As New ExcelPackage()


                Dim Sheet = Ep.Workbook.Worksheets.Add("ESTADISTICA")


                Dim rowCount As Integer = 1



                Sheet.Cells("A1:E1").Style.Font.Size = 14
                Sheet.Cells("A1:E1").Style.Font.Name = "Calibri"
                Sheet.Cells("A1:E3").Style.Font.Bold = True
                Sheet.Cells("A1:E1").Style.Font.Color.SetColor(Color.DarkBlue)
                Sheet.Cells("A1:E1").Style.HorizontalAlignment = ExcelHorizontalAlignment.Left
                Sheet.Cells("A1").RichText.Add("REPORTE POLIZA DIARIA")


                Sheet.Cells("A2:E3").Style.Font.Size = 14
                Sheet.Cells("A2:E3").Style.Font.Name = "Calibri"
                Sheet.Cells("A2:E3").Style.Font.Bold = True
                Sheet.Cells("A2:E3").Style.Font.Color.SetColor(Color.DarkBlue)
                Sheet.Cells("A2:E3").Style.HorizontalAlignment = ExcelHorizontalAlignment.Left
                Sheet.Cells("A2").RichText.Add("FECHA: ")


                Sheet.Cells("A3:E3").Style.Font.Size = 14
                Sheet.Cells("A3:E3").Style.Font.Name = "Calibri"
                Sheet.Cells("A3:E3").Style.Font.Bold = True
                Sheet.Cells("A3:E3").Style.Font.Color.SetColor(Color.DarkBlue)
                Sheet.Cells("A3:E3").Style.HorizontalAlignment = ExcelHorizontalAlignment.Left
                Sheet.Cells("A3").RichText.Add("ORGANISMO: ")



                Try

                    'ENCABEZADOS DEL DOCUMENTO
                    rowCount = 5
                    Sheet.Cells.Style.Font.Name = "Calibri"
                    Sheet.Cells.Style.Font.Size = 10
                    Sheet.Cells("A5:Z5").Style.Font.Bold = True
                    Sheet.Cells("A5:Z5").Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
                    Sheet.Cells("A5:Z5").Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray)


                    Sheet.Cells("A5").RichText.Add("NO. CONTRATO")
                    Sheet.Cells("B5").RichText.Add("USUARIO")
                    Sheet.Cells("C5").RichText.Add("SERVICIO DE AGUA")
                    Sheet.Cells("D5").RichText.Add("ALCANTARILLADO/SANEAMIENTO")
                    Sheet.Cells("E5").RichText.Add("TARIFA")
                    Sheet.Cells("F5").RichText.Add("% DESCUENTO 3ra EDAD")
                    Sheet.Cells("G5").RichText.Add("% DESCUENTO PRONTO PAGO")
                    Sheet.Cells("H5").RichText.Add("% OTROS DESCUENTOS")
                    Sheet.Cells("I5").RichText.Add("REZAGO MESES DEL EJERCICIO")
                    Sheet.Cells("J5").RichText.Add("RECARGOS MESES EJERCICIO")
                    Sheet.Cells("K5").RichText.Add("FOLIO CFDI / RECIBO")



                    Sheet.Cells("L5").RichText.Add("REZAGO 2023")
                    Sheet.Cells("M5").RichText.Add("REZAGO 2022")
                    Sheet.Cells("N5").RichText.Add("REZAGO 2021")
                    Sheet.Cells("O5").RichText.Add("REZAGO 2020")
                    Sheet.Cells("P5").RichText.Add("REZAGO 2019")
                    Sheet.Cells("Q5").RichText.Add("REZAGO 2018")
                    Sheet.Cells("R5").RichText.Add("TOTAL")


                    Sheet.Cells("S5").RichText.Add("RECARGO 2023")
                    Sheet.Cells("T5").RichText.Add("RECARGO 2022")
                    Sheet.Cells("U5").RichText.Add("RECARGO 2021")
                    Sheet.Cells("V5").RichText.Add("RECARGO 2020")
                    Sheet.Cells("W5").RichText.Add("RECARGO 2019")
                    Sheet.Cells("X5").RichText.Add("RECARGO 2018")
                    Sheet.Cells("Y5").RichText.Add("TOTAL")


                    Sheet.Cells("Z5").RichText.Add("IMPORTE DE DESC. 3ra EDAD, PENSIONADOS Y JUBILADOS")
                    Sheet.Cells("AA5").RichText.Add("IMPORTE DESCUENTO PRONTO PAGO")
                    Sheet.Cells("AB5").RichText.Add("IMPORTE OTROS DESCUENTOS AUTORIZADOS EN LEY DE INGRESOS")
                    Sheet.Cells("AC5").RichText.Add("PERMISO DE DESCARGA AL ALCANTARILLADO")
                    Sheet.Cells("AD5").RichText.Add("IMPORTE CONTRATO DE AGUA")
                    Sheet.Cells("AE5").RichText.Add("IMPORTE REINSTALACIÓN")
                    Sheet.Cells("AF5").RichText.Add("IMPORTE FACTIBILIDADES")
                    Sheet.Cells("AG5").RichText.Add("ALCANTARILLADO / SANEAMIENTO DEL PERIODO")
                    Sheet.Cells("AH5").RichText.Add("CONSUMO AGUA  DEL PERIODO")
                    Sheet.Cells("AI5").RichText.Add("TOTAL GENERAL")
                    Sheet.Cells("AJ5").RichText.Add("FECHA")
                    Sheet.Cells("AK5").RichText.Add("PÓLIZA No.")
                    Sheet.Cells("AL5").RichText.Add("INGRESO CUENTA CONTABLE")
                    Sheet.Cells("AM5").RichText.Add("DESCUENTO CUENTA CONTABLE")
                    Sheet.Cells("AN5").RichText.Add("INGRESO CUENTA PRESUPUESTA")
                    Sheet.Cells("AO5").RichText.Add("DESCUENTO CUENTA PRESUPUESTAL")

                    'Dim datos As IDataReader = ConsultaSql($"Select * from pago_mes where fecha between '{UnixDateFormat(fecini.SelectedDate)}' and '{UnixDateFormat(fecfinal.SelectedDate)}'").ExecuteReader
                    Dim SQL = "Select * from pagos where fecha_act between '" & UnixDateFormat(fecini.SelectedDate) & "' and '" & UnixDateFormat(fecfinal.SelectedDate) & "' order by cuenta asc"

                    Dim datos As IDataReader = ConsultaSql(SQL).ExecuteReader()

                    'datos.Read()

                    rowCount = 6

                    While datos.Read()

                        Dim serieRecibo As String = datos("SERIE").ToString()
                        Dim folioRecibo As Integer = datos("RECIBO")

                        Dim importeConsumo As Decimal = 0.0
                        Dim importeRezago As Decimal = 0.0
                        Dim importeAlcantarillado As Decimal = 0.0
                        Dim importeSaneamiento As Decimal = 0.0
                        Dim importeRecargos As Decimal = 0.0

                        Dim contratoMedido As Boolean
                        Dim contratoFijo As Boolean

                        Try


                            Dim SQLTarifa = $"Select * from cuotas where ID_TARIFA = {datos("TARIFA")}"

                            Dim datosTarifa As IDataReader = ConsultaSql(SQLTarifa).ExecuteReader()

                            datosTarifa.Read()

                            If datosTarifa("MEDIDO") = 0 Then

                                contratoFijo = True

                            Else

                                contratoMedido = True

                            End If

                        Catch ex As Exception

                        End Try

                        Sheet.Cells(String.Format("A{0}", rowCount)).Value = datos("CUENTA").ToString()

                        Sheet.Cells(String.Format("B{0}", rowCount)).Value = datos("NOMBRE")

                        'Sheet.Cells[string.Format("D{0}", row)].Style.Numberformat.Format = "$#,##0.00";





                        'Hacer consulta a pagotros para obetener los conceptos del recibo
                        Dim datosPagotros As IDataReader = ObtenerConceptosPagotros(serieRecibo, folioRecibo)
                        '

                        While datosPagotros.Read()

                            If datosPagotros("NUMCONCEPTO") = "081DES" Then

                                'Sheet.Cells(String.Format("C{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                Sheet.Cells(String.Format("C{0}", rowCount)).Value = datosPagotros("CONCEPTO").ToString()

                            End If

                            If datosPagotros("NUMCONCEPTO") = "002DRE" Then

                                Dim datosPago_Alcant As IDataReader = ObtenerConceptosPago_Mes(serieRecibo, folioRecibo, "ALCANTARILLADO")
                                Dim concatenarConcepto As String

                                While datosPago_Alcant.Read()

                                    concatenarConcepto += " " & datosPago_Alcant("MES").ToString() & " " & datosPago_Alcant("ANO").ToString() & ", "
                                End While
                                'Sheet.Cells(String.Format("D{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                Sheet.Cells(String.Format("D{0}", rowCount)).Value = datosPagotros("CONCEPTO").ToString() & concatenarConcepto

                                concatenarConcepto = ""
                            End If

                        End While


                        Dim descripcionTarifa As String = obtenerCampo($"select Descripcion_cuota from cuotas where id_tarifa = {datos("TARIFA")}", "Descripcion_cuota")

                        Sheet.Cells(String.Format("E{0}", rowCount)).Value = descripcionTarifa
                        'Sheet.Cells("F5").RichText.Add("% DESCUENTO 3ra EDAD")
                        'Sheet.Cells("G5").RichText.Add("% DESCUENTO PRONTO PAGO")
                        'Sheet.Cells("H5").RichText.Add("% OTROS DESCUENTOS")
                        'Sheet.Cells("I5").RichText.Add("REZAGO MESES DEL EJERCICIO")
                        'Sheet.Cells("J5").RichText.Add("RECARGOS MESES EJERCICIO")
                        'Sheet.Cells("K5").RichText.Add("FOLIO CFDI / RECIBO")

                        Sheet.Cells(String.Format("K{0}", rowCount)).Value = serieRecibo & " " & folioRecibo




                        rowCount = rowCount + 1

                    End While

                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try


                Sheet.Cells("A:AZ").AutoFitColumns()

                Ep.SaveAs(New FileInfo(pathReporte))

                MessageBox.Show("Excel generado correctamente")

            End Using


        Else

            MessageBox.Show("No has seleccionado una opción correcta")



        End If


        BtnAceptar.Enabled = True





    End Sub

    Function ObtenerConceptosPagotros(ByVal serieP As String, ByVal folioP As String) As IDataReader


        Dim SQL = $"Select * from pagotros where serie = '{serieP}' and recibo = {folioP} order by cuenta asc"

        Dim datosPagotros As IDataReader = ConsultaSql(SQL).ExecuteReader()

        Return datosPagotros

    End Function


    Function ObtenerConceptosPago_Mes(ByVal serieP As String, ByVal folioP As String, ByVal conceptoP As String) As IDataReader


        Dim SQL = $"Select * from pago_mes where serie = '{serieP}' and recibo = {folioP} and concepto = '{conceptoP}' order by periodo asc"

        Dim datosPagotros As IDataReader = ConsultaSql(SQL).ExecuteReader()

        Return datosPagotros

    End Function

End Class



Public Class corrige
    Public total As Decimal = 0
    Public elementos As New List(Of ELEMENTO)
    Public elementosc As New List(Of ELEMENTO)
    Public Sub Addelemento(llave As String, valor As Decimal)
        Dim X As New ELEMENTO
        X.LLAVE = llave
        X.VALOR = valor
        elementos.Add(X)
    End Sub

    Public Sub Limpiar()
        elementos.Clear()
    End Sub

    Public Sub SetNuevo()
        elementosc.Clear()
        Dim totaloriginal = elementos.Sum(Function(X) X.VALOR)

        For i = 0 To elementos.Count - 1
            Dim PORC As Decimal = elementos(i).VALOR / totaloriginal
            Dim TOTALNUEVO = total * PORC
            elementosc.Add(New ELEMENTO(elementos(i).LLAVE, TOTALNUEVO))
        Next
    End Sub


End Class

Public Class ELEMENTO
    Public VALOR As Decimal = 0
    Public LLAVE As String = String.Empty

    Public Sub New()

    End Sub

    Public Sub New(LL As String, _VALOR As Decimal)
        LLAVE = LL
        VALOR = _VALOR
    End Sub
End Class

