Imports DevComponents.DotNetBar

Public Class Estadistica
    Public TOTALrubrosCONSUMO As Decimal = 1
    Private Sub Estadistica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datos As Odbc.OdbcDataReader = ConsultaSql("select * from temborrala2 order by id").ExecuteReader

        While datos.Read()

            Dim concepto As String = datos("CONCEPTO")
            Dim QUETIPODENODO As String = datos("NODO")
            Dim quetipodevalor As String = datos("TIPO")
            Dim valor As Decimal = datos("valor")
            If QUETIPODENODO = "NODO 1" Then
                datapadron.Rows.Add(concepto, "", "", celda(quetipodevalor, valor))
            End If
            If QUETIPODENODO = "NODO 2" Then
                datapadron.Rows.Add("", "", "", "")
                datapadron.Rows.Add(concepto, "", celda(quetipodevalor, valor), "")
            End If
            If QUETIPODENODO = "NODO 3" Then
                datapadron.Rows.Add("   " & concepto, celda(quetipodevalor, valor), "", "")
            End If

        End While

        Dim datosingresofecha As Odbc.OdbcDataReader = ConsultaSql("select * from temborrala3 order by id").ExecuteReader

        While datosingresofecha.Read()

            Dim concepto As String = datosingresofecha("CONCEPTO")
            Dim QUETIPODENODO As String = datosingresofecha("NODO")
            Dim quetipodevalor As String = datosingresofecha("TIPO")
            Dim valor As Decimal = datosingresofecha("valor")
            If QUETIPODENODO = "NODO 1" Then
                dataingresofecha.Rows.Add(concepto, "", "", celda(quetipodevalor, valor))
            End If
            If QUETIPODENODO = "NODO 2" Then
                dataingresofecha.Rows.Add("", "", "", "")
                dataingresofecha.Rows.Add(concepto, "", celda(quetipodevalor, valor), "")
            End If
            If QUETIPODENODO = "NODO 3" Then
                dataingresofecha.Rows.Add("   " & concepto, celda(quetipodevalor, valor), "", "")
            End If
        End While


        Dim datosano As Odbc.OdbcDataReader = ConsultaSql("select * from temborralaconsumom order by id").ExecuteReader

        While datosano.Read()

            Dim concepto As String = datosano("CONCEPTO")
            Dim QUETIPODENODO As String = datosano("NODO")
            Dim quetipodevalor As String = datosano("TIPO")
            Dim valor As Decimal = datosano("valor")
            If QUETIPODENODO = "NODO 1" Then
                dataconsumo.Rows.Add(concepto, "", "", celda(quetipodevalor, valor))
            End If
            If QUETIPODENODO = "NODO 2" Then
                dataconsumo.Rows.Add("", "", "", "")
                dataconsumo.Rows.Add(concepto, "", celda(quetipodevalor, valor), "")
            End If
            If QUETIPODENODO = "NODO 3" Then
                dataconsumo.Rows.Add("   " & concepto, celda(quetipodevalor, valor), "", "")
            End If
        End While

        Dim datoXR As Odbc.OdbcDataReader = ConsultaSql("select * from temborrala4 order by id").ExecuteReader

        While datoXR.Read()

            Dim concepto As String = datoXR("CONCEPTO")
            Dim QUETIPODENODO As String = datoXR("NODO")
            Dim quetipodevalor As String = datoXR("TIPO")
            Dim valor As Decimal = datoXR("valor")
            If QUETIPODENODO = "NODO 1" Then
                dataporrubros.Rows.Add(concepto, "", "", celda(quetipodevalor, valor))
            End If
            If QUETIPODENODO = "NODO 2" Then
                dataporrubros.Rows.Add("", "", "", "")
                dataporrubros.Rows.Add(concepto, "", celda(quetipodevalor, valor), "")
            End If
            If QUETIPODENODO = "NODO 3" Then
                dataporrubros.Rows.Add("   " & concepto, celda(quetipodevalor, valor), "", "")
            End If
        End While

        Try
            Dim datosreca As Odbc.OdbcDataReader = ConsultaSql("select  tipos_usuarios.DESCRIPCION AS DESCr,count( cuenta) As cuantos, If (medido=1,""MEDIDO"",""FIJO"") As TIPO from borralacuentas2 inner join tipos_usuarios On borralacuentas2.parauso=tipos_usuarios.ID_TIPO_USUARIO group by borralacuentas2.parauso,MEDIDO").ExecuteReader
            datarevstipo.Rows.Add("PERSONAS QUE PAGARON EN EL PERIODO", "", "")
            datarevstipo.Rows.Add("", "", "")
            Do While datosreca.Read
                Try
                    datarevstipo.Rows.Add(datosreca("DESCr"), datosreca("CUANTOS"), datosreca("TIPO"))
                Catch ex As Exception

                End Try
            Loop

        Catch ex As Exception

        End Try

        Try

            Dim datosrecarango As Odbc.OdbcDataReader = ConsultaSql("select * from borralacuentas5").ExecuteReader
            Dtgpadronreca.Rows.Add("", "", "", "", "")
            Dtgpadronreca.Rows.Add("PERSONAS QUE PAGARON POR RANGO DE CONSUMO", "", "", "")
            Dtgpadronreca.Rows.Add("", "", "", "")
            Dtgpadronreca.Rows.Add("", "0 - 50 M3", "50.1 -100 M3", "100-ADELANTE")
            Do While datosrecarango.Read
                Try
                    Dtgpadronreca.Rows.Add(datosrecarango(0).ToString(), Math.Round(datosrecarango(1), 2), Math.Round(datosrecarango(2), 2), Math.Round(datosrecarango(3), 2))
                Catch ex As Exception

                End Try
            Loop

        Catch ex As Exception

        End Try
        ''''''''''''''consumo'''''''''''''''''''
        Try
            Dim datoc As Odbc.OdbcDataReader = ConsultaSql("select * from temconsumoTotal").ExecuteReader

            While datoc.Read()

                Dim concepto As String

                Try
                    concepto = datoc("Tipouso")
                Catch ex As Exception
                    concepto = ""
                End Try
                Dim QUETIPODENODO As String
                Try
                    QUETIPODENODO = datoc("NODO")
                Catch ex As Exception
                    QUETIPODENODO = ""
                End Try



                Dim quetipodevalor As Integer

                Try
                    quetipodevalor = datoc("Consumo")
                Catch ex As Exception
                    quetipodevalor = 0
                End Try

                Dim valor As String
                Dim monto As Decimal
                Try
                    valor = datoc("cantidad")
                Catch ex As Exception
                    valor = "0.00"
                End Try
                Try
                    monto = datoc("montoconsumo")
                Catch ex As Exception
                    monto = "0.00"
                End Try

                If QUETIPODENODO = "NODO 1" And concepto = "INDUSTRIAL" Then
                    dataConsumom3.Rows.Add("", "", "", "")
                    dataConsumom3.Rows.Add("De 1-50", "", "", "")
                    dataConsumom3.Rows.Add("", "", "", "")
                    dataConsumom3.Rows.Add(concepto, "", quetipodevalor, monto)
                End If
                If QUETIPODENODO = "NODO 3" And concepto = "INDUSTRIAL" Then
                    dataConsumom3.Rows.Add("", "", "", "")
                    dataConsumom3.Rows.Add("De 50-100", "", "", "")
                    dataConsumom3.Rows.Add("", "", "", "")
                    dataConsumom3.Rows.Add(concepto, "", quetipodevalor, monto)
                End If
                If QUETIPODENODO = "NODO 4" And concepto = "INDUSTRIAL" Then
                    dataConsumom3.Rows.Add("", "", "", "")
                    dataConsumom3.Rows.Add("Más de 100...", "", "", "")
                    dataConsumom3.Rows.Add("", "", "", "")
                    dataConsumom3.Rows.Add(concepto, "", quetipodevalor, monto)
                End If
                If QUETIPODENODO = "NODO 2" Then
                    dataConsumom3.Rows.Add(concepto, "", quetipodevalor, monto)
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function celda(tipo As String, valor As Decimal) As String
        Dim ETIQUETA As New LabelX
        Dim CELDAcreada As New DevComponents.AdvTree.Cell
        If tipo = "SIN VALOR" Then
            ETIQUETA.Text = ""
        End If
        If tipo = "VALOR ENTERO" Then
            ETIQUETA.Text = Math.Truncate(valor)
            ETIQUETA.TextAlignment = StringAlignment.Far
            ETIQUETA.ForeColor = Color.Blue
        End If
        If tipo = "CADENA" Then
            ETIQUETA.Text = valor
            ETIQUETA.TextAlignment = StringAlignment.Near
            ETIQUETA.ForeColor = Color.Black
        End If
        If tipo = "MONEDA" Then
            ETIQUETA.Text = valor.ToString("C")
            ETIQUETA.TextAlignment = StringAlignment.Far
            ETIQUETA.ForeColor = Color.DarkBlue
        End If
        Return ETIQUETA.Text
    End Function

    Private Sub imprimirEs_Click(sender As Object, e As EventArgs) Handles imprimirEs.Click

        Dim imp As New Imprimirnet
        Dim ali As Lineaimprimir.alineacion
        Dim impresora As String = ""
        impresora = imp.prtSettings.PrinterName
        Dim nombredeempresa = obtenerCampo("select * from empresa limit 1", "cnombre")
        imp.imprimir(430, 20, nombredeempresa, ali.Centrado, "ARIAL", 11)
        Dim po = obtenerCampo("select * from empresa limit 1", "cdomicilio")
        imp.imprimir(50, 40, po, ali.Izquierda, "ARIAL", 10)
        Dim texto As String = "Estadística de padrón de usuarios"
        imp.imprimir(500, 60, texto, ali.Centrado, "ARIAL", 11)
        Dim linea As Int16 = 95
        Dim altofila As Int16 = 15
        For i As Int16 = 0 To datapadron.RowCount - 1
            Dim celda1 As String = datapadron.Rows(i).Cells(0).Value
            imp.imprimir(50, linea, celda1, ali.Izquierda, "ARIAL", 8)
            Dim celda2 As String = datapadron.Rows(i).Cells(1).Value
            imp.imprimir(500, linea, celda2, ali.Centrado, "ARIAL", 8)
            Dim celda3 As String = datapadron.Rows(i).Cells(3).Value
            imp.imprimir(650, linea, celda3, ali.Centrado, "ARIAL", 10)
            linea += altofila
        Next
        imp.mandardocumento(False)

    End Sub

    Private Sub btntc_Click(sender As Object, e As EventArgs) Handles btntc.Click

        Dim imp As New Imprimirnet
        Dim ali As Lineaimprimir.alineacion
        Dim impresora As String = ""
        impresora = imp.prtSettings.PrinterName
        Dim nombredeempresa = obtenerCampo("select * from empresa limit 1", "cnombre")
        imp.imprimir(430, 20, nombredeempresa, ali.Centrado, "ARIAL", 12)
        Dim po = obtenerCampo("select * from empresa limit 1", "cdomicilio")
        imp.imprimir(50, 40, po, ali.Izquierda, "ARIAL", 10)
        Dim texto As String = "Estadística de Tarifa vs Consumo"
        imp.imprimir(300, 60, texto, ali.Centrado, "ARIAL", 11)
        Dim linea As Int16 = 95
        Dim altofila As Int16 = 15
        For i As Int16 = 0 To dataconsumo.RowCount - 1
            Dim celda1 As String = dataconsumo.Rows(i).Cells(0).Value
            'celda1 = celda1.Substring(1, 70)
            imp.imprimir(50, linea, celda1, ali.Izquierda, "ARIAL", 8)
            Dim celda2 As String = dataconsumo.Rows(i).Cells(1).Value
            imp.imprimir(500, linea, celda2, ali.Centrado, "ARIAL", 8)
            Dim celda3 As String = dataconsumo.Rows(i).Cells(2).Value
            imp.imprimir(600, linea, celda3, ali.Centrado, "ARIAL", 10)
            Dim celda4 As String = dataconsumo.Rows(i).Cells(3).Value
            imp.imprimir(700, linea, celda4, ali.Centrado, "ARIAL", 10)
            linea += altofila
        Next
        imp.mandardocumento(False)

    End Sub

    Private Sub btni_Click(sender As Object, e As EventArgs) Handles btni.Click

        Dim imp As New Imprimirnet
        Dim ali As Lineaimprimir.alineacion
        Dim impresora As String = ""
        impresora = imp.prtSettings.PrinterName
        Dim nombredeempresa = obtenerCampo("select * from empresa limit 1", "cnombre")
        imp.imprimir(430, 20, nombredeempresa, ali.Centrado, "ARIAL", 12)
        Dim po = obtenerCampo("select * from empresa limit 1", "cdomicilio")
        imp.imprimir(50, 40, po, ali.Izquierda, "ARIAL", 10)
        Dim texto As String = "Estadística de Resumen de Ingresos"
        imp.imprimir(300, 60, texto, ali.Centrado, "ARIAL", 11)
        Dim linea As Int16 = 95
        Dim altofila As Int16 = 15
        For i As Int16 = 0 To dataingresofecha.RowCount - 1
            Dim celda1 As String = dataingresofecha.Rows(i).Cells(0).Value
            imp.imprimir(50, linea, celda1, ali.Izquierda, "ARIAL", 8)
            Dim celda2 As String = dataingresofecha.Rows(i).Cells(1).Value
            imp.imprimir(500, linea, celda2, ali.Centrado, "ARIAL", 8)
            Dim celda3 As String = dataingresofecha.Rows(i).Cells(3).Value
            imp.imprimir(650, linea, celda3, ali.Centrado, "ARIAL", 8)
            linea += altofila
        Next
        imp.mandardocumento(False)

    End Sub

    Private Sub btnr_Click(sender As Object, e As EventArgs) Handles btnr.Click

        Dim imp As New Imprimirnet
        Dim ali As Lineaimprimir.alineacion
        Dim impresora As String = ""
        impresora = imp.prtSettings.PrinterName
        Dim nombredeempresa = obtenerCampo("select * from empresa limit 1", "cnombre")
        imp.imprimir(430, 20, nombredeempresa, ali.Centrado, "ARIAL", 12)
        Dim po = obtenerCampo("select * from empresa limit 1", "cdomicilio")
        imp.imprimir(50, 40, po, ali.Izquierda, "ARIAL", 10)
        Dim texto As String = "Estadística de Ingresos vs Consumo"
        imp.imprimir(300, 60, texto, ali.Centrado, "ARIAL", 11)
        Dim linea As Int16 = 95
        Dim altofila As Int16 = 15
        For i As Int16 = 0 To dataporrubros.RowCount - 1
            Dim celda1 As String = dataporrubros.Rows(i).Cells(0).Value
            celda1 = celda1.Substring(1, 50)
            imp.imprimir(50, linea, celda1, ali.Izquierda, "ARIAL", 8)
            Dim celda2 As String = dataporrubros.Rows(i).Cells(1).Value
            imp.imprimir(500, linea, celda2, ali.Centrado, "ARIAL", 8)
            Dim celda3 As String = dataporrubros.Rows(i).Cells(3).Value
            imp.imprimir(650, linea, celda3, ali.Centrado, "ARIAL", 10)
            linea += altofila
        Next
        imp.mandardocumento(False)

    End Sub

    Private Sub btnpr_Click(sender As Object, e As EventArgs) Handles btnpr.Click

        Dim imp As New Imprimirnet
        Dim ali As Lineaimprimir.alineacion
        Dim impresora As String = ""
        impresora = imp.prtSettings.PrinterName
        Dim nombredeempresa = obtenerCampo("select * from empresa limit 1", "cnombre")
        imp.imprimir(430, 20, nombredeempresa, ali.Centrado, "ARIAL", 12)
        Dim po = obtenerCampo("select * from empresa limit 1", "cdomicilio")
        imp.imprimir(50, 40, po, ali.Izquierda, "ARIAL", 10)
        Dim texto As String = "Estadística de Padrón vs Recaudación"
        imp.imprimir(300, 60, texto, ali.Centrado, "ARIAL", 11)
        Dim linea As Int16 = 95
        Dim altofila As Int16 = 15
        For i As Int16 = 0 To datarevstipo.RowCount - 1
            Dim celda1 As String = datarevstipo.Rows(i).Cells(0).Value
            imp.imprimir(50, linea, celda1, ali.Izquierda, "ARIAL", 8)
            linea += altofila
            Dim celda2 As String = datarevstipo.Rows(i).Cells(1).Value
            imp.imprimir(300, linea, celda2, ali.Centrado, "ARIAL", 8)
            Dim celda3 As String = datarevstipo.Rows(i).Cells(2).Value
            imp.imprimir(600, linea, celda3, ali.Centrado, "ARIAL", 8)
        Next
        imp.mandardocumento(False)

    End Sub

    'Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
    '    Dim renglones As Integer = dataingresofecha.RowCount - 2
    '    Dim datos(renglones) As Double

    '    For i As Int16 = 1 To dataingresofecha.RowCount - 2
    '        Dim celda As Integer
    '        Try
    '            celda = CInt(dataingresofecha.Rows(i).Cells(1).Value)
    '        Catch ex As Exception
    '            celda = 0
    '        End Try

    '        '   MsgBox(celda)

    '        Try
    '            Dim cc As Double
    '            If IsNumeric(celda) Then
    '                cc = celda
    '            End If
    '            datos(i) = cc
    '            'Dim nombre As String = Convert.ToString(dataingresofecha.CurrentRow.Cells(1).Value)
    '            'MsgBox(nombre)

    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try

    '    Next
    '    'Dim arreglo As Double = CDbl()

    '    MicroChart1.DataPoints = New List(Of Double)(datos)
    '    MicroChart1.DataPointTooltips = New List(Of String)(New String() {"Hola: {0}", "adios{0}"})
    '    MicroChart1.Text = "Profit:"
    '    MicroChart1.ChartType = eMicroChartType.Line
    '    'grafica.Series(0).Points.Clear()
    '    'grafica.Series(0).XValueMember = "Ingreso"
    '    'grafica.Series(0).YValueMembers = "Valor"
    '    'grafica.DataSource = dataingresofecha

    '    'Try
    '    '    Dim dt As New DataTable
    '    '    dt.Columns.Add("ingreso", Type.GetType("System.String"))
    '    '    dt.Columns.Add("Valor", Type.GetType("System.String"))

    '    '    For Each row As DataGridViewRow In dataingresofecha.Rows

    '    '        Dim newrow As DataRow = dt.NewRow()
    '    '        newrow("ingreso") = Convert.ToString(row.Cells(0).Value)
    '    '        newrow("Valor") = Convert.ToString(row.Cells(1).Value)

    '    '        dt.Rows.Add(newrow)
    '    '    Next
    '    '    grafica.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
    '    '    grafica.DataSource = dt
    '    'Catch ex As Exception
    '    '    MsgBox(ex.Message)
    '    'End Try


    '    'MicroChart1.TextPosition = eMicroChartTextPosition.Left
    'End Sub

    'Private Sub TabItem4_Click(sender As Object, e As EventArgs) Handles TabItem4.Click

    '    grafica.Series(0).Points.Clear()
    '    grafica.Series(0).XValueMember = "Ingreso"
    '    grafica.Series(0).YValueMembers = "Valor"

    '    grafica.DataSource = dataingresofecha

    '    Try
    '        Dim dt As New DataTable
    '        dt.Columns.Add("ingreso", Type.GetType("System.String"))
    '        dt.Columns.Add("Valor", Type.GetType("System.String"))

    '        'For Each row As DataGridViewRow In dataingresofecha.Rows
    '        For i As Integer = 1 To (dataingresofecha.RowCount - 2)
    '            Dim newrow As DataRow = dt.NewRow()
    '            newrow("ingreso") = Convert.ToString(dataingresofecha.Rows(i).Cells(0).Value)
    '            newrow("Valor") = Convert.ToString(dataingresofecha.Rows(i).Cells(1).Value)

    '            dt.Rows.Add(newrow)
    '        Next
    '        grafica.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
    '        grafica.DataSource = dt
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

End Class