Public Class Clspagoenlinea


    Public Sub creaServicio(Nombredelservicio As String, nombredelabase As String)
        Ejecucion("create schema " & Nombredelservicio)
        Ejecucion("create table " & Nombredelservicio & ".datos ( fecha DATETIME ) ")
        Ejecucion("insert into " & Nombredelservicio & ".datos (fecha) values ('" & Now.Year & "/" & Now.Month & "/" & Now.Day & "')")
        Ejecucion("create table " & Nombredelservicio & ".usuario like " & nombredelabase & ".usuario")
        Ejecucion("insert into " & Nombredelservicio & ".usuario select * from  " & nombredelabase & ".usuario")
        Ejecucion("create table " & Nombredelservicio & ".otrosconceptos like " & nombredelabase & ".otrosconceptos")
        Ejecucion("insert into " & Nombredelservicio & ".otrosconceptos select * from  " & nombredelabase & ".otrosconceptos where pagado=0 and estado<>'Cancel'")

        Ejecucion("create table " & Nombredelservicio & ".Vbancomer select * from  " & nombredelabase & ".vbancomer")

        Ejecucion("create table " & Nombredelservicio & ".lecturas like " & nombredelabase & ".lecturas")
        Ejecucion("CREATE TABLE " & Nombredelservicio & ".conceptosfactura (  `idConceptosfactura` INT NOT NULL AUTO_INCREMENT,  `unidadsat` VARCHAR(15) NULL DEFAULT 'E48',  `clavesat` VARCHAR(20) NULL DEFAULT '83101501',  `cantidad` DECIMAL(15,2) NOT NULL DEFAULT 1,  `claveconcepto` VARCHAR(45) NULL,  `CONCEPTO` VARCHAR(250) NULL,  `preciounitario` DECIMAL(15,2) NOT NULL DEFAULT 0,  `Base` DECIMAL(15,2) NOT NULL DEFAULT 0,  `llevaiva` INT NOT NULL DEFAULT 0,  `iva` DECIMAL(15,2) NOT NULL DEFAULT 0,  `importe` DECIMAL(15,2) NOT NULL DEFAULT 0,  `cuenta` INT NOT NULL DEFAULT 0, PRIMARY KEY (`idConceptosfactura`), index(cuenta));")
    End Sub

    Public Sub pasalecturas(Nombredelservicio As String, nombredelabase As String, cuenta As Integer)
        Ejecucion("insert into " & Nombredelservicio & ".lecturas select * from  " & nombredelabase & ".lecturas where cuenta=" & cuenta & " and pagado=0")
    End Sub

    Public Sub paragenerarfactura(Nombredelservicio As String, nombredelabase As String, cuenta As Integer, Listadeconceptos As Collection)

        Dim cantidad As Decimal = 1

        For i = 1 To Listadeconceptos.Count 
            Dim elemento As Clsconcepto
            elemento = Listadeconceptos(i)

            Try
                Dim cadena As New StringBuilder
                cadena.Append("INSERT INTO " & Nombredelservicio & ".`conceptosfactura` (`unidadsat`,`clavesat`,`cantidad`,`claveconcepto`,`CONCEPTO`,`preciounitario`,`Base`,`llevaiva`,`iva`,`importe`,cuenta) VALUES ")
                cadena.Append("('" & elemento.unidadsat & "'")
                cadena.Append(",'" & elemento.clavesat & "'")
                cadena.Append("," & elemento.Cantidad & ",")
                cadena.Append("'" & elemento.Clave & "',")
                cadena.Append("'" & elemento.Concepto & "',")
                cadena.Append(elemento.Preciounitario & ",")
                If elemento.IVA > 0 Then
                    cadena.Append(elemento.importe & ",1," & elemento.IVA & ",")
                Else
                    cadena.Append("0,0,0,")
                End If
                cadena.Append(elemento.importe & ",")
                cadena.Append(cuenta & ")")

                Ejecucion(cadena.ToString)

            Catch ex As Exception

            End Try



        Next
    End Sub

    Public Sub pagarusuario(Nombredelservicio As String, nombredelabase As String, cuenta As Integer, folio As Integer, fecha As Date, CAJA As Integer, referencia As String, formapago As String)
        Ejecucion("update " & nombredelabase & ".lecturas, " & Nombredelservicio & ".lecturas set " & nombredelabase & ".lecturas.pagado=1 where  " & nombredelabase & ".lecturas.llave= " & Nombredelservicio & ".lecturas.llave and " & Nombredelservicio & ".lecturas.cuenta=" & cuenta)
        Ejecucion("update " & nombredelabase & ".usuario ," & Nombredelservicio & ".datos set " & nombredelabase & ".usuario.deudafec=" & Nombredelservicio & ".datos.fecha where cuenta=" + cuenta)
        Dim datos As IDataReader = ConsultaSql("select * from " & Nombredelservicio & ".vbancomer where cuenta=" & cuenta).ExecuteReader
        datos.Read()
        Dim subtotal As Decimal = Decimal.Parse(datos("importe")) - Decimal.Parse(datos("iva"))
        Dim iva As Decimal = datos("iva")
        Dim total As Decimal = datos("importe")
        Dim periodo As String = datos("periodo")
        Dim nombre As String = datos("nombre")
        Dim colonia As String = datos("Colonia")
        Dim comunidad As String = datos("comunidad")

        Dim datosusuario = ConsultaSql("select * from usuario, cuotas where usuario.tarifa=cuotas.id_tarifa and cuenta=" & cuenta).ExecuteReader
        datosusuario.Read()
        Dim ubicacion As String = String.Empty
        Try
            ubicacion = datosusuario("ubicacion")

        Catch ex As Exception

        End Try
        Dim tarifa As String = String.Empty
        Try
            tarifa = datosusuario("tarifa")
        Catch ex As Exception

        End Try

        Dim ESFIJO As Short = 0
        Try
            ESFIJO = 1 - datosusuario("cuotas.medido")
        Catch ex As Exception

        End Try

        Dim usuario As String = String.Empty
        Try
            usuario = Nameuser
        Catch ex As Exception

        End Try

        Dim fechad As Date = Now
        Try
            fechad = datosusuario("deudafec")
        Catch ex As Exception

        End Try


        'Dim existe As Integer = Integer.Parse(obtenerCampo("select count(recibo) as cuantos from pagos where cuenta=" + cuenta + " and fecha= '" & fecha.Year + "/" + fecha.Month + "/" + fecha.Day & "' and esusuario=1", "cuantos"))
        'If existe > 0 Then

        'Else

        Ejecucion("INSERT INTO pagos (FECHA_ACT, PERIODO, PAGOS, FECHA_DEUDA, IVA, TOTAL, NOMBRE, RECIBO, CANCELADO, CUENTA, COMUNIDAD, COLONIA, SERIE, USUARIO, CAJA, UBICACION, TARIFA, CCODPAGO, ESFIJO, FACTURADO, esusuario,observacion, Descuento,Descuentopesos) VALUES ('" & fecha.Year & "/" & fecha.Month & "/" & fecha.Day & "', '" & periodo & "', " & subtotal & ", '" & fechad.Year & "/" & fechad.Month & "/" & fechad.Day & "', '" & iva & "', '" & total & "', '" & nombre & "', '" & folio & "', 'A', '" & cuenta & "', '" & comunidad & "', '" & colonia & "', 'L', '" & usuario & "', '" & CAJA & "', '" & ubicacion & "', '" & tarifa & "', 'TD'," & ESFIJO & ",0,1,'PAGO EN LINEA ', 0,0 )")
            Ejecucion("insert into " & nombredelabase & ".pagotros (`Recibo`,`Cuenta`,`Serie`,`Usuario`,`Fecha`,`NumConcepto`,`Concepto`,`Monto`,`Caja`,`Cancelado`,`Ubicacion`,`Ccodpago`,`Referencia`,`clavemov`,`importe`,`cantidad`,`IVA`,`MontoIva`) select " & folio & "," & cuenta & ",'L','" & Nameuser & "','" & fecha.Year & "/" & fecha.Month & "/" & fecha.Day & "',claveconcepto, concepto,preciounitario," & CAJA & ",'A','" & ubicacion & "','" & formapago & "','" & referencia & "', 0,importe,cantidad,if(iva>0,1,0),iva from " & Nombredelservicio & ".conceptosfactura where cuenta=" & cuenta)

        'End If




    End Sub



End Class
