Imports System.Text

Public Class classcierre
    Public comunidad As String
    Public region As String
    Public fecini As Date
    Public fecvto As Date
    Public mes As Date

#Region "CREA PERIODO EN ESTADOS"
    Public Function crearcierreporregion() As Integer

        'Dim cDATOS As New Odbc.OdbcCommand
        'Try
        '    Dim Totlec As String = obtenerCampo("select aplicacion from  rutas where id_comunidad= '" & comunidad & "' and id_region = '" & region & "' ", "aplicacion")
        '    If Totlec = "N" Then


        '        If MessageBoxEx.Show("No hay lecturas aplicadas para esta región, ¿Deseas Continuar, aún así? ", " Advertencia!!!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
        '            Return 1
        '        End If

        '    End If
        'Catch ex As Exception
        '    MessageBoxEx.Show(ex.Message)
        '    MessageBoxEx.Show("Posible perdida de conexión")
        'End Try

        Try
            Try
                Ejecucion("update estados set ultimo=0 where ultimo=1  AND id_comunidad= '" & comunidad & "' and id_region='" & region & "'  ")

            Catch ex As Exception
                MessageBoxEx.Show(ex.Message())
                MessageBoxEx.Show("no puede grabar la bandera del último cierre, Posible perdidad de conexión")
            End Try

            'MessageBoxEx.Show("Es posible que el cierre tarde varios minutos, sea paciente")

            ' INSERCION
            Dim CADENASQL As New StringBuilder

            CADENASQL.Append(" insert into estados (")
            CADENASQL.Append("ID_COMUNIDAD,")
            CADENASQL.Append("CUENTA,")
            CADENASQL.Append("MES_PERIODO,")
            CADENASQL.Append("AN_PER,")
            CADENASQL.Append("ID_REGION,")
            CADENASQL.Append("ID_RUTA,")
            CADENASQL.Append("MZN,")
            CADENASQL.Append("LOTE,")
            CADENASQL.Append("COD_GIR,")
            CADENASQL.Append("TARIFA,")
            '  CADENASQL.Append("DEPT,")
            'CADENASQL.Append("COD_USU,")
            CADENASQL.Append("COD_SER,")
            CADENASQL.Append("COD_TOMA,")
            CADENASQL.Append("COD_HOR,")
            'CADENASQL.Append("DESC_DRENA,")
            'CADENASQL.Append("GEST_COBRA,")
            CADENASQL.Append("ALTO_CONS,")
            CADENASQL.Append("MEDIDOR,NOMBRE,")
            CADENASQL.Append("FEC_EMI,")
            CADENASQL.Append("fec_vto,ultimo ) SELECT ")

            ' COSULTA QUE GENERA LA INSERCION
            CADENASQL.Append("ID_COMUNIDAD,")
            CADENASQL.Append("CUENTA,")
            CADENASQL.Append("'" & Mid(UCase(MonthName(Month(mes))), 1, 3) & "',")
            CADENASQL.Append(Year(mes) & ",")
            CADENASQL.Append("REGION,")
            CADENASQL.Append("RUTA,")
            CADENASQL.Append("MANZANA,")
            CADENASQL.Append("LOTE,")
            CADENASQL.Append("COD_GIR,")
            CADENASQL.Append("TARIFA,")
            '   CADENASQL.Append("DEPT,")
            CADENASQL.Append("ID_TIPO_USUARIO,")
            'obtenerCampo ("SELECT MEDIDO FROM CUOTAS WHERE ID_TARIFA='" & TA
            ' CADENASQL.Append("MEDIDO,")
            CADENASQL.Append("ESTADO,")
            CADENASQL.Append("ID_FORMA_SERVICIO,")
            'CADENASQL.Append("DESC_DRENA,")
            'CADENASQL.Append("GEST_COBRA,")
            CADENASQL.Append("ALTOCONSUMIDOR,")
            CADENASQL.Append("NODEMEDIDOR")
            CADENASQL.Append(",NOMBRE,")

            CADENASQL.Append("'" & UnixDateFormat(fecini) & "','")
            CADENASQL.Append("" & UnixDateFormat(fecvto) & "',1   FROM USUARIO,ESTADOTOMA WHERE REGION='" & Me.region & "' AND ID_COMUNIDAD='" & Me.comunidad & "' AND USUARIO.ESTADO= ESTADOTOMA.CLAVE AND ESTADOTOMA.MOSTRAR=1 ")

            Ejecucion(CADENASQL.ToString())


            Return (0)
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message())
            MessageBoxEx.Show("El error anterior no me permitio" + Chr(13) + " crear los estados de cuenta para esta region")
            Return 1

        End Try

    End Function

