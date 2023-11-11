Public Class FrmCapturaLecturas
    Dim Lectura As New ClsLecturas
    Dim Pasar As Boolean
    Dim NumLec As Integer, Tabla As String, Comu As String, Manzana As String, Lote As String
    Public SigRuta As Boolean = False
    Private Sub FrmCapturaLecturas_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.tabFacturacion.Select()
    End Sub

    Private Sub FrmCapturaLecturas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData

        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
            Case Keys.F10
                Try
                    Dim fim As New frmVerLect

                    fim.cuenta = Val(TxtCuenta.Text)
                    fim.Text = " LECTURAS DE LA CUENTA " & fim.cuenta & " " & fim.idcomu
                    fim.ShowDialog()

                Catch ex As Exception

                End Try
            Case Keys.F7
                Lectura.ReiniciarCaptura()
                Buscar()
                TxtLectura.Select()
        End Select
    End Sub
    Private Sub FrmCapturaLecturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  FrmVerificarLecturas.Close()
        FrmCalculaConsumo.Close()
        'FrmAplicarLecturas.Close()
        FrmLecturasCapturadas.Close()
        FrmLecturasNoCapturadas.Close()


        llenarCombo(CmbSituacion, "Select situacion, clave from situacion where tipo = 'Medicion'")
        llenarCombo(CmbSituacion2, "Select situacion ,clave from situacion where tipo = 'Padron'")
        llenarCombo(CmbSituacion3, "Select situacion, clave from situacion where tipo = 'Hidrometro'")
        llenarCombo(CmbRegion, "Select Id_Region, Region from region  order by region")
        CmbRegion.SelectedIndex = -1

        llenarCombo(CmbRuta, "Select id_ruta, ruta from rutas  order by id_ruta")

        llenarCombo(CmbLecturistas, "Select idtrab, nombre from trabajadores where cod_dep = 'MED'")
        DTMEs.Value = Now
        CmbSituacion.SelectedIndex = -1
        CmbSituacion2.SelectedIndex = -1
        CmbSituacion3.SelectedIndex = -1
        CmbLecturistas.SelectedIndex = -1
        llenaGrid(DGSit, "Select clave, situacion, Tipo from situacion")
        GPQuitar.Dock = DockStyle.Fill

        txtAn.Text = Year(Now)

    End Sub

    Private Sub RecorrePadre()
        If Lectura.Avanzar() Then
            LblNombre.Text = Lectura.Nombre
            TxtCuenta.Text = Lectura.Cuenta
            txtcuentaanterior.Text = Lectura.Lote
            LblMedidor.Text = Lectura.Medidor
            LblDireccion.Text = Lectura.Direccion
            LblAnterior.Text = Lectura.Lec1
            LblAnterior2.Text = Lectura.Lec2
            LblTarifa.Text = Lectura.Tarifa
            TxtLectura.Value = 0
            LblNumLec.Text = Lectura.NumLec
            Manzana = Lectura.Manzana
            Lote = Lectura.Lote
            BtnSiguiente.Enabled = True
            GPQuitar.Visible = False
        Else
            LblNombre.Text = ""
            TxtCuenta.Text = ""
            txtcuentaanterior.Text = ""
            LblUbicacion.Text = ""
            LblMedidor.Text = ""
            LblDireccion.Text = ""
            LblAnterior.Text = ""
            LblAnterior2.Text = ""
            LblTarifa.Text = ""
            TxtLectura.Value = 0
            LblNumLec.Text = ""

            Manzana = ""
            Lote = ""
            BtnSiguiente.Enabled = False
            MessageBox.Show("Se han capturado todas las lecturas de la ruta seleccionada", "Captura finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Ejecucion("Update rutas set captura = 'S' where id_ruta = '" & CmbRuta.ComboBox.SelectedValue.ToString & "' and id_region = '" & CmbRegion.ComboBox.SelectedValue.ToString & "'  ")

            GPQuitar.Visible = True
        End If
    End Sub

    Public Sub Buscar()
        If SigRuta = False Then
           
            If CmbRegion.ComboBox.Text <> "" Then
                Lectura.Region = CmbRegion.ComboBox.SelectedValue.ToString
            Else
                MessageBox.Show("No selecciono la region de las lecturas", "Captura de lecturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CmbRegion.Select()
                Exit Sub
            End If
            Lectura.Fecha = DTMEs.Value
            If CmbRuta.ComboBox.Text <> "" Then
                Lectura.Ruta = CmbRuta.ComboBox.SelectedValue.ToString
            Else
                MessageBox.Show("No selecciono la ruta de las lecturas", "Captura de lecturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CmbRuta.Select()
                Exit Sub
            End If
            If CmbLecturistas.ComboBox.Text <> "" Then
                Lectura.Lecturista = CmbLecturistas.ComboBox.SelectedValue.ToString
            Else
                MessageBox.Show("No selecciono al lecturista que realizo la toma de lecturas", "Captura de lecturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CmbLecturistas.Select()
                Exit Sub
            End If

            If cmbmes.Text <> "" Then
                Lectura.mes = cmbmes.Text
            Else
                MessageBox.Show("No selecciono el mes que se va a capturar", "Captura de lecturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbmes.Select()
                Exit Sub
            End If


            If txtAn.Text <> "" Then
                Lectura.periodo = txtAn.Text
            Else
                MessageBox.Show("No selecciono el año que se va a capturar", "Captura de lecturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAn.Select()
                Exit Sub
            End If


            If obtenerCampo("Select Tomalec from rutas where id_ruta ='" & Lectura.Ruta & "' and id_region = '" & Lectura.Region & "'", "TomaLec") = "N" Then
                If MessageBox.Show("Para esta ruta " & CmbRuta.ComboBox.Text & " no se ha realizado el reporte de toma de lecturas" & vbCrLf & "¿Ignorar la emision de la toma de lecturas?", "Captura de lecturas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Ejecucion("Update rutas set TomaLec = 'I' where Id_ruta = '" & Lectura.Ruta & "' and id_region = '" & Lectura.Region & "'")
                Else
                    Exit Sub
                End If
            End If
            Lectura.CreaConsultausuario()
            RecorrePadre()
            TxtLectura.Select()


            CmbRegion.Enabled = False
            CmbRuta.Enabled = False
        Else
            Try
                BtnBuscar.Enabled = False
                CmbRuta.ComboBox.SelectedIndex = CmbRuta.ComboBox.SelectedIndex + 1
                Lectura.Ruta = CmbRuta.ComboBox.SelectedValue.ToString
                Lectura.CreaConsultausuario()
                RecorrePadre()
                TxtLectura.Select()
                BtnBuscar.Enabled = True
            Catch ex As Exception
                MessageBox.Show("Ya no existen mas rutas por capturar para esta region", "Captura de lecturas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BtnBuscar.Enabled = False
                Exit Sub
            End Try


        End If

        GPQuitar.Visible = False

        'BtnBuscar.Enabled = False
        BtnBuscar.Image = My.Resources.agt_forward
        SigRuta = True
    End Sub

    Private Sub BtnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSiguiente.Click
        If TxtLectura.Value = 0 Then
            Lectura.Lectura = 0
        Else
            Lectura.Lectura = Val(TxtLectura.Value)
        End If

        Lectura.Sit_Med = CmbSituacion.Text
        Lectura.Sit_Pad = CmbSituacion2.Text
        Lectura.Sit_Hid = CmbSituacion3.Text
        Lectura.Observacion = TxtObservacion.Text
        Lectura.NumLec = Val(LblNumLec.Text)
        ' Lectura.Fecha = DTMEs.Value
        Select Case Lectura.Capturar
            Case ClsLecturas.RespCaptura.Alerta
                TxtObservacion.Text = ""
                Pasar = False
                TxtLectura.Focus()
                'TxtLectura.SelectAll()
            Case ClsLecturas.RespCaptura.No_Capturado
                TxtLectura.Focus()
                'TxtLectura.SelectAll()
            Case ClsLecturas.RespCaptura.Capturado
                TxtLectura.Value = 0
                CmbSituacion.SelectedIndex = -1
                CmbSituacion2.SelectedIndex = -1
                CmbSituacion3.SelectedIndex = -1
                TxtObservacion.Text = ""
                Pasar = False
                RecorrePadre()
        End Select
        TxtCuenta.Focus()

    End Sub

    Private Sub CmbRegion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbRegion.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub CmbRegion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbRegion.SelectedIndexChanged
        Try
            llenarCombo(CmbRuta, "Select id_ruta, ruta from rutas where id_region = '" & CmbRegion.ComboBox.SelectedValue.ToString & "'  order by id_ruta")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        Lectura.ReiniciarCaptura()
        Buscar()
        TxtLectura.Select()
    End Sub

    Private Sub BtnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnListado.Click
        If Lectura.ConsultaHijo = Nothing Then
            MessageBox.Show("No ha establecido el criterio de busqueda", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        FrmLecturasCapturadas.MdiParent = My.Forms.MDIPrincipal
        FrmLecturasCapturadas.Filtro = Lectura.ConsultaHijo

        FrmLecturasCapturadas.Regi = CmbRegion.ComboBox.SelectedValue.ToString
        FrmLecturasCapturadas.Ruta = CmbRuta.ComboBox.SelectedValue.ToString
        FrmLecturasCapturadas.Fecha = DTMEs.Value
        FrmLecturasCapturadas.Show()
        FrmLecturasCapturadas.WindowState = FormWindowState.Maximized
    End Sub

    

    Private Sub CmbRuta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbRuta.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub CmbLecturistas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbLecturistas.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

  

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        CmbSituacion.SelectedIndex = -1
        CmbSituacion2.SelectedIndex = -1
        CmbSituacion3.SelectedIndex = -1
    End Sub

    Private Sub TxtCuenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCuenta.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCuenta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCuenta.LostFocus
        If TxtCuenta.Text = "" Then Exit Sub
        If TxtCuenta.Text <> Lectura.Cuenta Then
            If Lectura.Buscar(Val(TxtCuenta.Text)) = False Then
                MessageBox.Show("La cuenta no fue localizada", "Captura de lecturas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LblNombre.Text = Lectura.Nombre
                TxtCuenta.Text = Lectura.Cuenta
                txtcuentaanterior.Text = Lectura.Lote
                LblMedidor.Text = Lectura.Medidor
                LblDireccion.Text = Lectura.Direccion
                LblAnterior.Text = Lectura.Lec1
                LblAnterior2.Text = Lectura.Lec2
                LblTarifa.Text = Lectura.Tarifa
                TxtLectura.Value = 0
                LblNumLec.Text = Lectura.NumLec
                Manzana = Lectura.Manzana
                Lote = Lectura.Lote
                BtnSiguiente.Enabled = True
                TxtCuenta.SelectAll()
                Exit Sub
            Else
                LblNombre.Text = Lectura.Nombre
                TxtCuenta.Text = Lectura.Cuenta
                txtcuentaanterior.Text = Lectura.Manzana & "-" & Lectura.Lote
                LblMedidor.Text = Lectura.Medidor
                LblDireccion.Text = Lectura.Direccion
                LblAnterior.Text = Lectura.Lec1
                LblAnterior2.Text = Lectura.Lec2
                LblTarifa.Text = Lectura.Tarifa
                TxtLectura.Value = 0
                LblNumLec.Text = Lectura.NumLec
                Manzana = Lectura.Manzana
                Lote = Lectura.Lote
                BtnSiguiente.Enabled = True
                TxtLectura.Select()
            End If
        Else
            TxtLectura.Select()
        End If
    End Sub



    Private Sub CmbSituacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbSituacion.KeyPress
        Select Case e.KeyChar

            Case vbCrLf
                'SendKeys.Send("{TAB}")
                CmbSituacion.Select()
        End Select
    End Sub

    Private Sub CmbSituacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSituacion.SelectedIndexChanged

        If CmbSituacion.SelectedIndex = -1 Then
            Exit Sub
        End If
        Try
            LblMedicion.Text = CmbSituacion.SelectedValue.ToString
            repite()
        Catch ex As Exception
            LblMedicion.Text = ""
        End Try
    End Sub

    Private Sub CmbSituacion2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbSituacion2.KeyPress
        Select Case e.KeyChar

            Case vbCrLf
                'SendKeys.Send("{TAB}")
                CmbSituacion2.Select()

        End Select
    End Sub

    Private Sub CmbSituacion2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSituacion2.SelectedIndexChanged

        If CmbSituacion2.SelectedIndex = -1 Then
            Exit Sub
        End If
        Try
            LblPadron.Text = CmbSituacion2.SelectedValue.ToString
            repite()
        Catch ex As Exception
            LblPadron.Text = ""
        End Try
    End Sub

    Private Sub CmbSituacion3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbSituacion3.KeyPress
        Select Case e.KeyChar

            Case vbCrLf
                'SendKeys.Send("{TAB}")
                CmbSituacion3.Select()
        End Select
    End Sub

    Private Sub CmbSituacion3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSituacion3.SelectedIndexChanged
        Try
            lblHidro.Text = CmbSituacion3.SelectedValue.ToString
            repite()
        Catch ex As Exception
            lblHidro.Text = ""
        End Try
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Buscar()
    End Sub

    Private Sub FrmCapturaLecturas_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        Linea1.Width = Me.Width
        Linea2.Width = Me.Width
    End Sub

    Private Sub CmbLecturistas_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbLecturistas.LostFocus
        BtnBuscar.Select()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Close()
    End Sub



    Private Sub BtnFaltanteLec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFaltanteLec.Click
        Dim lec As New ClsLecturas
        lec.Ruta = CmbRuta.ComboBox.SelectedValue.ToString

        lec.Region = CmbRegion.ComboBox.SelectedValue.ToString
        Try
            Ejecucion("Delete from repusuario")
            'Ejecucion("Create Table repusuario like select * from  vusuario as v, cuotas as c where v.descripcion_cuota = c.descripcion_cuota and c.medido <> 0 and id_comunidad = '" & _Comunidad & "' and region = '" & _Region & "' and ruta = '" & _Ruta & "' and mostrar = 1 and (cuenta not in (select cuenta from " & lec.Tabla & ")")
            'Ejecucion("Create Table repusuario select * from  vusuario as v, cuotas as c where v.descripcion_cuota = c.descripcion_cuota and c.medido <> 0 and id_comunidad = '" & _Comunidad & "' and region = '" & _Region & "' and ruta = '" & _Ruta & "' and mostrar = 1 and (cuenta not in (select cuenta from " & lec.Tabla & ")")
            Ejecucion("Insert into repusuario select cuenta, nombre, comunidad, colonia, calle, numext, numint, nodemedidor, sector, ruta, lote, manzana, region from vusuario as v, cuotas as c where v.descripcion_cuota = c.descripcion_cuota and c.medido <> 0  and region = '" & CmbRegion.ComboBox.SelectedValue.ToString & "' and ruta = '" & CmbRuta.ComboBox.SelectedValue.ToString & "' and mostrar = 1 and (cuenta not in (select cuenta from " & lec.Tabla & "))")
        Catch ex As Exception
            ' messagebox.Show(ex.Message)
        End Try
        Dim Titulo As String = "'REGION: " & CmbRegion.ComboBox.Text & " RUTA: " & CmbRuta.ComboBox.Text & "'"
        Dim rep As New frmReporte(frmReporte.Lista.LecNoCapturadas, "", "Titulo, " & Titulo)
        rep.MdiParent = MDIPrincipal
        rep.Show()
        rep.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub LblConsumo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblConsumo.TextChanged
        If Val(LblConsumo.Text) < 0 Then
            LblConsumo.ForeColor = Color.Red
        Else
            LblConsumo.ForeColor = Color.Black

        End If

    End Sub


    Private Sub TxtLectura_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLectura.ValueChanged
        If TxtLectura.Value = 0 Then
            LblConsumo.Text = 0
        Else
            LblConsumo.Text = Val(TxtLectura.Value) - Val(LblAnterior2.Text)
        End If
    End Sub

    Private Sub TxtCuenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCuenta.TextChanged

    End Sub

    Private Sub TSPeriodos_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles TSPeriodos.ItemClicked

    End Sub

    Private Sub CmbRegion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbRegion.Click

    End Sub

    Public Sub repite()
        If TxtLectura.Value = 0 And Lectura.Lec2 >= 0 Then
            TxtLectura.Value = Lectura.Lec2
        End If
    End Sub
End Class