Imports System.Data.Odbc
Imports System.Windows.Forms
Public Class ClsPagoMedido

    'Public fechainicial As String = Date.Now().ToString("MMM")
    'Public fechafinal As String = Date.Now().ToString("MMM")
    Public fechainicial As Date = Now()
    Public fechafinal As Date = Now()
    Public montopago As Double = 0
    Public tarifa As String
    'Public tarifa As Integer = 1
    Public cuenta As Integer



    Public collection As New Collection
    Public collectionconsumo As New Collection
    Public collectionrezago As New Collection



    Public lecturasgeneradas As New Collection
    Private tabladelecturas As New Hashtable
    Public pordescuento As Double = 0
    Public periodoscondescuento As Integer = 0
    Public pagocondescuento As Double = 0
    Public pagodeiva As Double = 0
    Public descontartodoslosperiodos As Boolean = False
    Public periodosadeudados As Integer
    Public periodo As String = ""
    Public Memoria As Boolean = False
    Public fechas As New clsfechas()


    Public periodoconsumo As String = ""
    Public periodorezago As String = ""


    Public montopagorezago As Double = 0
    Public pagocondescuentorezago As Double = 0

    Public llevaiva As Boolean
    Public totaldescuentopesos As Decimal = 0

    Public Function restainicial() As Integer
        Dim numeromes As Integer
        numeromes = fechainicial.Month - 1
        Return 12 - numeromes
    End Function
    Public Function restafinal() As Integer
        Return fechafinal.Month

    End Function

    Public Sub calculapago(Optional ByVal pagoconanticipo As Boolean = False)
        lecturasgeneradas.Clear()
        Dim mescadena As String
        Dim fecopera As New clsfechas
        Dim cadena As String
        '  mescadena = fechafinal
        mescadena = fecopera.valorcadenames(fechafinal.Month)
        mescadena = acompletacero(mescadena, 2)
        Dim meses As Integer

        If Memoria = True Then
            'cadena = "select mes,an_per,consumocobrado,lectura,lectant,consumoMedidos(consumocobrado,usuario.tarifa) AS MONTO,valornummes(mes,an_per) as ordenado,usuario.tarifa as tarifa  from lecturas,usuario where lecturas.cuenta= usuario.cuenta and usuario.cuenta =" & cuenta & " and pagado=0 order by ordenado "
            '   cadena = "select mes,an_per,consumocobrado,lectura,lectant,consumoMedidos(consumocobrado,usuario.tarifa,an_per) AS MONTO,valornummes(mes,an_per) as ordenado,usuario.tarifa as tarifa  from lecturas,usuario where lecturas.cuenta= usuario.cuenta and usuario.cuenta =" & cuenta & " and pagado=0 order by ordenado "
            cadena = "select mes,an_per,consumocobrado,lectura,lectant, MONTO,valornummes(mes,an_per) as ordenado,usuario.tarifa as tarifa  from lecturas,usuario where lecturas.cuenta= usuario.cuenta and usuario.cuenta =" & cuenta & " and pagado=0 and valornummes(mes,an_per)<= valornummes('" & mescadena & "'," & fechafinal.Year & " ) order by ordenado "
        Else
            'cadena = "select mes,an_per,consumocobrado,lectura,lectant,consumoMedidosSin(consumocobrado,usuario.tarifa) AS MONTO,valornummes(mes,an_per) as ordenado,usuario.tarifa as tarifa from lecturas,usuario where lecturas.cuenta= usuario.cuenta and usuario.cuenta =" & cuenta & " and pagado=0 order by ordenado " modificado para cobro medido por alos 17/01/2015
            cadena = "select mes,an_per,consumocobrado,lectura,lectant,consumoMedidosSin(consumocobrado,usuario.tarifa,an_per) AS MONTO,valornummes(mes,an_per) as ordenado,usuario.tarifa as tarifa from lecturas,usuario where lecturas.cuenta= usuario.cuenta and usuario.cuenta =" & cuenta & " and pagado=0 and valornummes(mes,an_per)<= valornummes('" & mescadena & "'," & fechafinal.Year & " ) order by ordenado "
        End If





        Dim rs As OdbcDataReader
        Dim bas As New base

        bas.conectar()
        rs = bas.consultasql(cadena)
        Try
            While (rs.Read())
                meses = meses + 1
            End While

        Catch ex As Exception
            montopago = 0
            pagocondescuento = 0
            pagodeiva = 0
            Exit Sub
        End Try




        bas.conectar()
        rs = bas.consultasql(cadena)

        periodosadeudados = meses

        If descontartodoslosperiodos = True Then
            periodoscondescuento = meses
        End If

        'Dim contadormeses As Integer = Month(fechainicial)
        Dim contadormeses As Integer
        contadormeses = fechainicial.Month
        Dim contadorperiodos As Integer
        contadorperiodos = fechafinal.Month
        'Dim contadorperiodos As Integer = Year(fechainicial)
        Dim trabajoconfecha As New clsfechas
        Dim acumulador As Double = 0
        Dim acumuladorcondescuento As Double = 0
        Dim acumuladorrezago As Double = 0
        Dim acumuladorcondescuentorezago As Double = 0


        Dim funcionesf As New clsfechas


        contadormeses += 1
        Dim i As Integer = meses
        Dim llevaconsumo As Boolean = False
        Dim llevarezago As Boolean = False
        Dim posicioninicialconsumo As Integer = -1
        Dim cadenacomodin As String = ""
        Dim elprimeroconsumo As Boolean = True
        Dim elprimerorezago As Boolean = True

        Do While (rs.Read)


            Dim objeto As New ClsRegistrolectura
            objeto.Consumo = Int(rs("consumocobrado"))
            objeto.Lectura_Actual = Int(rs("lectura"))
            objeto.Lectura_Anterior = Int(rs("Lectant"))
            'objeto.Situacion = (rs("situacion"))
            objeto.Total = Math.Round(rs("Monto"), 2)



            If contadormeses = 13 Then
                contadormeses = 1
                contadorperiodos = contadorperiodos + 1
            End If

            objeto.Numeroperiodo = i
            i -= 1
            objeto.Mes = rs("mes")
            objeto.Periodo = rs("an_per")





            acumulador = acumulador + objeto.Total

            If i < periodoscondescuento Then
                If pordescuento > 0 Then


                    Select Case TIPODESCUENTO
                        Case "SOBRE TOTAL"
                            objeto.Descuento = objeto.Total * (pordescuento / 100)
                        Case "SOBRE MINIMO"
                            Dim descuento As Decimal = obtenerCampo("select consumomedidos(0,""" & tarifa & """," & objeto.Periodo & ") as minimo", "minimo") * (pordescuento / 100)
                            objeto.Descuento = descuento
                    End Select


                    objeto.Totalcondescuento = objeto.Total - objeto.Descuento


                End If
            Else
                objeto.Descuento = 0
                objeto.Totalcondescuento = objeto.Total

            End If


            If llevaiva Then
                objeto.coniva()
            Else
                objeto.siniva()
            End If

            pagodeiva = pagodeiva + objeto.totaliva
            If objeto.Periodo = Year(Now) Then
                objeto.Tipo = "CONSUMO"
                acumulador = acumulador + objeto.Total
                acumuladorcondescuento = acumuladorcondescuento + objeto.Totalcondescuento
                If elprimeroconsumo Then
                    cadenacomodin = objeto.Mes & " " & objeto.Periodo
                    elprimeroconsumo = False
                End If
                llevaconsumo = True

                collectionconsumo.Add(objeto)
            Else
                llevarezago = True

                objeto.Tipo = "REZAGO"
                acumuladorrezago += objeto.Total
                acumuladorcondescuentorezago += objeto.Totalcondescuento
                If elprimerorezago Then
                    cadenacomodin = objeto.Mes & " " & objeto.Periodo
                    elprimerorezago = False
                End If

                collectionrezago.Add(objeto)
            End If

            collection.Add(objeto, i)
            contadormeses = contadormeses + 1
        Loop


        If llevaconsumo Then
            Dim objeto As ClsRegistrolectura
            Dim objeto2 As ClsRegistrolectura
            objeto = collectionconsumo.Item(1)
            objeto2 = collectionconsumo.Item(collectionconsumo.Count)
            periodoconsumo = objeto.Mes & " " & objeto.Periodo & "-" & objeto2.Mes & " " & objeto2.Periodo
        End If

        If llevarezago Then
            Dim objeto As ClsRegistrolectura
            Dim objeto2 As ClsRegistrolectura
            objeto = collectionrezago.Item(1)
            objeto2 = collectionrezago.Item(collectionrezago.Count)
            periodorezago = objeto.Mes & " " & objeto.Periodo & "-" & objeto2.Mes & " " & objeto2.Periodo
        End If

        bas.conexion.Dispose()
        pagocondescuento = Math.Round(acumuladorcondescuento, 2)
        montopago = Math.Round(acumulador, 2)
        pagocondescuentorezago = Math.Round(acumuladorcondescuentorezago, 2)
        montopagorezago = Math.Round(acumuladorrezago, 2)

        If montopago < 0 Then
            montopago = 0
        End If
    End Sub

    Public Function llaveante(llave As String) As String

        Dim mes, ano As Integer
        ano = Val(llave.Substring(0, 4))
        mes = Val(llave.Substring(4, 2)) - 1
        If mes = 0 Then
            mes = 12
            ano = ano - 1
        End If

        Dim llavea As String = ""
        llavea = ano.ToString()
        Dim me2 As String = ""
        me2 = acompletacero(mes.ToString(), 2)
        llavea += me2
        Return llavea
    End Function

End Class
