Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmAvisosPago

    Private Sub BtnSalir_Click(sender As System.Object, e As System.EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub FrmAvisosPago_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            llenarCombo(CmdRegion, "select id_region, region from region order by region")
        Catch ex As Exception

        End Try
        Try
            llenarCombo(cmbComunidades, "SELECT id_colonia,Colonia FROM Colonia")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click

        Dim filtro As String


        If rbruta.Checked Then
            If CmdRegion.SelectedIndex = -1 And CmbRuta.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione los Region y Ruta para Continuar")
                CmdRegion.Focus()
                CmbRuta.Focus()
            Else
                filtro = "{usuario1.region} = '" & CmdRegion.SelectedValue.ToString & "' and {usuario1.ruta} = '" & CmbRuta.SelectedValue.ToString & "' and {usuario1.periodosadeudo}>2"
            End If
        End If

        If rbComunidad.Checked Then
            If cmbComunidades.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione la Colonia para Continuar")
                cmbComunidades.Focus()
            Else
                filtro = "{usuario1.id_colonia} = '" & cmbComunidades.SelectedValue.ToString & "'"
            End If
        End If


        If rbCuenta.Checked Then
            If iiCuenta.Text = "" Then
                MessageBox.Show("Escriba el Numero de Cuenta para Continuar")
                cmbComunidades.Focus()
            Else
                filtro = "{usuario1.cuenta} = " & iiCuenta.Text.ToString & ""
            End If
        End If

        BtnCalcular.Enabled = False
        Using reporte As New ReportDocument()

            reporte.Load(AppPath() & ".\Reportes\AvisosPago.rpt")

            Dim servidorreporte As String = My.Settings.servidorreporte
            Dim usuarioreporte As String = My.Settings.usuarioreporte
            Dim passreporte As String = My.Settings.passreporte
            Dim basereporte As String = My.Settings.basereporte

            reporte.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
            reporte.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

            reporte.RecordSelectionFormula = filtro

            'ENVIar TEXTO EN ESPECIFICO JIJIJIJIJ
            reporte.DataDefinition.FormulaFields.Item("Mensaje").Text = "'" & txtMensaje.Text & "'"
            '  reporte.DataDefinition.FormulaFields.Item("Colonia").Text = "'" & cmbcolonia.Text & "'"

            Dim x As New FrmReporteOrden
            x.crystalReportViewer1.ReportSource = reporte
            x.Show()
        End Using

        BtnCalcular.Enabled = True


    End Sub

    Private Sub txtMensaje_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtMensaje.MouseClick
        txtMensaje.ResetText()
    End Sub

    Private Sub chktodascolonia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmdRegion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdRegion.SelectedIndexChanged
        Try
            llenarCombo(CmbRuta, "select id_ruta, ruta from rutas where id_region='" & CmdRegion.SelectedValue & "' order by ruta")
        Catch ex As Exception

        End Try
    End Sub
End Class