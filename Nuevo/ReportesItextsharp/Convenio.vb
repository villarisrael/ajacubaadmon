
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class Convenio

    Public Sub GenerarConvenio(idconvenio As Integer)


        Dim datosOrganismo As IDataReader = ConsultaSql("select * from empresa").ExecuteReader
        datosOrganismo.Read()

        Dim datosconvenio As IDataReader = ConsultaSql("select * from encconvenio where idencconvenio=" & idconvenio).ExecuteReader
        datosconvenio.Read()
        Dim cuenta As String = datosconvenio("idcuenta")

        Dim datosUsuario As IDataReader = ConsultaSql($"select * from vusuario where cuenta = {cuenta}").ExecuteReader
        datosUsuario.Read()



        Dim cadenafolder As String = (Application.StartupPath & "\Convenios\" & Year(Now) & acompletacero(Month(Now).ToString(), 2)).Trim

        Dim cadenafolderDocAn As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Convenios\" & Year(Now) & acompletacero(Month(Now).ToString(), 2)).Trim



        Try


            Dim colordefinido = New Clscolorreporte()
            colordefinido.ClsColoresReporte("Morado claro")




            'Dar propiedades al Documento
            Dim pdfDoc As New Document(iTextSharp.text.PageSize.LETTER, 15.0F, 15.0F, 30.0F, 30.0F)





            If Not Directory.Exists(cadenafolder) Then
                Directory.CreateDirectory(cadenafolder)
            End If



            If Not Directory.Exists(cadenafolderDocAn) Then
                Directory.CreateDirectory(cadenafolderDocAn)
            End If





            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(cadenafolder & "\Convenio_" & datosUsuario("cuenta") & "_" & datosUsuario("nombre") & ".pdf", FileMode.Create))

            Dim pdfWrite3 As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(cadenafolderDocAn & "\Convenio_" & datosUsuario("cuenta") & "_" & datosUsuario("nombre") & ".pdf", FileMode.Create))





            Dim Font As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 7, iTextSharp.text.Font.NORMAL))
            Dim Font8N As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 7, iTextSharp.text.Font.BOLD))
            Dim Font88 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 14, iTextSharp.text.Font.BOLD))
            Dim Font8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.NORMAL))
            Dim Font12 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.NORMAL))
            Dim Font12N As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.BOLD))
            Dim Font9 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL))
            Dim Fontp As New Font(FontFactory.GetFont(FontFactory.COURIER, 8, iTextSharp.text.Font.BOLD))
            Dim CVacio As PdfPCell = New PdfPCell(New Phrase(""))
            CVacio.Border = 0



            pdfDoc.Open()



            ''''''''''''''''''''''''''''ENCABEZADO''''''''''''''''''''''''''

            Dim Table1 As PdfPTable = New PdfPTable(2)
            Table1.DefaultCell.Border = BorderStyle.None
            Dim Col1 As PdfPCell
            'Dim ILine As Integer
            'Dim iFila As Integer
            Table1.WidthPercentage = 100

            Dim widths As Single() = New Single() {100.0F, 800.0F}
            Table1.SetWidths(widths)

            'Encabezado

            Dim imagenBMP As iTextSharp.text.Image
            imagenBMP = iTextSharp.text.Image.GetInstance(LOGOBYTE)
            imagenBMP.ScaleToFit(100.0F, 90.0F)
            imagenBMP.Border = 0

            Table1.AddCell(imagenBMP)


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
            Col1 = New PdfPCell(New Phrase(datosOrganismo("CNOMBRE"), Font12N))
            Col1.Border = 0
            Col1.HorizontalAlignment = PdfPCell.ALIGN_CENTER


            Dim DIRECCIONE As String = $" {datosOrganismo("CDOMICILIO")}, {datosOrganismo("CCOLONIA")}, {datosOrganismo("CPOBLACION")}, {datosOrganismo("ESTADO")}, CP: {datosOrganismo("CCODPOS")} "
            Dim Col1d = New PdfPCell(New Phrase(DIRECCIONE, Font8))
            Col1d.Border = 0
            Col1d.HorizontalAlignment = PdfPCell.ALIGN_CENTER


            Dim Col1rfe = New PdfPCell(New Phrase(datosOrganismo("CNIF"), Font9))
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
            Dim Col1Titulo = New PdfPCell(New Phrase("CONVENIO DE PAGOS", Font12N))
            Col1Titulo.Border = 0
            Col1Titulo.HorizontalAlignment = PdfPCell.ALIGN_CENTER

            TableTitulo.AddCell(Col1Titulo)




            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



            Dim TableDatosContrato As PdfPTable = New PdfPTable(6)

            Dim Col61 As PdfPCell
            Dim Col62 As PdfPCell
            Dim Col63 As PdfPCell
            Dim Col64 As PdfPCell

            TableDatosContrato.WidthPercentage = 100
            Dim widthsT6 As Single() = New Single() {40.0F, 30.0F, 30.0F, 100.0F, 30.0F, 50.0F}
            TableDatosContrato.SetWidths(widthsT6)

            Col61 = New PdfPCell(New Phrase("UBICACION", Font8))
            Col61.Border = 0
            Col61.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'Col61.BackgroundColor = colordefinido.color
            TableDatosContrato.AddCell(Col61)

            Col62 = New PdfPCell(New Phrase(datosUsuario("ubicacion"), Font9))
            Col62.Border = 0
            Col62.HorizontalAlignment = PdfPCell.ALIGN_CENTER

            TableDatosContrato.AddCell(Col62)

            Col63 = New PdfPCell(New Phrase("TIPO: ", Font8))
            Col63.Border = 0
            Col63.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'Col63.BackgroundColor = colordefinido.color
            TableDatosContrato.AddCell(Col63)

            Dim ColMi = New PdfPCell(New Phrase(datosUsuario("TIPOUSU"), Font9))
            ColMi.Border = 0
            ColMi.HorizontalAlignment = PdfPCell.ALIGN_LEFT

            TableDatosContrato.AddCell(ColMi)


            Col64 = New PdfPCell(New Phrase("FECHA: ", Font8))
            Col64.Border = 0
            Col64.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'Col64.BackgroundColor = colordefinido.color
            TableDatosContrato.AddCell(Col64)




            Col64 = New PdfPCell(New Phrase(Now.ToShortDateString(), Font9))
                Col64.Border = 0
                Col64.HorizontalAlignment = PdfPCell.ALIGN_LEFT

                TableDatosContrato.AddCell(Col64)





            Col61 = New PdfPCell(New Phrase("CUENTA: ", Font8))
            Col61.Border = 0
            Col61.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'Col61.BackgroundColor = colordefinido.color
            TableDatosContrato.AddCell(Col61)

            Col62 = New PdfPCell(New Phrase(datosUsuario("cuenta"), Font9))
            Col62.Border = 0
            Col62.HorizontalAlignment = PdfPCell.ALIGN_LEFT

            TableDatosContrato.AddCell(Col62)

            Col63 = New PdfPCell(New Phrase("GIRO: ", Font8))
            Col63.Border = 0
            Col63.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'Col63.BackgroundColor = colordefinido.color
            TableDatosContrato.AddCell(Col63)

            ColMi = New PdfPCell(New Phrase(datosUsuario("Giro"), Font9))
            ColMi.Border = 0
            ColMi.HorizontalAlignment = PdfPCell.ALIGN_LEFT

            TableDatosContrato.AddCell(ColMi)


            Col64 = New PdfPCell(New Phrase(" ", Font9))
            Col64.Border = 0
            Col64.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
            'Col64.BackgroundColor = colordefinido.color
            TableDatosContrato.AddCell(Col64)


            Col64 = New PdfPCell(New Phrase(" ", Font9))
            Col64.Border = 0
            Col64.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
            'Col64.BackgroundColor = colordefinido.color
            TableDatosContrato.AddCell(Col64)






            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''



            'Cuerpo del contrato




            Dim TableCuerpoContrato As PdfPTable = New PdfPTable(1)
            TableCuerpoContrato.DefaultCell.Border = BorderStyle.None


            TableCuerpoContrato.WidthPercentage = 100

            Dim widthsTabCuerpoContrato As Single() = New Single() {800.0F}
            TableCuerpoContrato.SetWidths(widthsTabCuerpoContrato)




            Dim Col1CuerpoContrato = New PdfPCell(New Phrase("Convenio de pago de servicios de agua que celebran por una parte el Sistema de Agua Potable, Alcantarillado y Saneamiento de MULEGÉ, Baja California Sur, representado por el C " & Director & " en su carácter de Administrador, a quién en lo sucesivo se le denominará "" EL SISTEMA "", y por otra parte el C.  " & datosUsuario("nombre") & " Quien en el cuerpo del presente se le denominará "" EL DEUDOR ”", se acuerda el siguiente convenio de pago por parcialidades::", Font12))

            Col1CuerpoContrato.Border = 0
            Col1CuerpoContrato.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED
            TableCuerpoContrato.AddCell(Col1CuerpoContrato)

            Col1CuerpoContrato = New PdfPCell(New Phrase(" ", Font12))
            Col1CuerpoContrato.Border = 0
            Col1CuerpoContrato.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableCuerpoContrato.AddCell(Col1CuerpoContrato)


            'Dim DIRECCIONE As String = Direccion & " " & coloniaEMPRESA & " " & poblacionEMPRESA & " " & Estadoempresa
            Col1CuerpoContrato = New PdfPCell(New Phrase("C L A U S U L A S", Font12))
            Col1CuerpoContrato.Border = 0
            Col1CuerpoContrato.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableCuerpoContrato.AddCell(Col1CuerpoContrato)

            Col1CuerpoContrato = New PdfPCell(New Phrase(" ", Font12))
            Col1CuerpoContrato.Border = 0
            Col1CuerpoContrato.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableCuerpoContrato.AddCell(Col1CuerpoContrato)


            '& vbCrLf &  - dar salto de linea
            Dim totalconvenio As String = Decimal.Parse(datosconvenio("Total")).ToString("C")

            Dim Col1CuerpoContrato2 = New PdfPCell(New Phrase($"
            

PRIMERA: EL Deudor reconoce una deuda de pago de  {totalconvenio} pesos 

SEGUNDA: El Software seguira cargando los recargos correspondientes al cambio de cada mes en consecuencia los pagos aqui comprometidos son aproximados y seran actualizados al dia que se realize el pago

TERCERA: Ambas partes acuerdan que la deuda pendiente será saldada en cuotas con aplazamiento de acuerdo a la siguiente tabla

", Font12))


            Col1CuerpoContrato2.Border = 0
            Col1CuerpoContrato2.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED
            TableCuerpoContrato.AddCell(Col1CuerpoContrato2)




            Dim TableDatosCONVENIO As PdfPTable = New PdfPTable(3)



            TableDatosCONVENIO.WidthPercentage = 60
            Dim widthsTConvenio As Single() = New Single() {50.0F, 250.0F, 50.0F}
            TableDatosContrato.SetWidths(widthsT6)

            TableDatosCONVENIO.DefaultCell.Border = BorderStyle.FixedSingle
            TableDatosCONVENIO.DefaultCell.BorderWidth = 2



            Dim Coltc1 As PdfPCell = New PdfPCell(New Phrase("FECHA", Font12N))

            Coltc1.HorizontalAlignment = PdfPCell.ALIGN_LEFT

            TableDatosCONVENIO.AddCell(Coltc1)

            Dim Coltc2 As PdfPCell = New PdfPCell(New Phrase("CONCEPTO", Font12N))

            Coltc2.HorizontalAlignment = PdfPCell.ALIGN_LEFT

            TableDatosCONVENIO.AddCell(Coltc2)

            Dim Coltc3 As PdfPCell = New PdfPCell(New Phrase("MONTO", Font12N))

            Coltc3.HorizontalAlignment = PdfPCell.ALIGN_RIGHT

            TableDatosCONVENIO.AddCell(Coltc3)

            Dim datosdetalleconvenio As IDataReader = ConsultaSql("select * from detconvenio where idencconvenio=" & idconvenio).ExecuteReader
            Do While datosdetalleconvenio.Read()
                Dim Coltc11 As PdfPCell = New PdfPCell(New Phrase(datosdetalleconvenio("fecha"), Font8N))

                Coltc11.HorizontalAlignment = PdfPCell.ALIGN_LEFT

                TableDatosCONVENIO.AddCell(Coltc11)

                Dim Coltc22 As PdfPCell = New PdfPCell(New Phrase(datosdetalleconvenio("concepto"), Font12N))

                Coltc22.HorizontalAlignment = PdfPCell.ALIGN_LEFT

                TableDatosCONVENIO.AddCell(Coltc22)
                Dim monto As Decimal = Decimal.Parse(datosdetalleconvenio("monto"))

                Dim Coltc33 As PdfPCell = New PdfPCell(New Phrase(monto.ToString("C"), Font8N))

                Coltc33.HorizontalAlignment = PdfPCell.ALIGN_RIGHT

                TableDatosCONVENIO.AddCell(Coltc33)

            Loop


            TableCuerpoContrato.AddCell(TableDatosCONVENIO)

            datosdetalleconvenio.Close()



            Dim Col2CuerpoContrato2 = New PdfPCell(New Phrase($"


Firman los que en este contrato participan a " & DateTime.Now.Day & " dias del mes de " & mesdehoy() & " del año " & DateTime.Now.Year & "
", Font12))


            Col2CuerpoContrato2.Border = 0
            Col2CuerpoContrato2.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED
            TableCuerpoContrato.AddCell(Col2CuerpoContrato2)





            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            Dim TableFirmasContrato As PdfPTable = New PdfPTable(3)

            TableFirmasContrato.WidthPercentage = 100
            Dim widthsFirmas As Single() = New Single() {250.0F, 100.0F, 250.0F}
            TableFirmasContrato.SetWidths(widthsFirmas)



            Dim Col1Firmas = New PdfPCell(New Phrase($"POR LA ‘’{datosOrganismo("SIGLAS")}’’", Font9))
            Col1Firmas.Border = 0
            Col1Firmas.HorizontalAlignment = PdfPCell.ALIGN_CENTER

            TableFirmasContrato.AddCell(Col1Firmas)


            Col1Firmas = New PdfPCell(New Phrase(" ", Font9))
            Col1Firmas.Border = 0
            Col1Firmas.HorizontalAlignment = PdfPCell.ALIGN_RIGHT

            TableFirmasContrato.AddCell(Col1Firmas)


            Col1Firmas = New PdfPCell(New Phrase("POR EL USUARIO", Font9))
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


            Col1Firmas2 = New PdfPCell(New Phrase(datosUsuario("nombre"), Font9))
            Col1Firmas2.Border = 1
            Col1Firmas2.HorizontalAlignment = PdfPCell.ALIGN_CENTER

            TableFirmasContrato.AddCell(Col1Firmas2)




            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            pdfDoc.Add(Table1)
            pdfDoc.Add(TableTitulo)
            pdfDoc.Add(TableEspacio)
            pdfDoc.Add(TableEspacio)
            pdfDoc.Add(TableDatosContrato)
            pdfDoc.Add(TableEspacio)
            pdfDoc.Add(TableEspacio)
            pdfDoc.Add(TableCuerpoContrato)
            pdfDoc.Add(TableEspacio)
            pdfDoc.Add(TableEspacio)
            pdfDoc.Add(TableEspacio)
            pdfDoc.Add(TableEspacio)
            pdfDoc.Add(TableFirmasContrato)

            pdfDoc.Close()
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error: " & ex.ToString())
        End Try


        Try
            Dim psi As New ProcessStartInfo(cadenafolderDocAn & "\Convenio_" & datosUsuario("cuenta") & "_" & datosUsuario("nombre") & ".pdf")
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
End Class
