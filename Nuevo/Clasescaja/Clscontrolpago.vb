﻿Imports System.Data.Odbc
Imports System



Public Class Clscontrolpago

    Public Tarifa As String
    'Public Tarifa As Integer
    Public Fechainicio As Date
    Public Fechafinal As Date
    Public Listadeconceptos As New Collection
    Public EsFijo As Boolean
    Public EsMEdido As Boolean
    Public descuentoaconsumo As Double = 0
    Public descuentoaalcantarillado As Double = 0
    Public descuentoasaneamiento As Double = 0
    Public descuentoarecargo As Double = 0
    Public descuentoarezago As Double = 0

    Public periodoscondescuentodeconsumo As Integer = 0
    Public periodoscondescuentodealcantarillado As Integer = 0
    Public periodoscondescuentodesaneamiento As Integer = 0
    Public periodoscondescuentoderecargo As Integer = 0
    Public periodoscondescuentoderezago As Integer = 0

    Public descontartodoslosperiodosdeconsumo As Boolean = False
    Public descontartodoslosperiodosdealcantarillado As Boolean = False
    Public descontartodoslosperiodosdesaneamiento As Boolean = False
    Public descontartodoslosperiodosderecargo As Boolean = False
    Public descontartodoslosperiodosderezago As Boolean = False

    Public periodosadeudados As Integer
    Public Tarifaconiva As Boolean = False
    Public cuenta As Long
    Public periodo As String = ""
    Public periodoconsumo As String = ""
    Public periodorezago As String = ""
    Public desgloseconsumo As New Collection
    Public desglosealcantarillado As New Collection
    Public desglosesaneamiento As New Collection
    Public desgloserecargo As New Collection
    Public desgloserezago As New Collection
    Public desgloseAnticipo As New Collection
    Public desgloselecturas As New Collection

    Public llevaivaconsumo As Boolean = False
    Public llevaivaalcantarillado As Boolean = False
    Public llevaivasaneamiento As Boolean = False
    Public llevaivarecargo As Boolean = False

    Public ConMemoria As Boolean = False


    Public totaldeudaconsumo As Double = 0
    Public totaldeudaalcantarillado As Double = 0
    Public totaldeudasaneamiento As Double = 0
    Public totaldeudaiva As Double = 0
    Public totaldeudarecargos As Double = 0
    Public totaldeudaotros As Double = 0

    Public totaldescuento As Double = 0
    Public Ttotaldescuento As Double = 0
    Public totaldescuentopesos As Double = 0

    Public pagosatrasados As Integer = 0

    Public fechas As New clsfechas()
    Public FI As String = ""
    Public FIF As String = ""

    Public valvulista As Integer = 0
    Public saneamiento As Integer = 0
    Public alcantarillado As Integer = 0
    Public credito As Double = 0
    Public totaldescuentorecargo As Decimal = 0

    Public Sub calcula(ByVal permitiranticipo As Boolean)
        VARIABLE_IVA = 16
        totaldeudaconsumo = 0
        totaldeudaalcantarillado = 0
        totaldeudasaneamiento = 0
        totaldeudaiva = 0
        totaldeudarecargos = 0
        totaldeudaotros = 0
        ' LIMPIA LOS DESGOSES
        desgloseconsumo.Clear()
        desglosealcantarillado.Clear()
        desglosesaneamiento.Clear()
        desgloserecargo.Clear()
        desgloserezago.Clear()
        desgloseAnticipo.Clear()
        desgloselecturas.Clear()


        Try
            Listadeconceptos.Clear()
        Catch ex As Exception

        End Try

        Dim cadena As String = "select * from CUOTAS where id_tarifa ='" & Tarifa & "'"
        Dim rs As OdbcDataReader
        Dim bas As New base

        bas.conectar()
        rs = bas.consultasql(cadena)

        Try
            rs.Read()
            If rs("MEDIDO") = 0 Then
                EsFijo = True
                EsMEdido = False
            Else
                EsFijo = False
                EsMEdido = True
            End If


            If rs("ivaacon") = 0 Then
                llevaivaconsumo = False
            Else
                llevaivaconsumo = True
            End If

            If rs("ivaalca") = 0 Then
                llevaivaalcantarillado = False
            Else
                llevaivaalcantarillado = True
            End If

            If rs("ivasane") = 0 Then
                llevaivasaneamiento = False
            Else
                llevaivasaneamiento = True
            End If

            If rs("ivareca") = 0 Then
                llevaivarecargo = False
            Else
                llevaivarecargo = True
            End If

            If rs("Memoria") = 0 Then
                ConMemoria = False
            Else
                ConMemoria = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            If rs(My.Settings.booleanIVA) <> 0 Then
                Tarifaconiva = True
            End If
        Catch ex As Exception

        End Try
        pagosatrasados = 0
        If EsFijo Then
            Try
                calculafijo(rs)
            Catch ex As Exception
                MessageBox.Show(" control pago_ fijo:" & ex.Message)
            End Try


        End If  ' fin de si es fijo en consumo

        If EsMEdido Then ' ejecutar el calculo de consumo medido
            Try
                calculamedido(rs, permitiranticipo)
            Catch ex As Exception
                MessageBox.Show(" control pago_ medido:" & ex.Message)
            End Try


        End If  ' fin de si es fijo en consumo

        If periodoconsumo = "" And periodorezago <> "" Then
            periodo = periodorezago
        End If
        If periodorezago = "" And periodoconsumo <> "" Then
            periodo = periodoconsumo
        End If
        If periodoconsumo <> "" And periodorezago <> "" Then
            periodo = Mid(periodorezago, 1, 9) & Mid(periodoconsumo, 10, 10)
        End If

        'If My.Settings.cobrarvalvulista = "SI" Then
        '    calculavalvulista()
        'End If
        bas.conexion.Dispose()
        llenaotros()
        rectificaiva()
    End Sub

    Public Sub rectificaiva()
        ' Rectifica el iva en los conceptos
        Dim acumiva As Double = 0

        For index = 1 To Listadeconceptos.Count
            Dim conce As New Clsconcepto
            conce = Listadeconceptos(index)
            If conce.IVA > 0 Then
                conce.IVA = Math.Round((conce.Cantidad * conce.Preciounitario) * (VARIABLE_IVA / 100), 2)
            End If
            acumiva += conce.IVA
        Next
        totaldeudaiva = acumiva
    End Sub

    Public Sub calculafijo(ByVal rs As OdbcDataReader)

        Dim Cadenadeperiodo As String = ""
        Dim consumo As New clspagofijo


        Try
            'If Not (fechahoy < Fechainicio) Then
            '    consumo.fechainicial = fechahoy
            'Else
            consumo.fechainicial = Fechainicio
            'End If


            If Tarifaconiva Then
                consumo.llevaiva = llevaivaconsumo
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        consumo.fechafinal = DateAdd(DateInterval.Month, -1, Now) 'Fechafinal
        consumo.tarifa = Tarifa
        consumo.pordescuento = descuentoaconsumo
        consumo.periodoscondescuento = periodoscondescuentodeconsumo
        consumo.descontartodoslosperiodos = descontartodoslosperiodosdeconsumo
        consumo.calculapago()

        desgloseconsumo = consumo.collectionconsumo '' hace una copia de cada mes en desglose como una coleccion
        periodosadeudados = consumo.periodosadeudados
        totaldescuentopesos = consumo.totaldedescuentopesos
        conectar()

        If consumo.montopago > 0 Then
            Dim concepto As New Clsconcepto
            concepto.Clave = My.Settings.Clavedeconsumo
            concepto.clavesat = obtenerCampo("select clavesat From conceptoscxc where id_concepto='" & concepto.Clave & "'", "clavesat")
            concepto.unidadsat = obtenerCampo("select unidadsat From conceptoscxc where id_concepto='" & concepto.Clave & "'", "unidadsat")

            concepto.Cantidad = 1
            concepto.Concepto = "CONSUMO DE AGUA "
            Dim objeto, objeto2 As New clsunidadmes
            Try
                'objeto = consumo.collection.Item(1)
                'objeto2 = consumo.collection.Item(consumo.collection.Count)
                'Cadenadeperiodo = objeto.mes & " " & objeto.periodo & " - " & objeto2.mes & " " & objeto2.periodo
                Cadenadeperiodo = consumo.Periodoconsumo
                periodoconsumo = Cadenadeperiodo

                concepto.Concepto += Cadenadeperiodo
            Catch ex As Exception

            End Try
            concepto.Preciounitario = consumo.pagocondescuento
            concepto.calcula()
            '
            ' totaldescuento += consumo.pagocondescuento
            If llevaivaconsumo Then
                concepto.IVA = Math.Round(consumo.pagocondescuento * (VARIABLE_IVA / 100), 2)
            Else
                concepto.IVA = 0
            End If
            concepto.importe = consumo.pagocondescuento
            totaldeudaconsumo += consumo.pagocondescuento ' acumulando el consumo para el evento cierre de mes
            totaldeudaiva += Math.Round(concepto.IVA, 2)  ' acumula el iva al cierre
            concepto.Clave = My.Settings.Clavedeconsumo


            Listadeconceptos.Add(concepto, "CONSUMO") ' añade el concepto de consumo
        End If ' fin de consumo

        desgloserezago = consumo.collectionrezago

        pagosatrasados = consumo.collection.Count


        If consumo.montopagorezago > 0 Then
            Dim concepto As New Clsconcepto
            concepto.Clave = My.Settings.ClavedeRezago

            concepto.clavesat = obtenerCampo("select clavesat From conceptoscxc where id_concepto='" & concepto.Clave & "'", "claveosat")
            concepto.unidadsat = obtenerCampo("select unidadsat From conceptoscxc where id_concepto='" & concepto.Clave & "'", "unidadsat")

            concepto.Cantidad = 1
            concepto.Concepto = "REZAGO DE AGUA  "
            Dim objeto, objeto2 As New clsunidadmes

            Try

                'objeto = Rezagoconsumo.collection.Item(1)
                'objeto2 = Rezagoconsumo.collection.Item(Rezagoconsumo.collection.Count)
                periodorezago = consumo.PeriodoRezago
                concepto.Concepto += consumo.PeriodoRezago
            Catch ex As Exception

            End Try
            concepto.Preciounitario = consumo.pagocondescuentorezago
            concepto.calcula()
            '
            'totaldescuento += consumo.pagocondescuento
            '
            If llevaivaconsumo Then
                concepto.IVA = consumo.pagocondescuentorezago * (VARIABLE_IVA / 100)
            Else
                concepto.IVA = 0
            End If


            totaldeudaconsumo += consumo.pagocondescuentorezago ' acumulando el consumo para el evento cierre de mes
            totaldeudaiva += concepto.IVA
            concepto.Clave = My.Settings.ClavedeRezago



            Listadeconceptos.Add(concepto, "Rezago") ' añade el concepto de consumo
        End If '

   Dim alcantarillado2 As New Clscobrofijo
        Try
            If alcantarillado = 1 Then
                If rs(My.Settings.booleanalcantarillado) <> 0 Then
                   

                    If Tarifaconiva Then
                        alcantarillado2.llevaiva = llevaivaalcantarillado
                    End If

                    If rs(My.Settings.booleancobrarfijoalcantarillado) <> 0 Then ' si va cobrar fijo alcantarillado

                        alcantarillado2.tarifa = Tarifa
                        alcantarillado2.cobroaporcentaje = False
                        alcantarillado2.campodecobro = "pago_alcant"

                        alcantarillado2.descontartodoslosperiodos = descontartodoslosperiodosdealcantarillado
                        alcantarillado2.pordescuento = descuentoaalcantarillado
                        alcantarillado2.periodoscondescuento = periodoscondescuentodealcantarillado

                        alcantarillado2.calcular(Fechainicio, Fechafinal)
                    Else

                        alcantarillado2.tarifa = Tarifa
                        alcantarillado2.cobroaporcentaje = True
                        alcantarillado2.Porcentajedecobro = rs(My.Settings.Porcentajedealcantarillado)

                        alcantarillado2.descontartodoslosperiodos = descontartodoslosperiodosdealcantarillado
                        alcantarillado2.pordescuento = descuentoaalcantarillado
                        alcantarillado2.periodoscondescuento = periodoscondescuentodealcantarillado
                        alcantarillado2.descontartodoslosperiodos = descontartodoslosperiodosdealcantarillado
                        alcantarillado2.calcular(Fechainicio, Fechafinal)

                    End If
                    If alcantarillado2.Pago > 0 Then
                        desglosealcantarillado = alcantarillado2.collection ' obtiene el desglosado de alcantarillado por ms

                        Dim conceptoalcan As New Clsconcepto
                        conceptoalcan.Clave = My.Settings.Clavedealcantarillado
                        conceptoalcan.Cantidad = 1
                        conceptoalcan.Concepto = "ALCANTARILLADO"
                        conceptoalcan.Preciounitario = alcantarillado2.pagocondescuento
                        conceptoalcan.calcula()
                        '
                        ' totaldescuento += consumo.pagocondescuento
                        '
                        conceptoalcan.IVA = alcantarillado2.pagodeiva

                        totaldeudaalcantarillado = conceptoalcan.importe ' acumulado para el cierre
                        totaldeudaiva += conceptoalcan.IVA

                        conceptoalcan.Clave = My.Settings.Clavedealcantarillado
                        Listadeconceptos.Add(conceptoalcan, "Alcantarillado") ' añade el concepto de alcantarillado
                    End If

                End If ' fin de si se cobro alcantarillado
            End If

        Catch ex As Exception

        End Try

        Try
            If saneamiento = 1 Then
            Dim saneamiento2 As New Clscobrofijo
                If rs(My.Settings.booleansaneamiento) <> 0 Then
                    

                    If Tarifaconiva Then
                        saneamiento2.llevaiva = llevaivasaneamiento
                    End If

                    If rs(My.Settings.booleancobrarfijoalcantarillado) <> 0 Then ' si va cobrar fijo alcantarillado

                        saneamiento2.tarifa = Tarifa
                        saneamiento2.cobroaporcentaje = False
                        saneamiento2.campodecobro = "Saneamiento"

                        saneamiento2.descontartodoslosperiodos = descontartodoslosperiodosdesaneamiento
                        saneamiento2.pordescuento = descuentoasaneamiento
                        saneamiento2.periodoscondescuento = periodoscondescuentodesaneamiento
                        saneamiento2.descontartodoslosperiodos = descontartodoslosperiodosdesaneamiento

                    Else

                        saneamiento2.tarifa = Tarifa
                        saneamiento2.cobroaporcentaje = True
                        saneamiento2.Porcentajedecobro = rs(My.Settings.Porcentajedesaneamiento)

                        saneamiento2.descontartodoslosperiodos = descontartodoslosperiodosdesaneamiento
                        saneamiento2.pordescuento = descuentoasaneamiento
                        saneamiento2.periodoscondescuento = periodoscondescuentodesaneamiento
                        saneamiento2.descontartodoslosperiodos = descontartodoslosperiodosdesaneamiento


                    End If
                    saneamiento2.calcular(Fechainicio, Fechafinal)
                    If saneamiento2.Pago > 0 Then
                        desglosesaneamiento = saneamiento2.collection
                        Dim conceptosan As New Clsconcepto
                        conceptosan.Clave = My.Settings.clavedesaneamiento
                        conceptosan.Cantidad = 1
                        conceptosan.Concepto = "SANEAMIENTO"
                        conceptosan.Preciounitario = saneamiento2.pagocondescuento
                        conceptosan.calcula()
                        '
                        ' totaldescuento += consumo.pagocondescuento
                        '
                        conceptosan.IVA = saneamiento2.pagodeiva

                        totaldeudasaneamiento = conceptosan.importe ' acumulado para el cierre
                        totaldeudaiva += conceptosan.IVA
                        conceptosan.Clave = My.Settings.clavedesaneamiento

                        Listadeconceptos.Add(conceptosan, "SANEAMIENTO") ' añade el concepto de saneamiento
                    End If

                End If ' fin de si se cobro alcantarillado
            End If

        Catch ex As Exception

        End Try
        Try
            If rs(My.Settings.booleanrecargos) <> 0 Then
                Dim recargos As New Clsrecargo
                recargos.esmedido = EsMEdido
                If Tarifaconiva Then
                    recargos.llevaiva = llevaivarecargo
                End If

                recargos.descontartodoslosperiodos = descontartodoslosperiodosderecargo
                recargos.periodoscondescuento = periodoscondescuentoderecargo
                recargos.pordescuento = descuentoarecargo

                recargos.calcular(consumo.collection, alcantarillado2.collection, "FIJO")
                If recargos.recargo <= 0 Then
                    recargos.recargo = 0
                End If

                If recargos.recargo > 0 Then
                    desgloserecargo = recargos.collection
                    Dim conceptoreca As New Clsconcepto
                    conceptoreca.Clave = My.Settings.Clavederecargo



                    conceptoreca.clavesat = obtenerCampo("select clavesat From conceptoscxc where id_concepto='" & conceptoreca.Clave & "'", "clavesat")
                    conceptoreca.unidadsat = obtenerCampo("select unidadsat From conceptoscxc where id_concepto='" & conceptoreca.Clave & "'", "unidadsat")



                    conceptoreca.Cantidad = 1
                    conceptoreca.Concepto = "RECARGO "
                    conceptoreca.Preciounitario = recargos.pagocondescuento
                    conceptoreca.calcula()
                    '
					 totaldescuentorecargo = 0	
                    ' totaldescuento += consumo.pagocondescuento
                    '
                    If llevaivarecargo Then
                        conceptoreca.IVA = recargos.pagocondescuento * (VARIABLE_IVA / 100)
                    Else
                        conceptoreca.IVA = 0
                    End If
                    conceptoreca.Clave = My.Settings.Clavederecargo


                    Listadeconceptos.Add(conceptoreca, "RECARGO") ' añade el concepto de RECARGO


                    totaldeudarecargos = conceptoreca.importe ' acumulado para el cierre
                    totaldeudaiva += conceptoreca.IVA


                End If

            End If ' fin 

        Catch ex As Exception

        End Try
        'Ttotaldescuento = totaldescuento
    End Sub

    Public Sub calculamedido(ByVal rs As OdbcDataReader, Optional ByVal pagoconanticipo As Boolean = False)

        Dim consumo As New ClsPagoMedido
        Dim fechahoy As Date = Now
        '  Date.TryParse("28/" & Now.Month & "/" & Now.Year, fechahoy)
        'fechahoy = fechahoy.AddMonths(0)
        fechahoy = fechahoy.AddMonths(-1)

        Dim Cadenadeperiodo As String = ""
        'Dim consumo As New clspagofijo

        Try
            If Tarifaconiva Then
                consumo.llevaiva = llevaivaconsumo
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        'If (fechahoy.Month >= Fechafinal.Month And fechahoy.Year >= Fechafinal.Year) Or (fechahoy.Month >= Fechafinal.Month And fechahoy.Year >= Fechafinal.Year) Then
        ' If (fechahoy.Month >= Fechafinal.Month And fechahoy.Year >= Fechafinal.Year) Then

        consumo.cuenta = cuenta


        consumo.fechainicial = DateAdd(DateInterval.Month, 0, Fechainicio)
        'consumo.fechafinal = fechahoy 'Fechafinal
        consumo.fechafinal = DateAdd(DateInterval.Month, -1, Now) 'Fechafinal
        consumo.Memoria = ConMemoria

        consumo.tarifa = Tarifa

        consumo.pordescuento = descuentoaconsumo
        consumo.periodoscondescuento = periodoscondescuentodeconsumo
        consumo.descontartodoslosperiodos = descontartodoslosperiodosdeconsumo
        consumo.calculapago(False) ' calcula actual en pagoconanticipo=false , emergue la ventana de anticipo =true




        totaldescuentopesos = consumo.totaldescuentopesos

        desgloselecturas = consumo.lecturasgeneradas
        periodosadeudados = consumo.periodosadeudados

        Dim acuconsumo As Double = 0
        Dim acurezago As Double = 0
        Dim posicionconsumo As Integer = 0
        Dim contador As Integer = 0
        Dim acuivaconsumo As Double = 0
        Dim acuivarezago As Double = 0
        Dim yalopuse As Boolean = False
        For Each elemento In consumo.collection
            Dim registro As ClsRegistrolectura = elemento

            If registro.Tipo.ToUpper = "CONSUMO" Or registro.Tipo.ToUpper = "ANTICIPO" Then

                If Not yalopuse Then ' si no ha identificado cual es la primer posicion del periodo
                    posicionconsumo = contador
                    yalopuse = True

                End If
                acuivaconsumo = acuivaconsumo + registro.totaliva
                desgloseconsumo.Add(registro)
                If registro.Tipo.ToUpper = "ANTICIPO" Then
                    desgloseAnticipo.Add(registro)
                End If
                acuconsumo += registro.Total
            End If
            If registro.Tipo.ToUpper = "REZAGO" Then
                acurezago += registro.Total
                desgloserezago.Add(registro)
                acuivarezago += registro.totaliva
            End If
            contador += 1
        Next



        ' ************aqui hay que ordenar las colecciones **************



        'If consumo.montopago > 0 Then
        '  desgloseconsumo = consumo.collection '' hace una copia de cada mes en desglose como una coleccion
        Dim objeto, objeto2 As New ClsRegistrolectura
        If acuconsumo > 0 Then
            Dim concepto As New Clsconcepto
            concepto.Clave = My.Settings.Clavedeconsumo
            concepto.Cantidad = 1
            concepto.Concepto = "CONSUMO DE AGUA PERIODO "

            Try

                objeto = consumo.collection.Item(posicionconsumo + 1)
                objeto2 = consumo.collection.Item(consumo.collection.Count)
                'Cadenadeperiodo = objeto2.Mes & " " & objeto2.Periodo & " - " & objeto.Mes & " " & objeto.Periodo
                Cadenadeperiodo = objeto.Mes & " " & objeto.Periodo & " - " & objeto2.Mes & " " & objeto2.Periodo
                periodoconsumo = Cadenadeperiodo
                concepto.Concepto += Cadenadeperiodo
            Catch ex As Exception

            End Try
            concepto.Preciounitario = Math.Round(acuconsumo, 2)
            concepto.importe = Math.Round(acuconsumo, 2)
            concepto.IVA = Math.Round(acuivaconsumo, 2)

            '            concepto.calcula()
            '           concepto.IVA = consumo.pagodeiva


            totaldeudaconsumo += Math.Round(concepto.importe, 2) ' acumulado para el cierre
            totaldeudaiva += Math.Round(concepto.IVA, 2)
            concepto.Clave = My.Settings.Clavedeconsumo
            Listadeconceptos.Add(concepto, "Consumo") ' añade el concepto de consumo

        End If
        ' aqui empieza el rezago

        If acurezago > 0 Then
            Dim conceptorez As New Clsconcepto
            conceptorez.Clave = My.Settings.ClavedeRezago
            conceptorez.Cantidad = 1
            conceptorez.Concepto = "REZAGO DEL PERIODO "
            conceptorez.IVA = acuivarezago
            Try

                objeto = consumo.collection.Item(1)
                If posicionconsumo <= 0 Then
                    objeto2 = consumo.collection.Item(consumo.collection.Count)
                Else
                    objeto2 = consumo.collection.Item(posicionconsumo)
                End If

                'Cadenadeperiodo = objeto2.Mes & " " & objeto2.Periodo & " - " & objeto.Mes & " " & objeto.Periodo
                Cadenadeperiodo = objeto.Mes & " " & objeto.Periodo & " - " & objeto2.Mes & " " & objeto2.Periodo
                periodorezago = Cadenadeperiodo
                conceptorez.Concepto += Cadenadeperiodo
            Catch ex As Exception

            End Try
            conceptorez.Preciounitario = Math.Round(acurezago, 2)
            conceptorez.importe = Math.Round(acurezago, 2)
            '          'conceptorez.calcula()

            'REVISAR POR QUE ??
            'conceptorez.IVA = consumo.pagodeiva


            totaldeudaconsumo += Math.Round(conceptorez.importe, 2) ' acumulado para el cierre
            totaldeudaiva += Math.Round(conceptorez.IVA, 2)

            Listadeconceptos.Add(conceptorez, "Rezago") ' 

        End If
        ' alcantarillador

        Dim alcantarillado2 As New Clscobrofijo
        Try
            If alcantarillado = 1 Then
                If rs(My.Settings.booleanalcantarillado) <> 0 Then
                    

                    If Tarifaconiva Then
                        alcantarillado2.llevaiva = llevaivaalcantarillado
                    End If

                    If rs(My.Settings.booleancobrarfijoalcantarillado) <> 0 Then ' si va cobrar fijo alcantarillado

                        alcantarillado2.tarifa = Tarifa
                        alcantarillado2.cobroaporcentaje = False


                        alcantarillado2.descontartodoslosperiodos = descontartodoslosperiodosdealcantarillado
                        alcantarillado2.pordescuento = descuentoaalcantarillado
                        alcantarillado2.periodoscondescuento = periodoscondescuentodealcantarillado
                        alcantarillado2.descontartodoslosperiodos = descontartodoslosperiodosdealcantarillado


                        For i = 1 To consumo.collection.Count
                            Dim objetoalca As New ClsRegistrolectura
                            Dim objetlectura As New ClsRegistrolectura
                            objetlectura = consumo.collection.Item(i)
                            objetoalca.Mes = objetlectura.Mes
                            objetoalca.Periodo = objetlectura.Periodo
                            objetoalca.Numeroperiodo = objetlectura.Numeroperiodo
                            objetoalca.Total = rs(My.Settings.campoalcantarillo)
                            '''' aqui meter algoritmo de descuento

                            objetoalca.Totalcondescuento = rs(My.Settings.campoalcantarillo)
                            If alcantarillado2.llevaiva Then
                                objetoalca.totaliva = Math.Round(objetoalca.Totalcondescuento * (variable_iva / 100), 2)
                                alcantarillado2.pagodeiva += objetoalca.totaliva
                                objetoalca.totalconiva = objetoalca.Totalcondescuento + objetoalca.totaliva
                            End If
                            alcantarillado2.collection.Add(objetoalca)
                            alcantarillado2.Pago = alcantarillado2.Pago + objetoalca.Totalcondescuento
                        Next



                    Else

                        alcantarillado2.tarifa = Tarifa
                        alcantarillado2.cobroaporcentaje = False

                        alcantarillado2.descontartodoslosperiodos = descontartodoslosperiodosdealcantarillado
                        alcantarillado2.pordescuento = descuentoaalcantarillado
                        alcantarillado2.periodoscondescuento = periodoscondescuentodealcantarillado
                        alcantarillado2.descontartodoslosperiodos = descontartodoslosperiodosdealcantarillado


                        For i = 1 To consumo.collection.Count
                            Dim objetoalca As New ClsRegistrolectura
                            Dim objetlectura As New ClsRegistrolectura
                            objetlectura = consumo.collection.Item(i)
                            objetoalca.Mes = objetlectura.Mes
                            objetoalca.Periodo = objetlectura.Periodo
                            objetoalca.Numeroperiodo = objetlectura.Numeroperiodo
                            objetoalca.Total = (rs(My.Settings.Porcentajedealcantarillado) / 100) * objetlectura.Totalcondescuento
                            '''' aqui meter algoritmo de descuento
                            objetoalca.Descuento = Math.Round(objetoalca.Total * (descuentoaalcantarillado / 100), 2)

                            objetoalca.Totalcondescuento = Math.Round(objetoalca.Total - objetoalca.Descuento, 2)


                            If alcantarillado2.llevaiva Then
                                objetoalca.totaliva = Math.Round(objetoalca.Totalcondescuento * (variable_iva / 100), 2)
                                alcantarillado2.pagodeiva += objetoalca.totaliva
                                objetoalca.totalconiva = objetoalca.Totalcondescuento + objetoalca.totaliva
                            End If
                            alcantarillado2.collection.Add(objetoalca)
                            alcantarillado2.Pago = alcantarillado2.Pago + objetoalca.Totalcondescuento
                        Next




                    End If
                    If alcantarillado2.Pago > 0 Then
                        desglosealcantarillado = alcantarillado2.collection ' obtiene el desglosado de alcantarillado por ms

                        Dim conceptoalcan As New Clsconcepto
                        conceptoalcan.Clave = My.Settings.Clavedealcantarillado
                        conceptoalcan.Cantidad = 1
                        conceptoalcan.Concepto = "ALCANTARILLADO"
                        conceptoalcan.Preciounitario = alcantarillado2.Pago
                        conceptoalcan.calcula()
                        conceptoalcan.IVA = alcantarillado2.pagodeiva

                        totaldeudaalcantarillado = conceptoalcan.importe ' acumulado para el cierre
                        totaldeudaiva += conceptoalcan.IVA

                        conceptoalcan.Clave = My.Settings.Clavedealcantarillado

                        Listadeconceptos.Add(conceptoalcan, "Alcantarillado") ' añade el concepto de alcantarillado
                    End If

                End If ' fin de si se cobro alcantarillado
            End If

        Catch ex As Exception

        End Try
        ' aqui comienza el saneamiento

        Try
            If saneamiento = 1 Then
                If rs(My.Settings.booleansaneamiento) <> 0 Then
                    Dim saneamiento As New Clscobrofijo

                    If Tarifaconiva Then
                        saneamiento.llevaiva = llevaivasaneamiento
                    End If


                    If rs(My.Settings.booleancobrarfijosaneamiento) <> 0 Then ' si va cobrar fijo alcantarillado

                        saneamiento.tarifa = Tarifa
                        saneamiento.cobroaporcentaje = False

                        saneamiento.descontartodoslosperiodos = descontartodoslosperiodosdealcantarillado
                        saneamiento.pordescuento = descuentoaalcantarillado
                        saneamiento.periodoscondescuento = periodoscondescuentodealcantarillado
                        saneamiento.descontartodoslosperiodos = descontartodoslosperiodosdealcantarillado
                        saneamiento.calcular(Fechainicio, Fechafinal)


                        For i = 1 To consumo.collection.Count
                            Dim objetoalca As New ClsRegistrolectura
                            Dim objetlectura As New ClsRegistrolectura
                            objetlectura = consumo.collection.Item(i)
                            objetoalca.Mes = objetlectura.Mes
                            objetoalca.Periodo = objetlectura.Periodo
                            objetoalca.Numeroperiodo = objetlectura.Numeroperiodo
                            objetoalca.Total = rs(My.Settings.camposaneamiento)

                            objetoalca.Totalcondescuento = rs(My.Settings.camposaneamiento)

                            '''' aqui meter algoritmo de descuento




                            If saneamiento.llevaiva Then
                                objetoalca.totaliva = Math.Round(objetoalca.Totalcondescuento * (variable_iva / 100), 2)
                                saneamiento.pagodeiva += objetoalca.totaliva
                                objetoalca.totalconiva = objetoalca.Totalcondescuento + objetoalca.totaliva
                            End If


                            saneamiento.collection.Add(objetoalca)
                            saneamiento.Pago = saneamiento.Pago + objetoalca.Totalcondescuento
                        Next


                    Else

                        saneamiento.tarifa = Tarifa
                        saneamiento.cobroaporcentaje = False

                        saneamiento.descontartodoslosperiodos = descontartodoslosperiodosdealcantarillado
                        saneamiento.pordescuento = descuentoaalcantarillado
                        saneamiento.periodoscondescuento = periodoscondescuentodealcantarillado
                        saneamiento.descontartodoslosperiodos = descontartodoslosperiodosdealcantarillado

                        For i = 1 To consumo.collection.Count
                            Dim objetoalca As New ClsRegistrolectura
                            Dim objetlectura As New ClsRegistrolectura
                            objetlectura = consumo.collection.Item(i)
                            objetoalca.Mes = objetlectura.Mes
                            objetoalca.Periodo = objetlectura.Periodo
                            objetoalca.Numeroperiodo = objetlectura.Numeroperiodo
                            objetoalca.Total = (rs(My.Settings.Porcentajedesaneamiento) / 100) * objetlectura.Totalcondescuento



                            '''' aqui meter algoritmo de descuento
                            objetoalca.Descuento = Math.Round(objetoalca.Total * (descuentoasaneamiento / 100), 2)
                            objetoalca.Totalcondescuento = objetoalca.Total - objetoalca.Descuento

                            If saneamiento.llevaiva Then
                                objetoalca.totaliva = Math.Round(objetoalca.Totalcondescuento * (variable_iva / 100), 2)
                                saneamiento.pagodeiva += objetoalca.totaliva
                                objetoalca.totalconiva = objetoalca.Totalcondescuento + objetoalca.totaliva
                            End If

                            objetoalca.Totalcondescuento = Math.Round(objetoalca.Total - objetoalca.Descuento, 2)
                            saneamiento.collection.Add(objetoalca)
                            saneamiento.Pago = saneamiento.Pago + objetoalca.Totalcondescuento
                        Next






                    End If
                    If saneamiento.Pago > 0 Then

                        desglosesaneamiento = saneamiento.collection

                        Dim conceptoalcan As New Clsconcepto
                        conceptoalcan.Clave = My.Settings.clavedesaneamiento
                        conceptoalcan.Cantidad = 1
                        conceptoalcan.Concepto = "SANEAMIENTO"
                        conceptoalcan.Preciounitario = saneamiento.Pago
                        conceptoalcan.calcula()
                        conceptoalcan.IVA = saneamiento.pagodeiva

                        totaldeudasaneamiento = conceptoalcan.importe ' acumulado para el cierre
                        totaldeudaiva += conceptoalcan.IVA
                        conceptoalcan.Clave = My.Settings.clavedesaneamiento

                        Listadeconceptos.Add(conceptoalcan, "Saneamiento") ' añade el concepto de alcantarillado
                    End If

                End If ' fin de si se cobro saneamiento
            End If
        Catch ex As Exception

        End Try

        Try

            If rs(My.Settings.booleanrecargos) <> 0 Then
                Dim recargos As New Clsrecargo
                recargos.esmedido = EsMEdido
                If Tarifaconiva Then
                    recargos.llevaiva = llevaivarecargo
                End If

                recargos.descontartodoslosperiodos = descontartodoslosperiodosderecargo
                recargos.periodoscondescuento = periodoscondescuentoderecargo
                recargos.pordescuento = descuentoarecargo

                recargos.calcular(consumo.collection, alcantarillado2.collection, "MEDIDO")

                If recargos.pagocondescuento < 0 Then
                    recargos.pagocondescuento = 0
                End If
                If recargos.pagocondescuento > 0 Then

                    'If recargos.pagocondescuento > acurezago Then
                    '    recargos.pagocondescuento = acurezago - 0.01
                    'End If

                   

                    desgloserecargo = recargos.collection
                    Dim conceptoreca As New Clsconcepto
                    conceptoreca.Clave = My.Settings.Clavederecargo
                    conceptoreca.Cantidad = 1
                    conceptoreca.Concepto = "RECARGO "
                    conceptoreca.Preciounitario = recargos.pagocondescuento
                    conceptoreca.calcula()
                    conceptoreca.IVA = recargos.pagodeiva

                    totaldescuentorecargo = recargos.recargo - recargos.pagocondescuento
                    If totaldescuentorecargo < 0.1 Then
                        totaldescuentorecargo = 0
                    End If
                    conceptoreca.Clave = My.Settings.Clavederecargo
                    totaldeudarecargos = conceptoreca.importe ' acumulado para el cierre
                    totaldeudaiva += 0

                    Listadeconceptos.Add(conceptoreca, "Recargo") ' añade el concepto de saneamiento
                End If

            End If ' fin 
        Catch ex As Exception

        End Try
    End Sub

   Dim hoy As Date = Date.Now
   
    Public Sub llenaotros()
        Dim x As New base
        Dim DATOS As OdbcDataReader = x.consultasql("SELECT  CANTIDAD, CONCEPTO, subtotRESTA AS MONTO, conceptoscxc.id_concepto AS CLAVE , conceptoscxc.aplicaiva as aplicaiva, otrosconceptos.CLAVE AS CLAVEMOV,unidadsat,clavesat FROM otrosconceptos,conceptoscxc WHERE otrosconceptos.CUENTA=" & cuenta & " AND PAGADO=0 AND otrosconceptos.ESTADO<>'CANCELADO' AND conceptoscxc.id_concepto=otrosconceptos.id_concepto")
        totaldeudaotros = 0
        totaldeudaotros = 0
        While DATOS.Read
            Dim Xy As New Clsconcepto
            Xy.Cantidad = 1
            Xy.Concepto = DATOS("CONCEPTO")
            'If DATOS("APLICAIVA") Then
            '    Xy.Preciounitario = Math.Round(DATOS("Monto") / (1 + (VARIABLE_IVA / 100)), 2)
            'Else
            Xy.Preciounitario = DATOS("Monto")
            'End If
            Xy.Clave = DATOS("CLAVE")
            Xy.unidadsat = DATOS("Unidadsat")
            Xy.clavesat = DATOS("clavesat")
			     Xy.Clave = DATOS("CLAVE")
            Xy.CLAVEMOV = DATOS("CLAVEmov")
            Xy.calcula()
            If DATOS("APLICAIVA") Then
                Xy.IVA = Math.Round(Xy.importe * (VARIABLE_IVA / 100), 2)
            Else
                Xy.IVA = 0
            End If
            totaldeudaotros += Xy.importe ' acumulado para el cierre
            totaldeudaiva += Xy.IVA
            Try
                Listadeconceptos.Add(Xy, "Renglon" & Xy.CLAVEMOV)
            Catch ex As Exception

            End Try


        End While
        x.conexion.Dispose()
    End Sub

    Public Sub calculavalvulista()
        Dim v As New Clsvalvulista
        Dim meses As Integer = desgloseconsumo.Count + desgloserezago.Count

        If meses > 0 Then
            v.id = valvulista
            v.nmeses = meses

            v.calcular()

            Dim con As New Clsconcepto
            con.Cantidad = v.nmeses
            con.Clave = My.Settings.clavevalvulista
            con.Concepto = "PAGO VALVULISTA"
            con.Preciounitario = v.Preciouni
            con.importe = v.Importe
            con.IVA = Math.Round(v.Importe * (VARIABLE_IVA / 100), 2)
            con.calcula()
            If con.importe > 0 Then
                Listadeconceptos.Add(con, "PAGO VALVULISTA")
            End If

        End If


    End Sub
End Class
