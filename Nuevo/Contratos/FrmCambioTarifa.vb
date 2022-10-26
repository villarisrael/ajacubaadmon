Public Class FrmCambioTarifa
    Public Cuenta As Double, Comunidad As String

    Private Sub FrmCambioTarifa_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.RTUsuarios.Select()
    End Sub

    Private Sub FrmCambioTarifa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub
    Private Sub FrmCambioTarifa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCombo(cmbtipouso, "descripcion", "select descripcion from tipos_usuarios")

        Dim cons As IDataReader = ConsultaSql("Select * from vusuario where cuenta = " & Cuenta & " and comunidad = '" & Comunidad & "' ").ExecuteReader
        cons.Read()
        LblCuenta.Text = Cuenta
        LblComunidad.Text = Comunidad
        LblNombre.Text = cons("nombre")
        LblEstadoActual.Text = UCase(cons("estado"))
        LblDireccion.Text = cons("Direccion")
        LblGiro.Text = cons("giro")
        LblTarifa.Text = cons("descripcion_cuota")
        LblTarifaAntes.Text = cons("descripcion_cuota")
        LblTipo.Text = cons("tipousu")
    End Sub

    Private Sub cmbtipouso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbtipouso.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub cmbtipouso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtipouso.SelectedIndexChanged
        cmbtarifa.Items.Clear()
        llenarCombo(cmbtarifa, "descripcion_cuota", "select descripcion_cuota from cuotas where paraUso='" & obtenerCampo("select id_tipo_usuario from tipos_usuarios where descripcion='" & cmbtipouso.SelectedItem & "'", "id_tipo_usuario") & "' order by descripcion_cuota")
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Dim IdTarifa As String, TipUsuario As String, TarAntes As String, TipAntes As String

        'Si el contrato tiene adeudo no se podra cambiar la tarifa hasta que se liquide el adeudo corriente

        'Dim adeudoCorriente As Double = Val(obtenerCampo("Select Total as Total from Usuario where cuenta = " & Cuenta, "Total"))

        'If adeudoCorriente > 0 Then
        '    MessageBox.Show("NO ES POSIBLE REALIZAR EL CAMBIO DE TÁRIFA, PRIMERO SE TIENE QUE LIQUIDAR EL ADEUDO CORRIENTE")

        '    Me.Close()

        'Else



        If cmbtipouso.Text = "" Then
                MsgBox("No ha seleccionado el tipo de uso", MsgBoxStyle.Information, "")
                Exit Sub
            End If
            If cmbtarifa.Text = "" Then
                MsgBox("No ha seleccionado la tarifa", MsgBoxStyle.Information, "")
                Exit Sub
            End If
            TipUsuario = obtenerCampo("select id_tipo_usuario from tipos_usuarios where descripcion = '" & cmbtipouso.Text & "'", "id_tipo_usuario")
            If TipUsuario = "0" Then
                MsgBox("No elegiste un tipo de usuario correcto")
                Exit Sub
            End If
            IdTarifa = obtenerCampo("select ID_TARIFA FROM cuotas WHERE DESCRIPCION_CUOTA='" & cmbtarifa.Text & "'", "ID_TARIFA")
            If IdTarifa = "0" Then
                MsgBox("Es importante elegir una tarifa correctamente")
                Exit Sub
            End If

            TipAntes = obtenerCampo("select id_tipo_usuario from tipos_usuarios where descripcion = '" & LblTipo.Text & "'", "id_tipo_usuario")
            TarAntes = obtenerCampo("select ID_TARIFA FROM cuotas WHERE DESCRIPCION_CUOTA='" & LblTarifaAntes.Text & "'", "ID_TARIFA")
            Dim num As Double = Val(obtenerCampo("Select max(clave) as mayor from cambiotarifa", "mayor")) + 1
            Dim Com As String = obtenerCampo("Select id_comunidad from comunidades where comunidad = '" & Comunidad & "'", "id_comunidad")

            BtnAceptar.Enabled = False
            Ejecucion("update usuario set tarifa='" & IdTarifa & "',id_tipo_usuario='" & TipUsuario & "' where cuenta = " & Cuenta)
            Ejecucion("insert into cambiotarifa (clave, cuenta, comunidad, antestipo, antestarifa, tipo, tarifa, fecha, observacion, usuario) values (" & num & ", " & Cuenta & ", '" & Com & "','" & TipAntes & "','" & TarAntes & "', '" & TipUsuario & "', '" & IdTarifa & "', '" & UnixDateFormat(Now) & "','" & TxtMotivo.Text & "', " & NumUser & "  )")



            Dim nombre_Host As String = Net.Dns.GetHostName()
            Dim este_Host As Net.IPHostEntry = Net.Dns.GetHostEntry(nombre_Host)
            Dim direccion_Ip As String = este_Host.AddressList(0).ToString

            Try
                Ejecucion("insert into bitacora(fecha,hora,evento,cuenta,usuario,concepto,maquina,motivo) values(" & UnixDateFormat(Now.Date, True, False) & ",'" & Now.ToShortTimeString() & "','Cambio Tarifa'," & Cuenta & "," & NumUser & ",'Nueva Tarifa: " & IdTarifa & "','" & direccion_Ip & "','" & TxtMotivo.Text & "')")

                ' MessageBoxEx.Show("Registro realizado satisfactoriamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'ButtonX1.Enabled = True

                'frmBusUsuario.filtro(frmBusUsuario._sqlgeneral)
                '  BtnAceptar.Enabled = False
            Catch ex As Exception
                MessageBox.Show("Ocurrio un error al registar en la bitacora: " & ex.ToString())
            End Try

            MsgBox("Cambio de tarifa realizada satisfactoriamente", MsgBoxStyle.Information, "")
            ButtonX1.Enabled = True
            cmdGenCob.Enabled = True
            BtnAceptar.Enabled = False

        'End If

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim frm As New FrmTipoImprContrato(Cuenta, Comunidad)
        frm.CambioNombre = FrmTipoImprContrato.Posibilidades.Cambio_Tarifa
        frm.Show()
    End Sub

    Private Sub cmdGenCob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenCob.Click
        Dim frm As New frmagrmov(eve.CambioTarifa, Val(LblCuenta.Text), LblNombre.Text, LblComunidad.Text)
        frm.ShowDialog()
    End Sub

    Private Sub BtnCancelar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancelar.GotFocus
        BtnCancelar.Pulse()
        BtnCancelar.StopPulseOnMouseOver = False
    End Sub

    Private Sub BtnCancelar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancelar.LostFocus
        BtnCancelar.StopPulse()
    End Sub

    Private Sub BtnAceptar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAceptar.GotFocus
        BtnAceptar.Pulse()
        BtnAceptar.StopPulseOnMouseOver = False
    End Sub

    Private Sub BtnAceptar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAceptar.LostFocus
        BtnAceptar.StopPulse()
    End Sub

    Private Sub ButtonX1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonX1.GotFocus
        ButtonX1.Pulse()
        ButtonX1.StopPulseOnMouseOver = False
    End Sub

    Private Sub ButtonX1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonX1.LostFocus
        ButtonX1.StopPulse()
    End Sub

    Private Sub cmdGenCob_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdGenCob.GotFocus
        cmdGenCob.Pulse()
        cmdGenCob.StopPulseOnMouseOver = False
    End Sub

    Private Sub cmdGenCob_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdGenCob.LostFocus
        cmdGenCob.StopPulse()
    End Sub

    Private Sub cmbtarifa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbtarifa.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

End Class