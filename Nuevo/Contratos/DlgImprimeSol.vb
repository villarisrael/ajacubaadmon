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
        Dim cadsql As String = "select fecha,numero, nombre, colonia,estado from vsolicitud where "
        Dim filtro As String = MC1.SelectedDate.ToString("dd-MM-yyyy") & " AL " & MC2.SelectedDate.ToString("dd-MM-yyyy")
        cadsql += " fecha between '" & UnixDateFormat(MC1.SelectedDate) & "' and '" & UnixDateFormat(MC2.SelectedDate) & "'"


        If CmbComunidades.SelectedIndex >= 0 Then
            filtro += " COMUNIDAD ='" & CmbComunidades.Text & "'"
            cadsql += " And comunidad ='" & CmbComunidades.Text & "'"
        End If
        If cmbEst.SelectedIndex >= 0 Then
            filtro += " ESTADO ='" & cmbEst.Text & "'"
            cadsql += " and estado='" & cmbEst.Text & "'"
            End If
        If CmbColonias.SelectedIndex >= 0 Then

            filtro += " COLONIA ='" & CmbColonias.Text & "'"
            cadsql += " and COLONIA='" & CmbColonias.Text & "'"
        End If




        idtot = ConsultaSql(cadsql).ExecuteReader()

        If idtot.RecordsAffected > 0 Then
            Dim lISTA As New ListadoSolcitudesvb
            lISTA.CreaResumen(cadsql, filtro)



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