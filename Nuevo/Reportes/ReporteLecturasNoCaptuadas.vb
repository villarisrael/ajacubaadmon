Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class ReporteLecturasNoCaptuadas


    Public Sub GenerarReporteLecturasNoCapturadas(ByVal sql As String, ByVal Titulo As String)



        Try

            Dim datosDeudores As IDataReader = ConsultaSql(sql).ExecuteReader()

            Dim Fecha As String
            'Dim stringrandom As String = RandomString(5, True)


            Dim obj As New Random()
            Dim posibles As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
            Dim longitud As Integer = posibles.Length
            Dim letra As Char
            Dim longitudnuevacadena As Integer = 1
            Dim nuevaLetra As String = Nothing
            For i As Integer = 0 To longitudnuevacadena - 1
                letra = posibles(obj.[Next](longitud))
                nuevaLetra += letra.ToString()
            Next



            Fecha = DateTime.Now.ToString("dd-MMMM-yyyy")

            'Dim directorioReporte As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\ListadoDeudores\ListadoDeudores__" & Fecha & ".pdf").Trim()
            Dim directorioReporte As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\LecturasNoCapturadas\").Trim
            If Not Directory.Exists(directorioReporte) Then
                Directory.CreateDirectory(directorioReporte)
            End If

            'Dar propiedades al Documento
            Dim pdfDoc As New Document(iTextSharp.text.PageSize.LETTER, 15.0F, 15.0F, 30.0F, 30.0F)


            'Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(cadenafolder & "\factura" & serie & factura & ".pdf", FileMode.Create))
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(directorioReporte & "\LecturasNoCapturadas_" & Fecha & "_" & nuevaLetra & ".pdf", FileMode.Create))



            'Formato Letras

            Dim Font As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 6, iTextSharp.text.Font.NORMAL))
            Dim Font8N As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 6, iTextSharp.text.Font.BOLD))
            Dim Font88 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 13, iTextSharp.text.Font.BOLD))
            Dim Font8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 9, iTextSharp.text.Font.BOLD))
            Dim Font12 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.BOLD))
            Dim Font9 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 9, iTextSharp.text.Font.NORMAL))
            Dim Font9G As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 9, iTextSharp.text.Font.NORMAL))
            Dim Fontp As New Font(FontFactory.GetFont(FontFactory.COURIER, 7, iTextSharp.text.Font.BOLD))
            Dim CVacio As PdfPCell = New PdfPCell(New Phrase(""))
            CVacio.Border = 0

            'abrimos el pdf para comenzar a escribir en el, al terminar cerramos
            pdfDoc.Open()

            'Agregar Logo
            Dim imagenBMP As iTextSharp.text.Image
            imagenBMP = iTextSharp.text.Image.GetInstance(LOGOBYTE)
            imagenBMP.ScaleToFit(85.0F, 80.0F)
            imagenBMP.Border = 0

            'Tabla para el Encabezado
            Dim TableEncabezadoTitulo As PdfPTable = New PdfPTable(1)
            TableEncabezadoTitulo.DefaultCell.Border = BorderStyle.None
            TableEncabezadoTitulo.WidthPercentage = 100
            Dim widths As Single() = New Single() {100.0F}
            TableEncabezadoTitulo.SetWidths(widths)

            'Columnas
            Dim DIRECCIONE As String = Empresa
            Dim ColEnc1 = New PdfPCell(New Phrase(DIRECCIONE, Font8))
            ColEnc1.Border = 0
            ColEnc1.HorizontalAlignment = PdfPCell.ALIGN_CENTER

            TableEncabezadoTitulo.AddCell(ColEnc1)


            'Tabla para el Encabezado
            Dim TableEncabezado2 As PdfPTable = New PdfPTable(3)
            TableEncabezado2.DefaultCell.Border = BorderStyle.None
            TableEncabezado2.WidthPercentage = 100
            Dim widthsEnc2 As Single() = New Single() {100.0F, 500, 150.0F}
            TableEncabezado2.SetWidths(widthsEnc2)


            Dim ColEnc21 = New PdfPCell(New Phrase(" ", Font8))
            ColEnc21.Border = 0
            ColEnc21.HorizontalAlignment = PdfPCell.ALIGN_CENTER


            Dim ColEnc22 = New PdfPCell(New Phrase(Fecha, Font8))
            ColEnc22.Border = 0
            ColEnc22.HorizontalAlignment = PdfPCell.ALIGN_CENTER

            TableEncabezado2.AddCell(imagenBMP)
            TableEncabezado2.AddCell(ColEnc21)
            TableEncabezado2.AddCell(ColEnc22)

            'Tabla Ruta
            Dim TableRuta As PdfPTable = New PdfPTable(1)
            TableRuta.DefaultCell.Border = BorderStyle.None
            TableRuta.WidthPercentage = 100
            Dim widthsRuta As Single() = New Single() {1000.0F}
            TableRuta.SetWidths(widthsRuta)

            Dim ColRut1 = New PdfPCell(New Phrase($"LECTURAS NO CAPTURADAS: {Titulo}", Font8))
            ColRut1.Border = 0
            ColRut1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableRuta.AddCell(ColRut1)

            ColRut1 = New PdfPCell(New Phrase(" ", Font8))
            ColRut1.Border = 0
            ColRut1.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableRuta.AddCell(ColRut1)

            'Tabla Datos Deudores
            Dim TableDatosDeu As PdfPTable = New PdfPTable(3)
            TableDatosDeu.DefaultCell.Border = BorderStyle.None
            TableDatosDeu.WidthPercentage = 100
            Dim widthsDatDeu As Single() = New Single() {55.0F, 115.0F, 115.0F}
            TableDatosDeu.SetWidths(widthsDatDeu)

            Dim ColCuenta = New PdfPCell(New Phrase("Contrato", Font8))
            ColCuenta.Border = 7
            ColCuenta.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'ColCuenta.BackgroundColor = New iTextSharp.text.BaseColor(104, 104, 104)
            TableDatosDeu.AddCell(ColCuenta)

            Dim ColNombre = New PdfPCell(New Phrase("Nombre", Font8))
            ColNombre.Border = 3
            ColNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableDatosDeu.AddCell(ColNombre)

            Dim ColDireccion = New PdfPCell(New Phrase("Dirección", Font8))
            ColDireccion.Border = 11
            ColDireccion.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableDatosDeu.AddCell(ColDireccion)

            'Dim ColMZ = New PdfPCell(New Phrase("MZ", Font8))
            'ColMZ.Border = 3
            'ColMZ.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'TableDatosDeu.AddCell(ColMZ)

            'Dim ColLT = New PdfPCell(New Phrase("LT", Font8))
            'ColLT.Border = 3
            'ColLT.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'TableDatosDeu.AddCell(ColLT)

            'Dim ColTarifa = New PdfPCell(New Phrase("Tarifa", Font8))
            'ColTarifa.Border = 3
            'ColTarifa.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'TableDatosDeu.AddCell(ColTarifa)

            'Dim ColMedidor = New PdfPCell(New Phrase("Medidor", Font8))
            'ColMedidor.Border = 3
            'ColMedidor.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'TableDatosDeu.AddCell(ColMedidor)

            'Dim ColPeriodo = New PdfPCell(New Phrase("Periodo", Font8))
            'ColPeriodo.Border = 3
            'ColPeriodo.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'TableDatosDeu.AddCell(ColPeriodo)

            'Dim ColMeses = New PdfPCell(New Phrase("Mes.", Font8))
            'ColMeses.Border = 3
            'ColMeses.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'TableDatosDeu.AddCell(ColMeses)

            'Dim ColTotal



            'ColTotal = New PdfPCell(New Phrase(" ", Font8))
            'ColTotal.Border = 3
            'ColTotal.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'TableDatosDeu.AddCell(ColTotal)





            ''ColTotal = New PdfPCell(New Phrase("Total", Font8))
            ''ColTotal.Border = 3
            ''ColTotal.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            ''TableDatosDeu.AddCell(ColTotal)





            'Dim ColVac = New PdfPCell(New Phrase(" ", Font8))
            'ColVac.Border = 11
            'ColVac.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'TableDatosDeu.AddCell(ColVac)

            'Dim lista As New List(Of )(sql)

            'For Each item As String In lista
            '    Debug.Write(item & " ")
            'Next

            Dim NumReg As Int32 = 0
            Dim CarteraVencida As Decimal = 0


            While datosDeudores.Read()

                ColCuenta = New PdfPCell(New Phrase(datosDeudores("cuenta").ToString(), Font9G))
                ColCuenta.Border = 7
                ColCuenta.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                'ColCuenta.BackgroundColor = New iTextSharp.text.BaseColor(104, 104, 104)
                TableDatosDeu.AddCell(ColCuenta)

                ColNombre = New PdfPCell(New Phrase(datosDeudores("Nombre").ToString(), Font9))
                ColNombre.Border = 3
                ColNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosDeu.AddCell(ColNombre)

                ColDireccion = New PdfPCell(New Phrase(datosDeudores("Domicilio").ToString(), Font9))
                ColDireccion.Border = 11
                ColDireccion.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosDeu.AddCell(ColDireccion)

                'ColMZ = New PdfPCell(New Phrase(datosDeudores("Manzana").ToString(), Font9))
                'ColMZ.Border = 3
                'ColMZ.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                'TableDatosDeu.AddCell(ColMZ)

                'ColLT = New PdfPCell(New Phrase(datosDeudores("Lote").ToString(), Font9))
                'ColLT.Border = 3
                'ColLT.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                'TableDatosDeu.AddCell(ColLT)

                'ColTarifa = New PdfPCell(New Phrase(datosDeudores("Tarifa").ToString(), Font9))
                'ColTarifa.Border = 3
                'ColTarifa.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                'TableDatosDeu.AddCell(ColTarifa)

                'ColMedidor = New PdfPCell(New Phrase(datosDeudores("nodemedidor").ToString(), Font9))
                'ColMedidor.Border = 3
                'ColMedidor.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                'TableDatosDeu.AddCell(ColMedidor)

                'ColPeriodo = New PdfPCell(New Phrase(datosDeudores("Periodo").ToString(), Font9))
                'ColPeriodo.Border = 3
                'ColPeriodo.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                'TableDatosDeu.AddCell(ColPeriodo)

                'ColMeses = New PdfPCell(New Phrase(datosDeudores("NumPeriodos").ToString(), Font9))
                'ColMeses.Border = 3
                'ColMeses.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                'TableDatosDeu.AddCell(ColMeses)



                'ColTotal = New PdfPCell(New Phrase(" ", Font9))
                'ColTotal.Border = 3
                'ColTotal.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                'TableDatosDeu.AddCell(ColTotal)



                ''ColTotal = New PdfPCell(New Phrase("$" & datosDeudores("Total").ToString(), Font9))
                ''    ColTotal.Border = 3
                ''    ColTotal.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                ''    TableDatosDeu.AddCell(ColTotal)




                'ColVac = New PdfPCell(New Phrase(" ", Font9))
                'ColVac.Border = 11
                'ColVac.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                'TableDatosDeu.AddCell(ColVac)

                'CarteraVencida += datosDeudores("Total")
                NumReg = NumReg + 1

            End While


            'Tabla Contador
            Dim TableContador As PdfPTable = New PdfPTable(2)
            TableContador.DefaultCell.Border = BorderStyle.None
            TableContador.WidthPercentage = 100
            Dim widthsCont As Single() = New Single() {600.0F, 400.0F}
            TableContador.SetWidths(widthsCont)

            Dim ColCont = New PdfPCell(New Phrase(" ", Font8))
            ColCont.Border = 0
            ColCont.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableContador.AddCell(ColCont)

            ColCont = New PdfPCell(New Phrase(" ", Font8))
            ColCont.Border = 0
            ColCont.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableContador.AddCell(ColCont)

            ColCont = New PdfPCell(New Phrase("Registros Totales: " & NumReg.ToString(), Font8))
            ColCont.Border = 0
            ColCont.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableContador.AddCell(ColCont)

            ColCont = New PdfPCell(New Phrase(" ", Font8))
            ColCont.Border = 0
            ColCont.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableContador.AddCell(ColCont)

            'ColCont = New PdfPCell(New Phrase("Cartera Vencida: " & CarteraVencida.ToString("C"), Font8))
            'ColCont.Border = 0
            'ColCont.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'TableContador.AddCell(ColCont)


            pdfDoc.Add(TableEncabezadoTitulo)
            pdfDoc.Add(TableEncabezado2)
            pdfDoc.Add(TableRuta)
            pdfDoc.Add(TableDatosDeu)
            pdfDoc.Add(TableContador)

            pdfDoc.Close()



            Process.Start(directorioReporte & "\LecturasNoCapturadas_" & Fecha & "_" & nuevaLetra & ".pdf")

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try


    End Sub


End Class
