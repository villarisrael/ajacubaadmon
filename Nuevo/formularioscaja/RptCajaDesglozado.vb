﻿Imports System.IO
Imports iTextSharp.text
    Imports iTextSharp.text.pdf

    Public Class RptCajaDesglozado

        Dim Factura As Int64
        Dim Cuenta As Int64
        Dim Nombre As String
        Dim Subtotal As Decimal
        Dim IVA As Decimal
        Dim Total As Decimal
        Dim Status As String
        Dim Virtual As Decimal
        Dim DescPorcentaje As Double
        Dim DescPorcentaje50 As Double
        Dim DescPorcentaje100 As Double

        Dim executeSQL As IDataReader

        Dim SumaSubTotal As Decimal
        Dim SumaIVA As Decimal
        Dim SumaTotal As Decimal
        Dim SumaDescuento As Decimal
        Dim Cont As Int64 = 0
        Dim ContCanc As Int64 = 0
        Dim Recibo As Int64


        Dim totalGeneral As Decimal
        Dim fechaActual As String

        Dim TotaCDesc As Decimal

        Public Sub CorteDiario(ByVal sql As String, ByVal filtro As String, ByVal Caja As String, sqldescuento As String, sqlDescuentosRecargosP As String, sqlformapago As String)

            fechaActual = DateTime.Now.ToString("dd-MMM-yyyy").ToUpper()

            Try

                'Crear el directorio en donde se van a almacenar los PDF
                If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\ReporteCaja\" & Year(Now) & acompletacero(Month(Now).ToString(), 2).Trim) Then

                    My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\ReporteCaja\" & Year(Now) & acompletacero(Month(Now).ToString(), 2).Trim)
                End If

                Dim cadenafolder As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\ReporteCaja\" & Year(Now) & acompletacero(Month(Now).ToString(), 2)).Trim

                'Dar propiedades al Documento
                Dim pdfDoc As New Document(iTextSharp.text.PageSize.LETTER, 15.0F, 15.0F, 5.0F, 3.0F)

                'Obtener la ruta donde se va a crear el pdf
                Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(cadenafolder & "\CorteCaja_" & filtro & ".pdf", FileMode.Create))

                'Formato de letras
                Dim Font8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL))
                Dim Font5 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 5, iTextSharp.text.Font.NORMAL))
                Dim Font7 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 7, iTextSharp.text.Font.NORMAL))
                Dim Font4 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 4, iTextSharp.text.Font.NORMAL))
                Dim Font8N As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD))
                Dim Font13N As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 13, iTextSharp.text.Font.BOLD))
                Dim Font10N As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.BOLD))
                Dim Font12N As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.BOLD))
                Dim Font9 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 9, iTextSharp.text.Font.NORMAL))
                Dim Font7White As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 7, iTextSharp.text.Font.BOLD, BaseColor.WHITE))
                Dim Font8White As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE))
                Dim Font5White As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 5, iTextSharp.text.Font.BOLD, BaseColor.WHITE))
                Dim Font7courierN As New Font(FontFactory.GetFont(FontFactory.COURIER, 6, iTextSharp.text.Font.BOLD))

                'Abrimos el pdf para comenzar a escribir en el
                pdfDoc.Open()


#Region ""

                Dim imagenBMP As iTextSharp.text.Image
                imagenBMP = iTextSharp.text.Image.GetInstance(LOGOBYTE)
                imagenBMP.ScaleToFit(60.0F, 40.0F)

                imagenBMP.Border = 0

            Dim widthsRec As Single() = New Single() {50.0F, 50.0, 55.0F, 110.0F, 70.0F, 70.0F, 80.0F, 40.0F, 70.0F}
            Dim ColRecibo = New PdfPCell(New Phrase("", Font7White))


#End Region
            Dim TableVacio As PdfPTable = New PdfPTable(1)
            TableVacio.DefaultCell.Border = BorderStyle.None
            TableVacio.WidthPercentage = 100
            Dim widthsVacio As Single() = New Single() {1000.0F}
            TableVacio.SetWidths(widthsVacio)

            Dim widthsEncGen2 As Single() = New Single() {602.0F}
