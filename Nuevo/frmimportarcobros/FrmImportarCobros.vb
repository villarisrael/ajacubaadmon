Imports System.IO
Public Class FrmImportarCobros
    Dim DirGen As String
    Dim terminar As Boolean = True
    

    Private Sub FrmImportarCobros_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If terminar Then

        Else
            e.Cancel = terminar
        End If

    End Sub

    Private Sub FrmImportarCobros_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.tabcobros.Select()
    End Sub

    Private Sub FrmImportarCobros_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyData = Keys.Escape Then
            Close()
        End If
    End Sub
    Private Sub FrmImportarCobros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCombo(CmbOficina, "Select Cod_ofi, Nombre from oficinas")
        DirGen = obtenerCampo("select rutatmp from empresa ", "rutatmp")
        If DirGen = "0" Then
            DirGen = "C:\tmpimportacion"
        End If

        If Not Directory.Exists(DirGen) Then
            Directory.CreateDirectory(DirGen)
        End If
        BtnCopiar.Enabled = True
        BtnActualizar.Enabled = False
    End Sub

    Private Sub BtnCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopiar.Click
        Dim dias As Integer = DateDiff(DateInterval.Day, DTInicio.Value, DtFin.Value)
        Dim Archivo As String, Directorio As String, Fecha As Date, Destino As String
        Directorio = TxtRuta.Text
        PG.Visible = True
        PG.Maximum = dias + 1
        PG.Value = 0
        If CmbOficina.SelectedIndex = -1 Then
            MessageBox.Show("No seleccionaste oficina")
            Exit Sub
        End If

        If CmbCaja.SelectedIndex = -1 Then
            MessageBox.Show("No seleccionaste caja")
            Exit Sub
        End If

        'For i As Integer = 0 To dias + 1
        'PG.Value = dias
        Fecha = DTInicio.Value 'DateAdd(DateInterval.Day, i, DTInicio.Value)
        'If Fecha > DtFin.Value Then
        '    Exit For
        'End If
        Archivo = Directorio & "\" & "Importacion" & CmbOficina.SelectedValue.ToString & "-" & CmbCaja.SelectedValue.ToString & "-" & Format(Fecha.Day, "00") & "-" & Format(Fecha.Month, "00") & "-" & Fecha.Year & ".txt"
        Destino = DirGen & "\" & "Importacion" & CmbOficina.SelectedValue.ToString & "-" & CmbCaja.SelectedValue.ToString & "-" & Format(Fecha.Day, "00") & "-" & Format(Fecha.Month, "00") & "-" & Fecha.Year & ".txt"
        PG.Text = "Copiando Archivo " & "Importacion" & CmbOficina.SelectedValue.ToString & "-" & CmbCaja.SelectedValue.ToString & "-" & Format(Fecha.Day, "00") & "-" & Format(Fecha.Month, "00") & "-" & Fecha.Year & ".txt"
        If My.Computer.FileSystem.FileExists(Archivo) Then
            Try
                My.Computer.FileSystem.CopyFile(Archivo, Destino, True)
            Catch ex As Exception
                MessageBoxEx.Show(ex.Message, "")
                Exit Sub
            End Try
        Else
            MessageBoxEx.Show("No existe el archivo para el dia " & Fecha.Day & " del mes " & MonthName(Fecha.Month) & " del " & Fecha.Year, "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim verificadatos As IDataReader = ConsultaSql("select * from pagos where cod_ofi='" & CmbOficina.SelectedValue & "' and id_caja ='" & CmbCaja.SelectedValue & "' and fecha_act='" & UnixDateFormat(DTInicio.Value) & "' limit 1").ExecuteReader
        If verificadatos.Read() Then
            MessageBox.Show("Tengo pagos registrados de este dia tu importación es imposible!!!! ", " Alerta!!!", MessageBoxButtons.OK)
            Exit Sub
        End If
        'Archivo = Directorio & "\" & CmbOficina.SelectedValue.ToString & CmbCaja.SelectedValue.ToString & Format(Fecha.Day, "00") & Format(Fecha.Month, "00") & Fecha.Year
        'If Directory.Exists(Archivo) Then
        '    Try
        '        Directory.CreateDirectory(DirGen & "\" & CmbOficina.SelectedValue.ToString & CmbCaja.SelectedValue.ToString & Format(Fecha.Day, "00") & Format(Fecha.Month, "00") & Fecha.Year)
        '    Catch ex As Exception
        '    End Try
        '    Try
        '        My.Computer.FileSystem.CopyDirectory(Archivo, DirGen & "\" & CmbOficina.SelectedValue.ToString & CmbCaja.SelectedValue.ToString & Format(Fecha.Day, "00") & Format(Fecha.Month, "00") & Fecha.Year)
        '    Catch ex As IOException
        '        If MessageBoxEx.Show("¿El Archivo para el dia " & Fecha.Day & " del mes " & MonthName(Fecha.Month).ToUpper & " del " & Fecha.Year & " existe, desea remplazarlo?", "Archivo existente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        '            My.Computer.FileSystem.DeleteDirectory(DirGen & "\" & CmbOficina.SelectedValue.ToString & CmbCaja.SelectedValue.ToString & Format(Fecha.Day, "00") & Format(Fecha.Month, "00") & Fecha.Year, FileIO.DeleteDirectoryOption.DeleteAllContents)
        '            My.Computer.FileSystem.CopyDirectory(Archivo, DirGen & "\" & CmbOficina.SelectedValue.ToString & CmbCaja.SelectedValue.ToString & Format(Fecha.Day, "00") & Format(Fecha.Month, "00") & Fecha.Year)
        '        End If
        '    End Try
        'Else
        '    MessageBoxEx.Show("No existe el archivo para el dia " & Fecha.Day & " del mes " & MonthName(Fecha.Month) & " del " & Fecha.Year, "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
        '  Next
        BtnCopiar.Enabled = False
        BtnActualizar.Enabled = True
        DTInicio.Enabled = False
        DtFin.Enabled = False
        CmbOficina.Enabled = False
        CmbCaja.Enabled = False
        PG.Visible = False
        MessageBoxEx.Show("Archivo Copiado satisfactoriamente", "Copiar archivos", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub CmbOficina_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbOficina.SelectedValueChanged

        Try
            llenarCombo(CmbCaja, "Select Id_caja, Descripcion from cajas where cod_ofi = '" & CmbOficina.SelectedValue.ToString & "'")
            CmbCaja.SelectedIndex = -1
        Catch ex As Exception
        End Try

    End Sub

    Private Sub BtnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSeleccionar.Click
        Dialogo.ShowDialog()
        TxtRuta.Text = Dialogo.SelectedPath
    End Sub


    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        Dim dias As Integer = DateDiff(DateInterval.Day, DTInicio.Value, DtFin.Value)
        Dim Archivo As String, Directorio As String, Fecha As Date, Cont As Int16
        Directorio = TxtRuta.Text
        BtnActualizar.Enabled = False
        BtnCerrar.Enabled = False
        terminar = False
        For i As Integer = 0 To dias + 1
            Fecha = DateAdd(DateInterval.Day, i, DTInicio.Value)
            If Fecha > DtFin.Value Then
                Exit For
            End If

            Archivo = DirGen & "\" & "Importacion" & CmbOficina.SelectedValue.ToString & "-" & CmbCaja.SelectedValue.ToString & "-" & Format(Fecha.Day, "00") & "-" & Format(Fecha.Month, "00") & "-" & Fecha.Year & ".txt"
            If My.Computer.FileSystem.FileExists(Archivo) Then
                Cont = 0
                Dim strContents As String
                Dim endondeelerror As String = ""
                Dim objReader As StreamReader
                Try
                    objReader = New StreamReader(Archivo)
                    Dim recibo As Integer = 0
                    Dim SERIE As String = ""
                    Dim CUENTA As Integer = 0
                    Dim COMUNIDAD As String = ""
                    Dim MESINIPER As String = ""
                    Dim ANOINIPER = 0
                    Dim MESFINPER As String = ""
                    Dim ANOFINPER = 0
                    Dim CUANTOSPAGADOS As Integer = 0
                    Do While Not objReader.EndOfStream
                        endondeelerror = ""
                        CUANTOSPAGADOS = 0
                        strContents = objReader.ReadLine.Remove(0, 1)
                        strContents = strContents.Remove(strContents.Length - 1, 1)

                        Try
                            ' strContents = strContents.Remove(strContents.Length - 1, 1)
                            Console.WriteLine(strContents)
                            If Mid(strContents, 1, 17) = "insert into pagos" Then
                                endondeelerror = "Al registrar factura"
                                recibo = buscareciboencadena(strContents, 18)
                                SERIE = buscaSERIEreciboencadena(strContents, 22)
                                CUENTA = buscacuentaencadena(strContents, 1)
                                COMUNIDAD = buscacomunidadencadena(strContents, 2)
                                MESINIPER = buscacomunidadencadena(strContents, 3)
                                ANOINIPER = buscacuentaencadena(strContents, 4)
                                MESFINPER = buscacomunidadencadena(strContents, 5)
                                ANOFINPER = buscacuentaencadena(strContents, 6)

                                Dim gh As IDataReader
                                gh = ConsultaSql("select recibo,serie from pagos where recibo=" & recibo & " and serie='" & SERIE & "'").ExecuteReader
                                If gh.Read Then Throw New Exception("la Serie recibo se encuentra registrado previamente")

                            End If
                            If Mid(strContents, 1, 27) = "update estados set pagado=1" Then
                                If recibo = 277190 Then Stop

                                endondeelerror = "Al registrar estado de cuenta"

                                If buscaperiodoestados(strContents).Length = 0 Then
                                    Throw New Exception("No hagas nada")
                                    endondeelerror = ""
                                End If

                                CUANTOSPAGADOS = Val(" " & obtenerCampo("SELECT SUM(PAGADO) AS CUANTOS FROM ESTADOS  WHERE CUENTA =" & CUENTA & " AND ID_COMUNIDAD='" & COMUNIDAD & "' AND VALORNUMMES(MES_PERIODO,AN_PER)>= VALORNUMMES('" & MESINIPER & "'," & ANOINIPER & ") AND VALORNUMMES(MES_PERIODO,AN_PER)>= VALORNUMMES('" & MESFINPER & "'," & ANOFINPER & ")", "CUANTOS"))

                                If CUANTOSPAGADOS > 0 Then
                                    Ejecucion(strContents)
                                    Throw New Exception("PERIODOS PAGADOS DOBLEMENTE")
                                End If

                               
                            End If
                            Ejecucion(strContents)

                        Catch ex As Exception
                            Select Case ex.Message
                                Case "No hagas nada"
                                Case "la Serie recibo se encuentra registrado previamente"
                                    Guardarerroresimportacion("EL RECIBO : " & SERIE & " " & recibo & "SE ENCUENTRA REGISTRADO PREVIAMENTE", DTInicio.Value, CmbOficina.SelectedValue, CmbCaja.SelectedValue, DirGen)
                                    Cont += 1
                                
                                Case "PERIODOS PAGADOS DOBLEMENTE"
                                    Guardarerroresimportacion("EL USUARIO " & CUENTA & " " & COMUNIDAD & " TENIA PAGADO " & CUANTOSPAGADOS & " MESES PAGADOS DEL PERIODO " & vbCrLf & MESINIPER & " " & ANOINIPER & "-" & MESFINPER & " " & ANOFINPER & vbCrLf & " EN EL RECIBO " & SERIE & " " & recibo & vbCrLf, DTInicio.Value, CmbOficina.SelectedValue, CmbCaja.SelectedValue, DirGen)
                                    Cont += 1

                                Case Else
                                    Select Case endondeelerror
                                        Case "Al registrar factura"

                                            Guardarerroresimportacion("Error al registrar la factura: " & SERIE & " " & recibo, DTInicio.Value, CmbOficina.SelectedValue, CmbCaja.SelectedValue, DirGen)
                                            Guardarerroresimportacion("sentencia SQL: " & strContents & vbCrLf, DTInicio.Value, DtFin.Value, CmbOficina.SelectedValue, CmbCaja.SelectedValue, DirGen)

                                            Cont += 1

                                        Case "Al registrar estado de cuenta"
                                            Guardarerroresimportacion("Error al registrar estados de cuenta de la factura: " & recibo, DTInicio.Value, CmbOficina.SelectedValue, CmbOficina.SelectedValue, DirGen)
                                            Guardarerroresimportacion("sentencia SQL :" & strContents & vbCrLf, DTInicio.Value, CmbOficina.SelectedValue, CmbCaja.SelectedValue, DirGen)
                                            '      Guardarerroresimportacion(ex.Message, DTInicio.Value, DtFin.Value, DirGen)
                                            Cont += 1
                                        Case Else
                                            Guardarerroresimportacion("Error al registrar la factura: " & recibo, DTInicio.Value, CmbOficina.SelectedValue, CmbCaja.SelectedValue, DirGen)
                                            Guardarerroresimportacion("sentencia SQL :" & strContents & vbCrLf, DTInicio.Value, CmbOficina.SelectedValue, CmbCaja.SelectedValue, DirGen)
                                    End Select
                            End Select

                        End Try

                    Loop
                    MsgBox("Numero de errores " & Cont & " las sentecias las podras ver en el archivo ERRORIMPORTACION-" & CmbOficina.SelectedValue & "-" & CmbCaja.SelectedValue & " de la carpeta" & vbCrLf & " " & DirGen)
                    ' strContents = objReader.ReadToEnd()
                    objReader.Close()

                Catch Ex As Exception
                    MessageBoxEx.Show(Ex.Message)
                End Try
            End If
        Next
        MessageBox.Show("Termine", "Aviso", MessageBoxButtons.OK)
        BtnCopiar.Enabled = True
        BtnCerrar.Enabled = True
        DTInicio.Enabled = True
        DtFin.Enabled = True

        terminar = True
        'Dim dias As Integer = DateDiff(DateInterval.Day, MCInicio.SelectedDate, MCFin.SelectedDate)
        'Dim Archivo As String, Directorio As String, Fecha As Date
        
    End Sub

    Private Sub BtnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCerrar.Click

        Close()
    End Sub

    Private Sub DtFin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtFin.Click

    End Sub

    Private Sub CmbOficina_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbOficina.SelectedIndexChanged

        Try
            llenarCombo(CmbCaja, "Select Id_caja, Descripcion from cajas where cod_ofi = '" & CmbOficina.SelectedValue.ToString & "'")
            CmbCaja.SelectedIndex = -1
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DTInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTInicio.Click
        DtFin.Value = DTInicio.Value
    End Sub

    Private Sub DTInicio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTInicio.TextChanged
        DtFin.Value = DTInicio.Value
    End Sub

    Function buscareciboencadena(ByVal cadena As String, ByVal numcamp As Integer) As Integer
        Dim i As Integer = 1
        Dim pos As Integer = 1
        Do While i <= numcamp
            pos = InStr(cadena, ",")
            If pos = 0 Then Return 0
            cadena = Mid(cadena, pos + 1, cadena.Length)
            i = i + 1
        Loop
        If i > 1 Then


            Dim pos2 As Integer = 0
            pos2 = InStr(cadena, ",")
            Return Val(Mid(cadena, 1, pos2))
        Else
            Return 0
        End If

    End Function

    Function buscacuentaencadena(ByVal cadena As String, ByVal numcamp As Integer) As Integer
        Dim i As Integer = 1
        Dim pos As Integer = 1
        Do While i <= numcamp
            pos = InStr(cadena, ",")
            If pos = 0 Then Return 0
            cadena = Mid(cadena, pos + 1, cadena.Length)
            i = i + 1
        Loop
        If i > 1 Then


            Dim pos2 As Integer = 0
            pos2 = InStr(cadena, ",")
            Return Val(Mid(cadena, 1, pos2))
        Else
            Return 0
        End If

    End Function


    Function buscaSERIEreciboencadena(ByVal cadena As String, ByVal numcamp As Integer) As String
        Dim i As Integer = 1
        Dim pos As Integer = 1
        Do While i <= numcamp
            pos = InStr(cadena, ",")
            If pos = 0 Then Return 0
            cadena = Mid(cadena, pos + 1, cadena.Length)
            i = i + 1
        Loop
        If i > 1 Then


            Dim pos2 As Integer = 0
            pos2 = InStr(cadena, ",")
            Return Mid(cadena, 2, 1)
        Else
            Return 0
        End If

    End Function

    Function buscacomunidadencadena(ByVal cadena As String, ByVal numcamp As Integer) As String
        Dim i As Integer = 1
        Dim pos As Integer = 1
        Do While i <= numcamp
            pos = InStr(cadena, ",")
            If pos = 0 Then Return 0
            cadena = Mid(cadena, pos + 1, cadena.Length)
            i = i + 1
        Loop
        If i > 1 Then


            Dim pos2 As Integer = 0
            pos2 = InStr(cadena, ",")
            Return Mid(cadena, 2, 3)
        Else
            Return 0
        End If

    End Function

    Function buscaperiodoestados(ByVal cadena As String) As String
        If InStr(cadena, "ENE") > 0 Then
            Return "ENE"
        End If
        If InStr(cadena, "FEB") > 0 Then
            Return "FEB"
        End If
        If InStr(cadena, "MAR") > 0 Then
            Return "MAR"
        End If
        If InStr(cadena, "ABR") > 0 Then
            Return "ABR"
        End If
        If InStr(cadena, "MAY") > 0 Then
            Return "MAY"
        End If
        If InStr(cadena, "JUN") > 0 Then
            Return "JUN"
        End If
        If InStr(cadena, "JUL") > 0 Then
            Return "JUL"
        End If
        If InStr(cadena, "AGO") > 0 Then
            Return "AGO"
        End If
        If InStr(cadena, "SEP") > 0 Then
            Return "SEP"
        End If
        If InStr(cadena, "OCT") > 0 Then
            Return "OCT"
        End If
        If InStr(cadena, "NOV") > 0 Then
            Return "NOV"
        End If
        If InStr(cadena, "DIC") > 0 Then
            Return "DIC"
        End If
        Return ""
    End Function


    

    Function buscawhereencadena(ByVal cadena As String) As String
        Dim i As Integer = 1
        Dim pos As Integer = 1

        pos = InStr(cadena, "where")
        If pos = 0 Then
            Return ""
        Else
            cadena = Mid(cadena, pos, cadena.Length - pos + 1) & " limit 1"
            Return cadena
        End If
    End Function
End Class