Imports CrystalDecisions.CrystalReports.Engine
Imports DevComponents.DotNetBar

Public Class frmRepLecturasCapturadas



    Private Sub CmdRegion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbRegion.SelectedIndexChanged
        Try
            llenarCombo(CmbRuta, "select id_ruta, ruta from rutas where id_region = '" & CmbRegion.SelectedValue.ToString & "'  order by ruta")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FrmRepLecturasCapturadas_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
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
        'MCMes.SelectedDate = Now
        'MCMes.DisplayMonth = Now
        Try
            llenarCombo(CmbRegion, "select id_region, region from region  order by region")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub BtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimir.Click

        If CmbRegion.SelectedIndex < 0 Then
            MessageBoxEx.Show("No especificaste la Región", "Reporte de Toma de lecturas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CmbRegion.Select()
            Exit Sub
        End If

        If CmbRuta.SelectedIndex < 0 Then
            MessageBoxEx.Show("No especificaste una ruta", "Reporte de Toma de lecturas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CmbRuta.Select()
            Exit Sub
        End If

        If cmbmes.Text = "" Then
            MessageBoxEx.Show("No especificaste el Mes", "Reporte de Toma de lecturas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbmes.Select()
            Exit Sub
        End If

        If txtAn.Text = "" Then
            MessageBoxEx.Show("No especificaste el Año", "Reporte de Toma de lecturas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAn.Select()
            Exit Sub
        End If



        CmbRegion.Enabled = False
        cmbmes.Enabled = False


        CmbRuta.Enabled = False
        'BtnSalir.Enabled = False
        BtnImprimir.Enabled = False
        LblEspera.Text = "Espere un momento por favor, se esta generando el reporte"
        LblEspera.Visible = True


        Dim Encabezado As String = "' Region : " & CmbRegion.Text & "    RUTA: " & CmbRuta.Text & "'"

        CmbRegion.Enabled = True
        cmbmes.Enabled = True
        txtAn.Text = Year(Now)
        CmbRuta.Enabled = True
        BtnSalir.Enabled = True
        BtnImprimir.Enabled = True
        LblEspera.Visible = False

        Try ' region y ruta
            Ejecucion("delete from tmpreplecturas;")
            Ejecucion("Insert into tmpreplecturas (`Cuenta`,`comunidad`,`Region`,`Ruta`,`Manzana`,`Lote`,`Lecturista`,`LectAnt`,`Lectura`,`Sit_Med`,`Sit_Pad`,`Sit_Hid`,`Ope_Cap`,`Fec_Cap`, `Consumo`,consumocobrado,`NumLec`, tarifa)  select l.cuenta,v.id_comunidad,v.region,v.ruta,v.manzana,v.lote,l.lecturista,l.lectant,l.lectura,l.sit_med,l.sit_pad,l.sit_hid,l.ope_cap,l.fec_cap,l.consumo,l.consumocobrado,l.numlec, v.tarifa from lecturas l, vusuario v  where l.cuenta=v.cuenta and v.region='" + CmbRegion.SelectedValue + "'" & " and l.ruta='" + CmbRuta.SelectedValue + "'   and l.mes ='" + cmbmes.Text + "'and l.an_per=" + txtAn.Text + "")
            '    Ejecucion("Insert into tmpreplecturas    select l.*  from lecturas l, usuario v  where l.cuenta=v.cuenta and v.region='" + CmbRegion.SelectedValue + "' and v.ruta= '" & CmbRuta.SelectedValue & "' and l.mes='" + cmbmes.Text + "' and l.an_per='" + txtAn.Text + "'")

        Catch ex As Exception
            MessageBoxEx.Show("No existe el archivo para la ruta: " & CmbRuta.Text, "Archivo inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        '     
        Ejecucion("Delete from rptsit")
        Ejecucion("insert into rptsit select count(sit_med), sit_med from tmpreplecturas where sit_med <> '' group by sit_med")
        Ejecucion("insert into rptsit select count(sit_hid), sit_hid from tmpreplecturas where sit_hid <> '' group by sit_hid")
        Ejecucion("insert into rptsit select count(sit_pad), sit_pad from tmpreplecturas where sit_pad <> '' group by sit_pad")



        Dim rpt As New frmReporte()
        Dim objrep As New ReportDocument
        objrep.Load(".\reportes\LecturasCapturadas.rpt")
        Dim servidorreporte As String = My.Settings.servidorreporte
        Dim usuarioreporte As String = My.Settings.usuarioreporte
        Dim passreporte As String = My.Settings.passreporte
        Dim basereporte As String = My.Settings.basereporte

        objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
        objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

        rpt.crvReporte.SelectionFormula = ""
        rpt.crvReporte.ReportSource = objrep


        objrep.DataDefinition.FormulaFields("Titulo").Text = "'LECTURAS CAPTURADAS'"
        objrep.DataDefinition.FormulaFields("Encabezado").Text = Encabezado

        rpt.MdiParent = My.Forms.MDIPrincipal
        rpt.Show()
        rpt.WindowState = FormWindowState.Maximized
        BtnImprimir.Enabled = True
        BtnSalir.Enabled = True
    End Sub
End Class