#Region "Encabezado"

            Try

                Dim ColVacio = New PdfPCell(New Phrase(" ", Font5White))
                ColVacio.Border = 0
                ColVacio.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                TableVacio.AddCell(ColVacio)


                Dim TableEncGeneral As PdfPTable = New PdfPTable(1)
                TableEncGeneral.DefaultCell.Border = BorderStyle.None
                TableEncGeneral.WidthPercentage = 100

                TableEncGeneral.SetWidths(widthsEncGen2)


                Dim ColPiePag1 = New PdfPCell(New Phrase("", Font5White))
                ColPiePag1.Border = 0
                ColPiePag1.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableEncGeneral.AddCell(ColPiePag1)


                Dim TableEnc2 As PdfPTable = New PdfPTable(2)
                TableEnc2.DefaultCell.Border = BorderStyle.None
                TableEnc2.WidthPercentage = 100
                Dim widthsEnc2 As Single() = New Single() {60.0F, 900.0F}
                TableEnc2.SetWidths(widthsEnc2)

                Dim Colimagen = New PdfPCell(imagenBMP)
                Colimagen.Border = 0
                Colimagen.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableEnc2.AddCell(Colimagen)


                ColPiePag1 = New PdfPCell(New Phrase(Empresa, Font10N))
                ColPiePag1.Border = 0
                ColPiePag1.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableEnc2.AddCell(ColPiePag1)



                ColPiePag1 = New PdfPCell(New Phrase("REPORTE DE INGRESOS POR RECIBO DESGLOZADO", Font10N))
                ColPiePag1.Border = 0
                ColPiePag1.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)



                TableEncGeneral.AddCell(TableEnc2)

                TableEncGeneral.AddCell(ColPiePag1)

                Dim TableEncFechas As PdfPTable = New PdfPTable(2)
                TableEncFechas.DefaultCell.Border = BorderStyle.None
                TableEncFechas.WidthPercentage = 100
                Dim widthsEncFec As Single() = New Single() {650.0F, 400.0F}
                TableEncFechas.SetWidths(widthsEncFec)

                If Caja = "" Then
                    Caja = "CORTE GENERAL"
                End If

                Dim ColEncFec = New PdfPCell(New Phrase("REPORTE DE INGRESOS DEL " & filtro & "            CAJA: " & Caja, Font8))
                ColEncFec.Border = 0
                ColEncFec.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableEncFechas.AddCell(ColEncFec)

                ColEncFec = New PdfPCell(New Phrase("FECHA DE EMISIÓN: " & fechaActual, Font8))
                ColEncFec.Border = 0
                ColEncFec.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableEncFechas.AddCell(ColEncFec)





#End Region




