Public Class frmImpEstC

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        Dim frmrep As New frmReporte()
        If Not chkDetalle.Checked Then
            frmrep = New frmReporte(frmReporte.Lista.Estadistica_de_Calidad, "{vordent1.fec_ord}>=cdate('" & UnixDateFormat(MC1.SelectedDate) & "') and {vordent1.fec_ord}<=cdate('" & UnixDateFormat(MC2.SelectedDate) & "') and {vordent1.status} <> 'CANCELADA' and not isnull({vordent1.FEC_RES})", "FECINI, '" & MC1.SelectedDate & "'", "FECFIN, '" & MC2.SelectedDate & "'")
        Else
            frmrep = New frmReporte(frmReporte.Lista.Estadistica_de_Calidad_Det, "{vordent1.fec_ord}>=cdate('" & UnixDateFormat(MC1.SelectedDate) & "') and {vordent1.fec_ord}<=cdate('" & UnixDateFormat(MC2.SelectedDate) & "') and {vordent1.status} <> 'CANCELADA' and not isnull({vordent1.FEC_RES})", "FECINI, '" & MC1.SelectedDate & "'", "FECFIN, '" & MC2.SelectedDate & "'")

        End If
        frmrep.MdiParent = My.Forms.MDIPrincipal
        frmrep.Show()
        frmrep.WindowState = FormWindowState.Maximized
        Me.Close()
    End Sub

    Private Sub frmImpEstC_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.RBCis.Select()

    End Sub

    Private Sub frmImpEstC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyaskii As Keys = e.KeyData
        Select Case keyaskii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select

    End Sub

    Private Sub frmImpEstC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MC1.DisplayMonth = Now.Date
        MC1.SelectedDate = Now.Date
        MC2.DisplayMonth = Now.Date
        MC2.SelectedDate = Now.Date
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Close()
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
End Class