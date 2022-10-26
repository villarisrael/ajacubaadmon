Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class FrmReportesPipa
    Dim FechaInicio As String
    Dim FechaFin As String
    Dim folio As Integer
    Dim sqlfiltrado As String
    Private Sub vaciarHerramientas()
        txtinicio.Text = ""
        txtfin.Text = ""



    End Sub
    Private Sub FrmReportesPipa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim FechaInicio As String
        'Dim FechaFin As String
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size

        'FechaInicio = CalenReporteInicio.SelectionRange.Start.Year & "-" & CalenReporteInicio.SelectionRange.Start.Month & "-" & CalenReporteInicio.SelectionRange.Start.Day
        'FechaFin = CalenReporteFin.SelectionRange.Start.Year & "-" & CalenReporteFin.SelectionRange.Start.Month & "-" & CalenReporteFin.SelectionRange.Start.Day

        'Dim sql As String = "select * from solicitudpipa"

        'llenaGrid(DGVReportePipa, sql)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        If CheckBoxFiltrar.Checked Then

            FechaInicio = CalenReporteInicio.SelectionRange.Start.Year & "-" & CalenReporteInicio.SelectionRange.Start.Month & "-" & CalenReporteInicio.SelectionRange.Start.Day
            FechaFin = CalenReporteFin.SelectionRange.Start.Year & "-" & CalenReporteFin.SelectionRange.Start.Month & "-" & CalenReporteFin.SelectionRange.Start.Day

            sqlfiltrado = "select * from solicitudpipa WHERE Estatus ='" + ComboBoxEstatus.Text + "' and fechaSolicitud BETWEEN '" & FechaInicio & "' AND '" & FechaFin & "'"

            llenaGrid(DGVReportePipa, sqlfiltrado)

            txtinicio.Text = FechaInicio
            txtfin.Text = FechaFin

        End If

        If CheckBoxFiltrar.Checked = False Then

            FechaInicio = CalenReporteInicio.SelectionRange.Start.Year & "-" & CalenReporteInicio.SelectionRange.Start.Month & "-" & CalenReporteInicio.SelectionRange.Start.Day
            FechaFin = CalenReporteFin.SelectionRange.Start.Year & "-" & CalenReporteFin.SelectionRange.Start.Month & "-" & CalenReporteFin.SelectionRange.Start.Day

            Dim sql As String = "select * from solicitudpipa WHERE fechaSolicitud BETWEEN '" & FechaInicio & "' AND '" & FechaFin & "'"

            llenaGrid(DGVReportePipa, sql)

            txtinicio.Text = FechaInicio
            txtfin.Text = FechaFin

        End If




    End Sub

    Private Sub btnReportesPipa_Click(sender As Object, e As EventArgs) Handles btnReportesPipa.Click


        'Ejecucion("select * from solicitudpipa WHERE fechaSolicitud BETWEEN '" & FechaInicio & "' AND '" & FechaFin & "'")

        'folio = folio + 1

        'Dim cadenafolio As String = ("UPDATE empresa SET FolioSolPIPA = '" + folio.ToString() + "' WHERE CODEMP = 1")
        'Ejecucion(cadenafolio)

        folio = Val(obtenerCampo("select max(FolioSolPIPA) as FolioPIPA from Empresa", "FolioPIPA"))

        If CheckBoxFiltrar.Checked Then

            GenerarPDFFiltrado()

        End If

        If CheckBoxFiltrar.Checked = False Then

            GenerarPDFGeneral()

        End If


        'Dim datosSolPipa As IDataReader = ConsultaSql(sqlfiltrado + " order by Direccion").ExecuteReader()


    End Sub


    Private Sub GenerarPDFFiltrado()

        Dim datosSolPipa As IDataReader

        datosSolPipa = ConsultaSql(sqlfiltrado + " order by Direccion").ExecuteReader()

        'Se crea la carpeta donde se guardaran los reportes de solicitud de pipa
        Dim directorioSolPipa = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\ReportesSolicitudPipa\").Trim
        Dim directorioSolPipaxMes = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\ReportesSolicitudPipa\" & Year(Now) & acompletacero(Month(Now).ToString(), 2)).Trim

        If Not Directory.Exists(directorioSolPipa) Then
            Directory.CreateDirectory(directorioSolPipa)
        End If

        If Not Directory.Exists(directorioSolPipaxMes) Then
            Directory.CreateDirectory(directorioSolPipaxMes)
        End If


