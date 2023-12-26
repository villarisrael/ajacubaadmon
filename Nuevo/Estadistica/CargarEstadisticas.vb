Imports System.Globalization

Public Class CargarEstadisticas

    Public Sub CargarInfNumeroTomas(ByVal comunidadP As String, ByVal mesP As String, ByVal periodoP As Int16)

        Dim numTomasDomConMedidor As Integer = 0
        Dim numTomasDomSinMedidor As Integer = 0

        Dim numTomasComConMedidor As Integer = 0
        Dim numTomasComSinMedidor As Integer = 0

        Dim numTomasIndConMedidor As Integer = 0
        Dim numTomasIndSinMedidor As Integer = 0

        Dim numTomasPubConMedidor As Integer = 0
        Dim numTomasPubSinMedidor As Integer = 0

        Dim numTomasSinUso As Integer = 0

        Dim numTomasTotales As Integer = 0

        Dim SQLInsert As String = ""

        Try



            Dim SQL As String = $"SELECT C.MEDIDO, COUNT(U.CUENTA) AS num_cuentas, T.DESCRIPCION AS DESCRIPCION FROM USUARIO U INNER JOIN CUOTAS C ON U.TARIFA = C.ID_TARIFA INNER JOIN tipos_usuarios T ON U.ID_TIPO_USUARIO=T.ID_TIPO_USUARIO WHERE U.ESTADO = 1 GROUP BY C.MEDIDO, U.ID_TIPO_USUARIO;"


            Dim dataNumTomas As IDataReader = ConsultaSql(SQL).ExecuteReader()


            While dataNumTomas.Read()

                Dim descripcionToma As String = ""
                Dim medido As Int16 = 0

                descripcionToma = dataNumTomas("DESCRIPCION")
                medido = dataNumTomas("MEDIDO")

                Select Case descripcionToma

                    Case "DOMESTICO"

                        If medido = 0 Then

                            numTomasDomSinMedidor = dataNumTomas("num_cuentas")

                        Else

                            numTomasDomConMedidor = dataNumTomas("num_cuentas")

                        End If

                    Case "COMERCIAL"

                        If medido = 0 Then

                            numTomasComSinMedidor = dataNumTomas("num_cuentas")

                        Else

                            numTomasComConMedidor = dataNumTomas("num_cuentas")

                        End If

                    Case "INDUSTRIAL"

                        If medido = 0 Then

                            numTomasIndSinMedidor = dataNumTomas("num_cuentas")

                        Else

                            numTomasIndConMedidor = dataNumTomas("num_cuentas")

                        End If

                    Case "SERVICIOS PUBLICOS"

                        If medido = 0 Then

                            numTomasIndSinMedidor = dataNumTomas("num_cuentas")

                        Else

                            numTomasIndConMedidor = dataNumTomas("num_cuentas")

                        End If

                    Case Else


                End Select


            End While

            numTomasSinUso = ObtenerCampoBDRemoto("SELECT COUNT(CUENTA) AS TOMAS_SIN_USO FROM USUARIO WHERE ESTADO <> 1", "TOMAS_SIN_USO")


            numTomasTotales = numTomasDomConMedidor + numTomasDomSinMedidor + numTomasComConMedidor + numTomasComSinMedidor + numTomasIndConMedidor + numTomasIndSinMedidor + numTomasSinUso

            SQLInsert = $"INSERT INTO db_a8c8a1_mulege.numerotomas (comunidad, mes, periodo, domesticas_con_medidor, domesticas_sin_medidor, comerciales_con_medidor, comerciales_sin_medidor, industriales_con_medidor, industriales_sin_medidor, tomas_sin_uso, importe_total) VALUES ('{comunidadP}','{mesP.ToUpper()}',{periodoP}, {numTomasDomConMedidor}, {numTomasDomSinMedidor},{numTomasComConMedidor},{numTomasComSinMedidor},{numTomasIndConMedidor},{numTomasIndSinMedidor},{numTomasSinUso},{numTomasTotales})"

            Dim unused = EjecutarConsultaRemotaAsync(SQLInsert)

            MessageBox.Show("LOS DATOS SE HAN CARGADO EXITOSAMENTE")

        Catch ex As Exception

            MessageBox.Show("OCURRIO UN ERROR AL CARGAR LOS DATOS")

        End Try

    End Sub

    Public Sub CargarInfNumeroDescargas(ByVal comunidadP As String, ByVal mesP As String, ByVal periodoP As Int16)

        Dim numTomasDomConMedidor As Integer = 0
        Dim numTomasDomSinMedidor As Integer = 0

        Dim numTomasComConMedidor As Integer = 0
        Dim numTomasComSinMedidor As Integer = 0

        Dim numTomasIndConMedidor As Integer = 0
        Dim numTomasIndSinMedidor As Integer = 0

        Dim numTomasPubConMedidor As Integer = 0
        Dim numTomasPubSinMedidor As Integer = 0

        Dim numTomasSinUso As Integer = 0

        Dim numTomasTotales As Integer = 0

        Dim SQLInsert As String = ""

        Try



            Dim SQL As String = $"SELECT C.MEDIDO, COUNT(U.CUENTA) AS num_cuentas, T.DESCRIPCION AS DESCRIPCION FROM USUARIO U INNER JOIN CUOTAS C ON U.TARIFA = C.ID_TARIFA INNER JOIN tipos_usuarios T ON U.ID_TIPO_USUARIO=T.ID_TIPO_USUARIO WHERE U.ESTADO = 1 AND U.ALCANTARILLADO = 1 GROUP BY C.MEDIDO, U.ID_TIPO_USUARIO;"


            Dim dataNumTomas As IDataReader = ConsultaSql(SQL).ExecuteReader()


            While dataNumTomas.Read()

                Dim descripcionToma As String = ""
                Dim medido As Int16 = 0

                descripcionToma = dataNumTomas("DESCRIPCION")
                medido = dataNumTomas("MEDIDO")

                Select Case descripcionToma

                    Case "DOMESTICO"

                        If medido = 0 Then

                            numTomasDomSinMedidor = dataNumTomas("num_cuentas")

                        Else

                            numTomasDomConMedidor = dataNumTomas("num_cuentas")

                        End If

                    Case "COMERCIAL"

                        If medido = 0 Then

                            numTomasComSinMedidor = dataNumTomas("num_cuentas")

                        Else

                            numTomasComConMedidor = dataNumTomas("num_cuentas")

                        End If

                    Case "INDUSTRIAL"

                        If medido = 0 Then

                            numTomasIndSinMedidor = dataNumTomas("num_cuentas")

                        Else

                            numTomasIndConMedidor = dataNumTomas("num_cuentas")

                        End If

                    Case "SERVICIOS PUBLICOS"

                        If medido = 0 Then

                            numTomasIndSinMedidor = dataNumTomas("num_cuentas")

                        Else

                            numTomasIndConMedidor = dataNumTomas("num_cuentas")

                        End If

                    Case Else


                End Select


            End While

            numTomasSinUso = ObtenerCampoBDRemoto("SELECT COUNT(CUENTA) AS TOMAS_SIN_USO FROM USUARIO WHERE ESTADO <> 1", "TOMAS_SIN_USO")


            numTomasTotales = numTomasDomConMedidor + numTomasDomSinMedidor + numTomasComConMedidor + numTomasComSinMedidor + numTomasIndConMedidor + numTomasIndSinMedidor + numTomasSinUso

            SQLInsert = $"INSERT INTO db_a8c8a1_mulege.numerodescargas (sistema, mes, periodo, domesticas_con_medidor, domesticas_sin_medidor, comerciales_con_medidor, comerciales_sin_medidor, industriales_con_medidor, industriales_sin_medidor, total) VALUES ('{comunidadP}','{mesP.ToUpper()}',{periodoP}, {numTomasDomConMedidor}, {numTomasDomSinMedidor},{numTomasComConMedidor},{numTomasComSinMedidor},{numTomasIndConMedidor},{numTomasIndSinMedidor},{numTomasTotales})"

            Dim unused = EjecutarConsultaRemotaAsync(SQLInsert)

            MessageBox.Show("LOS DATOS SE HAN CARGADO EXITOSAMENTE")

        Catch ex As Exception

            MessageBox.Show("OCURRIO UN ERROR AL CARGAR LOS DATOS")

        End Try

    End Sub


    Public Sub CargarInfVolumenServicio()



    End Sub

    Public Sub CargarInfConsumoFacturado(ByVal comunidadP As String, ByVal mesP As String, ByVal periodoP As Int16)

        Dim fechaInical As String = ""
        Dim fechaFinal As String = ""

        Dim consumoTomasDomConMedidor As Decimal = 0.0
        Dim consumoTomasDomSinMedidor As Decimal = 0.0

        Dim consumoTomasComConMedidor As Decimal = 0.0
        Dim consumoTomasComSinMedidor As Decimal = 0.0

        Dim consumoTomasIndConMedidor As Decimal = 0.0
        Dim consumoTomasIndSinMedidor As Decimal = 0.0

        Dim consumoImporteTotal As Decimal = 0.0

        Dim alcantaTomasDomConMedidor As Decimal = 0.0
        Dim alcantaTomasDomSinMedidor As Decimal = 0.0

        Dim alcantaTomasComConMedidor As Decimal = 0.0
        Dim alcantaTomasComSinMedidor As Decimal = 0.0

        Dim alcantaTomasIndConMedidor As Decimal = 0.0
        Dim alcantaTomasIndSinMedidor As Decimal = 0.0

        Dim alcantaImporteTotal As Decimal = 0.0

        Dim importeTotal As Decimal = 0.0

        Dim result As Tuple(Of DateTime, DateTime) = GetFirstAndLastDayOfMonth(periodoP, mesP)
        Dim firstDayOfMonth As DateTime = result.Item1
        Dim lastDayOfMonth As DateTime = result.Item2

        fechaInical = firstDayOfMonth.ToString("yyyy-MM-dd")
        fechaFinal = lastDayOfMonth.ToString("yyyy-MM-dd")

        'OBTENER DATOS DE CONSUMO
        Try


            Dim SQLConsumo As String = $"SELECT C.MEDIDO, SUM(PO.IMPORTE) AS IMPORTE_CONCEPTO, T.DESCRIPCION AS DESCRIPCION FROM USUARIO U INNER JOIN CUOTAS C ON U.TARIFA = C.ID_TARIFA INNER JOIN PAGOS P ON U.CUENTA=P.cuenta INNER JOIN PAGOTROS PO ON P.SERIE=PO.SERIE AND P.RECIBO=PO.RECIBO INNER JOIN tipos_usuarios T ON U.ID_TIPO_USUARIO=T.ID_TIPO_USUARIO WHERE U.ESTADO = 1 AND P.FECHA_ACT BETWEEN '{fechaInical}' AND '{fechaFinal}' AND (PO.NUMCONCEPTO = '{My.Settings.Clavedeconsumo}' OR PO.NUMCONCEPTO = '{My.Settings.ClavedeRezago}') AND P.CANCELADO = 'A'  GROUP BY C.MEDIDO, U.ID_TIPO_USUARIO"


            Dim dataNumTomas As IDataReader = ConsultaSql(SQLConsumo).ExecuteReader()


            While dataNumTomas.Read()

                Dim descripcionToma As String = ""
                Dim medido As Int16 = 0

                descripcionToma = dataNumTomas("DESCRIPCION")
                medido = dataNumTomas("MEDIDO")

                Select Case descripcionToma

                    Case "DOMESTICO"

                        If medido = 0 Then

                            consumoTomasDomSinMedidor = dataNumTomas("IMPORTE_CONCEPTO")

                        Else

                            consumoTomasDomConMedidor = dataNumTomas("IMPORTE_CONCEPTO")

                        End If

                    Case "COMERCIAL"

                        If medido = 0 Then

                            consumoTomasComSinMedidor = dataNumTomas("IMPORTE_CONCEPTO")

                        Else

                            consumoTomasComConMedidor = dataNumTomas("IMPORTE_CONCEPTO")

                        End If

                    Case "INDUSTRIAL"

                        If medido = 0 Then

                            consumoTomasIndSinMedidor = dataNumTomas("IMPORTE_CONCEPTO")

                        Else

                            consumoTomasIndConMedidor = dataNumTomas("IMPORTE_CONCEPTO")

                        End If

                    Case Else


                End Select


            End While

            consumoImporteTotal = consumoTomasDomSinMedidor + consumoTomasDomConMedidor + consumoTomasComSinMedidor + consumoTomasComConMedidor + consumoTomasIndSinMedidor + consumoTomasIndConMedidor

        Catch ex As Exception

            MessageBox.Show($"OCURRIO UN ERROR AL CARGAR LOS DATOS DE CONSUMO: {ex.ToString()}")

        End Try



        'OBTENER DATOS DE ALCANTARILLADO
        Try


            Dim SQLAlcantarillado As String = $"SELECT C.MEDIDO, SUM(PO.IMPORTE) AS IMPORTE_CONCEPTO, T.DESCRIPCION AS DESCRIPCION FROM USUARIO U INNER JOIN CUOTAS C ON U.TARIFA = C.ID_TARIFA INNER JOIN PAGOS P ON U.CUENTA=P.cuenta INNER JOIN PAGOTROS PO ON P.SERIE=PO.SERIE AND P.RECIBO=PO.RECIBO INNER JOIN tipos_usuarios T ON U.ID_TIPO_USUARIO=T.ID_TIPO_USUARIO WHERE U.ESTADO = 1 AND P.FECHA_ACT BETWEEN '{fechaInical}' AND '{fechaFinal}' AND (PO.NUMCONCEPTO = '{My.Settings.Clavedealcantarillado}') AND P.CANCELADO = 'A'  GROUP BY C.MEDIDO, U.ID_TIPO_USUARIO"


            Dim dataNumTomas As IDataReader = ConsultaSql(SQLAlcantarillado).ExecuteReader()


            While dataNumTomas.Read()

                Dim descripcionToma As String = ""
                Dim medido As Int16 = 0

                descripcionToma = dataNumTomas("DESCRIPCION")
                medido = dataNumTomas("MEDIDO")

                Select Case descripcionToma

                    Case "DOMESTICO"

                        If medido = 0 Then

                            alcantaTomasDomSinMedidor = dataNumTomas("IMPORTE_CONCEPTO")

                        Else

                            alcantaTomasDomConMedidor = dataNumTomas("IMPORTE_CONCEPTO")

                        End If

                    Case "COMERCIAL"

                        If medido = 0 Then

                            alcantaTomasComSinMedidor = dataNumTomas("IMPORTE_CONCEPTO")

                        Else

                            alcantaTomasComConMedidor = dataNumTomas("IMPORTE_CONCEPTO")

                        End If

                    Case "INDUSTRIAL"

                        If medido = 0 Then

                            alcantaTomasIndSinMedidor = dataNumTomas("IMPORTE_CONCEPTO")

                        Else

                            alcantaTomasIndConMedidor = dataNumTomas("IMPORTE_CONCEPTO")

                        End If

                    Case Else


                End Select

            End While

            alcantaImporteTotal = alcantaTomasDomSinMedidor + alcantaTomasDomConMedidor + alcantaTomasComSinMedidor + alcantaTomasComConMedidor + alcantaTomasIndSinMedidor + alcantaTomasIndConMedidor

        Catch ex As Exception

            MessageBox.Show($"OCURRIO UN ERROR AL CARGAR LOS DATOS DE ALCANTARILLADO: {ex.ToString()}")

        End Try

        importeTotal = consumoImporteTotal + alcantaImporteTotal

        'INSERTAR LOS DATOS A TABLA DE aguafacturada

        Try

            Dim SQLInsert = $"INSERT INTO db_a8c8a1_mulege.numerotomas (comunidad, mes, periodo, aguaDOM_con_medidor, aguaDOM_sin_medidor, aguaCOM_con_medidor, aguaCOM_sin_medidor, aguaIND_con_medidor, aguaIND_sin_medidor, importe_agua, alcantarilladoDOM_con_medidor, alcantarilladoDOM_sin_medidor, alcantarilladoCOM_con_medidor, alcantarilladoCOM_sin_medidor, alcantarilladoIND_con_medidor, alcantarilladoIND_sin_medidor, importe_alcantarillado, importe_total) VALUES ('{comunidadP}','{mesP.ToUpper()}',{periodoP}, {consumoTomasDomConMedidor}, {consumoTomasDomSinMedidor},{consumoTomasComConMedidor},{consumoTomasComSinMedidor},{consumoTomasIndConMedidor},{consumoTomasIndSinMedidor},{consumoImporteTotal},{alcantaTomasDomConMedidor}, {alcantaTomasDomSinMedidor}, {alcantaTomasComConMedidor}, {alcantaTomasComSinMedidor}, {alcantaTomasIndConMedidor}, {alcantaTomasIndSinMedidor}, {alcantaImporteTotal},{importeTotal})"

            Dim unused = EjecutarConsultaRemotaAsync(SQLInsert)

            MessageBox.Show("LOS DATOS SE HAN CARGADO EXITOSAMENTE")

        Catch ex As Exception

            MessageBox.Show($"OCURRIO UN ERROR AL CARGAR LOS DATOS: {ex.ToString()}")

        End Try


    End Sub

    Public Function GetFirstAndLastDayOfMonth(ByVal year As Integer, ByVal month As String) As Tuple(Of DateTime, DateTime)
        Dim monthNumber As Integer = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month
        Dim firstDayOfMonth As DateTime = New DateTime(year, monthNumber, 1)
        Dim lastDayOfMonth As DateTime = firstDayOfMonth.AddMonths(1).AddDays(-1)
        Return Tuple.Create(firstDayOfMonth, lastDayOfMonth)
    End Function




    Function GetMonthNumber(monthName As String) As Integer
        ' Convierte el nombre del mes a minúsculas y remueve los espacios iniciales y finales
        Dim normalizedMonthName As String = monthName.ToLower().Trim()

        ' Utiliza una instrucción Select Case para asignar el número del mes basado en el nombre
        Select Case normalizedMonthName
            Case "enero"
                Return 1
            Case "febrero"
                Return 2
            Case "marzo"
                Return 3
            Case "abril"
                Return 4
            Case "mayo"
                Return 5
            Case "junio"
                Return 6
            Case "julio"
                Return 7
            Case "agosto"
                Return 8
            Case "septiembre", "setiembre"
                Return 9
            Case "octubre"
                Return 10
            Case "noviembre"
                Return 11
            Case "diciembre"
                Return 12
            Case Else
                ' Si el nombre del mes no coincide con ninguno de los anteriores, retorna -1 o un valor que indique un error
                Return -1
        End Select
    End Function


End Class

Public Class NumeroTomas

    Public comunidad As String = ""
    Public mes As String = ""
    Public periodo As Integer = 0
    Public domesticasConMedidor As Decimal = 0.0
    Public domesticasSinMedidor As Decimal = 0.0
    Public comercialesConMedidor As Decimal = 0.0
    Public comercialesSinMedidor As Decimal = 0.0
    Public industrialesConMedidor As Decimal = 0.0
    Public industrialesSinMedidor As Decimal = 0.0
    Public tomasSinUso As Decimal = 0.0
    Public importeTotal As Decimal = 0.0

End Class
