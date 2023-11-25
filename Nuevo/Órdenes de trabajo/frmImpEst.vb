Public Class frmImpEst
    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        cmdImp.Text = "IMPRIMIENDO..."
        cmdImp.Enabled = False

        Dim frmrep As New frmReporte()
        If Not chkDet.Checked Then
            'If cmbDirec.SelectedValue = Nothing Then
            '    frmrep = New frmReporte(frmReporte.Lista.Estadistica_Tipo_Queja, "{vordent1.fec_ord}>=cdate('" & UnixDateFormat(MC1.SelectedDate) & "') and {vordent1.fec_ord}<=cdate('" & UnixDateFormat(MC2.SelectedDate) & "') and {vordent1.status}<> 'CANCELADA'", "FECINI, '" & MC1.SelectedDate & "'", "FECFIN, '" & MC2.SelectedDate & "'")
            'Else
            If cmbDep.SelectedValue = Nothing Then
                'frmrep = New frmReporte(frmReporte.Lista.Estadistica_Tipo_Queja, "{vordent1.fec_ord}>=cdate('" & UnixDateFormat(MC1.SelectedDate) & "') and {vordent1.fec_ord}<=cdate('" & UnixDateFormat(MC2.SelectedDate) & "') and {vordent1.cod_dir}='" & cmbDirec.SelectedValue.ToString & "' and {vordent1.status}<> 'CANCELADA'", "FECINI, '" & MC1.SelectedDate & "'", "FECFIN, '" & MC2.SelectedDate & "'")

                Dim objReporte As New ReportesOrdenTrabajo()
                objReporte.GenerarReporteTipoQueja(MC1.SelectedDate, MC2.SelectedDate, cmbDirec.SelectedValue.ToString)

            Else
                'frmrep = New frmReporte(frmReporte.Lista.Estadistica_Tipo_Queja, "{vordent1.fec_ord}>=cdate('" & UnixDateFormat(MC1.SelectedDate) & "') and {vordent1.fec_ord}<=cdate('" & UnixDateFormat(MC2.SelectedDate) & "') and {vordent1.cod_dir}='" & cmbDirec.SelectedValue.ToString & "' and {vordent1.cod_res}='" & cmbDep.SelectedValue.ToString & "' and {vordent1.status}<> 'CANCELADA'", "FECINI, '" & MC1.SelectedDate & "'", "FECFIN, '" & MC2.SelectedDate & "'")

                Dim objReporte As New ReportesOrdenTrabajo()
                objReporte.GenerarReporteTipoQueja(MC1.SelectedDate, MC2.SelectedDate, cmbDirec.SelectedValue.ToString, cmbDep.SelectedValue.ToString)

            End If

            'End If
        Else
            If cmbDep.SelectedValue = Nothing Then
                'frmrep = New frmReporte(frmReporte.Lista.Estadistica_Tipo_Queja_Det, "{vordent1.fec_ord}>=cdate('" & UnixDateFormat(MC1.SelectedDate) & "') and {vordent1.fec_ord}<=cdate('" & UnixDateFormat(MC2.SelectedDate) & "') and {vordent1.status}<> 'CANCELADA'", "FECINI, '" & MC1.SelectedDate & "'", "FECFIN, '" & MC2.SelectedDate & "'")

                Dim objReporte As New ReportesOrdenTrabajo()
                objReporte.GenerarReporteTipoQueja(MC1.SelectedDate, MC2.SelectedDate, cmbDirec.SelectedValue.ToString, True)

            Else
                'frmrep = New frmReporte(frmReporte.Lista.Estadistica_Tipo_Queja_Det, "{vordent1.fec_ord}>=cdate('" & UnixDateFormat(MC1.SelectedDate) & "') and {vordent1.fec_ord}<=cdate('" & UnixDateFormat(MC2.SelectedDate) & "') and {vordent1.cod_res}='" & cmbDep.SelectedValue.ToString & "' and {vordent1.status}<> 'CANCELADA'", "FECINI, '" & MC1.SelectedDate & "'", "FECFIN, '" & MC2.SelectedDate & "'")

                Dim objReporte As New ReportesOrdenTrabajo()
                objReporte.GenerarReporteTipoQueja(MC1.SelectedDate, MC2.SelectedDate, cmbDirec.SelectedValue.ToString, cmbDep.SelectedValue.ToString, True)

            End If
        End If

        'frmrep.MdiParent = My.Forms.MDIPrincipal
        'frmrep.Show()
        'frmrep.WindowState = FormWindowState.Maximized
        Me.Close()
    End Sub

    Private Sub frmImpEst_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.RBCis.Select()

    End Sub

    Private Sub frmImpEst_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData

        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub frmImpEst_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MC1.DisplayMonth = Now.Date
        MC1.SelectedDate = Now.Date
        MC2.DisplayMonth = Now.Date
        MC2.SelectedDate = Now.Date

        llenarCombo(cmbDirec, "select cod_dir, nombre from direc order by nombre")
    End Sub
    Private Sub cmdImp_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdImp.GotFocus
        cmdImp.Pulse()
        cmdImp.StopPulseOnMouseOver = False
    End Sub
    Private Sub cmdImp_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdImp.LostFocus
        cmdImp.StopPulse()
    End Sub
    Private Sub cmdCancel_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.GotFocus
        cmdImp.Pulse()
        cmdImp.StopPulseOnMouseOver = False
    End Sub
    Private Sub cmdCancel_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.LostFocus
        cmdImp.StopPulse()
    End Sub
    Private Sub cmbDirec_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbDirec.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
    Private Sub cmbDirec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDirec.SelectedIndexChanged
        If Not cmbDirec.SelectedValue Is Nothing AndAlso cmbDirec.SelectedValue.ToString <> "System.Data.DataRowView" Then
            llenarCombo(cmbDep, "select cod_dep, nombre from deptos where cod_dir='" & cmbDirec.SelectedValue.ToString & "' order by nombre")
        End If
    End Sub
    Private Sub cmbDep_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbDep.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
End Class