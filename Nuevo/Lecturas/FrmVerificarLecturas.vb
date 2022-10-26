Imports DevComponents.DotNetBar

Public Class FrmVerificarLecturas
    Dim Lectura As New ClsLecturas
    Dim Pasar As Boolean, Modificado As Boolean
    Dim NumLec As Integer, Tabla As String, Comu As String, Manzana As String, Lote As String

    Private Sub FrmVerificarLecturas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData

        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub
    Private Sub FrmCapturaLecturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCombo(CmbSituacion, "Select situacion, clave from situacion where tipo = 'Medicion'")
        llenarCombo(CmbSituacion2, "Select situacion ,clave from situacion where tipo = 'Padron'")
        llenarCombo(CmbSituacion3, "Select situacion, clave from situacion where tipo = 'Hidrometro'")
        llenarCombo(CmbComunidad, "Select id_comunidad, Comunidad from comunidades order by comunidad")
        llenarCombo(CmbLecturistas, "Select idtrab, nombre from trabajadores where cod_dep = 'MED'")
        DTMEs.Value = Now
        CmbSituacion.SelectedIndex = -1
        CmbSituacion2.SelectedIndex = -1
        CmbSituacion3.SelectedIndex = -1
        CmbComunidad.ComboBox.Select()
    End Sub

    Private Sub RecorrePadre()
        If Lectura.Avanzar() Then
            LblNombre.Text = Lectura.Nombre
            TxtCuenta.Text = Lectura.Cuenta
            LblEstado.Text = Lectura.Estado
            LblUbicacion.Text = CmbComunidad.Text
            LblMedidor.Text = Lectura.Medidor
            LblDireccion.Text = Lectura.Direccion
            LblAnterior.Text = Lectura.Lec1
            LblAnterior2.Text = Lectura.Lec2
            LblTarifa.Text = Lectura.Tarifa
            LblNumLec.Text = Lectura.NumLec
            Manzana = Lectura.Manzana
            Lote = Lectura.Lote
            Modificado = False
            BtnSiguiente.Enabled = True
        Else
            LblNombre.Text = ""
            TxtCuenta.Text = ""
            LblEstado.Text = ""
            LblUbicacion.Text = ""
            LblMedidor.Text = ""
            LblDireccion.Text = ""
            LblAnterior.Text = ""
            LblAnterior2.Text = ""
            LblTarifa.Text = ""
            LblNumLec.Text = ""
            Manzana = ""
            Lote = ""
            Modificado = False
            BtnSiguiente.Enabled = False
        End If
    End Sub

    Private Sub CmbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBuscar.Click
        Try
            Lectura.Comunidad = CmbComunidad.ComboBox.SelectedValue.ToString
        Catch ex As Exception
            MessageBoxEx.Show("No selecciono la comunidad de las lecturas", "Captura de lecturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        Lectura.Fecha = DTMEs.Value
        Try
            Lectura.Region = CmbRegion.ComboBox.SelectedValue.ToString
        Catch ex As Exception
            MessageBoxEx.Show("No selecciono la Region de las lecturas", "Captura de lecturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        Try
            Lectura.Ruta = CmbRuta.ComboBox.SelectedValue.ToString
        Catch ex As Exception
            MessageBoxEx.Show("No selecciono la Ruta de las lecturas", "Captura de lecturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        Try
            Lectura.Lecturista = CmbLecturistas.ComboBox.SelectedValue.ToString
        Catch ex As Exception
            MessageBoxEx.Show("No selecciono al lecturista que tomo las lecturas", "Captura de lecturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        'Lectura.Periodo = DTPeriodo.Value
        ' Lectura.IniciaVerificacion()
        RecorrePadre()
        TxtLectura.Focus()
    End Sub

    Private Sub CmbSituacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbSituacion.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub CmbComunidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbComunidad.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub CmbSector_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbComunidad.SelectedIndexChanged
        Try
            llenarCombo(CmbRegion, "Select id_region, region from region where id_COMUNIDAD = '" & CmbComunidad.ComboBox.SelectedValue.ToString & "'")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CmbSituacion2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbSituacion2.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub CmbSituacion3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbSituacion3.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub BtnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSiguiente.Click
        Lectura.Lectura = Val(TxtLectura.Text)
        Lectura.Sit_Med = CmbSituacion.Text
        Lectura.Sit_Pad = CmbSituacion2.Text
        Lectura.Sit_Hid = CmbSituacion3.Text
        Lectura.Observacion = TxtObservacion.Text
        'Select Case Lectura.Verificar(Modificado)
        '    Case ClsLecturas.RespCaptura.Alerta
        '        TxtObservacion.Text = ""
        '        Pasar = False
        '    Case ClsLecturas.RespCaptura.No_Capturado
        '        TxtLectura.Focus()
        '        Exit Select
        '    Case ClsLecturas.RespCaptura.Capturado
        '        TxtLectura.Text = ""
        '        CmbSituacion.SelectedIndex = -1
        '        CmbSituacion2.SelectedIndex = -1
        '        CmbSituacion3.SelectedIndex = -1
        '        TxtObservacion.Text = ""
        '        Pasar = False
        'End Select
        CmbSituacion.SelectedIndex = -1
        CmbSituacion2.SelectedIndex = -1
        CmbSituacion3.SelectedIndex = -1
        RecorrePadre()
        TxtLectura.Focus()
    End Sub

    Private Sub CmbRegion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbRegion.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub CmbRegion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbRegion.SelectedIndexChanged
        Try
            llenarCombo(CmbRuta, "Select id_ruta, ruta from rutas where id_region = '" & CmbRegion.ComboBox.SelectedValue.ToString & "'")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnListado.Click
        Dim frm As New FrmLecturasCapturadas
        frm.MdiParent = My.Forms.MDIPrincipal
        frm.Filtro = Lectura.ConsultaHijo
        frm.Comunidad = CmbComunidad.ComboBox.SelectedValue.ToString
        frm.Regi = CmbRegion.ComboBox.SelectedValue.ToString
        frm.Ruta = CmbRuta.ComboBox.SelectedValue.ToString
        frm.Fecha = DTMEs.Value
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Close()
    End Sub

    Private Sub BtnReiniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReiniciar.Click
        Lectura.Comunidad = CmbComunidad.ComboBox.SelectedValue.ToString
        Lectura.Fecha = DTMEs.Value
        Lectura.Region = CmbRegion.ComboBox.SelectedValue.ToString
        Lectura.Ruta = CmbRuta.ComboBox.SelectedValue.ToString
        'Lectura.IniciaVerificacion()
        RecorrePadre()
        TxtLectura.Focus()
    End Sub

    Private Sub CmbRuta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbRuta.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub CmbLecturistas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbLecturistas.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub TxtLectura_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtLectura.LostFocus
        If Lectura.Lectura <> Val(TxtLectura.Text) Then
            Dim dlg As New DlgCambioVerificacion
            dlg.LblActual.Text = TxtLectura.Text
            dlg.LblAntes.Text = Lectura.Lectura
            dlg.ShowDialog()
            If dlg.Respuesta Then
                TxtLectura.Text = Lectura.Lectura
            Else
                Modificado = True
            End If
        End If
    End Sub

    Private Sub CmbSituacion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbSituacion.LostFocus
        If Lectura.Sit_Med <> CmbSituacion.Text Then
            Dim dlg As New DlgCambioVerificacion
            dlg.LblActual.Text = CmbSituacion.Text
            dlg.LblAntes.Text = Lectura.Sit_Med
            dlg.ShowDialog()
            If dlg.Respuesta Then
                CmbSituacion.Text = Lectura.Sit_Med
            Else
                Modificado = True
            End If
        End If
    End Sub

    Private Sub TxtObservacion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtObservacion.LostFocus
        If Lectura.Observacion <> TxtObservacion.Text Then
            Dim dlg As New DlgCambioVerificacion
            dlg.LblActual.Text = TxtObservacion.Text
            dlg.LblAntes.Text = Lectura.Observacion
            dlg.ShowDialog()
            If dlg.Respuesta Then
                TxtObservacion.Text = Lectura.Observacion
            Else
                Modificado = True
            End If
        End If


    End Sub

    Private Sub CmbSituacion2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbSituacion2.LostFocus
        If Lectura.Sit_Pad <> CmbSituacion2.Text Then
            Dim dlg As New DlgCambioVerificacion
            dlg.LblActual.Text = CmbSituacion2.Text
            dlg.LblAntes.Text = Lectura.Sit_Pad
            dlg.ShowDialog()
            If dlg.Respuesta Then
                CmbSituacion2.Text = Lectura.Sit_Pad
            Else
                Modificado = True
            End If
        End If
    End Sub

    Private Sub CmbSituacion3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbSituacion3.LostFocus
        If Lectura.Sit_Hid <> CmbSituacion3.Text Then
            Dim dlg As New DlgCambioVerificacion
            dlg.LblActual.Text = CmbSituacion3.Text
            dlg.LblAntes.Text = Lectura.Sit_Hid
            dlg.ShowDialog()
            If dlg.Respuesta Then
                CmbSituacion3.Text = Lectura.Sit_Hid
            Else
                Modificado = True
            End If
        End If
    End Sub


    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        CmbSituacion.SelectedIndex = -1
        CmbSituacion2.SelectedIndex = -1
        CmbSituacion3.SelectedIndex = -1
    End Sub

    Private Sub TxtCuenta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCuenta.LostFocus
        If TxtCuenta.Text <> Lectura.Cuenta Then
            If Lectura.Buscar(Val(TxtCuenta.Text)) = False Then
                MessageBox.Show("La cuenta no fue localizada", "Captura de lecturas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtCuenta.SelectAll()
            Else
                LblNombre.Text = Lectura.Nombre
                TxtCuenta.Text = Lectura.Cuenta
                LblEstado.Text = Lectura.Estado
                LblUbicacion.Text = CmbComunidad.Text
                LblMedidor.Text = Lectura.Medidor
                LblDireccion.Text = Lectura.Direccion
                LblAnterior.Text = Lectura.Lec1
                LblAnterior2.Text = Lectura.Lec2
                LblTarifa.Text = Lectura.Tarifa
                TxtLectura.Text = ""
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

    Private Sub TxtCuenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCuenta.TextChanged

    End Sub
End Class