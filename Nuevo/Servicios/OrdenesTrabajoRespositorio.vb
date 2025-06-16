Imports System.Data.Odbc
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class OrdenesTrabajoRespositorio
    Implements IOrdenesTrabajo(Of OrdenTrabajo)

    Public Function GenerarOrdenTrabajo(id As Integer) As OrdenTrabajo Implements IOrdenesTrabajo(Of OrdenTrabajo).GenerarOrdenTrabajo

        Dim objOrdenTrabajo As New OrdenTrabajo()


        Try

            ' Crearnos la solicitud
            'Dim datosOrdenTrabajo As IDataReader = ConsultaSql($"SELECT * FROM vordent WHERE NUMERO = {id}").ExecuteReader

            Dim sqlQuery As String = $"SELECT CASE WHEN vordent.status = 1 THEN 'PENDIENTE' WHEN vordent.status = 2 THEN 'REALIZADA EN TIEMPO' WHEN vordent.status = 3 THEN 'REALIZADA FUERA DE TIEMPO' WHEN vordent.status = 4 THEN 'REALIZADA CON MAS DE TRES DIAS DE RETRASO' WHEN vordent.status = 'CANCELADA' OR vordent.status = 5 THEN 'CANCELADA' ELSE 'DESCONOCIDO' END AS ESTADO_OT, CASE WHEN vordent.urge = '-1' THEN 'URGENTE' WHEN vordent.urge = '0' THEN '' END AS URGENTE, CASE WHEN vordent.reincide = '-1' THEN 'REINCIDE' WHEN vordent.reincide = '0' THEN '' END AS REINCIDE, vordent.DEPARTAMENTO AS DEPARTAMENTO, vordent.folio AS FOLIO, vordent.cuenta AS CUENTA, VU.cuentaanterior as CUENTA_ANTERIOR, vordent.nombre AS NOMBRE, vordent.TEL AS TELEFONO, vordent.cel AS CELULAR, vordent.Descripcion_queja AS CONCEPTO, vordent.INDIC AS INDICACIONES, vordent.fec_ord AS FECHA, vordent.hora AS HORA, vordent.fec_res AS RESULTADO, vordent.fec_com AS COMPROMISO, vordent.ubicacion AS UBICACION, VU.Municipio AS MUNICIPIO, vordent.COMENT1 AS COMENTARIO, vordent.PER_ATE AS ASIGNADO, vordent.FEC_RESP AS FECHA_RESPUESTA, VU.nodemedidor as MEDIDOR, VU.REGION AS REGION_NOMBRE FROM vordent LEFT JOIN VUSUARIO VU ON vordent.CUENTA=VU.CUENTA WHERE vordent.folio = {id};"

            Using connection As New OdbcConnection(My.Settings.baseaguaConnectionString)
                connection.Open()

                Using command As New OdbcCommand(sqlQuery, connection)
                    ' Añadir parámetros al comando
                    Using reader As OdbcDataReader = command.ExecuteReader()

                        Try



                            If reader.Read() = True Then

                                objOrdenTrabajo.Status = If(IsDBNull(reader("ESTADO_OT")), "DESCONOCIDO", reader("ESTADO_OT").ToString())
                                objOrdenTrabajo.Folio = If(IsDBNull(reader("Folio")), "0", reader("Folio").ToString())
                                objOrdenTrabajo.FechaOrden = If(IsDBNull(reader("Fecha")), "0", reader("Fecha").ToString())
                                objOrdenTrabajo.Hora = If(IsDBNull(reader("Hora")), "0", reader("Hora"))
                                objOrdenTrabajo.Nombre = If(IsDBNull(reader("Nombre")), "SIN NOMBRE", reader("Nombre").ToString())
                                objOrdenTrabajo.Cuenta = If(IsDBNull(reader("Cuenta")), "0", reader("Cuenta").ToString())
                                objOrdenTrabajo.CuentaAnterior = If(IsDBNull(reader("CUENTA_ANTERIOR")), "0", reader("CUENTA_ANTERIOR").ToString())
                                objOrdenTrabajo.Direccion = If(IsDBNull(reader("UBICACION")), "SIN DIRECCIÓN", reader("UBICACION").ToString())
                                objOrdenTrabajo.Municipio = If(IsDBNull(reader("MUNICIPIO")), $"{poblacionEMPRESA}", reader("MUNICIPIO").ToString())
                                objOrdenTrabajo.Telefono = If(IsDBNull(reader("TELEFONO")), "N/A", reader("TELEFONO").ToString())
                                objOrdenTrabajo.Celular = If(IsDBNull(reader("CELULAR")), "N/A", reader("CELULAR").ToString())
                                objOrdenTrabajo.Departamento = If(IsDBNull(reader("DEPARTAMENTO")), "DEPARTAMENTO DESCONOCIDO", reader("DEPARTAMENTO").ToString())
                                objOrdenTrabajo.DescripcionQueja = If(IsDBNull(reader("CONCEPTO")), "DESCONOCIDO", reader("CONCEPTO").ToString())
                                objOrdenTrabajo.Indicaciones = If(IsDBNull(reader("INDICACIONES")), "DESCONOCIDO", reader("INDICACIONES").ToString())
                                objOrdenTrabajo.Urge = If(IsDBNull(reader("URGENTE")), "", reader("URGENTE").ToString())
                                objOrdenTrabajo.Reincide = If(IsDBNull(reader("REINCIDE")), "", reader("REINCIDE").ToString())
                                objOrdenTrabajo.Medidor = If(IsDBNull(reader("MEDIDOR")), "DESCONOCIDO", reader("MEDIDOR").ToString())
                                objOrdenTrabajo.Zona = If(IsDBNull(reader("REGION_NOMBRE")), "DESCONOCIDO", reader("REGION_NOMBRE").ToString())


                            Else

                                MessageBox.Show($"No hay datos disponibles para la orden de trabajo: {id}")

                            End If

                        Catch ex As Exception

                            MessageBox.Show($"Ocurrio un error al obtener los datos de la orden de trabajo: {id}")

                        End Try

                    End Using

                End Using

            End Using



        Catch ex As Exception

            MessageBox.Show($"OCURRIO UN ERROR: {ex.ToString()}")

        End Try



        Return objOrdenTrabajo

    End Function

    Public Function GenerarPDF(ordenTrabajo As OrdenTrabajo) As Boolean Implements IOrdenesTrabajo(Of OrdenTrabajo).GenerarPDF

        'Dim rutaDestino As String = "C:/Users/100076707/Documents/Contratos_Agua/ordenservicio.pdf"


        Dim rutaDocumento As String = ""
        Dim rutaDocumentoNombreUsuario As String = ""


        Dim doc As New Document(PageSize.A4)
        Try

            Dim rutasDocumento = CrearCarpetas(doc, ordenTrabajo.Folio, ordenTrabajo.Nombre.Trim())

            rutaDocumento = rutasDocumento.Item1
            rutaDocumentoNombreUsuario = rutasDocumento.Item2


            Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(rutaDocumento, FileMode.Create))
            Dim writerNombre As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(rutaDocumentoNombreUsuario, FileMode.Create))

            doc.Open()

            ' Fuente personalizada
            Dim fuenteTitulo As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11)
            Dim fuenteTexto As Font = FontFactory.GetFont(FontFactory.HELVETICA, 10)
            Dim fuenteTexto11 As Font = FontFactory.GetFont(FontFactory.HELVETICA, 11)
            Dim fuenteTexto12 As Font = FontFactory.GetFont(FontFactory.HELVETICA, 12)
            Dim fuenteTexto8 As Font = FontFactory.GetFont(FontFactory.HELVETICA, 8)
            Dim fuenteTexto8Bold As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8)
            Dim fuenteTexto6Bold As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 6)
            Dim fuenteTexto7Bold As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 7)
            Dim fuenteTexto6 As Font = FontFactory.GetFont(FontFactory.HELVETICA, 6)
            Dim fuenteTexto7 As Font = FontFactory.GetFont(FontFactory.HELVETICA, 7)

            '' Título
            'Dim titulo As New Paragraph("ORDEN DE TRABAJO", fuenteTitulo)
            'titulo.Alignment = Element.ALIGN_CENTER
            'doc.Add(titulo)
            'doc.Add(New Paragraph(" "))

            '' Tabla de datos del usuario
            'Dim tablaUsuario As New PdfPTable(2)
            'tablaUsuario.WidthPercentage = 100
            'tablaUsuario.AddCell(New Phrase("Cuenta:", fuenteTexto))
            'tablaUsuario.AddCell(ordenTrabajo.Cuenta)
            'tablaUsuario.AddCell(New Phrase("Nombre:", fuenteTexto))
            'tablaUsuario.AddCell(ordenTrabajo.Nombre)
            'tablaUsuario.AddCell(New Phrase("Dirección:", fuenteTexto))
            'tablaUsuario.AddCell(ordenTrabajo.Direccion)
            'tablaUsuario.AddCell(New Phrase("Teléfono:", fuenteTexto))
            'tablaUsuario.AddCell(ordenTrabajo.Telefono)
            'doc.Add(tablaUsuario)
            'doc.Add(New Paragraph(" "))

            '' Tabla de datos de la orden
            'Dim tablaOrden As New PdfPTable(2)
            'tablaOrden.WidthPercentage = 100
            'tablaOrden.AddCell(New Phrase("Área:", fuenteTexto))
            'tablaOrden.AddCell("[Área]")
            'tablaOrden.AddCell(New Phrase("Actividad:", fuenteTexto))
            'tablaOrden.AddCell("[Actividad]")
            'doc.Add(tablaOrden)
            'doc.Add(New Paragraph(" "))

            '' Indicaciones
            'doc.Add(New Paragraph("INDICACIONES:", fuenteTitulo))
            'doc.Add(New Paragraph("[Indicaciones]", fuenteTexto))
            'doc.Add(New Paragraph(" "))

            '' Materiales
            'doc.Add(New Paragraph("MATERIALES:", fuenteTitulo))
            'doc.Add(New Paragraph("[Materiales]", fuenteTexto))
            'doc.Add(New Paragraph(" "))

            '' Resultados
            'doc.Add(New Paragraph("RESULTADOS:", fuenteTitulo))
            'doc.Add(New Paragraph("[Resultados]", fuenteTexto))
            'doc.Add(New Paragraph(" "))

            '' Espacio para fotos (se pueden agregar imágenes aquí)
            'doc.Add(New Paragraph("FOTO 1", fuenteTitulo))
            'doc.Add(New Paragraph("[Imagen 1]", fuenteTexto))
            'doc.Add(New Paragraph(" "))
            'doc.Add(New Paragraph("FOTO 2", fuenteTitulo))
            'doc.Add(New Paragraph("[Imagen 2]", fuenteTexto))
            'doc.Add(New Paragraph(" "))

            '' Firmas
            'doc.Add(New Paragraph("Brigada: _________________________", fuenteTexto))
            'doc.Add(New Paragraph("Persona que recibió el servicio: _________________________", fuenteTexto))
            'doc.Add(New Paragraph("Responsable del área: _________________________", fuenteTexto))
            'doc.Add(New Paragraph("Fecha de aplicación: _________________________", fuenteTexto))


            Dim TableEncabezado As PdfPTable = New PdfPTable(4)
            TableEncabezado.DefaultCell.Border = BorderStyle.None
            TableEncabezado.WidthPercentage = 100

            Dim widths As Single() = New Single() {100.0F, 600.0F, 200.0F, 100.0F}
            TableEncabezado.SetWidths(widths)


            Dim imagenBMP As iTextSharp.text.Image
            imagenBMP = iTextSharp.text.Image.GetInstance(LOGOBYTE)
            imagenBMP.ScaleToFit(40.0F, 35.0F)
            imagenBMP.Border = 0

            TableEncabezado.AddCell(imagenBMP)



            Dim Tabledireccion As PdfPTable = New PdfPTable(1)
            Dim Col1 = New PdfPCell(New Phrase(Empresa, fuenteTitulo))
            Col1.Border = 0
            Col1.HorizontalAlignment = PdfPCell.ALIGN_CENTER

            Tabledireccion.AddCell(Col1)




            Dim direccionOrganismo As String = $"{Direccion}, {coloniaEmpresa}, CP. {cpEmpresa}, {poblacionEmpresa}, {estadoEmpresa}"
            Dim Col1Direccion = New PdfPCell(New Phrase(direccionOrganismo, fuenteTexto))
            Col1Direccion.Border = 0
            Col1Direccion.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            Tabledireccion.AddCell(Col1Direccion)



            TableEncabezado.AddCell(Tabledireccion)



            Dim TableFolio As PdfPTable = New PdfPTable(2)
            TableFolio.WidthPercentage = 100
            Dim widthsT2 As Single() = New Single() {150, 150.0F}
            TableFolio.SetWidths(widthsT2)



            Dim Col10 = New PdfPCell(New Phrase("Orden de Servicio", fuenteTexto8Bold))
            Col10.Border = 15
            Col10.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            Col10.BackgroundColor = New BaseColor(217, 217, 217) ' Azul
            TableFolio.AddCell(Col10)


            Dim Col11 = New PdfPCell(New Phrase("Fecha", fuenteTexto8Bold))
            Col11.Border = 15
            Col11.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            Col11.BackgroundColor = New BaseColor(217, 217, 217)
            TableFolio.AddCell(Col11)

            Col10 = New PdfPCell(New Phrase(ordenTrabajo.Folio, fuenteTexto8))
            Col10.Border = 0
            Col10.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableFolio.AddCell(Col10)


            Col11 = New PdfPCell(New Phrase(ordenTrabajo.FechaOrden, fuenteTexto8))
            Col11.Border = 0
            Col11.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableFolio.AddCell(Col11)


            TableEncabezado.AddCell(TableFolio)


            'Dim imagenBMP2 As iTextSharp.text.Image
            'imagenBMP2 = iTextSharp.text.Image.GetInstance(LOGOBYTE2)
            'imagenBMP2.ScaleToFit(40.0F, 35.0F)
            'imagenBMP2.Border = 0

            TableEncabezado.AddCell("")


            doc.Add(TableEncabezado)


            Dim titulo As New Paragraph("ORDEN DE TRABAJO", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10))
            titulo.Alignment = Element.ALIGN_CENTER
            doc.Add(titulo)


            Dim espacio As New Paragraph(" ", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10))
            espacio.Alignment = Element.ALIGN_CENTER
            doc.Add(espacio)



            ' Tabla de datos orden de trabajo

            Dim TableDatos As PdfPTable = New PdfPTable(3)
            TableDatos.DefaultCell.Border = BorderStyle.None
            TableDatos.WidthPercentage = 100

            Dim widthsDatos As Single() = New Single() {490.0F, 20.0F, 490.0F}
            TableDatos.SetWidths(widthsDatos)



            ' Tabla Datos de Usuario

            Dim TableDatosUsuarioGeneral As PdfPTable = New PdfPTable(1)
            TableDatosUsuarioGeneral.DefaultCell.Border = BorderStyle.None
            TableDatosUsuarioGeneral.WidthPercentage = 100

            Dim widthsDatosUsuarioGeneral As Single() = New Single() {1000.0F}
            TableDatosUsuarioGeneral.SetWidths(widthsDatosUsuarioGeneral)



            Dim TableDatosUsuario1 As PdfPTable = New PdfPTable(1)
            TableDatosUsuario1.DefaultCell.Border = BorderStyle.None
            TableDatosUsuario1.WidthPercentage = 100

            Dim widthsDatosUsuario1 As Single() = New Single() {1000.0F}
            TableDatosUsuario1.SetWidths(widthsDatosUsuario1)


            Dim Col1UsuarioTitulo = New PdfPCell(New Phrase("DATOS DEL USUARIO", fuenteTexto8))
            Col1UsuarioTitulo.Border = 15
            Col1UsuarioTitulo.BackgroundColor = New BaseColor(217, 217, 217)
            Col1UsuarioTitulo.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableDatosUsuario1.AddCell(Col1UsuarioTitulo)



            Dim TableDatosUsuario2 As PdfPTable = New PdfPTable(4)
            TableDatosUsuario2.DefaultCell.Border = BorderStyle.None
            TableDatosUsuario2.WidthPercentage = 100

            Dim widthsDatosUsuario2 As Single() = New Single() {180.0F, 400.0F, 180.0F, 210.0F}
            TableDatosUsuario2.SetWidths(widthsDatosUsuario2)


            Dim Col1Usuario21 = New PdfPCell(New Phrase("CUENTA", fuenteTexto7Bold))
            Col1Usuario21.Border = 0
            Col1Usuario21.BackgroundColor = New BaseColor(217, 217, 217)
            Col1Usuario21.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
            TableDatosUsuario2.AddCell(Col1Usuario21)


            Dim Col1Usuario22 = New PdfPCell(New Phrase(ordenTrabajo.Cuenta, fuenteTexto7))
            Col1Usuario22.Border = 0
            Col1Usuario22.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableDatosUsuario2.AddCell(Col1Usuario22)


            Dim Col1Usuario23 = New PdfPCell(New Phrase("CTA. ANTERIOR:", fuenteTexto7Bold))
            Col1Usuario23.Border = 0
            Col1Usuario23.BackgroundColor = New BaseColor(217, 217, 217)
            Col1Usuario23.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
            TableDatosUsuario2.AddCell(Col1Usuario23)


            Dim Col1Usuario24 = New PdfPCell(New Phrase(ordenTrabajo.CuentaAnterior, fuenteTexto7))
            Col1Usuario24.Border = 0
            Col1Usuario24.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableDatosUsuario2.AddCell(Col1Usuario24)



            Col1Usuario21 = New PdfPCell(New Phrase("NOMBRE", fuenteTexto7Bold))
            Col1Usuario21.Border = 0
            Col1Usuario21.BackgroundColor = New BaseColor(217, 217, 217)
            Col1Usuario21.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
            TableDatosUsuario2.AddCell(Col1Usuario21)


            Col1Usuario22 = New PdfPCell(New Phrase(ordenTrabajo.Nombre, fuenteTexto7))
            Col1Usuario22.Border = 0
            Col1Usuario22.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableDatosUsuario2.AddCell(Col1Usuario22)


            Col1Usuario23 = New PdfPCell(New Phrase("MEDIDOR", fuenteTexto7Bold))
            Col1Usuario23.Border = 0
            Col1Usuario23.BackgroundColor = New BaseColor(217, 217, 217)
            Col1Usuario23.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
            TableDatosUsuario2.AddCell(Col1Usuario23)


            Col1Usuario24 = New PdfPCell(New Phrase(ordenTrabajo.Medidor, fuenteTexto6))
            Col1Usuario24.Border = 0
            Col1Usuario24.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableDatosUsuario2.AddCell(Col1Usuario24)



            Col1Usuario21 = New PdfPCell(New Phrase("DIRECCIÓN", fuenteTexto7Bold))
            Col1Usuario21.Border = 0
            Col1Usuario21.BackgroundColor = New BaseColor(217, 217, 217)
            Col1Usuario21.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
            TableDatosUsuario2.AddCell(Col1Usuario21)


            Col1Usuario22 = New PdfPCell(New Phrase(ordenTrabajo.Direccion, fuenteTexto7))
            Col1Usuario22.Border = 0
            Col1Usuario22.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableDatosUsuario2.AddCell(Col1Usuario22)


            Col1Usuario23 = New PdfPCell(New Phrase("ZONA", fuenteTexto7Bold))
            Col1Usuario23.Border = 0
            Col1Usuario23.BackgroundColor = New BaseColor(217, 217, 217)
            Col1Usuario23.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
            TableDatosUsuario2.AddCell(Col1Usuario23)


            Col1Usuario24 = New PdfPCell(New Phrase(ordenTrabajo.Zona, fuenteTexto6))
            Col1Usuario24.Border = 0
            Col1Usuario24.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableDatosUsuario2.AddCell(Col1Usuario24)



            Col1Usuario21 = New PdfPCell(New Phrase("MUNICIPIO", fuenteTexto7Bold))
            Col1Usuario21.Border = 0
            Col1Usuario21.BackgroundColor = New BaseColor(217, 217, 217)
            Col1Usuario21.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
            TableDatosUsuario2.AddCell(Col1Usuario21)


            Col1Usuario22 = New PdfPCell(New Phrase(ordenTrabajo.Municipio, fuenteTexto7))
            Col1Usuario22.Border = 0
            Col1Usuario22.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableDatosUsuario2.AddCell(Col1Usuario22)


            Col1Usuario23 = New PdfPCell(New Phrase("", fuenteTexto8))
            Col1Usuario23.Border = 0
            Col1Usuario23.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableDatosUsuario2.AddCell(Col1Usuario23)


            Col1Usuario24 = New PdfPCell(New Phrase("", fuenteTexto8))
            Col1Usuario24.Border = 0
            Col1Usuario24.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableDatosUsuario2.AddCell(Col1Usuario24)




            Col1Usuario21 = New PdfPCell(New Phrase("TELEFONO", fuenteTexto7Bold))
            Col1Usuario21.Border = 0
            Col1Usuario21.BackgroundColor = New BaseColor(217, 217, 217)
            Col1Usuario21.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
            TableDatosUsuario2.AddCell(Col1Usuario21)


            Col1Usuario22 = New PdfPCell(New Phrase(ordenTrabajo.Telefono, fuenteTexto7))
            Col1Usuario22.Border = 0
            Col1Usuario22.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableDatosUsuario2.AddCell(Col1Usuario22)


            Col1Usuario23 = New PdfPCell(New Phrase("MÓVIL", fuenteTexto7Bold))
            Col1Usuario23.Border = 0
            Col1Usuario23.BackgroundColor = New BaseColor(217, 217, 217)
            Col1Usuario23.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
            TableDatosUsuario2.AddCell(Col1Usuario23)


            Col1Usuario24 = New PdfPCell(New Phrase(ordenTrabajo.Celular, fuenteTexto7))
            Col1Usuario24.Border = 0
            Col1Usuario24.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableDatosUsuario2.AddCell(Col1Usuario24)




            TableDatosUsuarioGeneral.AddCell(TableDatosUsuario1)
            TableDatosUsuarioGeneral.AddCell(TableDatosUsuario2)



            TableDatos.AddCell(TableDatosUsuarioGeneral)



            ' Tabla Datos de Usuario Vacia

            Dim TableDatosUsuarioVacio As PdfPTable = New PdfPTable(1)
            TableDatosUsuarioVacio.DefaultCell.Border = BorderStyle.None
            TableDatosUsuarioVacio.WidthPercentage = 100

            Dim widthsDatosUsuarioVacio As Single() = New Single() {1000.0F}
            TableDatosUsuarioVacio.SetWidths(widthsDatosUsuarioVacio)


            Dim Col1UsuarioVacio = New PdfPCell(New Phrase("", fuenteTexto8))
            Col1UsuarioVacio.Border = 0
            Col1UsuarioVacio.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableDatosUsuarioVacio.AddCell(Col1UsuarioVacio)


            TableDatos.AddCell(TableDatosUsuarioVacio)





            ' Tabla datos de la orden


            Dim TableDatosUsuarioGeneral2 As PdfPTable = New PdfPTable(1)
            TableDatosUsuarioGeneral2.DefaultCell.Border = BorderStyle.None
            TableDatosUsuarioGeneral2.WidthPercentage = 100

            Dim widthsDatosUsuarioGeneral2 As Single() = New Single() {1000.0F}
            TableDatosUsuarioGeneral2.SetWidths(widthsDatosUsuarioGeneral2)



            Dim TableDatosOrden1 As PdfPTable = New PdfPTable(1)
            TableDatosOrden1.DefaultCell.Border = BorderStyle.None
            TableDatosOrden1.WidthPercentage = 100

            Dim widthsDatosDatos1 As Single() = New Single() {1000.0F}
            TableDatosOrden1.SetWidths(widthsDatosDatos1)


            Dim Col1UsuarioTituloOrden = New PdfPCell(New Phrase("DATOS DE LA ORDEN", fuenteTexto8))
            Col1UsuarioTituloOrden.Border = 15
            Col1UsuarioTituloOrden.BackgroundColor = New BaseColor(217, 217, 217)
            Col1UsuarioTituloOrden.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableDatosOrden1.AddCell(Col1UsuarioTituloOrden)


            Col1UsuarioTituloOrden = New PdfPCell(New Phrase("ORDEN DE TRABAJO PARA:", fuenteTexto8))
            Col1UsuarioTituloOrden.Border = 0
            Col1UsuarioTituloOrden.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableDatosOrden1.AddCell(Col1UsuarioTituloOrden)



            TableDatosUsuarioGeneral2.AddCell(TableDatosOrden1)




            Dim TableDatosOrdenContenido1 As PdfPTable = New PdfPTable(2)
            TableDatosOrdenContenido1.DefaultCell.Border = BorderStyle.None
            TableDatosOrdenContenido1.WidthPercentage = 100

            Dim widthsDatosOrdenContenido1 As Single() = New Single() {200.0F, 800.0F}
            TableDatosOrdenContenido1.SetWidths(widthsDatosOrdenContenido1)


            Dim Col1Usuario31 = New PdfPCell(New Phrase("AREA:", fuenteTexto7Bold))
            Col1Usuario31.Border = 0
            Col1Usuario31.BackgroundColor = New BaseColor(217, 217, 217)
            Col1Usuario31.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
            TableDatosOrdenContenido1.AddCell(Col1Usuario31)


            Dim Col1Usuario32 = New PdfPCell(New Phrase(ordenTrabajo.Departamento, fuenteTexto7Bold))
            Col1Usuario32.Border = 0
            Col1Usuario32.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableDatosOrdenContenido1.AddCell(Col1Usuario32)


            Dim Col1Usuario33 = New PdfPCell(New Phrase("ACTIVIDAD:", fuenteTexto7Bold))
            Col1Usuario33.Border = 0
            Col1Usuario33.BackgroundColor = New BaseColor(217, 217, 217)
            Col1Usuario33.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
            TableDatosOrdenContenido1.AddCell(Col1Usuario33)


            Dim Col1Usuario34 = New PdfPCell(New Phrase(ordenTrabajo.DescripcionQueja, fuenteTexto7Bold))
            Col1Usuario34.Border = 0
            Col1Usuario34.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableDatosOrdenContenido1.AddCell(Col1Usuario34)



            Col1Usuario31 = New PdfPCell(New Phrase("ATENDER:", fuenteTexto7Bold))
            Col1Usuario31.Border = 0
            Col1Usuario31.BackgroundColor = New BaseColor(217, 217, 217)
            Col1Usuario31.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
            TableDatosOrdenContenido1.AddCell(Col1Usuario31)


            Col1Usuario32 = New PdfPCell(New Phrase(ordenTrabajo.Urge, fuenteTexto7Bold))
            Col1Usuario32.Border = 0
            Col1Usuario32.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableDatosOrdenContenido1.AddCell(Col1Usuario32)


            Col1Usuario33 = New PdfPCell(New Phrase("REINCIDE:", fuenteTexto7Bold))
            Col1Usuario33.Border = 0
            Col1Usuario33.BackgroundColor = New BaseColor(217, 217, 217)
            Col1Usuario33.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
            TableDatosOrdenContenido1.AddCell(Col1Usuario33)


            Col1Usuario34 = New PdfPCell(New Phrase(ordenTrabajo.Reincide, fuenteTexto7))
            Col1Usuario34.Border = 0
            Col1Usuario34.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableDatosOrdenContenido1.AddCell(Col1Usuario34)


            Col1Usuario33 = New PdfPCell(New Phrase("ESTATUS:", fuenteTexto7Bold))
            Col1Usuario33.Border = 0
            Col1Usuario33.BackgroundColor = New BaseColor(217, 217, 217)
            Col1Usuario33.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
            TableDatosOrdenContenido1.AddCell(Col1Usuario33)


            Col1Usuario34 = New PdfPCell(New Phrase(ordenTrabajo.Status, fuenteTexto7Bold))
            Col1Usuario34.Border = 0
            Col1Usuario34.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableDatosOrdenContenido1.AddCell(Col1Usuario34)


            TableDatosUsuarioGeneral2.AddCell(TableDatosOrdenContenido1)



            TableDatos.AddCell(TableDatosUsuarioGeneral2)


            doc.Add(TableDatos)



            doc.Add(espacio)





            ' Tabla generall, indicaciones y fotos

            Dim TableGeneral2 As PdfPTable = New PdfPTable(3)
            TableGeneral2.DefaultCell.Border = BorderStyle.None
            TableGeneral2.WidthPercentage = 100

            Dim widthsGeneral2 As Single() = New Single() {490.0F, 20.0F, 490.0F}
            TableGeneral2.SetWidths(widthsGeneral2)



            Dim TableIndicaciones As PdfPTable = New PdfPTable(1)
            TableIndicaciones.DefaultCell.Border = BorderStyle.None
            TableIndicaciones.WidthPercentage = 100

            Dim widthsDatosIndicaciones As Single() = New Single() {1000.0F}
            TableIndicaciones.SetWidths(widthsDatosIndicaciones)


            Dim Col1Indicaciones = New PdfPCell(New Phrase($"INDICACIONES: {ordenTrabajo.Indicaciones}{vbCrLf}{vbCrLf}", fuenteTexto))
            Col1Indicaciones.Border = 0
            Col1Indicaciones.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableIndicaciones.AddCell(Col1Indicaciones)



            Dim Col1Materiales = New PdfPCell(New Phrase($"MATERIALES: ______________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________{vbCrLf}{vbCrLf}", fuenteTexto11))
            Col1Materiales.Border = 0
            Col1Materiales.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableIndicaciones.AddCell(Col1Materiales)



            Dim Col1Resultados = New PdfPCell(New Phrase($"RESULTADOS: ______________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________", fuenteTexto11))
            Col1Resultados.Border = 0
            Col1Resultados.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableIndicaciones.AddCell(Col1Resultados)


            TableGeneral2.AddCell(TableIndicaciones)




            ' Tabla Datos de Usuario Vacia

            Dim TableDatosUsuarioVacio2 As PdfPTable = New PdfPTable(1)
            TableDatosUsuarioVacio2.DefaultCell.Border = BorderStyle.None
            TableDatosUsuarioVacio2.WidthPercentage = 100

            Dim widthsDatosUsuarioVacio2 As Single() = New Single() {1000.0F}
            TableDatosUsuarioVacio2.SetWidths(widthsDatosUsuarioVacio2)


            Dim Col1UsuarioVacio2 = New PdfPCell(New Phrase("", fuenteTexto8))
            Col1UsuarioVacio2.Border = 0
            Col1UsuarioVacio2.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableDatosUsuarioVacio2.AddCell(Col1UsuarioVacio2)


            TableGeneral2.AddCell(TableDatosUsuarioVacio2)






            ' Tabla fotos

            Dim TableFotos As PdfPTable = New PdfPTable(1)
            TableFotos.DefaultCell.Border = BorderStyle.None
            TableFotos.WidthPercentage = 100

            Dim widthsFotos As Single() = New Single() {1000.0F}
            TableFotos.SetWidths(widthsFotos)


            Dim imagenFoto1 As iTextSharp.text.Image
            imagenFoto1 = iTextSharp.text.Image.GetInstance(Foto1OrdenTrabajo)
            imagenFoto1.ScaleToFit(80.0F, 70.0F)
            imagenFoto1.Border = 0

            TableFotos.AddCell(imagenFoto1)



            Dim imagenFoto2 As iTextSharp.text.Image
            imagenFoto2 = iTextSharp.text.Image.GetInstance(Foto1OrdenTrabajo)
            imagenFoto2.ScaleToFit(80.0F, 70.0F)
            imagenFoto2.Border = 0

            TableFotos.AddCell(imagenFoto2)


            TableGeneral2.AddCell(TableFotos)


            doc.Add(TableGeneral2)

            doc.Add(espacio)
            doc.Add(espacio)



            ' Tabla firmas


            Dim TableGeneral3 As PdfPTable = New PdfPTable(3)
            TableGeneral3.DefaultCell.Border = BorderStyle.None
            TableGeneral3.WidthPercentage = 100

            Dim widthsGeneral3 As Single() = New Single() {490.0F, 20.0F, 490.0F}
            TableGeneral3.SetWidths(widthsGeneral3)



            Dim Col1FirmaBrigada = New PdfPCell(New Phrase($"BRIGADA", fuenteTexto8))
            Col1FirmaBrigada.Border = 1
            Col1FirmaBrigada.BorderWidth = 2
            Col1FirmaBrigada.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableGeneral3.AddCell(Col1FirmaBrigada)



            Dim Col1Vacio = New PdfPCell(New Phrase($"", fuenteTexto))
            Col1Vacio.Border = 0
            Col1Vacio.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableGeneral3.AddCell(Col1Vacio)



            Dim Col1Recibio = New PdfPCell(New Phrase($"PERSONA QUE RECIBIO EL SERVICIO", fuenteTexto8))
            Col1Recibio.Border = 1
            Col1Recibio.BorderWidth = 2
            Col1Recibio.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableGeneral3.AddCell(Col1Recibio)


            doc.Add(TableGeneral3)


            doc.Add(espacio)
            doc.Add(espacio)



            Dim TableFirmaResponsable As PdfPTable = New PdfPTable(3)
            TableFirmaResponsable.DefaultCell.Border = BorderStyle.None
            TableFirmaResponsable.WidthPercentage = 100

            Dim widthsFirmaResponsable As Single() = New Single() {200.0F, 600.0F, 200.0F}
            TableFirmaResponsable.SetWidths(widthsFirmaResponsable)


            Dim Col1VacioFirma = New PdfPCell(New Phrase($"", fuenteTexto))
            Col1VacioFirma.Border =
            Col1VacioFirma.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableGeneral3.AddCell(Col1VacioFirma)

            TableFirmaResponsable.AddCell(Col1VacioFirma)




            Dim Col1ResponsableArea = New PdfPCell(New Phrase($"RESPONSABLE DEL AREA", fuenteTexto8))
            Col1ResponsableArea.Border = 1
            Col1ResponsableArea.BorderWidth = 2
            Col1ResponsableArea.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableGeneral3.AddCell(Col1ResponsableArea)

            TableFirmaResponsable.AddCell(Col1ResponsableArea)




            Col1VacioFirma = New PdfPCell(New Phrase($" ", fuenteTexto6Bold))
            Col1VacioFirma.Border = 0
            Col1VacioFirma.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableGeneral3.AddCell(Col1VacioFirma)

            TableFirmaResponsable.AddCell(Col1VacioFirma)


            doc.Add(TableFirmaResponsable)

            doc.Add(espacio)



            Dim fechaAplicación As New Paragraph($"FECHA DE APLICACIÓN:___________________", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 7))
            fechaAplicación.Alignment = Element.ALIGN_RIGHT
            doc.Add(fechaAplicación)

            Return True


        Catch ex As Exception

            Throw New Exception("Error al generar el PDF: " & ex.Message)

            Return False

        Finally

            doc.Close()

            VisualizarPDF(rutaDocumento)

        End Try



    End Function

    Public Function CrearCarpetas(pdfDocumento As Document, folioDocumento As Double, nombreUsuario As String) As (String, String)

        Dim rutaPDF As String = ""
        Dim rutaPDFNombre As String = ""
        Dim cadenaFolder As String = ""
        Dim cadenaFolderNombreUsuario As String = ""

        Dim cadenaRutaXML As String = ""



        Try





            If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\OrdenesTrabajo\" & Year(Now) & acompletacero(Month(Now).ToString(), 2).Trim) Then

                My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\OrdenesTrabajo\" & Year(Now) & acompletacero(Month(Now).ToString(), 2).Trim)



            End If

            If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\OrdenesTrabajo\" & Year(Now) & acompletacero(Month(Now).ToString(), 2).Trim & "\" & nombreUsuario) Then

                My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\OrdenesTrabajo\" & Year(Now) & acompletacero(Month(Now).ToString(), 2).Trim & "\" & nombreUsuario)

            End If

            cadenaFolder = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\OrdenesTrabajo\" & Year(Now) & acompletacero(Month(Now).ToString(), 2).Trim)

            cadenaFolderNombreUsuario = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\OrdenesTrabajo\" & Year(Now) & acompletacero(Month(Now).ToString(), 2).Trim & "\" & nombreUsuario)


            'Dim cadenaFolder As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Facturas\" & Year(Now) & acompletacero(Month(Now).ToString(), 2).Trim)

            'Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDocumento, New System.IO.FileStream(cadenaFolder & "\Factura_" & serieDocumento & folioDocumento & ".pdf", FileMode.Create))



            'objXMLReader.CrearArchivoXML(datosCFDI40_XML.Serie, datosCFDI40_XML.Folio, cadenafolderComplemento)


            rutaPDF = $"{cadenaFolder}\OrdenTrabajo_{folioDocumento}.pdf"

            rutaPDFNombre = $"{cadenaFolderNombreUsuario}\OrdenTrabajo_{folioDocumento}.pdf"




        Catch ex As Exception

            MessageBox.Show($"Ocurrio un error al crear las carpetas de factura: {ex.ToString()}")

        End Try

        Return (rutaPDF, rutaPDFNombre)

    End Function


    Public Sub VisualizarPDF(rutaPDFP As String)

        Try
            Dim psi As New ProcessStartInfo(rutaPDFP)
            'psi.WorkingDirectory = cadenafolder & "\factura\" + nombresespacios

            psi.WindowStyle = ProcessWindowStyle.Hidden
            Dim p As Process = Process.Start(psi)


        Catch ex As Exception

            MessageBox.Show("Ocurrio un error al visualizar el pdf" & ex.Message)

        End Try

    End Sub


End Class
