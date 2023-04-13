Imports System.Globalization
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

        ElseIf chkPoliza14.Checked = True Then

            GenerarPoliza14()

        ElseIf ChkPoliza15.Checked = True Then

            GenerarPoliza15()

        ElseIf chkPoliza16.Checked = True Then

            GenerarPoliza16()

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


    Function ObtenerPeriodoPago_Mes(ByVal serieP As String, ByVal folioP As String, ByVal conceptoP As String) As IDataReader


        Dim SQL = $"Select * from pago_mes where serie = '{serieP}' and recibo = {folioP} and concepto = '{conceptoP}' order by periodo asc"

        Dim datosPagotros As IDataReader = ConsultaSql(SQL).ExecuteReader()

        Return datosPagotros

    End Function

    Function ObtenerMontoPeriodoPago_Mes(ByVal serieP As String, ByVal folioP As String, ByVal conceptoP As String) As IDataReader


        Dim SQL = $"Select ano, concepto, sum(montopagado) as montoPagado, count(mes) as NumPeriodos from pago_mes where serie = '{serieP}' and recibo = {folioP} and concepto = '{conceptoP}' group by ANO order by periodo asc"

        Dim datosPagotros As IDataReader = ConsultaSql(SQL).ExecuteReader()

        Return datosPagotros

    End Function


    Function ObtenerMontoPeriodoRezagoPago_Mes(ByVal serieP As String, ByVal folioP As String, ByVal conceptoP As String, ByVal contratoMedido As Boolean) As List(Of ConceptosRezago)

        Dim listaConceptos As List(Of ConceptosRezago) = New List(Of ConceptosRezago)


        Dim SQL = $"Select MES, ano, concepto, montoPagado, FECHA from pago_mes where serie = '{serieP}' and recibo = {folioP} and concepto = '{conceptoP}' order by periodo desc"

        Try


            Dim datosConsumo As IDataReader = ConsultaSql(SQL).ExecuteReader()

            While datosConsumo.Read()

                Dim objConceptosConsumo As New ConceptosRezago
                Dim year As Integer = 0
                Dim month As Integer = 0
                Dim day As Integer = 0
                Dim fechaSeparada(2) As String

                Dim mesConsumo As String = datosConsumo("MES")
                Dim periodoConsumo As String = datosConsumo("ANO")
                Dim montoPagadoxPeriodo As Decimal = datosConsumo("montoPagado")
                Dim fechaConsumo As Date
                Dim fechaPago As Date
                Dim fechaPagoFormato As String
                'Dim fechaPagoConvertida As DateTime

                fechaConsumo = DateTime.Parse("1" & "-" & CadenaNumeroMes(mesConsumo) & "-" & periodoConsumo)
                fechaPago = DateTime.Parse(datosConsumo("FECHA"))

                fechaPagoFormato = fechaPago.ToString("dd-MM-yyyy")
                fechaSeparada = fechaPagoFormato.Split("-")

                day = Integer.Parse(fechaSeparada(0))
                month = Integer.Parse(fechaSeparada(1))
                year = Integer.Parse(fechaSeparada(2))

                If contratoMedido = True Then

                    'Si es un contrato Medido ejecuta este algoritmo

                    If month = 1 Then

                        month = 12
                        year = year - 1

                    Else

                        month = month - 1

                    End If

                    Dim fechaPagoConvertida As New DateTime(year, month, 1)

                    If (DateTime.Compare(fechaConsumo, fechaPagoConvertida) >= 0) Then

                        'MessageBox.Show("Este registro es un consumo para el contrato medido")

                        'objConceptosConsumo.mes = datosConsumo("MES").ToString()
                        'objConceptosConsumo.periodoConsumo = datosConsumo("ANO").ToString()
                        'objConceptosConsumo.concepto = "CONSUMO"

                        'listaConceptos.Add(objConceptosConsumo)

                    Else

                        'MessageBox.Show("Este registro es un rezago para el contrato fijo")

                        objConceptosConsumo.mes = datosConsumo("MES").ToString()
                        objConceptosConsumo.periodoConsumo = datosConsumo("ANO").ToString()
                        objConceptosConsumo.montoPagado = montoPagadoxPeriodo
                        objConceptosConsumo.concepto = "REZAGO"


                        listaConceptos.Add(objConceptosConsumo)

                    End If

                Else

                    'Si es un contrato Fijo ejecuta este algoritmo

                    Dim fechaPagoConvertida As New DateTime(year, month, 1)

                    If (DateTime.Compare(fechaConsumo, fechaPagoConvertida) >= 0) Then

                        'MessageBox.Show("Este registro es un consumo para el contrato fijo")

                        'objConceptosConsumo.mes = datosConsumo("MES").ToString()
                        'objConceptosConsumo.periodoConsumo = datosConsumo("ANO").ToString()
                        'objConceptosConsumo.concepto = "CONSUMO"

                        'listaConceptos.Add(objConceptosConsumo)

                    Else

                        'MessageBox.Show("Este registro es un rezago para el contrato fijo")

                        objConceptosConsumo.mes = datosConsumo("MES").ToString()
                        objConceptosConsumo.periodoConsumo = datosConsumo("ANO").ToString()
                        objConceptosConsumo.montoPagado = montoPagadoxPeriodo
                        objConceptosConsumo.concepto = "REZAGO"

                        listaConceptos.Add(objConceptosConsumo)

                    End If

                End If


            End While


            Return listaConceptos

        Catch ex As Exception
            MessageBox.Show($"Ocurrio un error al obtener los datos de rezago: {SQL}")
        End Try
    End Function


    Function ObtenerConsumoMedidosPago_Mes(ByVal serieP As String, ByVal folioP As String, ByVal conceptoP As String, ByVal contratoMedido As Boolean) As List(Of ConceptosConsumo)

        Dim listaConceptos As List(Of ConceptosConsumo) = New List(Of ConceptosConsumo)
        Dim contadorPeriodos As Integer

        Dim SQL = $"Select MES, ano, concepto, montoPagado, FECHA from pago_mes where serie = '{serieP}' and recibo = {folioP} and concepto = '{conceptoP}' order by periodo asc"

        Try


            Dim datosConsumo As IDataReader = ConsultaSql(SQL).ExecuteReader()

            While datosConsumo.Read()

                Dim objConceptosConsumo As New ConceptosConsumo

                Dim year As Integer = 0
                Dim month As Integer = 0
                Dim day As Integer = 0
                Dim fechaSeparada(2) As String

                Dim mesConsumo As String = datosConsumo("MES")
                Dim periodoConsumo As String = datosConsumo("ANO")
                Dim montoPagadoxConsumo As Decimal = datosConsumo("MONTOPAGADO")
                Dim fechaConsumo As Date
                Dim fechaPago As Date
                Dim fechaPagoFormato As String
                'Dim fechaPagoConvertida As DateTime

                fechaConsumo = DateTime.Parse("1" & "-" & CadenaNumeroMes(mesConsumo) & "-" & periodoConsumo)
                fechaPago = DateTime.Parse(datosConsumo("FECHA"))

                fechaPagoFormato = fechaPago.ToString("dd-MM-yyyy")
                fechaSeparada = fechaPagoFormato.Split("-")

                day = Integer.Parse(fechaSeparada(0))
                month = Integer.Parse(fechaSeparada(1))
                year = Integer.Parse(fechaSeparada(2))

                If contratoMedido = True Then

                    'Si es un contrato Medido ejecuta este algoritmo

                    If month = 1 Then

                        month = 12
                        year = year - 1

                    Else

                        month = month - 1

                    End If

                    Dim fechaPagoConvertida As New DateTime(year, month, 1)

                    If (DateTime.Compare(fechaConsumo, fechaPagoConvertida) >= 0) Then

                        'MessageBox.Show("Este registro es un consumo para el contrato medido")

                        objConceptosConsumo.mes = datosConsumo("MES").ToString()
                        objConceptosConsumo.periodoConsumo = datosConsumo("ANO").ToString()
                        objConceptosConsumo.montoPagado = montoPagadoxConsumo
                        objConceptosConsumo.concepto = "CONSUMO"


                        listaConceptos.Add(objConceptosConsumo)

                        'Else

                        'MessageBox.Show("Este registro es un rezago para el contrato fijo")



                    End If

                Else

                    'Si es un contrato Fijo ejecuta este algoritmo

                    Dim fechaPagoConvertida As New DateTime(year, month, 1)

                    If (DateTime.Compare(fechaConsumo, fechaPagoConvertida) >= 0) Then

                        objConceptosConsumo.mes = datosConsumo("MES").ToString()
                        objConceptosConsumo.periodoConsumo = datosConsumo("ANO").ToString()
                        objConceptosConsumo.montoPagado = montoPagadoxConsumo
                        objConceptosConsumo.concepto = "CONSUMO"

                        listaConceptos.Add(objConceptosConsumo)

                        'Else

                        'MessageBox.Show("Este registro es un rezago para el contrato fijo")



                    End If

                End If


            End While


            Return listaConceptos

        Catch ex As Exception
            MessageBox.Show($"Ocurrio un error al obtener los datos de rezago: {SQL}")

        End Try
    End Function


    'Function ObtenerOtrosConceptos(ByVal serieP As String, ByVal folioP As String, ByVal conceptoP As String, ByVal contratoMedido As Boolean) As List(Of ConceptosConsumo)

    '    Dim listaConceptos As List(Of ConceptosConsumo) = New List(Of ConceptosConsumo)
    '    Dim contadorPeriodos As Integer

    '    Dim SQL = $"Select MES, ano, concepto, montoPagado, FECHA from pago_mes where serie = '{serieP}' and recibo = {folioP} and concepto = '{conceptoP}' order by periodo asc"

    '    Try


    '        Dim datosConsumo As IDataReader = ConsultaSql(SQL).ExecuteReader()

    '        While datosConsumo.Read()

    '            Dim objConceptosConsumo As New ConceptosConsumo

    '            Dim year As Integer = 0
    '            Dim month As Integer = 0
    '            Dim day As Integer = 0
    '            Dim fechaSeparada(2) As String

    '            Dim mesConsumo As String = datosConsumo("MES")
    '            Dim periodoConsumo As String = datosConsumo("ANO")
    '            Dim montoPagadoxConsumo As Decimal = datosConsumo("MONTOPAGADO")
    '            Dim fechaConsumo As Date
    '            Dim fechaPago As Date
    '            Dim fechaPagoFormato As String
    '            'Dim fechaPagoConvertida As DateTime

    '            fechaConsumo = DateTime.Parse("1" & "-" & CadenaNumeroMes(mesConsumo) & "-" & periodoConsumo)
    '            fechaPago = DateTime.Parse(datosConsumo("FECHA"))

    '            fechaPagoFormato = fechaPago.ToString("dd-MM-yyyy")
    '            fechaSeparada = fechaPagoFormato.Split("-")

    '            day = Integer.Parse(fechaSeparada(0))
    '            month = Integer.Parse(fechaSeparada(1))
    '            year = Integer.Parse(fechaSeparada(2))

    '            If contratoMedido = True Then

    '                'Si es un contrato Medido ejecuta este algoritmo

    '                If month = 1 Then

    '                    month = 12
    '                    year = year - 1

    '                Else

    '                    month = month - 1

    '                End If

    '                Dim fechaPagoConvertida As New DateTime(year, month, 1)

    '                If (DateTime.Compare(fechaConsumo, fechaPagoConvertida) >= 0) Then

    '                    'MessageBox.Show("Este registro es un consumo para el contrato medido")

    '                    objConceptosConsumo.mes = datosConsumo("MES").ToString()
    '                    objConceptosConsumo.periodoConsumo = datosConsumo("ANO").ToString()
    '                    objConceptosConsumo.montoPagado = montoPagadoxConsumo
    '                    objConceptosConsumo.concepto = "CONSUMO"


    '                    listaConceptos.Add(objConceptosConsumo)

    '                    'Else

    '                    'MessageBox.Show("Este registro es un rezago para el contrato fijo")



    '                End If

    '            Else

    '                'Si es un contrato Fijo ejecuta este algoritmo

    '                Dim fechaPagoConvertida As New DateTime(year, month, 1)

    '                If (DateTime.Compare(fechaConsumo, fechaPagoConvertida) >= 0) Then

    '                    objConceptosConsumo.mes = datosConsumo("MES").ToString()
    '                    objConceptosConsumo.periodoConsumo = datosConsumo("ANO").ToString()
    '                    objConceptosConsumo.montoPagado = montoPagadoxConsumo
    '                    objConceptosConsumo.concepto = "CONSUMO"

    '                    listaConceptos.Add(objConceptosConsumo)

    '                    'Else

    '                    'MessageBox.Show("Este registro es un rezago para el contrato fijo")



    '                End If

    '            End If


    '        End While


    '        Return listaConceptos

    '    Catch ex As Exception
    '        MessageBox.Show($"Ocurrio un error al obtener los datos de rezago: {SQL}")

    '    End Try
    'End Function


    Public Sub GenerarPoliza14()


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
        Dim ruta As String = "\\EstadisticaNueva\\" + "Póliza14_.xlsx"
        Dim pathReporte As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ruta).Trim()


        ExcelPackage.LicenseContext = LicenseContext.NonCommercial




        Using Ep As New ExcelPackage()


            Dim Sheet = Ep.Workbook.Worksheets.Add("PÓLIZA 14")


            Dim rowCount As Integer = 1



            Sheet.Cells("A1:E1").Style.Font.Size = 13
            Sheet.Cells("A1:E1").Style.Font.Name = "Calibri"
            Sheet.Cells("A1:E3").Style.Font.Bold = True
            Sheet.Cells("A1:E1").Style.Font.Color.SetColor(Color.DarkBlue)
            Sheet.Cells("A1:E1").Style.HorizontalAlignment = ExcelHorizontalAlignment.Left
            Sheet.Cells("A1").RichText.Add("REPORTE POLIZA CONCENTRADA")


            Sheet.Cells("A2:E3").Style.Font.Size = 12
            Sheet.Cells("A2:E3").Style.Font.Name = "Calibri"
            Sheet.Cells("A2:E3").Style.Font.Bold = True
            Sheet.Cells("A2:E3").Style.Font.Color.SetColor(Color.DarkBlue)
            Sheet.Cells("A2:E3").Style.HorizontalAlignment = ExcelHorizontalAlignment.Left
            Sheet.Cells("A2").RichText.Add($"MES: {UnixDateFormat(fecini.SelectedDate)} AL {UnixDateFormat(fecfinal.SelectedDate)}")


            Sheet.Cells("A3:E3").Style.Font.Size = 12
            Sheet.Cells("A3:E3").Style.Font.Name = "Calibri"
            Sheet.Cells("A3:E3").Style.Font.Bold = True
            Sheet.Cells("A3:E3").Style.Font.Color.SetColor(Color.DarkBlue)
            Sheet.Cells("A3:E3").Style.HorizontalAlignment = ExcelHorizontalAlignment.Left

            Dim nombreOrganismo As String = obtenerCampo($"select CNOMBRE from EMPRESA where CODEMP = 1", "CNOMBRE")
            Sheet.Cells("A3").RichText.Add($"ORGANISMO: {nombreOrganismo}")



            Try

                'ENCABEZADOS DEL DOCUMENTO
                rowCount = 5
                Sheet.Cells.Style.Font.Name = "Calibri"
                Sheet.Cells.Style.Font.Size = 10
                Sheet.Cells("A5:AT5").Style.Font.Bold = True
                Sheet.Cells("A5:AT5").Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
                Sheet.Cells("A5:AT5").Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray)


                Sheet.Cells("A5").RichText.Add("FECHA")
                Sheet.Cells("B5").RichText.Add("NUMERO DE PAGOS")
                'Sheet.Cells("C5").RichText.Add("ALCANTARILLADO DE PERIODO")

                Sheet.Cells("C5").RichText.Add("CONSUMO AGUA DEL PERIODO")


                Sheet.Cells("D5").RichText.Add("ALCATARILLADO 2023")
                Sheet.Cells("E5").RichText.Add("ALCATARILLADO 2022")
                Sheet.Cells("F5").RichText.Add("ALCATARILLADO 2021")
                Sheet.Cells("G5").RichText.Add("ALCATARILLADO 2020")
                Sheet.Cells("H5").RichText.Add("ALCATARILLADO 2019")
                Sheet.Cells("I5").RichText.Add("ALCATARILLADO 2018")
                Sheet.Cells("J5").RichText.Add("ALCATARILLADO 2017")
                Sheet.Cells("K5").RichText.Add("ALCATARILLADO 2016")
                Sheet.Cells("L5").RichText.Add("TOTAL ALCANTARILLADO")


                Sheet.Cells("M5").RichText.Add("REZAGO 2023")
                Sheet.Cells("N5").RichText.Add("REZAGO 2022")
                Sheet.Cells("O5").RichText.Add("REZAGO 2021")
                Sheet.Cells("P5").RichText.Add("REZAGO 2020")
                Sheet.Cells("Q5").RichText.Add("REZAGO 2019")
                Sheet.Cells("R5").RichText.Add("REZAGO 2018")
                Sheet.Cells("S5").RichText.Add("REZAGO 2017")
                Sheet.Cells("T5").RichText.Add("REZAGO 2016")
                Sheet.Cells("U5").RichText.Add("TOTAL REZAGO")


                Sheet.Cells("V5").RichText.Add("RECARGO 2023")
                Sheet.Cells("W5").RichText.Add("RECARGO 2022")
                Sheet.Cells("X5").RichText.Add("RECARGO 2021")
                Sheet.Cells("Y5").RichText.Add("RECARGO 2020")
                Sheet.Cells("Z5").RichText.Add("RECARGO 2019")
                Sheet.Cells("AA5").RichText.Add("RECARGO 2018")
                Sheet.Cells("AB5").RichText.Add("RECARGO 2017")
                Sheet.Cells("AC5").RichText.Add("RECARGO 2016")
                Sheet.Cells("AD5").RichText.Add("TOTAL RECARGOS")



                Sheet.Cells("AE5").RichText.Add("OTROS DERECHOS")
                Sheet.Cells("AF5").RichText.Add("TOTAL GENERAL")




                rowCount = 6

                'Dim datos As IDataReader = ConsultaSql($"Select * from pago_mes where fecha between '{UnixDateFormat(fecini.SelectedDate)}' and '{UnixDateFormat(fecfinal.SelectedDate)}'").ExecuteReader
                Dim SQL = "Select FECHA_ACT, COUNT(RECIBO) AS NUMRECIBOS from pagos where fecha_act between '" & UnixDateFormat(fecini.SelectedDate) & "' and '" & UnixDateFormat(fecfinal.SelectedDate) & "' AND CANCELADO = 'A' GROUP BY FECHA_ACT"

                Dim datos As IDataReader = ConsultaSql(SQL).ExecuteReader()

                While datos.Read()

                    Dim totalGeneral As Decimal = 0.0
                    Dim montoConsumo As Decimal = 0.0

                    Dim acumuladorConsumo As Decimal = 0.0
                    Dim montoRezago As Decimal = 0.0
                    Dim montoRecargos As Decimal = 0.0
                    Dim acumuladorMontosOtrosConceptos As Decimal = 0.0

                    Dim periodoAlcantaGlobal As Integer = 0
                    Dim periodoRezagoGlobal As Integer = 0
                    Dim periodoRecargosGlobal As Integer = 0

                    Dim montoAlcantaGlobal As Decimal = 0.0
                    Dim montoRezagoGlobal As Decimal = 0.0
                    Dim montoRecargosGlobal As Decimal = 0.0

                    Dim fechaAgrupada As String = datos("FECHA_ACT")
                    Dim numRecibos As Integer = datos("NUMRECIBOS")

                    Dim acumuladorAlcantarillado As Decimal
                    Dim acumuladorRezago As Decimal
                    Dim acumuladorRecargos As Decimal

                    Dim listConceptosAlcantarillado As List(Of ConceptosAlcantarillado) = New List(Of ConceptosAlcantarillado)
                    Dim listConceptosRezago As List(Of ConceptosRezago) = New List(Of ConceptosRezago)
                    Dim listConceptosRecargos As List(Of ConceptosRecargos) = New List(Of ConceptosRecargos)




                    Dim formato As String = ""
                    formato = Format(CDate(datos("FECHA_ACT")), "dd/MM/yyyy")
                    Sheet.Cells(String.Format("A{0}", rowCount)).Style.Numberformat.Format = DateTimeFormatInfo.CurrentInfo.ShortDatePattern
                    Sheet.Cells(String.Format("A{0}", rowCount)).Value = formato

                    Dim fechaConvertida As String = ""
                    fechaConvertida = Format(CDate(datos("FECHA_ACT")), "yyyy/MM/dd")


                    Sheet.Cells(String.Format("B{0}", rowCount)).Value = numRecibos

                    ' Necesito hacer otra consulta para traer el dato de tarifa, serie y folio del recibo para que funcionen los calculadores de ocnsumo, rezago, etc

                    Dim SQL2 = $"Select * from pagos where fecha_act = '{fechaConvertida}'"

                    Dim datos2 As IDataReader = ConsultaSql(SQL2).ExecuteReader()


                    While datos2.Read()





                        Dim contratoFijo As Boolean = False
                        Dim contratoMedido As Boolean = False

                        'Dim totalGeneral2 As Decimal = 0.0

                        Dim serieRecibo As String = datos2("SERIE").ToString()
                        Dim folioRecibo As Integer = datos2("RECIBO")

                        Try


                            Dim SQLTarifa = $"Select * from cuotas where ID_TARIFA = {datos2("TARIFA")}"

                            Dim datosTarifa As IDataReader = ConsultaSql(SQLTarifa).ExecuteReader()

                        datosTarifa.Read()

                        If datosTarifa("MEDIDO") = 0 Then

                            contratoFijo = True

                        Else

                            contratoMedido = True

                        End If

                    Catch ex As Exception

                    End Try


                    Dim datosPagotros As IDataReader = ObtenerConceptosPagotros(serieRecibo, folioRecibo)



                        While datosPagotros.Read()

                            If contratoFijo = True Then


                            If datosPagotros("NUMCONCEPTO") = "081DES" Or datosPagotros("NUMCONCEPTO") = "004RZG" Then

                                    'Sheet.Cells(String.Format("C{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                    'Sheet.Cells(String.Format("C{0}", rowCount)).Value = datosPagotros("CONCEPTO").ToString()

                                    'acumuladorConsumo = acumuladorConsumo + Decimal.Parse(datosPagotros("MONTO"))

                                    Dim listConceptoConsumoMedido As List(Of ConceptosConsumo) = ObtenerConsumoMedidosPago_Mes(serieRecibo, folioRecibo, "CONSUMO", False)

                                Dim objConceptoConsumoMedido2 As New ConceptosConsumo
                                Dim periodoConsumoMedido As String

                                'For i = 1 To listConceptoConsumoMedido.Count

                                '    objConceptoConsumoMedido2 = listConceptoConsumoMedido.Item(i)

                                '    periodoConsumoMedido += $"{objConceptoConsumoMedido2.mes} {objConceptoConsumoMedido2.periodoConsumo} - "

                                'Next

                                For Each elemento In listConceptoConsumoMedido
                                        'periodoConsumoMedido += $"{elemento.mes} {elemento.periodoConsumo} "

                                        acumuladorConsumo = acumuladorConsumo + elemento.montoPagado
                                    montoConsumo = elemento.montoPagado
                                Next


                                    'If montoConsumo > 0 Then

                                    '    Sheet.Cells(String.Format("C{0}", rowCount)).Value = $"CONSUMO DE AGUA PERIODO {periodoConsumoMedido} "

                                    'Else

                                    '    Sheet.Cells(String.Format("C{0}", rowCount)).Value = $" "

                                    'End If



                                    periodoConsumoMedido = ""

                            End If

                        ElseIf contratoMedido = True Then

                            If datosPagotros("NUMCONCEPTO") = "081DES" Or datosPagotros("NUMCONCEPTO") = "004RZG" Then

                                'Sheet.Cells(String.Format("C{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"

                                Dim listConceptoConsumoMedido As List(Of ConceptosConsumo) = ObtenerConsumoMedidosPago_Mes(serieRecibo, folioRecibo, "CONSUMO", contratoMedido)

                                Dim objConceptoConsumoMedido2 As New ConceptosConsumo
                                Dim periodoConsumoMedido As String

                                'For i = 1 To listConceptoConsumoMedido.Count

                                '    objConceptoConsumoMedido2 = listConceptoConsumoMedido.Item(i)

                                '    periodoConsumoMedido += $"{objConceptoConsumoMedido2.mes} {objConceptoConsumoMedido2.periodoConsumo} - "

                                'Next

                                For Each elemento In listConceptoConsumoMedido
                                        'periodoConsumoMedido += $"{elemento.mes} {elemento.periodoConsumo} "

                                        acumuladorConsumo = acumuladorConsumo + elemento.montoPagado
                                Next

                                    'Sheet.Cells(String.Format("C{0}", rowCount)).Value = $"CONSUMO DE AGUA PERIODO {periodoConsumoMedido} "

                                    periodoConsumoMedido = ""
                            End If

                                'Sheet.Cells(String.Format("AS{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                'Sheet.Cells(String.Format("AS{0}", rowCount)).Value = acumuladorConsumo

                            End If




                        If datosPagotros("NUMCONCEPTO") = "002DRE" Then

                                'Dim periodoAlcantarillado As Integer = 0


                                'Dim datosPago_Alcant As IDataReader = ObtenerConceptosPago_Mes(serieRecibo, folioRecibo, "ALCANTARILLADO")
                                'Dim concatenarConcepto As String

                                Dim datosPago_Alcant As IDataReader = ObtenerMontoPeriodoPago_Mes(serieRecibo, folioRecibo, "ALCANTARILLADO")
                                'Dim concatenarConcepto As String

                                'Sheet.Cells(String.Format("D{0}:K{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"

                                While datosPago_Alcant.Read()

                                    Dim objConceptosAlcanta As New ConceptosAlcantarillado

                                    Dim montoAlcantarillado As Decimal = 0.0
                                    Dim periodoAlcantarillado As Integer = Integer.Parse(datosPago_Alcant("ano"))
                                montoAlcantarillado = datosPago_Alcant("montoPagado")
                                'concatenarConcepto += " " & datosPago_Alcant("MES").ToString() & " " & datosPago_Alcant("ANO").ToString() & ", "
                                Select Case periodoAlcantarillado


                                    Case 2023

                                            'Sheet.Cells(String.Format("D{0}", rowCount)).Value = montoAlcantarillado


                                            objConceptosAlcanta.concepto = "ALCANTARILLADO"
                                            objConceptosAlcanta.mes = ""
                                            objConceptosAlcanta.periodoAlcantarillado = 2023
                                            objConceptosAlcanta.montoPagado = montoAlcantarillado

                                            listConceptosAlcantarillado.Add(objConceptosAlcanta)

                                        Case 2022

                                            'Sheet.Cells(String.Format("E{0}", rowCount)).Value = montoAlcantarillado


                                            objConceptosAlcanta.concepto = "ALCANTARILLADO"
                                            objConceptosAlcanta.mes = ""
                                            objConceptosAlcanta.periodoAlcantarillado = 2022
                                            objConceptosAlcanta.montoPagado = montoAlcantarillado

                                            listConceptosAlcantarillado.Add(objConceptosAlcanta)

                                        Case 2021

                                            'Sheet.Cells(String.Format("F{0}", rowCount)).Value = montoAlcantarillado


                                            objConceptosAlcanta.concepto = "ALCANTARILLADO"
                                            objConceptosAlcanta.mes = ""
                                            objConceptosAlcanta.periodoAlcantarillado = 2021
                                            objConceptosAlcanta.montoPagado = montoAlcantarillado

                                            listConceptosAlcantarillado.Add(objConceptosAlcanta)

                                        Case 2020

                                            'Sheet.Cells(String.Format("G{0}", rowCount)).Value = montoAlcantarillado


                                            objConceptosAlcanta.concepto = "ALCANTARILLADO"
                                            objConceptosAlcanta.mes = ""
                                            objConceptosAlcanta.periodoAlcantarillado = 2020
                                            objConceptosAlcanta.montoPagado = montoAlcantarillado

                                            listConceptosAlcantarillado.Add(objConceptosAlcanta)

                                        Case 2019

                                            'Sheet.Cells(String.Format("H{0}", rowCount)).Value = montoAlcantarillado


                                            objConceptosAlcanta.concepto = "ALCANTARILLADO"
                                            objConceptosAlcanta.mes = ""
                                            objConceptosAlcanta.periodoAlcantarillado = 2019
                                            objConceptosAlcanta.montoPagado = montoAlcantarillado

                                            listConceptosAlcantarillado.Add(objConceptosAlcanta)

                                        Case 2018

                                            'Sheet.Cells(String.Format("I{0}", rowCount)).Value = montoAlcantarillado


                                            objConceptosAlcanta.concepto = "ALCANTARILLADO"
                                            objConceptosAlcanta.mes = ""
                                            objConceptosAlcanta.periodoAlcantarillado = 2018
                                            objConceptosAlcanta.montoPagado = montoAlcantarillado

                                            listConceptosAlcantarillado.Add(objConceptosAlcanta)

                                        Case 2017

                                            'Sheet.Cells(String.Format("J{0}", rowCount)).Value = montoAlcantarillado


                                            objConceptosAlcanta.concepto = "ALCANTARILLADO"
                                            objConceptosAlcanta.mes = ""
                                            objConceptosAlcanta.periodoAlcantarillado = 2017
                                            objConceptosAlcanta.montoPagado = montoAlcantarillado

                                            listConceptosAlcantarillado.Add(objConceptosAlcanta)

                                        Case 2016

                                            'Sheet.Cells(String.Format("K{0}", rowCount)).Value = montoAlcantarillado


                                            objConceptosAlcanta.concepto = "ALCANTARILLADO"
                                            objConceptosAlcanta.mes = ""
                                            objConceptosAlcanta.periodoAlcantarillado = 2016
                                            objConceptosAlcanta.montoPagado = montoAlcantarillado

                                            listConceptosAlcantarillado.Add(objConceptosAlcanta)

                                    End Select

                            End While

                                'Sheet.Cells(String.Format("D{0}", rowCount)).Value = datosPagotros("CONCEPTO").ToString() & concatenarConcepto

                                'concatenarConcepto = ""
                                'Sheet.Cells(String.Format("AR{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                'Sheet.Cells(String.Format("AR{0}", rowCount)).Value = acumuladorAlcantarillado

                            End If





                        If datosPagotros("NUMCONCEPTO") = "004RZG" Then

                                Dim periodoRezago As Integer = 0

                                Dim objConceptosRezago As New ConceptosRezago

                                '    Dim contadorPeriodos As Integer = 0

                                'Dim datosPago_Alcant As IDataReader = ObtenerConceptosPago_Mes(serieRecibo, folioRecibo, "ALCANTARILLADO")
                                'Dim concatenarConcepto As String

                                If datosPagotros("CUENTA") = 4758 Then
                                MessageBox.Show("CUENTA 4758")
                            End If

                                Dim listConceptosRez As List(Of ConceptosRezago) = ObtenerMontoPeriodoRezagoPago_Mes(serieRecibo, folioRecibo, "CONSUMO", contratoMedido)

                                'Dim objConceptosConsumo2 As New ConceptosConsumo

                                'Sheet.Cells(String.Format("S{0}:AJ{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"

                                'For i = 1 To objConceptosConsumo.Listadeconceptos.Count

                                '    objConceptosConsumo2 = objConceptosConsumo.Listadeconceptos.Item(i)

                                'For Each elemento In listConceptosRezago

                                '    'periodoConsumoMedido += $"{elemento.mes} {elemento.periodoConsumo} "

                                'Next


                                Dim montosRezago = From rezago In listConceptosRez
                                                   Group By PerRezago = rezago.periodoConsumo
                                                    Into RezagosenPeriodo = Group, MontoPagado = Sum(rezago.montoPagado)


                                For Each result In montosRezago
                                'Debug.WriteLine($"{result.PeriodoLecturas} {result.MontoPagado}")

                                periodoRezago = result.PerRezago
                                montoRezago = result.MontoPagado

                                Select Case periodoRezago


                                    Case 2023

                                            'Sheet.Cells(String.Format("S{0}", rowCount)).Value = montoRezago



                                            objConceptosRezago.periodoConsumo = 2023
                                            objConceptosRezago.montoPagado = montoRezago

                                            listConceptosRezago.Add(objConceptosRezago)

                                        Case 2022

                                            'Sheet.Cells(String.Format("T{0}", rowCount)).Value = montoRezago

                                            objConceptosRezago.periodoConsumo = 2022
                                            objConceptosRezago.montoPagado = montoRezago

                                            listConceptosRezago.Add(objConceptosRezago)

                                        Case 2021

                                            'Sheet.Cells(String.Format("U{0}", rowCount)).Value = montoRezago

                                            objConceptosRezago.periodoConsumo = 2021
                                            objConceptosRezago.montoPagado = montoRezago

                                            listConceptosRezago.Add(objConceptosRezago)

                                        Case 2020

                                            'Sheet.Cells(String.Format("V{0}", rowCount)).Value = montoRezago

                                            objConceptosRezago.periodoConsumo = 2020
                                            objConceptosRezago.montoPagado = montoRezago

                                            listConceptosRezago.Add(objConceptosRezago)

                                        Case 2019

                                            'Sheet.Cells(String.Format("W{0}", rowCount)).Value = montoRezago

                                            objConceptosRezago.periodoConsumo = 2019
                                            objConceptosRezago.montoPagado = montoRezago

                                            listConceptosRezago.Add(objConceptosRezago)

                                        Case 2018

                                            'Sheet.Cells(String.Format("X{0}", rowCount)).Value = montoRezago

                                            objConceptosRezago.periodoConsumo = 2018
                                            objConceptosRezago.montoPagado = montoRezago

                                            listConceptosRezago.Add(objConceptosRezago)


                                        Case 2017

                                            'Sheet.Cells(String.Format("Y{0}", rowCount)).Value = montoRezago

                                            objConceptosRezago.periodoConsumo = 2017
                                            objConceptosRezago.montoPagado = montoRezago

                                            listConceptosRezago.Add(objConceptosRezago)

                                        Case 2016

                                            'Sheet.Cells(String.Format("Z{0}", rowCount)).Value = montoRezago

                                            objConceptosRezago.periodoConsumo = 2016
                                            objConceptosRezago.montoPagado = montoRezago

                                            listConceptosRezago.Add(objConceptosRezago)


                                    End Select

                                    'contadorPeriodos = listConceptosRezago.Count

                                Next

                                'Sheet.Cells(String.Format("AA{0}", rowCount)).Value = acumuladorRezago

                                'Sheet.Cells(String.Format("P{0}", rowCount)).Value = contadorPeriodos
                                'Dim periodoRezago As Integer = Integer.Parse(objConceptosConsumo2.periodoConsumo)
                                ''concatenarConcepto += " " & datosPago_Alcant("MES").ToString() & " " & datosPago_Alcant("ANO").ToString() & ", "

                            End If



                        If datosPagotros("NUMCONCEPTO") = "003REC" Then

                            Dim periodoRecargos As Integer = 0

                                Dim contadorPeriodosRecargos As Integer = 0

                            'Dim datosPago_Alcant As IDataReader = ObtenerConceptosPago_Mes(serieRecibo, folioRecibo, "ALCANTARILLADO")
                            'Dim concatenarConcepto As String

                            Dim datosPago_Recargo As IDataReader = ObtenerMontoPeriodoPago_Mes(serieRecibo, folioRecibo, "RECARGO")
                            'Dim concatenarConcepto As String

                            'Sheet.Cells(String.Format("D{0}:I{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"

                            While datosPago_Recargo.Read()

                                    Dim objConceptosRecargos As New ConceptosRecargos

                                    Dim periodoRecargo As Integer = Integer.Parse(datosPago_Recargo("ano"))
                                Dim montoPagado As Decimal = datosPago_Recargo("montoPagado")
                                Dim numPeriodos As Integer = datosPago_Recargo("NumPeriodos")
                                'concatenarConcepto += " " & datosPago_Alcant("MES").ToString() & " " & datosPago_Alcant("ANO").ToString() & ", "

                                Select Case periodoRecargo


                                    Case 2023

                                            'Sheet.Cells(String.Format("AB{0}", rowCount)).Value = montoPagado

                                            objConceptosRecargos.periodoRecargo = 2023
                                            objConceptosRecargos.montoPagado = montoPagado

                                            listConceptosRecargos.Add(objConceptosRecargos)

                                        Case 2022

                                            'Sheet.Cells(String.Format("AC{0}", rowCount)).Value = montoPagado

                                            objConceptosRecargos.periodoRecargo = 2022
                                            objConceptosRecargos.montoPagado = montoPagado

                                            listConceptosRecargos.Add(objConceptosRecargos)

                                        Case 2021

                                            'Sheet.Cells(String.Format("AD{0}", rowCount)).Value = montoPagado

                                            objConceptosRecargos.periodoRecargo = 2021
                                            objConceptosRecargos.montoPagado = montoPagado

                                            listConceptosRecargos.Add(objConceptosRecargos)

                                        Case 2020

                                            'Sheet.Cells(String.Format("AE{0}", rowCount)).Value = montoPagado

                                            objConceptosRecargos.periodoRecargo = 2020
                                            objConceptosRecargos.montoPagado = montoPagado

                                            listConceptosRecargos.Add(objConceptosRecargos)

                                        Case 2019

                                            'Sheet.Cells(String.Format("AF{0}", rowCount)).Value = montoPagado

                                            objConceptosRecargos.periodoRecargo = 2019
                                            objConceptosRecargos.montoPagado = montoPagado

                                            listConceptosRecargos.Add(objConceptosRecargos)

                                        Case 2018

                                            'Sheet.Cells(String.Format("AG{0}", rowCount)).Value = montoPagado

                                            objConceptosRecargos.periodoRecargo = 2018
                                            objConceptosRecargos.montoPagado = montoPagado

                                            listConceptosRecargos.Add(objConceptosRecargos)


                                        Case 2017

                                            'Sheet.Cells(String.Format("AH{0}", rowCount)).Value = montoPagado

                                            objConceptosRecargos.periodoRecargo = 2017
                                            objConceptosRecargos.montoPagado = montoPagado

                                            listConceptosRecargos.Add(objConceptosRecargos)

                                        Case 2016

                                            'Sheet.Cells(String.Format("AI{0}", rowCount)).Value = montoPagado

                                            objConceptosRecargos.periodoRecargo = 2016
                                            objConceptosRecargos.montoPagado = montoPagado

                                            listConceptosRecargos.Add(objConceptosRecargos)


                                    End Select


                                    'contadorPeriodosRecargos = contadorPeriodosRecargos + numPeriodos
                                End While

                                'Sheet.Cells(String.Format("AJ{0}", rowCount)).Value = acumuladorRecargos

                                'Sheet.Cells(String.Format("Q{0}", rowCount)).Value = contadorPeriodosRecargos
                                'Sheet.Cells(String.Format("D{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                'Sheet.Cells(String.Format("D{0}", rowCount)).Value = datosPagotros("CONCEPTO").ToString() & concatenarConcepto

                                'concatenarConcepto = ""
                            End If

                        If datosPagotros("NUMCONCEPTO") <> "081DES" And datosPagotros("NUMCONCEPTO") <> "004RZG" And datosPagotros("NUMCONCEPTO") <> "002DRE" And datosPagotros("NUMCONCEPTO") <> "003REC" Then

                            acumuladorMontosOtrosConceptos = acumuladorMontosOtrosConceptos + Decimal.Parse(datosPagotros("MONTO"))

                        End If

                    End While


                    End While



                    Sheet.Cells(String.Format("C{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                    Sheet.Cells(String.Format("C{0}", rowCount)).Value = acumuladorConsumo




                    Dim totalAlcantarillados As Decimal = 0.0
                    Dim montosAlcantarillado = From alcanta In listConceptosAlcantarillado
                                               Group By PerAlcan = alcanta.periodoAlcantarillado
                                        Into AlcantaenPeriodo = Group, MontoPagado = Sum(alcanta.montoPagado)


                    For Each resultAlcanta In montosAlcantarillado
                        'Debug.WriteLine($"{result.PeriodoLecturas} {result.MontoPagado}")

                        periodoAlcantaGlobal = resultAlcanta.PerAlcan
                        montoAlcantaGlobal = resultAlcanta.MontoPagado


                        Select Case periodoAlcantaGlobal


                            Case 2023

                                Sheet.Cells(String.Format("D{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                Sheet.Cells(String.Format("D{0}", rowCount)).Value = montoAlcantaGlobal

                                totalAlcantarillados = totalAlcantarillados + montoAlcantaGlobal

                            Case 2022

                                Sheet.Cells(String.Format("E{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                Sheet.Cells(String.Format("E{0}", rowCount)).Value = montoAlcantaGlobal

                                totalAlcantarillados = totalAlcantarillados + montoAlcantaGlobal

                            Case 2021

                                Sheet.Cells(String.Format("F{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                Sheet.Cells(String.Format("F{0}", rowCount)).Value = montoAlcantaGlobal

                                totalAlcantarillados = totalAlcantarillados + montoAlcantaGlobal

                            Case 2020

                                Sheet.Cells(String.Format("G{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                Sheet.Cells(String.Format("G{0}", rowCount)).Value = montoAlcantaGlobal

                                totalAlcantarillados = totalAlcantarillados + montoAlcantaGlobal

                            Case 2019

                                Sheet.Cells(String.Format("H{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                Sheet.Cells(String.Format("H{0}", rowCount)).Value = montoAlcantaGlobal

                                totalAlcantarillados = totalAlcantarillados + montoAlcantaGlobal

                            Case 2018

                                Sheet.Cells(String.Format("I{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                Sheet.Cells(String.Format("I{0}", rowCount)).Value = montoAlcantaGlobal

                                totalAlcantarillados = totalAlcantarillados + montoAlcantaGlobal

                            Case 2017

                                Sheet.Cells(String.Format("J{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                Sheet.Cells(String.Format("J{0}", rowCount)).Value = montoAlcantaGlobal

                                totalAlcantarillados = totalAlcantarillados + montoAlcantaGlobal

                            Case 2016

                                Sheet.Cells(String.Format("K{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                Sheet.Cells(String.Format("K{0}", rowCount)).Value = montoAlcantaGlobal

                                totalAlcantarillados = totalAlcantarillados + montoAlcantaGlobal

                        End Select


                    Next


                    Dim totalRezagos As Decimal = 0.0
                    Dim montosRezagos = From rezago In listConceptosRezago
                                        Group By PerRezago = rezago.periodoConsumo
                                        Into RezagoenPeriodo = Group, MontoPagado = Sum(rezago.montoPagado)


                    For Each resultRezagos In montosRezagos
                        'Debug.WriteLine($"{result.PeriodoLecturas} {result.MontoPagado}")

                        periodoRezagoGlobal = resultRezagos.PerRezago
                        montoRezagoGlobal = resultRezagos.MontoPagado


                        Select Case periodoRezagoGlobal


                            Case 2023

                                Sheet.Cells(String.Format("M{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                Sheet.Cells(String.Format("M{0}", rowCount)).Value = montoRezagoGlobal

                                totalRezagos = totalRezagos + montoRezagoGlobal

                            Case 2022

                                Sheet.Cells(String.Format("N{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                Sheet.Cells(String.Format("N{0}", rowCount)).Value = montoRezagoGlobal

                                totalRezagos = totalRezagos + montoRezagoGlobal

                            Case 2021

                                Sheet.Cells(String.Format("O{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                Sheet.Cells(String.Format("O{0}", rowCount)).Value = montoRezagoGlobal

                                totalRezagos = totalRezagos + montoRezagoGlobal

                            Case 2020

                                Sheet.Cells(String.Format("P{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                Sheet.Cells(String.Format("P{0}", rowCount)).Value = montoRezagoGlobal

                                totalRezagos = totalRezagos + montoRezagoGlobal

                            Case 2019

                                Sheet.Cells(String.Format("Q{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                Sheet.Cells(String.Format("Q{0}", rowCount)).Value = montoRezagoGlobal

                                totalRezagos = totalRezagos + montoRezagoGlobal

                            Case 2018

                                Sheet.Cells(String.Format("R{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                Sheet.Cells(String.Format("R{0}", rowCount)).Value = montoRezagoGlobal

                                totalRezagos = totalRezagos + montoRezagoGlobal

                            Case 2017

                                Sheet.Cells(String.Format("S{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                Sheet.Cells(String.Format("S{0}", rowCount)).Value = montoRezagoGlobal

                                totalRezagos = totalRezagos + montoRezagoGlobal

                            Case 2016

                                Sheet.Cells(String.Format("T{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                Sheet.Cells(String.Format("T{0}", rowCount)).Value = montoRezagoGlobal

                                totalRezagos = totalRezagos + montoRezagoGlobal

                        End Select


                    Next



                    Dim totalRecargos As Decimal = 0.0
                    Dim montosRecargos = From recargos In listConceptosRecargos
                                         Group By PerRecargos = recargos.periodoRecargo
                                        Into RecargosenPeriodo = Group, MontoPagado = Sum(recargos.montoPagado)


                    For Each resultRecargos In montosRecargos
                        'Debug.WriteLine($"{result.PeriodoLecturas} {result.MontoPagado}")

                        periodoRecargosGlobal = resultRecargos.PerRecargos
                        montoRecargosGlobal = resultRecargos.MontoPagado


                        Select Case periodoRecargosGlobal


                            Case 2023

                                Sheet.Cells(String.Format("V{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                Sheet.Cells(String.Format("V{0}", rowCount)).Value = montoRecargosGlobal

                                totalRecargos = totalRecargos + montoRecargosGlobal

                            Case 2022

                                Sheet.Cells(String.Format("W{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                Sheet.Cells(String.Format("W{0}", rowCount)).Value = montoRecargosGlobal

                                totalRecargos = totalRecargos + montoRecargosGlobal

                            Case 2021

                                Sheet.Cells(String.Format("X{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                Sheet.Cells(String.Format("X{0}", rowCount)).Value = montoRecargosGlobal

                                totalRecargos = totalRecargos + montoRecargosGlobal

                            Case 2020

                                Sheet.Cells(String.Format("Y{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                Sheet.Cells(String.Format("Y{0}", rowCount)).Value = montoRecargosGlobal

                                totalRecargos = totalRecargos + montoRecargosGlobal

                            Case 2019

                                Sheet.Cells(String.Format("Z{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                Sheet.Cells(String.Format("Z{0}", rowCount)).Value = montoRecargosGlobal

                                totalRecargos = totalRecargos + montoRecargosGlobal

                            Case 2018

                                Sheet.Cells(String.Format("AA{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                Sheet.Cells(String.Format("AA{0}", rowCount)).Value = montoRecargosGlobal

                                totalRecargos = totalRecargos + montoRecargosGlobal

                            Case 2017

                                Sheet.Cells(String.Format("AB{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                Sheet.Cells(String.Format("AB{0}", rowCount)).Value = montoRecargosGlobal

                                totalRecargos = totalRecargos + montoRecargosGlobal

                            Case 2016

                                Sheet.Cells(String.Format("AC{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                Sheet.Cells(String.Format("AC{0}", rowCount)).Value = montoRecargosGlobal

                                totalRecargos = totalRecargos + montoRecargosGlobal

                        End Select


                    Next



                    Sheet.Cells(String.Format("L{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                    Sheet.Cells(String.Format("L{0}", rowCount)).Value = totalAlcantarillados

                    Sheet.Cells(String.Format("U{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                    Sheet.Cells(String.Format("U{0}", rowCount)).Value = totalRezagos

                    Sheet.Cells(String.Format("AD{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                    Sheet.Cells(String.Format("AD{0}", rowCount)).Value = totalRecargos

                    Sheet.Cells(String.Format("AE{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                    Sheet.Cells(String.Format("AE{0}", rowCount)).Value = acumuladorMontosOtrosConceptos

                    totalGeneral = acumuladorConsumo + totalAlcantarillados + totalRezagos + totalRecargos + acumuladorMontosOtrosConceptos
                    Sheet.Cells(String.Format("AF{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                    Sheet.Cells(String.Format("AF{0}", rowCount)).Value = totalGeneral

                    rowCount = rowCount + 1

                End While

                'datos.Read()





            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try


            Sheet.Cells("A:AZ").AutoFitColumns()

            Ep.SaveAs(New FileInfo(pathReporte))

            MessageBox.Show("Excel generado correctamente")

        End Using


    End Sub


    Public Sub GenerarPoliza15()


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
        Dim ruta As String = "\\EstadisticaNueva\\" + "Póliza15_.xlsx"
        Dim pathReporte As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ruta).Trim()


        ExcelPackage.LicenseContext = LicenseContext.NonCommercial




        Using Ep As New ExcelPackage()



            Dim Sheet = Ep.Workbook.Worksheets.Add("PÓLIZA 15")


            Dim rowCount As Integer = 1



            Sheet.Cells("A1:E1").Style.Font.Size = 13
            Sheet.Cells("A1:E1").Style.Font.Name = "Calibri"
            Sheet.Cells("A1:E3").Style.Font.Bold = True
            Sheet.Cells("A1:E1").Style.Font.Color.SetColor(Color.DarkBlue)
            Sheet.Cells("A1:E1").Style.HorizontalAlignment = ExcelHorizontalAlignment.Left
            Sheet.Cells("A1").RichText.Add("REPORTE POLIZA DIARIA")


            Sheet.Cells("A2:E3").Style.Font.Size = 12
            Sheet.Cells("A2:E3").Style.Font.Name = "Calibri"
            Sheet.Cells("A2:E3").Style.Font.Bold = True
            Sheet.Cells("A2:E3").Style.Font.Color.SetColor(Color.DarkBlue)
            Sheet.Cells("A2:E3").Style.HorizontalAlignment = ExcelHorizontalAlignment.Left
            Sheet.Cells("A2").RichText.Add($"FECHA: {UnixDateFormat(fecini.SelectedDate)} AL {UnixDateFormat(fecfinal.SelectedDate)}")


            Sheet.Cells("A3:E3").Style.Font.Size = 12
            Sheet.Cells("A3:E3").Style.Font.Name = "Calibri"
            Sheet.Cells("A3:E3").Style.Font.Bold = True
            Sheet.Cells("A3:E3").Style.Font.Color.SetColor(Color.DarkBlue)
            Sheet.Cells("A3:E3").Style.HorizontalAlignment = ExcelHorizontalAlignment.Left

            Dim nombreOrganismo As String = obtenerCampo($"select CNOMBRE from EMPRESA where CODEMP = 1", "CNOMBRE")
            Sheet.Cells("A3").RichText.Add($"ORGANISMO: {nombreOrganismo}")



            Try

                'ENCABEZADOS DEL DOCUMENTO
                rowCount = 5
                Sheet.Cells.Style.Font.Name = "Calibri"
                Sheet.Cells.Style.Font.Size = 12
                Sheet.Cells("A5:BA5").Style.Font.Bold = True
                Sheet.Cells("A5:BA5").Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
                Sheet.Cells("A5:BA5").Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray)


                Sheet.Cells("A5").RichText.Add("NO. CONTRATO")
                Sheet.Cells("B5").RichText.Add("USUARIO")
                Sheet.Cells("C5").RichText.Add("SERVICIO DE AGUA")

                Sheet.Cells("D5").RichText.Add("ALCANTARILLADO 2023")
                Sheet.Cells("E5").RichText.Add("ALCANTARILLADO 2022")
                Sheet.Cells("F5").RichText.Add("ALCANTARILLADO 2021")
                Sheet.Cells("G5").RichText.Add("ALCANTARILLADO 2020")
                Sheet.Cells("H5").RichText.Add("ALCANTARILLADO 2019")
                Sheet.Cells("I5").RichText.Add("ALCANTARILLADO 2018")
                Sheet.Cells("J5").RichText.Add("ALCANTARILLADO 2017")
                Sheet.Cells("K5").RichText.Add("ALCANTARILLADO 2016")


                Sheet.Cells("L5").RichText.Add("TARIFA")
                Sheet.Cells("M5").RichText.Add("% DESCUENTO 3ra EDAD")
                Sheet.Cells("N5").RichText.Add("% DESCUENTO PRONTO PAGO")
                Sheet.Cells("O5").RichText.Add("% OTROS DESCUENTOS")
                Sheet.Cells("P5").RichText.Add("REZAGO MESES DEL EJERCICIO")
                Sheet.Cells("Q5").RichText.Add("RECARGOS MESES EJERCICIO")
                Sheet.Cells("R5").RichText.Add("FOLIO CFDI / RECIBO")



                Sheet.Cells("S5").RichText.Add("REZAGO 2023")
                Sheet.Cells("T5").RichText.Add("REZAGO 2022")
                Sheet.Cells("U5").RichText.Add("REZAGO 2021")
                Sheet.Cells("V5").RichText.Add("REZAGO 2020")
                Sheet.Cells("W5").RichText.Add("REZAGO 2019")
                Sheet.Cells("X5").RichText.Add("REZAGO 2018")
                Sheet.Cells("Y5").RichText.Add("REZAGO 2017")
                Sheet.Cells("Z5").RichText.Add("REZAGO 2016")

                Sheet.Cells("AA5").RichText.Add("TOTAL REZAGOS")


                Sheet.Cells("AB5").RichText.Add("RECARGO 2023")
                Sheet.Cells("AC5").RichText.Add("RECARGO 2022")
                Sheet.Cells("AD5").RichText.Add("RECARGO 2021")
                Sheet.Cells("AE5").RichText.Add("RECARGO 2020")
                Sheet.Cells("AF5").RichText.Add("RECARGO 2019")
                Sheet.Cells("AG5").RichText.Add("RECARGO 2018")
                Sheet.Cells("AH5").RichText.Add("RECARGO 2017")
                Sheet.Cells("AI5").RichText.Add("RECARGO 2016")
                Sheet.Cells("AJ5").RichText.Add("TOTAL RECARGOS")


                Sheet.Cells("AK5").RichText.Add("IMPORTE DE DESC. 3ra EDAD, PENSIONADOS Y JUBILADOS")
                Sheet.Cells("AL5").RichText.Add("IMPORTE DESCUENTO PRONTO PAGO")
                Sheet.Cells("AM5").RichText.Add("IMPORTE OTROS DESCUENTOS AUTORIZADOS EN LEY DE INGRESOS")
                Sheet.Cells("AN5").RichText.Add("PERMISO DE DESCARGA AL ALCANTARILLADO")
                Sheet.Cells("AO5").RichText.Add("IMPORTE CONTRATO DE AGUA")
                Sheet.Cells("AP5").RichText.Add("IMPORTE REINSTALACIÓN")
                Sheet.Cells("AQ5").RichText.Add("IMPORTE FACTIBILIDADES")
                Sheet.Cells("AR5").RichText.Add("ALCANTARILLADO / SANEAMIENTO DEL PERIODO")
                Sheet.Cells("AS5").RichText.Add("CONSUMO AGUA  DEL PERIODO")

                Sheet.Cells("AT5").RichText.Add("IMPORTE OTROS CONCEPTOS")
                Sheet.Cells("AU5").RichText.Add("TOTAL GENERAL")
                Sheet.Cells("AV5").RichText.Add("FECHA")
                Sheet.Cells("AW5").RichText.Add("PÓLIZA No.")
                Sheet.Cells("AX5").RichText.Add("INGRESO CUENTA CONTABLE")
                Sheet.Cells("AY5").RichText.Add("DESCUENTO CUENTA CONTABLE")
                Sheet.Cells("AZ5").RichText.Add("INGRESO CUENTA PRESUPUESTA")
                Sheet.Cells("BA5").RichText.Add("DESCUENTO CUENTA PRESUPUESTAL")

                'Dim datos As IDataReader = ConsultaSql($"Select * from pago_mes where fecha between '{UnixDateFormat(fecini.SelectedDate)}' and '{UnixDateFormat(fecfinal.SelectedDate)}'").ExecuteReader
                Dim SQL = "Select * from pagos where fecha_act between '" & UnixDateFormat(fecini.SelectedDate) & "' and '" & UnixDateFormat(fecfinal.SelectedDate) & "' AND CANCELADO = 'A' order by cuenta, FECHA_ACT asc"

                Dim datos As IDataReader = ConsultaSql(SQL).ExecuteReader()

                'datos.Read()

                rowCount = 6

                While datos.Read()

                    Dim acumuladorConsumo As Decimal = 0.0
                    Dim acumuladorRezago As Decimal = 0.0
                    Dim acumuladorRecargos As Decimal = 0.0
                    Dim acumuladorAlcantarillado As Decimal = 0.0


                    Dim totalGeneral As Decimal = 0.0

                    Dim serieRecibo As String = datos("SERIE").ToString()
                    Dim folioRecibo As Integer = datos("RECIBO")
                    Dim tipoUsuario As Integer = datos("esusuario")

                    Dim importeConsumo As Decimal = 0.0
                    Dim importeRezago As Decimal = 0.0
                    Dim importeAlcantarillado As Decimal = 0.0
                    Dim importeSaneamiento As Decimal = 0.0
                    Dim importeRecargos As Decimal = 0.0

                    Dim contratoMedido As Boolean = False
                    Dim contratoFijo As Boolean = False



                    Try

                        Sheet.Cells(String.Format("A{0}", rowCount)).Value = datos("CUENTA").ToString()

                        Sheet.Cells(String.Format("B{0}", rowCount)).Value = datos("NOMBRE")



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



                    'Sheet.Cells[string.Format("D{0}", row)].Style.Numberformat.Format = "$#,##0.00";





                    'Hacer consulta a pagotros para obetener los conceptos del recibo
                    Dim datosPagotros As IDataReader = ObtenerConceptosPagotros(serieRecibo, folioRecibo)
                    Dim acumuladorMontosOtrosConceptos As Decimal = 0.0

                    While datosPagotros.Read()

                        If contratoFijo = True Then


                            If datosPagotros("NUMCONCEPTO") = "081DES" Or datosPagotros("NUMCONCEPTO") = "004RZG" Then

                                'Sheet.Cells(String.Format("C{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                                'Sheet.Cells(String.Format("C{0}", rowCount)).Value = datosPagotros("CONCEPTO").ToString()

                                'acumuladorConsumo = acumuladorConsumo + Decimal.Parse(datosPagotros("MONTO"))
                                Dim montoConsumo As Decimal = 0.0
                                Dim listConceptoConsumoMedido As List(Of ConceptosConsumo) = ObtenerConsumoMedidosPago_Mes(serieRecibo, folioRecibo, "CONSUMO", False)

                                Dim objConceptoConsumoMedido2 As New ConceptosConsumo
                                Dim periodoConsumoMedido As String

                                'For i = 1 To listConceptoConsumoMedido.Count

                                '    objConceptoConsumoMedido2 = listConceptoConsumoMedido.Item(i)

                                '    periodoConsumoMedido += $"{objConceptoConsumoMedido2.mes} {objConceptoConsumoMedido2.periodoConsumo} - "

                                'Next

                                For Each elemento In listConceptoConsumoMedido
                                    periodoConsumoMedido += $"{elemento.mes} {elemento.periodoConsumo} "

                                    acumuladorConsumo = acumuladorConsumo + elemento.montoPagado
                                    montoConsumo = elemento.montoPagado
                                Next


                                If montoConsumo > 0 Then

                                    Sheet.Cells(String.Format("C{0}", rowCount)).Value = $"CONSUMO DE AGUA PERIODO {periodoConsumoMedido} "

                                Else

                                    Sheet.Cells(String.Format("C{0}", rowCount)).Value = $" "

                                End If



                                periodoConsumoMedido = ""

                            End If

                        ElseIf contratoMedido = True Then

                            If datosPagotros("NUMCONCEPTO") = "081DES" Or datosPagotros("NUMCONCEPTO") = "004RZG" Then

                                'Sheet.Cells(String.Format("C{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"

                                Dim listConceptoConsumoMedido As List(Of ConceptosConsumo) = ObtenerConsumoMedidosPago_Mes(serieRecibo, folioRecibo, "CONSUMO", contratoMedido)

                                Dim objConceptoConsumoMedido2 As New ConceptosConsumo
                                Dim periodoConsumoMedido As String

                                'For i = 1 To listConceptoConsumoMedido.Count

                                '    objConceptoConsumoMedido2 = listConceptoConsumoMedido.Item(i)

                                '    periodoConsumoMedido += $"{objConceptoConsumoMedido2.mes} {objConceptoConsumoMedido2.periodoConsumo} - "

                                'Next

                                For Each elemento In listConceptoConsumoMedido
                                    periodoConsumoMedido += $"{elemento.mes} {elemento.periodoConsumo} "

                                    acumuladorConsumo = acumuladorConsumo + elemento.montoPagado
                                Next

                                Sheet.Cells(String.Format("C{0}", rowCount)).Value = $"CONSUMO DE AGUA PERIODO {periodoConsumoMedido} "

                                periodoConsumoMedido = ""
                            End If

                            Sheet.Cells(String.Format("AS{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                            Sheet.Cells(String.Format("AS{0}", rowCount)).Value = acumuladorConsumo

                        End If




                        If datosPagotros("NUMCONCEPTO") = "002DRE" Then

                            'Dim periodoAlcantarillado As Integer = 0
                            Dim montoAlcantarillado As Decimal = 0.0

                            'Dim datosPago_Alcant As IDataReader = ObtenerConceptosPago_Mes(serieRecibo, folioRecibo, "ALCANTARILLADO")
                            'Dim concatenarConcepto As String

                            Dim datosPago_Alcant As IDataReader = ObtenerMontoPeriodoPago_Mes(serieRecibo, folioRecibo, "ALCANTARILLADO")
                            'Dim concatenarConcepto As String

                            Sheet.Cells(String.Format("D{0}:K{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"

                            While datosPago_Alcant.Read()

                                Dim periodoAlcantarillado As Integer = Integer.Parse(datosPago_Alcant("ano"))
                                montoAlcantarillado = datosPago_Alcant("montoPagado")
                                'concatenarConcepto += " " & datosPago_Alcant("MES").ToString() & " " & datosPago_Alcant("ANO").ToString() & ", "
                                Select Case periodoAlcantarillado


                                    Case 2023

                                        Sheet.Cells(String.Format("D{0}", rowCount)).Value = montoAlcantarillado

                                        acumuladorAlcantarillado = acumuladorAlcantarillado + montoAlcantarillado
                                    Case 2022

                                        Sheet.Cells(String.Format("E{0}", rowCount)).Value = montoAlcantarillado

                                        acumuladorAlcantarillado = acumuladorAlcantarillado + montoAlcantarillado
                                    Case 2021

                                        Sheet.Cells(String.Format("F{0}", rowCount)).Value = montoAlcantarillado

                                        acumuladorAlcantarillado = acumuladorAlcantarillado + montoAlcantarillado
                                    Case 2020

                                        Sheet.Cells(String.Format("G{0}", rowCount)).Value = montoAlcantarillado

                                        acumuladorAlcantarillado = acumuladorAlcantarillado + montoAlcantarillado
                                    Case 2019

                                        Sheet.Cells(String.Format("H{0}", rowCount)).Value = montoAlcantarillado

                                        acumuladorAlcantarillado = acumuladorAlcantarillado + montoAlcantarillado
                                    Case 2018

                                        Sheet.Cells(String.Format("I{0}", rowCount)).Value = montoAlcantarillado

                                        acumuladorAlcantarillado = acumuladorAlcantarillado + montoAlcantarillado

                                    Case 2017

                                        Sheet.Cells(String.Format("J{0}", rowCount)).Value = montoAlcantarillado

                                        acumuladorAlcantarillado = acumuladorAlcantarillado + montoAlcantarillado
                                    Case 2016

                                        Sheet.Cells(String.Format("K{0}", rowCount)).Value = montoAlcantarillado

                                        acumuladorAlcantarillado = acumuladorAlcantarillado + montoAlcantarillado

                                End Select

                            End While

                            'Sheet.Cells(String.Format("D{0}", rowCount)).Value = datosPagotros("CONCEPTO").ToString() & concatenarConcepto

                            'concatenarConcepto = ""
                            Sheet.Cells(String.Format("AR{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                            Sheet.Cells(String.Format("AR{0}", rowCount)).Value = acumuladorAlcantarillado

                        End If





                        If datosPagotros("NUMCONCEPTO") = "004RZG" Then

                            Dim periodoRezago As Integer = 0
                            Dim montoRezago As Decimal = 0.0
                            Dim contadorPeriodos As Integer = 0

                            'Dim datosPago_Alcant As IDataReader = ObtenerConceptosPago_Mes(serieRecibo, folioRecibo, "ALCANTARILLADO")
                            'Dim concatenarConcepto As String

                            If datosPagotros("CUENTA") = 4758 Then
                                MessageBox.Show("CUENTA 4758")
                            End If

                            Dim listConceptosRezago As List(Of ConceptosRezago) = ObtenerMontoPeriodoRezagoPago_Mes(serieRecibo, folioRecibo, "CONSUMO", contratoMedido)

                            'Dim objConceptosConsumo2 As New ConceptosConsumo

                            Sheet.Cells(String.Format("S{0}:AJ{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"

                            'For i = 1 To objConceptosConsumo.Listadeconceptos.Count

                            '    objConceptosConsumo2 = objConceptosConsumo.Listadeconceptos.Item(i)

                            'For Each elemento In listConceptosRezago

                            '    'periodoConsumoMedido += $"{elemento.mes} {elemento.periodoConsumo} "

                            'Next


                            Dim montosRezago = From rezago In listConceptosRezago
                                               Group By PerRezago = rezago.periodoConsumo
                                                    Into RezagosenPeriodo = Group, MontoPagado = Sum(rezago.montoPagado)


                            For Each result In montosRezago
                                'Debug.WriteLine($"{result.PeriodoLecturas} {result.MontoPagado}")

                                periodoRezago = result.PerRezago
                                montoRezago = result.MontoPagado

                                Select Case periodoRezago


                                    Case 2023

                                        Sheet.Cells(String.Format("S{0}", rowCount)).Value = montoRezago

                                        acumuladorRezago = acumuladorRezago + montoRezago
                                    Case 2022

                                        Sheet.Cells(String.Format("T{0}", rowCount)).Value = montoRezago

                                        acumuladorRezago = acumuladorRezago + montoRezago
                                    Case 2021

                                        Sheet.Cells(String.Format("U{0}", rowCount)).Value = montoRezago

                                        acumuladorRezago = acumuladorRezago + montoRezago
                                    Case 2020

                                        Sheet.Cells(String.Format("V{0}", rowCount)).Value = montoRezago

                                        acumuladorRezago = acumuladorRezago + montoRezago
                                    Case 2019

                                        Sheet.Cells(String.Format("W{0}", rowCount)).Value = montoRezago

                                        acumuladorRezago = acumuladorRezago + montoRezago
                                    Case 2018

                                        Sheet.Cells(String.Format("X{0}", rowCount)).Value = montoRezago

                                        acumuladorRezago = acumuladorRezago + montoRezago

                                    Case 2017

                                        Sheet.Cells(String.Format("Y{0}", rowCount)).Value = montoRezago

                                        acumuladorRezago = acumuladorRezago + montoRezago
                                    Case 2016

                                        Sheet.Cells(String.Format("Z{0}", rowCount)).Value = montoRezago

                                        acumuladorRezago = acumuladorRezago + montoRezago

                                End Select

                                contadorPeriodos = listConceptosRezago.Count

                            Next

                            Sheet.Cells(String.Format("AA{0}", rowCount)).Value = acumuladorRezago

                            Sheet.Cells(String.Format("P{0}", rowCount)).Value = contadorPeriodos
                            'Dim periodoRezago As Integer = Integer.Parse(objConceptosConsumo2.periodoConsumo)
                            ''concatenarConcepto += " " & datosPago_Alcant("MES").ToString() & " " & datosPago_Alcant("ANO").ToString() & ", "

                        End If



                        If datosPagotros("NUMCONCEPTO") = "003REC" Then

                            Dim periodoRecargos As Integer = 0
                            Dim montoRecargos As Decimal = 0.0
                            Dim contadorPeriodosRecargos As Integer = 0

                            'Dim datosPago_Alcant As IDataReader = ObtenerConceptosPago_Mes(serieRecibo, folioRecibo, "ALCANTARILLADO")
                            'Dim concatenarConcepto As String

                            Dim datosPago_Recargo As IDataReader = ObtenerMontoPeriodoPago_Mes(serieRecibo, folioRecibo, "RECARGO")
                            'Dim concatenarConcepto As String

                            'Sheet.Cells(String.Format("D{0}:I{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"

                            While datosPago_Recargo.Read()

                                Dim periodoRecargo As Integer = Integer.Parse(datosPago_Recargo("ano"))
                                Dim montoPagado As Decimal = datosPago_Recargo("montoPagado")
                                Dim numPeriodos As Integer = datosPago_Recargo("NumPeriodos")
                                'concatenarConcepto += " " & datosPago_Alcant("MES").ToString() & " " & datosPago_Alcant("ANO").ToString() & ", "

                                Select Case periodoRecargo


                                    Case 2023

                                        Sheet.Cells(String.Format("AB{0}", rowCount)).Value = montoPagado

                                        acumuladorRecargos = acumuladorRecargos + montoPagado
                                    Case 2022

                                        Sheet.Cells(String.Format("AC{0}", rowCount)).Value = montoPagado

                                        acumuladorRecargos = acumuladorRecargos + montoPagado
                                    Case 2021

                                        Sheet.Cells(String.Format("AD{0}", rowCount)).Value = montoPagado

                                        acumuladorRecargos = acumuladorRecargos + montoPagado
                                    Case 2020

                                        Sheet.Cells(String.Format("AE{0}", rowCount)).Value = montoPagado

                                        acumuladorRecargos = acumuladorRecargos + montoPagado
                                    Case 2019

                                        Sheet.Cells(String.Format("AF{0}", rowCount)).Value = montoPagado

                                        acumuladorRecargos = acumuladorRecargos + montoPagado
                                    Case 2018

                                        Sheet.Cells(String.Format("AG{0}", rowCount)).Value = montoPagado

                                        acumuladorRecargos = acumuladorRecargos + montoPagado

                                    Case 2017

                                        Sheet.Cells(String.Format("AH{0}", rowCount)).Value = montoPagado

                                        acumuladorRecargos = acumuladorRecargos + montoPagado
                                    Case 2016

                                        Sheet.Cells(String.Format("AI{0}", rowCount)).Value = montoPagado

                                        acumuladorRecargos = acumuladorRecargos + montoPagado

                                End Select


                                contadorPeriodosRecargos = contadorPeriodosRecargos + numPeriodos
                            End While

                            Sheet.Cells(String.Format("AJ{0}", rowCount)).Value = acumuladorRecargos

                            Sheet.Cells(String.Format("Q{0}", rowCount)).Value = contadorPeriodosRecargos
                            'Sheet.Cells(String.Format("D{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                            'Sheet.Cells(String.Format("D{0}", rowCount)).Value = datosPagotros("CONCEPTO").ToString() & concatenarConcepto

                            'concatenarConcepto = ""
                        End If

                        If datosPagotros("NUMCONCEPTO") <> "081DES" And datosPagotros("NUMCONCEPTO") <> "004RZG" And datosPagotros("NUMCONCEPTO") <> "002DRE" And datosPagotros("NUMCONCEPTO") <> "003REC" Then

                            acumuladorMontosOtrosConceptos = acumuladorMontosOtrosConceptos + Decimal.Parse(datosPagotros("MONTO"))

                        End If

                    End While

                    Dim descripcionTarifa As String = ""

                    If tipoUsuario = 1 Then

                        descripcionTarifa = obtenerCampo($"select Descripcion_cuota from cuotas where id_tarifa = {datos("TARIFA")}", "Descripcion_cuota")

                    Else

                        descripcionTarifa = ""

                    End If


                    Sheet.Cells(String.Format("L{0}", rowCount)).Value = descripcionTarifa
                    'Sheet.Cells("F5").RichText.Add("% DESCUENTO 3ra EDAD")
                    'Sheet.Cells("G5").RichText.Add("% DESCUENTO PRONTO PAGO")
                    'Sheet.Cells("H5").RichText.Add("% OTROS DESCUENTOS")
                    'Sheet.Cells("I5").RichText.Add("REZAGO MESES DEL EJERCICIO")
                    'Sheet.Cells("J5").RichText.Add("RECARGOS MESES EJERCICIO")
                    'Sheet.Cells("K5").RichText.Add("FOLIO CFDI / RECIBO")

                    Sheet.Cells(String.Format("R{0}", rowCount)).Value = serieRecibo & " " & folioRecibo


                    Sheet.Cells(String.Format("AT{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                    Sheet.Cells(String.Format("AT{0}", rowCount)).Value = acumuladorMontosOtrosConceptos

                    totalGeneral = acumuladorConsumo + acumuladorRezago + acumuladorRecargos + acumuladorAlcantarillado + acumuladorMontosOtrosConceptos

                    Sheet.Cells(String.Format("AU{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                    Sheet.Cells(String.Format("AU{0}", rowCount)).Value = totalGeneral


                    'Dim fechaPago As DateTime =
                    Dim formato As String = ""
                    formato = Format(CDate(datos("FECHA_ACT")), "dd/MM/yyyy")
                    Sheet.Cells(String.Format("AV{0}", rowCount)).Style.Numberformat.Format = DateTimeFormatInfo.CurrentInfo.ShortDatePattern
                    Sheet.Cells(String.Format("AV{0}", rowCount)).Value = formato


                    'While datosPagotros.Read()


                    'If datosPagotros("NUMCONCEPTO") = "004RZG" Then

                    '        'Dim datosPago_Alcant As IDataReader = ObtenerConceptosPago_Mes(serieRecibo, folioRecibo, "ALCANTARILLADO")
                    '        'Dim concatenarConcepto As String

                    '        Dim objConceptosConsumo As ConceptosConsumo = ObtenerMontoPeriodoRezagoPago_Mes(serieRecibo, folioRecibo, "CONSUMO", contratoMedido)

                    '        Dim objConceptosConsumo2 As New ConceptosConsumo

                    '        Sheet.Cells(String.Format("Q{0}:V{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"

                    '        For i = 1 To objConceptosConsumo.Listadeconceptos.Count

                    '            objConceptosConsumo2 = objConceptosConsumo.Listadeconceptos.Item(i)

                    '            If objConceptosConsumo2.concepto = "REZAGO" Then

                    '                'Dim periodoRezago As Integer = Integer.Parse(objConceptosConsumo2.periodoConsumo)
                    '                ''concatenarConcepto += " " & datosPago_Alcant("MES").ToString() & " " & datosPago_Alcant("ANO").ToString() & ", "
                    '                'Select Case periodoRezago


                    '                '    Case 2023

                    '                '        Sheet.Cells(String.Format("Q{0}", rowCount)).Value = Decimal.Parse(datosPago_Alcant("montoPagado"))
                    '                '    Case 2022

                    '                '        Sheet.Cells(String.Format("R{0}", rowCount)).Value = Decimal.Parse(datosPago_Alcant("montoPagado"))
                    '                '    Case 2021

                    '                '        Sheet.Cells(String.Format("S{0}", rowCount)).Value = Decimal.Parse(datosPago_Alcant("montoPagado"))
                    '                '    Case 2020

                    '                '        Sheet.Cells(String.Format("T{0}", rowCount)).Value = Decimal.Parse(datosPago_Alcant("montoPagado"))
                    '                '    Case 2019

                    '                '        Sheet.Cells(String.Format("U{0}", rowCount)).Value = Decimal.Parse(datosPago_Alcant("montoPagado"))
                    '                '    Case 2018

                    '                '        Sheet.Cells(String.Format("V{0}", rowCount)).Value = Decimal.Parse(datosPago_Alcant("montoPagado"))


                    '                'End Select


                    '            End If


                    '        Next
                    '        'Dim concatenarConcepto As String


                    '        'Case 2023

                    '        'Sheet.Cells(String.Format("Q{0}", rowCount)).Value = Decimal.Parse(datosPago_Alcant("montoPagado"))
                    '        'Case 2022

                    '        'Sheet.Cells(String.Format("R{0}", rowCount)).Value = Decimal.Parse(datosPago_Alcant("montoPagado"))
                    '        'Case 2021

                    '        'Sheet.Cells(String.Format("S{0}", rowCount)).Value = Decimal.Parse(datosPago_Alcant("montoPagado"))
                    '        'Case 2020

                    '        'Sheet.Cells(String.Format("T{0}", rowCount)).Value = Decimal.Parse(datosPago_Alcant("montoPagado"))
                    '        'Case 2019

                    '        'Sheet.Cells(String.Format("U{0}", rowCount)).Value = Decimal.Parse(datosPago_Alcant("montoPagado"))
                    '        'Case 2018

                    '        'Sheet.Cells(String.Format("V{0}", rowCount)).Value = Decimal.Parse(datosPago_Alcant("montoPagado"))

                    '        ''While datosPago_Alcant.Read()


                    '        'End While
                    '        'Sheet.Cells(String.Format("D{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                    '        'Sheet.Cells(String.Format("D{0}", rowCount)).Value = datosPagotros("CONCEPTO").ToString() & concatenarConcepto

                    '        'concatenarConcepto = ""
                    '    End If

                    ''End While




                    rowCount = rowCount + 1

                End While

            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try


            Sheet.Cells("A:BA").AutoFitColumns()

            Ep.SaveAs(New FileInfo(pathReporte))

            MessageBox.Show("Excel generado correctamente")

        End Using


    End Sub


    Public Sub GenerarPoliza16()


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
        Dim ruta As String = "\\EstadisticaNueva\\" + "Póliza16_.xlsx"
        Dim pathReporte As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ruta).Trim()


        ExcelPackage.LicenseContext = LicenseContext.NonCommercial




        Using Ep As New ExcelPackage()


            Dim Sheet = Ep.Workbook.Worksheets.Add("PÓLIZA 16")


            Dim rowCount As Integer = 1



            Sheet.Cells("A1:E1").Style.Font.Size = 13
            Sheet.Cells("A1:E1").Style.Font.Name = "Calibri"
            Sheet.Cells("A1:E3").Style.Font.Bold = True
            Sheet.Cells("A1:E1").Style.Font.Color.SetColor(Color.DarkBlue)
            Sheet.Cells("A1:E1").Style.HorizontalAlignment = ExcelHorizontalAlignment.Left
            Sheet.Cells("A1").RichText.Add("PÓLIZA DIARIA OTROS DERECHOS")


            Sheet.Cells("A2:E3").Style.Font.Size = 12
            Sheet.Cells("A2:E3").Style.Font.Name = "Calibri"
            Sheet.Cells("A2:E3").Style.Font.Bold = True
            Sheet.Cells("A2:E3").Style.Font.Color.SetColor(Color.DarkBlue)
            Sheet.Cells("A2:E3").Style.HorizontalAlignment = ExcelHorizontalAlignment.Left
            Sheet.Cells("A2").RichText.Add($"FECHA: {UnixDateFormat(fecini.SelectedDate)} AL {UnixDateFormat(fecfinal.SelectedDate)}")


            Sheet.Cells("A3:E3").Style.Font.Size = 12
            Sheet.Cells("A3:E3").Style.Font.Name = "Calibri"
            Sheet.Cells("A3:E3").Style.Font.Bold = True
            Sheet.Cells("A3:E3").Style.Font.Color.SetColor(Color.DarkBlue)
            Sheet.Cells("A3:E3").Style.HorizontalAlignment = ExcelHorizontalAlignment.Left

            Dim nombreOrganismo As String = obtenerCampo($"select CNOMBRE from EMPRESA where CODEMP = 1", "CNOMBRE")
            Sheet.Cells("A3").RichText.Add($"ORGANISMO: {nombreOrganismo}")



            Try

                'ENCABEZADOS DEL DOCUMENTO
                rowCount = 5
                Sheet.Cells.Style.Font.Name = "Calibri"
                Sheet.Cells.Style.Font.Size = 10
                Sheet.Cells("A5:N5").Style.Font.Bold = True
                Sheet.Cells("A5:N5").Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
                Sheet.Cells("A5:N5").Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray)


                Sheet.Cells("A5").RichText.Add("NO. CONTRATO / CUENTA")
                Sheet.Cells("B5").RichText.Add("FOLIO CFDI / RECIBO")
                Sheet.Cells("C5").RichText.Add("USUARIO")

                Sheet.Cells("D5").RichText.Add("OPERACION (TIPO DE SERVICIO)")
                Sheet.Cells("E5").RichText.Add("IMPORTE")
                Sheet.Cells("F5").RichText.Add("CUENTA CONTABLE INGRESO")
                Sheet.Cells("G5").RichText.Add("CUENTA PRESUPUESTAL (RECAUDADO)")
                Sheet.Cells("H5").RichText.Add("TOTAL GENERAL")
                Sheet.Cells("I5").RichText.Add("PÓLIZA CONTABLE NO.")
                Sheet.Cells("J5").RichText.Add("FECHA")
                Sheet.Cells("K5").RichText.Add("INGRESO CUENTA CONTABLE")


                Sheet.Cells("L5").RichText.Add("PÓLIZA NO. PRESUPUESTAL")
                Sheet.Cells("M5").RichText.Add("FECHA")
                Sheet.Cells("N5").RichText.Add("INGRESO CUENTA PRESUPUESTAL")


                'Sheet.Cells("O5").RichText.Add("RECARGO 2020")
                'Sheet.Cells("P5").RichText.Add("RECARGO 2019")
                'Sheet.Cells("P5").RichText.Add("RECARGO 2018")
                'Sheet.Cells("Q5").RichText.Add("TOTAL")



                'Sheet.Cells("R5").RichText.Add("OTROS DERECHOS")
                'Sheet.Cells("S5").RichText.Add("TOTAL GENERAL")

                'Dim datos As IDataReader = ConsultaSql($"Select * from pago_mes where fecha between '{UnixDateFormat(fecini.SelectedDate)}' and '{UnixDateFormat(fecfinal.SelectedDate)}'").ExecuteReader
                Dim SQL = "Select * from ENCFAC where FECHATIMBRADO between '" & UnixDateFormat(fecini.SelectedDate) & "' and '" & UnixDateFormat(fecfinal.SelectedDate) & "' and ESTADO = 'A' order by numero asc"

                Dim datos As IDataReader = ConsultaSql(SQL).ExecuteReader()

                'datos.Read()

                rowCount = 6


                While datos.Read()

                    Dim acumuladorConsumo As Decimal = 0.0
                    Dim acumuladorRezago As Decimal = 0.0
                    Dim acumuladorRecargos As Decimal = 0.0



                    Dim serieRecibo As String = datos("SERIERECIBO").ToString()
                    Dim folioRecibo As Integer = datos("RECIBO")

                    Dim serieFactura As String = datos("SERIE").ToString()
                    Dim folioFactura As Integer = datos("NUMERO")

                    Dim cuenta As Integer = obtenerCampo($"select cuenta from pagos where serie='{serieRecibo}' and recibo = {folioRecibo}", "cuenta")
                    Dim tipoUsuario As Integer = obtenerCampo($"select esusuario from pagos where serie='{serieRecibo}' and recibo = {folioRecibo}", "esusuario")
                    Dim nombre
                    Dim usuario As String = datos("NOMBRE")
                    Dim tipoServicio As String = ""
                    'Dim fecha As String = datos("FECHATIMBRADO")

                    If tipoUsuario = 1 Then
                        tipoServicio = obtenerCampo($"select TIPOUSU from VUSUARIO where CUENTA = {cuenta}", "TIPOUSU")
                    End If

                    Dim importe As Decimal = Decimal.Parse(datos("TOTAL"))
                    Dim totalGeneral As Decimal = Decimal.Parse(datos("TOTAL"))


                    Sheet.Cells(String.Format("A{0}", rowCount)).Value = $"{cuenta.ToString()}"
                    Sheet.Cells(String.Format("B{0}", rowCount)).Value = $"{serieFactura + folioFactura.ToString()}"
                    Sheet.Cells(String.Format("C{0}", rowCount)).Value = $"{usuario.ToString()}"


                    Sheet.Cells(String.Format("D{0}", rowCount)).Value = $"{tipoServicio}"

                    Sheet.Cells(String.Format("E{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"
                    Sheet.Cells(String.Format("H{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"

                    Sheet.Cells(String.Format("E{0}", rowCount)).Value = importe
                    Sheet.Cells(String.Format("H{0}", rowCount)).Value = totalGeneral

                    Dim formato As String = ""
                    formato = Format(CDate(datos("FECHATIMBRADO")), "dd/MM/yyyy")
                    Sheet.Cells(String.Format("J{0}", rowCount)).Style.Numberformat.Format = DateTimeFormatInfo.CurrentInfo.ShortDatePattern
                    Sheet.Cells(String.Format("J{0}", rowCount)).Value = $"{formato}"

                    rowCount = rowCount + 1

                End While


            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try


            Sheet.Cells("A:N").AutoFitColumns()

            Ep.SaveAs(New FileInfo(pathReporte))

            MessageBox.Show("Excel generado correctamente")

        End Using


    End Sub

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


Public Class ConceptosConsumo

    'Public Listadeconceptos As New Collection

    Public concepto As String = ""
    Public mes As String = ""
    Public periodoConsumo As Integer = 0
    Public montoPagado As Decimal = 0.0


End Class

Public Class ConceptosRezago

    'Public Listadeconceptos As New Collection

    Public concepto As String = ""
    Public mes As String = ""
    Public periodoConsumo As Integer = 0
    Public montoPagado As Decimal = 0.0


End Class

Public Class ConceptosAlcantarillado

    Public concepto As String = ""
    Public mes As String = ""
    Public periodoAlcantarillado As Integer = 0
    Public montoPagado As Decimal = 0.0

End Class

Public Class ConceptosRecargos

    Public concepto As String = ""
    Public mes As String = ""
    Public periodoRecargo As Integer = 0
    Public montoPagado As Decimal = 0.0

End Class