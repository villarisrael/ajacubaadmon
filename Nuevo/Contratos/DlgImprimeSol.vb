Public Class DlgImprimeSol
    Private cargo As Boolean = False
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Close()
    End Sub
    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
            cmdImp.Text = "IMPRIMIENDO... "
        cmdImp.Enabled = False
        Dim frm As frmReporte = Nothing
        Dim idtot As IDataReader = Nothing
        Dim cadsql As String = "select count(*) as tot from vsolicitud where "

        If CmbComunidades.Text = "" And CmbColonias.Text = "" Then

            If cmbEst.Text = "" Then
                frm = New frmReporte(frmReporte.Lista.ListadoSolicitudes, "{vsolicitud1.fecha} >= cdate('" & UnixDateFormat(MC1.SelectedDate) & "') and {vsolicitud1.fecha} <= cdate('" & UnixDateFormat(MC2.SelectedDate) & "') ", "FECINI, '" & MC1.SelectedDate.Date & "'", "FECFIN, '" & MC2.SelectedDate.Date & "'")
                cadsql += " fecha between '" & UnixDateFormat(MC1.SelectedDate) & "' and '" & UnixDateFormat(MC2.SelectedDate) & "'"
            Else
                frm = New frmReporte(frmReporte.Lista.ListadoSolicitudes, "{vsolicitud1.fecha} >= cdate('" & UnixDateFormat(MC1.SelectedDate) & "') and {vsolicitud1.fecha} <= cdate('" & UnixDateFormat(MC2.SelectedDate) & "') and {vsolicitud1.estado}='" & cmbEst.Text & "'", "FECINI, '" & MC1.SelectedDate.Date & "'", "FECFIN, '" & MC2.SelectedDate.Date & "'")
                cadsql += " fecha between '" & UnixDateFormat(MC1.SelectedDate) & "' and '" & UnixDateFormat(MC2.SelectedDate) & "' and estado='" & cmbEst.Text & "'"
            End If




        ElseIf CmbComunidades.Text <> "" And CmbColonias.Text = "" Then

            If cmbEst.Text = "" Then
                frm = New frmReporte(frmReporte.Lista.ListadoSolicitudes, "{vsolicitud1.comunidad} = '" & CmbComunidades.Text & "' and {vsolicitud1.fecha} >= cdate('" & UnixDateFormat(MC1.SelectedDate) & "') and {vsolicitud1.fecha} <= cdate('" & UnixDateFormat(MC2.SelectedDate) & "')", "FECINI, '" & MC1.SelectedDate.Date & "'", "FECFIN, '" & MC2.SelectedDate.Date & "'")
                cadsql += " fecha between '" & UnixDateFormat(MC1.SelectedDate) & "' and '" & UnixDateFormat(MC2.SelectedDate) & "' and comunidad='" & CmbComunidades.Text & "'"
            Else
                frm = New frmReporte(frmReporte.Lista.ListadoSolicitudes, "{vsolicitud1.comunidad} = '" & CmbComunidades.Text & "' and {vsolicitud1.fecha} >= cdate('" & UnixDateFormat(MC1.SelectedDate) & "') and {vsolicitud1.fecha} <= cdate('" & UnixDateFormat(MC2.SelectedDate) & "') and {vsolicitud1.estado}='" & cmbEst.Text & "'", "FECINI, '" & MC1.SelectedDate.Date & "'", "FECFIN, '" & MC2.SelectedDate.Date & "'")
                cadsql += " fecha between '" & UnixDateFormat(MC1.SelectedDate) & "' and '" & UnixDateFormat(MC2.SelectedDate) & "' and comunidad='" & CmbComunidades.Text & "' and estado='" & cmbEst.Text & "'"
            End If

        ElseIf CmbComunidades.Text <> "" And CmbColonias.Text <> "" Then
            If cmbEst.Text = "" Then
                frm = New frmReporte(frmReporte.Lista.ListadoSolicitudes, "{vsolicitud1.comunidad} = '" & CmbComunidades.Text & "' and {vsolicitud1.colonia} = '" & CmbColonias.Text & "' and {vsolicitud1.fecha} >= cdate('" & UnixDateFormat(MC1.SelectedDate) & "') and {vsolicitud1.fecha} <= cdate('" & UnixDateFormat(MC2.SelectedDate) & "')", "FECINI, '" & MC1.SelectedDate.Date & "'", "FECFIN, '" & MC2.SelectedDate.Date & "'")
                cadsql += " fecha between '" & UnixDateFormat(MC1.SelectedDate) & "' and '" & UnixDateFormat(MC2.SelectedDate) & "' and comunidad='" & CmbComunidades.Text & "' and colonia='" & CmbColonias.Text & "'"
            Else
                frm = New frmReporte(frmReporte.Lista.ListadoSolicitudes, "{vsolicitud1.comunidad} = '" & CmbComunidades.Text & "' and {vsolicitud1.colonia} = '" & CmbColonias.Text & "' and {vsolicitud1.fecha} >= cdate('" & UnixDateFormat(MC1.SelectedDate) & "') and {vsolicitud1.fecha} <= cdate('" & UnixDateFormat(MC2.SelectedDate) & "') and {vsolicitud1.estado}='" & cmbEst.Text & "'", "FECINI, '" & MC1.SelectedDate.Date & "'", "FECFIN, '" & MC2.SelectedDate.Date & "'")
                cadsql += " fecha between '" & UnixDateFormat(MC1.SelectedDate) & "' and '" & UnixDateFormat(MC2.SelectedDate) & "' and comunidad='" & CmbComunidades.Text & "' and colonia='" & CmbColonias.Text & "' and estado='" & cmbEst.Text & "'"
            End If
        ElseIf CmbComunidades.SelectedIndex = -1 And CmbColonias.SelectedIndex >= 0 Then
            frm = New frmReporte(frmReporte.Lista.ListadoSolicitudes, "{vsolicitud1.colonia} = '" & CmbColonias.Text & "' and {vsolicitud1.fecha} >= cdate('" & UnixDateFormat(MC1.SelectedDate) & "') and {vsolicitud1.fecha} <= cdate('" & UnixDateFormat(MC2.SelectedDate) & "')", "FECINI, '" & MC1.SelectedDate.Date & "'", "FECFIN, '" & MC2.SelectedDate.Date & "'")
            cadsql += " fecha between '" & UnixDateFormat(MC1.SelectedDate) & "' and '" & UnixDateFormat(MC2.SelectedDate) & "'  and colonia='" & CmbColonias.Text & "'"

        End If

        idtot = ConsultaSql(cadsql).ExecuteReader()
        idtot.Read()
        If idtot("tot") > 0 Then
            frm.MdiParent = MDIPrincipal
            frm.Show()
            frm.WindowState = FormWindowState.Maximized
        Else
            MessageBox.Show("No existen datos para esta consulta", "Solicitudes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        cmdImp.Enabled = True
        cmdImp.Text = "IMPRIMIR"
        'Close()
    End Sub


    Private Sub DlgImprimeSol_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Dim keyascii As Keys = e.KeyData

        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub DlgImprimeSol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargo = False
        MC1.SelectedDate = Now
        MC1.DisplayMonth = Now
        MC2.SelectedDate = Now
        MC2.DisplayMonth = Now
        llenarCombo(CmbComunidades, "Select id_comunidad, Comunidad from comunidades")
        llenarCombo(CmbColonias, "Select id_colonia, colonia from colonia order by colonia")
        llenarCombo(cmbEst, "est", "select distinct(estadosolicitud) as est from solicitud order by estadosolicitud")
        cargo = True
    End Sub

    Private Sub CmbComunidades_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbComunidades.KeyPress
        DespliegaCombo(CmbComunidades, e)
    End Sub
    Private Sub CmbComunidades_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbComunidades.SelectedIndexChanged
        If Not CmbComunidades.SelectedValue Is Nothing AndAlso cargo Then
            llenarCombo(CmbColonias, "Select id_colonia, Colonia from colonia where id_comunidad = '" & CmbComunidades.SelectedValue.ToString & "'")
        End If

    End Sub

    Private Sub CmbColonias_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbColonias.KeyPress
        DespliegaCombo(CmbColonias, e)
    End Sub
    Private Sub cmdImp_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdImp.GotFocus
        cmdImp.Pulse()
        cmdImp.StopPulseOnMouseOver = False
    End Sub
    Private Sub cmdImp_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdImp.LostFocus
        cmdImp.StopPulse()
    End Sub
    Private Sub cmdCancel_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.GotFocus
        cmdCancel.Pulse()
        cmdCancel.StopPulseOnMouseOver = False
    End Sub
    Private Sub cmdCancel_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.LostFocus
        cmdCancel.StopPulse()
    End Sub

    Private Sub cmbEst_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbEst.KeyPress
        DespliegaCombo(cmbEst, e)
    End Sub

End Class