#End Region

#Region "APLICA LAS LECTURAS DE MEDIDOS"
    Public Sub aplicalecturas()
        Try
            Dim DATOS As IDataReader
            Dim Consul As New Odbc.OdbcCommand
            Consul = ConsultaSql("SELECT l.lectura, l.lecturaant, l.lecturista, l.fec_lec, l.sit_pad, l.sit_hid, l.sit_med, l.accion, l.montoconsumo, l.mesespromedio, l.montoalcanta, l.montoiva, l.montosanea, l.baseiva, l.cuenta, l.comunidad, l.consumo, l.consumocobrado FROM ESTADOS,LECTURAS as l WHERE ESTADOS.MES_PERIODO = L.MES AND ESTADOS.AN_PER=L.AN_PER AND ESTADOS.ID_COMUNIDAD= L.COMUNIDAD AND ESTADOS.CUENTA=l.CUENTA AND ESTADOS.MES_PERIODO='" & UCase(MonthName(Month(mes), True)) & "' AND ESTADOS.AN_PER=" & Year(mes))
            Dim CADENASQL As New StringBuilder
            DATOS = Consul.ExecuteReader
            
            For I = 1 To DATOS.RecordsAffected
                DATOS.Read()
                Try
                    For E = 1 To CADENASQL.Length
                        CADENASQL.Remove(0, 1)
                    Next
                    CADENASQL.Append(" UPDATE estados set ")
                    CADENASQL.Append(" estados.LEC_ACT=" & DATOS("LECTURA"))
                    CADENASQL.Append(", estados.LEC_ANT=" & DATOS("LECTURAANT"))
                    CADENASQL.Append(", estados.NUM_LEC=" & DATOS("lecturista"))
                    CADENASQL.Append(", estados.FEC_LEC='" & UnixDateFormat(DATOS("FEC_LEC")) & "'")
                    CADENASQL.Append(", estados.CVE_PAD='" & DATOS("SIT_PAD") & "'")
                    CADENASQL.Append(", estados.CVE_HID='" & DATOS("SIT_HID") & "'")
                    CADENASQL.Append(", estados.CVE_MED='" & DATOS("SIT_MED") & "'")
                    CADENASQL.Append(", estados.ACCION='" & DATOS("ACCION") & "'")
                    CADENASQL.Append(", estados.CONSUMO=" & DATOS("montoCONSUMO"))

                    'CADENASQL.Append(", estados.NUM_PE_ACU=" & DATOS("MESESPROMEDIO"))
                    CADENASQL.Append(", estados.DRENAJE=" & DATOS("MONTOALCANTA"))
                    CADENASQL.Append(", estados.IVA=" & DATOS("MONTOIVA"))
                    CADENASQL.Append(", estados.SANEAMIENTO=" & DATOS("MONTOSANEA"))
                    CADENASQL.Append(", estados.baseconsumo=" & DATOS("baseiva"))
                    CADENASQL.Append(", estados.CON_M3=" & DATOS("consumo"))
                    CADENASQL.Append(", estados.CON_PROM=" & DATOS("consumocobrado"))
                    CADENASQL.Append(" WHERE ESTADOS.MES_PERIODO ='" & UCase(MonthName(Month(mes), True)) & "' AND ESTADOS.AN_PER=" & Year(mes) & " AND ESTADOS.CUENTA=" & DATOS("CUENTA") & " AND ESTADOS.ID_COMUNIDAD='" & DATOS("COMUNIDAD") & "'")

                    Ejecucion(CADENASQL.ToString())

                Catch ex As Exception
                    MessageBox.Show(ex.Message())
                End Try
            Next
            
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message())
            MessageBoxEx.Show("ESTE ERROR NO ME PERMITIO APLICAR LECTURAS")
            Exit Sub
        End Try
        Try
            Ejecucion("UPDATE LECTURAS SET STATUS='A' WHERE LECTURAS.MES ='" & UCase(MonthName(Month(mes), True)) & "' AND LECTURAS.AN_PER =" & Year(mes) & " AND COMUNIDAD='" & comunidad & "' AND REGION='" & region & "' ")

        Catch ex As Exception
            MessageBoxEx.Show(ex.Message())
            MessageBoxEx.Show("ESTE ERROR NO ME PERMITIO CAMBIAR EL ESTADO DE LECTURAS A APLICADAS")
            Exit Sub
        End Try
    End Sub
