Imports DevComponents.DotNetBar

Public Class FrmBajaDefinitiva
    Public Cuenta As Double, Comunidad As String
    Dim clave As Double = 0



    Private Sub FrmBajaDefinitiva_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.RTUsuarios.Select()
    End Sub

    Private Sub FrmBajaDefinitiva_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub FrmBajaDefinitiva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cons As IDataReader = ConsultaSql("Select * from vusuario where cuenta = " & Cuenta & " and comunidad = '" & Comunidad & "' ").ExecuteReader
        cons.Read()
        LblCuenta.Text = Cuenta
        LblComunidad.Text = Comunidad
        LblNombre.Text = cons("nombre")
        LblEstadoActual.Text = UCase(cons("estado"))
        LblDireccion.Text = cons("Direccion")
        LblGiro.Text = cons("giro")
        LblTarifa.Text = cons("descripcion_cuota")
        BtnAceptar.Enabled = True
        TxtMotivo.Text = ""
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If TxtMotivo.Text = "" Then
            MsgBox("No ha introducido el motivo del cambio de estado", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        If MessageBoxEx.Show("¿Esta seguro que desea dar de baja la cuenta definitivamente?", "Baja Definitiva", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim num As Double = Val(obtenerCampo("Select max(clave) as mayor from bajas", "mayor")) + 1
            clave = num
            Dim Com As String = obtenerCampo("Select id_comunidad from comunidades where comunidad = '" & Comunidad & "'", "id_comunidad")
            Dim EAntes As Integer = Val(obtenerCampo("Select clave from estadotoma where descripcion = '" & LblEstadoActual.Text & "'", "clave"))
            Dim numEst As Double = Val(obtenerCampo("Select max(clave) as mayor from cambioestado", "mayor")) + 1

            Ejecucion("update usuario set estado = 4 Where   cuenta=" & Cuenta)
            Ejecucion("insert into bajas(clave, cuenta, id_comunidad, estadoAnterior, motivo, fechacambio, Usuario) values(" & num & ", " & Cuenta & ", '" & Com & "', " & EAntes & ", '" & TxtMotivo.Text & "', '" & UnixDateFormat(Now) & "', " & NumUser & " )")
            Ejecucion("insert into cambioestado(clave, cuenta, id_comunidad, motivo, fechacambio, Usuario,estado) values(" & numEst & ", " & Cuenta & ", '" & Com & "', '" & TxtMotivo.Text & "', '" & UnixDateFormat(Now) & "', " & NumUser & ",4)")
            ButtonX1.Enabled = True
            BtnAceptar.Enabled = False
            frmBusUsuario.filtro(frmBusUsuario._sqlgeneral)
            MessageBoxEx.Show("El estado del usuario ha cambiado exitosamente", "Baja Definitiva", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Close()
        End If
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

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim frmrep As New frmReporte(frmReporte.Lista.repBajaDefinitiva, "{vusuario1.cuenta}=" & Cuenta & " and {vusuario1.comunidad}='" & Comunidad & "' and {bajas1.clave}=" & clave & "")
        frmrep.MdiParent = MDIPrincipal
        frmrep.Show()
        frmrep.WindowState = FormWindowState.Maximized
        Me.Close()
    End Sub

    Private Sub ButtonX1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonX1.GotFocus
        ButtonX1.Pulse()
        ButtonX1.StopPulseOnMouseOver = False
    End Sub

    Private Sub ButtonX1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonX1.LostFocus
        ButtonX1.StopPulse()
    End Sub

    Protected Overrides Sub Finalize()
        BtnAceptar.Enabled = True
        TxtMotivo.Text = True
        MyBase.Finalize()
    End Sub
End Class