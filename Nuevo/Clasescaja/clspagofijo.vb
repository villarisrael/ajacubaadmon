﻿Imports System.Data.Odbc
Public Class clspagofijo
    Public fechainicial As Date = Now()
    Public fechafinal As Date = Now()
    Public montopago As Double = 0
    Public montopagorezago As Double = 0
    Public pagocondescuento As Double = 0
    Public pagocondescuentorezago As Double = 0
    'Public tarifa As Integer = 1
    Public tarifa As String
    Public collection As New Collection
    Public collectionconsumo As New Collection
    Public collectionrezago As New Collection
    Public cuo As New clscuota
    Public pordescuento As Double = 0
    Public periodoscondescuento As Integer = 0

    Public descontartodoslosperiodos As Boolean = False
    Public periodosadeudados As Integer
    Public pagodeiva As Double = 0
    Public llevaiva As Boolean

    Dim posicioninicialconsumo As Integer = -1
    Public Periodoconsumo As String = ""
    Public PeriodoRezago As String = ""
    Public totaldedescuentopesos As Decimal = 0

    Public Function restainicial() As Integer
        Dim numeromes As Integer
        numeromes = fechainicial.Month
        Return 12 - numeromes
    End Function
    Public Function restafinal() As Integer
        Return fechafinal.Month

    End Function

    Public Sub calculapago()

        Try
            If fechainicial > fechafinal Then
                montopago = 0
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        Dim meses As Integer = 0
        Try
            meses = DateDiff(DateInterval.Month, fechainicial, fechafinal)
            'MessageBox.Show(meses)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        periodosadeudados = meses

        If descontartodoslosperiodos = True Then
            periodoscondescuento = meses
        End If

        cuo.llena(tarifa)

        Dim contadormeses As Integer = Month(fechainicial)
        Dim contadorperiodos As Integer = Year(fechainicial)
        Dim trabajoconfecha As New clsfechas
        Dim acumulador As Double = 0
        Dim acumuladorcondescuento As Double = 0
        Dim acumuladorrezago As Double = 0
        Dim acumuladorcondescuentorezago As Double = 0
        Dim funcionesf As New clsfechas


        contadormeses += 1
        Dim vane As Boolean = True
        Dim cadenacomodin As String

        Dim llevaconsumo As Boolean = False
        Dim llevarezago As Boolean = False

        For i = meses - 1 To 0 Step -1

            If contadormeses = 13 Then
                contadormeses = 1
                contadorperiodos = contadorperiodos + 1
            End If

            If vane Then
                cadenacomodin = trabajoconfecha.valorcadenames(contadormeses) & " " & contadorperiodos
                vane = False
            End If
            Dim objeto As New clsunidadmes
            objeto.numerodemes = i

            objeto.cuota = cuo.cuotas(contadorperiodos)
            objeto.mes = trabajoconfecha.valorcadenames(contadormeses)
            objeto.periodo = contadorperiodos
            'objeto.total = cuo.cuotas(contadorperiodos)




            '28/10/2021 ISRAEL VILLAR, UZIEL MÁRQUEZ
            'Quita el descuento a pensionados fijos y lo cobra como domestico fijo

            If tarifa = "22" Then ' si la tarifa es pensionado fijo la conbra al doble por que le quita el descuento la cobra como tarifa 19
                Dim normal As New clscuota
                normal.llena("19")
                objeto.total = cuo.cuotas(contadorperiodos)
                If contadorperiodos < Now.Year Then
                    objeto.total = normal.cuotas(contadorperiodos)
                End If
                If contadorperiodos = Now.Year And contadormeses < Now.Month Then
                    objeto.total = normal.cuotas(contadorperiodos)
                End If
                If contadorperiodos = Now.Year And contadormeses >= Now.Month Then
                    objeto.total = cuo.cuotas(contadorperiodos)
                End If


            Else

                objeto.total = cuo.cuotas(contadorperiodos)
            End If



            If i < periodoscondescuento Then
                If pordescuento > 0 Then
                    objeto.descuento = objeto.total * (pordescuento / 100)
                    objeto.totalcondescuento = objeto.total - objeto.descuento
                End If
            Else
                objeto.descuento = 0
                objeto.totalcondescuento = objeto.total

            End If

            If llevaiva Then
                objeto.coniva()
            Else
                objeto.siniva()
            End If

            pagodeiva = pagodeiva + objeto.totaliva


            If contadorperiodos = Year(Now) Then
                objeto.tipo = "CONSUMO"
                acumulador = acumulador + objeto.total
                acumuladorcondescuento = acumuladorcondescuento + objeto.totalcondescuento
                If llevaconsumo = False Then
                    posicioninicialconsumo = i
                End If
                llevaconsumo = True
                Periodoconsumo = "-" & objeto.mes & " " & contadorperiodos
                collectionconsumo.Add(objeto)
            Else
                llevarezago = True

                objeto.tipo = "REZAGO"
                acumuladorrezago += objeto.total
                acumuladorcondescuentorezago += objeto.totalcondescuento
                PeriodoRezago = cadenacomodin & "-" & objeto.mes & " " & contadorperiodos
                collectionrezago.Add(objeto)
            End If

            collection.Add(objeto, i)
            contadormeses = contadormeses + 1

        Next

        If llevaconsumo Then
            Dim objeto As clsunidadmes
            objeto = collection.Item(collection.Count - posicioninicialconsumo)
            Periodoconsumo = objeto.mes & " " & objeto.periodo & Periodoconsumo
        End If

        pagocondescuento = Math.Round(acumuladorcondescuento, 2)
        montopago = Math.Round(acumulador, 2)
        pagocondescuentorezago = Math.Round(acumuladorcondescuentorezago, 2)
        montopagorezago = Math.Round(acumuladorrezago, 2)



    End Sub


End Class

