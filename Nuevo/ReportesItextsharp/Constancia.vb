Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class Constancia

    Public Sub GenerarConstancianoadeudo(cuentaP As Double, formatoP As String, OBSERVACION As String)


        Dim datosOrganismo As IDataReader = ConsultaSql("select * from empresa").ExecuteReader
        datosOrganismo.Read()


        Dim datosUsuario As IDataReader = ConsultaSql($"select * from vusuario where cuenta = {cuentaP.ToString()}").ExecuteReader
        datosUsuario.Read()

        Dim datosContrato As IDataReader = ConsultaSql($"select * from vcontrato where cuenta = {cuentaP.ToString()}").ExecuteReader
        datosContrato.Read()

        Dim cadenafolder As String = (Application.StartupPath & "\Contratos_Agua\" & Year(Now) & acompletacero(Month(Now).ToString(), 2)).Trim

        Dim cadenafolderDocAn As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Contratos_Agua\" & Year(Now) & acompletacero(Month(Now).ToString(), 2)).Trim



        Try


            Dim colordefinido = New Clscolorreporte()
            colordefinido.ClsColoresReporte("Azul")




            'Dar propiedades al Documento
            Dim pdfDoc As New Document(iTextSharp.text.PageSize.LETTER, 15.0F, 15.0F, 30.0F, 30.0F)





            If Not Directory.Exists(cadenafolder) Then
                Directory.CreateDirectory(cadenafolder)
            End If



            If Not Directory.Exists(cadenafolderDocAn) Then
                Directory.CreateDirectory(cadenafolderDocAn)
            End If





            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(cadenafolder & "\Contrato_" & datosUsuario("cuenta") & "_" & datosUsuario("nombre") & ".pdf", FileMode.Create))

            Dim pdfWrite3 As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(cadenafolderDocAn & "\Contrato_" & datosUsuario("cuenta") & "_" & datosUsuario("nombre") & ".pdf", FileMode.Create))


            pdfWrite.PageEvent = New Watermark("barco.png")


            Dim Font As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 7, iTextSharp.text.Font.NORMAL))
            Dim Font8N As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD))
            Dim Font88 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 14, iTextSharp.text.Font.NORMAL))
            Dim Font8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.NORMAL))
            Dim Font12 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.NORMAL))
            Dim Font9 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL))
            Dim Fontp As New Font(FontFactory.GetFont(FontFactory.COURIER, 8, iTextSharp.text.Font.BOLD))
            Dim CVacio As PdfPCell = New PdfPCell(New Phrase(""))
            CVacio.Border = 0



            pdfDoc.Open()



            ''''''''''''''''''''''''''''ENCABEZADO''''''''''''''''''''''''''

            Dim Table1 As PdfPTable = New PdfPTable(1)
            Table1.DefaultCell.Border = BorderStyle.None
            Dim Col1 As PdfPCell
            'Dim ILine As Integer
            'Dim iFila As Integer
            Table1.WidthPercentage = 100

            Dim widths As Single() = New Single() {800.0F}
            Table1.SetWidths(widths)

            'Encabezado

            'Dim imagenBMP As iTextSharp.text.Image
            'imagenBMP = iTextSharp.text.Image.GetInstance(logos)
            'imagenBMP.ScaleToFit(600, 1200.0F)
            'imagenBMP.Border = 0

            'Table1.AddCell(imagenBMP)


            Dim TableEspacio As PdfPTable = New PdfPTable(1)
            Dim ColEsp As PdfPCell
            TableEspacio.WidthPercentage = 100
            Dim widthsTE As Single() = New Single() {1000.0F}
            TableEspacio.SetWidths(widthsTE)

            ColEsp = New PdfPCell(New Phrase(" ", Font))
            ColEsp.Border = 0
            ColEsp.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableEspacio.AddCell(ColEsp)



            Dim Tabledireccion As PdfPTable = New PdfPTable(1)
            Col1 = New PdfPCell(New Phrase(datosOrganismo("CNOMBRE"), Font12))
            Col1.Border = 0
            Col1.HorizontalAlignment = PdfPCell.ALIGN_CENTER


            Dim DIRECCIONE As String = $" {datosOrganismo("CDOMICILIO")}, {datosOrganismo("CCOLONIA")}, {datosOrganismo("CPOBLACION")}, {datosOrganismo("ESTADO")}, CP: {datosOrganismo("CCODPOS")} "
            Dim Col1d = New PdfPCell(New Phrase(DIRECCIONE, Font8))
            Col1d.Border = 0
            Col1d.HorizontalAlignment = PdfPCell.ALIGN_CENTER


            Dim Col1rfe = New PdfPCell(New Phrase($"{datosOrganismo("CNIF")},                 {formatoP}  " & OBSERVACION, Font9))
            Col1rfe.Border = 0
            Col1rfe.HorizontalAlignment = PdfPCell.ALIGN_CENTER


            Tabledireccion.AddCell(Col1)
            Tabledireccion.AddCell(Col1d)
            Tabledireccion.AddCell(Col1rfe)
            Table1.AddCell(Tabledireccion)



            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



            Dim TableTitulo As PdfPTable = New PdfPTable(1)
            TableTitulo.DefaultCell.Border = BorderStyle.None

            'Dim ILine As Integer
            'Dim iFila As Integer
            TableTitulo.WidthPercentage = 100

            Dim widthsTabTitulo As Single() = New Single() {900.0F}
            TableTitulo.SetWidths(widthsTabTitulo)



            'Dim DIRECCIONE As String = Direccion & " " & coloniaEMPRESA & " " & poblacionEMPRESA & " " & Estadoempresa
            Dim Col1Titulo = New PdfPCell(New Phrase("



CONSTANCIA DE NO ADEUDO", Font12))
            Col1Titulo.Border = 0
            Col1Titulo.HorizontalAlignment = PdfPCell.ALIGN_CENTER

            TableTitulo.AddCell(Col1Titulo)








            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''



            'Cuerpo del contrato




            Dim TableCuerpoContrato As PdfPTable = New PdfPTable(1)
            TableCuerpoContrato.DefaultCell.Border = BorderStyle.None


            TableCuerpoContrato.WidthPercentage = 100

            Dim widthsTabCuerpoContrato As Single() = New Single() {800.0F}
            TableCuerpoContrato.SetWidths(widthsTabCuerpoContrato)




            Dim Col1CuerpoContrato = New PdfPCell(New Phrase("A QUIEN CORRESPONDA", Font12))

            Col1CuerpoContrato.Border = 0
            Col1CuerpoContrato.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED
            TableCuerpoContrato.AddCell(Col1CuerpoContrato)

            Col1CuerpoContrato = New PdfPCell(New Phrase(" ", Font12))
            Col1CuerpoContrato.Border = 0
            Col1CuerpoContrato.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableCuerpoContrato.AddCell(Col1CuerpoContrato)




            '& vbCrLf &  - dar salto de linea
            Dim fechahy As Date = Date.Now
            Dim fechaperiodo As Date = fechahy.AddMonths(-1)




            Dim Col1CuerpoContrato2 = New PdfPCell(New Phrase($"Por este conducto se hace CONSTAR que el servicio de agua potable ubicado en  {datosUsuario("Domicilio")} {datosUsuario("Comunidad")},con clave de ubicacion {datosUsuario("Ubicacion")}, clave predial {datosUsuario("cedula_catastral")}  y con el numero de cuenta " & datosUsuario("cuenta") & " en cual se encuentra bajo el nombre de " & datosUsuario("Nombre") & " El cual no presenta adeudo alguno al periodo de " & mesdehoy(fechaperiodo).ToUpper & " " & fechaperiodo.Year & " para con este Sistema de Agua Potable y Alcantarillado  del municipio de MULEGÉ, Baja California Sur.     	

Por tal motivo y para los fines que al (la) interesado (a) convengan se extiende la presente CONSTANCIA DE NO ADEUDO en la ciudad de " & datosUsuario("COMUNIDAD") & ", municipio de Mulegé, estado de Baja California Sur, a " & DateTime.Now.Day & " dias del mes de " & mesdehoy() & " del año " & DateTime.Now.Year & "


", Font12))


            Col1CuerpoContrato2.Border = 0
            Col1CuerpoContrato2.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED
            TableCuerpoContrato.AddCell(Col1CuerpoContrato2)






            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            Dim TableFirmasContrato As PdfPTable = New PdfPTable(3)

            TableFirmasContrato.WidthPercentage = 100
            Dim widthsFirmas As Single() = New Single() {250.0F, 100.0F, 250.0F}
            TableFirmasContrato.SetWidths(widthsFirmas)



            Dim Col1Firmas = New PdfPCell(New Phrase($"POR LA '’{datosOrganismo("SIGLAS")}’’", Font9))
            Col1Firmas.Border = 0
            Col1Firmas.HorizontalAlignment = PdfPCell.ALIGN_CENTER

            TableFirmasContrato.AddCell(Col1Firmas)


            Col1Firmas = New PdfPCell(New Phrase(" ", Font9))
            Col1Firmas.Border = 0
            Col1Firmas.HorizontalAlignment = PdfPCell.ALIGN_RIGHT

            TableFirmasContrato.AddCell(Col1Firmas)


            Col1Firmas = New PdfPCell(New Phrase("", Font9))
            Col1Firmas.Border = 0
            Col1Firmas.HorizontalAlignment = PdfPCell.ALIGN_CENTER

            TableFirmasContrato.AddCell(Col1Firmas)




            Col1Firmas = New PdfPCell(New Phrase(" ", Font9))
            Col1Firmas.Border = 0
            Col1Firmas.HorizontalAlignment = PdfPCell.ALIGN_RIGHT

            TableFirmasContrato.AddCell(Col1Firmas)


            Col1Firmas = New PdfPCell(New Phrase(" ", Font9))
            Col1Firmas.Border = 0
            Col1Firmas.HorizontalAlignment = PdfPCell.ALIGN_RIGHT

            TableFirmasContrato.AddCell(Col1Firmas)


            Col1Firmas = New PdfPCell(New Phrase(" ", Font9))
            Col1Firmas.Border = 0
            Col1Firmas.HorizontalAlignment = PdfPCell.ALIGN_RIGHT

            TableFirmasContrato.AddCell(Col1Firmas)


            Col1Firmas = New PdfPCell(New Phrase(" ", Font9))
            Col1Firmas.Border = 0
            Col1Firmas.HorizontalAlignment = PdfPCell.ALIGN_RIGHT

            TableFirmasContrato.AddCell(Col1Firmas)


            Col1Firmas = New PdfPCell(New Phrase(" ", Font9))
            Col1Firmas.Border = 0
            Col1Firmas.HorizontalAlignment = PdfPCell.ALIGN_RIGHT

            TableFirmasContrato.AddCell(Col1Firmas)


            Col1Firmas = New PdfPCell(New Phrase(" ", Font9))
            Col1Firmas.Border = 0
            Col1Firmas.HorizontalAlignment = PdfPCell.ALIGN_RIGHT

            TableFirmasContrato.AddCell(Col1Firmas)


            Col1Firmas = New PdfPCell(New Phrase(" ", Font9))
            Col1Firmas.Border = 0
            Col1Firmas.HorizontalAlignment = PdfPCell.ALIGN_RIGHT

            TableFirmasContrato.AddCell(Col1Firmas)


            Col1Firmas = New PdfPCell(New Phrase(" ", Font9))
            Col1Firmas.Border = 0 *
            Col1Firmas.HorizontalAlignment = PdfPCell.ALIGN_RIGHT

            TableFirmasContrato.AddCell(Col1Firmas)


            Col1Firmas = New PdfPCell(New Phrase(" ", Font9))
            Col1Firmas.Border = 0
            Col1Firmas.HorizontalAlignment = PdfPCell.ALIGN_RIGHT

            TableFirmasContrato.AddCell(Col1Firmas)




            Dim Col1Firmas2 = New PdfPCell(New Phrase(datosOrganismo("CADMINIS"), Font9))
            Col1Firmas2.Border = 1
            Col1Firmas2.HorizontalAlignment = PdfPCell.ALIGN_CENTER

            TableFirmasContrato.AddCell(Col1Firmas2)


            Col1Firmas = New PdfPCell(New Phrase(" ", Font9))
            Col1Firmas.Border = 0
            Col1Firmas.HorizontalAlignment = PdfPCell.ALIGN_RIGHT

            TableFirmasContrato.AddCell(Col1Firmas)


            Col1Firmas2 = New PdfPCell(New Phrase("", Font9))
            Col1Firmas2.Border = 0
            Col1Firmas2.HorizontalAlignment = PdfPCell.ALIGN_CENTER

            TableFirmasContrato.AddCell(Col1Firmas2)


            Dim Tables As PdfPTable = New PdfPTable(1)
            Table1.DefaultCell.Border = BorderStyle.None
            Dim Col1s As PdfPCell
            'Dim ILine As Integer
            'Dim iFila As Integer
            Table1.WidthPercentage = 100

            Dim widthss As Single() = New Single() {800.0F}
            Table1.SetWidths(widthss)

            'Encabezado

            'Dim imagenBMPs As iTextSharp.text.Image
            'imagenBMPs = iTextSharp.text.Image.GetInstance(sipodemos)
            'imagenBMPs.ScaleToFit(800, 129.0F)
            'imagenBMPs.Border = 0

            'Tables.AddCell(imagenBMPs)


            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            pdfDoc.Add(Table1)
            pdfDoc.Add(TableTitulo)
            pdfDoc.Add(TableEspacio)
            pdfDoc.Add(TableEspacio)
           
            pdfDoc.Add(TableEspacio)
            pdfDoc.Add(TableEspacio)
            pdfDoc.Add(TableCuerpoContrato)
            pdfDoc.Add(TableEspacio)
            pdfDoc.Add(TableEspacio)

            pdfDoc.Add(TableEspacio)
            pdfDoc.Add(TableFirmasContrato)
            pdfDoc.Add(TableEspacio)
            pdfDoc.Add(TableEspacio)
            pdfDoc.Add(TableEspacio)
            pdfDoc.Add(TableEspacio)
            pdfDoc.Add(TableEspacio)
            pdfDoc.Add(TableEspacio)
            pdfDoc.Add(TableEspacio)
            pdfDoc.Add(TableEspacio)
            pdfDoc.Add(TableEspacio)
            pdfDoc.Add(TableEspacio)
            pdfDoc.Add(Tables)
            pdfDoc.Close()
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error: " & ex.ToString())
        End Try


        Try
            Dim psi As New ProcessStartInfo(cadenafolderDocAn & "\Contrato_" & datosUsuario("cuenta") & "_" & datosUsuario("nombre") & ".pdf")
            'psi.WorkingDirectory = cadenafolder & "\factura\" + nombresespacios

            psi.WindowStyle = ProcessWindowStyle.Hidden
            Dim p As Process = Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("error al visualizar el pdf" & ex.Message)
        End Try



        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    End Sub




    Public Function mesdehoy() As String

        If DateTime.Now.Month = 1 Then
            Return "Enero"
        End If

        If DateTime.Now.Month = 2 Then
            Return "Febrero"
        End If

        If DateTime.Now.Month = 3 Then
            Return "Marzo"
        End If
        If DateTime.Now.Month = 4 Then
            Return "Abril"
        End If
        If DateTime.Now.Month = 5 Then
            Return "Mayo"
        End If
        If DateTime.Now.Month = 6 Then
            Return "Junio"
        End If
        If DateTime.Now.Month = 7 Then
            Return "Julio"
        End If
        If DateTime.Now.Month = 8 Then
            Return "Agosto"
        End If
        If DateTime.Now.Month = 9 Then
            Return "Septiembre"
        End If
        If DateTime.Now.Month = 10 Then
            Return "Octubre"
        End If
        If DateTime.Now.Month = 11 Then
            Return "Noviembre"
        End If
        If DateTime.Now.Month = 12 Then
            Return "Diciembre"
        End If


    End Function

    Public Function mesdehoy(FECHA As Date) As String

        Dim MES As Integer = Month(FECHA)
        If MES = 1 Then
            Return "Enero"
        End If

        If MES = 2 Then
            Return "Febrero"
        End If

        If MES = 3 Then
            Return "Marzo"
        End If
        If MES = 4 Then
            Return "Abril"
        End If
        If MES = 5 Then
            Return "Mayo"
        End If
        If MES = 6 Then
            Return "Junio"
        End If
        If MES = 7 Then
            Return "Julio"
        End If
        If MES = 8 Then
            Return "Agosto"
        End If
        If MES = 9 Then
            Return "Septiembre"
        End If
        If MES = 10 Then
            Return "Octubre"
        End If
        If MES = 11 Then
            Return "Noviembre"
        End If
        If MES = 12 Then
            Return "Diciembre"
        End If


    End Function


End Class
