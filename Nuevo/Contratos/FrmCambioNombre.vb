Imports DevComponents.DotNetBar

Public Class FrmCambioNombre
    Public Cuenta As Double, Comunidad As String

    Private Sub FrmCambioNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.RTUsuarios.Select()
    End Sub

    Private Sub FrmCambioNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData

        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub
    Private Sub FrmCambioNombre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cons As IDataReader = ConsultaSql("Select * from vusuario where cuenta = " & Cuenta & " and comunidad = '" & Comunidad & "' ").ExecuteReader
        cons.Read()
        LblCuenta.Text = Cuenta
        LblComunidad.Text = Comunidad
        LblNombre.Text = cons("nombre")
        LblEstadoActual.Text = UCase(cons("estado"))
        LblDireccion.Text = cons("Direccion")
        LblGiro.Text = cons("giro")
        LblTarifa.Text = cons("descripcion_cuota")
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If TxtNuevoNombre.Text = "" Then
            MessageBoxEx.Show("No ha introducido el nombre de usuario", "Nombre", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim num As String = Val(obtenerCampo("Select max(clave) as mayor from cambionombre", "mayor")) + 1
        Dim Com As String = obtenerCampo("Select id_comunidad from comunidades where comunidad = '" & Comunidad & "'", "id_comunidad")

        Ejecucion("update usuario set nombre = '" & TxtNuevoNombre.Text & "' where cuenta = " & Cuenta)
        Ejecucion("insert into cambionombre (clave, cuenta, comunidad, nombreantes, nombre, fecha, observacion, usuario) values (" & num & ", " & Cuenta & ", '" & Com & "','" & LblNombre.Text & "','" & TxtNuevoNombre.Text & "', '" & UnixDateFormat(Now) & "','" & TxtMotivo.Text & "', " & NumUser & "  )")

        Dim nombre_Host As String = Net.Dns.GetHostName()
        Dim este_Host As Net.IPHostEntry = Net.Dns.GetHostEntry(nombre_Host)
        Dim direccion_Ip As String = este_Host.AddressList(0).ToString


        Try
            Ejecucion("insert into bitacora(fecha,hora,evento,cuenta,usuario,concepto,maquina,motivo) values(" & UnixDateFormat(Now.Date, True, False) & ",'" & Now.ToShortTimeString() & "','Cambio Nombre '," & Cuenta & "," & NumUser & ",'Cambio Nombre Antes : " & LblNombre.Text & " ahora " & TxtNuevoNombre.Text & "','" & direccion_Ip & "','" & TxtMotivo.Text & "')")

            ' MessageBoxEx.Show("Registro realizado satisfactoriamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'ButtonX1.Enabled = True

            'frmBusUsuario.filtro(frmBusUsuario._sqlgeneral)
            BtnAceptar.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al registar en la bitacora: " & ex.ToString())
        End Try


        MessageBoxEx.Show("Cambio de nombre realizado satisfactoriamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'ButtonX1.Enabled = True
        cmdGenCob.Enabled = True
        frmBusUsuario.filtro(frmBusUsuario._sqlgeneral)
        BtnAceptar.Enabled = False
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim frm As New FrmTipoImprContrato(Cuenta, Comunidad)
        frm.CambioNombre = FrmTipoImprContrato.Posibilidades.Cambio_Nombre
        frm.Show()
    End Sub

    Private Sub cmdGenCob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenCob.Click
        Dim frm As New frmagrmov(eve.CambioNombre, Val(LblCuenta.Text), TxtNuevoNombre.Text, LblComunidad.Text)
        frm.ShowDialog()
        If frm.Cancelado Then
            cmdGenCob.Text = "Cobro generado"
            cmdGenCob.Enabled = False
        End If

    End Sub

    Private Sub BtnAceptar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAceptar.GotFocus
        BtnAceptar.Pulse()
        BtnAceptar.StopPulseOnMouseOver = False
    End Sub

    Private Sub BtnAceptar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAceptar.LostFocus
        BtnAceptar.StopPulse()
    End Sub

    Private Sub BtnCancelar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancelar.GotFocus
        BtnCancelar.Pulse()
        BtnCancelar.StopPulseOnMouseOver = False
    End Sub

    Private Sub BtnCancelar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancelar.LostFocus
        BtnCancelar.StopPulse()
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
End Class