#Region "Tabla Recibos"


                Dim TableRecibosencabezado As PdfPTable = New PdfPTable(9)
                TableRecibosencabezado.DefaultCell.Border = BorderStyle.None
                TableRecibosencabezado.WidthPercentage = 100

                TableRecibosencabezado.SetWidths(widthsRec)

                ColRecibo = New PdfPCell(New Phrase("FACTURA", Font7White))
                ColRecibo.Border = 0
                ColRecibo.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                ColRecibo.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableRecibosencabezado.AddCell(ColRecibo)

                ColRecibo = New PdfPCell(New Phrase("RECIBO ", Font7White))
                ColRecibo.Border = 0
                ColRecibo.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                ColRecibo.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableRecibosencabezado.AddCell(ColRecibo)

                ColRecibo = New PdfPCell(New Phrase("CUENTA", Font7White))
                ColRecibo.Border = 0
                ColRecibo.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                ColRecibo.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableRecibosencabezado.AddCell(ColRecibo)

                ColRecibo = New PdfPCell(New Phrase("NOMBRE", Font7White))
                ColRecibo.Border = 0
                ColRecibo.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                ColRecibo.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableRecibosencabezado.AddCell(ColRecibo)

                ColRecibo = New PdfPCell(New Phrase("SUBTOTAL", Font7White))
                ColRecibo.Border = 0
                ColRecibo.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                ColRecibo.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableRecibosencabezado.AddCell(ColRecibo)

                ColRecibo = New PdfPCell(New Phrase("IVA", Font7White))
                ColRecibo.Border = 0
                ColRecibo.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                ColRecibo.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableRecibosencabezado.AddCell(ColRecibo)

                ColRecibo = New PdfPCell(New Phrase("TOTAL", Font7White))
                ColRecibo.Border = 0
                ColRecibo.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                ColRecibo.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableRecibosencabezado.AddCell(ColRecibo)

                ColRecibo = New PdfPCell(New Phrase("STATUS", Font7White))
                ColRecibo.Border = 0
                ColRecibo.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                ColRecibo.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableRecibosencabezado.AddCell(ColRecibo)

                ColRecibo = New PdfPCell(New Phrase("VIRTUAL", Font7White))
                ColRecibo.Border = 0
                ColRecibo.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                ColRecibo.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableRecibosencabezado.AddCell(ColRecibo)




                pdfDoc.Add(TableEncGeneral)
                pdfDoc.Add(TableVacio)
                pdfDoc.Add(TableVacio)
                pdfDoc.Add(TableVacio)
                pdfDoc.Add(TableEncFechas)
                pdfDoc.Add(TableRecibosencabezado)
            Catch ex As Exception
                MessageBox.Show("EN:" & ex.Message)
            End Try


            'CONSULTA

            executeSQL = ConsultaSql(sql).ExecuteReader






            While executeSQL.Read()

                Dim TableRecibos As PdfPTable = New PdfPTable(9)
                TableRecibos.DefaultCell.Border = BorderStyle.None
                TableRecibos.WidthPercentage = 100

                TableRecibos.SetWidths(widthsRec)

                Factura = executeSQL("facturado")
                Recibo = executeSQL("recibo")
                Cuenta = executeSQL("cuenta")
                    Nombre = executeSQL("Nombre")
                    Subtotal = executeSQL("pagos")
                    IVA = executeSQL("IVA")
                    Total = executeSQL("total")
                    Status = executeSQL("Cancelado")
                    Virtual = executeSQL("DescuentoPesos")
                    DescPorcentaje = executeSQL("descuento")



                    ColRecibo = New PdfPCell(New Phrase(Factura, Font7))
                    ColRecibo.Border = 1
                    ColRecibo.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                    'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                    TableRecibos.AddCell(ColRecibo)

                ColRecibo = New PdfPCell(New Phrase(executeSQL("serie") & Recibo, Font7))
                ColRecibo.Border = 1
                    ColRecibo.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                    'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                    TableRecibos.AddCell(ColRecibo)

                    ColRecibo = New PdfPCell(New Phrase(Cuenta, Font7))
                    ColRecibo.Border = 1
                    ColRecibo.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                    'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                    TableRecibos.AddCell(ColRecibo)

                    ColRecibo = New PdfPCell(New Phrase(Nombre, Font7))
                    ColRecibo.Border = 1
                    ColRecibo.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                    TableRecibos.AddCell(ColRecibo)

                    ColRecibo = New PdfPCell(New Phrase(Subtotal.ToString("C"), Font7))
                    ColRecibo.Border = 1
                    ColRecibo.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                    TableRecibos.AddCell(ColRecibo)

                    ColRecibo = New PdfPCell(New Phrase(IVA.ToString("C"), Font7))
                    ColRecibo.Border = 1
                    ColRecibo.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                    TableRecibos.AddCell(ColRecibo)

                    ColRecibo = New PdfPCell(New Phrase(Total.ToString("C"), Font7))
                    ColRecibo.Border = 1
                    ColRecibo.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                    TableRecibos.AddCell(ColRecibo)

                    ColRecibo = New PdfPCell(New Phrase(Status, Font7))
                    ColRecibo.Border = 1
                    ColRecibo.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                    'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                    TableRecibos.AddCell(ColRecibo)

                    If DescPorcentaje = 50 Or DescPorcentaje = 100 And Status = "A" Then
                        ColRecibo = New PdfPCell(New Phrase(Virtual.ToString("C"), Font7))
                        ColRecibo.Border = 1
                        ColRecibo.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                        'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                        TableRecibos.AddCell(ColRecibo)



                        SumaDescuento += Virtual


                        If DescPorcentaje = 50 Then
                            DescPorcentaje50 += Virtual
                        End If

                        If DescPorcentaje = 100 Then
                            DescPorcentaje100 += Virtual
                        End If

                    Else
                        ColRecibo = New PdfPCell(New Phrase("$0.00", Font7))
                        ColRecibo.Border = 1
                        ColRecibo.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                        'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                        TableRecibos.AddCell(ColRecibo)

                    End If

                    If Status = "A" Then
                        SumaSubTotal += Subtotal
                        SumaIVA += IVA
                        SumaTotal += Total

                    End If




                    Cont = Cont + 1

                    If Status = "C" Then
                        ContCanc = ContCanc + 1
                    End If

                pdfDoc.Add(TableRecibos)


                Try
                    Dim Tabledesgloze As PdfPTable = New PdfPTable(5)
                    Tabledesgloze.DefaultCell.Border = BorderStyle.None
                    Tabledesgloze.WidthPercentage = 80
                    Dim widthdesglozado As Single() = New Single() {60.0F, 200.0, 85.0F, 85.0F, 50.0F}
                    Tabledesgloze.SetWidths(widthdesglozado)

                    Dim datosrecibo = ConsultaSql("select * from pagotros where serie='" & executeSQL("serie") & "' and recibo=" & Recibo).ExecuteReader


                    Dim colcantidad = New PdfPCell(New Phrase("CANT,", Font7))
                    colcantidad.Border = 0
                    colcantidad.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                    'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                    Tabledesgloze.AddCell(colcantidad)

                    Dim colconcepto = New PdfPCell(New Phrase("CONCEPTO", Font7))
                    colconcepto.Border = 0
                    colconcepto.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                    Tabledesgloze.AddCell(colconcepto)

                    Dim colpc = New PdfPCell(New Phrase("P.U.", Font7))
                    colpc.Border = 0
                    colpc.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                    Tabledesgloze.AddCell(colpc)

                    Dim colimporte = New PdfPCell(New Phrase("IMPORTE", Font7))
                    colimporte.Border = 0
                    colimporte.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                    Tabledesgloze.AddCell(colimporte)

                    Dim coliva = New PdfPCell(New Phrase("IVA", Font7))
                    coliva.Border = 0
                    coliva.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                    Tabledesgloze.AddCell(coliva)


                    While datosrecibo.Read
                        colcantidad = New PdfPCell(New Phrase(datosrecibo("cantidad"), Font7))
                        colcantidad.Border = 0
                        colcantidad.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                        'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                        Tabledesgloze.AddCell(colcantidad)

                        colconcepto = New PdfPCell(New Phrase(datosrecibo("concepto"), Font7))
                        colconcepto.Border = 0
                        colconcepto.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                        'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                        Tabledesgloze.AddCell(colconcepto)

                        colpc = New PdfPCell(New Phrase(datosrecibo("Monto"), Font7))
                        colpc.Border = 0
                        colpc.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                        'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                        Tabledesgloze.AddCell(colpc)

                        colimporte = New PdfPCell(New Phrase(datosrecibo("Importe"), Font7))
                        colimporte.Border = 0
                        colimporte.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                        'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                        Tabledesgloze.AddCell(colimporte)

                        coliva = New PdfPCell(New Phrase(datosrecibo("MontoIVa"), Font7))
                        coliva.Border = 0
                        coliva.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                        'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                        Tabledesgloze.AddCell(coliva)


                    End While
                    Tabledesgloze.CompleteRow()
                    pdfDoc.Add(Tabledesgloze)
                Catch ex As Exception
                    MessageBox.Show("IR: " & ex.Message)
                End Try




            End While



            Dim TableTotales As PdfPTable = New PdfPTable(9)
            TableTotales.DefaultCell.Border = BorderStyle.None
                TableTotales.WidthPercentage = 100
                Dim widthsRecs As Single() = New Single() {70.0F, 65.0, 55.0F, 110.0F, 70.0F, 70.0F, 80.0F, 40.0F, 70.0F}
                TableTotales.SetWidths(widthsRecs)

                Dim ColTotal = New PdfPCell(New Phrase("", Font12N))
                ColTotal.Border = 1
                ColTotal.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableTotales.AddCell(ColTotal)

                ColTotal = New PdfPCell(New Phrase("", Font12N))
                ColTotal.Border = 1
                ColTotal.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableTotales.AddCell(ColTotal)

                ColTotal = New PdfPCell(New Phrase("", Font12N))
                ColTotal.Border = 1
                ColTotal.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableTotales.AddCell(ColTotal)

                ColTotal = New PdfPCell(New Phrase("TOTAL GENERAL ", Font12N))
                ColTotal.Border = 1
                ColTotal.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableTotales.AddCell(ColTotal)

                ColTotal = New PdfPCell(New Phrase(SumaSubTotal.ToString("C"), Font12N))
                ColTotal.Border = 1
                ColTotal.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableTotales.AddCell(ColTotal)

                ColTotal = New PdfPCell(New Phrase(SumaIVA.ToString("C"), Font12N))
                ColTotal.Border = 1
                ColTotal.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableTotales.AddCell(ColTotal)

                ColTotal = New PdfPCell(New Phrase(SumaTotal.ToString("C"), Font12N))
                ColTotal.Border = 1
                ColTotal.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableTotales.AddCell(ColTotal)

                ColTotal = New PdfPCell(New Phrase("", Font12N))
                ColTotal.Border = 1
                ColTotal.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableTotales.AddCell(ColTotal)

                ColTotal = New PdfPCell(New Phrase(SumaDescuento.ToString("C"), Font12N))
                ColTotal.Border = 1
                ColTotal.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableTotales.AddCell(ColTotal)


                totalGeneral = SumaTotal - SumaDescuento


            Dim TableRecibos2 As PdfPTable = New PdfPTable(9)
            TableRecibos2.DefaultCell.Border = BorderStyle.None
            TableRecibos2.WidthPercentage = 100

            TableRecibos2.SetWidths(widthsRec)


            ColRecibo = New PdfPCell(New Phrase("", Font7))
                ColRecibo.Border = 1
                ColRecibo.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
            TableRecibos2.AddCell(ColRecibo)

            ColRecibo = New PdfPCell(New Phrase("", Font7))
                ColRecibo.Border = 1
                ColRecibo.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
            TableRecibos2.AddCell(ColRecibo)

            ColRecibo = New PdfPCell(New Phrase("", Font7))
                ColRecibo.Border = 1
                ColRecibo.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
            TableRecibos2.AddCell(ColRecibo)

            ColRecibo = New PdfPCell(New Phrase(SumaSubTotal.ToString("C"), Font7))
                ColRecibo.Border = 1
                ColRecibo.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
            'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
            TableRecibos2.AddCell(ColRecibo)

            ColRecibo = New PdfPCell(New Phrase(SumaIVA.ToString("C"), Font7))
                ColRecibo.Border = 1
                ColRecibo.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
            'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
            TableRecibos2.AddCell(ColRecibo)

            ColRecibo = New PdfPCell(New Phrase(SumaTotal.ToString("C"), Font7))
                ColRecibo.Border = 1
                ColRecibo.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
            'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
            TableRecibos2.AddCell(ColRecibo)

            ColRecibo = New PdfPCell(New Phrase("", Font7))
                ColRecibo.Border = 1
                ColRecibo.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
            TableRecibos2.AddCell(ColRecibo)

            ColRecibo = New PdfPCell(New Phrase("", Font7))
                ColRecibo.Border = 1
                ColRecibo.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
            TableRecibos2.AddCell(ColRecibo)

