Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class Reporte_ContratoAgua

    Public Sub GenerarContratoAgua(cuentaP As Double, formatoP As String, OBSERVACION As String)


        Dim datosOrganismo As IDataReader = ConsultaSql("select * from empresa").ExecuteReader
        datosOrganismo.Read()


        Dim datosUsuario As IDataReader = ConsultaSql($"select * from vusuario where cuenta = {cuentaP.ToString()}").ExecuteReader
        datosUsuario.Read()



        Dim cadenafolder As String = (Application.StartupPath & "\Contratos_Agua\" & Year(Now) & acompletacero(Month(Now).ToString(), 2)).Trim

        Dim cadenafolderDocAn As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Contratos_Agua\" & Year(Now) & acompletacero(Month(Now).ToString(), 2)).Trim



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





            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(cadenafolder & "\Contrato_" & datosUsuario("cuenta") & "_" & datosUsuario("nombre") & ".pdf", FileMode.Create))

            Dim pdfWrite3 As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(cadenafolderDocAn & "\Contrato_" & datosUsuario("cuenta") & "_" & datosUsuario("nombre") & ".pdf", FileMode.Create))





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
            Dim Col1Titulo = New PdfPCell(New Phrase("CONTRATO DE PRESTACIÓN DE SERVICIOS DE AGUA POTABLE", Font12))
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

            Col61 = New PdfPCell(New Phrase("CONTRATO", Font8))
            Col61.Border = 0
            Col61.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'Col61.BackgroundColor = colordefinido.color
            TableDatosContrato.AddCell(Col61)

            Col62 = New PdfPCell(New Phrase(" ", Font9))
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

            Try

                Col64 = New PdfPCell(New Phrase(datosUsuario("alta"), Font9))
                Col64.Border = 0
                Col64.HorizontalAlignment = PdfPCell.ALIGN_LEFT

                TableDatosContrato.AddCell(Col64)

            Catch ex As Exception
                Col64 = New PdfPCell(New Phrase(Now.ToShortDateString(), Font9))
                Col64.Border = 0
                Col64.HorizontalAlignment = PdfPCell.ALIGN_LEFT

                TableDatosContrato.AddCell(Col64)

            End Try





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




            Dim Col1CuerpoContrato = New PdfPCell(New Phrase("Contrato de prestación de servicios de agua que celebran por una parte el Sistema de Agua Potable, Alcantarillado y Saneamiento de MULEGÉ, Baja California Sur, representado por el C " & Director & " en su carácter de Administrador, a quién en lo sucesivo se le denominará "" EL SISTEMA "", y por otra parte el C.  " & datosUsuario("nombre") & " Quien en el cuerpo del presente se le denominará "" EL USUARIO ”", sometiéndose al tenor de las siguientes cláusulas:", Font12))

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

            Dim Col1CuerpoContrato2 = New PdfPCell(New Phrase($"


PRIMERA: EL SERVICIO SERÁ CONECTADO EN  {datosUsuario("Domicilio")} {datosUsuario("Comunidad")}, MPIO. DE MULEGÉ, BCS
 
SEGUNDA: EL USUARIO cubrirá enteramente los costos de material y mano de obra, de acuerdo con el presupuesto que derivado de la inspección física se realice para la instalación del servicio.

TERCERA: EL USUARIO pagará mensualmente los servicios que reciba, conforme a la cuota a base del medidor y en la clase de servicios anteriormente indicada con base en la tarifa que se encuentra aprobada y la que en lo futuro se establezca. EL USUARIO pagará los derechos correspondientes en la oficina de EL SISTEMA dentro de los diez días posteriores a la fecha en que se le haya notificado el importe del consumo correspondiente al mes inmediato anterior o de la fecha en que se le comunique el adeudo. 

CUARTA: La falta de pago puntual motivará el cobro de recargos de ley y en los casos en que EL SISTEMA lo estime conveniente, se suspenderá el servicio.

QUINTA: La falta de pago de las cuotas por servicio, a la fecha de vencimiento, por usuario comercial o industrial, faculta a EL SISTEMA para suspender los servicios públicos hasta que se regularice su pago. En los casos de uso doméstico, la falta de pago de dos meses consecutivos ocasionará la limitación del servicio, reduciéndolo al mínimo indispensable, lo anterior con base en el artículo 119 de la Ley de Aguas del Estado.

SEXTA: Mientras no se pueda instalar el aparato medidor, los derechos correspondientes se pagarán conforme a la cuota que le señale EL SISTEMA, tomando en consideración el consumo probable, pero en ningún caso podrá ser menor de la cuota mínima establecida por EL SISTEMA.
SEPTIMA: Cuando por cualquier causa, por desperfecto en el medidor, no pueda leerse el consumo efectivo, se cobrará promediando el pago de los tres meses inmediatos anteriores, o en caso de que la instalación fuera reciente y menor al término de los tres meses se cobrara conforme a la cuota mínima.

OCTAVA: En caso de que el consumo no se pueda efectuar por desperfecto en el aparato medidor causados intencionalmente o por motivos imputables a EL USUARIO el pago del consumo se exigirá duplicando la cantidad que resulte de calcular el pago conforme a las circunstancias señaladas antes, independientemente de que EL SISTEMA imponga las sanciones que proceden a cada caso, entre ellas el pago del importe de la reparación del aparato.

NOVENA: La lectura de los medidores se hará por periodos mensuales de 26 a 33 días.

DÉCIMA: EL USUARIO será responsable del medidor que se instale a su toma, la verificación del consumo, por la que a fin de evitarse responsabilidades debe protegerlo contra robo, manipulación y deterioro.

DÉCIMA PRIMERA: EL USUARIO se obliga a permitir que el personal autorizado pueda efectuar las lecturas correspondientes y las reparaciones que fueran necesarias.


", Font12))


            Col1CuerpoContrato2.Border = 0
            Col1CuerpoContrato2.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED
            TableCuerpoContrato.AddCell(Col1CuerpoContrato2)



            Dim Col2CuerpoContrato2 = New PdfPCell(New Phrase($"

DÉCIMA SEGUNDA: En caso de que EL USUARIO no esté conforme con la lectura del medidor, podrá presentar a EL SISTEMA su inconformidad por escrito o concurrir personalmente a sus oficinas para presentar su inconformidad, dentro del término no mayor a 30 días, en caso contrario la lectura se considera aceptada. Recibida la inconformidad, EL SISTEMA ordenará la inspección del medidor y resolverá confirmando o rectificando la lectura objetada.

DÉCIMA TERCERA: Cuando el aparato medidor instalado sufra daños o escape el agua, el usuario deberá reportarlo inmediatamente a EL SISTEMA para que se proceda a su reparación.

DÉCIMA CUARTA: EL USUARIO se compromete a no retirar, ni modificar la instalación del aparato medidor y únicamente permitirá que el mismo sea revisado, operado y retirado por el personal oficial designado al efecto, comprometiéndose a cubrir y responder por los daños y perjuicios que a dichos objetos se ocasionan por personas extrañas al servicio.

DÉCIMA QUINTA: Si llegara a ser interrumpido el servicio, materia de este contrato, por casos fortuitos o de fuerza mayor o por causas que no sean imputables, así como descomposturas de las máquinas y aparatos instalados, el presente contrato quedará en suspensión sin responsabilidad para ninguna de las partes. Los sellos que se coloquen en el equipo de medición, o a la llave de estrangulación, a las cajas de protección o cualquier otro artículo, no podrán ser movidos más que por personal que a efecto se designe por las autoridades competentes.

DÉCIMA SEXTA: En caso de traspaso o venta de las fincas donde se encuentren conectados los servicios a que este contrato se refiere, EL USUARIO o propietario tiene la obligación de cubrir el adeudo que exista en su cuenta con EL SISTEMA y deberá dar aviso de baja correspondiente a efecto de que se dé de alta al nuevo propietario o se suspenda el servicio. En caso de no cumplir con el anterior requisito, será responsable solidaria y mancomunadamente con el nuevo dueño o usuario de los adeudos causados, así como los que se continúen causando.

DÉCIMA SEPTIMA: EL USUARIO se da por enterado y reconoce que no podrá permitir ni conceder derivaciones de las instalaciones del servicio de agua que reciba a otro u otros predios giros o establecimientos, así como en caso de incurrir en algún acto de los anteriores citados, está conforme en aceptar y cumplir con las partes de las sanciones que se impongan por dicho motivo, así como evitar la repetición de dicho acto.

DÉCIMA OCTAVA: La responsabilidad de EL SISTEMA será precisamente en el punto de entrega del agua potable después del medidor en consecuencias, cualquier reclamación que surja de este punto en adelante, por ser la parte de la instalación perteneciente al medidor será exclusiva responsabilidad de EL USUARIO.

DÉCIMA NOVENA: EL SISTEMA se reserva la faculta de cuantificar el gasto individual de agua en las tomas del medidor, de la capacidad de sus instalaciones y de la cuantía integral de la demanda constituyéndose en árbitro exclusivo de la regulación de los caudales de acuerdo con las facturaciones de la relación producción demanda, facultada que EL USUARIO desde ahora reconoce y ofrece respetar las disposiciones que para el cumplimiento de estas cláusulas dicte EL SISTEMA.

VIGÉSIMA: EL SISTEMA tendrá derecho, sin restricción alguna de parte de EL USUARIO para instalar, extender, componer, cambiar o quitar la línea, equipo de medición, útiles de estrangulación y de más materiales necesarios para el servicio objeto de este contrato, que correspondan al SISTEMA y que se encuentren en el interior o exterior de los edificios o en los terrenos que utilicen los propios servicios.
	

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
End Class
