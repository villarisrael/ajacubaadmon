Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class frmListOrd



    Dim ResultSQL As String


    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        cmdImp.Text = "IMPRIMIENDO..."
        cmdImp.Enabled = False
        ResultSQL = "select * from ordent where fec_ord BETWEEN '" & UnixDateFormat(MC1.SelectedDate) & "' and '" & UnixDateFormat(MC2.SelectedDate) & "'"

        If rbTod.Checked Then
            RepListadoOrdISharp(ResultSQL, "1")
        End If
        If rbMedidor.Checked Then
            If txtmedidor.Text = "" Then
                MsgBox("No Escribiste un medidor", MsgBoxStyle.Critical, "Aviso")
                cmdImp.Enabled = True
                Exit Sub
            Else
                ResultSQL += " and Nodemedido='" & txtmedidor.Text & "'"

            End If
        End If


        If rbBrigada.Checked Then
            If cmbBrig.SelectedIndex = -1 Then
                MsgBox("No seleccionaste una brigada", MsgBoxStyle.Critical, "Aviso")
                cmdImp.Enabled = True
                Exit Sub
            Else


                ResultSQL += " and cod_rel = '" & cmbBrig.SelectedValue.ToString & "'"




            End If
            RepListadoOrdISharp(ResultSQL, "1")
        End If
        cmdImp.Text = "IMPRIMIR"
        cmdImp.Enabled = True
        Me.Close()
    End Sub

    Private Sub frmListOrd_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.RBCis.Select()
    End Sub
    Private Sub frmListOrd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub
    Private Sub frmListOrd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCombo(cmbBrig, "select nobrig, descripcion from  brigada  order by descripcion")

        MC1.SelectedDate = Now
        MC1.DisplayMonth = Now
        MC2.SelectedDate = Now
        MC2.DisplayMonth = Now

        ResultSQL = "select * from ordent where fec_ord BETWEEN '" & UnixDateFormat(MC1.SelectedDate) & "' and '" & UnixDateFormat(MC2.SelectedDate) & "'"
    End Sub
    Private Sub cmbBrig_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbBrig.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub cmdImp_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdImp.GotFocus
        cmdImp.Pulse()
        cmdImp.StopPulseOnMouseOver = False
    End Sub

    Private Sub cmdImp_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdImp.LostFocus
        cmdImp.StopPulse()
    End Sub

    Private Sub cmdCancel_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.GotFocus
        cmdCancel.Pulse()
        cmdCancel.StopPulseOnMouseOver = False
    End Sub

    Private Sub cmdCancel_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.LostFocus
        cmdCancel.StopPulse()
    End Sub

    Private Sub rbTod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTod.CheckedChanged
        txtmedidor.Visible = False
        cmbBrig.Visible = False

    End Sub

    Private Sub rbMedidor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMedidor.CheckedChanged
        txtmedidor.Visible = True
        cmbBrig.Visible = False

    End Sub

    Private Sub rbBrigada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbBrigada.CheckedChanged
        txtmedidor.Visible = False
        cmbBrig.Visible = True


    End Sub

    Private Sub rbZona_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtmedidor.Visible = False
        cmbBrig.Visible = False

    End Sub

    Private Sub RepListadoOrdISharp(ByVal sql As String, ByVal caso As String)

        'Reporte Listado de Ordenes de tranajo por brigada en ItextSharp
        Dim SQLListOrdTra As IDataReader

        SQLListOrdTra = ConsultaSql(sql).ExecuteReader()

        'Se crea la carpeta donde se guardaran los reportes de solicitud de pipa
        Dim direcListBNoEntre = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\ListOrdenTrabajoSinE\").Trim

        'Dim directorioSolPipaxMes = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\ReportesSolicitudPipa\" & Year(Now) & acompletacero(Month(Now).ToString(), 2)).Trim

        If Not Directory.Exists(direcListBNoEntre) Then
            Directory.CreateDirectory(direcListBNoEntre)
        End If

