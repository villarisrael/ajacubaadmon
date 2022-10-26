Imports DevComponents.DotNetBar

Public Class FrmRepCalculoConsumo
    Private cargo As Boolean = False

    Private Sub CmbComunidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.KeyChar = UCase(e.KeyChar)
    End Sub
    Private Sub CmbComunidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

        Catch ex As Exception
        End Try
    End Sub

    Private Sub CmdRegion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmdRegion.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub CmdRegion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdRegion.SelectedIndexChanged
        Try
            llenarCombo(CmbRuta, "select id_ruta, ruta from rutas where id_region = '" & CmdRegion.SelectedValue.ToString & "'  order by ruta")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FrmRepCalculoConsumo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.tabFacturacion.Select()
    End Sub

    Private Sub FrmRepLecturasCapturadas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub FrmRepLecturasCapturadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtAn.Text = Year(Now)
        cargo = False
        llenarCombo(CmdRegion, "select id_region, region from region order by region")

        cargo = True

        'MCMes.SelectedDate = Now
        'MCMes.DisplayMonth = Now

    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub BtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimir.Click
        Dim Filtro As String = ""

        If CmdRegion.SelectedIndex < 0 Then
            MessageBoxEx.Show("No especificaste la Región", "Lecturas Capturadas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CmdRegion.Select()
            Exit Sub
        End If

        If CmbRuta.SelectedIndex < 0 Then
            MessageBoxEx.Show("No especificaste la Región", "Lecturas Capturadas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CmbRuta.Select()
            Exit Sub
        End If

        If Not cmbTarifa.SelectedIndex < 0 Then
            Filtro &= "{vusuario1.tarifa}='" & cmbTarifa.SelectedValue.ToString & "' and"
        End If

        If cmbmes.Text = "" Then
            MessageBoxEx.Show("No especificaste el Mes", "Reporte de calculo de consumos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbmes.Select()
            Exit Sub
        End If

        If txtAn.Text = "" Then
            MessageBoxEx.Show("No especificaste el Año", "Reporte de calculo de consumos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAn.Select()
            Exit Sub
        End If


        'If NGobierno.Value > 0 Then
        '    Filtro &= "( {cuotas1.parauso} = 'GOB' and {tmplecturas1.montoconsumo} >= " & NGobierno.Value & " ) or "
        'End If

        If NPublico.Value > 0 Then
            Filtro = Filtro & " ( {cuotas1.parauso} = '4' and {tmplecturas1.montocobrado} >= " & NPublico.Value & " ) or "
        End If
        If NIndustrial.Value > 0 Then
            Filtro = Filtro & " ( {cuotas1.parauso} = '3' and {tmplecturas1.montocobrado} >= " & NIndustrial.Value & " ) or "
        End If
        If NDomestico.Value > 0 Then
            Filtro = Filtro & " ( {cuotas1.parauso} = '1' and {tmplecturas1.montocobrado} >= " & NDomestico.Value & " ) or "
        End If
        If NComercial.Value > 0 Then
            Filtro = Filtro & " ( {cuotas1.parauso} = '2' and {tmplecturas1.montocobrado} >= " & NComercial.Value & " ) or "
        End If
        'If NEspeciales.Value > 0 Then
        '    Filtro = Filtro & " ( {cuotas1.parauso} = 'ESP' and {tmplecturas1.montoconsumo} >= " & NEspeciales.Value & " ) or "
        'End If
        If Filtro.Length > 0 Then
            Filtro = Mid(Filtro, 1, Filtro.Length - 4)
        End If



        BtnImprimir.Enabled = False
        BtnSalir.Enabled = False
        Dim Lectura As New ClsLecturas

        Lectura.Region = CmdRegion.SelectedValue.ToString
        Try
            Lectura.Ruta = CmbRuta.SelectedValue.ToString
        Catch ex As Exception
            Lectura.Ruta = ""
        End Try

        Dim Encabezado As String = "'    Region: " & CmdRegion.Text & " RUTA : " & CmbRuta.Text & "'"

        Ejecucion("delete from tmpreplecturas")

        Try
            Ejecucion("Insert into tmpreplecturas (`Cuenta`,`comunidad`,`Region`,`Ruta`,`Manzana`,`Lote`,`Lecturista`,`LectAnt`,`Lectura`,`Sit_Med`,`Sit_Pad`,`Sit_Hid`,`Ope_Cap`,`Fec_Cap`, `Consumo`,consumocobrado,`NumLec`, tarifa, monto, montocobrado)  select l.cuenta,v.id_comunidad,v.region,v.ruta,v.manzana,v.lote,l.lecturista,l.lectant,l.lectura,l.sit_med,l.sit_pad,l.sit_hid,l.ope_cap,l.fec_cap,l.consumo,l.consumocobrado,l.numlec, v.tarifa, l.monto, l.montocobrado from lecturas l, vusuario v  where l.cuenta=v.cuenta and v.region='" + CmdRegion.SelectedValue + "'" & " and l.ruta='" + CmbRuta.SelectedValue + "'   and l.mes ='" + cmbmes.Text + "'and l.an_per=" + txtAn.Text + "")
        Catch ex As Exception
            MessageBoxEx.Show("Error al leer lecturas", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        Dim rpt As New frmReporte(frmReporte.Lista.CalculoConsumo, Filtro, "Encabezado, " & Encabezado)
        rpt.MdiParent = My.Forms.MDIPrincipal
        rpt.Show()
        rpt.WindowState = FormWindowState.Maximized

        BtnImprimir.Enabled = True
        BtnSalir.Enabled = True

    End Sub

    Private Sub cmbTipUsu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.KeyChar = UCase(e.KeyChar)
    End Sub



    Private Sub cmbTarifa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTarifa.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub CmbRuta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbRuta.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

End Class