#End Region




#Region "Table Totales y firmas"

            Dim nombreDirectorCaja As String = obtenerCampo("select * from empresa where codemp='1'", "Admin_Cajas")

                Dim TableRecibosTotal As PdfPTable = New PdfPTable(4)
                TableRecibosTotal.DefaultCell.Border = BorderStyle.None
                TableRecibosTotal.WidthPercentage = 100
                Dim widthsTot As Single() = New Single() {70.0F, 70.0F, 70.0F, 70.0F}
                TableRecibosTotal.SetWidths(widthsTot)

                Dim ColTotxRec = New PdfPCell(New Phrase("Recibos Totales: ", Font8))
                ColTotxRec.Border = 0
                ColTotxRec.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableRecibosTotal.AddCell(ColTotxRec)

                ColTotxRec = New PdfPCell(New Phrase(Cont, Font8))
                ColTotxRec.Border = 0
                ColTotxRec.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableRecibosTotal.AddCell(ColTotxRec)

                ColTotxRec = New PdfPCell(New Phrase("Recibos Cancelados: ", Font8))
                ColTotxRec.Border = 0
                ColTotxRec.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableRecibosTotal.AddCell(ColTotxRec)

                ColTotxRec = New PdfPCell(New Phrase(ContCanc, Font8))
                ColTotxRec.Border = 0
                ColTotxRec.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableRecibosTotal.AddCell(ColTotxRec)



                Dim TableFirmas As PdfPTable = New PdfPTable(5)
                TableFirmas.DefaultCell.Border = BorderStyle.None
                TableFirmas.WidthPercentage = 100
                Dim widthsTotxRec As Single() = New Single() {70.0F, 400.0F, 20.0F, 400.0F, 70.0F}
                TableFirmas.SetWidths(widthsTotxRec)

                Dim ColFirm = New PdfPCell(New Phrase(" ", Font5White))
                ColFirm.Border = 0
                ColFirm.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableFirmas.AddCell(ColFirm)

            ColFirm = New PdfPCell(New Phrase("Administracion", Font8))
            ColFirm.Border = 1
                ColFirm.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableFirmas.AddCell(ColFirm)

                ColFirm = New PdfPCell(New Phrase(" ", Font5White))
                ColFirm.Border = 0
                ColFirm.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableFirmas.AddCell(ColFirm)

                ColFirm = New PdfPCell(New Phrase(nombreDirectorCaja, Font8))
                ColFirm.Border = 1
                ColFirm.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableFirmas.AddCell(ColFirm)

                ColFirm = New PdfPCell(New Phrase(" ", Font5White))
                ColFirm.Border = 0
                ColFirm.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                TableFirmas.AddCell(ColFirm)






                'Actopan
                '30,3,4,5


                Dim Tabletitdescuentos As PdfPTable = New PdfPTable(1)
                Tabletitdescuentos.DefaultCell.Border = BorderStyle.None
            Tabletitdescuentos.WidthPercentage = 100

            Tabletitdescuentos.SetWidths(widthsEncGen2)


                Dim ColPiePag1d = New PdfPCell(New Phrase("AGRUPAMIENTO POR DESCUENTO", Font10N))
                ColPiePag1d.Border = 0
                ColPiePag1d.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)



                Tabletitdescuentos.AddCell(ColPiePag1d)






                executeSQL = ConsultaSql(sqldescuento).ExecuteReader
                Dim TableDescuentos As PdfPTable = New PdfPTable(4)
                TableDescuentos.DefaultCell.Border = BorderStyle.None
                TableDescuentos.WidthPercentage = 100
                Dim widthsDesc As Single() = New Single() {250.0F, 250.0F, 250.0F, 250.0F}
                TableDescuentos.SetWidths(widthsDesc)

                Do While executeSQL.Read

                    Dim cuantos As Decimal = Decimal.Parse(executeSQL("cuantos"))
                    Dim virtu As Decimal = Decimal.Parse(executeSQL("virtuales"))
                    Dim descu As String = executeSQL("descuento").ToString()

                    If descu = "5" Or descu = "10" Or descu = "50" Or descu = "100" Then ' A petición de la directora Yoseline, solo mostrar descuentos del 5, 10, 50 y 100% 14/09/2022


                        If virtu > 0 Then

                            Dim ColDesc = New PdfPCell(New Phrase(cuantos & " descuentos del: ", Font8))
                            ColDesc.Border = 0
                            ColDesc.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                            'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                            TableDescuentos.AddCell(ColDesc)

                            TotaCDesc = SumaTotal + SumaDescuento

                            ColDesc = New PdfPCell(New Phrase(descu & "%", Font8))
                            ColDesc.Border = 0
                            ColDesc.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                            'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                            TableDescuentos.AddCell(ColDesc)

                            ColDesc = New PdfPCell(New Phrase("Total : ", Font8))
                            ColDesc.Border = 0
                            ColDesc.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                            'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                            TableDescuentos.AddCell(ColDesc)

                            TotaCDesc = TotaCDesc - SumaDescuento
                            ColDesc = New PdfPCell(New Phrase(virtu.ToString("C"), Font8))
                            ColDesc.Border = 0
                            ColDesc.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                            'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                            TableDescuentos.AddCell(ColDesc)
                        End If

                    End If

                Loop


                Dim TabletitFROMAPAGO As PdfPTable = New PdfPTable(1)
                TabletitFROMAPAGO.DefaultCell.Border = BorderStyle.None
                TabletitFROMAPAGO.WidthPercentage = 100

                TabletitFROMAPAGO.SetWidths(widthsEncGen2)


                Dim ColPiePag1FP = New PdfPCell(New Phrase("AGRUPAMIENTO POR FORMA DE PAGO", Font10N))
                ColPiePag1FP.Border = 0
                ColPiePag1FP.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)



                TabletitFROMAPAGO.AddCell(ColPiePag1FP)






                executeSQL = ConsultaSql(sqlformapago).ExecuteReader

                Dim Tableformapago As PdfPTable = New PdfPTable(4)
                Tableformapago.DefaultCell.Border = BorderStyle.None
                Tableformapago.WidthPercentage = 100
                Dim widthsfp As Single() = New Single() {250.0F, 250.0F, 250.0F, 250.0F}
                Tableformapago.SetWidths(widthsDesc)

                Do While executeSQL.Read

                    Dim cuantos As Decimal = Decimal.Parse(executeSQL("cuantos"))
                    Dim ccodpago As String = executeSQL("ccodpago")
                    Dim descu As Decimal = executeSQL("Total").ToString()



                    Dim fp As String = obtenerCampo("select * from fpago where ccodpago='" & ccodpago & "'", "CDESPAGO")

                    Dim ColDesc = New PdfPCell(New Phrase(cuantos & " pagos de " & fp & " ", Font8))
                    ColDesc.Border = 0
                    ColDesc.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                    Tableformapago.AddCell(ColDesc)

                    TotaCDesc = SumaTotal + SumaDescuento

                    ColDesc = New PdfPCell(New Phrase(descu, Font8))
                    ColDesc.Border = 0
                    ColDesc.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                    Tableformapago.AddCell(ColDesc)

                    ColDesc = New PdfPCell(New Phrase("Total : ", Font8))
                    ColDesc.Border = 0
                    ColDesc.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                    Tableformapago.AddCell(ColDesc)

                    TotaCDesc = TotaCDesc - SumaDescuento
                    ColDesc = New PdfPCell(New Phrase(descu.ToString("C"), Font8))
                    ColDesc.Border = 0
                    ColDesc.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
                    Tableformapago.AddCell(ColDesc)




                Loop




