Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class ReportesOrdenTrabajo


    Public Sub GenerarReporteTipoQueja(fechaInicioP As Date, FechaFinP As Date, direccionP As String, departamentoP As String)


        Dim contadorCumplidasGeneral As Short = 0
        Dim contadorxVencerGeneral As Short = 0
        Dim contadorVencidasGeneral As Short = 0
        Dim contadorGeneralGeneral As Short = 0

        Dim fechaInicial As String = UnixDateFormat(fechaInicioP)
        Dim fechaFinal As String = UnixDateFormat(FechaFinP)

        Dim datosOrganismo As IDataReader = ConsultaSql("select * from empresa").ExecuteReader
        datosOrganismo.Read()

        Dim DIRECCIONE As String = $" {datosOrganismo("CDOMICILIO")}, {datosOrganismo("CCOLONIA")}, {datosOrganismo("CPOBLACION")}, {datosOrganismo("ESTADO")}, CP: {datosOrganismo("CCODPOS")} "





        Dim cadenafolderDocAn As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Reportes_OrdServicio\" & Year(Now) & acompletacero(Month(Now).ToString(), 2)).Trim

        If Not Directory.Exists(cadenafolderDocAn) Then
            Directory.CreateDirectory(cadenafolderDocAn)
        End If

        Try


            Dim pdfDoc As New Document(iTextSharp.text.PageSize.LETTER, 30.0F, 30.0F, 30.0F, 30.0F)

            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(cadenafolderDocAn & "\CIS-TipoQueja_" & fechaInicial & "_" & fechaFinal & ".pdf", FileMode.Create))

            Dim Font7 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 7, iTextSharp.text.Font.NORMAL))
            Dim Font7BOLD As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 7, iTextSharp.text.Font.BOLD))
            Dim Font8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL))
            Dim Font8BOLD As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD))
            Dim Font9 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 9, iTextSharp.text.Font.NORMAL))
            Dim Font9BOLD As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 9, iTextSharp.text.Font.BOLD))
            Dim Font10 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.NORMAL))
            Dim Font10BOLD As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.BOLD))


            pdfDoc.Open()



            'ENCABEZADO
            Dim Table1 As PdfPTable = New PdfPTable(2)
            Table1.DefaultCell.Border = BorderStyle.None
            Dim Col1 As PdfPCell
            Table1.WidthPercentage = 100

            Dim widths As Single() = New Single() {100.0F, 800.0F}
            Table1.SetWidths(widths)


            Dim imagenBMP As iTextSharp.text.Image
            imagenBMP = iTextSharp.text.Image.GetInstance(LOGOBYTE)
            imagenBMP.ScaleToFit(80.0F, 70.0F)
            imagenBMP.Border = 0

            Table1.AddCell(imagenBMP)


            Dim TableEspacio As PdfPTable = New PdfPTable(1)
            Dim ColEsp As PdfPCell
            TableEspacio.WidthPercentage = 100
            Dim widthsTE As Single() = New Single() {1000.0F}
            TableEspacio.SetWidths(widthsTE)

            ColEsp = New PdfPCell(New Phrase(" ", Font10BOLD))
            ColEsp.Border = 0
            ColEsp.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableEspacio.AddCell(ColEsp)



            Dim TableTitulo As PdfPTable = New PdfPTable(1)
            Col1 = New PdfPCell(New Phrase(datosOrganismo("CNOMBRE"), Font10BOLD))
            Col1.Border = 0
            Col1.HorizontalAlignment = PdfPCell.ALIGN_CENTER


            Dim Col1rfe = New PdfPCell(New Phrase($"{DIRECCIONE}", Font8))
            Col1rfe.Border = 0
            Col1rfe.HorizontalAlignment = PdfPCell.ALIGN_CENTER


            TableTitulo.AddCell(Col1)
            TableTitulo.AddCell(Col1rfe)
            Table1.AddCell(TableTitulo)





            Dim TableTituloReporte As PdfPTable = New PdfPTable(1)

            TableTituloReporte.WidthPercentage = 100
            Dim widthsTRepor As Single() = New Single() {1000.0F}
            TableTituloReporte.SetWidths(widthsTRepor)

            Dim ColTitRep = New PdfPCell(New Phrase("REPORTE DE CIS POR TIPO DE QUEJA", Font9BOLD))
            ColTitRep.Border = 0
            ColTitRep.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableTituloReporte.AddCell(ColTitRep)



            Dim TableEncabezado As PdfPTable = New PdfPTable(6)

            TableEncabezado.WidthPercentage = 100
            Dim widthsEncabez As Single() = New Single() {40.0F, 30.0F, 20.0F, 60.0F, 50.0F, 50.0F}
            TableEncabezado.SetWidths(widthsEncabez)


            Dim ColEnc1 = New PdfPCell(New Phrase("PERIODO DEL: ", Font8BOLD))
            ColEnc1.Border = 0
            ColEnc1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableEncabezado.AddCell(ColEnc1)

            ColEnc1 = New PdfPCell(New Phrase($"{fechaInicioP.ToString("dd-MM-yyyy")}", Font8))
            ColEnc1.Border = 0
            ColEnc1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableEncabezado.AddCell(ColEnc1)

            ColEnc1 = New PdfPCell(New Phrase("AL: ", Font8BOLD))
            ColEnc1.Border = 0
            ColEnc1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableEncabezado.AddCell(ColEnc1)

            ColEnc1 = New PdfPCell(New Phrase($"{FechaFinP.ToString("dd-MM-yyyy")}", Font8))
            ColEnc1.Border = 0
            ColEnc1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableEncabezado.AddCell(ColEnc1)

            ColEnc1 = New PdfPCell(New Phrase("FECHA DE EMISIÓN: ", Font8BOLD))
            ColEnc1.Border = 0
            ColEnc1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableEncabezado.AddCell(ColEnc1)

            ColEnc1 = New PdfPCell(New Phrase($"{DateTime.Now.ToString("dd-MM-yyyy")}", Font8))
            ColEnc1.Border = 0
            ColEnc1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableEncabezado.AddCell(ColEnc1)




            Dim TableTituloReporte2 As PdfPTable = New PdfPTable(1)

            TableTituloReporte2.WidthPercentage = 100
            Dim widthsTRepor2 As Single() = New Single() {1000.0F}
            TableTituloReporte2.SetWidths(widthsTRepor2)

            Dim ColTitRep2 = New PdfPCell(New Phrase($"DIRECCIÓN: {direccionP}", Font9BOLD))
            ColTitRep2.Border = 0
            ColTitRep2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableTituloReporte2.AddCell(ColTitRep2)

            ColTitRep2 = New PdfPCell(New Phrase($" ", Font9BOLD))
            ColTitRep2.Border = 0
            ColTitRep2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableTituloReporte2.AddCell(ColTitRep2)

            Dim departamento = obtenerCampo($"SELECT NOMBRE FROM DEPTOS WHERE COD_DEP = '{departamentoP}'", "NOMBRE")
            ColTitRep2 = New PdfPCell(New Phrase($"DEPARTAMENTO: {departamento}", Font9BOLD))
            ColTitRep2.Border = 0
            ColTitRep2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableTituloReporte2.AddCell(ColTitRep2)





            Dim TableCuerpoReporte As PdfPTable = New PdfPTable(6)

            TableCuerpoReporte.WidthPercentage = 100
            Dim widthsCuerpoReporte As Single() = New Single() {40.0F, 100.0F, 40.0F, 40.0F, 40.0F, 40.0F}
            TableCuerpoReporte.SetWidths(widthsCuerpoReporte)

            Dim ColCuerpo1 = New PdfPCell(New Phrase("CLAVE", Font8BOLD))
            ColCuerpo1.Border = 0
            ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableCuerpoReporte.AddCell(ColCuerpo1)


            ColCuerpo1 = New PdfPCell(New Phrase("DESCRIPCION", Font8BOLD))
            ColCuerpo1.Border = 0
            ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableCuerpoReporte.AddCell(ColCuerpo1)


            ColCuerpo1 = New PdfPCell(New Phrase("RECIBIDAS", Font8BOLD))
            ColCuerpo1.Border = 0
            ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableCuerpoReporte.AddCell(ColCuerpo1)


            ColCuerpo1 = New PdfPCell(New Phrase("CUMPLIDAS", Font8BOLD))
            ColCuerpo1.Border = 0
            ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableCuerpoReporte.AddCell(ColCuerpo1)


            ColCuerpo1 = New PdfPCell(New Phrase("X/VENCER", Font8BOLD))
            ColCuerpo1.Border = 0
            ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableCuerpoReporte.AddCell(ColCuerpo1)


            ColCuerpo1 = New PdfPCell(New Phrase("VENCIDAS", Font8BOLD))
            ColCuerpo1.Border = 0
            ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableCuerpoReporte.AddCell(ColCuerpo1)


            pdfDoc.Add(Table1)
            pdfDoc.Add(TableEncabezado)
            pdfDoc.Add(TableTituloReporte2)

            Dim ordenesFueraDeRango As String = ""

            Dim sql = $"SELECT COD_CVE, DESCRIPCION_QUEJA FROM VORDENT WHERE FEC_ORD BETWEEN '{fechaInicial}' AND '{fechaFinal}' AND COD_DIR = '{direccionP}' AND COD_RES = '{departamentoP}' GROUP BY COD_CVE ORDER BY COD_CVE ASC"
            Dim datosConceptosAgrupados As IDataReader = ConsultaSql(sql).ExecuteReader

            While datosConceptosAgrupados.Read()

                Dim contadorGeneral As Short = 0
                Dim contadorCumplidas As Short = 0
                Dim contadorxVencer As Short = 0
                Dim contadorVencidas As Short = 0

                Dim codigoProblema As String = ""
                Dim descripcionProblema As String = ""
                Dim folioOrdTrabajo As Integer

                codigoProblema = datosConceptosAgrupados("COD_CVE")
                descripcionProblema = datosConceptosAgrupados("DESCRIPCION_QUEJA")


                ColCuerpo1 = New PdfPCell(New Phrase($"{codigoProblema}", Font8))
                ColCuerpo1.Border = 0
                ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableCuerpoReporte.AddCell(ColCuerpo1)


                ColCuerpo1 = New PdfPCell(New Phrase($"{descripcionProblema}", Font8))
                ColCuerpo1.Border = 0
                ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableCuerpoReporte.AddCell(ColCuerpo1)

                Dim sql2 As String = ""

                sql2 = $"SELECT FOLIO FROM VORDENT WHERE FEC_ORD BETWEEN '{fechaInicial}' AND '{fechaFinal}' AND COD_DIR = '{direccionP}' AND COD_RES = '{departamentoP}' AND COD_CVE = {codigoProblema} AND STATUS <> 'CANCELADA'"
                Dim datosOrdenesTrabajo As IDataReader = ConsultaSql(sql2).ExecuteReader
                While datosOrdenesTrabajo.Read()



                    folioOrdTrabajo = datosOrdenesTrabajo("FOLIO")


                    'Crear Método para calcular los días de la orden de trabajo
                    Dim estatus = CalcularEstatusOrdenTrabajo(folioOrdTrabajo)


                    Select Case estatus
                        Case 1

                            contadorCumplidas = contadorCumplidas + 1
                            contadorCumplidasGeneral = contadorCumplidasGeneral + 1
                        Case 2

                            contadorxVencer = contadorxVencer + 1
                            contadorxVencerGeneral = contadorxVencerGeneral + 1
                        Case 3

                            contadorVencidas = contadorVencidas + 1
                            contadorVencidasGeneral = contadorVencidasGeneral + 1
                        Case Else

                            ordenesFueraDeRango = $"{ordenesFueraDeRango}, {folioOrdTrabajo}"
                    End Select

                    contadorGeneral = contadorGeneral + 1
                    contadorGeneralGeneral = contadorGeneralGeneral + 1

                End While

                ColCuerpo1 = New PdfPCell(New Phrase($"{contadorGeneral}", Font8))
                ColCuerpo1.Border = 0
                ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableCuerpoReporte.AddCell(ColCuerpo1)

                ColCuerpo1 = New PdfPCell(New Phrase($"{contadorCumplidas}", Font8))
                ColCuerpo1.Border = 0
                ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableCuerpoReporte.AddCell(ColCuerpo1)


                ColCuerpo1 = New PdfPCell(New Phrase($"{contadorxVencer}", Font8))
                ColCuerpo1.Border = 0
                ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableCuerpoReporte.AddCell(ColCuerpo1)


                ColCuerpo1 = New PdfPCell(New Phrase($"{contadorVencidas}", Font8))
                ColCuerpo1.Border = 0
                ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableCuerpoReporte.AddCell(ColCuerpo1)


            End While

            pdfDoc.Add(TableCuerpoReporte)

            Dim TableContadoresGenerales As PdfPTable = New PdfPTable(6)

            TableContadoresGenerales.WidthPercentage = 100
            TableContadoresGenerales.SpacingBefore = 5
            Dim widthsContadoresGen As Single() = New Single() {40.0F, 100.0F, 40.0F, 40.0F, 40.0F, 40.0F}
            TableContadoresGenerales.SetWidths(widthsContadoresGen)

            Dim vuelta As Short = 0

            Dim ColContadoresGen = New PdfPCell()

            While vuelta <= 2

                ColContadoresGen = New PdfPCell(New Phrase("", Font8BOLD))
                ColContadoresGen.Border = 0
                ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                TableContadoresGenerales.AddCell(ColContadoresGen)

                Select Case vuelta

                    Case 0

                        ColContadoresGen = New PdfPCell(New Phrase("TOTAL DEPARTAMENTO", Font8BOLD))
                        ColContadoresGen.Border = 0
                        ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                        TableContadoresGenerales.AddCell(ColContadoresGen)


                    Case 1

                        ColContadoresGen = New PdfPCell(New Phrase("TOTAL DIRECCIÓN", Font8BOLD))
                        ColContadoresGen.Border = 0
                        ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                        TableContadoresGenerales.AddCell(ColContadoresGen)



                    Case 2

                        ColContadoresGen = New PdfPCell(New Phrase("TOTAL GENERAL", Font8BOLD))
                        ColContadoresGen.Border = 0
                        ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                        TableContadoresGenerales.AddCell(ColContadoresGen)



                End Select



                ColContadoresGen = New PdfPCell(New Phrase(contadorGeneralGeneral, Font8BOLD))
                ColContadoresGen.Border = 0
                ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableContadoresGenerales.AddCell(ColContadoresGen)


                ColContadoresGen = New PdfPCell(New Phrase(contadorCumplidasGeneral, Font8BOLD))
                ColContadoresGen.Border = 0
                ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableContadoresGenerales.AddCell(ColContadoresGen)


                ColContadoresGen = New PdfPCell(New Phrase(contadorxVencerGeneral, Font8BOLD))
                ColContadoresGen.Border = 0
                ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableContadoresGenerales.AddCell(ColContadoresGen)


                ColContadoresGen = New PdfPCell(New Phrase(contadorVencidasGeneral, Font8BOLD))
                ColContadoresGen.Border = 0
                ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableContadoresGenerales.AddCell(ColContadoresGen)

                vuelta = vuelta + 1

            End While

            pdfDoc.Add(TableContadoresGenerales)



            pdfDoc.Close()




        Catch ex As Exception

            MessageBox.Show(ex.ToString())

        End Try

        Try
            Dim psi As New ProcessStartInfo(cadenafolderDocAn & "\CIS-TipoQueja_" & fechaInicial & "_" & fechaFinal & ".pdf")
            'psi.WorkingDirectory = cadenafolder & "\factura\" + nombresespacios

            psi.WindowStyle = ProcessWindowStyle.Hidden
            Dim p As Process = Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("error al visualizar el pdf" & ex.Message)
        End Try

    End Sub

    Public Sub GenerarReporteTipoQueja(fechaInicioP As Date, FechaFinP As Date, direccionP As String)


        Dim contadorCumplidasGeneral As Short = 0
        Dim contadorxVencerGeneral As Short = 0
        Dim contadorVencidasGeneral As Short = 0
        Dim contadorGeneralGeneral As Short = 0

        Dim fechaInicial As String = UnixDateFormat(fechaInicioP)
        Dim fechaFinal As String = UnixDateFormat(FechaFinP)

        Dim datosOrganismo As IDataReader = ConsultaSql("select * from empresa").ExecuteReader
        datosOrganismo.Read()

        Dim DIRECCIONE As String = $" {datosOrganismo("CDOMICILIO")}, {datosOrganismo("CCOLONIA")}, {datosOrganismo("CPOBLACION")}, {datosOrganismo("ESTADO")}, CP: {datosOrganismo("CCODPOS")} "





        Dim cadenafolderDocAn As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Reportes_OrdServicio\" & Year(Now) & acompletacero(Month(Now).ToString(), 2)).Trim

        If Not Directory.Exists(cadenafolderDocAn) Then
            Directory.CreateDirectory(cadenafolderDocAn)
        End If

        Try


            Dim pdfDoc As New Document(iTextSharp.text.PageSize.LETTER, 30.0F, 30.0F, 30.0F, 30.0F)

            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(cadenafolderDocAn & "\CIS-TipoQueja_SD_" & fechaInicial & "_" & fechaFinal & ".pdf", FileMode.Create))

            Dim Font7 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 7, iTextSharp.text.Font.NORMAL))
            Dim Font7BOLD As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 7, iTextSharp.text.Font.BOLD))
            Dim Font8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL))
            Dim Font8BOLD As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD))
            Dim Font9 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 9, iTextSharp.text.Font.NORMAL))
            Dim Font9BOLD As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 9, iTextSharp.text.Font.BOLD))
            Dim Font10 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.NORMAL))
            Dim Font10BOLD As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.BOLD))


            pdfDoc.Open()



            'ENCABEZADO
            Dim Table1 As PdfPTable = New PdfPTable(2)
            Table1.DefaultCell.Border = BorderStyle.None
            Dim Col1 As PdfPCell
            Table1.WidthPercentage = 100

            Dim widths As Single() = New Single() {100.0F, 800.0F}
            Table1.SetWidths(widths)


            Dim imagenBMP As iTextSharp.text.Image
            imagenBMP = iTextSharp.text.Image.GetInstance(LOGOBYTE)
            imagenBMP.ScaleToFit(80.0F, 70.0F)
            imagenBMP.Border = 0

            Table1.AddCell(imagenBMP)


            Dim TableEspacio As PdfPTable = New PdfPTable(1)
            Dim ColEsp As PdfPCell
            TableEspacio.WidthPercentage = 100
            Dim widthsTE As Single() = New Single() {1000.0F}
            TableEspacio.SetWidths(widthsTE)

            ColEsp = New PdfPCell(New Phrase(" ", Font10BOLD))
            ColEsp.Border = 0
            ColEsp.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableEspacio.AddCell(ColEsp)



            Dim TableTitulo As PdfPTable = New PdfPTable(1)
            Col1 = New PdfPCell(New Phrase(datosOrganismo("CNOMBRE"), Font10BOLD))
            Col1.Border = 0
            Col1.HorizontalAlignment = PdfPCell.ALIGN_CENTER


            Dim Col1rfe = New PdfPCell(New Phrase($"{DIRECCIONE}", Font8))
            Col1rfe.Border = 0
            Col1rfe.HorizontalAlignment = PdfPCell.ALIGN_CENTER


            TableTitulo.AddCell(Col1)
            TableTitulo.AddCell(Col1rfe)
            Table1.AddCell(TableTitulo)





            Dim TableTituloReporte As PdfPTable = New PdfPTable(1)

            TableTituloReporte.WidthPercentage = 100
            Dim widthsTRepor As Single() = New Single() {1000.0F}
            TableTituloReporte.SetWidths(widthsTRepor)

            Dim ColTitRep = New PdfPCell(New Phrase("REPORTE DE CIS POR TIPO DE QUEJA", Font9BOLD))
            ColTitRep.Border = 0
            ColTitRep.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableTituloReporte.AddCell(ColTitRep)



            Dim TableEncabezado As PdfPTable = New PdfPTable(6)

            TableEncabezado.WidthPercentage = 100
            Dim widthsEncabez As Single() = New Single() {40.0F, 30.0F, 20.0F, 60.0F, 50.0F, 50.0F}
            TableEncabezado.SetWidths(widthsEncabez)


            Dim ColEnc1 = New PdfPCell(New Phrase("PERIODO DEL: ", Font8BOLD))
            ColEnc1.Border = 0
            ColEnc1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableEncabezado.AddCell(ColEnc1)

            ColEnc1 = New PdfPCell(New Phrase($"{fechaInicioP.ToString("dd-MM-yyyy")}", Font8))
            ColEnc1.Border = 0
            ColEnc1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableEncabezado.AddCell(ColEnc1)

            ColEnc1 = New PdfPCell(New Phrase("AL: ", Font8BOLD))
            ColEnc1.Border = 0
            ColEnc1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableEncabezado.AddCell(ColEnc1)

            ColEnc1 = New PdfPCell(New Phrase($"{FechaFinP.ToString("dd-MM-yyyy")}", Font8))
            ColEnc1.Border = 0
            ColEnc1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableEncabezado.AddCell(ColEnc1)

            ColEnc1 = New PdfPCell(New Phrase("FECHA DE EMISIÓN: ", Font8BOLD))
            ColEnc1.Border = 0
            ColEnc1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableEncabezado.AddCell(ColEnc1)

            ColEnc1 = New PdfPCell(New Phrase($"{DateTime.Now.ToString("dd-MM-yyyy")}", Font8))
            ColEnc1.Border = 0
            ColEnc1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableEncabezado.AddCell(ColEnc1)


            pdfDoc.Add(Table1)
            pdfDoc.Add(TableEncabezado)






            Dim sqlDeptos = $"SELECT DEPARTAMENTO FROM VORDENT WHERE FEC_ORD BETWEEN '{fechaInicial}' AND '{fechaFinal}' AND COD_DIR = '{direccionP}' GROUP BY DEPARTAMENTO ORDER BY DEPARTAMENTO ASC"
            Dim datosDeptosAgrupados As IDataReader = ConsultaSql(sqlDeptos).ExecuteReader
            Dim vueltaDireccion As Short = 0

            While datosDeptosAgrupados.Read()

                Dim contadoraGeneralxDepartamento As Short = 0
                Dim contadoraCumplidasxDepartamento As Short = 0
                Dim contadoraxVencerxDepartamento As Short = 0
                Dim contadoraVencidasxDepartamento As Short = 0

                Dim TableTituloReporte2 As PdfPTable = New PdfPTable(1)

                TableTituloReporte2.WidthPercentage = 100
                Dim widthsTRepor2 As Single() = New Single() {1000.0F}
                TableTituloReporte2.SetWidths(widthsTRepor2)

                Dim ColTitRep2 = New PdfPCell()

                If vueltaDireccion <= 0 Then

                    Dim nombreDpto = obtenerCampo($"SELECT NOMBRE FROM DIREC WHERE COD_DIR = '{direccionP}'", "NOMBRE")
                    ColTitRep2 = New PdfPCell(New Phrase($"DIRECCIÓN: {nombreDpto}", Font9BOLD))
                    ColTitRep2.Border = 0
                    ColTitRep2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    TableTituloReporte2.AddCell(ColTitRep2)

                Else

                    ColTitRep2 = New PdfPCell(New Phrase($" ", Font9BOLD))
                    ColTitRep2.Border = 0
                    ColTitRep2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    TableTituloReporte2.AddCell(ColTitRep2)

                End If


                ColTitRep2 = New PdfPCell(New Phrase($" ", Font9BOLD))
                ColTitRep2.Border = 0
                ColTitRep2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableTituloReporte2.AddCell(ColTitRep2)

                Dim departamentoVuelta As String = datosDeptosAgrupados("Departamento")

                Dim codigoDepartamento = obtenerCampo($"SELECT COD_DEP FROM DEPTOS WHERE NOMBRE = '{departamentoVuelta}'", "COD_DEP")
                Dim ColTitRep3 = New PdfPCell(New Phrase($"DEPARTAMENTO: {departamentoVuelta}", Font9BOLD))
                ColTitRep3.Border = 0
                ColTitRep3.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableTituloReporte2.AddCell(ColTitRep3)


                pdfDoc.Add(TableTituloReporte2)


                Dim TableCuerpoReporte As PdfPTable = New PdfPTable(6)

                TableCuerpoReporte.WidthPercentage = 100
                Dim widthsCuerpoReporte As Single() = New Single() {40.0F, 100.0F, 40.0F, 40.0F, 40.0F, 40.0F}
                TableCuerpoReporte.SetWidths(widthsCuerpoReporte)

                Dim ColCuerpo1 = New PdfPCell(New Phrase("CLAVE", Font8BOLD))
                ColCuerpo1.Border = 0
                ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableCuerpoReporte.AddCell(ColCuerpo1)


                ColCuerpo1 = New PdfPCell(New Phrase("DESCRIPCION", Font8BOLD))
                ColCuerpo1.Border = 0
                ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableCuerpoReporte.AddCell(ColCuerpo1)


                ColCuerpo1 = New PdfPCell(New Phrase("RECIBIDAS", Font8BOLD))
                ColCuerpo1.Border = 0
                ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableCuerpoReporte.AddCell(ColCuerpo1)


                ColCuerpo1 = New PdfPCell(New Phrase("CUMPLIDAS", Font8BOLD))
                ColCuerpo1.Border = 0
                ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableCuerpoReporte.AddCell(ColCuerpo1)


                ColCuerpo1 = New PdfPCell(New Phrase("X/VENCER", Font8BOLD))
                ColCuerpo1.Border = 0
                ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableCuerpoReporte.AddCell(ColCuerpo1)


                ColCuerpo1 = New PdfPCell(New Phrase("VENCIDAS", Font8BOLD))
                ColCuerpo1.Border = 0
                ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableCuerpoReporte.AddCell(ColCuerpo1)





                Dim ordenesFueraDeRango As String = ""

                Dim sql = $"SELECT COD_CVE, DESCRIPCION_QUEJA FROM VORDENT WHERE FEC_ORD BETWEEN '{fechaInicial}' AND '{fechaFinal}' AND COD_DIR = '{direccionP}' AND COD_RES = '{codigoDepartamento}' GROUP BY COD_CVE ORDER BY COD_CVE ASC"
                Dim datosConceptosAgrupados As IDataReader = ConsultaSql(sql).ExecuteReader

                While datosConceptosAgrupados.Read()

                    Dim contadorGeneral As Short = 0
                    Dim contadorCumplidas As Short = 0
                    Dim contadorxVencer As Short = 0
                    Dim contadorVencidas As Short = 0

                    Dim codigoProblema As String = ""
                    Dim descripcionProblema As String = ""
                    Dim folioOrdTrabajo As Integer

                    codigoProblema = datosConceptosAgrupados("COD_CVE")
                    descripcionProblema = datosConceptosAgrupados("DESCRIPCION_QUEJA")


                    ColCuerpo1 = New PdfPCell(New Phrase($"{codigoProblema}", Font8))
                    ColCuerpo1.Border = 0
                    ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    TableCuerpoReporte.AddCell(ColCuerpo1)


                    ColCuerpo1 = New PdfPCell(New Phrase($"{descripcionProblema}", Font8))
                    ColCuerpo1.Border = 0
                    ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    TableCuerpoReporte.AddCell(ColCuerpo1)

                    Dim sql2 As String = ""

                    sql2 = $"SELECT FOLIO FROM VORDENT WHERE FEC_ORD BETWEEN '{fechaInicial}' AND '{fechaFinal}' AND COD_DIR = '{direccionP}' AND COD_RES = '{codigoDepartamento}' AND COD_CVE = {codigoProblema} AND STATUS <> 'CANCELADA'"
                    Dim datosOrdenesTrabajo As IDataReader = ConsultaSql(sql2).ExecuteReader
                    While datosOrdenesTrabajo.Read()



                        folioOrdTrabajo = datosOrdenesTrabajo("FOLIO")


                        'Crear Método para calcular los días de la orden de trabajo
                        Dim estatus = CalcularEstatusOrdenTrabajo(folioOrdTrabajo)


                        Select Case estatus
                            Case 1

                                contadorCumplidas = contadorCumplidas + 1
                                contadorCumplidasGeneral = contadorCumplidasGeneral + 1
                                contadoraCumplidasxDepartamento = contadoraCumplidasxDepartamento + 1
                            Case 2

                                contadorxVencer = contadorxVencer + 1
                                contadorxVencerGeneral = contadorxVencerGeneral + 1
                                contadoraxVencerxDepartamento = contadoraxVencerxDepartamento + 1
                            Case 3

                                contadorVencidas = contadorVencidas + 1
                                contadorVencidasGeneral = contadorVencidasGeneral + 1
                                contadoraVencidasxDepartamento = contadoraVencidasxDepartamento + 1
                            Case Else

                                ordenesFueraDeRango = $"{ordenesFueraDeRango}, {folioOrdTrabajo}"
                        End Select

                        contadorGeneral = contadorGeneral + 1
                        contadoraGeneralxDepartamento = contadoraGeneralxDepartamento + 1
                        contadorGeneralGeneral = contadorGeneralGeneral + 1

                    End While

                    ColCuerpo1 = New PdfPCell(New Phrase($"{contadorGeneral}", Font8))
                    ColCuerpo1.Border = 0
                    ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    TableCuerpoReporte.AddCell(ColCuerpo1)

                    ColCuerpo1 = New PdfPCell(New Phrase($"{contadorCumplidas}", Font8))
                    ColCuerpo1.Border = 0
                    ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    TableCuerpoReporte.AddCell(ColCuerpo1)


                    ColCuerpo1 = New PdfPCell(New Phrase($"{contadorxVencer}", Font8))
                    ColCuerpo1.Border = 0
                    ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    TableCuerpoReporte.AddCell(ColCuerpo1)


                    ColCuerpo1 = New PdfPCell(New Phrase($"{contadorVencidas}", Font8))
                    ColCuerpo1.Border = 0
                    ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    TableCuerpoReporte.AddCell(ColCuerpo1)

                    'Sustituir por una variable boleana
                    vueltaDireccion = vueltaDireccion + 1
                End While

                pdfDoc.Add(TableCuerpoReporte)


                Dim TableContadoresxDepartamento As PdfPTable = New PdfPTable(6)

                TableContadoresxDepartamento.WidthPercentage = 100
                TableContadoresxDepartamento.SpacingBefore = 5
                TableContadoresxDepartamento.SpacingAfter = 5
                Dim widthsContadoresxDep As Single() = New Single() {40.0F, 100.0F, 40.0F, 40.0F, 40.0F, 40.0F}
                TableContadoresxDepartamento.SetWidths(widthsContadoresxDep)

                Dim ColContadoresGenDep = New PdfPCell(New Phrase("", Font8BOLD))
                ColContadoresGenDep.Border = 0
                ColContadoresGenDep.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                TableContadoresxDepartamento.AddCell(ColContadoresGenDep)

                ColContadoresGenDep = New PdfPCell(New Phrase("TOTAL DEPARTAMENTO", Font8BOLD))
                ColContadoresGenDep.Border = 0
                ColContadoresGenDep.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableContadoresxDepartamento.AddCell(ColContadoresGenDep)

                ColContadoresGenDep = New PdfPCell(New Phrase($"{contadoraGeneralxDepartamento}", Font8BOLD))
                ColContadoresGenDep.Border = 0
                ColContadoresGenDep.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableContadoresxDepartamento.AddCell(ColContadoresGenDep)

                ColContadoresGenDep = New PdfPCell(New Phrase($"{contadoraCumplidasxDepartamento}", Font8BOLD))
                ColContadoresGenDep.Border = 0
                ColContadoresGenDep.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableContadoresxDepartamento.AddCell(ColContadoresGenDep)

                ColContadoresGenDep = New PdfPCell(New Phrase($"{contadoraxVencerxDepartamento}", Font8BOLD))
                ColContadoresGenDep.Border = 0
                ColContadoresGenDep.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableContadoresxDepartamento.AddCell(ColContadoresGenDep)

                ColContadoresGenDep = New PdfPCell(New Phrase($"{contadoraVencidasxDepartamento}", Font8BOLD))
                ColContadoresGenDep.Border = 0
                ColContadoresGenDep.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableContadoresxDepartamento.AddCell(ColContadoresGenDep)

                pdfDoc.Add(TableContadoresxDepartamento)

            End While



            Dim TableContadoresGenerales As PdfPTable = New PdfPTable(6)

            TableContadoresGenerales.WidthPercentage = 100
            TableContadoresGenerales.SpacingBefore = 10
            Dim widthsContadoresGen As Single() = New Single() {40.0F, 100.0F, 40.0F, 40.0F, 40.0F, 40.0F}
            TableContadoresGenerales.SetWidths(widthsContadoresGen)

            Dim vuelta As Short = 0

            Dim ColContadoresGen = New PdfPCell()

            While vuelta <= 1

                ColContadoresGen = New PdfPCell(New Phrase("", Font8BOLD))
                ColContadoresGen.Border = 0
                ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                TableContadoresGenerales.AddCell(ColContadoresGen)

                Select Case vuelta


                    Case 0

                        ColContadoresGen = New PdfPCell(New Phrase("TOTAL DIRECCIÓN", Font8BOLD))
                        ColContadoresGen.Border = 0
                        ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                        TableContadoresGenerales.AddCell(ColContadoresGen)



                    Case 1

                        ColContadoresGen = New PdfPCell(New Phrase("TOTAL GENERAL", Font8BOLD))
                        ColContadoresGen.Border = 0
                        ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                        TableContadoresGenerales.AddCell(ColContadoresGen)



                End Select



                ColContadoresGen = New PdfPCell(New Phrase(contadorGeneralGeneral, Font8BOLD))
                ColContadoresGen.Border = 0
                ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableContadoresGenerales.AddCell(ColContadoresGen)


                ColContadoresGen = New PdfPCell(New Phrase(contadorCumplidasGeneral, Font8BOLD))
                ColContadoresGen.Border = 0
                ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableContadoresGenerales.AddCell(ColContadoresGen)


                ColContadoresGen = New PdfPCell(New Phrase(contadorxVencerGeneral, Font8BOLD))
                ColContadoresGen.Border = 0
                ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableContadoresGenerales.AddCell(ColContadoresGen)


                ColContadoresGen = New PdfPCell(New Phrase(contadorVencidasGeneral, Font8BOLD))
                ColContadoresGen.Border = 0
                ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableContadoresGenerales.AddCell(ColContadoresGen)

                vuelta = vuelta + 1

            End While

            pdfDoc.Add(TableContadoresGenerales)



            pdfDoc.Close()




        Catch ex As Exception

            MessageBox.Show(ex.ToString())

        End Try

        Try
            Dim psi As New ProcessStartInfo(cadenafolderDocAn & "\CIS-TipoQueja_SD_" & fechaInicial & "_" & fechaFinal & ".pdf")
            'psi.WorkingDirectory = cadenafolder & "\factura\" + nombresespacios

            psi.WindowStyle = ProcessWindowStyle.Hidden
            Dim p As Process = Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("error al visualizar el pdf" & ex.Message)
        End Try

    End Sub


    Public Sub GenerarReporteTipoQueja(fechaInicioP As Date, FechaFinP As Date, direccionP As String, departamentoP As String, detalleReporteP As Boolean)


        Dim contadorCumplidasGeneral As Short = 0
        Dim contadorxVencerGeneral As Short = 0
        Dim contadorVencidasGeneral As Short = 0
        Dim contadorGeneralGeneral As Short = 0

        Dim fechaInicial As String = UnixDateFormat(fechaInicioP)
        Dim fechaFinal As String = UnixDateFormat(FechaFinP)
        Dim rutaArchivo As String = ""
        Dim direccionEmpresa As String

        Dim datosOrganismo As IDataReader = ConsultaSql("select * from empresa").ExecuteReader
        datosOrganismo.Read()

        direccionEmpresa = $" {datosOrganismo("CDOMICILIO")}, {datosOrganismo("CCOLONIA")}, {datosOrganismo("CPOBLACION")}, {datosOrganismo("ESTADO")}, CP: {datosOrganismo("CCODPOS")} "





        Dim cadenafolderDocAn As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Reportes_OrdServicio\" & Year(Now) & acompletacero(Month(Now).ToString(), 2)).Trim

        If Not Directory.Exists(cadenafolderDocAn) Then
            Directory.CreateDirectory(cadenafolderDocAn)
        End If

        Try


            Using pdfDoc As New Document(iTextSharp.text.PageSize.LETTER, 30.0F, 30.0F, 30.0F, 30.0F)

                Using pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(cadenafolderDocAn & "\CIS-TipoQueja_Det_" & fechaInicial & "_" & fechaFinal & ".pdf", FileMode.Create))



                    Dim Font7 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 7, iTextSharp.text.Font.NORMAL))
                    Dim Font7BOLD As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 7, iTextSharp.text.Font.BOLD))
                    Dim Font8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL))
                    Dim Font8BOLD As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD))
                    Dim Font9 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 9, iTextSharp.text.Font.NORMAL))
                    Dim Font9BOLD As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 9, iTextSharp.text.Font.BOLD))
                    Dim Font10 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.NORMAL))
                    Dim Font10BOLD As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.BOLD))


                    pdfDoc.Open()



                    'ENCABEZADO
                    Dim Table1 As PdfPTable = New PdfPTable(2)
                    Table1.DefaultCell.Border = BorderStyle.None
                    Dim Col1 As PdfPCell
                    Table1.WidthPercentage = 100

                    Dim widths As Single() = New Single() {100.0F, 800.0F}
                    Table1.SetWidths(widths)


                    Dim imagenBMP As iTextSharp.text.Image
                    imagenBMP = iTextSharp.text.Image.GetInstance(LOGOBYTE)
                    imagenBMP.ScaleToFit(80.0F, 70.0F)
                    imagenBMP.Border = 0

                    Table1.AddCell(imagenBMP)


                    Dim TableEspacio As PdfPTable = New PdfPTable(1)
                    Dim ColEsp As PdfPCell
                    TableEspacio.WidthPercentage = 100
                    Dim widthsTE As Single() = New Single() {1000.0F}
                    TableEspacio.SetWidths(widthsTE)

                    ColEsp = New PdfPCell(New Phrase(" ", Font10BOLD))
                    ColEsp.Border = 0
                    ColEsp.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    TableEspacio.AddCell(ColEsp)



                    Dim TableTitulo As PdfPTable = New PdfPTable(1)
                    Col1 = New PdfPCell(New Phrase(datosOrganismo("CNOMBRE"), Font10BOLD))
                    Col1.Border = 0
                    Col1.HorizontalAlignment = PdfPCell.ALIGN_CENTER


                    Dim Col1rfe = New PdfPCell(New Phrase($"{direccionEmpresa}", Font8))
                    Col1rfe.Border = 0
                    Col1rfe.HorizontalAlignment = PdfPCell.ALIGN_CENTER


                    TableTitulo.AddCell(Col1)
                    TableTitulo.AddCell(Col1rfe)
                    Table1.AddCell(TableTitulo)





                    Dim TableTituloReporte As PdfPTable = New PdfPTable(1)

                    TableTituloReporte.WidthPercentage = 100
                    Dim widthsTRepor As Single() = New Single() {1000.0F}
                    TableTituloReporte.SetWidths(widthsTRepor)

                    Dim ColTitRep = New PdfPCell(New Phrase("REPORTE DE CIS POR TIPO DE QUEJA A DETALLE POR DEPARTAMENTO", Font9BOLD))
                    ColTitRep.Border = 0
                    ColTitRep.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                    TableTituloReporte.AddCell(ColTitRep)



                    Dim TableEncabezado As PdfPTable = New PdfPTable(6)

                    TableEncabezado.WidthPercentage = 100
                    Dim widthsEncabez As Single() = New Single() {40.0F, 30.0F, 20.0F, 60.0F, 50.0F, 50.0F}
                    TableEncabezado.SetWidths(widthsEncabez)


                    Dim ColEnc1 = New PdfPCell(New Phrase("PERIODO DEL: ", Font8BOLD))
                    ColEnc1.Border = 0
                    ColEnc1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    TableEncabezado.AddCell(ColEnc1)

                    ColEnc1 = New PdfPCell(New Phrase($"{fechaInicioP.ToString("dd-MM-yyyy")}", Font8))
                    ColEnc1.Border = 0
                    ColEnc1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    TableEncabezado.AddCell(ColEnc1)

                    ColEnc1 = New PdfPCell(New Phrase("AL: ", Font8BOLD))
                    ColEnc1.Border = 0
                    ColEnc1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    TableEncabezado.AddCell(ColEnc1)

                    ColEnc1 = New PdfPCell(New Phrase($"{FechaFinP.ToString("dd-MM-yyyy")}", Font8))
                    ColEnc1.Border = 0
                    ColEnc1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    TableEncabezado.AddCell(ColEnc1)

                    ColEnc1 = New PdfPCell(New Phrase("FECHA DE EMISIÓN: ", Font8BOLD))
                    ColEnc1.Border = 0
                    ColEnc1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    TableEncabezado.AddCell(ColEnc1)

                    ColEnc1 = New PdfPCell(New Phrase($"{DateTime.Now.ToString("dd-MM-yyyy")}", Font8))
                    ColEnc1.Border = 0
                    ColEnc1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    TableEncabezado.AddCell(ColEnc1)




                    Dim TableTituloReporte2 As PdfPTable = New PdfPTable(1)

                    TableTituloReporte2.WidthPercentage = 100
                    Dim widthsTRepor2 As Single() = New Single() {1000.0F}
                    TableTituloReporte2.SetWidths(widthsTRepor2)

                    Dim ColTitRep2 = New PdfPCell(New Phrase($"DIRECCIÓN: {direccionP}", Font9BOLD))
                    ColTitRep2.Border = 0
                    ColTitRep2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    TableTituloReporte2.AddCell(ColTitRep2)

                    ColTitRep2 = New PdfPCell(New Phrase($" ", Font9BOLD))
                    ColTitRep2.Border = 0
                    ColTitRep2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    TableTituloReporte2.AddCell(ColTitRep2)

                    Dim departamento = obtenerCampo($"SELECT NOMBRE FROM DEPTOS WHERE COD_DEP = '{departamentoP}'", "NOMBRE")
                    ColTitRep2 = New PdfPCell(New Phrase($"DEPARTAMENTO: {departamento}", Font9BOLD))
                    ColTitRep2.Border = 0
                    ColTitRep2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    TableTituloReporte2.AddCell(ColTitRep2)



                    pdfDoc.Add(Table1)
                    pdfDoc.Add(TableEncabezado)
                    pdfDoc.Add(TableTituloReporte2)

                    Dim ordenesFueraDeRango As String = ""

                    Dim sql = $"SELECT COD_CVE, DESCRIPCION_QUEJA FROM VORDENT WHERE FEC_ORD BETWEEN '{fechaInicial}' AND '{fechaFinal}' AND COD_DIR = '{direccionP}' AND COD_RES = '{departamentoP}' GROUP BY COD_CVE ORDER BY COD_CVE ASC"
                    Dim datosConceptosAgrupados As IDataReader = ConsultaSql(sql).ExecuteReader

                    Dim vueltaTablaEncabezados As Short = 0


                    While datosConceptosAgrupados.Read()

                        Dim contadorGeneral As Short = 0
                        Dim contadorCumplidas As Short = 0
                        Dim contadorxVencer As Short = 0
                        Dim contadorVencidas As Short = 0

                        Dim codigoProblema As String = ""
                        Dim descripcionProblema As String = ""
                        Dim folioOrdTrabajo As Integer

                        codigoProblema = datosConceptosAgrupados("COD_CVE")
                        descripcionProblema = datosConceptosAgrupados("DESCRIPCION_QUEJA")

                        Dim TableCuerpoReporte As PdfPTable = New PdfPTable(6)

                        TableCuerpoReporte.WidthPercentage = 100
                        Dim widthsCuerpoReporte As Single() = New Single() {40.0F, 100.0F, 40.0F, 40.0F, 40.0F, 40.0F}
                        TableCuerpoReporte.SetWidths(widthsCuerpoReporte)

                        Dim ColCuerpo1 = New PdfPCell

                        If vueltaTablaEncabezados = 0 Then



                            ColCuerpo1 = New PdfPCell(New Phrase("CLAVE", Font8BOLD))
                            ColCuerpo1.Border = 0
                            ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                            TableCuerpoReporte.AddCell(ColCuerpo1)


                            ColCuerpo1 = New PdfPCell(New Phrase("DESCRIPCION", Font8BOLD))
                            ColCuerpo1.Border = 0
                            ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                            TableCuerpoReporte.AddCell(ColCuerpo1)


                            ColCuerpo1 = New PdfPCell(New Phrase("RECIBIDAS", Font8BOLD))
                            ColCuerpo1.Border = 0
                            ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                            TableCuerpoReporte.AddCell(ColCuerpo1)


                            ColCuerpo1 = New PdfPCell(New Phrase("CUMPLIDAS", Font8BOLD))
                            ColCuerpo1.Border = 0
                            ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                            TableCuerpoReporte.AddCell(ColCuerpo1)


                            ColCuerpo1 = New PdfPCell(New Phrase("X/VENCER", Font8BOLD))
                            ColCuerpo1.Border = 0
                            ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                            TableCuerpoReporte.AddCell(ColCuerpo1)


                            ColCuerpo1 = New PdfPCell(New Phrase("VENCIDAS", Font8BOLD))
                            ColCuerpo1.Border = 0
                            ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                            TableCuerpoReporte.AddCell(ColCuerpo1)

                        End If

                        If vueltaTablaEncabezados = 0 Or vueltaTablaEncabezados > 0 Then


                            ColCuerpo1 = New PdfPCell(New Phrase($"{codigoProblema}", Font8))
                            ColCuerpo1.Border = 0
                            ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                            ColCuerpo1.PaddingTop = 15
                            ColCuerpo1.PaddingBottom = 5
                            TableCuerpoReporte.AddCell(ColCuerpo1)


                            ColCuerpo1 = New PdfPCell(New Phrase($"{descripcionProblema}", Font8))
                            ColCuerpo1.Border = 0
                            ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                            ColCuerpo1.PaddingTop = 15
                            ColCuerpo1.PaddingBottom = 5
                            TableCuerpoReporte.AddCell(ColCuerpo1)




                            Dim sql2 As String = ""

                            sql2 = $"SELECT FOLIO FROM VORDENT WHERE FEC_ORD BETWEEN '{fechaInicial}' AND '{fechaFinal}' AND COD_DIR = '{direccionP}' AND COD_RES = '{departamentoP}' AND COD_CVE = {codigoProblema} AND STATUS <> 'CANCELADA'"

                            Dim datosOrdenesTrabajo As IDataReader = ConsultaSql(sql2).ExecuteReader

                            While datosOrdenesTrabajo.Read()



                                folioOrdTrabajo = datosOrdenesTrabajo("FOLIO")


                                'Crear Método para calcular los días de la orden de trabajo
                                Dim estatus = CalcularEstatusOrdenTrabajo(folioOrdTrabajo)


                                Select Case estatus
                                    Case 1

                                        contadorCumplidas = contadorCumplidas + 1
                                        contadorCumplidasGeneral = contadorCumplidasGeneral + 1
                                    Case 2

                                        contadorxVencer = contadorxVencer + 1
                                        contadorxVencerGeneral = contadorxVencerGeneral + 1
                                    Case 3

                                        contadorVencidas = contadorVencidas + 1
                                        contadorVencidasGeneral = contadorVencidasGeneral + 1
                                    Case Else

                                        ordenesFueraDeRango = $"{ordenesFueraDeRango}, {folioOrdTrabajo}"
                                End Select

                                contadorGeneral = contadorGeneral + 1
                                contadorGeneralGeneral = contadorGeneralGeneral + 1

                            End While


                            ColCuerpo1 = New PdfPCell(New Phrase($"{contadorGeneral}", Font8))
                            ColCuerpo1.Border = 0
                            ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                            ColCuerpo1.PaddingTop = 15
                            ColCuerpo1.PaddingBottom = 5
                            TableCuerpoReporte.AddCell(ColCuerpo1)

                            ColCuerpo1 = New PdfPCell(New Phrase($"{contadorCumplidas}", Font8))
                            ColCuerpo1.Border = 0
                            ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                            ColCuerpo1.PaddingTop = 15
                            ColCuerpo1.PaddingBottom = 5
                            TableCuerpoReporte.AddCell(ColCuerpo1)


                            ColCuerpo1 = New PdfPCell(New Phrase($"{contadorxVencer}", Font8))
                            ColCuerpo1.Border = 0
                            ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                            ColCuerpo1.PaddingTop = 15
                            ColCuerpo1.PaddingBottom = 5
                            TableCuerpoReporte.AddCell(ColCuerpo1)


                            ColCuerpo1 = New PdfPCell(New Phrase($"{contadorVencidas}", Font8))
                            ColCuerpo1.Border = 0
                            ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                            ColCuerpo1.PaddingTop = 15
                            ColCuerpo1.PaddingBottom = 5
                            TableCuerpoReporte.AddCell(ColCuerpo1)


                        End If

                        Dim sql3 As String = ""

                        sql3 = $"SELECT FOLIO, NOMBRE FROM VORDENT WHERE FEC_ORD BETWEEN '{fechaInicial}' AND '{fechaFinal}' AND COD_DIR = '{direccionP}' AND COD_RES = '{departamentoP}' AND COD_CVE = {codigoProblema} AND STATUS <> 'CANCELADA'"

                        Dim datosOrdenesxUsuario As IDataReader = ConsultaSql(sql3).ExecuteReader


                        Dim TableRegistrosxUsuario As PdfPTable = New PdfPTable(6)

                        TableRegistrosxUsuario.WidthPercentage = 100
                        Dim widthsRegxUsuario As Single() = New Single() {40.0F, 100.0F, 40.0F, 40.0F, 40.0F, 40.0F}
                        TableRegistrosxUsuario.SetWidths(widthsRegxUsuario)


                        While datosOrdenesxUsuario.Read()

                            Dim contadorxUsuarioCumplida As Int16 = 0
                            Dim contadorxUsuarioxVencer As Int16 = 0
                            Dim contadorxUsuarioVencida As Int16 = 0

                            Dim folioOrdTrabajoxUsuario As Integer = 0
                            Dim nombreOrdTrabajoxUsuario As String = ""


                            folioOrdTrabajoxUsuario = datosOrdenesxUsuario("FOLIO")
                            nombreOrdTrabajoxUsuario = datosOrdenesxUsuario("NOMBRE")


                            Dim ColCuerpoxUsuario = New PdfPCell(New Phrase($"{folioOrdTrabajoxUsuario}", Font7))
                            ColCuerpoxUsuario.Border = 0
                            ColCuerpoxUsuario.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                            TableRegistrosxUsuario.AddCell(ColCuerpoxUsuario)

                            ColCuerpoxUsuario = New PdfPCell(New Phrase($"{nombreOrdTrabajoxUsuario}", Font7))
                            ColCuerpoxUsuario.Border = 0
                            ColCuerpoxUsuario.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                            TableRegistrosxUsuario.AddCell(ColCuerpoxUsuario)

                            ColCuerpoxUsuario = New PdfPCell(New Phrase($" ", Font7))
                            ColCuerpoxUsuario.Border = 0
                            ColCuerpoxUsuario.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                            TableRegistrosxUsuario.AddCell(ColCuerpoxUsuario)

                            Dim estatus = CalcularEstatusOrdenTrabajo(folioOrdTrabajoxUsuario)


                            Select Case estatus
                                Case 1

                                    contadorxUsuarioCumplida = contadorxUsuarioCumplida + 1

                                Case 2

                                    contadorxUsuarioxVencer = contadorxUsuarioxVencer + 1

                                Case 3

                                    contadorxUsuarioVencida = contadorxUsuarioVencida + 1

                                Case Else

                                    ordenesFueraDeRango = $"{ordenesFueraDeRango}, {folioOrdTrabajo}"
                            End Select

                            ColCuerpoxUsuario = New PdfPCell(New Phrase($"{contadorxUsuarioCumplida}", Font7))
                            ColCuerpoxUsuario.Border = 0
                            ColCuerpoxUsuario.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                            TableRegistrosxUsuario.AddCell(ColCuerpoxUsuario)

                            ColCuerpoxUsuario = New PdfPCell(New Phrase($"{contadorxUsuarioxVencer}", Font7))
                            ColCuerpoxUsuario.Border = 0
                            ColCuerpoxUsuario.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                            TableRegistrosxUsuario.AddCell(ColCuerpoxUsuario)

                            ColCuerpoxUsuario = New PdfPCell(New Phrase($"{contadorxUsuarioVencida}", Font7))
                            ColCuerpoxUsuario.Border = 0
                            ColCuerpoxUsuario.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                            TableRegistrosxUsuario.AddCell(ColCuerpoxUsuario)



                        End While

                        pdfDoc.Add(TableCuerpoReporte)

                        pdfDoc.Add(TableRegistrosxUsuario)

                        vueltaTablaEncabezados = vueltaTablaEncabezados + 1

                    End While



                    Dim TableContadoresGenerales As PdfPTable = New PdfPTable(6)

                    TableContadoresGenerales.WidthPercentage = 100
                    TableContadoresGenerales.SpacingBefore = 5
                    Dim widthsContadoresGen As Single() = New Single() {40.0F, 100.0F, 40.0F, 40.0F, 40.0F, 40.0F}
                    TableContadoresGenerales.SetWidths(widthsContadoresGen)

                    Dim vuelta As Short = 0

                    Dim ColContadoresGen = New PdfPCell()

                    While vuelta <= 2

                        ColContadoresGen = New PdfPCell(New Phrase("", Font8BOLD))
                        ColContadoresGen.Border = 0
                        ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                        TableContadoresGenerales.AddCell(ColContadoresGen)

                        Select Case vuelta

                            Case 0

                                ColContadoresGen = New PdfPCell(New Phrase("TOTAL DEPARTAMENTO", Font8BOLD))
                                ColContadoresGen.Border = 0
                                ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                                TableContadoresGenerales.AddCell(ColContadoresGen)


                            Case 1

                                ColContadoresGen = New PdfPCell(New Phrase("TOTAL DIRECCIÓN", Font8BOLD))
                                ColContadoresGen.Border = 0
                                ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                                TableContadoresGenerales.AddCell(ColContadoresGen)



                            Case 2

                                ColContadoresGen = New PdfPCell(New Phrase("TOTAL GENERAL", Font8BOLD))
                                ColContadoresGen.Border = 0
                                ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                                TableContadoresGenerales.AddCell(ColContadoresGen)



                        End Select



                        ColContadoresGen = New PdfPCell(New Phrase(contadorGeneralGeneral, Font8BOLD))
                        ColContadoresGen.Border = 0
                        ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                        TableContadoresGenerales.AddCell(ColContadoresGen)


                        ColContadoresGen = New PdfPCell(New Phrase(contadorCumplidasGeneral, Font8BOLD))
                        ColContadoresGen.Border = 0
                        ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                        TableContadoresGenerales.AddCell(ColContadoresGen)


                        ColContadoresGen = New PdfPCell(New Phrase(contadorxVencerGeneral, Font8BOLD))
                        ColContadoresGen.Border = 0
                        ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                        TableContadoresGenerales.AddCell(ColContadoresGen)


                        ColContadoresGen = New PdfPCell(New Phrase(contadorVencidasGeneral, Font8BOLD))
                        ColContadoresGen.Border = 0
                        ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                        TableContadoresGenerales.AddCell(ColContadoresGen)

                        vuelta = vuelta + 1

                    End While

                    pdfDoc.Add(TableContadoresGenerales)

                    ' pdfDoc
                    pdfDoc.Close()

                End Using

            End Using



        Catch ex As Exception

            MessageBox.Show(ex.ToString())

        End Try

        Try
            rutaArchivo = cadenafolderDocAn & "\CIS-TipoQueja_Det_" & fechaInicial & "_" & fechaFinal & ".pdf"

            'OperacionesItextSharp.NumerarPDF(rutaArchivo)

            'Previsualizar reporte
            Dim psi As New ProcessStartInfo(rutaArchivo)
            'psi.WorkingDirectory = cadenafolder & "\factura\" + nombresespacios

            psi.WindowStyle = ProcessWindowStyle.Hidden
            Dim p As Process = Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("error al visualizar el pdf" & ex.Message)
        End Try

    End Sub
    Public Sub GenerarReporteTipoQueja(fechaInicioP As Date, FechaFinP As Date, direccionP As String, detalleReporteP As Boolean)


        Dim contadorCumplidasGeneral As Short = 0
        Dim contadorxVencerGeneral As Short = 0
        Dim contadorVencidasGeneral As Short = 0
        Dim contadorGeneralGeneral As Short = 0

        Dim fechaInicial As String = UnixDateFormat(fechaInicioP)
        Dim fechaFinal As String = UnixDateFormat(FechaFinP)
        Dim rutaArchivo As String = ""
        Dim direccionEmpresa As String

        Dim datosOrganismo As IDataReader = ConsultaSql("select * from empresa").ExecuteReader
        datosOrganismo.Read()

        direccionEmpresa = $" {datosOrganismo("CDOMICILIO")}, {datosOrganismo("CCOLONIA")}, {datosOrganismo("CPOBLACION")}, {datosOrganismo("ESTADO")}, CP: {datosOrganismo("CCODPOS")} "





        Dim cadenafolderDocAn As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Reportes_OrdServicio\" & Year(Now) & acompletacero(Month(Now).ToString(), 2)).Trim

        If Not Directory.Exists(cadenafolderDocAn) Then
            Directory.CreateDirectory(cadenafolderDocAn)
        End If

        Try


            Using pdfDoc As New Document(iTextSharp.text.PageSize.LETTER, 30.0F, 30.0F, 30.0F, 30.0F)

                Using pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(cadenafolderDocAn & "\CIS-TipoQueja_Det_SD" & fechaInicial & "_" & fechaFinal & ".pdf", FileMode.Create))



                    Dim Font7 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 7, iTextSharp.text.Font.NORMAL))
                    Dim Font7BOLD As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 7, iTextSharp.text.Font.BOLD))
                    Dim Font8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL))
                    Dim Font8BOLD As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD))
                    Dim Font9 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 9, iTextSharp.text.Font.NORMAL))
                    Dim Font9BOLD As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 9, iTextSharp.text.Font.BOLD))
                    Dim Font10 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.NORMAL))
                    Dim Font10BOLD As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.BOLD))


                    pdfDoc.Open()



                    'ENCABEZADO
                    Dim Table1 As PdfPTable = New PdfPTable(2)
                    Table1.DefaultCell.Border = BorderStyle.None
                    Dim Col1 As PdfPCell
                    Table1.WidthPercentage = 100

                    Dim widths As Single() = New Single() {100.0F, 800.0F}
                    Table1.SetWidths(widths)


                    Dim imagenBMP As iTextSharp.text.Image
                    imagenBMP = iTextSharp.text.Image.GetInstance(LOGOBYTE)
                    imagenBMP.ScaleToFit(80.0F, 70.0F)
                    imagenBMP.Border = 0

                    Table1.AddCell(imagenBMP)


                    Dim TableEspacio As PdfPTable = New PdfPTable(1)
                    Dim ColEsp As PdfPCell
                    TableEspacio.WidthPercentage = 100
                    Dim widthsTE As Single() = New Single() {1000.0F}
                    TableEspacio.SetWidths(widthsTE)

                    ColEsp = New PdfPCell(New Phrase(" ", Font10BOLD))
                    ColEsp.Border = 0
                    ColEsp.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    TableEspacio.AddCell(ColEsp)



                    Dim TableTitulo As PdfPTable = New PdfPTable(1)
                    Col1 = New PdfPCell(New Phrase(datosOrganismo("CNOMBRE"), Font10BOLD))
                    Col1.Border = 0
                    Col1.HorizontalAlignment = PdfPCell.ALIGN_CENTER


                    Dim Col1rfe = New PdfPCell(New Phrase($"{direccionEmpresa}", Font8))
                    Col1rfe.Border = 0
                    Col1rfe.HorizontalAlignment = PdfPCell.ALIGN_CENTER


                    TableTitulo.AddCell(Col1)
                    TableTitulo.AddCell(Col1rfe)
                    Table1.AddCell(TableTitulo)





                    Dim TableTituloReporte As PdfPTable = New PdfPTable(1)

                    TableTituloReporte.WidthPercentage = 100
                    Dim widthsTRepor As Single() = New Single() {1000.0F}
                    TableTituloReporte.SetWidths(widthsTRepor)

                    Dim ColTitRep = New PdfPCell(New Phrase("REPORTE DE CIS POR TIPO DE QUEJA A DETALLE POR DEPARTAMENTO", Font9BOLD))
                    ColTitRep.Border = 0
                    ColTitRep.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                    TableTituloReporte.AddCell(ColTitRep)



                    Dim TableEncabezado As PdfPTable = New PdfPTable(6)

                    TableEncabezado.WidthPercentage = 100
                    Dim widthsEncabez As Single() = New Single() {40.0F, 30.0F, 20.0F, 60.0F, 50.0F, 50.0F}
                    TableEncabezado.SetWidths(widthsEncabez)


                    Dim ColEnc1 = New PdfPCell(New Phrase("PERIODO DEL: ", Font8BOLD))
                    ColEnc1.Border = 0
                    ColEnc1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    TableEncabezado.AddCell(ColEnc1)

                    ColEnc1 = New PdfPCell(New Phrase($"{fechaInicioP.ToString("dd-MM-yyyy")}", Font8))
                    ColEnc1.Border = 0
                    ColEnc1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    TableEncabezado.AddCell(ColEnc1)

                    ColEnc1 = New PdfPCell(New Phrase("AL: ", Font8BOLD))
                    ColEnc1.Border = 0
                    ColEnc1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    TableEncabezado.AddCell(ColEnc1)

                    ColEnc1 = New PdfPCell(New Phrase($"{FechaFinP.ToString("dd-MM-yyyy")}", Font8))
                    ColEnc1.Border = 0
                    ColEnc1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    TableEncabezado.AddCell(ColEnc1)

                    ColEnc1 = New PdfPCell(New Phrase("FECHA DE EMISIÓN: ", Font8BOLD))
                    ColEnc1.Border = 0
                    ColEnc1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    TableEncabezado.AddCell(ColEnc1)

                    ColEnc1 = New PdfPCell(New Phrase($"{DateTime.Now.ToString("dd-MM-yyyy")}", Font8))
                    ColEnc1.Border = 0
                    ColEnc1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    TableEncabezado.AddCell(ColEnc1)



                    pdfDoc.Add(Table1)
                    pdfDoc.Add(TableEncabezado)




                    Dim sqlDeptos = $"SELECT DEPARTAMENTO FROM VORDENT WHERE FEC_ORD BETWEEN '{fechaInicial}' AND '{fechaFinal}' AND COD_DIR = '{direccionP}' GROUP BY DEPARTAMENTO ORDER BY DEPARTAMENTO ASC"
                    Dim datosDeptosAgrupados As IDataReader = ConsultaSql(sqlDeptos).ExecuteReader
                    Dim vueltaDireccion As Short = 0


                    While datosDeptosAgrupados.Read()

                        Dim contadoraGeneralxDepartamento As Short = 0
                        Dim contadoraCumplidasxDepartamento As Short = 0
                        Dim contadoraxVencerxDepartamento As Short = 0
                        Dim contadoraVencidasxDepartamento As Short = 0

                        Dim TableTituloReporte2 As PdfPTable = New PdfPTable(1)

                        TableTituloReporte2.WidthPercentage = 100
                        Dim widthsTRepor2 As Single() = New Single() {1000.0F}
                        TableTituloReporte2.SetWidths(widthsTRepor2)

                        Dim ColTitRep2 = New PdfPCell()


                        If vueltaDireccion <= 0 Then

                            Dim nombreDpto = obtenerCampo($"SELECT NOMBRE FROM DIREC WHERE COD_DIR = '{direccionP}'", "NOMBRE")
                            ColTitRep2 = New PdfPCell(New Phrase($"DIRECCIÓN: {nombreDpto}", Font9BOLD))
                            ColTitRep2.Border = 0
                            ColTitRep2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                            TableTituloReporte2.AddCell(ColTitRep2)

                        Else

                            ColTitRep2 = New PdfPCell(New Phrase($" ", Font9BOLD))
                            ColTitRep2.Border = 0
                            ColTitRep2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                            TableTituloReporte2.AddCell(ColTitRep2)

                        End If

                        ColTitRep2 = New PdfPCell(New Phrase($" ", Font9BOLD))
                        ColTitRep2.Border = 0
                        ColTitRep2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                        TableTituloReporte2.AddCell(ColTitRep2)

                        Dim departamentoVuelta As String = datosDeptosAgrupados("Departamento")

                        Dim codigoDepartamento = obtenerCampo($"SELECT COD_DEP FROM DEPTOS WHERE NOMBRE = '{departamentoVuelta}'", "COD_DEP")
                        Dim ColTitRep3 = New PdfPCell(New Phrase($"DEPARTAMENTO: {departamentoVuelta}", Font9BOLD))
                        ColTitRep3.Border = 0
                        ColTitRep3.PaddingBottom = 5
                        ColTitRep3.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                        TableTituloReporte2.AddCell(ColTitRep3)


                        pdfDoc.Add(TableTituloReporte2)


                        Dim ordenesFueraDeRango As String = ""

                        Dim sql = $"SELECT COD_CVE, DESCRIPCION_QUEJA FROM VORDENT WHERE FEC_ORD BETWEEN '{fechaInicial}' AND '{fechaFinal}' AND COD_DIR = '{direccionP}' AND COD_RES = '{codigoDepartamento}' GROUP BY COD_CVE ORDER BY COD_CVE ASC"
                        Dim datosConceptosAgrupados As IDataReader = ConsultaSql(sql).ExecuteReader

                        Dim vueltaTablaEncabezados As Short = 0


                        While datosConceptosAgrupados.Read()

                            Dim contadorGeneral As Short = 0
                            Dim contadorCumplidas As Short = 0
                            Dim contadorxVencer As Short = 0
                            Dim contadorVencidas As Short = 0

                            Dim codigoProblema As String = ""
                            Dim descripcionProblema As String = ""
                            Dim folioOrdTrabajo As Integer

                            codigoProblema = datosConceptosAgrupados("COD_CVE")
                            descripcionProblema = datosConceptosAgrupados("DESCRIPCION_QUEJA")

                            Dim TableCuerpoReporte As PdfPTable = New PdfPTable(6)

                            TableCuerpoReporte.WidthPercentage = 100
                            Dim widthsCuerpoReporte As Single() = New Single() {40.0F, 100.0F, 40.0F, 40.0F, 40.0F, 40.0F}
                            TableCuerpoReporte.SetWidths(widthsCuerpoReporte)

                            Dim ColCuerpo1 = New PdfPCell

                            If vueltaTablaEncabezados = 0 Then



                                ColCuerpo1 = New PdfPCell(New Phrase("CLAVE", Font8BOLD))
                                ColCuerpo1.Border = 0
                                ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                                TableCuerpoReporte.AddCell(ColCuerpo1)


                                ColCuerpo1 = New PdfPCell(New Phrase("DESCRIPCION", Font8BOLD))
                                ColCuerpo1.Border = 0
                                ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                                TableCuerpoReporte.AddCell(ColCuerpo1)


                                ColCuerpo1 = New PdfPCell(New Phrase("RECIBIDAS", Font8BOLD))
                                ColCuerpo1.Border = 0
                                ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                                TableCuerpoReporte.AddCell(ColCuerpo1)


                                ColCuerpo1 = New PdfPCell(New Phrase("CUMPLIDAS", Font8BOLD))
                                ColCuerpo1.Border = 0
                                ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                                TableCuerpoReporte.AddCell(ColCuerpo1)


                                ColCuerpo1 = New PdfPCell(New Phrase("X/VENCER", Font8BOLD))
                                ColCuerpo1.Border = 0
                                ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                                TableCuerpoReporte.AddCell(ColCuerpo1)


                                ColCuerpo1 = New PdfPCell(New Phrase("VENCIDAS", Font8BOLD))
                                ColCuerpo1.Border = 0
                                ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                                TableCuerpoReporte.AddCell(ColCuerpo1)

                            End If

                            If vueltaTablaEncabezados = 0 Or vueltaTablaEncabezados > 0 Then


                                ColCuerpo1 = New PdfPCell(New Phrase($"{codigoProblema}", Font8))
                                ColCuerpo1.Border = 0
                                ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                                ColCuerpo1.PaddingTop = 15
                                ColCuerpo1.PaddingBottom = 5
                                TableCuerpoReporte.AddCell(ColCuerpo1)


                                ColCuerpo1 = New PdfPCell(New Phrase($"{descripcionProblema}", Font8))
                                ColCuerpo1.Border = 0
                                ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                                ColCuerpo1.PaddingTop = 15
                                ColCuerpo1.PaddingBottom = 5
                                TableCuerpoReporte.AddCell(ColCuerpo1)




                                Dim sql2 As String = ""

                                sql2 = $"SELECT FOLIO FROM VORDENT WHERE FEC_ORD BETWEEN '{fechaInicial}' AND '{fechaFinal}' AND COD_DIR = '{direccionP}' AND COD_RES = '{codigoDepartamento}' AND COD_CVE = {codigoProblema} AND STATUS <> 'CANCELADA'"

                                Dim datosOrdenesTrabajo As IDataReader = ConsultaSql(sql2).ExecuteReader

                                While datosOrdenesTrabajo.Read()



                                    folioOrdTrabajo = datosOrdenesTrabajo("FOLIO")


                                    'Crear Método para calcular los días de la orden de trabajo
                                    Dim estatus = CalcularEstatusOrdenTrabajo(folioOrdTrabajo)


                                    Select Case estatus
                                        Case 1

                                            contadorCumplidas = contadorCumplidas + 1
                                            contadorCumplidasGeneral = contadorCumplidasGeneral + 1
                                        Case 2

                                            contadorxVencer = contadorxVencer + 1
                                            contadorxVencerGeneral = contadorxVencerGeneral + 1
                                        Case 3

                                            contadorVencidas = contadorVencidas + 1
                                            contadorVencidasGeneral = contadorVencidasGeneral + 1
                                        Case Else

                                            ordenesFueraDeRango = $"{ordenesFueraDeRango}, {folioOrdTrabajo}"
                                    End Select

                                    contadorGeneral = contadorGeneral + 1
                                    contadorGeneralGeneral = contadorGeneralGeneral + 1

                                End While


                                ColCuerpo1 = New PdfPCell(New Phrase($"{contadorGeneral}", Font8))
                                ColCuerpo1.Border = 0
                                ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                                ColCuerpo1.PaddingTop = 15
                                ColCuerpo1.PaddingBottom = 5
                                TableCuerpoReporte.AddCell(ColCuerpo1)

                                ColCuerpo1 = New PdfPCell(New Phrase($"{contadorCumplidas}", Font8))
                                ColCuerpo1.Border = 0
                                ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                                ColCuerpo1.PaddingTop = 15
                                ColCuerpo1.PaddingBottom = 5
                                TableCuerpoReporte.AddCell(ColCuerpo1)


                                ColCuerpo1 = New PdfPCell(New Phrase($"{contadorxVencer}", Font8))
                                ColCuerpo1.Border = 0
                                ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                                ColCuerpo1.PaddingTop = 15
                                ColCuerpo1.PaddingBottom = 5
                                TableCuerpoReporte.AddCell(ColCuerpo1)


                                ColCuerpo1 = New PdfPCell(New Phrase($"{contadorVencidas}", Font8))
                                ColCuerpo1.Border = 0
                                ColCuerpo1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                                ColCuerpo1.PaddingTop = 15
                                ColCuerpo1.PaddingBottom = 5
                                TableCuerpoReporte.AddCell(ColCuerpo1)


                            End If

                            Dim sql3 As String = ""

                            sql3 = $"SELECT FOLIO, NOMBRE FROM VORDENT WHERE FEC_ORD BETWEEN '{fechaInicial}' AND '{fechaFinal}' AND COD_DIR = '{direccionP}' AND COD_RES = '{codigoDepartamento}' AND COD_CVE = {codigoProblema} AND STATUS <> 'CANCELADA'"

                            Dim datosOrdenesxUsuario As IDataReader = ConsultaSql(sql3).ExecuteReader


                            Dim TableRegistrosxUsuario As PdfPTable = New PdfPTable(6)

                            TableRegistrosxUsuario.WidthPercentage = 100
                            Dim widthsRegxUsuario As Single() = New Single() {40.0F, 100.0F, 40.0F, 40.0F, 40.0F, 40.0F}
                            TableRegistrosxUsuario.SetWidths(widthsRegxUsuario)


                            While datosOrdenesxUsuario.Read()

                                Dim contadorxUsuarioCumplida As Int16 = 0
                                Dim contadorxUsuarioxVencer As Int16 = 0
                                Dim contadorxUsuarioVencida As Int16 = 0

                                Dim folioOrdTrabajoxUsuario As Integer = 0
                                Dim nombreOrdTrabajoxUsuario As String = ""


                                folioOrdTrabajoxUsuario = datosOrdenesxUsuario("FOLIO")
                                nombreOrdTrabajoxUsuario = datosOrdenesxUsuario("NOMBRE")


                                Dim ColCuerpoxUsuario = New PdfPCell(New Phrase($"{folioOrdTrabajoxUsuario}", Font7))
                                ColCuerpoxUsuario.Border = 0
                                ColCuerpoxUsuario.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                                TableRegistrosxUsuario.AddCell(ColCuerpoxUsuario)

                                ColCuerpoxUsuario = New PdfPCell(New Phrase($"{nombreOrdTrabajoxUsuario}", Font7))
                                ColCuerpoxUsuario.Border = 0
                                ColCuerpoxUsuario.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                                TableRegistrosxUsuario.AddCell(ColCuerpoxUsuario)

                                ColCuerpoxUsuario = New PdfPCell(New Phrase($" ", Font7))
                                ColCuerpoxUsuario.Border = 0
                                ColCuerpoxUsuario.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                                TableRegistrosxUsuario.AddCell(ColCuerpoxUsuario)

                                Dim estatus = CalcularEstatusOrdenTrabajo(folioOrdTrabajoxUsuario)


                                Select Case estatus
                                    Case 1

                                        contadorxUsuarioCumplida = contadorxUsuarioCumplida + 1

                                    Case 2

                                        contadorxUsuarioxVencer = contadorxUsuarioxVencer + 1

                                    Case 3

                                        contadorxUsuarioVencida = contadorxUsuarioVencida + 1

                                    Case Else

                                        ordenesFueraDeRango = $"{ordenesFueraDeRango}, {folioOrdTrabajo}"
                                End Select

                                ColCuerpoxUsuario = New PdfPCell(New Phrase($"{contadorxUsuarioCumplida}", Font7))
                                ColCuerpoxUsuario.Border = 0
                                ColCuerpoxUsuario.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                                TableRegistrosxUsuario.AddCell(ColCuerpoxUsuario)

                                ColCuerpoxUsuario = New PdfPCell(New Phrase($"{contadorxUsuarioxVencer}", Font7))
                                ColCuerpoxUsuario.Border = 0
                                ColCuerpoxUsuario.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                                TableRegistrosxUsuario.AddCell(ColCuerpoxUsuario)

                                ColCuerpoxUsuario = New PdfPCell(New Phrase($"{contadorxUsuarioVencida}", Font7))
                                ColCuerpoxUsuario.Border = 0
                                ColCuerpoxUsuario.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                                TableRegistrosxUsuario.AddCell(ColCuerpoxUsuario)



                            End While

                            pdfDoc.Add(TableCuerpoReporte)

                            pdfDoc.Add(TableRegistrosxUsuario)

                            vueltaTablaEncabezados = vueltaTablaEncabezados + 1

                        End While

                        vueltaDireccion = vueltaDireccion + 1

                    End While

                    Dim TableContadoresGenerales As PdfPTable = New PdfPTable(6)

                    TableContadoresGenerales.WidthPercentage = 100
                    TableContadoresGenerales.SpacingBefore = 5
                    Dim widthsContadoresGen As Single() = New Single() {40.0F, 100.0F, 40.0F, 40.0F, 40.0F, 40.0F}
                    TableContadoresGenerales.SetWidths(widthsContadoresGen)

                    Dim vuelta As Short = 0

                    Dim ColContadoresGen = New PdfPCell()

                    While vuelta <= 1

                        ColContadoresGen = New PdfPCell(New Phrase("", Font8BOLD))
                        ColContadoresGen.Border = 0
                        ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                        TableContadoresGenerales.AddCell(ColContadoresGen)

                        Select Case vuelta




                            Case 0

                                ColContadoresGen = New PdfPCell(New Phrase("TOTAL DIRECCIÓN", Font8BOLD))
                                ColContadoresGen.Border = 0
                                ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                                TableContadoresGenerales.AddCell(ColContadoresGen)



                            Case 1

                                ColContadoresGen = New PdfPCell(New Phrase("TOTAL GENERAL", Font8BOLD))
                                ColContadoresGen.Border = 0
                                ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                                TableContadoresGenerales.AddCell(ColContadoresGen)



                        End Select



                        ColContadoresGen = New PdfPCell(New Phrase(contadorGeneralGeneral, Font8BOLD))
                        ColContadoresGen.Border = 0
                        ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                        TableContadoresGenerales.AddCell(ColContadoresGen)


                        ColContadoresGen = New PdfPCell(New Phrase(contadorCumplidasGeneral, Font8BOLD))
                        ColContadoresGen.Border = 0
                        ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                        TableContadoresGenerales.AddCell(ColContadoresGen)


                        ColContadoresGen = New PdfPCell(New Phrase(contadorxVencerGeneral, Font8BOLD))
                        ColContadoresGen.Border = 0
                        ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                        TableContadoresGenerales.AddCell(ColContadoresGen)


                        ColContadoresGen = New PdfPCell(New Phrase(contadorVencidasGeneral, Font8BOLD))
                        ColContadoresGen.Border = 0
                        ColContadoresGen.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                        TableContadoresGenerales.AddCell(ColContadoresGen)

                        vuelta = vuelta + 1

                    End While

                    pdfDoc.Add(TableContadoresGenerales)

                    ' pdfDoc
                    pdfDoc.Close()

                End Using

            End Using



        Catch ex As Exception

            MessageBox.Show(ex.ToString())

        End Try

        Try
            rutaArchivo = cadenafolderDocAn & "\CIS-TipoQueja_Det_SD" & fechaInicial & "_" & fechaFinal & ".pdf"

            'OperacionesItextSharp.NumerarPDF(rutaArchivo)

            'Previsualizar reporte
            Dim psi As New ProcessStartInfo(rutaArchivo)
            'psi.WorkingDirectory = cadenafolder & "\factura\" + nombresespacios

            psi.WindowStyle = ProcessWindowStyle.Hidden
            Dim p As Process = Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("error al visualizar el pdf" & ex.Message)
        End Try

    End Sub

    Function CalcularEstatusOrdenTrabajo(folioOrdenTrabajoP As String) As Integer

        Dim fechaCreacion As String
        Dim fechaCompromiso As String
        Dim fechaRespuesta As String
        Dim respuesta As Boolean = True



        Try


            fechaCreacion = DateTime.Parse(obtenerCampo("SELECT FEC_ORD FROM VORDENT WHERE FOLIO = '" & folioOrdenTrabajoP & "'", "FEC_ORD"))
            fechaCompromiso = DateTime.Parse(obtenerCampo("SELECT FEC_COM FROM VORDENT WHERE FOLIO = '" & folioOrdenTrabajoP & "'", "FEC_COM"))

            Try
                fechaRespuesta = DateTime.Parse(obtenerCampo("SELECT FEC_RES FROM VORDENT WHERE FOLIO = '" & folioOrdenTrabajoP & "'", "FEC_RES"))

            Catch ex As Exception

                respuesta = False
                fechaRespuesta = "2000-01-01"

            End Try

            Dim dateCompromiso As Date = DateTime.Parse(fechaCompromiso)
            Dim dateRespuesta As Date = DateTime.Parse(fechaRespuesta)
            Dim dateHoy As Date = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"))

            If (respuesta = True And DateTime.Compare(dateCompromiso, dateRespuesta) >= 0) Then

                'CUMPLIDAS: La fecha de emisión de reporte tiene que ser menor que la fecha de compromiso y la fecha de respuesta debe de ser menor que la fecha de compromiso
                'MessageBox.Show("La Fecha de la orden de trabajo se cumplio dentro de la fecha del compromiso")

                Return 1

            ElseIf (respuesta = False And (DateTime.Compare(dateCompromiso, dateHoy) > 0)) Then

                'POR VENCER: La fecha de emisión del reporte debe ser menor que la fecha de compromiso
                'MessageBox.Show("La Fecha de la orden de trabajo esta aún por vencer")

                Return 2

            ElseIf (respuesta = False And (DateTime.Compare(dateHoy, dateCompromiso) > 0)) Then

                'VENCIDAS: NO HAY FECHA DE RESPUESTA Y LA FECHA DE EMISIÓN DEL REPORTE ES MAYOR A LA FECHA DE COMPROMISO

                ' MessageBox.Show("La ORDEN DE TRABAJO ya venció")

                Return 3

            ElseIf (respuesta = True And (DateTime.Compare(dateRespuesta, dateCompromiso) > 0)) Then

                'VENCIDAS: LA FECHA DE RESPUESTA ES MAYOR A LA FECHA DE COMPROMISO

                ' MessageBox.Show("La ORDEN DE TRABAJO ya venció")

                Return 3
            End If

        Catch ex As Exception



        End Try
    End Function

End Class