Public Class frmelaboracierre

    Private Sub frmelaboracierre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.tabFacturacion.Select()
    End Sub
    Private Sub frmelaboracierre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim KEYASCII As Keys = e.KeyData
        Select Case KEYASCII
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub
    Private Sub frmelaboracierre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            llenarCombo(CmbComunidad, "Select id_comunidad, comunidad from comunidades")
        Catch ex As Exception

        End Try
        'Txtmensaje.Text = Realizado este proceso no se podrán realizar cambios sobre los datos en el periodo" & _
        fecini.Value = Now
        fec_vto.Value = DiasHabiles(Now, 25)
        DTPeriodo.Value = Now
    End Sub



    Private Sub BtnAceptar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If CmbComunidad.Text = "" Then
            MessageBoxEx.Show("No especificaste la Comunidad", "Aplicación de lecturas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CmbComunidad.Select()
            Exit Sub
        End If
        If CmdRegion.Text = "" Then
            MessageBoxEx.Show("No especificaste la Region", "Aplicación de lecturas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CmdRegion.Select()
            Exit Sub
        End If


        BtnAceptar.Enabled = False
        BtnSalir.Enabled = False
        CmbComunidad.Enabled = False
        CmdRegion.Enabled = False
        fecini.Enabled = False
        fec_vto.Enabled = False
        DTPeriodo.Enabled = False

        Dim Lectura As New ClsLecturas
        Lectura.Comunidad = CmbComunidad.SelectedValue.ToString
        Lectura.Region = CmdRegion.SelectedValue.ToString

        Dim datos As IDataReader, Ultimo As Date
        Try
            datos = ConsultaSql("SELECT Clave FROM cierre WHERE ID_COMUNIDAD='" & Lectura.Comunidad & "' AND ID_REGION='" & Lectura.Region & "'  and mes='" & MonthName(DTPeriodo.Value.Month, True) & "' and anio=" & DTPeriodo.Value.Year & "  ").ExecuteReader
            If datos.Read() Then
                MessageBoxEx.Show("Este periodo ya se realizo el cierre, por lo que no se puede realizar nuevamente", "Cierre de Mes", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                GoTo Salir
            End If
        Catch ex As Exception
            GoTo Salir
        End Try
        Lectura.Periodo = DTPeriodo.Value

        Try
            datos = ConsultaSql("select mes, anio from cierre WHERE ID_COMUNIDAD='" & CmbComunidad.SelectedValue & "' AND ID_REGION='" & CmdRegion.SelectedValue.ToString & "'  order by valornummes(mes, anio)  desc").ExecuteReader
            If datos.Read Then
                Ultimo = CDate("01/" & datos("mes") & "/" & datos("anio"))
                If Ultimo >= DTPeriodo.Value Then
                    MessageBoxEx.Show("No se puede realizar el cierre para ese mes, dado que existe un cierre para un mes mas reciente , el ultimo cierre es de " & datos("mes") & " " & datos("anio"), "Cierre de mes", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    GoTo Salir
                End If
                Ultimo = DateAdd(DateInterval.Month, 1, Ultimo)
                Ultimo = CDate("01/" & Ultimo.Month & "/" & Ultimo.Year)
                DTPeriodo.Value = CDate("01/" & DTPeriodo.Value.Month & "/" & DTPeriodo.Value.Year)
                If DTPeriodo.Value > Ultimo Then
                    If MessageBoxEx.Show("No se puede realizar el cierre para ese mes, dado que el periodo no corresponde, el ultimo cierre es de " & datos("mes") & " " & datos("anio") & vbCrLf & "¿Desea realizar de todas formas el cierre para este mes? ", "Cierre de mes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                        GoTo Salir
                    End If
                End If
            Else
                'si la tabla cierre esta en blanco preguntar
                If MessageBoxEx.Show("El cierre anterior a este periodo no corresponde desea continuar", "Cierre de mes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    GoTo Salir
                End If
            End If

        Catch ex As Exception

        End Try
        Lblespere.Visible = True
        Lblespere.Text = "Aplicando las lecturas al historial del usuario..."

        If Lectura.AplicarLectura(ProgressBarcierre1) = False Then
            'MessageBoxEx.Show("No se pudieron aplicar las lecturas al historial del usuario", "Cierre de Mes", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Lblespere.Visible = False
            GoTo Salir
        End If
        Lblespere.Visible = False

        Dim x As New classcierre
        Dim valida As Integer

        x.comunidad = CmbComunidad.SelectedValue.ToString
        x.region = CmdRegion.SelectedValue.ToString
        x.fecini = fecini.Value
        x.fecvto = fec_vto.Value
        x.mes = DTPeriodo.Value

        Lblespere.Text = "Validando la creación del cierre..."
        Lblespere.Visible = True

        valida = x.crearcierreporregion()
        Application.DoEvents()
        If valida = 1 Then
            Lblespere.Visible = False
            GoTo Salir
        End If

        Lblespere.Text = "Cargando las lecturas de usuarios medidos..."
        x.aplicalecturas()
        Application.DoEvents()
        Lblespere.Text = "Cargando los usuarios fijos..."
        x.cargafijos()
        Application.DoEvents()
        Lblespere.Text = "Elaborando el cierre..."
        x.CIERRA(ProgressBarcierre1)
        Application.DoEvents()
        Lblespere.Text = "Grabando datos del cierre..."
        x.GRABADATO()
        Application.DoEvents()

        Ejecucion("update rutas set Tomalec = 'N', Captura ='N', Calculo = 'N', Aplicacion = 'N', Cierre= 'N' where id_comunidad = '" & x.comunidad & "' and id_region = '" & x.region & "'")
        MessageBoxEx.Show("Se ha terminado el proceso de cierre", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

Salir:
        Lblespere.Visible = False
        BtnAceptar.Enabled = True
        BtnSalir.Enabled = True
        CmbComunidad.Enabled = True
        CmdRegion.Enabled = True
        fecini.Enabled = True
        fec_vto.Enabled = True
        DTPeriodo.Enabled = True
    End Sub

    Private Sub CmbComunidad_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbComunidad.SelectedIndexChanged
        Try
            llenarCombo(CmdRegion, "select id_region, region from region where id_comunidad = '" & CmbComunidad.SelectedValue.ToString & "' order by region")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub fecini_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles fecini.LostFocus
        fec_vto.MinDate = DiasHabiles(fecini.Value, 1)
        fec_vto.Value = DiasHabiles(fecini.Value, 25)
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub fecini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecini.Click

    End Sub

    Private Sub Lblespere_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lblespere.Click

    End Sub
End Class