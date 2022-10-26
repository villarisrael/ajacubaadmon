Imports DevComponents.DotNetBar

Public Class FrmActivarCuenta
    Public Cuenta As Double, Comunidad As String
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Dim num1 As Double = 0

        If MessageBoxEx.Show("¿Desea Activar esta cuenta?", "Activación de cuenta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim num As Double = Val(obtenerCampo("Select max(clave) as mayor from activaciones", "mayor")) + 1
            Dim Com As String = obtenerCampo("Select id_comunidad from comunidades where comunidad = '" & Comunidad & "'", "id_comunidad")
            Dim EAntes As Integer = Val(obtenerCampo("Select clave from estadotoma where descripcion = '" & LblEstadoActual.Text & "'", "clave"))
            Try
                Ejecucion("update usuario set estado = 1 Where   cuenta=" & Cuenta)
                Ejecucion("insert into activaciones(clave, cuenta, id_comunidad, estadoAnterior, motivo, fechacambio, Usuario) values(" & num & ", " & Cuenta & ", '" & Com & "', " & EAntes & ", '" & TxtMotivo.Text & "', '" & UnixDateFormat(Now) & "', " & NumUser & " )")
            Catch ex As Exception

            End Try

            Try
                num1 = obtenerCampo("select max(clave) + 1  as num from cambioestado", "num")
            Catch ex As Exception
                num1 = 1
            End Try

            Ejecucion("insert into cambioestado values(" & num1 & "," & Cuenta & ",'" & obtenerCampo("select id_comunidad from comunidades where comunidad='" & Comunidad & "'", "id_comunidad") & "',1,'ACTIVACIÓN DE CUENTA','" & UnixDateFormat(Now) & "'," & NumUser & ")")

            MessageBoxEx.Show("Cuenta activada satisfactoriamente", "Activación de cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmBusUsuario.filtro(frmBusUsuario._sqlgeneral)
            Close()
        End If
    End Sub

    Private Sub FrmActivarCuenta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.RTUsuarios.Select()
    End Sub

    Private Sub FrmActivarCuenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub


    Private Sub FrmActivarCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cons As IDataReader = ConsultaSql("Select * from vusuario where cuenta = " & Cuenta & " and comunidad = '" & Comunidad & "' ").ExecuteReader
        Dim datac As IDataReader = ConsultaSql("select * from activaciones where cuenta=" & Cuenta & " and id_comunidad='" & obtenerCampo("select id_comunidad from comunidades where comunidad='" & Comunidad & "'", "id_comunidad") & "' ").ExecuteReader()

        cons.Read()
        If datac.Read() Then
            TxtMotivo.Text = datac("motivo")
            MCFecha.DisplayMonth = CDate(datac("fechacambio"))
            MCFecha.SelectedDate = CDate(datac("fechacambio"))
        Else
            TxtMotivo.Text = ""


            MCFecha.DisplayMonth = Now
        End If
        LblCuenta.Text = Cuenta
        LblComunidad.Text = Comunidad
        LblNombre.Text = cons("nombre")
        LblEstadoActual.Text = UCase(cons("estado"))
        LblDireccion.Text = cons("colonia") & "   " & cons("domicilio") & "  " & cons("numext") & "  " & cons("numint")
        LblGiro.Text = cons("giro")

        LblTarifa.Text = cons("descripcion_cuota")
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
End Class