#End Region

#Region "calcula a los fijos"
    Public Sub cargafijos()
        'Try
        '    Dim cadenasql As New StringBuilder
        '    cadenasql.Append("update estados, cuotas set ESTADOS.ACCION='FIJO', estados.con_m3=cuotas.mCubEquiv, estados.consumo= cuotas.consumen ")
        '    cadenasql.Append(", saneamiento= SaneaFijos(cuotas.consumen,cuenta, id_comunidad), estados.drenaje=  AlcantaFijos(cuotas.consumen,cuenta, id_comunidad)  where estados.tarifa=cuotas.id_tarifa and cuotas.medido=0  ")
        '    cadenasql.Append(" and MES_PERIODO='" & UCase(MonthName(Month(mes), True)) & "' AND AN_PER=" & Year(mes))

        '    Ejecucion(cadenasql.ToString)

        '    ' actualiza la base del iva que se va estar cobrando

        '    cadenasql.Remove(0, cadenasql.Length)
        '    cadenasql.Append("update estados, cuotas set ESTADOS.baseconsumo=baseFijos(estados.consumo, estados.saneamiento, estados.drenaje, estados.tarifa)")
        '    cadenasql.Append("where estados.tarifa=cuotas.id_tarifa and cuotas.medido=0  ")
        '    cadenasql.Append(" and MES_PERIODO='" & UCase(MonthName(Month(mes), True)) & "' AND AN_PER=" & Year(mes))

        '    Ejecucion(cadenasql.ToString)


        'Catch ex As Exception
        '    MessageBoxEx.Show(ex.Message)
        '    MessageBoxEx.Show("El error anterior no me permitio actualizar los usuarios de cuota fija")
        'End Try
        Try
            Ejecucion("CALL CARGAFIJO('" & comunidad & "','" & region & "')")
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message())
        End Try
    End Sub
#End Region

#Region "OTROCIERRE"
    Public Sub CIERRA(ByVal PB As DevComponents.DotNetBar.Controls.ProgressBarX)
        Dim XC As New Odbc.OdbcCommand
        XC = ConsultaSql(" SELECT CUENTA FROM ESTADOS WHERE ID_COMUNIDAD='" & comunidad & "' AND id_REGION='" & region & "' AND ULTIMO=1")
        Dim XR As IDataReader
        XR = XC.ExecuteReader
        Dim i As Integer
        Application.DoEvents()
        'frmelaboracierre.Text = "Elaborando al cierre..."
        frmelaboracierre.ProgressBarcierre1.Visible = True
        frmelaboracierre.ProgressBarcierre1.Maximum = XR.RecordsAffected
        PB.Maximum = XR.RecordsAffected
        For i = 1 To XR.RecordsAffected
            XR.Read()

            PB.Value = i
            PB.Text = " Cerrando ... " & Math.Round((PB.Value / PB.Maximum) * 100, 0) & "% "
            'frmelaboracierre.ProgressBarcierre1.Text = Math.Round((i / XR.RecordsAffected) * 100, 0) & "%"
            Dim CUENTA As Integer

            CUENTA = XR("CUENTA")
            Try
                Ejecucion("CALL cierra('" & comunidad & "'," & CUENTA & ",'" & UCase(MonthName(Month(mes), True)) & "'," & Year(mes) & ")")
            Catch ex As Exception
                ' MessageBoxEx.Show(ex.Message)
            End Try
        Next
        Try
            Ejecucion("UPDATE ESTADOS SET PAGADO=1 WHERE SALDO=0 AND ID_COMUNIDAD= '" & comunidad & "' AND ID_REGION='" & region & "' AND ULTIMO=1")
            Ejecucion("update otrosconceptos set pagado =1 where resta<=0 and pagado=0")
            '  frmelaboracierre.Lblespere.Text = "Cacelando convenios de la región"
            PB.Text = " Cancelando convenios que no pagaron anticipo "
            Ejecucion("update convenios,usuario set usuario.convenio=0 , convenios.status='Cancelado' where convenios.status='Pendiente' and convenios.cuenta= usuario.cuenta and convenios.id_comunidad = usuario.id_comunidad and usuario.id_comunidad='" & comunidad & "' and usuario.region='" & region & "'")
            ' Ejecucion("UPDATE RUTAS SET TOMALEC='N', CAPTURA='N', CALCULO='N',APLICACION='N' WHERE ID_COMUNIDAD='" & comunidad & "' AND ID_REGION='" & region & "'")
            'frmelaboracierre.ProgressBarcierre1.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

