Public Class FrmCierraCaja
    Dim FolFin As Double
    Dim Caja, Oficina, Tip_Caja As String
    Private Sub FrmCierraCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim IrCaja As IDataReader = ConsultaSql("Select * from croape where maquina = '" & My.Computer.Name & "' and fec_ape = '" & UnixDateFormat(Now) & "' and statusa = 'A'").ExecuteReader
        If IrCaja.Read Then
            frmCajas.Close()
            Caja = IrCaja("caja")
            Oficina = IrCaja("Cod_ofi")
            LblCaja.Text = obtenerCampo("Select descripcion from cajas where cod_ofi = '" & IrCaja("caja") & "'", "Descripcion")
            LblOficina.Text = obtenerCampo("Select nombre from oficinas where cod_ofi = '" & IrCaja("cod_ofi") & "'", "nombre")
            LblFecha.Text = Now.Date
            LblIngresos.Text = FormatCurrency(obtenerCampo("select sum(total) as tot from pagos where cod_ofi='" & IrCaja("cod_ofi") & "' and id_caja='" & IrCaja("caja") & "' and fecha_act='" & UnixDateFormat(Now) & "' and cancelado='A'", "tot"), 2) 'FormatCurrency(IrCaja("ing_tot"), 2)
            LblOperaciones.Text = IrCaja("num_ope")
            FolFin = IrCaja("Fol_Fin")
            Tip_Caja = IrCaja("Tcaja")
        Else
            MessageBoxEx.Show("No ha realizado ninguna apertura de caja el dia de hoy", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub Hora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hora.Tick
        LblHora.Text = TimeString
    End Sub

    Private Sub cmdCance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCance.Click
        Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If MessageBoxEx.Show("¿Desea cerrar cajas?, Recuerde que no podrá abrirla hasta el día de mañana", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Ejecucion("update croape set fec_cie= '" & UnixDateFormat(Now) & "', hor_cie='" & TimeString & "', caj_cie='" & NumUser & "', statusa='C' WHERE cod_ofi='" & Oficina & "' and caja='" & Caja & "' and FEC_APE='" & UnixDateFormat(Now) & "'")
            Ejecucion("update cajas set folio=" & FolFin & " where id_caja='" & Caja & "' and cod_ofi='" & Oficina & "'")
            If Tip_Caja = "Remota" Then
                'EjecucionDbase("update croape set fec_cie= '" & Now.Date & "', hor_cie='" & TimeString & "', caj_cie='" & NumUser & "', ing_tot=" & _ing_tot & ", statusa='C'  WHERE cod_ofi='" & cmbOfi.SelectedValue.ToString & "' and caja='" & cmbCaja.SelectedValue.ToString & "' and FEC_APE=" & fec_ape & " ")
                'EjecucionDbase("update cajas set folio=" & txtFolioIni.Text & ", remanente=" & txtSalIni.Text & " where id_caja='" & cmbCaja.SelectedValue.ToString & "' and cod_ofi='" & cmbCaja.SelectedValue.ToString & "'")
                GuardarTxt("update croape set fec_cie= '" & UnixDateFormat(Now) & "', hor_cie='" & TimeString & "', caj_cie='" & NumUser & "', statusa='C' WHERE cod_ofi='" & Oficina & "' and caja='" & Caja & "' and FEC_APE='" & UnixDateFormat(Now) & "'")
                GuardarTxt("update cajas set folio=" & FolFin & " where id_caja='" & Caja & "' and cod_ofi='" & Oficina & "'")
            End If
            crea_detallecierre()
            Close()
        End If
    End Sub
End Class