#Region "Dar propiedades al documento"

        'Dar propiedades al Documento
        Dim pdfDoc As New Document(iTextSharp.text.PageSize.LETTER.Rotate(), 15.0F, 15.0F, 30.0F, 30.0F)

        'Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(directorioSolPipa & "\Reporte_" & FechaInicio & "__" & FechaFin & ".pdf", FileMode.Create))
        'Dim pdfWrite2 As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(directorioreimpresas & "\factura" & serie & factura & ".pdf", FileMode.Create))
        Dim pdfWrite2 As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(directorioSolPipaxMes & "\Reporte_" & FechaInicio & "__" & FechaFin & "__F" & folio & ".pdf", FileMode.Create))
        'Formtos para distintos tamaños de letras

        'Formato Letras


        Dim Font As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 6, iTextSharp.text.Font.NORMAL))
        Dim Font6B As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 6, iTextSharp.text.Font.BOLD))
        Dim Font6W As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 6, iTextSharp.text.Font.BOLD, BaseColor.WHITE))
        Dim Font8N As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 6, iTextSharp.text.Font.BOLD))
        Dim Font8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD))
        Dim Font88 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.BOLD))
        Dim Font12 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.BOLD))
        Dim Font10 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.NORMAL))
        Dim Font9 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 7, iTextSharp.text.Font.NORMAL))
        Dim Fontp As New Font(FontFactory.GetFont(FontFactory.COURIER, 7, iTextSharp.text.Font.BOLD))
        Dim CVacio As PdfPCell = New PdfPCell(New Phrase(""))
        CVacio.Border = 0

        pdfDoc.Open()


        Dim TableEncabezado As PdfPTable = New PdfPTable(3)
        TableEncabezado.DefaultCell.Border = BorderStyle.None
        Dim Col1 As PdfPCell
        'Dim ILine As Integer
        'Dim iFila As Integer
        TableEncabezado.WidthPercentage = 100

        Dim widths As Single() = New Single() {100.0F, 400.0F, 100.0F}
        TableEncabezado.SetWidths(widths)
        ' comenzamos con un cuadro

        'Dim _cb As PdfContentByte

        'Dim colordefinido = New Clscolorreporte()
        'colordefinido.ClsColoresReporte(My.Settings.colorfactura)
        Dim imagenBMP As iTextSharp.text.Image
        imagenBMP = iTextSharp.text.Image.GetInstance(LOGOBYTE)
        imagenBMP.ScaleToFit(80.0F, 70.0F)
        'imagenBMP.SpacingBefore = 100.0F
        'imagenBMP.SpacingAfter = 1000.0F

        imagenBMP.Border = 0
        TableEncabezado.AddCell(imagenBMP)

        Dim Tabledireccion As PdfPTable = New PdfPTable(1)
        Col1 = New PdfPCell(New Phrase(Empresa, Font12))
        Col1.Border = 0
        Col1.HorizontalAlignment = PdfPCell.ALIGN_CENTER

        Dim DIRECCIONE As String = Empresa & " " & Direccion
        Dim Col1d = New PdfPCell(New Phrase(DIRECCIONE, Font12))
        Col1d.Border = 0
        Col1d.HorizontalAlignment = PdfPCell.ALIGN_CENTER

        Dim ColFolio = New PdfPCell(New Phrase("Folio: " & folio, Font88))
        ColFolio.Border = 0
        ColFolio.HorizontalAlignment = PdfPCell.ALIGN_LEFT


        Tabledireccion.AddCell(Col1d)
        TableEncabezado.AddCell(Tabledireccion)
        TableEncabezado.AddCell(ColFolio)

        Dim TableEspacio As PdfPTable = New PdfPTable(1)
        Dim ColEsp As PdfPCell
        TableEspacio.WidthPercentage = 100
        Dim widthsTE As Single() = New Single() {1000.0F}
        TableEspacio.SetWidths(widthsTE)

        ColEsp = New PdfPCell(New Phrase(" ", Font))
        ColEsp.Border = 0
        ColEsp.HorizontalAlignment = PdfPCell.ALIGN_LEFT
        TableEspacio.AddCell(ColEsp)

        Dim TableFechaReporte As PdfPTable = New PdfPTable(2)
        TableFechaReporte.WidthPercentage = 100
        Dim widthsFR As Single() = New Single() {600.0F, 350.0F}
        TableFechaReporte.SetWidths(widthsFR)

        Dim ColFechaSolRep = New PdfPCell(New Phrase("Reporte Solicitud de Pipa del " & FechaInicio & " al " & FechaFin, Font10))
        ColFechaSolRep.Border = 0
        ColFechaSolRep.HorizontalAlignment = PdfPCell.ALIGN_LEFT
        'ColFechaSolRep.BackgroundColor = BaseColor.LIGHT_GR
        TableFechaReporte.AddCell(ColFechaSolRep)

        Dim ColSolEstatus = New PdfPCell(New Phrase("Estatus de solicitudes:   " & ComboBoxEstatus.Text, Font10))
        ColSolEstatus.Border = 0
        ColSolEstatus.HorizontalAlignment = PdfPCell.ALIGN_LEFT
        'ColFechaSolRep.BackgroundColor = BaseColor.LIGHT_GR
        TableFechaReporte.AddCell(ColSolEstatus)


        Dim TableSolicitudes As PdfPTable = New PdfPTable(9)
        TableSolicitudes.WidthPercentage = 100
        Dim widthsT6 As Single() = New Single() {15.0F, 80.0F, 65.0F, 50.0F, 60.0F, 30.0F, 15.0F, 40.0F, 50.0F}
        TableSolicitudes.SetWidths(widthsT6)

        Dim ColSolContrato = New PdfPCell(New Phrase("N.C.", Font6W))
        ColSolContrato.Border = 7
        ColSolContrato.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        ColSolContrato.BackgroundColor = New iTextSharp.text.BaseColor(30, 151, 194)
        ColSolContrato.FixedHeight = 20.0F
        TableSolicitudes.AddCell(ColSolContrato)

        Dim ColSolNombre = New PdfPCell(New Phrase("Nombre", Font6W))
        ColSolNombre.Border = 7
        ColSolNombre.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        ColSolNombre.BackgroundColor = New iTextSharp.text.BaseColor(30, 151, 194)
        TableSolicitudes.AddCell(ColSolNombre)

        Dim ColSolDireccion = New PdfPCell(New Phrase("Dirección", Font6W))
        ColSolDireccion.Border = 7
        ColSolDireccion.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        ColSolDireccion.BackgroundColor = New iTextSharp.text.BaseColor(30, 151, 194)
        TableSolicitudes.AddCell(ColSolDireccion)

        Dim ColSolEntre = New PdfPCell(New Phrase("Entre Calles", Font6W))
        ColSolEntre.Border = 7
        ColSolEntre.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        ColSolEntre.BackgroundColor = New iTextSharp.text.BaseColor(30, 151, 194)
        TableSolicitudes.AddCell(ColSolEntre)

        Dim ColSolReferencia = New PdfPCell(New Phrase("Referencia", Font6W))
        ColSolReferencia.Border = 7
        ColSolReferencia.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        ColSolReferencia.BackgroundColor = New iTextSharp.text.BaseColor(30, 151, 194)
        TableSolicitudes.AddCell(ColSolReferencia)

        Dim ColSolCelTel = New PdfPCell(New Phrase("Celular/Teléfono", Font6W))
        ColSolCelTel.Border = 7
        ColSolCelTel.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        ColSolCelTel.BackgroundColor = New iTextSharp.text.BaseColor(30, 151, 194)
        TableSolicitudes.AddCell(ColSolCelTel)

        Dim ColSolLts = New PdfPCell(New Phrase("Litros", Font6W))
        ColSolLts.Border = 7
        ColSolLts.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        ColSolLts.BackgroundColor = New iTextSharp.text.BaseColor(30, 151, 194)
        TableSolicitudes.AddCell(ColSolLts)

        Dim ColSolFirma = New PdfPCell(New Phrase("Firma", Font6W))
        ColSolFirma.Border = 7
        ColSolFirma.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        ColSolFirma.BackgroundColor = New iTextSharp.text.BaseColor(30, 151, 194)
        TableSolicitudes.AddCell(ColSolFirma)

        Dim ColSolEAServ = New PdfPCell(New Phrase("E.A. Servicio", Font6W))
        ColSolEAServ.Border = 7
        ColSolEAServ.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        ColSolEAServ.BackgroundColor = New iTextSharp.text.BaseColor(30, 151, 194)
        TableSolicitudes.AddCell(ColSolEAServ)


        While datosSolPipa.Read()
            ColSolContrato = New PdfPCell(New Phrase(datosSolPipa("Cuenta"), Font6B))
            ColSolContrato.Border = 7
            ColSolContrato.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            ColSolContrato.FixedHeight = 40.0F
            'ColSolContrato.BackgroundColor = BaseColor.LIGHT_GRAY
            TableSolicitudes.AddCell(ColSolContrato)

            ColSolNombre = New PdfPCell(New Phrase(datosSolPipa("Nombre"), Font))
            ColSolNombre.Border = 7
            ColSolNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'ColSolNombre.BackgroundColor = BaseColor.LIGHT_GRAY
            TableSolicitudes.AddCell(ColSolNombre)

            ColSolDireccion = New PdfPCell(New Phrase(datosSolPipa("Direccion"), Font))
            ColSolDireccion.Border = 7
            ColSolDireccion.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'ColSolDireccion.BackgroundColor = BaseColor.LIGHT_GRAY
            TableSolicitudes.AddCell(ColSolDireccion)

            ColSolEntre = New PdfPCell(New Phrase(datosSolPipa("Entre"), Font))
            ColSolEntre.Border = 7
            ColSolEntre.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'ColSolEntre.BackgroundColor = BaseColor.LIGHT_GRAY
            TableSolicitudes.AddCell(ColSolEntre)

            ColSolReferencia = New PdfPCell(New Phrase(datosSolPipa("Referencia"), Font))
            ColSolReferencia.Border = 7
            ColSolReferencia.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'ColSolReferencia.BackgroundColor = BaseColor.LIGHT_GRAY
            TableSolicitudes.AddCell(ColSolReferencia)

            ColSolCelTel = New PdfPCell(New Phrase(datosSolPipa("NumCel"), Font))
            ColSolCelTel.Border = 7
            ColSolCelTel.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'ColSolCelTel.BackgroundColor = BaseColor.LIGHT_GRAY
            TableSolicitudes.AddCell(ColSolCelTel)

            ColSolLts = New PdfPCell(New Phrase(datosSolPipa("CantLts"), Font))
            ColSolLts.Border = 7
            ColSolLts.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            'ColSolFirma.BackgroundColor = BaseColor.LIGHT_GRAY
            TableSolicitudes.AddCell(ColSolLts)

            ColSolFirma = New PdfPCell(New Phrase("                ", Font))
            ColSolFirma.Border = 7
            ColSolFirma.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            'ColSolFirma.BackgroundColor = BaseColor.LIGHT_GRAY
            TableSolicitudes.AddCell(ColSolFirma)

            ColSolEAServ = New PdfPCell(New Phrase("                ", Font))
            ColSolEAServ.Border = 7
            ColSolEAServ.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            'ColSolFirma.BackgroundColor = BaseColor.LIGHT_GRAY
            TableSolicitudes.AddCell(ColSolEAServ)
        End While

        pdfDoc.Add(TableEncabezado)
        pdfDoc.Add(TableEspacio)
        pdfDoc.Add(TableEspacio)
        pdfDoc.Add(TableFechaReporte)
        pdfDoc.Add(TableEspacio)
        pdfDoc.Add(TableSolicitudes)

        pdfDoc.Close()

        vaciarHerramientas()





        Try
            Dim psi As New ProcessStartInfo(directorioSolPipaxMes & "\Reporte_" & FechaInicio & "__" & FechaFin & "__F" & folio & ".pdf")
            'psi.WorkingDirectory = cadenafolder & "\factura\" + nombresespacios

            psi.WindowStyle = ProcessWindowStyle.Hidden
            Dim p As Process = Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("error al visualizar el pdf" & ex.Message)
        End Try


        'folio = Val(obtenerCampo("select max(FolioSolPIPA) as FolioPIPA from solicitudpipa", "FolioPIPA"))
        'Dim Fol As Int32 = folio
        'Fol = Fol + 1

        Dim cadenafolio As String = ("update empresa set FolioSolPIPA = FolioSolPIPA + 1 where CODEMP = '1'")
        Ejecucion(cadenafolio)