#End Region

#Region "GRABA EL DATO DE CIERRE"
    Public Sub GRABADATO()

        Dim xc As New Odbc.OdbcCommand
        Dim xr As IDataReader
        Dim consumo As Double = 0
        Dim alcanta As Double = 0
        Dim sanea As Double = 0
        Dim iva As Double = 0
        Dim cuantos As Long = 0
        Dim otros As Double = 0
        Dim metros As Long = 0
        Dim tot As Double = 0

        xc = ConsultaSql("select sum(con_m3) as m3, sum(consumo) as consumo,sum(drenaje) as alcantarillado, sum(baseconsumo)* " & VARIABLE_IVA & " as iva ,sum(otros_cargos) as otros, sum(saneamiento) as saneamiento, count(*) as cuantos from estados where ultimo=1 and id_comunidad='" & comunidad & "' and id_region ='" & region & "'")

        Try
            xr = xc.ExecuteReader
            While xr.Read()
                consumo = xr("consumo")
                metros = xr("m3")
                cuantos = xr("cuantos")
                alcanta = xr("alcantarillado")
                sanea = xr("saneamiento")
                iva = xr("iva")
                otros = xr("otros")


            End While

        Catch ex As Exception
            MessageBoxEx.Show(ex.Message())
            MessageBoxEx.Show("no puede resumir los datos del cierre, Posible perdidad de conexión")

        End Try


        Dim CADENA As New StringBuilder
        tot = consumo + alcanta + sanea + otros + iva
        CADENA.Append("INSERT INTO CIERRE (ID_COMUNIDAD,ID_REGION,FECHA,USUARIO,MES,ANIO,cuantos,m3,MONTOCONSUMO,MONTOALCANTA,MONTOSANEA,MONTOIVA,MONTOOTROS,TOTAL)  VALUES (")
        CADENA.Append("'" & comunidad & "','" & region & "'," & UnixDateFormat(Now, True, True) & "," & NumUser & ",'" & Mid(UCase(MonthName(Month(mes))), 1, 3) & "'," & Year(mes) & ",")
        CADENA.Append(cuantos & "," & metros & "," & consumo & "," & alcanta & "," & sanea & "," & iva & "," & otros & "," & tot & ")")
        Try
            Ejecucion(CADENA.ToString())

        Catch ex As Exception
            MessageBoxEx.Show(ex.Message())
            MessageBoxEx.Show("no puede grabar los datos del cierre, Posible perdidad de conexión")
        End Try

        Try
            '   Ejecucion("UPDATE RUTAS SET TOMALEC='N', CAPTURA='N', CALCULO='N',APLICACION='N' WHERE ID_COMUNIDAD='" & comunidad & "' AND ID_REGION='" & region & "'")

        Catch ex As Exception
            MessageBoxEx.Show(ex.Message())
            MessageBoxEx.Show("no puede iniciar las validaciones del curso de accion del cierra para esta region, Posible perdidad de conexión")
        End Try
       

    End Sub

#End Region


End Class




