Imports DevComponents.DotNetBar

Public Class FrmDarDeBaja
    Public Cuenta As Double, Comunidad As String
    Dim clave As Double = 0
    Private Sub FrmDarDeBaja_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.RTUsuarios.Select()
    End Sub

    Private Sub FrmDarDeBaja_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub
    Private Sub FrmCambiarEstado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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



        Dim nombre_Host As String = Net.Dns.GetHostName()
        Dim este_Host As Net.IPHostEntry = Net.Dns.GetHostEntry(nombre_Host)
        Dim direccion_Ip As String = este_Host.AddressList(0).ToString

        Try
            Ejecucion("insert into bitacora(fecha,hora,evento,cuenta,usuario,concepto,maquina,motivo) values(" & UnixDateFormat(Now.Date, True, False) & ",'" & Now.ToShortTimeString() & "','Bitacora'," & Cuenta & "," & NumUser & ",'BAJA','" & direccion_Ip & "','" & TxtMotivo.Text & "')")

            '  MessageBoxEx.Show("Registro realizado satisfactoriamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'ButtonX1.Enabled = True

            'frmBusUsuario.filtro(frmBusUsuario._sqlgeneral)
            BtnAceptar.Enabled = False
        Catch ex As Exception

        End Try


        Dim num As Double = Val(obtenerCampo("Select max(clave) as mayor from bajas", "mayor")) + 1
        clave = num
        Dim Com As String = obtenerCampo("Select id_comunidad from comunidades where comunidad = '" & Comunidad & "'", "id_comunidad")
        Dim EAntes As Integer = Val(obtenerCampo("Select clave from estadotoma where descripcion = '" & LblEstadoActual.Text & "'", "clave"))
        BtnAceptar.Enabled = False
        Ejecucion("update usuario set estado = 2 Where  cuenta=" & Cuenta)
        Ejecucion("insert into bajas(clave, cuenta, id_comunidad, estadoAnterior, motivo, fechacambio, Usuario) values(" & num & ", " & Cuenta & ", '" & Com & "', " & EAntes & ", '" & TxtMotivo.Text & "', '" & UnixDateFormat(Now) & "', " & NumUser & " )")
        ButtonX1.Enabled = True
        frmBusUsuario.filtro(frmBusUsuario._sqlgeneral)
        MessageBoxEx.Show("El estado del usuario ha cambiado exitosamente", "Baja temporal", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'frmBusUsuario.Actualizar()
        'Close()
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

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim baja As New FormatoBaja
        baja.GenerarFpormatobaja(Cuenta, "Original", TxtMotivo.Text, "temporal")

    End Sub


    Protected Overrides Sub Finalize()
        BtnAceptar.Enabled = True
        TxtMotivo.Text = True
        MyBase.Finalize()
    End Sub
End Class