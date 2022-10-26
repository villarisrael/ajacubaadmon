Imports DevComponents.DotNetBar

Public Class frmImpOrdC

    Private Sub frmImpOrdC_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.RBCis.Select()
    End Sub

    Private Sub frmImpOrdC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MC1.DisplayMonth = Now.Date
        MC1.SelectedDate = Now.Date
        MC2.DisplayMonth = Now.Date
        MC2.SelectedDate = Now.Date

        llenarCombo(cmbTrab, "select idtrab, nombre from trabajadores order by nombre")
        rbTod.Checked = True
    End Sub

    Private Sub rbEm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEm.CheckedChanged
        If Not rbEm.Checked Then
            cmbTrab.Visible = False
        End If
    End Sub

    Private Sub rbTod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTod.CheckedChanged
        If rbEm.Checked Then
            cmbTrab.Visible = True
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmbTrab_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTrab.KeyPress
        cmbTrab.DroppedDown = True
    End Sub

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        Dim frmrep As New frmReporte()
        If rbTod.Checked Then
            frmrep = New frmReporte(frmReporte.Lista.Grafica_Calidad, "{ordent1.fec_res}>=cdate('" & UnixDateFormat(MC1.SelectedDate) & "') and {ordent1.fec_res}<=cdate('" & UnixDateFormat(MC2.SelectedDate) & "')")
        Else

            If cmbTrab.Text = "" Then
                MessageBoxEx.Show("Especifique el trabajador, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            frmrep = New frmReporte(frmReporte.Lista.Grafica_Calidad, "{ordent1.fec_res}>=cdate('" & UnixDateFormat(MC1.SelectedDate) & "') and {ordent1.fec_res}<=cdate('" & UnixDateFormat(MC2.SelectedDate) & "') and {ordent1.cod_rel}='" & cmbTrab.SelectedValue.ToString & "'")
        End If
        frmrep.MdiParent = My.Forms.MDIPrincipal
        frmrep.Show()
        frmrep.WindowState = FormWindowState.Maximized
        Me.Close()
    End Sub
End Class
