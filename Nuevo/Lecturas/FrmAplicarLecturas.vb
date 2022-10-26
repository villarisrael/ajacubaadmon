Imports DevComponents.DotNetBar

Public Class FrmAplicarLecturas

    Private Sub FrmAplicarLecturas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData

        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub FrmAplicarLecturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCombo(CmbComunidad, "Select id_comunidad, comunidad from comunidades")
        CmbComunidad.SelectedIndex = -1
        DTMES.Value = DateAdd(DateInterval.Month, -1, Now)
        'MCMes.SelectedDate = Now
        'MCMes.DisplayMonth = Now
    End Sub

    Private Sub CmbComunidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbComunidad.SelectedIndexChanged
        Try
            llenarCombo(CmdRegion, "select id_region, region from region where id_comunidad = '" & CmbComunidad.SelectedValue.ToString & "' order by region")
            CmdRegion.SelectedIndex = -1
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAplicar.Click
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
        BtnAplicar.Enabled = False
        BtnSalir.Enabled = False
        Dim Lectura As New ClsLecturas
        Lectura.Comunidad = CmbComunidad.SelectedValue.ToString
        Lectura.Region = CmdRegion.SelectedValue.ToString
        'Lectura.Periodo = DTMES.Value
        ' Lectura.AplicarLectura()
        BtnAplicar.Enabled = True
        BtnSalir.Enabled = True
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

End Class