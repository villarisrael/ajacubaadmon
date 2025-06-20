Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class FormatosUsuarioRepositorio
    Implements IFormatos(Of UsuarioDTO)


    Dim Font7 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 7, iTextSharp.text.Font.NORMAL))
    Dim Font7Bold As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 7, iTextSharp.text.Font.BOLD))
    Dim Font8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL))
    Dim Font8Bold As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD))
    Dim Font9 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 9, iTextSharp.text.Font.NORMAL))
    Dim Font9Bold As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 9, iTextSharp.text.Font.BOLD))
    Dim Font10 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.NORMAL))
    Dim Font10Bold As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.BOLD))
    Dim Font11 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 11, iTextSharp.text.Font.NORMAL))
    Dim Font11Bold As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 11, iTextSharp.text.Font.BOLD))
    Dim Font12 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.NORMAL))
    Dim Font12Bold As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.BOLD))
    Dim Font13 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 13, iTextSharp.text.Font.NORMAL))
    Dim Font13Bold As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 13, iTextSharp.text.Font.BOLD))
    Dim Font14 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 14, iTextSharp.text.Font.NORMAL))
    Dim Font14Bold As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 14, iTextSharp.text.Font.BOLD))

    Dim CVacio As PdfPCell = New PdfPCell(New Phrase(""))




    Public Function GenerarContratoAguaPDF(objetoModelo As UsuarioDTO) As Boolean Implements IFormatos(Of UsuarioDTO).GenerarContratoAguaPDF

        'Dim rutaArchivo As String = ""
        'Dim rutaDocumento As String = ""


        Using ms As New MemoryStream()



            Try


                'Dar propiedades al Documento
                Dim pdfDoc As New Document(iTextSharp.text.PageSize.LETTER, 15.0F, 15.0F, 30.0F, 30.0F)





                'rutaArchivo = CrearCarpetaArchivos("ContratosAgua")




                'Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(rutaArchivo & "\ContratoAgua_" & objetoModelo.Cuenta & "_" & objetoModelo.Nombre & ".pdf", FileMode.Create))


                'rutaDocumento = $"{rutaArchivo}\ContratoAgua_{objetoModelo.Cuenta}_{objetoModelo.Nombre}.pdf"

                Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, ms)



                pdfDoc.Open()



                ' Agregar encabezado
                Dim encabezadoTable As New PdfPTable(3)
                encabezadoTable.WidthPercentage = 100
                encabezadoTable.SetWidths(New Single() {15, 70, 15})

                ' Logo
                If funcionesbasicas.LOGOBYTE IsNot Nothing AndAlso funcionesbasicas.LOGOBYTE.Length > 0 Then
                    Dim logo As Image = Image.GetInstance(funcionesbasicas.LOGOBYTE)
                    logo.ScaleToFit(70, 50)
                    Dim logoCell As New PdfPCell(logo, False)
                    logoCell.Border = Rectangle.NO_BORDER
                    logoCell.HorizontalAlignment = Element.ALIGN_CENTER
                    encabezadoTable.AddCell(logoCell)
                Else
                    encabezadoTable.AddCell(New PdfPCell(New Phrase("", Font7)) With {.Border = Rectangle.NO_BORDER})
                End If


                ' Título de la empresa
                Dim empresaInfo As New Paragraph()
                empresaInfo.Add(New Chunk(funcionesbasicas.Empresa & vbLf, Font13Bold))
                empresaInfo.Add(New Chunk($"{funcionesbasicas.Direccion}, {funcionesbasicas.coloniaEMPRESA}, {funcionesbasicas.Estadoempresa}, {funcionesbasicas.cpEmpresa}" & vbLf, Font10))
                empresaInfo.Add(New Chunk($"{funcionesbasicas.RFCORGANISMO}" & vbLf, Font9))
                empresaInfo.Add(New Chunk($"TEL. {funcionesbasicas.telefonoOrganismo}" & vbLf, Font7))
                encabezadoTable.AddCell(New PdfPCell(empresaInfo) With {
                    .HorizontalAlignment = Element.ALIGN_CENTER,
                    .Border = Rectangle.NO_BORDER
                })


                'Logo 2

                If funcionesbasicas.LOGOBYTE2 IsNot Nothing AndAlso funcionesbasicas.LOGOBYTE2.Length > 0 Then
                    Dim logo As Image = Image.GetInstance(funcionesbasicas.LOGOBYTE2)
                    logo.ScaleToFit(70, 50)
                    Dim logoCell As New PdfPCell(logo, False)
                    logoCell.Border = Rectangle.NO_BORDER
                    logoCell.HorizontalAlignment = Element.ALIGN_CENTER
                    encabezadoTable.AddCell(logoCell)
                Else
                    encabezadoTable.AddCell(New PdfPCell(New Phrase("", Font7)) With {.Border = Rectangle.NO_BORDER})
                End If



                pdfDoc.Add(encabezadoTable)






                '        ESPACIO VACÍO
                Dim TableEspacio As New PdfPTable(1) ' 
                TableEspacio.WidthPercentage = 100

                Dim espacio As New PdfPCell(New Phrase(" ", Font7)) With {
                    .Border = PdfPCell.NO_BORDER,
                    .FixedHeight = 10 ' Espacio de 10 puntos
                }

                TableEspacio.AddCell(espacio)



                pdfDoc.Add(TableEspacio) ' Se añade el espacio vacío




                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



                Dim TableTitulo As PdfPTable = New PdfPTable(1)
                TableTitulo.DefaultCell.Border = BorderStyle.None

                'Dim ILine As Integer
                'Dim iFila As Integer
                TableTitulo.WidthPercentage = 100

                Dim widthsTabTitulo As Single() = New Single() {900.0F}
                TableTitulo.SetWidths(widthsTabTitulo)



                'Dim DIRECCIONE As String = Direccion & " " & coloniaEMPRESA & " " & poblacionEMPRESA & " " & Estadoempresa
                Dim Col1Titulo = New PdfPCell(New Phrase("CONTRATO DE PRESTACIÓN DE SERVICIOS DE AGUA POTABLE", Font10))
                Col1Titulo.Border = 0
                Col1Titulo.HorizontalAlignment = PdfPCell.ALIGN_CENTER

                TableTitulo.AddCell(Col1Titulo)




                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                Dim TableDatosContrato As PdfPTable = New PdfPTable(2) ' Definir dos columnas
                TableDatosContrato.WidthPercentage = 100
                Dim widthsT6 As Single() = New Single() {20.0F, 60.0F} ' Ajustar el ancho de columnas
                TableDatosContrato.SetWidths(widthsT6)

                Dim Col As PdfPCell
                Dim Col2 As PdfPCell


                ' Primera fila: TIPO
                Col = New PdfPCell(New Phrase("TIPO DE SERVICIO:", Font8))
                Col.Border = 0
                Col.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosContrato.AddCell(Col)

                Col2 = New PdfPCell(New Phrase(objetoModelo.TipoUsu, Font8))
                Col2.Border = 0
                Col2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosContrato.AddCell(Col2)

                ' Segunda fila: CONTRATO
                Col = New PdfPCell(New Phrase("CONTRATO NO:", Font8))
                Col.Border = 0
                Col.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosContrato.AddCell(Col)

                Col2 = New PdfPCell(New Phrase(objetoModelo.Cuenta, Font8))
                Col2.Border = 0
                Col2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosContrato.AddCell(Col2)

                ' Tercera fila: CUENTA
                Col = New PdfPCell(New Phrase("MEDIDOR NO:", Font8))
                Col.Border = 0
                Col.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosContrato.AddCell(Col)

                Col2 = New PdfPCell(New Phrase(objetoModelo.NodeMedidor, Font8))
                Col2.Border = 0
                Col2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosContrato.AddCell(Col2)

                ' Cuarta fila: GIRO
                Col = New PdfPCell(New Phrase("MARCA:", Font8))
                Col.Border = 0
                Col.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosContrato.AddCell(Col)

                Col2 = New PdfPCell(New Phrase(objetoModelo.MarcaMedidor, Font8))
                Col2.Border = 0
                Col2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosContrato.AddCell(Col2)

                ' Quinta fila: CÉDULA CATASTRAL
                Col = New PdfPCell(New Phrase("ESTATUS DEL SERVICIO:", Font8))
                Col.Border = 0
                Col.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosContrato.AddCell(Col)

                Col2 = New PdfPCell(New Phrase(objetoModelo.Estado, Font8))
                Col2.Border = 0
                Col2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosContrato.AddCell(Col2)


                Dim TableFecha As New PdfPTable(1) ' Solo una columna para todo el texto
                TableFecha.WidthPercentage = 40 ' Ajustar ancho total
                TableFecha.DefaultCell.Border = PdfPCell.NO_BORDER ' Sin bordes

                Dim BoldFont As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9)
                Dim RegularFont As Font = FontFactory.GetFont(FontFactory.HELVETICA, 9)

                Try
                    Dim fechaContrato As Date = Convert.ToDateTime(objetoModelo.FechaAlta)

                    ' 
                    Dim textoFecha As New Phrase()
                    ' Agregar encabezado "FECHA:" 
                    textoFecha.Add(New Chunk("FECHA  ", BoldFont))
                    textoFecha.Add(New Chunk("DIA: ", BoldFont))
                    textoFecha.Add(New Chunk(fechaContrato.Day.ToString() + "  ", RegularFont))
                    textoFecha.Add(New Chunk("MES: ", BoldFont))
                    textoFecha.Add(New Chunk(fechaContrato.ToString("MMMM").ToUpper() + "  ", RegularFont))
                    textoFecha.Add(New Chunk("AÑO: ", BoldFont))
                    textoFecha.Add(New Chunk(fechaContrato.Year.ToString(), RegularFont))

                    ' Agregar a la tabla en una sola celda
                    TableFecha.AddCell(New PdfPCell(textoFecha) With {
                        .Border = PdfPCell.NO_BORDER,
                        .Padding = 2,
                        .HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    })

                Catch ex As Exception
                    Dim fechaActual As Date = Now

                    ' Manejo de error: Si no se obtiene una fecha válida, mostramos la fecha actual
                    Dim textoFecha As New Phrase()
                    textoFecha.Add(New Chunk("FECHA  ", BoldFont))
                    textoFecha.Add(New Chunk("DIA : ", BoldFont))
                    textoFecha.Add(New Chunk(fechaActual.Day.ToString() + "  ", RegularFont))
                    textoFecha.Add(New Chunk("MES : ", BoldFont))
                    textoFecha.Add(New Chunk(fechaActual.ToString("MMMM").ToUpper() + "  ", RegularFont))
                    textoFecha.Add(New Chunk("AÑO : ", BoldFont))
                    textoFecha.Add(New Chunk(fechaActual.Year.ToString(), RegularFont))

                    TableFecha.AddCell(New PdfPCell(textoFecha) With {
                        .Border = PdfPCell.NO_BORDER,
                        .Padding = 0,
                        .HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    })
                End Try

                ' Agregar la tabla de fecha a la tabla principal TableDatosContrato sin bordes
                TableDatosContrato.AddCell(New PdfPCell(TableFecha) With {.Colspan = 7, .Border = PdfPCell.NO_BORDER, .Padding = 1})





                Dim TableCuerpoContrato As PdfPTable = New PdfPTable(1)
                TableCuerpoContrato.DefaultCell.Border = BorderStyle.None


                TableCuerpoContrato.WidthPercentage = 100

                Dim widthsTabCuerpoContrato As Single() = New Single() {800.0F}
                TableCuerpoContrato.SetWidths(widthsTabCuerpoContrato)




                Dim Col1CuerpoContrato = New PdfPCell(New Phrase($"CONTRATO DE SERVICIO DE AGUA POTABLE que celebra por una parte la {funcionesbasicas.Empresa}, representada por el DIRECTOR GENERAL {funcionesbasicas.DirectorOrganismo}, que en lo sucesivo se determina como {“CAYSA”} y por la otra parte el/la C. {objetoModelo.Nombre}, en lo sucesivo se determina como {“EL USUARIO”}, y en conjunto se les denominará {“LAS PARTES”}; y cuyo objeto será el suministro de agua potable, con arreglo a las declaraciones y cláusulas siguientes:", Font10))

                Col1CuerpoContrato.Border = 0
                Col1CuerpoContrato.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED
                TableCuerpoContrato.AddCell(Col1CuerpoContrato)

                Col1CuerpoContrato = New PdfPCell(New Phrase(" ", Font12))
                Col1CuerpoContrato.Border = 0
                Col1CuerpoContrato.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                TableCuerpoContrato.AddCell(Col1CuerpoContrato)


                'Dim DIRECCIONE As String = Direccion & " " & coloniaEMPRESA & " " & poblacionEMPRESA & " " & Estadoempresa

                ' Crear la celda con la palabra "CLÁUSULAS" en negrita
                Col1CuerpoContrato = New PdfPCell(New Phrase("D E C L A R A C I O N E S", Font14Bold))
                Col1CuerpoContrato.Border = 0
                Col1CuerpoContrato.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                TableCuerpoContrato.AddCell(Col1CuerpoContrato)

                ' Crear una celda vacía
                Col1CuerpoContrato = New PdfPCell(New Phrase(" ", Font12))
                Col1CuerpoContrato.Border = 0
                Col1CuerpoContrato.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                TableCuerpoContrato.AddCell(Col1CuerpoContrato)


                '& vbCrLf &  - dar salto de linea


                Dim Col1CuerpoContrato2 = New PdfPCell(New Phrase($"
{“CAYSA”} declara:

I. Que, es un organismo público descentralizado de la administración pública del estado, con personalidad jurídica y patrimonio propios, de conformidad con el decreto de creación, publicado en el periódico oficial del estado, el 29 de diciembre del 2014, cuyo objetivo principal es la prestación de los servicios públicos de suministro de agua potable, alcantarillado y saneamiento, en los términos establecidos en la segunda parte del párrafo tercero del artículo 115 de la constitución política de los estados unidos mexicanos. 

II. Que, tiene su domicilio en {Direccion}, Colonia {coloniaEMPRESA} en {CPoblacion}, {Estadoempresa}, Código Postal {cpEmpresa}.

{“EL USUARIO”} declara:

I. Que, lleva por nombre {objetoModelo.Nombre}, de 65 años de edad, de nacionalidad mexicana, con domicilio {objetoModelo.Domicilio}, COL. {objetoModelo.Colonia}, {objetoModelo.Comunidad}, {CPoblacion}, {Estadoempresa}, CODIGO POSTAL {objetoModelo.Cp}, CON CLAVE DE ELECTOR  HRMRRS60051013M800 Y CURP HEMR600510MHGRRS05.

{“LAS PARTES”} declaran:

Que, se reconocen plenamente la personalidad con que actúan y establecen que este Contrato, es solo para efectos de contratar el servicio de agua y alcantarillado y no podrá ser usado para efectos de acreditar la propiedad y/o la posesión del predio aquel en que son suministrados dichos servicios, en ese sentido, se lleva a cabo bajo las siguientes:



", Font10))

                Col1CuerpoContrato2.Border = 0
                Col1CuerpoContrato2.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED
                TableCuerpoContrato.AddCell(Col1CuerpoContrato2)





                Col1CuerpoContrato = New PdfPCell(New Phrase("C  L  Á  U  S  U  L  A  S", Font14Bold))
                Col1CuerpoContrato.Border = 0
                Col1CuerpoContrato.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                TableCuerpoContrato.AddCell(Col1CuerpoContrato)






                Dim Col2CuerpoContrato2 = New PdfPCell(New Phrase($"

            PRIMERA. - El servicio de alcantarillado será conectado en C.{objetoModelo.Domicilio}, {objetoModelo.NumExt} , {objetoModelo.Comunidad}, {objetoModelo.Comunidad}, {objetoModelo.Estado}.

            SEGUNDA. - El servicio instalado será para uso Doméstico, el cual se instalará en la casa habitación ubicado en la dirección mencionada en la cláusula primera de este contrato.

            TERCERA.- INICIO DE LOS SERVICIOS- Para el efecto de que se inicie el suministro de agua, serán requisitos indispensables que: I) {“EL USUARIO”} haya pagado el importe del contrato de agua potable II) {“EL USUARIO”} firme de conformidad, la solicitud del servicio, el contrato de servicio de agua potable, y cumplir con la documentación requerida personal y del bien inmueble III) {“EL USUARIO”} realice debidamente el registro físico correspondiente para la instalación del servicio IV) {“EL USUARIO”} adquiera el medidor de agua potable, para instalar debidamente su servicio.

            CUARTA. - La instalación del servicio será responsabilidad de {“EL USUARIO”}, para lo cual debe preparar el registro, así como tener su material listo para la instalación del mismo, ya que la instalación se realizará por parte de {“CAYSA”}, en caso de no contar con su material y medidor y haber cumplido con los requisitos de la cláusula tercera, no se realizará la conexión de la misma, y deberá solicitarla nuevamente en las oficinas de {“CAYSA”}.

            QUINTA. -TARIFAS- {“EL USUARIO”} pagará mensualmente los servicios que reciba y en forma oportuna, las correspondientes cuotas y tarifas vigentes, que serán las últimas publicadas en el Periódico Oficial del Estado de Hidalgo, basándose en el medidor y en la categoría solicitada, del tipo anteriormente indicado con base a las tarifas que se encuentran aprobadas o en las que a futuro se actualicen. {“EL USUARIO”} cubrirá el pago correspondiente en las oficinas de {“CAYSA”} en moneda nacional, de curso legal, dentro de los cinco días posteriores a que se le haya notificado la lectura del consumo correspondiente al mes inmediato anterior o de la fecha en que se comunique al adeudo correspondiente.

            SEXTA. - La falta de pago motivará el cobro de recargos, así como lo establece la Ley de Ingresos vigente aplicable, el pago que reciba {“CAYSA”} se aplicará en el siguiente orden de prelación:

            a)	Multas;
            b)	Recargos;
            c)	Suerte principal (consumo)

            SÉPTIMA. - En caso de dejar de pagar el servicio, durante dos meses consecutivos, se hará efectivo su cobro mediante el procedimiento económico coactivo aplicado conforme a las disposiciones locales en vigor.

            OCTAVA. - Al hacerse la lectura del medidor, el lecturista entregará en el predio de {“EL USUARIO”}, giro o establecimientos una nota de lectura membretada con la lectura actual del medidor, así como la cuota del consumo respectivo y a partir de ese momento cubrirá el importe del mismo.

            NOVENA. - Cuando por cualquier causa, por desperfecto del medidor no pueda leerse el consumo efectivo, se le cobrará promediando el pago de los dos meses inmediatos anteriores o en caso que la instalación fuera reciente y menor al término de dos meses señalados se le cobrará conforme a la cuota mínima, este movimiento se realizará una única vez, otorgando un plazo de 60 días para reparar el medidor o bien instalar un nuevo para poder medir su consumo.

            DÉCIMA. - En el caso de que el consumo no se pueda efectuar por desperfectos en aparato medidor causados intencionalmente o por motivo imputable de los propietarios poseedores de la finca, el pago de consumo se exigirá duplicando las cantidades que resulten de calcular el pago conforme a las circunstancias señaladas antes, así como la respectiva multa que establece el artículo 164 de la ley de agua y alcantarillado para el estado de hidalgo.

            DÉCIMA PRIMERA. - La lectura de los medidores se hará por periodos mensuales.

            DÉCIMA SEGUNDA. - {“EL USUARIO”} se hará responsable del medidor que se instale en la toma, para la verificación del consumo, lo que afín de evitarse responsabilidades, deben protegerlos contra robo, manipulación o cualquier clase de deterioro.

            DÉCIMA TERCERA. - {“EL USUARIO”} se obligará a permitir que el personal autorizado por {“CAYSA”}, pueda efectuar las lecturas correspondientes y las reparaciones que fueran necesarias, lo cual se notificará en cada caso.

            DÉCIMA CUARTA. - En el caso de que {“EL USUARIO”} no este conforme a la lectura del medidor, podrá presentar ante {“CAYSA”} su inconformidad por escrito o presentarse en las oficinas para informar su inconformidad.

            {“CAYSA”} ordenará la inspección del medidor y resolverá conformando o ratificando la lectura objetada, la verificación del aparato podrá revisarse ante la presencia de {“EL USUARIO”} si este así lo desease para cuyo efecto {“CAYSA”} le notificará anticipadamente la fecha en que esta se realizará.

            DÉCIMA QUINTA. - En caso de que {“EL USUARIO”} tenga que ejecutar obras de construcción o reconstrucción del edificio. Desocupando el inmueble deberá solicitar la suspensión de la toma una vez que obtenga de las autoridades sanitarias la constancia correspondiente de la desocupación.

            DÉCIMA SEXTA. - {“CAYSA”}, En los casos que reciba el aviso que se refiere al párrafo anterior, ordenará el corte del servicio y mandara suspender los cargos de la cuenta correspondiente.  

            DÉCIMA SÉPTIMA. - {“CAYSA”}, Tendrá derecho de todo tipo a suspender el servicio temporalmente para hacer reparaciones o para cualquier otro objeto indispensable al servicio general, procurando en todo caso que estas suspensiones sean lo más corto posible. Si la suspensión es larga se prevendrá al público con avisos oportunos por la prensa, radio u otros medios.

            DÉCIMA OCTAVA. - {“EL USUARIO”} se compromete a no retirar o modificar la instalación de medidor, únicamente permitirá que el mismo sea revisado, operado o retirado por el personal oficial que se designe, {“CAYSA”} comprometiéndose a cubrir y responder de los daños y perjuicios que a dichos objeto se ocasione por personas extrañas al servicio.

            DÉCIMA NOVENA. - En caso de traspaso o rentas de fincas en donde se encuentren conectados los servicios a que este contrato se refiere {“EL USUARIO”} o propietario tiene la obligación de cubrir el adeudo que existe en su cuenta con {“CAYSA”} y deberá dar el aviso de baja correspondiente a efecto de que se de alta al nuevo propietario o se suspenda el servicio. En caso de no cumplir con el anterior requisito será responsabilidad solidaria y mancomunadamente con el dueño o usuario de los adeudos causados, así como los que se continúen causando.

            VIGÉSIMA. - {“EL USUARIO”} se da por enterado y reconoce que no podrá permitir y conceder derivaciones a las instalaciones del servicio de agua recibida a otro u otros edificios, predios, giros o establecimientos, así como de que, en caso de cumplir con las sanciones por dicho motivo, así para evitar la repetición de dichos actos.

            VIGÉSIMA PRIMERA.- RESTRICCIONES EN EL SUMINISTRO DEL AGUA- en este acto {“EL USUARIO”} queda notificado de las restricciones que existen para que se le suministre el agua potable a través de la red de distribución, por lo que {“EL USUARIO”} en este acto manifiesta su conformidad expresa con que el referido suministro, puede ser continuo o mediante el sistema de tandeo; en ambos casos, podrá ser con o sin horario o volumen determinados, pues ello dependerá de la disponibilidad del líquido que {“CAYSA”} tenga para la zona a que pertenezca el inmueble beneficiado. En todo caso, no se podrá dejar de suministrar el agua potable por más de setenta y dos horas continuas.

            VIGÉSIMA SEGUNDA.- Cuando se rebase el término de servicio en forma regular (continuo o tandeo) a que se refiere el párrafo anterior, {“CAYSA”} procederá al suministro de agua potable por medio de carros cisterna, en la medida que lo permita el acceso al inmueble, en tal caso {“LAS PARTES”} convienen en que {“EL USUARIO”} deberá estar al corriente en su pago, firmar la constancia de entrega que le sea presentada al momento de proporcionarle el agua y en caso de no localizar a nadie en el domicilio el agua no podrá ser entregada y deberá esperar al siguiente reparto o pagar por el servicio de pipa. 

            VIGÉSIMA TERCERA. - VIGENCIA- el presente contrato surte efectos a partir de la firma del mismo y estará vigente por tiempo indefinido o hasta en tanto se declare procedente una o más de las causas de rescisión o terminación que se establecen en las cláusulas siguientes.

            VIGÉSIMA CUARTA. - CAUSAS DE RESCISIÓN- {“LAS PARTES”} convienen en señalar como causas de rescisión del presente contrato, las siguientes:

            a)	La falta de pago de las cuotas o tarifas correspondientes, por seis dos meses consecutivos o más;
            b)	La falta de suministro de cualquiera de los servicios públicos objeto del presente contrato, por más de seis meses consecutivos; 
            c)	El incumplimiento de cualquiera otra de las obligaciones estipuladas en el presente contrato; y
            d)	Cuando la documentación o datos proporcionados por {“EL USUARIO”}, sea falsa o apócrifa.

            VIGÉSIMA QUINTA. - MEDIDORES- {“LAS PARTES”} convienen en que el o los medidores que se instalen son propiedad de {“CAYSA”} quien en todo momento tiene la facultad para determinar las características y especificaciones técnicas de estos aparatos, constituyéndose para los efectos de este contrato como el único proveedor de los mismos a los usuarios de los servicios públicos que presta. 

            Por lo que, a partir de la instalación, {“EL USUARIO”} se constituye en comodatario del o los aparatos medidores para los efectos de los artículos 115 y 155 de la Ley Estatal de Agua y Alcantarillado, obligándose a:

            I)	No modificar la ubicación del o los medidores instalados; y para el caso de que así lo requiriera, deberá solicitar autorización a {“CAYSA”}, mediante escrito en el cual justifique las causas del cambio.
            II)	Que la ubicación del aparato medidor sea en un lugar visible, donde el personal del prestador del servicio pueda tomar la lectura del aparato medidor, realizar las pruebas de funcionamiento y, en su caso, la suspensión del servicio, sin necesidad de introducirse al predio.
            III)	No dañar, alterar o modificar las partes que conforman el aparato medidor, con independencia de que dichas modificaciones tengan o no por objeto alterar el buen funcionamiento del mismo.
            IV)	Mantener el medidor en buen estado de conservación y funcionamiento.
            V)	Dar aviso inmediatamente a {“CAYSA”} de cualquier circunstancia que afecte la conservación o funcionamiento del medidor.
            VI)	Permitir la práctica de inspecciones y verificaciones que ordene {“CAYSA”}; y en su caso.
            VII)	Permitir la reposición del medidor, y en los casos en que proceda, pagar los costos generados con motivo de toda acción relacionada con el medidor.
            VIII)	Una vez concluido el presente contrato, el medidor será retirado por {“CAYSA”} y lo dará de baja en el sistema de control de {“CAYSA”}

            VIGÉSIMA SEXTA.- INFRACCIONES Y SANCIONES- {“EL USUARIO”} manifiesta expresamente que es conocedor de las causas de infracción; así como de las multas y demás sanciones administrativas, previstas por la Ley Estatal de Agua y Alcantarillado y su Reglamento; por lo que se obliga a no incurrir en actos u omisiones, tales como: retirar, variar, permitir desperfectos o dañar al aparato medidor; violar precintos; reconectar el o los servicios; no solicitar oportunamente la instalación del o los servicios; obtener clandestinamente el o los servicios; dar al agua, un uso diverso al contratado; desperdiciar el agua; emplear mecanismos para succionar agua de las tuberías de distribución; descargar en forma permanente o fortuita aguas residuales en contravención a lo dispuesto por la Ley; explotar, usar o aprovechar aguas residuales sin cumplir con la norma oficial; y las demás previstas por la legislación y normatividad aplicables.

            VIGÉSIMA SÉPTIMA.- CAMBIO EN EL USO O DESTINO DEL AGUA Y CAMBIO DE NOMBRE DEL TITULAR- {“EL USUARIO”} se obliga a que previamente al cambio en el uso o destino que dará al agua que se le suministre a virtud del presente contrato, deberá obtener el consentimiento escrito por parte de {“CAYSA”}, obligándose al pago de las cuotas y tarifas que procedan y de las que correspondan al nuevo uso solicitado, a partir de la autorización, en su caso; en el entendido de que el importe pagado por los conceptos de estudios de factibilidad u otros derechos, no serán recuperables en ninguna forma por {“EL USUARIO”}, aun cuando la resolución para el cambio de uso no le fuera favorable.

            En el supuesto de que {“EL USUARIO”} cambie el uso o destino del agua, sin obtener el consentimiento previo por parte de {“CAYSA”}, ésta tendrá derecho a:

            I)	Cobrar las cantidades que correspondan, por concepto de estudios de factibilidad y por concepto de conexión;
            II)	Cobrar las diferencias que existan entre la tarifa originalmente contratada y la aplicación de la tarifa correspondiente al uso actual del agua;
            III)Cobrar y ejecutar las multas y sanciones que procedan; y
            IV)	Cuando la factibilidad para el nuevo uso del agua, no sea favorable, rescindir el presente contrato, sin necesidad de acudir ante los tribunales y sin ninguna responsabilidad para {“CAYSA”}.
            Cuando por transmisión de la propiedad o posesión del inmueble, se solicite un cambio de nombre en la titularidad de este contrato, se hará el trámite administrativo, previo el pago de los derechos correspondientes, sin necesidad de suscribir un nuevo contrato, sino que el nuevo titular quedará automáticamente subrogado en los derechos y obligaciones que el titular anterior tenía, derivados de este instrumento; bastando que el cambio correspondiente se registre electrónicamente en el padrón de usuarios; como prueba suficiente.

            VIGÉSIMA OCTAVA. - USO RESPONSABLE DEL AGUA- Para lograr un uso responsable, racional y eficiente del agua, {“EL USUARIO”} se obliga frente a {“CAYSA”} a:

            I)	Conservar sus instalaciones hidráulicas intradomiciliarias en buenas condiciones, para evitar fugas;
            II)	Conectar a sus instalaciones hidráulicas llaves de cierre automático o aditamentos economizadores de agua, pagando el costo de los mismos; y
            III)	Evitar, por cualquier medio a su alcance, el gasto innecesario y/o el desperdicio del agua.

            Lo anterior sin perjuicio de las demás obligaciones que tiene conforme a lo dispuesto por la legislación aplicable. 

            La violación a lo dispuesto en la presente cláusula es causa de rescisión del contrato, sin necesidad de acudir previamente a los tribunales.

            VIGÉSIMA NOVENA. - SUSPENSIÓN DE LOS SERVICIOS- {“LAS PARTES”} convienen, en que la falta de pago en dos ocasiones consecutivas por parte de {“EL USUARIO”} faculta a {“CAYSA”} a suspender los servicios públicos objeto de este contrato, hasta que regularice su pago. De no regularizarse {“EL USUARIO”} en el término de 30 treinta días naturales, se procederá a la suspensión desde las redes de distribución. Igualmente procederá la suspensión de los servicios, cuando se detecten derivaciones no autorizadas, uso distinto al contratado, se reinstale el servicio violando sellos, o se proporcione servicio de otra toma de agua a las tomas que se encuentren suspendidas; así como cuando {“EL USUARIO”} no haya presentado la documentación requerida en los términos que {“CAYSA”} señale.

            Lo anterior, sin perjuicio de proceder a fijar las multas que procedan.

            {“LAS PARTES”} convienen en que únicamente se podrá considerar regularizada la situación en caso de que se pague el importe total adeudado, o bien se suscriba un convenio de pago en parcialidades, conforme a los lineamientos que para tal efecto establezca {“CAYSA”}. En este último supuesto, {“LAS PARTES”} están de acuerdo en que el atraso en el pago de 1 (una) o más parcialidades, da derecho a {“CAYSA”} a suspender los servicios inmediatamente. 

            {“CAYSA”}, podrá en todo caso, tomar libremente la decisión de suspender cualquiera de los servicios no pagados, o todos ellos a la vez, atendiendo a las particularidades del caso. 

            Cuando se determine suspender uno a uno los servicios no pagados, se preferirá iniciar con la suspensión del de suministro de agua; y al final con la suspensión del servicio de alcantarillado.

            Durante el tiempo que estén suspendidos los servicios, cuando dicha suspensión sea por causa imputable a {“EL USUARIO”}, {“CAYSA”} podrá continuar emitiendo los recibos y/o informativos de pago correspondientes, considerando la cuota mínima vigente, obligándose {“EL USUARIO”} a pagarlos.

            TRIGÉSIMA. - RECONEXIÓN- El costo por la reconexión de los servicios que se hubieran suspendido, correrá por cuenta de {“EL USUARIO”}, quién acepta que dicho costo se cobrara de conformidad con el tipo de corte que se haya realizado y con las tarifas autorizadas para tal efecto. 

            TRIGÉSIMA PRIMERA. - INSPECCIONES Y VERIFICACIONES- {“LAS PARTES”} convienen en que {“CAYSA”}, podrá llevar a cabo en todo tiempo y sin previo aviso, las inspecciones y verificaciones que resulten procedentes en los términos de la Ley Estatal de Agua y Alcantarillado y su Reglamento; quedando obligado {“EL USUARIO”} a brindar todas las facilidades requeridas para que lleven a cabo tales actos. Lo anteriormente expuesto debe de entenderse sin perjuicio de las facultades con que cuenten otras dependencias de la Administración Pública Federal, Estatal o Municipal. 

            TRIGÉSIMA SEGUNDA. - {“EL USUARIO”} autoriza expresamente a {“CAYSA”} para que cualquier adeudo que resulte de las obligaciones derivadas de este contrato, sean cargadas al o los recibos y/o informativos ordinarios de pago.

            TRIGÉSIMA TERCERA. - SUPLETORIEDAD- En todo lo no previsto en el presente contrato, {“LAS PARTES”} se someten a lo establecido en la Ley Estatal de Agua y Alcantarillado y su Reglamento.

            TRIGÉSIMA CUARTA. - MEDIOS ALTERNATIVOS DE SOLUCIÓN DE CONTROVERSIAS- En caso de inconformidad de {“EL USUARIO”} con cualquiera de los servicios objeto de este contrato, o con los cargos y cantidades a cobrar, u otras cuestiones derivadas de los mismos; {“LAS PARTES”} pactan como medios alternativos de solución a tales controversias, los siguientes, en ese orden de preferencia:

            a)	Convenio de pago en parcialidades;
            b)	Otorgamiento de beneficios contemplados en Programas Sociales, Institucionales u otros similares;
            c)	Promoción de recursos administrativos previstos en la Ley de la materia; y
            d)	Otras acciones a las que tenga derecho {“EL USUARIO”}. 

            TRIGÉSIMA QUINTA. - La Comisión de Agua y Saneamiento del Municipio de Ajacuba, Hgo., está obligada a suministrar el servicio de agua potable hasta el ingreso a su domicilio.

            TRIGÉSIMA SEXTA. - LEGISLACIÓN Y JURISDICCIÓN- Para todo lo relativo a la interpretación, cumplimiento y ejecución del presente contrato, {“LAS PARTES”} se someten a las leyes aplicables y a los tribunales competentes en la ciudad de Pachuca de Soto, Estado de Hidalgo.

            Leído que fue y debidamente enteradas {“LAS PARTES”} del alcance y contenido legal, lo firman en dos ejemplares, quedando un tanto en poder de cada una de las mismas, a los {DateTime.Now.Day} días del mes de {mesdehoy()} del año {DateTime.Now.Year}, en la ciudad de Ajacuba, Hidalgo.


            ", Font10))


                Col2CuerpoContrato2.Border = 0
                Col2CuerpoContrato2.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED
                TableCuerpoContrato.AddCell(Col2CuerpoContrato2)






                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                Dim TableFirmasContrato As PdfPTable = New PdfPTable(3)

                TableFirmasContrato.WidthPercentage = 100
                Dim widthsFirmas As Single() = New Single() {250.0F, 100.0F, 250.0F}
                TableFirmasContrato.SetWidths(widthsFirmas)



                Dim Col1Firmas = New PdfPCell(New Phrase($"C. {objetoModelo.Nombre.ToUpper()}{vbCrLf}{vbCrLf}USUARIO DE {funcionesbasicas.Empresa}", Font9))
                Col1Firmas.Border = 0
                Col1Firmas.HorizontalAlignment = PdfPCell.ALIGN_CENTER

                TableFirmasContrato.AddCell(Col1Firmas)


                Col1Firmas = New PdfPCell(New Phrase(" ", Font9))
                Col1Firmas.Border = 0
                Col1Firmas.HorizontalAlignment = PdfPCell.ALIGN_RIGHT

                TableFirmasContrato.AddCell(Col1Firmas)


                Col1Firmas = New PdfPCell(New Phrase($"{funcionesbasicas.DirectorOrganismo}{vbCrLf}{vbCrLf}DIRECTOR GENERAL DE LA {funcionesbasicas.Empresa}", Font9))
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




                Dim Col1Firmas2 = New PdfPCell(New Phrase(funcionesbasicas.DirectorOrganismo, Font9))
                Col1Firmas2.Border = 1
                Col1Firmas2.HorizontalAlignment = PdfPCell.ALIGN_CENTER

                TableFirmasContrato.AddCell(Col1Firmas2)


                Col1Firmas = New PdfPCell(New Phrase(" ", Font9))
                Col1Firmas.Border = 0
                Col1Firmas.HorizontalAlignment = PdfPCell.ALIGN_RIGHT

                TableFirmasContrato.AddCell(Col1Firmas)


                Col1Firmas2 = New PdfPCell(New Phrase(objetoModelo.Nombre, Font9))
                Col1Firmas2.Border = 1
                Col1Firmas2.HorizontalAlignment = PdfPCell.ALIGN_CENTER

                TableFirmasContrato.AddCell(Col1Firmas2)





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


                Dim datosPDF As Byte() = ms.ToArray()

                ' Guardar temporalmente para visualizar
                Dim rutaTemporal As String = Path.Combine(Path.GetTempPath(), $"ContratoAgua{objetoModelo.Cuenta}.pdf")
                File.WriteAllBytes(rutaTemporal, datosPDF)
                Process.Start(rutaTemporal)


                Return True

            Catch ex As Exception

                MessageBox.Show($"Ocurrio un error al crear el formato: {ex.ToString()}")

                Return False

            End Try

        End Using

    End Function

    Public Function GenerarContratoAlcantarilladoPDF(objetoModelo As UsuarioDTO) As Boolean Implements IFormatos(Of UsuarioDTO).GenerarContratoAlcantarilladoPDF

    End Function

    Public Function GenerarContratoAguaProvisionalPDF(objetoModelo As UsuarioDTO) As Boolean Implements IFormatos(Of UsuarioDTO).GenerarContratoAguaProvisionalPDF

    End Function

    Public Function GenerarCambioTarifaPDF(objetoModelo As UsuarioDTO) As Boolean Implements IFormatos(Of UsuarioDTO).GenerarCambioTarifaPDF

    End Function

    Public Function GenerarCambioMedidorPDF(objetoModelo As UsuarioDTO) As Boolean Implements IFormatos(Of UsuarioDTO).GenerarCambioMedidorPDF

    End Function

    Public Function GenerarCambioNombrePDF(objetoModelo As UsuarioDTO) As Boolean Implements IFormatos(Of UsuarioDTO).GenerarCambioNombrePDF
        Throw New NotImplementedException()
    End Function

    Public Function GenerarPrimeraNotificacionPDF(objetoModelo As UsuarioDTO) As Boolean Implements IFormatos(Of UsuarioDTO).GenerarPrimeraNotificacionPDF
        Throw New NotImplementedException()
    End Function

    Public Function GenerarSegundaNotificacionPDF(objetoModelo As UsuarioDTO) As Boolean Implements IFormatos(Of UsuarioDTO).GenerarSegundaNotificacionPDF
        Throw New NotImplementedException()
    End Function

    Public Function GenerarTerceraNotificacionPDF(objetoModelo As UsuarioDTO) As Boolean Implements IFormatos(Of UsuarioDTO).GenerarTerceraNotificacionPDF
        Throw New NotImplementedException()
    End Function

    Public Function GenerarNotificacionSuspensionPDF(objetoModelo As UsuarioDTO) As Boolean Implements IFormatos(Of UsuarioDTO).GenerarNotificacionSuspensionPDF
        Throw New NotImplementedException()
    End Function

    Public Function GenerarConstanciaNoAdeudoPDF(objetoModelo As UsuarioDTO) As Boolean Implements IFormatos(Of UsuarioDTO).GenerarConstanciaNoAdeudoPDF


        'Dim rutaArchivo As String = ""
        'Dim rutaDocumento As String = ""


        ' Creamos el MemoryStream para guardar el PDF en memoria
        Using ms As New MemoryStream()



            Try



                'Dar propiedades al Documento
                Dim pdfDoc As New Document(iTextSharp.text.PageSize.LETTER, 15.0F, 15.0F, 30.0F, 30.0F)



                'rutaArchivo = CrearCarpetaArchivos("ConstanciasNoAdeudo")




                'Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(rutaArchivo & "\ConstaciaNoAdeudo_" & objetoModelo.Cuenta & "_" & objetoModelo.Nombre & ".pdf", FileMode.Create))


                'rutaDocumento = $"{rutaArchivo}\ConstaciaNoAdeudo_{objetoModelo.Cuenta}_{objetoModelo.Nombre}.pdf"

                Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, ms)


                pdfDoc.Open()



                Dim TableEspacio As PdfPTable = New PdfPTable(1)
                Dim ColEsp As PdfPCell
                TableEspacio.WidthPercentage = 100
                Dim widthsTE As Single() = New Single() {1000.0F}
                TableEspacio.SetWidths(widthsTE)

                ColEsp = New PdfPCell(New Phrase(" ", Font7))
                ColEsp.Border = 0
                ColEsp.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableEspacio.AddCell(ColEsp)





                ' Agregar encabezado
                Dim encabezadoTable As New PdfPTable(3)
                encabezadoTable.WidthPercentage = 100
                encabezadoTable.SetWidths(New Single() {15, 70, 15})

                ' Logo
                If funcionesbasicas.LOGOBYTE IsNot Nothing AndAlso funcionesbasicas.LOGOBYTE.Length > 0 Then
                    Dim logo As Image = Image.GetInstance(funcionesbasicas.LOGOBYTE)
                    logo.ScaleToFit(70, 50)
                    Dim logoCell As New PdfPCell(logo, False)
                    logoCell.Border = Rectangle.NO_BORDER
                    logoCell.HorizontalAlignment = Element.ALIGN_CENTER
                    encabezadoTable.AddCell(logoCell)
                Else
                    encabezadoTable.AddCell(New PdfPCell(New Phrase("", Font7)) With {.Border = Rectangle.NO_BORDER})
                End If


                ' Título de la empresa
                Dim empresaInfo As New Paragraph()
                empresaInfo.Add(New Chunk(funcionesbasicas.Empresa & vbLf, Font13Bold))
                empresaInfo.Add(New Chunk($"{funcionesbasicas.Direccion}, {funcionesbasicas.coloniaEMPRESA}, {funcionesbasicas.Estadoempresa}, {funcionesbasicas.cpEmpresa}" & vbLf, Font10))
                empresaInfo.Add(New Chunk($"{funcionesbasicas.RFCORGANISMO}" & vbLf, Font9))
                empresaInfo.Add(New Chunk($"TEL. {funcionesbasicas.telefonoOrganismo}" & vbLf, Font7))
                encabezadoTable.AddCell(New PdfPCell(empresaInfo) With {
                    .HorizontalAlignment = Element.ALIGN_CENTER,
                    .Border = Rectangle.NO_BORDER
                })


                'Logo 2

                If funcionesbasicas.LOGOBYTE2 IsNot Nothing AndAlso funcionesbasicas.LOGOBYTE2.Length > 0 Then
                    Dim logo As Image = Image.GetInstance(funcionesbasicas.LOGOBYTE2)
                    logo.ScaleToFit(70, 50)
                    Dim logoCell As New PdfPCell(logo, False)
                    logoCell.Border = Rectangle.NO_BORDER
                    logoCell.HorizontalAlignment = Element.ALIGN_CENTER
                    encabezadoTable.AddCell(logoCell)
                Else
                    encabezadoTable.AddCell(New PdfPCell(New Phrase("", Font7)) With {.Border = Rectangle.NO_BORDER})
                End If



                pdfDoc.Add(encabezadoTable)




                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



                Dim TableTitulo As PdfPTable = New PdfPTable(1)
                TableTitulo.DefaultCell.Border = BorderStyle.None

                'Dim ILine As Integer
                'Dim iFila As Integer
                TableTitulo.WidthPercentage = 100

                Dim widthsTabTitulo As Single() = New Single() {900.0F}
                TableTitulo.SetWidths(widthsTabTitulo)



                'Dim DIRECCIONE As String = Direccion & " " & coloniaEMPRESA & " " & poblacionEMPRESA & " " & Estadoempresa
                Dim Col1Titulo = New PdfPCell(New Phrase("CONSTANCIA DE NO ADEUDO", Font12Bold))
                Col1Titulo.Border = 0
                Col1Titulo.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                TableTitulo.AddCell(Col1Titulo)




                Dim TableCuerpoContrato As PdfPTable = New PdfPTable(1)
                TableCuerpoContrato.DefaultCell.Border = BorderStyle.None
                TableCuerpoContrato.WidthPercentage = 100
                Dim widthsTabCuerpoContrato As Single() = New Single() {800.0F}
                TableCuerpoContrato.SetWidths(widthsTabCuerpoContrato)




                Dim Col1CuerpoContrato = New PdfPCell(New Phrase("A QUIEN CORRESPONDA", Font10Bold))

                Col1CuerpoContrato.Border = 0
                Col1CuerpoContrato.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED
                TableCuerpoContrato.AddCell(Col1CuerpoContrato)

                Col1CuerpoContrato = New PdfPCell(New Phrase(" ", Font12))
                Col1CuerpoContrato.Border = 0
                Col1CuerpoContrato.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                TableCuerpoContrato.AddCell(Col1CuerpoContrato)


                Col1CuerpoContrato = New PdfPCell(New Phrase(" ", Font12))
                Col1CuerpoContrato.Border = 0
                Col1CuerpoContrato.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                TableCuerpoContrato.AddCell(Col1CuerpoContrato)


                Col1CuerpoContrato = New PdfPCell(New Phrase(" ", Font12))
                Col1CuerpoContrato.Border = 0
                Col1CuerpoContrato.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                TableCuerpoContrato.AddCell(Col1CuerpoContrato)


                Col1CuerpoContrato = New PdfPCell(New Phrase(" ", Font12))
                Col1CuerpoContrato.Border = 0
                Col1CuerpoContrato.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                TableCuerpoContrato.AddCell(Col1CuerpoContrato)



                '& vbCrLf &  - dar salto de linea
                Dim fechaHoy As Date = Date.Now
                Dim fechaPeriodo As Date = fechaHoy.AddMonths(-1)



                Dim Col1CuerpoContrato2 = New PdfPCell(New Phrase($"Por este conducto se hace constar que el servicio de agua potable ubicado en {objetoModelo.Domicilio}, {objetoModelo.Colonia}, {objetoModelo.Cp}, {objetoModelo.Estado} con clave de ubicacion {objetoModelo.Ubicacion} y con el numero de cuenta {objetoModelo.Cuenta} en cual se encuentra bajo el nombre de {objetoModelo.Nombre} el cual no presenta adeudo alguno al periodo de {mesActualDateString(fechaPeriodo).ToUpper} {fechaPeriodo.Year} para con {funcionesbasicas.Empresa}.{vbCrLf}Por tal motivo y para los fines que al (la) interesado (a) convengan se extiende la presente CONSTANCIA DE NO ADEUDO en la ciudad de {funcionesbasicas.poblacionEMPRESA}, estado de {funcionesbasicas.Estadoempresa}, a {DateTime.Now.Day} dias del mes de {mesdehoy()} del año {DateTime.Now.Year}", Font12))


                Col1CuerpoContrato2.Border = 0
                Col1CuerpoContrato2.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED
                TableCuerpoContrato.AddCell(Col1CuerpoContrato2)






                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                Dim TableFirmasContrato As PdfPTable = New PdfPTable(3)

                TableFirmasContrato.WidthPercentage = 100
                Dim widthsFirmas As Single() = New Single() {300.0F, 400.0F, 300.0F}
                TableFirmasContrato.SetWidths(widthsFirmas)



                Dim Col1Firmas = New PdfPCell(New Phrase("", Font9))
                Col1Firmas.Border = 0
                Col1Firmas.HorizontalAlignment = PdfPCell.ALIGN_CENTER

                TableFirmasContrato.AddCell(Col1Firmas)


                Col1Firmas = New PdfPCell(New Phrase($"POR LA '’{funcionesbasicas.siglas}’’", Font9Bold))
                Col1Firmas.Border = 0
                Col1Firmas.HorizontalAlignment = PdfPCell.ALIGN_CENTER

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




                Dim Col1Firmas2 = New PdfPCell(New Phrase("", Font9))
                Col1Firmas2.Border = 0
                Col1Firmas2.HorizontalAlignment = PdfPCell.ALIGN_CENTER

                TableFirmasContrato.AddCell(Col1Firmas2)


                Col1Firmas = New PdfPCell(New Phrase($"{funcionesbasicas.DirectorOrganismo}", Font9Bold))
                Col1Firmas.Border = 1
                Col1Firmas.HorizontalAlignment = PdfPCell.ALIGN_CENTER

                TableFirmasContrato.AddCell(Col1Firmas)


                Col1Firmas2 = New PdfPCell(New Phrase("", Font9))
                Col1Firmas2.Border = 0
                Col1Firmas2.HorizontalAlignment = PdfPCell.ALIGN_CENTER

                TableFirmasContrato.AddCell(Col1Firmas2)



                'End Try



                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                pdfDoc.Add(TableEspacio)
                pdfDoc.Add(TableEspacio)
                pdfDoc.Add(TableTitulo)
                pdfDoc.Add(TableEspacio)
                pdfDoc.Add(TableEspacio)

                pdfDoc.Add(TableEspacio)
                pdfDoc.Add(TableEspacio)
                pdfDoc.Add(TableCuerpoContrato)
                pdfDoc.Add(TableEspacio)
                pdfDoc.Add(TableEspacio)
                pdfDoc.Add(TableEspacio)
                pdfDoc.Add(TableEspacio)
                pdfDoc.Add(TableEspacio)
                pdfDoc.Add(TableEspacio)
                pdfDoc.Add(TableFirmasContrato)
                pdfDoc.Add(TableEspacio)
                pdfDoc.Add(TableEspacio)


                pdfDoc.Close()



                Dim datosPDF As Byte() = ms.ToArray()

                ' Guardar temporalmente para visualizar
                Dim rutaTemporal As String = Path.Combine(Path.GetTempPath(), $"ConstaciaNoAdeudo_Contrato{objetoModelo.Cuenta}.pdf")
                File.WriteAllBytes(rutaTemporal, datosPDF)
                Process.Start(rutaTemporal)


                Return True

            Catch ex As Exception

                MessageBox.Show("Ocurrio un error: " & ex.ToString())
                Return False

            End Try

        End Using


    End Function

    Public Function GenerarBajaTemporalPDF(objetoModelo As UsuarioDTO) As Boolean Implements IFormatos(Of UsuarioDTO).GenerarBajaTemporalPDF



        Dim motivoBaja As String = ""



        ' Creamos el MemoryStream para guardar el PDF en memoria
        Using ms As New MemoryStream()



            Try

                motivoBaja = obtenerCampo($"select Motivo from bajas where cuenta = {objetoModelo.Cuenta}", "Motivo")

                'Dar propiedades al Documento
                Dim pdfDoc As New Document(iTextSharp.text.PageSize.LETTER, 15.0F, 15.0F, 30.0F, 30.0F)



                'rutaArchivo = CrearCarpetaArchivos("BajTemporal")




                'Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(rutaArchivo & "\BajaTemporal_" & objetoModelo.Cuenta & "_" & objetoModelo.Nombre & ".pdf", FileMode.Create))
                Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, ms)



                'rutaDocumento = $"{rutaArchivo}\BajaTemporal_{objetoModelo.Cuenta}_{objetoModelo.Nombre}.pdf"



                pdfDoc.Open()



                Dim TableEspacio As PdfPTable = New PdfPTable(1)
                Dim ColEsp As PdfPCell
                TableEspacio.WidthPercentage = 100
                Dim widthsTE As Single() = New Single() {1000.0F}
                TableEspacio.SetWidths(widthsTE)

                ColEsp = New PdfPCell(New Phrase(" ", Font7))
                ColEsp.Border = 0
                ColEsp.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableEspacio.AddCell(ColEsp)





                ' Agregar encabezado
                Dim encabezadoTable As New PdfPTable(3)
                encabezadoTable.WidthPercentage = 100
                encabezadoTable.SetWidths(New Single() {15, 70, 15})

                ' Logo
                If funcionesbasicas.LOGOBYTE IsNot Nothing AndAlso funcionesbasicas.LOGOBYTE.Length > 0 Then
                    Dim logo As Image = Image.GetInstance(funcionesbasicas.LOGOBYTE)
                    logo.ScaleToFit(70, 50)
                    Dim logoCell As New PdfPCell(logo, False)
                    logoCell.Border = Rectangle.NO_BORDER
                    logoCell.HorizontalAlignment = Element.ALIGN_CENTER
                    encabezadoTable.AddCell(logoCell)
                Else
                    encabezadoTable.AddCell(New PdfPCell(New Phrase("", Font7)) With {.Border = Rectangle.NO_BORDER})
                End If


                ' Título de la empresa
                Dim empresaInfo As New Paragraph()
                empresaInfo.Add(New Chunk(funcionesbasicas.Empresa & vbLf, Font13Bold))
                empresaInfo.Add(New Chunk($"{funcionesbasicas.Direccion}, {funcionesbasicas.coloniaEMPRESA}, {funcionesbasicas.Estadoempresa}, {funcionesbasicas.cpEmpresa}" & vbLf, Font10))
                empresaInfo.Add(New Chunk($"{funcionesbasicas.RFCORGANISMO}" & vbLf, Font9))
                empresaInfo.Add(New Chunk($"TEL. {funcionesbasicas.telefonoOrganismo}" & vbLf, Font7))
                encabezadoTable.AddCell(New PdfPCell(empresaInfo) With {
                    .HorizontalAlignment = Element.ALIGN_CENTER,
                    .Border = Rectangle.NO_BORDER
                })


                'Logo 2

                If funcionesbasicas.LOGOBYTE2 IsNot Nothing AndAlso funcionesbasicas.LOGOBYTE2.Length > 0 Then
                    Dim logo As Image = Image.GetInstance(funcionesbasicas.LOGOBYTE2)
                    logo.ScaleToFit(70, 50)
                    Dim logoCell As New PdfPCell(logo, False)
                    logoCell.Border = Rectangle.NO_BORDER
                    logoCell.HorizontalAlignment = Element.ALIGN_CENTER
                    encabezadoTable.AddCell(logoCell)
                Else
                    encabezadoTable.AddCell(New PdfPCell(New Phrase("", Font7)) With {.Border = Rectangle.NO_BORDER})
                End If



                pdfDoc.Add(encabezadoTable)




                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



                Dim TableTitulo As PdfPTable = New PdfPTable(1)
                TableTitulo.DefaultCell.Border = BorderStyle.None

                'Dim ILine As Integer
                'Dim iFila As Integer
                TableTitulo.WidthPercentage = 100

                Dim widthsTabTitulo As Single() = New Single() {900.0F}
                TableTitulo.SetWidths(widthsTabTitulo)



                'Dim DIRECCIONE As String = Direccion & " " & coloniaEMPRESA & " " & poblacionEMPRESA & " " & Estadoempresa
                Dim Col1Titulo = New PdfPCell(New Phrase("SOLICITUD DE BAJA TEMPORAL", Font12Bold))
                Col1Titulo.Border = 0
                Col1Titulo.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                TableTitulo.AddCell(Col1Titulo)





                Dim TableDatosContrato As PdfPTable = New PdfPTable(6)

                Dim Col61 As PdfPCell
                Dim Col62 As PdfPCell
                Dim Col63 As PdfPCell
                Dim Col64 As PdfPCell

                TableDatosContrato.WidthPercentage = 100
                Dim widthsT6 As Single() = New Single() {40.0F, 30.0F, 30.0F, 100.0F, 30.0F, 50.0F}
                TableDatosContrato.SetWidths(widthsT6)

                Col61 = New PdfPCell(New Phrase("CONTRATO", Font9Bold))
                Col61.Border = 0
                Col61.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                'Col61.BackgroundColor = colordefinido.color
                TableDatosContrato.AddCell(Col61)

                Col62 = New PdfPCell(New Phrase(" ", Font9))
                Col62.Border = 0
                Col62.HorizontalAlignment = PdfPCell.ALIGN_CENTER

                TableDatosContrato.AddCell(Col62)

                Col63 = New PdfPCell(New Phrase("TIPO: ", Font9Bold))
                Col63.Border = 0
                Col63.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                'Col63.BackgroundColor = colordefinido.color
                TableDatosContrato.AddCell(Col63)

                Dim ColMi = New PdfPCell(New Phrase(objetoModelo.TipoUsu, Font9))
                ColMi.Border = 0
                ColMi.HorizontalAlignment = PdfPCell.ALIGN_LEFT

                TableDatosContrato.AddCell(ColMi)


                Col64 = New PdfPCell(New Phrase("FECHA: ", Font9Bold))
                Col64.Border = 0
                Col64.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                'Col64.BackgroundColor = colordefinido.color
                TableDatosContrato.AddCell(Col64)


                Col64 = New PdfPCell(New Phrase(Now.Day & " " & Now.Month & " " & Now.Year, Font9))
                Col64.Border = 0
                Col64.HorizontalAlignment = PdfPCell.ALIGN_LEFT

                TableDatosContrato.AddCell(Col64)





                Col61 = New PdfPCell(New Phrase("CUENTA: ", Font9Bold))
                Col61.Border = 0
                Col61.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                'Col61.BackgroundColor = colordefinido.color
                TableDatosContrato.AddCell(Col61)

                Col62 = New PdfPCell(New Phrase(objetoModelo.Cuenta, Font9))
                Col62.Border = 0
                Col62.HorizontalAlignment = PdfPCell.ALIGN_LEFT

                TableDatosContrato.AddCell(Col62)

                Col63 = New PdfPCell(New Phrase("GIRO: ", Font9Bold))
                Col63.Border = 0
                Col63.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                'Col63.BackgroundColor = colordefinido.color
                TableDatosContrato.AddCell(Col63)

                ColMi = New PdfPCell(New Phrase(objetoModelo.Giro, Font9))
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







                Dim TableCuerpoContrato As PdfPTable = New PdfPTable(1)
                TableCuerpoContrato.DefaultCell.Border = BorderStyle.None


                TableCuerpoContrato.WidthPercentage = 100

                Dim widthsTabCuerpoContrato As Single() = New Single() {800.0F}
                TableCuerpoContrato.SetWidths(widthsTabCuerpoContrato)




                Dim Col1CuerpoContrato = New PdfPCell(New Phrase($"El (la) C. {objetoModelo.Nombre} con domicilio para oír y recibir notificaciones en {objetoModelo.Domicilio}, COL. {objetoModelo.Colonia}, {objetoModelo.Comunidad}, MUNICIPIO DE {funcionesbasicas.poblacionEMPRESA}, {funcionesbasicas.Estadoempresa}.", Font12))

                Col1CuerpoContrato.Border = 0
                Col1CuerpoContrato.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED
                TableCuerpoContrato.AddCell(Col1CuerpoContrato)

                Col1CuerpoContrato = New PdfPCell(New Phrase(" ", Font12))
                Col1CuerpoContrato.Border = 0
                Col1CuerpoContrato.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                TableCuerpoContrato.AddCell(Col1CuerpoContrato)




                '& vbCrLf &  - dar salto de linea

                Dim Col1CuerpoContrato2 = New PdfPCell(New Phrase($"Solicita atentamente el servicio baja {objetoModelo.TipoUsu} de la conexión a la red de alcantarillado dé este Sistema de Agua Potable y Alcantarillado, en el domicilio citado al inicio de esta solicitud. 

", Font12))


                Col1CuerpoContrato2.Border = 0
                Col1CuerpoContrato2.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED
                TableCuerpoContrato.AddCell(Col1CuerpoContrato2)


                Dim Col1CuerpoContrato3 = New PdfPCell(New Phrase($"Por lo anterior, manifiesto mi conformidad por el siguiente motivo: 


‘’{motivoBaja}’’




    ", Font12))


                Col1CuerpoContrato3.Border = 0
                Col1CuerpoContrato3.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED
                TableCuerpoContrato.AddCell(Col1CuerpoContrato3)



                Dim Col2CuerpoContrato2 = New PdfPCell(New Phrase($"{funcionesbasicas.poblacionEMPRESA} a " & DateTime.Now.Day & " dias del mes de " & mesdehoy() & " del año " & DateTime.Now.Year & "
", Font12))


                Col2CuerpoContrato2.Border = 0
                Col2CuerpoContrato2.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                TableCuerpoContrato.AddCell(Col2CuerpoContrato2)






                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                Dim TableFirmasContrato As PdfPTable = New PdfPTable(3)

                TableFirmasContrato.WidthPercentage = 100
                Dim widthsFirmas As Single() = New Single() {250.0F, 100.0F, 250.0F}
                TableFirmasContrato.SetWidths(widthsFirmas)



                Dim Col1Firmas = New PdfPCell(New Phrase($"POR LA ‘’{funcionesbasicas.siglas}’’", Font9))
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




                Dim Col1Firmas2 = New PdfPCell(New Phrase($"{funcionesbasicas.DirectorOrganismo}", Font9))
                Col1Firmas2.Border = 1
                Col1Firmas2.HorizontalAlignment = PdfPCell.ALIGN_CENTER

                TableFirmasContrato.AddCell(Col1Firmas2)


                Col1Firmas = New PdfPCell(New Phrase(" ", Font9))
                Col1Firmas.Border = 0
                Col1Firmas.HorizontalAlignment = PdfPCell.ALIGN_RIGHT

                TableFirmasContrato.AddCell(Col1Firmas)


                Col1Firmas2 = New PdfPCell(New Phrase($"{objetoModelo.Nombre}", Font9))
                Col1Firmas2.Border = 1
                Col1Firmas2.HorizontalAlignment = PdfPCell.ALIGN_CENTER

                TableFirmasContrato.AddCell(Col1Firmas2)



                'End Try



                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                pdfDoc.Add(TableEspacio)
                pdfDoc.Add(TableEspacio)
                pdfDoc.Add(TableTitulo)
                pdfDoc.Add(TableEspacio)
                pdfDoc.Add(TableEspacio)

                pdfDoc.Add(TableEspacio)
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


                pdfDoc.Close()


                ' PDF generado en el MemoryStream
                Dim datosPDF As Byte() = ms.ToArray()

                ' Guardar temporalmente para visualizar
                Dim rutaTemporal As String = Path.Combine(Path.GetTempPath(), $"BajaTemporal_Contrato{objetoModelo.Cuenta}.pdf")
                File.WriteAllBytes(rutaTemporal, datosPDF)
                Process.Start(rutaTemporal)


                Return True

            Catch ex As Exception

                MessageBox.Show("Ocurrio un error: " & ex.ToString())
                Return False

            End Try

        End Using

    End Function

    Public Function GenerarBajaDefinitivaPDF(objetoModelo As UsuarioDTO) As Boolean Implements IFormatos(Of UsuarioDTO).GenerarBajaDefinitivaPDF



        ' Creamos el MemoryStream para guardar el PDF en memoria
        Using ms As New MemoryStream()



            Try



                'Dar propiedades al Documento
                Dim pdfDoc As New Document(iTextSharp.text.PageSize.LETTER, 15.0F, 15.0F, 30.0F, 30.0F)



                'rutaArchivo = CrearCarpetaArchivos("BajTemporal")




                'Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(rutaArchivo & "\BajaTemporal_" & objetoModelo.Cuenta & "_" & objetoModelo.Nombre & ".pdf", FileMode.Create))
                Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, ms)



                'rutaDocumento = $"{rutaArchivo}\BajaTemporal_{objetoModelo.Cuenta}_{objetoModelo.Nombre}.pdf"



                pdfDoc.Open()



                Dim TableEspacio As PdfPTable = New PdfPTable(1)
                Dim ColEsp As PdfPCell
                TableEspacio.WidthPercentage = 100
                Dim widthsTE As Single() = New Single() {1000.0F}
                TableEspacio.SetWidths(widthsTE)

                ColEsp = New PdfPCell(New Phrase(" ", Font7))
                ColEsp.Border = 0
                ColEsp.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableEspacio.AddCell(ColEsp)





                ' Agregar encabezado
                Dim encabezadoTable As New PdfPTable(3)
                encabezadoTable.WidthPercentage = 100
                encabezadoTable.SetWidths(New Single() {15, 70, 15})

                ' Logo
                If funcionesbasicas.LOGOBYTE IsNot Nothing AndAlso funcionesbasicas.LOGOBYTE.Length > 0 Then
                    Dim logo As Image = Image.GetInstance(funcionesbasicas.LOGOBYTE)
                    logo.ScaleToFit(70, 50)
                    Dim logoCell As New PdfPCell(logo, False)
                    logoCell.Border = Rectangle.NO_BORDER
                    logoCell.HorizontalAlignment = Element.ALIGN_CENTER
                    encabezadoTable.AddCell(logoCell)
                Else
                    encabezadoTable.AddCell(New PdfPCell(New Phrase("", Font7)) With {.Border = Rectangle.NO_BORDER})
                End If


                ' Título de la empresa
                Dim empresaInfo As New Paragraph()
                empresaInfo.Add(New Chunk(funcionesbasicas.Empresa & vbLf, Font13Bold))
                empresaInfo.Add(New Chunk($"{funcionesbasicas.Direccion}, {funcionesbasicas.coloniaEMPRESA}, {funcionesbasicas.Estadoempresa}, {funcionesbasicas.cpEmpresa}" & vbLf, Font10))
                empresaInfo.Add(New Chunk($"{funcionesbasicas.RFCORGANISMO}" & vbLf, Font9))
                empresaInfo.Add(New Chunk($"TEL. {funcionesbasicas.telefonoOrganismo}" & vbLf, Font7))
                encabezadoTable.AddCell(New PdfPCell(empresaInfo) With {
                    .HorizontalAlignment = Element.ALIGN_CENTER,
                    .Border = Rectangle.NO_BORDER
                })


                'Logo 2

                If funcionesbasicas.LOGOBYTE2 IsNot Nothing AndAlso funcionesbasicas.LOGOBYTE2.Length > 0 Then
                    Dim logo As Image = Image.GetInstance(funcionesbasicas.LOGOBYTE2)
                    logo.ScaleToFit(70, 50)
                    Dim logoCell As New PdfPCell(logo, False)
                    logoCell.Border = Rectangle.NO_BORDER
                    logoCell.HorizontalAlignment = Element.ALIGN_CENTER
                    encabezadoTable.AddCell(logoCell)
                Else
                    encabezadoTable.AddCell(New PdfPCell(New Phrase("", Font7)) With {.Border = Rectangle.NO_BORDER})
                End If



                pdfDoc.Add(encabezadoTable)




                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



                Dim TableTitulo As PdfPTable = New PdfPTable(1)
                TableTitulo.DefaultCell.Border = BorderStyle.None

                'Dim ILine As Integer
                'Dim iFila As Integer
                TableTitulo.WidthPercentage = 100

                Dim widthsTabTitulo As Single() = New Single() {900.0F}
                TableTitulo.SetWidths(widthsTabTitulo)



                'Dim DIRECCIONE As String = Direccion & " " & coloniaEMPRESA & " " & poblacionEMPRESA & " " & Estadoempresa
                Dim Col1Titulo = New PdfPCell(New Phrase("SOLICITUD DE BAJA DEFINITIVA", Font12Bold))
                Col1Titulo.Border = 0
                Col1Titulo.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                TableTitulo.AddCell(Col1Titulo)





                Dim TableDatosContrato As PdfPTable = New PdfPTable(6)

                Dim Col61 As PdfPCell
                Dim Col62 As PdfPCell
                Dim Col63 As PdfPCell
                Dim Col64 As PdfPCell

                TableDatosContrato.WidthPercentage = 100
                Dim widthsT6 As Single() = New Single() {40.0F, 30.0F, 30.0F, 100.0F, 30.0F, 50.0F}
                TableDatosContrato.SetWidths(widthsT6)

                Col61 = New PdfPCell(New Phrase("CONTRATO", Font9Bold))
                Col61.Border = 0
                Col61.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                'Col61.BackgroundColor = colordefinido.color
                TableDatosContrato.AddCell(Col61)

                Col62 = New PdfPCell(New Phrase(" ", Font9))
                Col62.Border = 0
                Col62.HorizontalAlignment = PdfPCell.ALIGN_CENTER

                TableDatosContrato.AddCell(Col62)

                Col63 = New PdfPCell(New Phrase("TIPO: ", Font9Bold))
                Col63.Border = 0
                Col63.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                'Col63.BackgroundColor = colordefinido.color
                TableDatosContrato.AddCell(Col63)

                Dim ColMi = New PdfPCell(New Phrase(objetoModelo.TipoUsu, Font9))
                ColMi.Border = 0
                ColMi.HorizontalAlignment = PdfPCell.ALIGN_LEFT

                TableDatosContrato.AddCell(ColMi)


                Col64 = New PdfPCell(New Phrase("FECHA: ", Font9Bold))
                Col64.Border = 0
                Col64.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                'Col64.BackgroundColor = colordefinido.color
                TableDatosContrato.AddCell(Col64)


                Col64 = New PdfPCell(New Phrase(Now.Day & " " & Now.Month & " " & Now.Year, Font9))
                Col64.Border = 0
                Col64.HorizontalAlignment = PdfPCell.ALIGN_LEFT

                TableDatosContrato.AddCell(Col64)





                Col61 = New PdfPCell(New Phrase("CUENTA: ", Font9Bold))
                Col61.Border = 0
                Col61.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                'Col61.BackgroundColor = colordefinido.color
                TableDatosContrato.AddCell(Col61)

                Col62 = New PdfPCell(New Phrase(objetoModelo.Cuenta, Font9))
                Col62.Border = 0
                Col62.HorizontalAlignment = PdfPCell.ALIGN_LEFT

                TableDatosContrato.AddCell(Col62)

                Col63 = New PdfPCell(New Phrase("GIRO: ", Font9Bold))
                Col63.Border = 0
                Col63.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                'Col63.BackgroundColor = colordefinido.color
                TableDatosContrato.AddCell(Col63)

                ColMi = New PdfPCell(New Phrase(objetoModelo.Giro, Font9))
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







                Dim TableCuerpoContrato As PdfPTable = New PdfPTable(1)
                TableCuerpoContrato.DefaultCell.Border = BorderStyle.None


                TableCuerpoContrato.WidthPercentage = 100

                Dim widthsTabCuerpoContrato As Single() = New Single() {800.0F}
                TableCuerpoContrato.SetWidths(widthsTabCuerpoContrato)




                Dim Col1CuerpoContrato = New PdfPCell(New Phrase($"El (la) C. {objetoModelo.Nombre} con domicilio para oír y recibir notificaciones en {objetoModelo.Domicilio}, COL. {objetoModelo.Colonia}, {objetoModelo.Comunidad}, MUNICIPIO DE {funcionesbasicas.poblacionEMPRESA}, {funcionesbasicas.Estadoempresa}.", Font12))

                Col1CuerpoContrato.Border = 0
                Col1CuerpoContrato.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED
                TableCuerpoContrato.AddCell(Col1CuerpoContrato)

                Col1CuerpoContrato = New PdfPCell(New Phrase(" ", Font12))
                Col1CuerpoContrato.Border = 0
                Col1CuerpoContrato.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                TableCuerpoContrato.AddCell(Col1CuerpoContrato)




                '& vbCrLf &  - dar salto de linea

                Dim Col1CuerpoContrato2 = New PdfPCell(New Phrase($"Solicita atentamente el servicio baja {objetoModelo.TipoUsu} de la conexión a la red de alcantarillado dé este Sistema de Agua Potable y Alcantarillado, en el domicilio citado al inicio de esta solicitud. 

", Font12))


                Col1CuerpoContrato2.Border = 0
                Col1CuerpoContrato2.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED
                TableCuerpoContrato.AddCell(Col1CuerpoContrato2)


                Dim Col1CuerpoContrato3 = New PdfPCell(New Phrase($"Por lo anterior, manifiesto mi conformidad por el siguiente motivo: 







    ", Font12))


                Col1CuerpoContrato3.Border = 0
                Col1CuerpoContrato3.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED
                TableCuerpoContrato.AddCell(Col1CuerpoContrato3)



                Dim Col2CuerpoContrato2 = New PdfPCell(New Phrase($"{funcionesbasicas.poblacionEMPRESA} a " & DateTime.Now.Day & " dias del mes de " & mesdehoy() & " del año " & DateTime.Now.Year & "
", Font12))


                Col2CuerpoContrato2.Border = 0
                Col2CuerpoContrato2.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                TableCuerpoContrato.AddCell(Col2CuerpoContrato2)






                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                Dim TableFirmasContrato As PdfPTable = New PdfPTable(3)

                TableFirmasContrato.WidthPercentage = 100
                Dim widthsFirmas As Single() = New Single() {250.0F, 100.0F, 250.0F}
                TableFirmasContrato.SetWidths(widthsFirmas)



                Dim Col1Firmas = New PdfPCell(New Phrase($"POR LA ‘’{funcionesbasicas.siglas}’’", Font9))
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




                Dim Col1Firmas2 = New PdfPCell(New Phrase($"{funcionesbasicas.DirectorOrganismo}", Font9))
                Col1Firmas2.Border = 1
                Col1Firmas2.HorizontalAlignment = PdfPCell.ALIGN_CENTER

                TableFirmasContrato.AddCell(Col1Firmas2)


                Col1Firmas = New PdfPCell(New Phrase(" ", Font9))
                Col1Firmas.Border = 0
                Col1Firmas.HorizontalAlignment = PdfPCell.ALIGN_RIGHT

                TableFirmasContrato.AddCell(Col1Firmas)


                Col1Firmas2 = New PdfPCell(New Phrase($"{objetoModelo.Nombre}", Font9))
                Col1Firmas2.Border = 1
                Col1Firmas2.HorizontalAlignment = PdfPCell.ALIGN_CENTER

                TableFirmasContrato.AddCell(Col1Firmas2)



                'End Try



                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                pdfDoc.Add(TableEspacio)
                pdfDoc.Add(TableEspacio)
                pdfDoc.Add(TableTitulo)
                pdfDoc.Add(TableEspacio)
                pdfDoc.Add(TableEspacio)

                pdfDoc.Add(TableEspacio)
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


                pdfDoc.Close()


                ' Aquí ya tienes el PDF generado en el MemoryStream
                Dim datosPDF As Byte() = ms.ToArray()

                ' OPCIÓN 1: Guardar temporalmente para visualizar (si es necesario)
                Dim rutaTemporal As String = Path.Combine(Path.GetTempPath(), $"BajaDefinitiva_Contrato{objetoModelo.Cuenta}.pdf")
                File.WriteAllBytes(rutaTemporal, datosPDF)
                Process.Start(rutaTemporal)


                Return True

            Catch ex As Exception

                MessageBox.Show("Ocurrio un error: " & ex.ToString())
                Return False

            End Try

        End Using

    End Function

    'Public Sub VisualizarPDF()

    '    Try
    '        ' Verificar si el archivo existe
    '        If File.Exists(rutaArchivoGenerado) Then
    '            Dim proceso As New Process()
    '            proceso.StartInfo.FileName = rutaArchivoGenerado
    '            proceso.StartInfo.UseShellExecute = True
    '            proceso.Start()
    '        Else
    '            MessageBox.Show("El archivo PDF no se encontró en la ruta especificada.", "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show($"Error al abrir el archivo PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

End Class
