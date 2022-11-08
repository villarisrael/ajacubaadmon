Imports CrystalDecisions.CrystalReports.Engine
Imports DevComponents.DotNetBar

Public Class frmRepLecturasnoCapturadas



    Private Sub CmdRegion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbRegion.SelectedIndexChanged
        Try
            llenarCombo(CmbRuta, "select id_ruta, ruta from rutas where id_region = '" & CmbRegion.SelectedValue.ToString & "'  order by ruta")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmRepLecturasnoCapturadas_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.tabFacturacion.Select()
    End Sub

    Private Sub frmRepLecturasnoCapturadas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub frmRepLecturasnoCapturadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        Dim sqlConsulta As String = ""
        'Dim filtro As String = ""

        If CmbRegion.SelectedIndex < 0 Then
            MessageBoxEx.Show("No especificaste la Región", "Reporte de Toma de lecturas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CmbRegion.Select()
            Exit Sub
        End If

        If CmbRuta.SelectedValue < 0 Then
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


        'If filtro.Length > 0 Then
        '    filtro = Mid(filtro, 1, filtro.Length - 4)
        'End If



        'CmbRegion.Enabled = False
        'cmbmes.Enabled = False


        'CmbRuta.Enabled = False
        ''BtnSalir.Enabled = False
        'BtnImprimir.Enabled = False
        'LblEspera.Text = "Espere un momento por favor, se esta generando el reporte"
        'LblEspera.Visible = True

        'Dim Encabezado As String = "' Region : " & CmbRegion.Text & "    RUTA: " & CmbRuta.Text & "'"


        'CmbRegion.Enabled = True
        'cmbmes.Enabled = True
        ''txtAn.Text = Year(Now)
        'CmbRuta.Enabled = True
        'BtnSalir.Enabled = True
        'BtnImprimir.Enabled = True
        'LblEspera.Visible = False


        'Dim rpt As New frmReporte()
        'Dim objrep As New ReportDocument
        'objrep.Load(".\reportes\LecturasCapturadas.rpt")
        'rpt.crvReporte.SelectionFormula = filtro
        'rpt.crvReporte.ReportSource = objrep

        'objrep.DataDefinition.FormulaFields("Titulo").Text = "'LECTURAS CAPTURADAS'"
        'objrep.DataDefinition.FormulaFields("Encabezado").Text = Encabezado

        'rpt.MdiParent = My.Forms.MDIPrincipal
        'rpt.Show()
        'rpt.WindowState = FormWindowState.Maximized
        'BtnImprimir.Enabled = True
        'BtnSalir.Enabled = True


        Try
            Ejecucion("Delete from repusuario")
            Ejecucion("insert into repusuario select cuenta, nombre, Domicilio, nodemedidor, ruta, manzana, lote from usuario as u, cuotas as c where  u.tarifa = c.id_tarifa and c.medido <> 0 and u.region = '" & CmbRegion.SelectedValue & "' and u.ruta = '" & CmbRuta.SelectedValue & "' and (cuenta not in (select cuenta from Lecturas where mes='" & cmbmes.Text & "' and an_per=" & txtAn.Text & "))")
        Catch ex As Exception
            ' messagebox.Show(ex.Message)
        End Try
        Dim Titulo As String = "'REGION: " & CmbRegion.SelectedValue & " RUTA: " & CmbRuta.SelectedValue & "'"


        sqlConsulta = $"Select cuenta, nombre, domicilio from usuario  inner join cuotas On usuario.tarifa=cuotas.id_tarifa where  cuotas.medido=1 And  region = '{CmbRegion.SelectedValue}' and ruta = '{CmbRuta.SelectedValue}'  and cuenta not in (Select LECTURAS.cuenta from lecturas INNER JOIN USUARIO On lecturas.cuenta=usuario.cuenta   where lecturas.mes = '{cmbmes.Text}' And lecturas.an_per=2022 And usuario.region = '{CmbRegion.SelectedValue}' and usuario.ruta = '{CmbRuta.SelectedValue}')"


        Dim objReporte As New ReporteLecturasNoCaptuadas
        objReporte.GenerarReporteLecturasNoCapturadas(sqlConsulta, Titulo)

        'Dim rep As New frmReporte(frmReporte.Lista.LecNoCapturadas, "", "Titulo, " & Titulo)
        'rep.MdiParent = MDIPrincipal
        'rep.Show()
        'rep.WindowState = FormWindowState.Maximized





    End Sub
End Class