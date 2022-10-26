Imports DevComponents.DotNetBar

Public Class FrmCalculaConsumo

    Private Sub FrmCalculaConsumo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.tabFacturacion.Select()
    End Sub

    Private Sub FrmCalculaConsumo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData

        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub FrmCalculaConsumo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FrmCapturaLecturas.Close()
        FrmLecturasCapturadas.Close()
        FrmAgregarLectura.Close()
        'FrmAplicarLecturas.Close()
        frmRepLecturasCapturadas.Close()
        txtAn.Text = Year(Now)

        Try
            llenarCombo(CmdRegion, "select id_region, region from region order by region")
        Catch ex As Exception

        End Try
        WindowState = FormWindowState.Normal
    End Sub



    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click


        If CmdRegion.SelectedIndex = -1 Then
            MessageBoxEx.Show("No especificaste la Region", "Calculo de Consumo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CmdRegion.Select()
            Exit Sub
        End If

        If cmbmes.SelectedIndex < 0 Then
            MessageBoxEx.Show("No especificaste el Mes", "Calculo de Consumo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbmes.Select()
            Exit Sub
        End If

        If txtAn.Text = "" Then
            MessageBoxEx.Show("No especificaste el Año", "Calculo de Consumo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAn.Select()
            Exit Sub
        End If


        CmdRegion.Enabled = False
        BtnCalcular.Enabled = False
        BtnSalir.Enabled = False
        cmbmes.Enabled = False
        txtAn.Enabled = False

        Dim xlnc As New FrmLecturasNoCapturadas
        xlnc.local = Me

        Dim Lectura As New ClsLecturas
        Lectura.Region = CmdRegion.SelectedValue.ToString
        Lectura.mes = cmbmes.Text
        Lectura.periodo = txtAn.Text
        Lectura.ConsumoMes(PB)

        BtnCalcular.Enabled = True
        BtnSalir.Enabled = True
        CmdRegion.Enabled = True
        cmbmes.Enabled = True
        txtAn.Enabled = True

        Close()
    End Sub



    Private Sub CmdRegion_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdRegion.SelectedIndexChanged
        Try
            llenarCombo(CmbRuta, "select id_ruta, ruta from rutas where id_region='" & CmdRegion.SelectedValue & "' order by ruta")
        Catch ex As Exception

        End Try
    End Sub
End Class