Public Class FrmReactivar
    Public Cuenta As Double, Comunidad As String
    Private Sub FrmReactivar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.RTUsuarios.Select()
    End Sub

    Private Sub FrmReactivar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub
    Private Sub FrmReactivar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cons As IDataReader = ConsultaSql("Select * from vusuario where cuenta = " & Cuenta & " and comunidad = '" & Comunidad & "' ").ExecuteReader
        cons.Read()
        LblCuenta.Text = Cuenta
        LblComunidad.Text = Comunidad
        LblNombre.Text = cons("nombre")
        LblEstadoActual.Text = UCase(cons("estado"))
        LblDireccion.Text = cons("colonia") & "   " & cons("calle") & "  " & cons("numext") & "  " & cons("numint")
        LblGiro.Text = cons("giro")
        LblTarifa.Text = cons("descripcion_cuota")
    End Sub
    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If TxtMotivo.Text = "" Then
            MsgBox("No ha introducido el motivo del cambio de estado", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        Dim num As Double = Val(obtenerCampo("Select max(clave) as mayor from reactivaciones", "mayor")) + 1
        Dim Com As String = obtenerCampo("Select id_comunidad from comunidades where comunidad = '" & Comunidad & "'", "id_comunidad")
        Dim EAntes As Integer = Val(obtenerCampo("Select clave from estadotoma where descripcion = '" & LblEstadoActual.Text & "'", "clave"))
        Ejecucion("update usuario set estado = 1 Where  cuenta=" & Cuenta)
        Ejecucion("insert into reactivaciones(clave, cuenta, id_comunidad, estadoAnterior, motivo, fechacambio, Usuario) values(" & num & ", " & Cuenta & ", '" & Com & "', " & EAntes & ", '" & TxtMotivo.Text & "', '" & UnixDateFormat(Now) & "', " & NumUser & " )")
        BtnAceptar.Enabled = False
        frmBusUsuario.Actualizar()
        Close()
    End Sub
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Close()
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

End Class