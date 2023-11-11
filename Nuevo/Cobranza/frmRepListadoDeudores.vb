Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.Odbc
Imports System.Data
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports OfficeOpenXml
Imports OfficeOpenXml.Style
Imports System.Globalization

Public Class frmRepListadoDeudores
    Dim filtro As String
    Public quees As String = "Listado de dedudores"
    Dim encabezado As String = ""


    Private Sub frmRepListadoDeudores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            llenarCombo(CmdRegion, "select id_region, region from region order by region")
        Catch ex As Exception

        End Try
        Try
            llenarCombo(cmbComunidades, "SELECT Id_comunidad,Comunidad FROM comunidades")
        Catch ex As Exception

        End Try

        Select Case quees
            Case "Listado de deudores"
                chkmasde3.Visible = True
            Case "Listado de corte"
                Me.Text = " Listado de corte "
                chkmasde3.Visible = False
        End Select
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click



        If My.Settings.CombodeCalles = "NO" Then
            filtro = "SELECT U.cuenta as Contrato,U.cuentaanterior, U.periodo as Periodo, U.nombre as Nombre, cuotas.Descripcion_Cuota as Tarifa,domicilio as Comunidad ,U.Deuda, descuentos.xdescrip as Descripcion_Cuota, U.manzana as Manzana, U.deualcant, U.DeudaSanea, U.iva ,if (estadotoma.mostrar=1,U.total,0) as total,U.recargos, U.deudaotros, U.consumo, U.LecturaAnt, U.PeriodosAdeudo as NumPeriodos, U.nodemedidor, estadotoma.descripcion as estado, deudafec as ultimopago, U.lote as Lote FROM (usuario U inner join comunidades on(U.id_Comunidad=comunidades.Id_comunidad) inner join cuotas on(cuotas.id_tarifa=U.TARIFA) inner join descuentos on(U.iddescuento=descuentos.iddescuento)) inner join estadotoma on (U.estado = estadotoma.Clave) where total>0 "
        Else
            filtro = "SELECT U.cuenta as Contrato,U.cuentaanterior, U.periodo as Periodo, cuotas.Descripcion_Cuota as Tarifa, U.nombre as Nombre, concat(calles.nombre,' ',u.numext,' ', u.numint) as Comunidad ,U.Deuda, U.manzana as Manzana, concat('Desc ',descuentos.npctdsct,' Tarifa: ',u.tarifa), U.deualcant, U.DeudaSanea, U.iva ,if (estadotoma.mostrar=1,U.total,0) as total,U.recargos, U.deudaotros, U.consumo, U.LecturaAnt, U.PeriodosAdeudo as NumPeriodos, U.nodemedidor, estadotoma.descripcion as estado, deudafec as ultimopago, U.lote as Lote FROM ((usuario U inner join comunidades on(U.id_Comunidad=comunidades.Id_comunidad) inner join cuotas on(cuotas.id_tarifa=U.TARIFA) inner join descuentos on(U.iddescuento=descuentos.iddescuento)) inner join estadotoma on (U.estado = estadotoma.Clave)) inner join calles on u.id_Calle =calles.id_calle where total>0"
        End If
        Try

            Select Case quees


                Case "Listado de deudores"
                    If My.Settings.CombodeCalles = "NO" Then
                        filtro = "SELECT U.cuenta as Contrato,U.cuentaanterior, cuotas.Descripcion_Cuota as Tarifa, U.periodo as Periodo, U.nombre as Nombre, domicilio as Comunidad ,U.Deuda, descuentos.xdescrip as Descripcion_Cuota, U.manzana as Manzana, U.deualcant, U.DeudaSanea, U.iva ,if (estadotoma.mostrar=1,U.total,0) as total,U.recargos, U.deudaotros, U.consumo, U.LecturaAnt, U.PeriodosAdeudo as NumPeriodos, U.nodemedidor, estadotoma.descripcion as estado, deudafec as ultimopago, U.lote as Lote FROM (usuario U inner join comunidades on(U.id_Comunidad=comunidades.Id_comunidad) inner join cuotas on(cuotas.id_tarifa=U.TARIFA) inner join descuentos on(u.iddescuento=descuentos.iddescuento)) inner join estadotoma on (u.estado = estadotoma.Clave) where total>0 "
                    Else
                        filtro = "SELECT U.cuenta as Contrato,U.cuentaanterior, cuotas.Descripcion_Cuota as Tarifa, U.periodo as Periodo, U.nombre as Nombre, concat(calles.nombre,' ',u.numext,' ', u.numint) as Comunidad ,U.Deuda, concat('Desc ',descuentos.npctdsct,' Tarifa: ',u.tarifa) as Descripcion_cuota, U.manzana as Manzana, U.deualcant, U.DeudaSanea, U.iva ,if (estadotoma.mostrar=1,U.total,0) as total,U.recargos, U.deudaotros, U.consumo, U.LecturaAnt, U.PeriodosAdeudo as NumPeriodos, U.nodemedidor, estadotoma.descripcion as estado, deudafec as ultimopago, U.lote as Lote FROM ((usuario U inner join comunidades on(U.id_Comunidad=comunidades.Id_comunidad) inner join cuotas on(cuotas.id_tarifa=U.TARIFA) inner join descuentos on(U.iddescuento=descuentos.iddescuento)) inner join estadotoma on (U.estado = estadotoma.Clave)) inner join calles on u.id_Calle =calles.id_calle where total>0"
                    End If


                    If chkmasde3.Checked Then
                        filtro += " and U.periodosAdeudo>=3 "
                    End If





                Case "Listado de deudores Nombre"
                    If My.Settings.CombodeCalles = "NO" Then
                        filtro = "SELECT U.cuenta as Contrato,U.cuentaanterior, cuotas.Descripcion_Cuota as Tarifa, U.manzana as Manzana, U.periodo as Periodo, U.nombre as Nombre, domicilio as Comunidad ,U.Deuda, descuentos.xdescrip as Descripcion_Cuota, U.deualcant, U.DeudaSanea, U.iva ,if (estadotoma.mostrar=1,U.total,0) as total,U.recargos, U.deudaotros, U.consumo, U.LecturaAnt, U.PeriodosAdeudo as NumPeriodos, U.nodemedidor, estadotoma.descripcion as estado, deudafec as ultimopago, U.lote as Lote FROM (usuario U inner join comunidades on(U.id_Comunidad=comunidades.Id_comunidad) inner join cuotas on(cuotas.id_tarifa=U.TARIFA) inner join descuentos on(u.iddescuento=descuentos.iddescuento)) inner join estadotoma on (u.estado = estadotoma.Clave) where total>0  "
                    Else
                        filtro = "SELECT U.cuenta as Contrato,U.cuentaanterior, cuotas.Descripcion_Cuota as Tarifa, U.manzana as Manzana,U.periodo as Periodo, U.nombre as Nombre, concat(calles.nombre,' ',u.numext,' ', u.numint) as Comunidad ,U.Deuda, concat('Desc ',descuentos.npctdsct,' Tarifa: ',u.tarifa) as Descripcion_cuota, U.deualcant, U.DeudaSanea, U.iva ,if (estadotoma.mostrar=1,U.total,0) as total,U.recargos, U.deudaotros, U.consumo, U.LecturaAnt, U.PeriodosAdeudo as NumPeriodos, U.nodemedidor, estadotoma.descripcion as estado, deudafec as ultimopago, U.lote as Lote FROM ((usuario U inner join comunidades on(U.id_Comunidad=comunidades.Id_comunidad) inner join cuotas on(cuotas.id_tarifa=U.TARIFA) inner join descuentos on(U.iddescuento=descuentos.iddescuento)) inner join estadotoma on (U.estado = estadotoma.Clave)) inner join calles on u.id_Calle =calles.id_calle where total>0 "
                    End If

                    If chkmasde3.Checked Then
                        filtro += " and U.periodosAdeudo>=3 "
                    End If



                Case "Listado de corte"
                    'filtro = "SELECT U.cuenta, U.nombre, domicilio as Comunidad ,U.Deuda, descuentos.xdescrip as Descripcion_Cuota, U.deualcant, U.DeudaSanea, U.iva ,if (estadotoma.mostrar=1,U.total,0) as total,U.recargos, U.deudaotros, U.consumo, U.LecturaAnt, U.PeriodosAdeudo, U.nodemedidor, estadotoma.descripcion as estado, deudafec as ultimopago FROM (usuario U inner join comunidades on(U.id_Comunidad=comunidades.Id_comunidad) inner join cuotas on(cuotas.id_tarifa=U.TARIFA) inner join descuentos on(u.iddescuento=descuentos.iddescuento)) inner join estadotoma on (u.estado = estadotoma.Clave) where total>0 and u.periodosAdeudo>=3"
                    Dim cadenafil As New StringBuilder
                    If My.Settings.CombodeCalles = "NO" Then
                        cadenafil.Append("SELECT U.cuenta as Contrato,U.cuentaanterior, U.periodo as Periodo, U.nombre as Nombre, domicilio as Comunidad ,U.Deuda, U.manzana as Manzana, cuotas.Descripcion_Cuota as Tarifa, U.deualcant, U.DeudaSanea, U.iva ,if (estadotoma.mostrar=1,U.total,0) as total,U.recargos, U.deudaotros, U.consumo, U.LecturaAnt, U.PeriodosAdeudo as NumPeriodos, U.nodemedidor, estadotoma.descripcion as estado, U.ufechapago as ultimopago, U.lote as Lote FROM ((usuario U inner join comunidades on(U.id_Comunidad=comunidades.Id_comunidad) inner join cuotas on(cuotas.id_tarifa=U.TARIFA) inner join descuentos on(U.iddescuento=descuentos.iddescuento)) inner join estadotoma on (U.estado = estadotoma.Clave))")
                    Else
                        cadenafil.Append("SELECT U.cuenta as Contrato,U.cuentaanterior, U.periodo as Periodo, U.nombre as Nombre, U.manzana as Manzana, concat(calles.nombre, "" "", u.numext, "" "", U.numint ) as Comunidad ,U.Deuda,  cuotas.Descripcion_Cuota as Tarifa, concat('Desc ',descuentos.npctdsct,' Tarifa: ',u.tarifa)  as Descripcion_Cuota, U.deualcant, U.DeudaSanea, U.iva ,if (estadotoma.mostrar=1,U.total,0) as total,U.recargos, U.deudaotros, U.consumo, U.LecturaAnt, U.PeriodosAdeudo as NumPeriodos, U.nodemedidor, estadotoma.descripcion as estado, U.ufechapago as ultimopago, U.lote as Lote FROM (((usuario U inner join comunidades on(U.id_Comunidad=comunidades.Id_comunidad) inner join cuotas on(cuotas.id_tarifa=U.TARIFA) inner join descuentos on(U.iddescuento=descuentos.iddescuento)) inner join estadotoma on (U.estado = estadotoma.Clave))) inner join calles on u.id_Calle=calles.id_calle")
                    End If


                    cadenafil.Append(" where U.total>0 and U.periodosAdeudo>=3 ")
                    filtro = cadenafil.ToString


            End Select



            If rbComunidad.Checked And cmbComunidades.Text <> "" Then
                filtro += " and Comunidad='" & cmbComunidades.Text & "'"
                encabezado = "COMUNIDAD: " & cmbComunidades.Text
            End If

            If rbComunidad.Checked And cmbComunidades.Text = "" Then
                MessageBox.Show("No seleccionaleste comunidad")
                Return
            End If

            If rbruta.Checked And CmdRegion.SelectedIndex > -1 And CmbRuta.SelectedIndex > -1 Then 'and 
                filtro += " and region='" & CmdRegion.SelectedValue & "' and ruta ='" & CmbRuta.SelectedValue & "'"
                encabezado = "REGION: " & CmdRegion.Text & " RUTA: " & CmbRuta.Text
            End If

            If rbruta.Checked And CmdRegion.SelectedIndex > -1 And CmbRuta.SelectedIndex = -1 Then 'and 
                filtro += " and region='" & CmdRegion.SelectedValue & "'"
            End If

            If rbruta.Checked And CmdRegion.SelectedIndex = -1 Then
                MessageBox.Show("No seleccionaste la region")
                Return
            End If

            'Dim reporte As New ReportDocument()
            'Dim DR As New dtsDatosReporte()
            'Dim DT As New DataTable()


            Select Case quees
                Case "Listado de deudores"
                    If My.Settings.CombodeCalles = "NO" Then
                        filtro += " order by U.Manzana, U.Lote, comunidad"
                    Else
                        filtro += " order by U.Manzana, U.Lote, comunidad"
                    End If

                Case "Listado de deudores Nombre"
                    filtro += " order by Nombre, U.Manzana, U.Lote"
                Case "Listado de corte"

                    If My.Settings.CombodeCalles = "NO" Then
                        filtro += " order by U.Manzana, U.Lote, comunidad"
                    Else
                        filtro += " order by U.Manzana, U.Lote ,concat(calles.nombre, "" "", u.numext, "" "", U.numint )"
                    End If
            End Select





            Select Case quees


                Case "Listado de deudores"


                    If RBPDF.Checked = True Then


                        If CBCarteraVencida.Checked = False Then

                            ReporteListadoDeudores(filtro, "Listado de Deudores")


                            chkmasde3.Visible = True



                        Else

                            ReporteCarteraVencida(filtro, "Cartera Vencida")

                        End If


                    ElseIf RBExcel.Checked = True Then

                        If CBCarteraVencida.Checked = False Then



                        Else

                            ReporteCarteraVencidaExcel(filtro, "Cartera Vencida")

                        End If

                    End If
                    'Reporte en ItextSharp





                Case "Listado de deudores Nombre"


                    If RBPDF.Checked = True Then

                        If CBCarteraVencida.Checked = False Then

                            ReporteListadoDeudores(filtro, "Listado de Deudores Nombre")

                            chkmasde3.Visible = True

                        Else

                            ReporteCarteraVencida(filtro, "Cartera Vencida")

                        End If

                    ElseIf RBExcel.Checked = True Then


                        If CBCarteraVencida.Checked = False Then



                        Else

                            ReporteCarteraVencidaExcel(filtro, "Cartera Vencida")

                        End If


                    End If








                Case "Listado de corte"

                    If RBPDF.Checked = True Then

                        If CBCarteraVencida.Checked = False Then

                            ReporteListadoDeudores(filtro, "Listado de Corte")

                            chkmasde3.Visible = False

                        Else

                            ReporteCarteraVencida(filtro, "Cartera Vencida")

                        End If

                    ElseIf RBExcel.Checked = True Then

                        If CBCarteraVencida.Checked = False Then



                        Else

                            ReporteCarteraVencidaExcel(filtro, "Cartera Vencida")

                        End If

                    End If





            End Select




            'reporte.SetDataSource(DR)

            'reporte.DataDefinition.FormulaFields("Encabezado").Text = "'" & encabezado & "'"

            'Dim x As New frmReporte()
            'x.crvReporte.ReportSource = reporte
            'x.Show()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function DatosReporte(ByVal sql As String) As DataTable
        Dim conn As OdbcConnection
        conn = New OdbcConnection(My.Settings.baseaguaConnectionString)
        Dim comando As OdbcCommand
        Dim Adapt As OdbcDataAdapter
        Dim DS As DataSet

        Try
            conn.Open()
            comando = New OdbcCommand(sql.ToLower(), conn)
            Adapt = New OdbcDataAdapter(comando)
            DS = New DataSet
            Adapt.Fill(DS, "Datos")
            conn.Dispose()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return DS.Tables(0)

    End Function

    Private Sub CmdRegion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdRegion.SelectedIndexChanged
        Try
            llenarCombo(CmbRuta, "select id_ruta, ruta from rutas where id_region='" & CmdRegion.SelectedValue & "' order by ruta")
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ReporteListadoDeudores(ByVal sql As String, ByVal caso As String)



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
            Dim directorioReporte As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\ListadoDeudores\").Trim
            If Not Directory.Exists(directorioReporte) Then
                Directory.CreateDirectory(directorioReporte)
            End If

            'Dar propiedades al Documento
            Dim pdfDoc As New Document(iTextSharp.text.PageSize.LETTER, 15.0F, 15.0F, 30.0F, 30.0F)


            'Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(cadenafolder & "\factura" & serie & factura & ".pdf", FileMode.Create))
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(directorioReporte & "\ListadoDeudores_" & Fecha & "_" & nuevaLetra & ".pdf", FileMode.Create))



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
            imagenBMP.ScaleToFit(80.0F, 70.0F)
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
            Dim widthsEnc2 As Single() = New Single() {100.0F, 500, 100.0F}
            TableEncabezado2.SetWidths(widthsEnc2)


            Dim ColEnc21 = New PdfPCell(New Phrase(caso, Font8))
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

            Dim ColRut1 = New PdfPCell(New Phrase(encabezado, Font8))
            ColRut1.Border = 0
            ColRut1.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableRuta.AddCell(ColRut1)

            ColRut1 = New PdfPCell(New Phrase(" ", Font8))
            ColRut1.Border = 0
            ColRut1.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableRuta.AddCell(ColRut1)

            'Tabla Datos Deudores
            Dim TableDatosDeu As PdfPTable = New PdfPTable(11)
            TableDatosDeu.DefaultCell.Border = BorderStyle.None
            TableDatosDeu.WidthPercentage = 100
            Dim widthsDatDeu As Single() = New Single() {55.0F, 100.0F, 100.0F, 25.0F, 30.0F, 70.0F, 70.0F, 70.0F, 30.0F, 80.0F, 80.0F}
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
            ColDireccion.Border = 3
            ColDireccion.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableDatosDeu.AddCell(ColDireccion)

            Dim ColMZ = New PdfPCell(New Phrase("MZ", Font8))
            ColMZ.Border = 3
            ColMZ.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableDatosDeu.AddCell(ColMZ)

            Dim ColLT = New PdfPCell(New Phrase("LT", Font8))
            ColLT.Border = 3
            ColLT.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableDatosDeu.AddCell(ColLT)

            Dim ColTarifa = New PdfPCell(New Phrase("Tarifa", Font8))
            ColTarifa.Border = 3
            ColTarifa.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableDatosDeu.AddCell(ColTarifa)

            Dim ColMedidor = New PdfPCell(New Phrase("Medidor", Font8))
            ColMedidor.Border = 3
            ColMedidor.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableDatosDeu.AddCell(ColMedidor)

            Dim ColPeriodo = New PdfPCell(New Phrase("Periodo", Font8))
            ColPeriodo.Border = 3
            ColPeriodo.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableDatosDeu.AddCell(ColPeriodo)

            Dim ColMeses = New PdfPCell(New Phrase("Mes.", Font8))
            ColMeses.Border = 3
            ColMeses.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableDatosDeu.AddCell(ColMeses)

            Dim ColTotal



            ColTotal = New PdfPCell(New Phrase(" ", Font8))
            ColTotal.Border = 3
            ColTotal.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableDatosDeu.AddCell(ColTotal)





            ColTotal = New PdfPCell(New Phrase("ULTIMA FECHA PAGO", Font8))
            ColTotal.Border = 3
            ColTotal.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableDatosDeu.AddCell(ColTotal)





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

                ColCuenta = New PdfPCell(New Phrase(datosDeudores("Contrato").ToString(), Font9G))
                ColCuenta.Border = 7
                ColCuenta.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                'ColCuenta.BackgroundColor = New iTextSharp.text.BaseColor(104, 104, 104)
                TableDatosDeu.AddCell(ColCuenta)

                ColNombre = New PdfPCell(New Phrase(datosDeudores("Nombre").ToString(), Font9))
                ColNombre.Border = 3
                ColNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosDeu.AddCell(ColNombre)

                ColDireccion = New PdfPCell(New Phrase(datosDeudores("Comunidad").ToString(), Font9))
                ColDireccion.Border = 3
                ColDireccion.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosDeu.AddCell(ColDireccion)

                ColMZ = New PdfPCell(New Phrase(datosDeudores("Manzana").ToString(), Font9))
                ColMZ.Border = 3
                ColMZ.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosDeu.AddCell(ColMZ)

                ColLT = New PdfPCell(New Phrase(datosDeudores("Lote").ToString(), Font9))
                ColLT.Border = 3
                ColLT.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosDeu.AddCell(ColLT)

                ColTarifa = New PdfPCell(New Phrase(datosDeudores("Tarifa").ToString(), Font9))
                ColTarifa.Border = 3
                ColTarifa.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosDeu.AddCell(ColTarifa)

                ColMedidor = New PdfPCell(New Phrase(datosDeudores("nodemedidor").ToString(), Font9))
                ColMedidor.Border = 3
                ColMedidor.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosDeu.AddCell(ColMedidor)

                ColPeriodo = New PdfPCell(New Phrase(datosDeudores("Periodo").ToString(), Font9))
                ColPeriodo.Border = 3
                ColPeriodo.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosDeu.AddCell(ColPeriodo)

                ColMeses = New PdfPCell(New Phrase(datosDeudores("NumPeriodos").ToString(), Font9))
                ColMeses.Border = 3
                ColMeses.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                TableDatosDeu.AddCell(ColMeses)



                ColTotal = New PdfPCell(New Phrase(" ", Font9))
                ColTotal.Border = 3
                ColTotal.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosDeu.AddCell(ColTotal)

                Dim ultimafechapago As String = String.Empty

                Try
                    ultimafechapago = obtenerCampo("select fecha_act from pagos where cuenta=" & datosDeudores("Contrato").ToString() & " order by fecha_Act desc limit 1", "fecha_act")
                    If ultimafechapago = "0" Then
                        ultimafechapago = "Sin pagos"
                    End If
                Catch ex As Exception

                End Try

                ColTotal = New PdfPCell(New Phrase(ultimafechapago, Font9))
                ColTotal.Border = 3
                ColTotal.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                TableDatosDeu.AddCell(ColTotal)




                'ColVac = New PdfPCell(New Phrase(" ", Font9))
                'ColVac.Border = 11
                'ColVac.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                'TableDatosDeu.AddCell(ColVac)

                CarteraVencida += datosDeudores("Total")
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



            Process.Start(directorioReporte & "\ListadoDeudores_" & Fecha & "_" & nuevaLetra & ".pdf")

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try


    End Sub


    Public Sub ReporteCarteraVencida(ByVal sql As String, ByVal caso As String)
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
            Dim directorioReporte As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\CarteraVencida\").Trim
            If Not Directory.Exists(directorioReporte) Then
                Directory.CreateDirectory(directorioReporte)
            End If

            'Dar propiedades al Documento
            Dim pdfDoc As New Document(iTextSharp.text.PageSize.LETTER, 15.0F, 15.0F, 30.0F, 30.0F)


            'Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(cadenafolder & "\factura" & serie & factura & ".pdf", FileMode.Create))
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(directorioReporte & "\CarteraVencida_" & Fecha & "_" & nuevaLetra & ".pdf", FileMode.Create))



            'Formato Letras

            Dim Font As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 6, iTextSharp.text.Font.NORMAL))
            Dim Font8N As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 6, iTextSharp.text.Font.BOLD))
            Dim Font88 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 13, iTextSharp.text.Font.BOLD))
            Dim Font8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD))
            Dim Font12 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.BOLD))
            Dim Font9 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 7, iTextSharp.text.Font.NORMAL))
            Dim Font9G As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 9, iTextSharp.text.Font.NORMAL))
            Dim Fontp As New Font(FontFactory.GetFont(FontFactory.COURIER, 7, iTextSharp.text.Font.BOLD))
            Dim CVacio As PdfPCell = New PdfPCell(New Phrase(""))
            CVacio.Border = 0

            'abrimos el pdf para comenzar a escribir en el, al terminar cerramos
            pdfDoc.Open()

            'Agregar Logo
            Dim imagenBMP As iTextSharp.text.Image
            imagenBMP = iTextSharp.text.Image.GetInstance(LOGOBYTE)
            imagenBMP.ScaleToFit(80.0F, 70.0F)
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
            Dim widthsEnc2 As Single() = New Single() {100.0F, 500, 100.0F}
            TableEncabezado2.SetWidths(widthsEnc2)


            Dim ColEnc21 = New PdfPCell(New Phrase(caso, Font8))
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

            Dim ColRut1 = New PdfPCell(New Phrase(encabezado, Font8))
            ColRut1.Border = 0
            ColRut1.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableRuta.AddCell(ColRut1)

            ColRut1 = New PdfPCell(New Phrase(" ", Font8))
            ColRut1.Border = 0
            ColRut1.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableRuta.AddCell(ColRut1)

            'Tabla Datos Deudores
            Dim TableDatosDeu As PdfPTable = New PdfPTable(11)
            TableDatosDeu.DefaultCell.Border = BorderStyle.None
            TableDatosDeu.WidthPercentage = 100
            Dim widthsDatDeu As Single() = New Single() {55.0F, 90.0F, 90.0F, 20.0F, 30.0F, 80.0F, 90.0F, 25.0F, 60.0F, 50.0F, 70.0F}
            TableDatosDeu.SetWidths(widthsDatDeu)

            Dim ColCuenta = New PdfPCell(New Phrase("Contrato", Font8))
            ColCuenta.Border = 7
            ColCuenta.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'ColCuenta.BackgroundColor = New iTextSharp.text.BaseColor(104, 104, 104)
            TableDatosDeu.AddCell(ColCuenta)

            Dim ColNombre = New PdfPCell(New Phrase("Nombre", Fontp))
            ColNombre.Border = 3
            ColNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableDatosDeu.AddCell(ColNombre)

            Dim ColDireccion = New PdfPCell(New Phrase("Dirección", Fontp))
            ColDireccion.Border = 3
            ColDireccion.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableDatosDeu.AddCell(ColDireccion)

            Dim ColMZ = New PdfPCell(New Phrase("MZ", Font8))
            ColMZ.Border = 3
            ColMZ.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableDatosDeu.AddCell(ColMZ)

            Dim ColLT = New PdfPCell(New Phrase("LT", Font8))
            ColLT.Border = 3
            ColLT.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableDatosDeu.AddCell(ColLT)

            Dim ColTarifa = New PdfPCell(New Phrase("Tarifa", Font8))
            ColTarifa.Border = 3
            ColTarifa.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableDatosDeu.AddCell(ColTarifa)

            Dim ColPeriodo = New PdfPCell(New Phrase("Periodo", Font8))
            ColPeriodo.Border = 3
            ColPeriodo.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableDatosDeu.AddCell(ColPeriodo)

            Dim ColMeses = New PdfPCell(New Phrase("Mes.", Font8))
            ColMeses.Border = 3
            ColMeses.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableDatosDeu.AddCell(ColMeses)


            Dim ColTotal = New PdfPCell(New Phrase("Total", Font8))
            ColTotal.Border = 3
            ColTotal.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableDatosDeu.AddCell(ColTotal)



            Dim ColVac = New PdfPCell(New Phrase(" ", Font8))
            ColVac.Border = 11
            ColVac.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableDatosDeu.AddCell(ColVac)

            Dim ColVac2 = New PdfPCell(New Phrase("ULTIMA FECHA PAGO", Font8))
            ColVac2.Border = 11
            ColVac2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableDatosDeu.AddCell(ColVac2)


            'Dim lista As New List(Of )(sql)

            'For Each item As String In lista
            '    Debug.Write(item & " ")
            'Next

            Dim NumReg As Int32 = 0
            Dim CarteraVencida As Decimal = 0


            While datosDeudores.Read()

                ColCuenta = New PdfPCell(New Phrase(datosDeudores("Contrato").ToString(), Font9G))
                ColCuenta.Border = 7
                ColCuenta.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                'ColCuenta.BackgroundColor = New iTextSharp.text.BaseColor(104, 104, 104)
                TableDatosDeu.AddCell(ColCuenta)

                ColNombre = New PdfPCell(New Phrase(datosDeudores("Nombre").ToString(), Font9))
                ColNombre.Border = 3
                ColNombre.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosDeu.AddCell(ColNombre)

                ColDireccion = New PdfPCell(New Phrase(datosDeudores("Comunidad").ToString(), Font9))
                ColDireccion.Border = 3
                ColDireccion.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosDeu.AddCell(ColDireccion)

                ColMZ = New PdfPCell(New Phrase(datosDeudores("Manzana").ToString(), Font9))
                ColMZ.Border = 3
                ColMZ.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosDeu.AddCell(ColMZ)

                ColLT = New PdfPCell(New Phrase(datosDeudores("Lote").ToString(), Font9))
                ColLT.Border = 3
                ColLT.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosDeu.AddCell(ColLT)

                ColTarifa = New PdfPCell(New Phrase(datosDeudores("Tarifa").ToString(), Font9))
                ColTarifa.Border = 3
                ColTarifa.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosDeu.AddCell(ColTarifa)

                ColPeriodo = New PdfPCell(New Phrase(datosDeudores("Periodo").ToString(), Font9))
                ColPeriodo.Border = 3
                ColPeriodo.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosDeu.AddCell(ColPeriodo)

                ColMeses = New PdfPCell(New Phrase(datosDeudores("NumPeriodos").ToString(), Font9))
                ColMeses.Border = 3
                ColMeses.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosDeu.AddCell(ColMeses)



                ColTotal = New PdfPCell(New Phrase("$" & datosDeudores("Total").ToString(), Font9))
                ColTotal.Border = 3
                ColTotal.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosDeu.AddCell(ColTotal)




                ColVac = New PdfPCell(New Phrase(" ", Font9))
                ColVac.Border = 11
                ColVac.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableDatosDeu.AddCell(ColVac)

                Dim ultimafechapago As String = String.Empty
                Try
                    ultimafechapago = obtenerCampo("select fecha_act from pagos where cuenta=" & datosDeudores("Contrato").ToString() & " order by fecha_Act desc limit 1", "fecha_act")
                    If ultimafechapago = "0" Then
                        ultimafechapago = "Sin pagos"
                    End If
                Catch ex As Exception

                End Try

                Dim ColFECH As New PdfPCell(New Phrase(ultimafechapago, Font9))
                ColFECH.Border = 3
                ColFECH.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                TableDatosDeu.AddCell(ColFECH)



                CarteraVencida += datosDeudores("Total")
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

            ColCont = New PdfPCell(New Phrase("Cartera Vencida: " & CarteraVencida.ToString("C"), Font8))
            ColCont.Border = 0
            ColCont.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableContador.AddCell(ColCont)


            pdfDoc.Add(TableEncabezadoTitulo)
            pdfDoc.Add(TableEncabezado2)
            pdfDoc.Add(TableRuta)
            pdfDoc.Add(TableDatosDeu)
            pdfDoc.Add(TableContador)

            pdfDoc.Close()



            Process.Start(directorioReporte & "\CarteraVencida_" & Fecha & "_" & nuevaLetra & ".pdf")

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub


    Public Sub ReporteCarteraVencidaExcel(ByVal sql As String, ByVal caso As String)

        Dim datosDeudores As IDataReader = ConsultaSql(sql).ExecuteReader()

        Dim Fecha As String
        Dim acumuladorTotal As Decimal = 0.0
        Dim contador As Integer = 0
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
        Dim directorioReporte As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\CarteraVencida\").Trim
        If Not Directory.Exists(directorioReporte) Then
            Directory.CreateDirectory(directorioReporte)
        End If


        Dim ruta As String = $"\\CarteraVencida\\CarteraVencida_{CmbRuta.Text}.xlsx"
        Dim pathReporte As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ruta).Trim()


        ExcelPackage.LicenseContext = LicenseContext.NonCommercial




        Using Ep As New ExcelPackage()


            Dim Sheet = Ep.Workbook.Worksheets.Add("CARTERA_VENCIDA")


            Dim rowCount As Integer = 1


            Dim nombreOrganismo As String = obtenerCampo($"select CNOMBRE from EMPRESA where CODEMP = 1", "CNOMBRE")
            'Sheet.Cells("A3").RichText.Add($"ORGANISMO: {nombreOrganismo}")

            Sheet.Cells("A1:I1").Style.Font.Size = 13
            Sheet.Cells("A1:I1").Style.Font.Name = "Calibri"
            Sheet.Cells("A1:I3").Style.Font.Bold = True
            Sheet.Cells("A1:I1").Style.Font.Color.SetColor(Color.DarkBlue)
            Sheet.Cells("A1:I1").Style.HorizontalAlignment = ExcelHorizontalAlignment.Left
            Sheet.Cells("A1").RichText.Add($"{nombreOrganismo.ToUpper()}")



            Sheet.Cells("A2:I3").Style.Font.Size = 12
            Sheet.Cells("A2:I3").Style.Font.Name = "Calibri"
            Sheet.Cells("A2:I3").Style.Font.Bold = True
            Sheet.Cells("A2:I3").Style.Font.Color.SetColor(Color.DarkBlue)
            Sheet.Cells("A2:I3").Style.HorizontalAlignment = ExcelHorizontalAlignment.Left
            Sheet.Cells("A2").RichText.Add($"REPORTE: {caso.ToUpper()}")



            Sheet.Cells("A4:I4").Style.Font.Size = 12
            Sheet.Cells("A4:I4").Style.Font.Name = "Calibri"
            Sheet.Cells("A4:I4").Style.Font.Bold = True
            Sheet.Cells("A4:I4").Style.Font.Color.SetColor(Color.DarkBlue)
            Sheet.Cells("A4:I4").Style.HorizontalAlignment = ExcelHorizontalAlignment.Left
            Sheet.Cells("A4").RichText.Add($"{encabezado.ToUpper()}")


            Try

                'ENCABEZADOS DEL DOCUMENTO
                rowCount = 6
                Sheet.Cells.Style.Font.Name = "Calibri"
                Sheet.Cells.Style.Font.Size = 10
                Sheet.Cells("A5:AT5").Style.Font.Bold = True
                Sheet.Cells("A5:AT5").Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
                Sheet.Cells("A5:AT5").Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray)


                Sheet.Cells("A5").RichText.Add("CONTRATO")
                Sheet.Cells("B5").RichText.Add("NOMBRE")
                Sheet.Cells("C5").RichText.Add("DIRECCIÓN")
                Sheet.Cells("D5").RichText.Add("MZ")
                Sheet.Cells("E5").RichText.Add("LT")
                Sheet.Cells("F5").RichText.Add("TARIFA")
                Sheet.Cells("G5").RichText.Add("PERIODO")
                Sheet.Cells("H5").RichText.Add("MES")
                Sheet.Cells("I5").RichText.Add("TOTAL")


                rowCount = 6


                While datosDeudores.Read()


                    Dim contrato As String = ""
                    Dim nombreUsuario As String = ""
                    Dim dirección As String = ""
                    Dim manzana As String = ""
                    Dim lote As String = ""
                    Dim tarifa As String = ""
                    Dim periodoAdeudo As String = ""
                    Dim numMeses As String = ""
                    Dim total As Decimal = 0.0


                    contrato = datosDeudores("CONTRATO")
                    nombreUsuario = datosDeudores("NOMBRE")
                    dirección = datosDeudores("COMUNIDAD")
                    manzana = datosDeudores("MANZANA")
                    lote = datosDeudores("LOTE")
                    tarifa = datosDeudores("TARIFA")
                    periodoAdeudo = datosDeudores("PERIODO")
                    numMeses = datosDeudores("NUMPERIODOS")
                    total = Decimal.Parse(datosDeudores("TOTAL"))


                    'Sheet.Cells(String.Format("A{0}", rowCount)).Style.Numberformat.Format = DateTimeFormatInfo.CurrentInfo.ShortDatePattern



                    Sheet.Cells(String.Format("A{0}", rowCount)).Value = contrato
                    Sheet.Cells(String.Format("B{0}", rowCount)).Value = nombreUsuario
                    Sheet.Cells(String.Format("C{0}", rowCount)).Value = dirección
                    Sheet.Cells(String.Format("D{0}", rowCount)).Value = manzana
                    Sheet.Cells(String.Format("E{0}", rowCount)).Value = lote
                    Sheet.Cells(String.Format("F{0}", rowCount)).Value = tarifa
                    Sheet.Cells(String.Format("G{0}", rowCount)).Value = periodoAdeudo
                    Sheet.Cells(String.Format("H{0}", rowCount)).Value = numMeses


                    Sheet.Cells(String.Format("I{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"

                    Sheet.Cells(String.Format("I{0}", rowCount)).Value = total


                    acumuladorTotal = acumuladorTotal + total
                    contador = contador + 1

                    rowCount = rowCount + 1

                End While

            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try

            rowCount = rowCount + 1


            'Sheet.Cells(String.Format("I{0}", rowCount)).Style.Numberformat.Format = "$#,##0.00"


            Sheet.Cells(String.Format("H{0}", rowCount)).Value = $"NUM. REGISTROS: {contador}"
            Sheet.Cells(String.Format("I{0}", rowCount)).Value = $"{acumuladorTotal.ToString("C")}"


            Sheet.Cells("A:I").AutoFitColumns()

            Ep.SaveAs(New FileInfo(pathReporte))

            MessageBox.Show("Datos exportados a Excel correctamente")


        End Using

    End Sub

End Class