#End Region



            pdfDoc.Add(TableTotales)
                pdfDoc.Add(TableVacio)
                pdfDoc.Add(TableVacio)
                pdfDoc.Add(TableVacio)
                pdfDoc.Add(TableRecibosTotal)
                pdfDoc.Add(TableVacio)
                pdfDoc.Add(TableVacio)
                pdfDoc.Add(TableVacio)
                pdfDoc.Add(TableVacio)
                pdfDoc.Add(TableVacio)
                pdfDoc.Add(TableVacio)
                pdfDoc.Add(TableVacio)
                pdfDoc.Add(TableFirmas)
                pdfDoc.Add(TableVacio)
                pdfDoc.Add(TableVacio)
                pdfDoc.Add(Tabletitdescuentos)
                pdfDoc.Add(TableVacio)
                pdfDoc.Add(TableDescuentos)

                pdfDoc.Add(TableVacio)
                pdfDoc.Add(TableVacio)
                pdfDoc.Add(TabletitFROMAPAGO)
                pdfDoc.Add(TableVacio)
                pdfDoc.Add(Tableformapago)
                'pdfDoc.Add(TableDescuentosRecargos)

                pdfDoc.Close()

                'Ejecucion("update empresa set foliofactura = " & foliofactura & "")

                Try
                    Dim psi As New ProcessStartInfo(cadenafolder & "\CorteCaja_" & filtro & ".pdf")
                    'psi.WorkingDirectory = cadenafolder & "\factura\" + nombresespacios

                    psi.WindowStyle = ProcessWindowStyle.Hidden
                    Dim p As Process = Process.Start(psi)
                Catch ex As Exception
                    MessageBox.Show("Error al visualizar el pdf, posiblemente el archivo este en uso, cierrelo antes de generar un nuevo reporte" & ex.Message)
                End Try

            Catch ex As Exception
                MessageBox.Show("Error al generar el reporte: " & ex.Message)
            End Try

        End Sub


    End Class