#End Region
    End Sub

    Private Sub GenerarPDFGeneral()

        Dim datosSolPipa As IDataReader

        datosSolPipa = ConsultaSql("select * from solicitudpipa WHERE fechaSolicitud BETWEEN '" & FechaInicio & "' AND '" & FechaFin & "'" & " order by Direccion").ExecuteReader()

        'Se crea la carpeta donde se guardaran los reportes de solicitud de pipa
        Dim directorioSolPipa = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\ReportesSolicitudPipa\").Trim
        Dim directorioSolPipaxMes = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\ReportesSolicitudPipa\" & Year(Now) & acompletacero(Month(Now).ToString(), 2)).Trim

        If Not Directory.Exists(directorioSolPipa) Then
            Directory.CreateDirectory(directorioSolPipa)
        End If

        If Not Directory.Exists(directorioSolPipaxMes) Then
            Directory.CreateDirectory(directorioSolPipaxMes)
        End If


#Region "Dar propiedades al documento"

        'Dar propiedades al Documento
        Dim pdfDoc As New Document(iTextSharp.text.PageSize.LETTER.Rotate(), 15.0F, 15.0F, 30.0F, 30.0F)

        'Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(directorioSolPipa & "\Reporte_" & FechaInicio & "__" & FechaFin & ".pdf", FileMode.Create))
        'Dim pdfWrite2 As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(directorioreimpresas & "\factura" & serie & factura & ".pdf", FileMode.Create))
        Dim pdfWrite2 As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(directorioSolPipaxMes & "\Reporte_" & FechaInicio & "__" & FechaFin & "__F" & folio & ".pdf", FileMode.Create))
        'Formtos para distintos tamaños de letras

        'Formato Letras


        Dim Font As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 6, iTextSharp.text.Font.NORMAL))
        Dim Font6B As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 6, iTextSharp.text.Font.BOLD))
        Dim Font8N As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 6, iTextSharp.text.Font.BOLD))
        Dim Font8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD))
        Dim Font88 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.BOLD))
        Dim Font12 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.BOLD))
        Dim Font10 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.NORMAL))
        Dim Font9 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 7, iTextSharp.text.Font.NORMAL))
        Dim Fontp As New Font(FontFactory.GetFont(FontFactory.COURIER, 7, iTextSharp.text.Font.BOLD))
        Dim CVacio As PdfPCell = New PdfPCell(New Phrase(""))
        CVacio.Border = 0

        pdfDoc.Open()


        Dim TableEncabezado As PdfPTable = New PdfPTable(3)
        TableEncabezado.DefaultCell.Border = BorderStyle.None
        Dim Col1 As PdfPCell
        'Dim ILine As Integer
        'Dim iFila As Integer
        TableEncabezado.WidthPercentage = 100

        Dim widths As Single() = New Single() {100.0F, 500.0F, 100.0F}
        TableEncabezado.SetWidths(widths)
        ' comenzamos con un cuadro

        'Dim _cb As PdfContentByte

        'Dim colordefinido = New Clscolorreporte()
        'colordefinido.ClsColoresReporte(My.Settings.colorfactura)
        Dim imagenBMP As iTextSharp.text.Image
        imagenBMP = iTextSharp.text.Image.GetInstance(LOGOBYTE)
        imagenBMP.ScaleToFit(80.0F, 70.0F)
        'imagenBMP.SpacingBefore = 100.0F
        'imagenBMP.SpacingAfter = 1000.0F

        imagenBMP.Border = 0
        TableEncabezado.AddCell(imagenBMP)

        Dim Tabledireccion As PdfPTable = New PdfPTable(1)
        Col1 = New PdfPCell(New Phrase(Empresa, Font12))
        Col1.Border = 0
        Col1.HorizontalAlignment = PdfPCell.ALIGN_CENTER

        Dim DIRECCIONE As String = Empresa & " " & Direccion
        Dim Col1d = New PdfPCell(New Phrase(DIRECCIONE, Font12))
        Col1d.Border = 0
        Col1d.HorizontalAlignment = PdfPCell.ALIGN_CENTER

        Dim ColFolio = New PdfPCell(New Phrase("Folio: " & folio, Font88))
        ColFolio.Border = 0
        ColFolio.HorizontalAlignment = PdfPCell.ALIGN_LEFT


        Tabledireccion.AddCell(Col1d)
        TableEncabezado.AddCell(Tabledireccion)
        TableEncabezado.AddCell(ColFolio)

        Dim TableEspacio As PdfPTable = New PdfPTable(1)
        Dim ColEsp As PdfPCell
        TableEspacio.WidthPercentage = 100
        Dim widthsTE As Single() = New Single() {1000.0F}
        TableEspacio.SetWidths(widthsTE)

        ColEsp = New PdfPCell(New Phrase(" ", Font))
        ColEsp.Border = 0
        ColEsp.HorizontalAlignment = PdfPCell.ALIGN_LEFT
        TableEspacio.AddCell(ColEsp)

        Dim TableFechaReporte As PdfPTable = New PdfPTable(1)
        TableFechaReporte.WidthPercentage = 100
        Dim widthsFR As Single() = New Single() {500.0F}
        TableFechaReporte.SetWidths(widthsFR)

        Dim ColFechaSolRep = New PdfPCell(New Phrase("Reporte Solicitud de Pipa del " & FechaInicio & " al " & FechaFin, Font10))
        ColFechaSolRep.Border = 0
        ColFechaSolRep.HorizontalAlignment = PdfPCell.ALIGN_LEFT
        'ColFechaSolRep.BackgroundColor = BaseColor.LIGHT_GR
        TableFechaReporte.AddCell(ColFechaSolRep)


        Dim TableSolicitudes As PdfPTable = New PdfPTable(9)
        TableSolicitudes.WidthPercentage = 100
        Dim widthsT6 As Single() = New Single() {15.0F, 80.0F, 65.0F, 50.0F, 60.0F, 30.0F, 15.0F, 40.0F, 50.0F}
        TableSolicitudes.SetWidths(widthsT6)

        Dim ColSolContrato = New PdfPCell(New Phrase("N.C.", Font6B))
        ColSolContrato.Border = 7
        ColSolContrato.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        ColSolContrato.BackgroundColor = BaseColor.LIGHT_GRAY
        ColSolContrato.FixedHeight = 20.0F
        TableSolicitudes.AddCell(ColSolContrato)

        Dim ColSolNombre = New PdfPCell(New Phrase("Nombre", Font6B))
        ColSolNombre.Border = 7
        ColSolNombre.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        ColSolNombre.BackgroundColor = BaseColor.LIGHT_GRAY
        TableSolicitudes.AddCell(ColSolNombre)

        Dim ColSolDireccion = New PdfPCell(New Phrase("Dirección", Font6B))
        ColSolDireccion.Border = 7
        ColSolDireccion.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        ColSolDireccion.BackgroundColor = BaseColor.LIGHT_GRAY
        TableSolicitudes.AddCell(ColSolDireccion)

        Dim ColSolEntre = New PdfPCell(New Phrase("Entre Calles", Font6B))
        ColSolEntre.Border = 7
        ColSolEntre.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        ColSolEntre.BackgroundColor = BaseColor.LIGHT_GRAY
        TableSolicitudes.AddCell(ColSolEntre)

        Dim ColSolReferencia = New PdfPCell(New Phrase("Referencia", Font6B))
        ColSolReferencia.Border = 7
        ColSolReferencia.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        ColSolReferencia.BackgroundColor = BaseColor.LIGHT_GRAY
        TableSolicitudes.AddCell(ColSolReferencia)

        Dim ColSolCelTel = New PdfPCell(New Phrase("Celular/Teléfono", Font6B))
        ColSolCelTel.Border = 7
        ColSolCelTel.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        ColSolCelTel.BackgroundColor = BaseColor.LIGHT_GRAY
        TableSolicitudes.AddCell(ColSolCelTel)

        Dim ColSolLts = New PdfPCell(New Phrase("Litros", Font6B))
        ColSolLts.Border = 7
        ColSolLts.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        ColSolLts.BackgroundColor = BaseColor.LIGHT_GRAY
        TableSolicitudes.AddCell(ColSolLts)

        Dim ColSolFirma = New PdfPCell(New Phrase("Firma", Font6B))
        ColSolFirma.Border = 7
        ColSolFirma.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        ColSolFirma.BackgroundColor = BaseColor.LIGHT_GRAY
        TableSolicitudes.AddCell(ColSolFirma)

        Dim ColSolEAServ = New PdfPCell(New Phrase("E.A. Servicio", Font6B))
        ColSolEAServ.Border = 7
        ColSolEAServ.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        ColSolEAServ.BackgroundColor = BaseColor.LIGHT_GRAY
        TableSolicitudes.AddCell(ColSolEAServ)



        While datosSolPipa.Read()
            ColSolContrato = New PdfPCell(New Phrase(datosSolPipa("Cuenta"), Font6B))
            ColSolContrato.Border = 7
            ColSolContrato.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            ColSolContrato.FixedHeight = 40.0F
            'ColSolContrato.BackgroundColor = BaseColor.LIGHT_GRAY
            TableSolicitudes.AddCell(ColSolContrato)

            ColSolNombre = New PdfPCell(New Phrase(datosSolPipa("Nombre"), Font))
            ColSolNombre.Border = 7
            ColSolNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'ColSolNombre.BackgroundColor = BaseColor.LIGHT_GRAY
            TableSolicitudes.AddCell(ColSolNombre)

            ColSolDireccion = New PdfPCell(New Phrase(datosSolPipa("Direccion"), Font))
            ColSolDireccion.Border = 7
            ColSolDireccion.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'ColSolDireccion.BackgroundColor = BaseColor.LIGHT_GRAY
            TableSolicitudes.AddCell(ColSolDireccion)

            ColSolEntre = New PdfPCell(New Phrase(datosSolPipa("Entre"), Font))
            ColSolEntre.Border = 7
            ColSolEntre.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'ColSolEntre.BackgroundColor = BaseColor.LIGHT_GRAY
            TableSolicitudes.AddCell(ColSolEntre)

            ColSolReferencia = New PdfPCell(New Phrase(datosSolPipa("Referencia"), Font))
            ColSolReferencia.Border = 7
            ColSolReferencia.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'ColSolReferencia.BackgroundColor = BaseColor.LIGHT_GRAY
            TableSolicitudes.AddCell(ColSolReferencia)

            ColSolCelTel = New PdfPCell(New Phrase(datosSolPipa("NumCel"), Font))
            ColSolCelTel.Border = 7
            ColSolCelTel.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'ColSolCelTel.BackgroundColor = BaseColor.LIGHT_GRAY
            TableSolicitudes.AddCell(ColSolCelTel)

            ColSolLts = New PdfPCell(New Phrase(datosSolPipa("CantLts"), Font))
            ColSolLts.Border = 7
            ColSolLts.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            'ColSolFirma.BackgroundColor = BaseColor.LIGHT_GRAY
            TableSolicitudes.AddCell(ColSolLts)

            ColSolFirma = New PdfPCell(New Phrase("                ", Font))
            ColSolFirma.Border = 7
            ColSolFirma.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            'ColSolFirma.BackgroundColor = BaseColor.LIGHT_GRAY
            TableSolicitudes.AddCell(ColSolFirma)

            ColSolEAServ = New PdfPCell(New Phrase("                ", Font))
            ColSolEAServ.Border = 7
            ColSolEAServ.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            'ColSolFirma.BackgroundColor = BaseColor.LIGHT_GRAY
            TableSolicitudes.AddCell(ColSolEAServ)
        End While

        pdfDoc.Add(TableEncabezado)
        pdfDoc.Add(TableEspacio)
        pdfDoc.Add(TableEspacio)
        pdfDoc.Add(TableFechaReporte)
        pdfDoc.Add(TableEspacio)
        pdfDoc.Add(TableSolicitudes)

        pdfDoc.Close()

        vaciarHerramientas()





        Try
            Dim psi As New ProcessStartInfo(directorioSolPipaxMes & "\Reporte_" & FechaInicio & "__" & FechaFin & "__F" & folio & ".pdf")
            'psi.WorkingDirectory = cadenafolder & "\factura\" + nombresespacios

            psi.WindowStyle = ProcessWindowStyle.Hidden
            Dim p As Process = Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("error al visualizar el pdf" & ex.Message)
        End Try


        'folio = Val(obtenerCampo("select max(FolioSolPIPA) as FolioPIPA from solicitudpipa", "FolioPIPA"))
        'folio = folio + 1

        'Dim cadenafolio As String = ("UPDATE empresa SET FolioSolPIPA = '" + folio.ToString() + "' WHERE CODEMP = 1")
        'Ejecucion(cadenafolio)

        Dim cadenafolio As String = ("update empresa set FolioSolPIPA = FolioSolPIPA + 1 where CODEMP = '1'")
        Ejecucion(cadenafolio)


#End Region
    End Sub


    Private Sub DGVReportePipa_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVReportePipa.CellFormatting
        If (DGVReportePipa.Columns(e.ColumnIndex).Name = "Estatus") Then
            If Convert.ToString(e.Value) = "En Proceso" Then
                e.CellStyle.BackColor = Color.Yellow
            End If

            If Convert.ToString(e.Value) = "Entregado" Then
                e.CellStyle.BackColor = Color.Green
            End If

            If Convert.ToString(e.Value) = "No Se Entrego" Then
                e.CellStyle.BackColor = Color.Red
            End If
        End If
    End Sub
End Class