#Region "Dar propiedades al documento"

        'Dar propiedades al Documento
        Dim pdfDoc As New Document(iTextSharp.text.PageSize.LETTER, 15.0F, 15.0F, 30.0F, 30.0F)


        Dim pdfWrite2 As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(direcListBNoEntre & "\OrdTraNE_B" & "__" & UnixDateFormat(MC1.SelectedDate) & "__" & UnixDateFormat(MC2.SelectedDate) & ".pdf", FileMode.Create))


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

        'Tabla Vacia
        Dim TableVacia As PdfPTable = New PdfPTable(1)
        TableVacia.DefaultCell.Border = BorderStyle.None
        TableVacia.WidthPercentage = 100
        Dim widthsVacio As Single() = New Single() {1000.0F}
        TableVacia.SetWidths(widthsVacio)


        Dim Col1Vacio = New PdfPCell(New Phrase(" ", Font88))
        Col1Vacio.Border = 0
        Col1Vacio.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        TableVacia.AddCell(Col1Vacio)


        Dim TableEncabezado As PdfPTable = New PdfPTable(2)
        TableEncabezado.DefaultCell.Border = BorderStyle.None
        TableEncabezado.WidthPercentage = 100
        Dim widths As Single() = New Single() {100.0F, 500.0F}
        TableEncabezado.SetWidths(widths)


        'Agregar Logo
        Dim imagenBMP As iTextSharp.text.Image
        imagenBMP = iTextSharp.text.Image.GetInstance(LOGOBYTE)
        imagenBMP.ScaleToFit(80.0F, 70.0F)
        imagenBMP.Border = 0
        TableEncabezado.AddCell(imagenBMP)

        Dim Tabledireccion As PdfPTable = New PdfPTable(1)
        Tabledireccion.DefaultCell.Border = BorderStyle.None
        Tabledireccion.WidthPercentage = 100
        Dim widthsDir As Single() = New Single() {1000.0F}
        Tabledireccion.SetWidths(widthsDir)


        Dim DomEmpresa As String = Empresa
        Dim Col1d = New PdfPCell(New Phrase(DomEmpresa, Font88))
        Col1d.Border = 0
        Col1d.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        Tabledireccion.AddCell(Col1d)

        Dim DomDireccion As String = Direccion
        Col1d = New PdfPCell(New Phrase(DomDireccion, Font88))
        Col1d.Border = 0
        Col1d.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        Tabledireccion.AddCell(Col1d)

        Dim ColNomRep = New PdfPCell(New Phrase("REPORTE DE LISTADO DE ORDENES DE SERVICIO", Font12))
        ColNomRep.Border = 0
        ColNomRep.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        Tabledireccion.AddCell(ColNomRep)

        TableEncabezado.AddCell(Tabledireccion)


        Dim TableFechas As PdfPTable = New PdfPTable(3)
        TableFechas.DefaultCell.Border = BorderStyle.None
        TableFechas.WidthPercentage = 100
        Dim widthsF As Single() = New Single() {600.0F, 10.0F, 400.0F}
        TableFechas.SetWidths(widthsF)

        Dim Col1TabFec = New PdfPCell(New Phrase(" ", Font88))
        Col1TabFec.Border = 0
        Col1TabFec.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        TableFechas.AddCell(Col1TabFec)

        Col1TabFec = New PdfPCell(New Phrase(" ", Font88))
        Col1TabFec.Border = 0
        Col1TabFec.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        Col1TabFec.BackgroundColor = New iTextSharp.text.BaseColor(48, 87, 102)
        TableFechas.AddCell(Col1TabFec)

        Dim Col2TabFec = New PdfPCell(New Phrase("Fecha de Impresión: " & Date.Now.ToString("dd/MM/yyyy"), Font10))
        Col2TabFec.Border = 0
        Col2TabFec.HorizontalAlignment = PdfPCell.ALIGN_LEFT
        TableFechas.AddCell(Col2TabFec)

        Col1TabFec = New PdfPCell(New Phrase("PERIODO DEL " & UnixDateFormat(MC1.SelectedDate).ToString() & " AL " & UnixDateFormat(MC2.SelectedDate).ToString(), Font10))
        Col1TabFec.Border = 0
        Col1TabFec.HorizontalAlignment = PdfPCell.ALIGN_LEFT
        TableFechas.AddCell(Col1TabFec)

        Col1TabFec = New PdfPCell(New Phrase(" ", Font88))
        Col1TabFec.Border = 0
        Col1TabFec.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        Col1TabFec.BackgroundColor = New iTextSharp.text.BaseColor(48, 87, 102)
        TableFechas.AddCell(Col1TabFec)

        Dim Brigada As String = cmbBrig.Text
        Col2TabFec = New PdfPCell(New Phrase("BRIGADA: " & Brigada, Font12))
        Col2TabFec.Border = 0
        Col2TabFec.HorizontalAlignment = PdfPCell.ALIGN_LEFT
        TableFechas.AddCell(Col2TabFec)

        'Tabla de Conceptos
        Dim TableConceptos As PdfPTable = New PdfPTable(8)
        TableConceptos.DefaultCell.Border = BorderStyle.None
        TableConceptos.WidthPercentage = 100
        Dim widthsCon As Single() = New Single() {40.0F, 40.0F, 85.0F, 115.0F, 60.0F, 60.0F, 130.0F, 100.0F}
        TableConceptos.SetWidths(widthsCon)

        Dim Col1TabConcep1 = New PdfPCell(New Phrase("FOLIO", Fontp))
        Col1TabConcep1.Border = 7
        Col1TabConcep1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
        TableConceptos.AddCell(Col1TabConcep1)

        Dim Col1TabConcep2 = New PdfPCell(New Phrase("CUENTA", Fontp))
        Col1TabConcep2.Border = 3
        Col1TabConcep2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
        TableConceptos.AddCell(Col1TabConcep2)

        Dim Col1TabConcep3 = New PdfPCell(New Phrase("COMUNIDAD", Fontp))
        Col1TabConcep3.Border = 3
        Col1TabConcep3.HorizontalAlignment = PdfPCell.ALIGN_LEFT
        TableConceptos.AddCell(Col1TabConcep3)

        Dim Col1TabConcep4 = New PdfPCell(New Phrase("NOMBRE", Fontp))
        Col1TabConcep4.Border = 3
        Col1TabConcep4.HorizontalAlignment = PdfPCell.ALIGN_LEFT
        TableConceptos.AddCell(Col1TabConcep4)

        Dim Col1TabConcep5 = New PdfPCell(New Phrase("FECHA-ALTA", Fontp))
        Col1TabConcep5.Border = 3
        Col1TabConcep5.HorizontalAlignment = PdfPCell.ALIGN_LEFT
        TableConceptos.AddCell(Col1TabConcep5)

        Dim Col1TabConcep6 = New PdfPCell(New Phrase("HORA-ALTA", Fontp))
        Col1TabConcep6.Border = 3
        Col1TabConcep6.HorizontalAlignment = PdfPCell.ALIGN_LEFT
        TableConceptos.AddCell(Col1TabConcep6)

        Dim Col1TabConcep7
        Dim Col1TabConcep8

        If caso = "2" Then

            Col1TabConcep7 = New PdfPCell(New Phrase("INDICACIONES", Fontp))
            Col1TabConcep7.Border = 3
            Col1TabConcep7.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableConceptos.AddCell(Col1TabConcep7)

            Col1TabConcep8 = New PdfPCell(New Phrase("UBICACIÓN", Fontp))
            Col1TabConcep8.Border = 11
            Col1TabConcep8.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableConceptos.AddCell(Col1TabConcep8)

        End If

        If caso = "1" Then


            Col1TabConcep7 = New PdfPCell(New Phrase("COMPROMISO", Fontp))
            Col1TabConcep7.Border = 3
            Col1TabConcep7.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableConceptos.AddCell(Col1TabConcep7)

            Col1TabConcep8 = New PdfPCell(New Phrase("SE CUMPLIÓ", Fontp))
            Col1TabConcep8.Border = 11
            Col1TabConcep8.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableConceptos.AddCell(Col1TabConcep8)

        End If


        'Llenar tabla de conceptos
        Dim Cont As Int32 = 0

        While SQLListOrdTra.Read()

            Col1TabConcep1 = New PdfPCell(New Phrase(SQLListOrdTra("FOLIO"), Font9))
            Col1TabConcep1.Border = 3
            Col1TabConcep1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableConceptos.AddCell(Col1TabConcep1)

            Col1TabConcep2 = New PdfPCell(New Phrase(SQLListOrdTra("CUENTA"), Font9))
            Col1TabConcep2.Border = 3
            Col1TabConcep2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableConceptos.AddCell(Col1TabConcep2)

            'OBTENER EL NOMBRE DE LA COMUNIDAD

            Dim SQLComunidad As IDataReader
            Dim sqlcomu As String = "select Comunidad from comunidades where Id_comunidad = '" & SQLListOrdTra("Id_comunidad") & "'"
            SQLComunidad = ConsultaSql(sqlcomu).ExecuteReader()

            While SQLComunidad.Read()
                Col1TabConcep3 = New PdfPCell(New Phrase(SQLComunidad("Comunidad"), Font9))
                Col1TabConcep3.Border = 3
                Col1TabConcep3.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableConceptos.AddCell(Col1TabConcep3)
            End While

            Col1TabConcep4 = New PdfPCell(New Phrase(SQLListOrdTra("NOMBRE"), Font9))
            Col1TabConcep4.Border = 3
            Col1TabConcep4.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableConceptos.AddCell(Col1TabConcep4)

            Col1TabConcep5 = New PdfPCell(New Phrase(SQLListOrdTra("Fec_Ord"), Font9))
            Col1TabConcep5.Border = 3
            Col1TabConcep5.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableConceptos.AddCell(Col1TabConcep5)

            Col1TabConcep6 = New PdfPCell(New Phrase(SQLListOrdTra("hora").ToString(), Font9))
            Col1TabConcep6.Border = 3
            Col1TabConcep6.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            TableConceptos.AddCell(Col1TabConcep6)

            'Col1TabConcep7 = New PdfPCell(New Phrase(SQLListOrdTra("indic"), Font9))
            'Col1TabConcep7.Border = 3
            'Col1TabConcep7.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'TableConceptos.AddCell(Col1TabConcep7)

            'Col1TabConcep8 = New PdfPCell(New Phrase(SQLListOrdTra("ubicacion"), Font9))
            'Col1TabConcep8.Border = 3
            'Col1TabConcep8.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'TableConceptos.AddCell(Col1TabConcep8)

            If caso = "2" Then

                Col1TabConcep7 = New PdfPCell(New Phrase(SQLListOrdTra("indic"), Fontp))
                Col1TabConcep7.Border = 3
                Col1TabConcep7.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableConceptos.AddCell(Col1TabConcep7)

                Col1TabConcep8 = New PdfPCell(New Phrase(SQLListOrdTra("ubicacion"), Fontp))
                Col1TabConcep8.Border = 11
                Col1TabConcep8.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableConceptos.AddCell(Col1TabConcep8)

            End If

            If caso = "1" Then

                Col1TabConcep7 = New PdfPCell(New Phrase(SQLListOrdTra("FEC_COM"), Fontp))
                Col1TabConcep7.Border = 3
                Col1TabConcep7.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                TableConceptos.AddCell(Col1TabConcep7)



                Dim FechaResp As String = SQLListOrdTra("FEC_RES").ToString
                Try
                    Col1TabConcep8 = New PdfPCell(New Phrase(FechaResp, Fontp))
                    Col1TabConcep8.Border = 11
                    Col1TabConcep8.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    TableConceptos.AddCell(Col1TabConcep8)
                Catch ex As Exception
                    Col1TabConcep8 = New PdfPCell(New Phrase(" ", Fontp))
                    Col1TabConcep8.Border = 11
                    Col1TabConcep8.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    TableConceptos.AddCell(Col1TabConcep8)
                End Try


            End If

            Cont = Cont + 1

        End While


        'Tabla Vacia
        Dim TableTotalOrd As PdfPTable = New PdfPTable(2)
        TableTotalOrd.DefaultCell.Border = BorderStyle.None
        TableTotalOrd.WidthPercentage = 100
        Dim widthsTot As Single() = New Single() {500.0F, 500.0F}
        TableTotalOrd.SetWidths(widthsTot)


        Dim ColTota1 = New PdfPCell(New Phrase("Ordenes Totales: " & Cont.ToString(), Font88))
        ColTota1.Border = 0
        ColTota1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
        TableTotalOrd.AddCell(ColTota1)

        Dim ColTota2 = New PdfPCell(New Phrase(" ", Font88))
        ColTota2.Border = 0
        ColTota2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
        TableTotalOrd.AddCell(ColTota2)


        'Agregar tablas al documento
        pdfDoc.Add(TableEncabezado)
        pdfDoc.Add(TableVacia)
        pdfDoc.Add(TableFechas)
        pdfDoc.Add(TableVacia)
        pdfDoc.Add(TableConceptos)
        pdfDoc.Add(TableVacia)
        pdfDoc.Add(TableVacia)
        pdfDoc.Add(TableTotalOrd)

        'Cerrar documento
        pdfDoc.Close()

        'Visualizar el pdf

        Try
            Dim psi As New ProcessStartInfo(direcListBNoEntre & "\OrdTraNE_B" & "__" & UnixDateFormat(MC1.SelectedDate) & "__" & UnixDateFormat(MC2.SelectedDate) & ".pdf")
            'psi.WorkingDirectory = cadenafolder & "\factura\" + nombresespacios

            psi.WindowStyle = ProcessWindowStyle.Hidden
            Dim p As Process = Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("error al visualizar el pdf" & ex.Message)
        End Try



#End Region


    End Sub


End Class