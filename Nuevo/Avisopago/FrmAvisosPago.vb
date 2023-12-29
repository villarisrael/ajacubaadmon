Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class FrmAvisosPago

    Private Sub BtnSalir_Click(sender As System.Object, e As System.EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub FrmAvisosPago_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            llenarCombo(CmdRegion, "select id_region, region from region order by region")
        Catch ex As Exception

        End Try
        Try
            llenarCombo(cmbComunidades, "SELECT id_colonia,Colonia FROM Colonia")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click



        BtnCalcular.Enabled = False

        If rbruta.Checked Then
            If CmdRegion.SelectedIndex = -1 And CmbRuta.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione los Region y Ruta para Continuar")
                CmdRegion.Focus()
                CmbRuta.Focus()
            Else
                If Chk4.Checked Then
                    reporteaviso4(CmdRegion.SelectedValue.ToString, CmbRuta.SelectedValue.ToString)
                End If
                If chk2.Checked Then
                    reporteaviso2(CmdRegion.SelectedValue.ToString, CmbRuta.SelectedValue.ToString)
                End If
            End If
        End If

        If rbComunidad.Checked Then
            If cmbComunidades.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione la Colonia para Continuar")
                cmbComunidades.Focus()
            Else
                If Chk4.Checked Then
                    reporteaviso4(cmbComunidades.SelectedValue.ToString)
                End If
                If chk2.Checked Then
                    reporteaviso2(cmbComunidades.SelectedValue.ToString)
                End If
            End If
        End If


        If rbCuenta.Checked Then
            If iiCuenta.Text = "" Then
                MessageBox.Show("Escriba el Numero de Cuenta para Continuar")
                cmbComunidades.Focus()
            Else
                If Chk4.Checked Then
                    Dim cuenta As Integer = Integer.Parse(iiCuenta.Text)
                    reporteaviso4(cuenta)
                End If
                If chk2.Checked Then
                    Dim cuenta As Integer = Integer.Parse(iiCuenta.Text)
                    reporteaviso2(cuenta)
                End If

            End If
        End If


        BtnCalcular.Enabled = True





    End Sub

    Private Sub txtMensaje_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtMensaje.MouseClick
        txtMensaje.ResetText()
    End Sub

    Private Sub chktodascolonia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmdRegion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdRegion.SelectedIndexChanged
        Try
            llenarCombo(CmbRuta, "select id_ruta, ruta from rutas where id_region='" & CmdRegion.SelectedValue & "' order by ruta")
        Catch ex As Exception

        End Try
    End Sub





    Private Sub reporteaviso4(region As String, ruta As String)
        Dim datos As IDataReader = ConsultaSql("select * from vusuario where region='" & region & "' and ruta='" & ruta & "' and mostrar=1 order by lote").ExecuteReader()

        Reporte(datos, ruta)
    End Sub

    Private Sub reporteaviso4(colonia As String)
        Dim datos As IDataReader = ConsultaSql("select * from vusuario where id_colonia='" & colonia & "' and mostrar=1 order by direccion").ExecuteReader()
        Reporte(datos, colonia)
    End Sub

    Private Sub reporteaviso4(cuenta As Integer)
        Dim datos As IDataReader = ConsultaSql("select * from vusuario where cuenta=" & cuenta & " order by direccion").ExecuteReader()
        Reporte(datos, cuenta)
    End Sub



    Private Sub reporteaviso2(region As String, ruta As String)
        Dim datos As IDataReader = ConsultaSql("select * from vusuario where region='" & region & "' and ruta='" & ruta & "' and mostrar=1 order by lote").ExecuteReader()

        Reporte2(datos, ruta)
    End Sub

    Private Sub reporteaviso2(colonia As String)
        Dim datos As IDataReader = ConsultaSql("select * from vusuario where id_colonia='" & colonia & "' and mostrar=1 order by direccion").ExecuteReader()
        Reporte2(datos, colonia)
    End Sub

    Private Sub reporteaviso2(cuenta As Integer)

        If obtenerCampo("select total from usuario where cuenta=" & cuenta, "total") = "0" Then
            MessageBox.Show("El usuario no debe")
            Exit Sub
        End If

        Dim datos As IDataReader = ConsultaSql("select * from vusuario where cuenta=" & cuenta & " ").ExecuteReader()

        Reporte2(datos, cuenta)
    End Sub


    Private Sub Reporte(datos As IDataReader, opcionGeneracion As String)



        Try

            Dim datosEmpresa As IDataReader = ConsultaSql("select * from empresa").ExecuteReader()
            datosEmpresa.Read()

            Dim direccionEmpresa As String = $"{datosEmpresa("CDOMICILIO")}, Col. {datosEmpresa("CCOLONIA")}, CP {datosEmpresa("CCODPOS")} {datosEmpresa("CPOBLACION")}, BCS."
            Dim horarioAtencion As String = $"Horario: Lunes a Viernes de 9:00 am a 4:00 pm y Sábado de 9:00 am a 1:00 pm"

            Dim Fecha As String
            Dim subtototal As String
            Dim ivaTotal As String
            'Dim acumuladores = (subtototal, ivaTotal) 'Intento de Tupla
            Dim RFCEmpresa As String = $"RFC: {datosEmpresa("CNIF").ToString.ToUpper()}"
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
            Dim directorioReporte As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\AvisosdePago").Trim
            If Not Directory.Exists(directorioReporte) Then
                Directory.CreateDirectory(directorioReporte)
            End If

            'Dar propiedades al Documento
            Dim pdfDoc As New Document(iTextSharp.text.PageSize.LETTER, 30.0F, 30.0F, 30.0F, 30.0F)


            'Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(cadenafolder & "\factura" & serie & factura & ".pdf", FileMode.Create))
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(directorioReporte & "\AvisosdePago_" & opcionGeneracion & "_" & Fecha & "_" & nuevaLetra & ".pdf", FileMode.Create))



            'Formato Letras

            Dim Font As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 6, iTextSharp.text.Font.NORMAL))
            Dim Font8N As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 7, iTextSharp.text.Font.BOLD))
            Dim Font88 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 13, iTextSharp.text.Font.BOLD))
            Dim Font8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 9, iTextSharp.text.Font.BOLD))
            Dim Font5BW As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 6, iTextSharp.text.Font.BOLD, BaseColor.WHITE))
            Dim Font5W As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 5, iTextSharp.text.Font.NORMAL, BaseColor.WHITE))

            Dim Font5B As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 5, iTextSharp.text.Font.BOLD))
            Dim Font5 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 6, iTextSharp.text.Font.NORMAL))

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
            imagenBMP.ScaleToFit(70.0F, 70.0F)
            imagenBMP.Border = 0

            'Tabla para el Encabezado
            Dim Tablecontenido = New PdfPTable(2)
            'Tablecontenido.DefaultCell.BorderWidthRight = 50
            'Tablecontenido.
            Tablecontenido.WidthPercentage = 100
            Dim widths As Single() = New Single() {300.0F, 300.0F} ' fijamos dos columnas por renglon
            Tablecontenido.SetWidths(widths)

            Dim contador4 = 1

            While datos.Read()

                Dim datosOtrosConceptos As IDataReader = ConsultaSql($"select * from otrosconceptos where cuenta= '{datos("cuenta")}' and subtotresta > 0 and pagado = 0").ExecuteReader()

                'Validar contratos que tengan adeudo, si no tiene adeudo no los debe imprimir
                If datos("total") > 0 Or datosOtrosConceptos.Read() Then




                    Dim CelContenido = New PdfPCell()
                    ' CelContenido.BorderWidth = 0
                    CelContenido.BorderWidthRight = 3.0F
                    CelContenido.FixedHeight = 340 ' fijamos la altura del aviso

                    'Tabla para el Encabezado
                    Dim tablalogo = New PdfPTable(2)
                    tablalogo.DefaultCell.Border = BorderStyle.None
                    tablalogo.WidthPercentage = 95
                    Dim ancho As Single() = New Single() {70.0F, 280.0F} ' fijamos dos columnas por renglon
                    tablalogo.SetWidths(ancho)
                    Dim Celllogo = New PdfPCell(imagenBMP, True)
                    Celllogo.Border = 0

                    tablalogo.AddCell(Celllogo)

                    Dim cellorga = New PdfPCell(New Phrase($"{Empresa} {vbCrLf} {RFCEmpresa}", Font))
                    cellorga.Border = 0
                    cellorga.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                    tablalogo.AddCell(cellorga)


                    tablalogo.AddCell(cellorga)


                    'InsertarTablaVacia(CelContenido)
                    InsertarTablaVacia(CelContenido)
                    CelContenido.AddElement(tablalogo)




                    Dim tablaFecha = New PdfPTable(3)
                    tablaFecha.DefaultCell.Border = BorderStyle.None
                    tablaFecha.WidthPercentage = 95
                    Dim anchoTFecha As Single() = New Single() {700.0F, 100.0F, 150.0F} ' fijamos dos columnas por renglon
                    tablaFecha.SetWidths(anchoTFecha)

                    Dim CellFechavacio = New PdfPCell(New Phrase(" ", Font5BW))
                    CellFechavacio.Border = 0
                    CellFechavacio.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    tablaFecha.AddCell(CellFechavacio)


                    Dim CellFecha1 = New PdfPCell(New Phrase("FECHA: ", Font5BW))
                    CellFecha1.Border = 0
                    CellFecha1.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    CellFecha1.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
                    tablaFecha.AddCell(CellFecha1)

                    Dim CellFecha2 = New PdfPCell(New Phrase(Now.Day & "/" & Now.Month & "/" & Now.Year, Font5))
                    CellFecha2.Border = 0
                    CellFecha2.HorizontalAlignment = PdfPCell.ALIGN_LEFT

                    tablaFecha.AddCell(CellFecha2)

                    CelContenido.AddElement(tablaFecha)

                    InsertarTablaVacia(CelContenido)


                    'Tabala datos del usuario encabezado
                    Dim tabladatosEncUusario = New PdfPTable(4)
                    tabladatosEncUusario.DefaultCell.Border = BorderStyle.None
                    tabladatosEncUusario.WidthPercentage = 95
                    Dim anchodatos As Single() = New Single() {65.0F, 150.0F, 65.0F, 100.0F}
                    tabladatosEncUusario.SetWidths(anchodatos)

                    Dim ColdatosEncUsuario1 = New PdfPCell(New Phrase("NOMBRE:", Font5BW))
                    ColdatosEncUsuario1.Border = 0
                    ColdatosEncUsuario1.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    ColdatosEncUsuario1.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
                    tabladatosEncUusario.AddCell(ColdatosEncUsuario1)

                    Dim ColdatosEncUsuario2 = New PdfPCell(New Phrase(datos("NOMBRE").ToString().ToUpper(), Font5))
                    ColdatosEncUsuario2.Border = 0
                    ColdatosEncUsuario2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    tabladatosEncUusario.AddCell(ColdatosEncUsuario2)




                    Dim ColdatosEncUsuario3 = New PdfPCell(New Phrase("CUENTA:", Font5BW))
                    ColdatosEncUsuario3.Border = 0
                    ColdatosEncUsuario3.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    ColdatosEncUsuario3.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
                    tabladatosEncUusario.AddCell(ColdatosEncUsuario3)


                    Dim ubicacion As String = String.Empty
                    Try
                        ubicacion = datos("UBICACION")
                    Catch ex As Exception
                        ubicacion = String.Empty
                    End Try


                    Dim ColdatosEncUsuario4 = New PdfPCell(New Phrase(datos("CUENTA") & " " & ubicacion, Font5))
                    ColdatosEncUsuario4.Border = 0
                    ColdatosEncUsuario4.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    tabladatosEncUusario.AddCell(ColdatosEncUsuario4)



                    ColdatosEncUsuario1 = New PdfPCell(New Phrase("DIRECCIÓN:", Font5BW))
                    ColdatosEncUsuario1.Border = 0
                    ColdatosEncUsuario1.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    ColdatosEncUsuario1.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
                    tabladatosEncUusario.AddCell(ColdatosEncUsuario1)

                    ColdatosEncUsuario2 = New PdfPCell(New Phrase($"{datos("DOMICILIO").ToString().ToUpper()}, {datos("COLONIA").ToString().ToUpper()}", Font5))
                    ColdatosEncUsuario2.Border = 0
                    ColdatosEncUsuario2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    tabladatosEncUusario.AddCell(ColdatosEncUsuario2)

                    ColdatosEncUsuario3 = New PdfPCell(New Phrase("TARIFA:", Font5BW))
                    ColdatosEncUsuario3.Border = 0
                    ColdatosEncUsuario3.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    ColdatosEncUsuario3.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
                    tabladatosEncUusario.AddCell(ColdatosEncUsuario3)

                    ColdatosEncUsuario4 = New PdfPCell(New Phrase(datos("DESCRIPCION_CUOTA").ToString().ToUpper(), Font5))
                    ColdatosEncUsuario4.Border = 0
                    ColdatosEncUsuario4.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    tabladatosEncUusario.AddCell(ColdatosEncUsuario4)




                    ColdatosEncUsuario1 = New PdfPCell(New Phrase(" ", Font5BW))
                    ColdatosEncUsuario1.Border = 0
                    ColdatosEncUsuario1.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    'ColdatosEncUsuario1.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
                    tabladatosEncUusario.AddCell(ColdatosEncUsuario1)

                    ColdatosEncUsuario2 = New PdfPCell(New Phrase(" ", Font5))
                    ColdatosEncUsuario2.Border = 0
                    ColdatosEncUsuario2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    tabladatosEncUusario.AddCell(ColdatosEncUsuario2)

                    ColdatosEncUsuario3 = New PdfPCell(New Phrase("NO. MED:", Font5BW))
                    ColdatosEncUsuario3.Border = 0
                    ColdatosEncUsuario3.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    ColdatosEncUsuario3.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
                    tabladatosEncUusario.AddCell(ColdatosEncUsuario3)

                    ColdatosEncUsuario4 = New PdfPCell(New Phrase(datos("NODEMEDIDOR"), Font5))
                    ColdatosEncUsuario4.Border = 0
                    ColdatosEncUsuario4.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    tabladatosEncUusario.AddCell(ColdatosEncUsuario4)


                    CelContenido.AddElement(tabladatosEncUusario)

                    InsertarTablaVacia(CelContenido)




                    Dim tabladatosLectura = New PdfPTable(6)
                    tabladatosLectura.DefaultCell.Border = BorderStyle.None
                    tabladatosLectura.WidthPercentage = 95
                    Dim anchodatosLectura As Single() = New Single() {90.0F, 50.0F, 90.0F, 50.0F, 70.0F, 50.0F}
                    tabladatosLectura.SetWidths(anchodatosLectura)

                    Dim ColdatosLectura1 = New PdfPCell(New Phrase("ULT. LEC.", Font5BW))
                    ColdatosLectura1.Border = 0
                    ColdatosLectura1.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    ColdatosLectura1.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
                    tabladatosLectura.AddCell(ColdatosLectura1)

                    Try
                        Dim ColdatosLectura2 = New PdfPCell(New Phrase(datos("LECTURAANT"), Font5))
                        ColdatosLectura2.Border = 0
                        ColdatosLectura2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                        tabladatosLectura.AddCell(ColdatosLectura2)

                    Catch ex As Exception
                        Dim ColdatosLectura2 = New PdfPCell(New Phrase(datos(""), Font5))
                        ColdatosLectura2.Border = 0
                        ColdatosLectura2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                        tabladatosLectura.AddCell(ColdatosLectura2)

                    End Try


                    Dim ColdatosLectura3 = New PdfPCell(New Phrase("LEC. ACT.", Font5BW))
                    ColdatosLectura3.Border = 0
                    ColdatosLectura3.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    ColdatosLectura3.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
                    tabladatosLectura.AddCell(ColdatosLectura3)

                    Try
                        Dim ColdatosLectura4 = New PdfPCell(New Phrase(datos("LECTURAACT"), Font5))
                        ColdatosLectura4.Border = 0
                        ColdatosLectura4.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                        tabladatosLectura.AddCell(ColdatosLectura4)
                    Catch ex As Exception
                        Dim ColdatosLectura4 = New PdfPCell(New Phrase("", Font5))
                        ColdatosLectura4.Border = 0
                        ColdatosLectura4.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                        tabladatosLectura.AddCell(ColdatosLectura4)
                    End Try



                    Dim ColdatosLectura5 = New PdfPCell(New Phrase("CONSUMO", Font5BW))
                    ColdatosLectura5.Border = 0
                    ColdatosLectura5.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    ColdatosLectura5.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
                    tabladatosLectura.AddCell(ColdatosLectura5)

                    Dim consumo As Integer = 0

                    Try
                        consumo = (Int(datos("LECTURAANT")) - Int(datos("LECTURAACT")))
                    Catch ex As Exception

                    End Try


                    Dim ColdatosLectura6 = New PdfPCell(New Phrase(consumo, Font5))
                    ColdatosLectura6.Border = 0
                    ColdatosLectura6.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    tabladatosLectura.AddCell(ColdatosLectura6)


                    CelContenido.AddElement(tabladatosLectura)

                    InsertarTablaVacia(CelContenido)

                    InsertarTablaTituloConceptos(CelContenido)


                    Dim objdatosTotal As New Acumuladores

                    objdatosTotal = InsertarTablaConceptos(CelContenido, datos("CUENTA").ToString())

                    InsertarTablaVaciaExtensa(CelContenido)

                    InsertarTablaVacia(CelContenido)

                    InsertarTablaFinal(CelContenido, datos("CUENTA").ToString(), objdatosTotal.subtotal, objdatosTotal.ivaTotal, txtMensaje.Text)

                    InsertarTablaVacia(CelContenido)

                    InsertarTablaPiePagina(CelContenido, direccionEmpresa, horarioAtencion)

                    Tablecontenido.AddCell(CelContenido)



                End If

                If contador4 = 4 Then
                    pdfDoc.NewPage()
                    contador4 = 1
                End If
                contador4 += 1



            End While


            Tablecontenido.CompleteRow()

            pdfDoc.Add(Tablecontenido)

            pdfDoc.Close()

            Process.Start(directorioReporte & "\AvisosdePago_" & opcionGeneracion & "_" & Fecha & "_" & nuevaLetra & ".pdf")

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub



    Private Sub Reporte2(datos As IDataReader, opcionGeneracion As String)



        Try

            Dim datosEmpresa As IDataReader = ConsultaSql("select * from empresa").ExecuteReader()
            datosEmpresa.Read()

            Dim direccionEmpresa As String = $"{datosEmpresa("CDOMICILIO")}, Col. {datosEmpresa("CCOLONIA")}, CP {datosEmpresa("CCODPOS")} {datosEmpresa("CPOBLACION")}, BCS."
            Dim horarioAtencion As String = $"Horario: Lunes a Viernes de 9:00 am a 4:00 pm y Sábado de 9:00 am a 1:00 pm"

            Dim Fecha As String
            Dim subtototal As String
            Dim ivaTotal As String
            'Dim acumuladores = (subtototal, ivaTotal) 'Intento de Tupla
            Dim RFCEmpresa As String = $"RFC: {datosEmpresa("CNIF").ToString.ToUpper()}"
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
            Dim directorioReporte As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\AvisosdePago").Trim
            If Not Directory.Exists(directorioReporte) Then
                Directory.CreateDirectory(directorioReporte)
            End If

            'Dar propiedades al Documento
            Dim pdfDoc As New Document(iTextSharp.text.PageSize.LETTER, 30.0F, 30.0F, 30.0F, 30.0F)


            'Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(cadenafolder & "\factura" & serie & factura & ".pdf", FileMode.Create))
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(directorioReporte & "\AvisosdePago_" & opcionGeneracion & "_" & Fecha & "_" & nuevaLetra & ".pdf", FileMode.Create))



            'Formato Letras

            Dim Font As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 6, iTextSharp.text.Font.NORMAL))
            Dim Font8N As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 7, iTextSharp.text.Font.BOLD))
            Dim Font88 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 13, iTextSharp.text.Font.BOLD))
            Dim Font8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 9, iTextSharp.text.Font.BOLD))
            Dim Font5BW As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 6, iTextSharp.text.Font.BOLD, BaseColor.WHITE))
            Dim Font5W As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 5, iTextSharp.text.Font.NORMAL, BaseColor.WHITE))

            Dim Font5B As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 5, iTextSharp.text.Font.BOLD))
            Dim Font5 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 6, iTextSharp.text.Font.NORMAL))

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
            imagenBMP.ScaleToFit(70.0F, 70.0F)
            imagenBMP.Border = 0

            'Tabla para el Encabezado
            Dim Tablecontenido = New PdfPTable(1)
            'Tablecontenido.DefaultCell.BorderWidthRight = 50
            'Tablecontenido.
            Tablecontenido.WidthPercentage = 100
            Dim widths As Single() = New Single() {600.0F} ' fijamos dos columnas por renglon
            Tablecontenido.SetWidths(widths)

            Dim contador4 As Integer = 1
            While datos.Read()

                Dim datosOtrosConceptos As IDataReader = ConsultaSql($"select * from otrosconceptos where cuenta= " & datos("cuenta") & " and subtotresta > 0 and pagado = 0").ExecuteReader()

                'Validar contratos que tengan adeudo, si no tiene adeudo no los debe imprimir
                If datos("total") > 0 Or datosOtrosConceptos.Read() Then




                    Dim CelContenido = New PdfPCell()
                    ' CelContenido.BorderWidth = 0
                    CelContenido.BorderWidthRight = 3.0F
                    CelContenido.FixedHeight = 340 ' fijamos la altura del aviso

                    'Tabla para el Encabezado
                    Dim tablalogo = New PdfPTable(2)
                    tablalogo.DefaultCell.Border = BorderStyle.None
                    tablalogo.WidthPercentage = 95
                    Dim ancho As Single() = New Single() {70.0F, 280.0F} ' fijamos dos columnas por renglon
                    tablalogo.SetWidths(ancho)
                    Dim Celllogo = New PdfPCell(imagenBMP, True)
                    Celllogo.Border = 0

                    tablalogo.AddCell(Celllogo)

                    Dim cellorga = New PdfPCell(New Phrase($"{Empresa} {vbCrLf} {RFCEmpresa}", Font12))
                    cellorga.Border = 0
                    cellorga.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                    tablalogo.AddCell(cellorga)


                    tablalogo.AddCell(cellorga)


                    'InsertarTablaVacia(CelContenido)
                    InsertarTablaVacia(CelContenido)
                    CelContenido.AddElement(tablalogo)




                    Dim tablaFecha = New PdfPTable(3)
                    tablaFecha.DefaultCell.Border = BorderStyle.None
                    tablaFecha.WidthPercentage = 95
                    Dim anchoTFecha As Single() = New Single() {700.0F, 100.0F, 150.0F} ' fijamos dos columnas por renglon
                    tablaFecha.SetWidths(anchoTFecha)

                    Dim CellFechavacio = New PdfPCell(New Phrase(" ", Font5BW))
                    CellFechavacio.Border = 0
                    CellFechavacio.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    tablaFecha.AddCell(CellFechavacio)


                    Dim CellFecha1 = New PdfPCell(New Phrase("FECHA: ", Font5BW))
                    CellFecha1.Border = 0
                    CellFecha1.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    CellFecha1.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
                    tablaFecha.AddCell(CellFecha1)

                    Dim CellFecha2 = New PdfPCell(New Phrase(Now.Day & "/" & Now.Month & "/" & Now.Year, Font8))
                    CellFecha2.Border = 0
                    CellFecha2.HorizontalAlignment = PdfPCell.ALIGN_LEFT

                    tablaFecha.AddCell(CellFecha2)

                    CelContenido.AddElement(tablaFecha)

                    InsertarTablaVacia(CelContenido)


                    'Tabala datos del usuario encabezado
                    Dim tabladatosEncUusario = New PdfPTable(4)
                    tabladatosEncUusario.DefaultCell.Border = BorderStyle.None
                    tabladatosEncUusario.WidthPercentage = 95
                    Dim anchodatos As Single() = New Single() {65.0F, 150.0F, 65.0F, 100.0F}
                    tabladatosEncUusario.SetWidths(anchodatos)

                    Dim ColdatosEncUsuario1 = New PdfPCell(New Phrase("NOMBRE:", Font5BW))
                    ColdatosEncUsuario1.Border = 0
                    ColdatosEncUsuario1.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    ColdatosEncUsuario1.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
                    tabladatosEncUusario.AddCell(ColdatosEncUsuario1)

                    Dim ColdatosEncUsuario2 = New PdfPCell(New Phrase(datos("NOMBRE").ToString().ToUpper(), Font8))
                    ColdatosEncUsuario2.Border = 0
                    ColdatosEncUsuario2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    tabladatosEncUusario.AddCell(ColdatosEncUsuario2)

                    Dim ColdatosEncUsuario3 = New PdfPCell(New Phrase("CUENTA:", Font5BW))
                    ColdatosEncUsuario3.Border = 0
                    ColdatosEncUsuario3.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    ColdatosEncUsuario3.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
                    tabladatosEncUusario.AddCell(ColdatosEncUsuario3)


                    Dim ubicacion As String = String.Empty
                    Try
                        ubicacion = datos("UBICACION")
                    Catch ex As Exception
                        ubicacion = String.Empty
                    End Try




                    Dim ColdatosEncUsuario4 = New PdfPCell(New Phrase(datos("CUENTA") & " " & ubicacion, Font8))
                    ColdatosEncUsuario4.Border = 0
                    ColdatosEncUsuario4.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    tabladatosEncUusario.AddCell(ColdatosEncUsuario4)



                    ColdatosEncUsuario1 = New PdfPCell(New Phrase("DIRECCIÓN:", Font5BW))
                    ColdatosEncUsuario1.Border = 0
                    ColdatosEncUsuario1.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    ColdatosEncUsuario1.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
                    tabladatosEncUusario.AddCell(ColdatosEncUsuario1)

                    ColdatosEncUsuario2 = New PdfPCell(New Phrase($"{datos("DOMICILIO").ToString().ToUpper()}, {datos("COLONIA").ToString().ToUpper()}", Font8))
                    ColdatosEncUsuario2.Border = 0
                    ColdatosEncUsuario2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    tabladatosEncUusario.AddCell(ColdatosEncUsuario2)

                    ColdatosEncUsuario3 = New PdfPCell(New Phrase("TARIFA:", Font5BW))
                    ColdatosEncUsuario3.Border = 0
                    ColdatosEncUsuario3.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    ColdatosEncUsuario3.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
                    tabladatosEncUusario.AddCell(ColdatosEncUsuario3)

                    ColdatosEncUsuario4 = New PdfPCell(New Phrase(datos("DESCRIPCION_CUOTA").ToString().ToUpper(), Font8))
                    ColdatosEncUsuario4.Border = 0
                    ColdatosEncUsuario4.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    tabladatosEncUusario.AddCell(ColdatosEncUsuario4)




                    ColdatosEncUsuario1 = New PdfPCell(New Phrase(" ", Font5BW))
                    ColdatosEncUsuario1.Border = 0
                    ColdatosEncUsuario1.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    'ColdatosEncUsuario1.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
                    tabladatosEncUusario.AddCell(ColdatosEncUsuario1)

                    ColdatosEncUsuario2 = New PdfPCell(New Phrase(" ", Font5))
                    ColdatosEncUsuario2.Border = 0
                    ColdatosEncUsuario2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    tabladatosEncUusario.AddCell(ColdatosEncUsuario2)

                    ColdatosEncUsuario3 = New PdfPCell(New Phrase("NO. MED:", Font8))
                    ColdatosEncUsuario3.Border = 0
                    ColdatosEncUsuario3.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    ColdatosEncUsuario3.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
                    tabladatosEncUusario.AddCell(ColdatosEncUsuario3)

                    ColdatosEncUsuario4 = New PdfPCell(New Phrase(datos("NODEMEDIDOR"), Font5))
                    ColdatosEncUsuario4.Border = 0
                    ColdatosEncUsuario4.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    tabladatosEncUusario.AddCell(ColdatosEncUsuario4)


                    CelContenido.AddElement(tabladatosEncUusario)

                    InsertarTablaVacia(CelContenido)




                    Dim tabladatosLectura = New PdfPTable(6)
                    tabladatosLectura.DefaultCell.Border = BorderStyle.None
                    tabladatosLectura.WidthPercentage = 95
                    Dim anchodatosLectura As Single() = New Single() {90.0F, 50.0F, 90.0F, 50.0F, 70.0F, 50.0F}
                    tabladatosLectura.SetWidths(anchodatosLectura)

                    Dim ColdatosLectura1 = New PdfPCell(New Phrase("ULT. LEC.", Font5BW))
                    ColdatosLectura1.Border = 0
                    ColdatosLectura1.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    ColdatosLectura1.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
                    tabladatosLectura.AddCell(ColdatosLectura1)

                    Try
                        Dim ColdatosLectura2 = New PdfPCell(New Phrase(datos("LECTURAANT"), Font5))
                        ColdatosLectura2.Border = 0
                        ColdatosLectura2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                        tabladatosLectura.AddCell(ColdatosLectura2)
                    Catch ex As Exception
                        Dim ColdatosLectura2 = New PdfPCell(New Phrase("", Font8))
                        ColdatosLectura2.Border = 0
                        ColdatosLectura2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                        tabladatosLectura.AddCell(ColdatosLectura2)
                    End Try


                    Dim ColdatosLectura3 = New PdfPCell(New Phrase("LEC. ACT.", Font5BW))
                    ColdatosLectura3.Border = 0
                    ColdatosLectura3.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    ColdatosLectura3.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
                    tabladatosLectura.AddCell(ColdatosLectura3)

                    Try
                        Dim ColdatosLectura4 = New PdfPCell(New Phrase(datos("LECTURAACT"), Font5))
                        ColdatosLectura4.Border = 0
                        ColdatosLectura4.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                        tabladatosLectura.AddCell(ColdatosLectura4)

                    Catch ex As Exception
                        Dim ColdatosLectura4 = New PdfPCell(New Phrase("", Font8))
                        ColdatosLectura4.Border = 0
                        ColdatosLectura4.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                        tabladatosLectura.AddCell(ColdatosLectura4)

                    End Try


                    Dim ColdatosLectura5 = New PdfPCell(New Phrase("CONSUMO", Font5BW))
                    ColdatosLectura5.Border = 0
                    ColdatosLectura5.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    ColdatosLectura5.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
                    tabladatosLectura.AddCell(ColdatosLectura5)
                    Dim consumo As Integer = 0
                    Try
                        consumo = (Int(datos("LECTURAANT")) - Int(datos("LECTURAACT")))
                    Catch ex As Exception

                    End Try


                    Dim ColdatosLectura6 = New PdfPCell(New Phrase(consumo, Font8))
                    ColdatosLectura6.Border = 0
                    ColdatosLectura6.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    tabladatosLectura.AddCell(ColdatosLectura6)


                    CelContenido.AddElement(tabladatosLectura)

                    InsertarTablaVacia(CelContenido)

                    InsertarTablaTituloConceptos(CelContenido)


                    Dim objdatosTotal As New Acumuladores

                    objdatosTotal = InsertarTablaConceptos(CelContenido, datos("CUENTA").ToString())

                    InsertarTablaVaciaExtensa(CelContenido)

                    InsertarTablaVacia(CelContenido)

                    InsertarTablaFinal2(CelContenido, datos("CUENTA").ToString(), objdatosTotal.subtotal, objdatosTotal.ivaTotal, txtMensaje.Text)

                    InsertarTablaVacia(CelContenido)

                    InsertarTablaPiePagina(CelContenido, direccionEmpresa, horarioAtencion)

                    Tablecontenido.AddCell(CelContenido)



                End If
                If contador4 = 2 Then
                    pdfDoc.NewPage()
                    contador4 = 1
                End If
                contador4 += 1
            End While


            '  Tablecontenido.CompleteRow()

            pdfDoc.Add(Tablecontenido)

            pdfDoc.Close()

            Process.Start(directorioReporte & "\AvisosdePago_" & opcionGeneracion & "_" & Fecha & "_" & nuevaLetra & ".pdf")

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub



    Private Sub InsertarTablaVacia(Celda As PdfPCell)

        Dim Font As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 6, iTextSharp.text.Font.NORMAL))

        Dim tablaVacia = New PdfPTable(1)
        tablaVacia.DefaultCell.Border = BorderStyle.None
        tablaVacia.WidthPercentage = 95
        Dim anchoTFecha As Single() = New Single() {900.0F} ' fijamos dos columnas por renglon
        tablaVacia.SetWidths(anchoTFecha)

        Dim CellFechavacio = New PdfPCell(New Phrase(" ", Font))
        CellFechavacio.Border = 0
        CellFechavacio.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
        tablaVacia.AddCell(CellFechavacio)

        Celda.AddElement(tablaVacia)

    End Sub

    Private Sub InsertarTablaVaciaExtensa(Celda As PdfPCell)

        Dim Font As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 6, iTextSharp.text.Font.NORMAL))

        Dim tablaVacia = New PdfPTable(1)
        tablaVacia.DefaultCell.Border = BorderStyle.None
        tablaVacia.WidthPercentage = 95
        Dim anchoTFecha As Single() = New Single() {900.0F} ' fijamos dos columnas por renglon
        tablaVacia.SetWidths(anchoTFecha)

        Dim CellFechavacio = New PdfPCell(New Phrase(" ", Font))
        CellFechavacio.Border = 2
        CellFechavacio.FixedHeight = 35.0F
        CellFechavacio.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
        tablaVacia.AddCell(CellFechavacio)

        Celda.AddElement(tablaVacia)

    End Sub

    Private Sub InsertarTablaTituloConceptos(Celda As PdfPCell)

        Dim Font6BW As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 7, iTextSharp.text.Font.BOLD, BaseColor.WHITE))

        Dim tablaConceptosTitulo = New PdfPTable(1)
        tablaConceptosTitulo.DefaultCell.Border = BorderStyle.None
        tablaConceptosTitulo.WidthPercentage = 95
        Dim anchoTituloConc As Single() = New Single() {900.0F} ' fijamos dos columnas por renglon
        tablaConceptosTitulo.SetWidths(anchoTituloConc)

        Dim CelConceptos = New PdfPCell(New Phrase("CONCEPTOS", Font6BW))
        CelConceptos.Border = 0
        CelConceptos.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        CelConceptos.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
        tablaConceptosTitulo.AddCell(CelConceptos)

        Celda.AddElement(tablaConceptosTitulo)

    End Sub

    Function InsertarTablaConceptos(Celda As PdfPCell, cuenta As String)

        Dim devolverDatos As New Acumuladores

        Dim datosUsuario As IDataReader = ConsultaSql($"select * from usuario where cuenta= '{cuenta}'").ExecuteReader()
        datosUsuario.Read()

        Dim datosOtrosConceptos As IDataReader = ConsultaSql($"select * from otrosconceptos where cuenta= '{cuenta}' and subtotresta > 0 and pagado = 0 AND Estado<>'Cancelado'").ExecuteReader()

        Dim deudaConsumo As Decimal
        Dim deudaSaneamiento As Decimal
        Dim deudaAlcantarillado As Decimal
        Dim deudaRecargos As Decimal
        Dim periodoDeuda As String

        Dim contador As Integer = 0
        Dim subtotal As Decimal
        Dim acumuladorMontoOConceptos As Decimal
        Dim acumuladorMontoIVAConceptos As Decimal

        deudaConsumo = datosUsuario("DEUDA") + datosUsuario("CONSUMO")
        deudaSaneamiento = datosUsuario("DEUDASANEA")
        deudaAlcantarillado = datosUsuario("DEUALCANT") + datosUsuario("alcaconsumo")
        deudaRecargos = datosUsuario("RECARGOS")
        periodoDeuda = datosUsuario("PERIODO")

        Dim Font5B As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 6, iTextSharp.text.Font.BOLD))

        Dim tablaConceptos = New PdfPTable(3)
        tablaConceptos.DefaultCell.Border = BorderStyle.None
        tablaConceptos.WidthPercentage = 95

        Dim anchoTablaConceptos As Single() = New Single() {110.0F, 490.0F, 200.0F} ' fijamos dos columnas por renglon
        tablaConceptos.SetWidths(anchoTablaConceptos)

        Dim ColCantidad = New PdfPCell(New Phrase("CANTIDAD", Font5B))
        ColCantidad.Border = 0
        ColCantidad.HorizontalAlignment = PdfPCell.ALIGN_CENTER

        tablaConceptos.AddCell(ColCantidad)

        Dim ColConcepto = New PdfPCell(New Phrase("CONCEPTO", Font5B))
        ColConcepto.Border = 0
        ColConcepto.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        tablaConceptos.AddCell(ColConcepto)

        Dim ColImporte = New PdfPCell(New Phrase("IMPORTE", Font5B))
        ColImporte.Border = 0
        ColImporte.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
        tablaConceptos.AddCell(ColImporte)




        For index As Integer = 0 To 3



            Select Case contador

                Case 0

                    ColCantidad = New PdfPCell(New Phrase("1", Font5B))
                    ColCantidad.Border = 0
                    ColCantidad.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                    tablaConceptos.AddCell(ColCantidad)

                    ColConcepto = New PdfPCell(New Phrase($"CONSUMO DE AGUA {periodoDeuda.ToUpper()}", Font5B))
                    ColConcepto.Border = 0
                    ColConcepto.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    tablaConceptos.AddCell(ColConcepto)

                    ColImporte = New PdfPCell(New Phrase(deudaConsumo.ToString("C"), Font5B))
                    ColImporte.Border = 0
                    ColImporte.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    tablaConceptos.AddCell(ColImporte)

                'Case 1

                '    ColCantidad = New PdfPCell(New Phrase("1", Font5B))
                '    ColCantidad.Border = 0
                '    ColCantidad.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                '    tablaConceptos.AddCell(ColCantidad)

                '    ColConcepto = New PdfPCell(New Phrase("SANEAMIENTO", Font5B))
                '    ColConcepto.Border = 0
                '    ColConcepto.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                '    tablaConceptos.AddCell(ColConcepto)

                '    ColImporte = New PdfPCell(New Phrase(deudaSaneamiento.ToString("C"), Font5B))
                '    ColImporte.Border = 0
                '    ColImporte.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                '    tablaConceptos.AddCell(ColImporte)

                Case 2

                    ColCantidad = New PdfPCell(New Phrase("1", Font5B))
                    ColCantidad.Border = 0
                    ColCantidad.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                    tablaConceptos.AddCell(ColCantidad)

                    ColConcepto = New PdfPCell(New Phrase("ALCANTARILLADO", Font5B))
                    ColConcepto.Border = 0
                    ColConcepto.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    tablaConceptos.AddCell(ColConcepto)

                    ColImporte = New PdfPCell(New Phrase(deudaAlcantarillado.ToString("C"), Font5B))
                    ColImporte.Border = 0
                    ColImporte.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    tablaConceptos.AddCell(ColImporte)

                Case 3

                    ColCantidad = New PdfPCell(New Phrase("1", Font5B))
                    ColCantidad.Border = 0
                    ColCantidad.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                    tablaConceptos.AddCell(ColCantidad)

                    ColConcepto = New PdfPCell(New Phrase("RECARGOS", Font5B))
                    ColConcepto.Border = 0
                    ColConcepto.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    tablaConceptos.AddCell(ColConcepto)

                    ColImporte = New PdfPCell(New Phrase(deudaRecargos.ToString("C"), Font5B))
                    ColImporte.Border = 0
                    ColImporte.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    tablaConceptos.AddCell(ColImporte)
                    ColImporte.FixedHeight = 70.0F

            End Select

            contador = contador + 1


        Next

        While datosOtrosConceptos.Read()

            Dim descripcionConcepto As String = datosOtrosConceptos("CONCEPTO").ToString().ToUpper()
            Dim montoRestaConcepto As Decimal = datosOtrosConceptos("SubTotResta").ToString().ToUpper()
            Dim ivaMontoResta As String = datosOtrosConceptos("ivaResta").ToString().ToUpper()

            ColCantidad = New PdfPCell(New Phrase("1", Font5B))
            ColCantidad.Border = 0
            ColCantidad.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            tablaConceptos.AddCell(ColCantidad)

            ColConcepto = New PdfPCell(New Phrase(descripcionConcepto, Font5B))
            ColConcepto.Border = 0
            ColConcepto.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            tablaConceptos.AddCell(ColConcepto)

            ColImporte = New PdfPCell(New Phrase(montoRestaConcepto.ToString("C"), Font5B))
            ColImporte.Border = 0
            ColImporte.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
            tablaConceptos.AddCell(ColImporte)
            ColImporte.FixedHeight = 70.0F

            acumuladorMontoOConceptos = acumuladorMontoOConceptos + montoRestaConcepto
            acumuladorMontoIVAConceptos = acumuladorMontoIVAConceptos + ivaMontoResta


        End While

        subtotal = deudaConsumo + deudaSaneamiento + deudaAlcantarillado + deudaRecargos + acumuladorMontoOConceptos

        devolverDatos.subtotal = subtotal
        devolverDatos.ivaTotal = acumuladorMontoIVAConceptos

        Celda.AddElement(tablaConceptos)

        Return devolverDatos

    End Function


    Private Sub InsertarTablaFinal(Celda As PdfPCell, cuentaP As String, subtotalP As Decimal, ivaTotalP As Decimal, mensajeP As String)

        Dim datosMontoDeuda As IDataReader = ConsultaSql($"select * from usuario where cuenta= '{cuentaP}'").ExecuteReader()
        datosMontoDeuda.Read()

        'Dim ivaTotal As Decimal


        Dim ivaTotal = (Decimal).Parse(datosMontoDeuda("IVA"))
        Dim total As Decimal = subtotalP + ivaTotal
        'total = datosMontoDeuda("TOTAL")

        Dim Font5BW As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 6, iTextSharp.text.Font.BOLD, BaseColor.WHITE))
        Dim Font5 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 6, iTextSharp.text.Font.NORMAL))

        Dim tablaGeneralFinal = New PdfPTable(2)
        tablaGeneralFinal.DefaultCell.Border = BorderStyle.None
        tablaGeneralFinal.WidthPercentage = 95

        Dim anchoGeneralFin As Single() = New Single() {670.0F, 350.0F} ' fijamos dos columnas por renglon
        tablaGeneralFinal.SetWidths(anchoGeneralFin)



        Dim tablaMensaje = New PdfPTable(2)
        tablaMensaje.DefaultCell.Border = BorderStyle.None
        tablaMensaje.WidthPercentage = 95
        Dim anchoMensaje As Single() = New Single() {80.0F, 400.0F} ' fijamos dos columnas por renglon
        tablaMensaje.SetWidths(anchoMensaje)

        Dim CelMensaje1 = New PdfPCell(New Phrase("Avisos:", Font5BW))
        CelMensaje1.Border = 5
        CelMensaje1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
        CelMensaje1.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
        tablaMensaje.AddCell(CelMensaje1)

        Dim CelMensaje2 = New PdfPCell(New Phrase(" ", Font5BW))
        CelMensaje2.Border = 9
        CelMensaje2.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        'CelConceptos.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
        tablaMensaje.AddCell(CelMensaje2)


        Dim CelMensaje3 = New PdfPCell(New Phrase(" ", Font5BW))
        CelMensaje3.Border = 6
        CelMensaje3.HorizontalAlignment = PdfPCell.ALIGN_LEFT
        'CelConceptos.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
        tablaMensaje.AddCell(CelMensaje3)

        Dim CelMensaje4 = New PdfPCell(New Phrase(mensajeP, Font5))
        CelMensaje4.Border = 10
        CelMensaje4.HorizontalAlignment = PdfPCell.ALIGN_LEFT
        CelMensaje4.FixedHeight = 30.0F
        'CelConceptos.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
        tablaMensaje.AddCell(CelMensaje4)





        tablaGeneralFinal.AddCell(tablaMensaje)




        Dim tablatotales = New PdfPTable(2)
        tablatotales.DefaultCell.Border = BorderStyle.None
        tablatotales.WidthPercentage = 95
        Dim anchoTotales As Single() = New Single() {170.0F, 190.0F} ' fijamos dos columnas por renglon
        tablatotales.SetWidths(anchoTotales)

        Dim CelTotal1 = New PdfPCell(New Phrase("SUBTOTAL:", Font5BW))
        CelTotal1.Border = 1
        CelTotal1.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
        CelTotal1.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
        tablatotales.AddCell(CelTotal1)


        Dim CelTotal2 = New PdfPCell(New Phrase(subtotalP.ToString("C"), Font5))
        CelTotal2.Border = 11
        CelTotal2.HorizontalAlignment = PdfPCell.ALIGN_RIGHT

        tablatotales.AddCell(CelTotal2)


        CelTotal1 = New PdfPCell(New Phrase("IVA:", Font5BW))
        CelTotal1.Border = 0
        CelTotal1.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
        CelTotal1.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
        tablatotales.AddCell(CelTotal1)


        CelTotal2 = New PdfPCell(New Phrase(ivaTotal.ToString("C"), Font5))
        CelTotal2.Border = 11
        CelTotal2.HorizontalAlignment = PdfPCell.ALIGN_RIGHT

        tablatotales.AddCell(CelTotal2)


        CelTotal1 = New PdfPCell(New Phrase("TOTAL:", Font5BW))
        CelTotal1.Border = 2
        CelTotal1.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
        CelTotal1.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
        tablatotales.AddCell(CelTotal1)


        CelTotal2 = New PdfPCell(New Phrase(total.ToString("C"), Font5))
        CelTotal2.Border = 11
        CelTotal2.HorizontalAlignment = PdfPCell.ALIGN_RIGHT

        tablatotales.AddCell(CelTotal2)


        tablaGeneralFinal.AddCell(tablatotales)

        Celda.AddElement(tablaGeneralFinal)

    End Sub


    Private Sub InsertarTablaFinal2(Celda As PdfPCell, cuentaP As String, subtotalP As Decimal, ivaTotalP As Decimal, mensajeP As String)

        Dim datosMontoDeuda As IDataReader = ConsultaSql($"select * from usuario where cuenta= '{cuentaP}'").ExecuteReader()
        datosMontoDeuda.Read()

        'Dim ivaTotal As Decimal


        Dim ivaTotal = (Decimal).Parse(datosMontoDeuda("IVA"))
        Dim total As Decimal = subtotalP + ivaTotal
        'total = datosMontoDeuda("TOTAL")

        Dim Font5BW As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE))
        Dim Font5 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL))

        Dim tablaGeneralFinal = New PdfPTable(2)
        tablaGeneralFinal.DefaultCell.Border = BorderStyle.None
        tablaGeneralFinal.WidthPercentage = 95

        Dim anchoGeneralFin As Single() = New Single() {670.0F, 350.0F} ' fijamos dos columnas por renglon
        tablaGeneralFinal.SetWidths(anchoGeneralFin)



        Dim tablaMensaje = New PdfPTable(2)
        tablaMensaje.DefaultCell.Border = BorderStyle.None
        tablaMensaje.WidthPercentage = 95
        Dim anchoMensaje As Single() = New Single() {80.0F, 400.0F} ' fijamos dos columnas por renglon
        tablaMensaje.SetWidths(anchoMensaje)

        Dim CelMensaje1 = New PdfPCell(New Phrase("Avisos:", Font5BW))
        CelMensaje1.Border = 5
        CelMensaje1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
        CelMensaje1.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
        tablaMensaje.AddCell(CelMensaje1)

        Dim CelMensaje2 = New PdfPCell(New Phrase(" ", Font5BW))
        CelMensaje2.Border = 9
        CelMensaje2.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        'CelConceptos.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
        tablaMensaje.AddCell(CelMensaje2)


        Dim CelMensaje3 = New PdfPCell(New Phrase(" ", Font5BW))
        CelMensaje3.Border = 6
        CelMensaje3.HorizontalAlignment = PdfPCell.ALIGN_LEFT
        'CelConceptos.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
        tablaMensaje.AddCell(CelMensaje3)

        Dim CelMensaje4 = New PdfPCell(New Phrase(mensajeP, Font5))
        CelMensaje4.Border = 10
        CelMensaje4.HorizontalAlignment = PdfPCell.ALIGN_LEFT
        CelMensaje4.FixedHeight = 30.0F
        'CelConceptos.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
        tablaMensaje.AddCell(CelMensaje4)





        tablaGeneralFinal.AddCell(tablaMensaje)




        Dim tablatotales = New PdfPTable(2)
        tablatotales.DefaultCell.Border = BorderStyle.None
        tablatotales.WidthPercentage = 95
        Dim anchoTotales As Single() = New Single() {170.0F, 190.0F} ' fijamos dos columnas por renglon
        tablatotales.SetWidths(anchoTotales)

        Dim CelTotal1 = New PdfPCell(New Phrase("SUBTOTAL:", Font5BW))
        CelTotal1.Border = 1
        CelTotal1.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
        CelTotal1.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
        tablatotales.AddCell(CelTotal1)


        Dim CelTotal2 = New PdfPCell(New Phrase(subtotalP.ToString("C"), Font5))
        CelTotal2.Border = 11
        CelTotal2.HorizontalAlignment = PdfPCell.ALIGN_RIGHT

        tablatotales.AddCell(CelTotal2)


        CelTotal1 = New PdfPCell(New Phrase("IVA:", Font5BW))
        CelTotal1.Border = 0
        CelTotal1.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
        CelTotal1.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
        tablatotales.AddCell(CelTotal1)


        CelTotal2 = New PdfPCell(New Phrase(ivaTotal.ToString("C"), Font5))
        CelTotal2.Border = 11
        CelTotal2.HorizontalAlignment = PdfPCell.ALIGN_RIGHT

        tablatotales.AddCell(CelTotal2)


        CelTotal1 = New PdfPCell(New Phrase("TOTAL:", Font5BW))
        CelTotal1.Border = 2
        CelTotal1.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
        CelTotal1.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
        tablatotales.AddCell(CelTotal1)


        CelTotal2 = New PdfPCell(New Phrase(total.ToString("C"), Font5))
        CelTotal2.Border = 11
        CelTotal2.HorizontalAlignment = PdfPCell.ALIGN_RIGHT

        tablatotales.AddCell(CelTotal2)


        tablaGeneralFinal.AddCell(tablatotales)

        Celda.AddElement(tablaGeneralFinal)

    End Sub

    Private Sub InsertarTablaPiePagina(Celda As PdfPCell, direccionEmpresa As String, mensajeHorario As String)

        Dim Font5 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 5, iTextSharp.text.Font.NORMAL))

        Dim tablaPiePagina = New PdfPTable(1)
        tablaPiePagina.DefaultCell.Border = BorderStyle.None
        tablaPiePagina.WidthPercentage = 95

        Dim anchoPiePagina As Single() = New Single() {900.0F} ' fijamos dos columnas por renglon
        tablaPiePagina.SetWidths(anchoPiePagina)



        Dim CelPiePagina = New PdfPCell(New Phrase(direccionEmpresa, Font5))
        CelPiePagina.Border = 0
        CelPiePagina.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        'CelPiePagina.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
        tablaPiePagina.AddCell(CelPiePagina)

        CelPiePagina = New PdfPCell(New Phrase(mensajeHorario, Font5))
        CelPiePagina.Border = 0
        CelPiePagina.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        'CelPiePagina.BackgroundColor = New iTextSharp.text.BaseColor(12, 52, 116)
        tablaPiePagina.AddCell(CelPiePagina)

        Celda.AddElement(tablaPiePagina)

    End Sub



End Class



Public Class Acumuladores

    Public subtotal As Decimal = 0.0
    Public ivaTotal As Decimal = 0.0

End Class