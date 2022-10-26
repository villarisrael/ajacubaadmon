
Imports DevComponents.DotNetBar

Public Class frmimportalecturas
    Dim listo As Boolean = False
    Dim comunidad As String = ""
    Dim regio As String = ""
    Dim ruta As String = ""
    Dim lecturista As String = ""
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try

            Dim archivo As String
            'abrirarchivo.Filter = "Archivos XML (*.XML)|*.XML"
            'abrirarchivo.ShowDialog()
            fbd1.ShowNewFolderButton = True
            fbd1.ShowDialog()
            archivo = fbd1.SelectedPath
            'If archivo.Length > 60 Then
            '    lblarchivo.Text = "..." & archivo.Substring(archivo.Length - 60, 60)
            'ElseIf archivo.Length > 0 Then
            '    lblarchivo.Text = archivo
            'End If

            If archivo = "OpenFileDialog1" Then
                MessageBoxEx.Show("No seleccionó correctamente la ubicación de las lecturas, verifique por favor", "Importar lecturas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'lblarchivo.Text = ""
                Exit Sub
            End If
            Dim dst As New System.Data.DataSet
            dst.ReadXml(archivo & "\ArcLectura.xml")
            Tabla.DataSource = dst.Tables(0)


            'Dim ds As New DataSet
            'ds.ReadXml(archivo & "\Rutas.xml")
            ''dg.DataSource = ds.Tables(0)


            'dgArc.Rows.Clear()
            'For i = 0 To dg.RowCount - 2
            '    dgArc.Rows.Add("ruta 
            'Next i

            'If Tabla.RowCount > 0 Then
            '    comunidad = Tabla.Rows.Item(0).Cells("id_comunidad").Value
            '    regio = Tabla.Rows.Item(0).Cells("region").Value
            '    ruta = Tabla.Rows.Item(0).Cells("ruta").Value
            'End If

            'TEMPORAL = "TMPLECTURAS" & comunidad & "_" & regio & "_" & ruta
            'lbltemporal.Text = TEMPORAL
        Catch ex As Exception

            If ex.Message.Contains("No se pudo encontrar el archivo") Then
                MessageBoxEx.Show("No se pudo encontrar las lecturas en el archivo especificado", "Importar lecturas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBoxEx.Show(ex.Message, "Importar lecturas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End Try

    End Sub

    Private Sub frmimportalecturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'llenartemporales()
        txtAn.Text = Year(Now)
        Try
            llenarCombo(cmblecturista, "Select idtrab, nombre from trabajadores where cod_dep = 'MED'")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Dim contR As Int32 = 0
        Dim contU As Int32 = 0

        If cmblecturista.SelectedIndex = -1 Then
            MessageBoxEx.Show("No ha seleccionado lecturista", "Importar lecturas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmblecturista.Select()
            Exit Sub
        End If
        If cmbmes.Text = "" Then
            MessageBoxEx.Show("Selecciona el Mes al que Desea Agregar las Capturas .. ", "Importar lecturas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbmes.Select()
            Exit Sub
        End If

        If txtAn.Text = "" Then
            MessageBoxEx.Show("El Campo Año es Obligatorio.. ", "Importar lecturas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmblecturista.Select()
            Exit Sub
        End If

        'Dim rs As IDataReader
        ' continua la rutina y lee los datos del xml
        ButtonX2.Enabled = False
        PB.Value = 0
        PB.TextVisible = True
        PB.Maximum = Tabla.RowCount - 1
        Application.DoEvents()
        For i = 0 To Tabla.RowCount - 1
            Dim algoritmo As Integer = 1
            Dim alerta As Boolean = False

            Dim cuenta As Integer = Tabla.Item("cuenta", i).Value
            Dim lectura As Integer = Tabla.Item("lecturatom", i).Value
            Dim consumo As Integer = Tabla.Item("diferenciafinal", i).Value
            Dim montocobrado As Integer = Tabla.Item("importe", i).Value
            Dim sit_med As String = Tabla.Item("sit_med", i).Value
            Dim sit_pad As String = Tabla.Item("sit_pad", i).Value
            Dim sit_hid As String = Tabla.Item("sit_hid", i).Value
            Dim consumocobrado As Integer = Tabla.Item("importe", i).Value
            Dim observacion As String = Tabla.Item("observacion", i).Value
            Dim lecturaant As Integer = Tabla.Item("lecturaAct", i).Value

            'Dim tarifa As String = Tabla.Item("Tarifa", i).Value
            Dim tarifa As String = obtenerCampo("SELECT tarifa FROM usuario where cuenta='" & cuenta & "'", "tarifa")
            'Opcional
            'Dim ruta As String = Tabla.Item("ruta", i).Value
            Dim ruta As String = obtenerCampo("SELECT ruta FROM usuario where cuenta='" & cuenta & "'", "ruta")
            'Dim region As String = Tabla.Item("region", i).Value
            Dim region As String = obtenerCampo("SELECT region FROM usuario where cuenta='" & cuenta & "'", "region")


            If consumo >= Val(obtenerCampo("select altcap from cuotas where id_tarifa='" & tarifa & "'", "altcap")) Then
                alerta = True
            End If

            Dim fecap As Date = Now


            If sit_med = "" And sit_hid = "" And sit_pad = "" Then
                algoritmo = 1
            End If


            Dim status As String = "T"

            lecturista = cmblecturista.SelectedValue.ToString

            Try
                If obtenerCampo("select cuenta from lecturas  where cuenta=" & cuenta & " and mes='" & cmbmes.Text & "' and an_per='" & txtAn.Text & "' ", "cuenta") = "0" Then
                    Dim cadena As New StringBuilder

                    cadena.Append("insert into lecturas (cuenta, ruta, region, lectura, consumo, monto, sit_med, sit_pad, sit_hid, consumocobrado, lectant, tarifa, mes, an_per, lecturista) ")
                    cadena.Append(" values (" & cuenta & "," & ruta & "," & region & "," & lectura & "," & consumo & ",ConsumoMedidosSin(" & consumo & ",'" & tarifa & "'," & txtAn.Text & ") ,'" & sit_med & "','" & sit_pad & "','" & sit_hid & "'," & consumo & "," & lecturaant & ",'" & tarifa & "','" & cmbmes.Text & "'," & txtAn.Text & ",'" & cmblecturista.SelectedValue & "');")

                    Ejecucion(cadena.ToString)
                    contR = contR + 1
                Else
                    contU = contU + 1
                    Dim cadena As New StringBuilder
                    cadena.Append("update lecturas ")
                    cadena.Append("set lecturista='" & lecturista & "',")
                    cadena.Append("tarifa='" & tarifa & "',")
                    cadena.Append("lectant=" & lecturaant & ",")
                    cadena.Append("lectura=" & lectura & ",")
                    cadena.Append("sit_pad='" & sit_pad & "',")
                    cadena.Append("sit_med='" & sit_med & "',")
                    cadena.Append("sit_hid='" & sit_hid & "',")
                    cadena.Append("observa='" & observacion & "',")
                    cadena.Append("consumo=" & consumo & ",")
                    cadena.Append("consumocobrado=" & consumo & ",")
                    cadena.Append("MONTO=ConsumoMedidosSin(" & consumo & ",'" & tarifa & "'," & txtAn.Text & "),")
                    cadena.Append("alerta=" & alerta & ",")
                    cadena.Append("algoritmo=" & algoritmo & ",")
                    cadena.Append("lecturista='" & lecturista & "'")
                    cadena.Append(" where cuenta=" & cuenta)
                    cadena.Append(" and mes='" & cmbmes.Text & "'")
                    cadena.Append(" and an_per='" & txtAn.Text & "';")
                    Ejecucion(cadena.ToString)


                End If
            Catch ex As Exception
                MessageBoxEx.Show(ex.Message)
            End Try
            PB.Value += 1
            PB.Text = Math.Round(((PB.Value / PB.Maximum) * 100), 2) & "%"

        Next i
        Dim contRS As String = Convert.ToString(contR)
        Dim contUS As String = Convert.ToString(contU)
        MessageBoxEx.Show("Importación Finalizada, Se Realizaron: " & contRS & " Registros y " & contUS & " Actualizaciones ", "Importar lecturas", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ButtonX2.Enabled = True

    End Sub

    'Sub llenartemporales()

    '    For i = 0 To Listatemporales.Items.Count - 1
    '        Listatemporales.Items(0).Remove()
    '    Next

    '    Dim CONTADOR As Integer = 0
    '    Dim leer As IDataReader
    '    Try

    '        leer = ConsultaSql("show tables like 'tmplecturas%'").ExecuteReader



    '        Try
    '            While leer.Read()
    '                If leer(0).ToString <> "tmplecturas" Then
    '                    Listatemporales.Items.Add(leer(0).ToString.Substring(11, leer(0).ToString.Length - 11))
    '                    Listatemporales.Items(CONTADOR).ImageIndex = 0
    '                    CONTADOR = CONTADOR + 1
    '                End If

    '            End While

    '        Catch ex As Exception
    '            MessageBoxEx.Show(ex.Message)
    '        End Try
    '    Catch ex As Exception

    '    End Try
    'End Sub
    Private Sub cmblecturista_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmblecturista.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
    Private Sub ButtonX2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonX2.GotFocus
        ButtonX2.StopPulseOnMouseOver = False
        ButtonX2.Pulse()
    End Sub
    Private Sub ButtonX2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonX2.LostFocus
        ButtonX2.StopPulse()
    End Sub
End Class